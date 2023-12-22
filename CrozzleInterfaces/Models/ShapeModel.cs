namespace CrozzleInterfaces;

public record struct ShapeModel
{
	public readonly byte Width;
	public readonly byte Height;
	public readonly ushort Score;
	public readonly List<PlacementModel> Placements;
    public readonly string WordSequence;

    public List<int> History;
    public bool IsValid;

		public ShapeModel(ushort score, byte width, byte height, in List<PlacementModel> placements)
		{
        this.IsValid = true;
        this.Score = score;
        this.History = new List<int>();


        var sortedPlacements = PlacementList.SortByWord(placements);

        if (PlacementList.ShouldBeFlipped(sortedPlacements))
        {
            // We are flipping the shape as it makes GetWordSequence for all shapes same orientation
            var flippedPlacements = PlacementList.Flip(sortedPlacements);

            this.Width = height;
            this.Height = width;
            this.Placements = flippedPlacements;
            this.WordSequence = PlacementList.GetWordSequence(flippedPlacements);
        }
        else {
            this.Width = width;
            this.Height = height;
            this.Placements = sortedPlacements;
            this.WordSequence = PlacementList.GetWordSequence(sortedPlacements);
        }            
		}

    public void SetToInvalid()
    {
        IsValid = false;
    }

    public static List<int> CreateMergeHistory(
        in List<int> sourceShapeHistory,
        in List<int> searchShapeHistory)
    {
        if (sourceShapeHistory.Count == 1 && searchShapeHistory.Count == 1)
        {
            var source = sourceShapeHistory[0];
            var search = searchShapeHistory[0];
            if (source < search)
            {
                return new List<int> { source, search };
            }
            else
            {
                return new List<int> { search, source };
            }
        }
        // I think we should add to the source shape history rather than adding the larger one to the smaller one.  See if this makes a difference.
        sourceShapeHistory.AddRange(searchShapeHistory);
        return sourceShapeHistory;
        //else if (sourceShapeHistory.Count > searchShapeHistory.Count)
        //{
        //    sourceShapeHistory.AddRange(searchShapeHistory);
        //    return sourceShapeHistory;
        //}
        //else
        //{
        //    searchShapeHistory.AddRange(sourceShapeHistory);
        //    return searchShapeHistory;
        //}
    }

    public string ToCSharpCode()
    {
        var code = "";

        code += PlacementsToCSharp(placements: Placements) + "\n";

        code += $"var shape = new ShapeModel(score: {Score}, width: {Width}, height: {Height}, placements: placements);";

        return code;
    }
    public static string PlacementsToCSharp(List<PlacementModel> placements)  {
        var code = "";
    
        foreach (var placement in placements) {
            if (code != "") {
                code += ",\n";
            }
            code += "        " + PlacementToCSharp(placement: placement);
        }

        var result = "let placements = new List<PlacementModel> {\n" + code + "\n    };";
        return result;
    }
    public static String PlacementToCSharp(PlacementModel placement)
    {
        var horizontal = "true";
        if (placement.Z == false)
        {
            horizontal = "false";
        }
        return $"new PlacementModel(w: {placement.W}, x: {placement.X}, y: {placement.Y}, z: {horizontal}, l:{placement.L})";
    }


    public string ToSwiftCode()
    {
        var code = "";

        code += PlacementsToSwift(placements: Placements) + "\n";

        code += $"let shape = ShapeModel(score: {Score}, width: {Width}, height: {Height}, placements: placements)";

        return code;
    }
    public static string PlacementsToSwift(List<PlacementModel> placements)
    {
        var code = "";

        foreach (var placement in placements)
        {
            if (code != "")
            {
                code += ",\n        ";
            }
            code += "" + PlacementToSwift(placement: placement);
        }

        var result = "let placements = [\n        " + code + "\n    ]";
        return result;
    }
    public static String PlacementToSwift(PlacementModel placement)
    {
        var horizontal = "true";
        if (placement.Z == false)
        {
            horizontal = "false";
        }
        return $"PlacementModel(w: {placement.W}, x: {placement.X}, y: {placement.Y}, z: {horizontal}, l:{placement.L})";
    }

    /// rotate a shape and return a rotated shape which means width becomes height and all placements are rearranged
    public ShapeModel Flip()
    {
        var placements = new List<PlacementModel>();

        foreach (var p in this.Placements)
        {
            placements.Add(new PlacementModel(w: p.W, x: p.Y, y: p.X, z: !p.Z, l: p.L));
        }

        var result = new ShapeModel(score: this.Score, width: this.Height, height: this.Width, placements: placements);
        return result;
    }

    public String ToTextArray(in List<string> words)
    {
        var lines = ToTextDebug(words).Split("\n");
        string result = "";
        foreach(var line in lines)
        {
            if (result != "")
            {
                result += ",\n";
            }
            result += "\"" + line + "\"";
        }
        
        return "[\n" + result + "\n]";
    }



    public String ToTextDebug(in List<string> words)
    {
        int score = 0;

        int widthEOL = (int)this.Width + 1;
        int height = (int)this.Height;

        int gridSize = widthEOL * height;

        var grid = new List<char>();
        grid.Capacity = gridSize;
        for (int i = 0; i < gridSize; i++)
        {
            grid.Add(' ');
        }


        // Place all end of line characters into the space
        for (int i = 0; i < height; i++)
        {
            grid[i * widthEOL] = '\n';
        }

        foreach (var placement in this.Placements)
        {

            // the word must include the blocking characters at either end of the shape
            var word = "." + words[(int)placement.W] + ".";

            int gridPos = 0;

            for (int i = 0; i < word.Length; i++)
            {
                char letter = word[i];

                if (placement.Z)
                {
                    gridPos = (int)placement.X + i + (int)placement.Y * widthEOL + 1;
                }
                else
                {
                    gridPos = (int)placement.X + 1 + (int)(placement.Y + i) * widthEOL;
                }

                if (grid[gridPos] != ' ' && grid[gridPos] != letter)
                {
                    grid[gridPos] = '#';
                }
                else if (grid[gridPos] == ' ')
                {
                    grid[gridPos] = letter;
                }
                else if (grid[gridPos] == letter)
                {
                    // score += ScoreCalculator.score(letter);
                }
            }
        }

        var result = "";
        for (int i = 1; i < gridSize; i++)
        {
            result += grid[i];
        }

        if (result.Contains('#'))
        {
            score = 0;
        }
        else
        {
            score += this.Placements.Count * 10;
        }

        return result;
    }

    public List<int> GetWordIds()
    {
        return PlacementList.GetWords(this.Placements);
    }

    public HashSet<int> GetHashSetWordIds()
    {
        return new HashSet<int>(PlacementList.GetWords(this.Placements));
    }
}

