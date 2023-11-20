using CrozzleInterfaces;

namespace CrozzleShapeMaker;

public class SpecialShapesCalculator
{
    // These shape values come from /Users/michaelgeurtjens/Downloads/CrozzleDataFromWinningGames/*.json
    public static List<ShapeModel> C8703(in List<string> words)
    {
        var h = new List<string> { "JIFFY", "LATE", "ALWAYS" };
        var v = new List<string> { "DAILY", "FAST", "OFT", "YEAR" };

        var hid = WordList.ExtractPositions(words, h);
        var vid = WordList.ExtractPositions(words, v);

        var hl = WordList.LengthsInBytes(h);
        var vl = WordList.LengthsInBytes(v);

        var placements = new List<PlacementModel> {
            new PlacementModel(w: hid[0], x: 3, y: 3, z: true, l: hl[0]),
            new PlacementModel(w: hid[1], x: 4, y: 4, z: true, l: hl[1]),
            new PlacementModel(w: hid[2], x: 0, y: 5, z: true, l: hl[2]),

            new PlacementModel(w: vid[0], x: 5, y: 0, z: false, l: vl[0]),
            new PlacementModel(w: vid[1], x: 6, y: 2, z: false, l: vl[1]),
            new PlacementModel(w: vid[2], x: 7, y: 1, z: false, l: vl[2]),
            new PlacementModel(w: vid[3], x: 8, y: 2, z: false, l: vl[3])
        };

        var shape = new ShapeModel(score: 182, width: 10, height: 8, placements: placements);

        return new List<ShapeModel> { shape };
    }


    public static List<ShapeModel> C8805(in List<string> words)
    {
        var h = new List<string> { "WOOL", "MEAT", "TANK", "HARVEST" };
        var v = new List<string> { "EWE", "OATS", "ROTATION" };

        var hid = WordList.ExtractPositions(words, h);
        var vid = WordList.ExtractPositions(words, v);

        var hl = WordList.LengthsInBytes(h);
        var vl = WordList.LengthsInBytes(v);

        var placements = new List<PlacementModel> {
            new PlacementModel(w: hid[0], x: 4, y: 2, z: true, l: hl[0]),
            new PlacementModel(w: hid[1], x: 3, y: 3, z: true, l: hl[1]),
            new PlacementModel(w: hid[2], x: 5, y: 4, z: true, l: hl[2]),
            new PlacementModel(w: hid[3], x: 0, y: 5, z: true, l: hl[3]),

            new PlacementModel(w: vid[0], x: 5, y: 0, z: false, l: vl[0]),
            new PlacementModel(w: vid[1], x: 6, y: 1, z: false, l: vl[1]),
            new PlacementModel(w: vid[2], x: 7, y: 0, z: false, l: vl[2])
        };

        var shape = new ShapeModel(width: 11, height: 10, score: 172, placements: placements);

        return new List<ShapeModel> { shape };
    }

    public static List<ShapeModel> C9002a(in List<string> words)
    {
        var h = new List<string> { "NEPTUNE", "MARS", "JUNO" };
        var v = new List<string> { "REMUS", "PAN", "TROY", "URANUS" };

        var hid = WordList.ExtractPositions(words, h);
        var vid = WordList.ExtractPositions(words, v);

        var hl = WordList.LengthsInBytes(h);
        var vl = WordList.LengthsInBytes(v);

        var placements = new List<PlacementModel> {
            new PlacementModel(w: hid[0], x: 0, y: 5, z: true, l: hl[0]),
            new PlacementModel(w: hid[1], x: 1, y: 6, z: true, l: hl[1]),
            new PlacementModel(w: hid[2], x: 0, y: 7, z: true, l: hl[2]),

            new PlacementModel(w: vid[0], x: 2, y: 3, z: false, l: vl[0]),
            new PlacementModel(w: vid[1], x: 3, y: 4, z: false, l: vl[1]),
            new PlacementModel(w: vid[2], x: 4, y: 4, z: false, l: vl[2]),
            new PlacementModel(w: vid[3], x: 5, y: 0, z: false, l: vl[3])
        };

        var shape = new ShapeModel(width:9, height:10, score:178 ,placements: placements);

        return new List<ShapeModel> { shape };
    }

    public static List<ShapeModel> C9002b(in List<string> words)
    {
        var h = new List<string> { "OLYMPUS", "ROMULUS", "JANUS", "SATYR" };
        var v = new List<string> { "URANUS", "JASON", "MUSES", "MEDUSA" };

        var hid = WordList.ExtractPositions(words, h);
        var vid = WordList.ExtractPositions(words, v);

        var hl = WordList.LengthsInBytes(h);
        var vl = WordList.LengthsInBytes(v);

        var placements = new List<PlacementModel> {
            new PlacementModel(w: hid[0], x: 0, y: 3, z: true, l: hl[0]),
            new PlacementModel(w: hid[1], x: 5, y: 4, z: true, l: hl[1]),
            new PlacementModel(w: hid[2], x: 4, y: 5, z: true, l: hl[2]),
            new PlacementModel(w: hid[3], x: 7, y: 6, z: true, l: hl[3]),

            new PlacementModel(w: vid[0], x: 6, y: 2, z: false, l: vl[0]),
            new PlacementModel(w: vid[1], x: 7, y: 0, z: false, l: vl[1]),
            new PlacementModel(w: vid[2], x: 8, y: 3, z: false, l: vl[2]),
            new PlacementModel(w: vid[3], x: 9, y: 0, z: false, l: vl[3])
        };

        var shape = new ShapeModel(width: 14, height:10, score: 212, placements: placements);

        return new List<ShapeModel> { shape };
    }

    public static List<ShapeModel> C9101(in List<string> words)
    {
        var h = new List<string> { "BAT", "AMUSEMENT", "SUN", "HAT" };
        var v = new List<string> { "BUSH", "CASUAL", "TENT" };

        var hid = WordList.ExtractPositions(words, h);
        var vid = WordList.ExtractPositions(words, v);

        var hl = WordList.LengthsInBytes(h);
        var vl = WordList.LengthsInBytes(v);

        var placements = new List<PlacementModel> {
            new PlacementModel(w: hid[0], x: 2, y: 2, z: true, l: hl[0]),
            new PlacementModel(w: hid[1], x: 0, y: 3, z: true, l: hl[1]),
            new PlacementModel(w: hid[2], x: 2, y: 4, z: true, l: hl[2]),
            new PlacementModel(w: hid[3], x: 2, y: 5, z: true, l: hl[3]),

            new PlacementModel(w: vid[0], x: 3, y: 1, z: false, l: vl[0]),
            new PlacementModel(w: vid[1], x: 4, y: 0, z: false, l: vl[1]),
            new PlacementModel(w: vid[2], x: 5, y: 1, z: false, l: vl[2])
        };

        var shape = new ShapeModel(width: 11, height: 8, score: 186, placements: placements);

        return new List<ShapeModel> { shape };
    }


    public static List<ShapeModel> C9102(in List<string> words)
    {
        var h = new List<string> { "SPEED", "DOT", "CANON", "TYPE" };
        var v = new List<string> { "DATA", "SONY", "LAPTOP", "NEC" };

        var hid = WordList.ExtractPositions(words, h);
        var vid = WordList.ExtractPositions(words, v);

        var hl = WordList.LengthsInBytes(h);
        var vl = WordList.LengthsInBytes(v);

        var placements = new List<PlacementModel> {
            new PlacementModel(w: hid[0], x: 2, y: 3, z: true, l: hl[0]),
            new PlacementModel(w: hid[1], x: 1, y: 4, z: true, l: hl[1]),
            new PlacementModel(w: hid[2], x: 0, y: 5, z: true, l: hl[2]),
            new PlacementModel(w: hid[3], x: 1, y: 6, z: true, l: hl[3]),

            new PlacementModel(w: vid[0], x: 2, y: 3, z: false, l: vl[0]),
            new PlacementModel(w: vid[1], x: 3, y: 2, z: false, l: vl[1]),
            new PlacementModel(w: vid[2], x: 4, y: 0, z: false, l: vl[2]),
            new PlacementModel(w: vid[3], x: 5, y: 4, z: false, l: vl[3])
        };

        var shape = new ShapeModel(width: 9, height: 9, score: 214, placements: placements);

        return new List<ShapeModel> { shape };
    }


    public static List<ShapeModel> C9109(in List<string> words)
    {
        var h = new List<string> { "COPYPAPER", "ANSWER", "POST", "TELLER", "ORDER" };
        var v = new List<string> { "PASTE", "ENTER", "BUZZERS" };

        var hid = WordList.ExtractPositions(words, h);
        var vid = WordList.ExtractPositions(words, v);

        var hl = WordList.LengthsInBytes(h);
        var vl = WordList.LengthsInBytes(v);

        var placements = new List<PlacementModel> {
            new PlacementModel(w: hid[0], x: 0, y: 6, z: true, l: hl[0]),
            new PlacementModel(w: hid[1], x: 6, y: 7, z: true, l: hl[1]),
            new PlacementModel(w: hid[2], x: 4, y: 8, z: true, l: hl[2]),
            new PlacementModel(w: hid[3], x: 6, y: 9, z: true, l: hl[3]),
            new PlacementModel(w: hid[4], x: 3, y: 10, z: true, l: hl[4]),

            new PlacementModel(w: vid[0], x: 7, y: 5, z: false, l: vl[0]),
            new PlacementModel(w: vid[1], x: 8, y: 5, z: false, l: vl[1]),
            new PlacementModel(w: vid[2], x: 9, y: 0, z: false, l: vl[2])
        };

        var shape = new ShapeModel(width: 14, height: 12, score: 184, placements: placements);

        return new List<ShapeModel> { shape };
    }


    public static List<ShapeModel> C9204(in List<string> words)
    {
        var h = new List<string> { "RITUAL", "SAUCERS", "BEANS" };
        var v = new List<string> { "SHRUB", "ICED", "TEA", "URN", "ASSAM" };

        var hid = WordList.ExtractPositions(words, h);
        var vid = WordList.ExtractPositions(words, v);

        var hl = WordList.LengthsInBytes(h);
        var vl = WordList.LengthsInBytes(v);

        var placements = new List<PlacementModel> {
            new PlacementModel(w: hid[0], x: 2, y: 3, z: true, l: hl[0]),
            new PlacementModel(w: hid[1], x: 0, y: 4, z: true, l: hl[1]),
            new PlacementModel(w: hid[2], x: 2, y: 5, z: true, l: hl[2]),

            new PlacementModel(w: vid[0], x: 3, y: 0, z: false, l: vl[0]),
            new PlacementModel(w: vid[1], x: 4, y: 2, z: false, l: vl[1]),
            new PlacementModel(w: vid[2], x: 5, y: 2, z: false, l: vl[2]),
            new PlacementModel(w: vid[3], x: 6, y: 2, z: false, l: vl[3]),
            new PlacementModel(w: vid[4], x: 7, y: 2, z: false, l: vl[4])
        };

        var shape = new ShapeModel(width: 10, height: 9, score: 200, placements: placements);

        return new List<ShapeModel> { shape };
    }


    public static List<ShapeModel> C9209(in List<string> words)
    {
        var h = new List<string> { "ALAMO", "CORPS", "TNT", "DIVISIONS" };
        var v = new List<string> { "ACTION", "MONS", "FORTIFY" };

        var hid = WordList.ExtractPositions(words, h);
        var vid = WordList.ExtractPositions(words, v);

        var hl = WordList.LengthsInBytes(h);
        var vl = WordList.LengthsInBytes(v);

        var placements = new List<PlacementModel> {
            new PlacementModel(w: hid[0], x: 1, y: 2, z: true, l: hl[0]),
            new PlacementModel(w: hid[1], x: 3, y: 3, z: true, l: hl[1]),
            new PlacementModel(w: hid[2], x: 3, y: 4, z: true, l: hl[2]),
            new PlacementModel(w: hid[3], x: 0, y: 5, z: true, l: hl[3]),

            new PlacementModel(w: vid[0], x: 4, y: 1, z: false, l: vl[0]),
            new PlacementModel(w: vid[1], x: 5, y: 1, z: false, l: vl[1]),
            new PlacementModel(w: vid[2], x: 6, y: 0, z: false, l: vl[2])
        };

        var shape = new ShapeModel(width: 11, height: 9, score: 170, placements: placements);

        return new List<ShapeModel> { shape };
    }


    public static List<ShapeModel> C9407(in List<string> words)
    {
        var h = new List<string> { "INUIT", "SCOTT", "WINTER" };
        var v = new List<string> { "GUST", "ICE", "STORM" };

        var hid = WordList.ExtractPositions(words, h);
        var vid = WordList.ExtractPositions(words, v);
        
        var hl = WordList.LengthsInBytes(h);
        var vl = WordList.LengthsInBytes(v);

        var placements = new List<PlacementModel> {
            new PlacementModel(w: hid[0], x: 1, y: 2, z: true, l: hl[0]),
            new PlacementModel(w: hid[1], x: 3, y: 3, z: true, l: hl[1]),
            new PlacementModel(w: hid[2], x: 0, y: 4, z: true, l: hl[2]),

            new PlacementModel(w: vid[0], x: 4, y: 0, z: false, l: vl[0]),
            new PlacementModel(w: vid[1], x: 5, y: 1, z: false, l: vl[1]),
            new PlacementModel(w: vid[2], x: 6, y: 0, z: false, l: vl[2])
        };

        var shape = new ShapeModel(width: 10, height: 7, score: 148, placements: placements);

        return new List<ShapeModel> { shape };
    }

    public static List<ShapeModel> C9605(in List<string> words)
    {
        var h = new List<string> { "BAR", "TESTIMONY", "TREASON", "SURTAX", "FALSE" };
        var v = new List<string> { "ASSIZES", "SUE", "TESTATOR", "RENT" };


        var hid = WordList.ExtractPositions(words, h);
        var vid = WordList.ExtractPositions(words, v);

        var hl = WordList.LengthsInBytes(h);
        var vl = WordList.LengthsInBytes(v);

        var placements = new List<PlacementModel> {
            new PlacementModel(w: hid[0], x: 4, y: 5, z: true, l: hl[0]),
            new PlacementModel(w: hid[1], x: 5, y: 6, z: true, l: hl[1]),
            new PlacementModel(w: hid[2], x: 0, y: 7, z: true, l: hl[2]),
            new PlacementModel(w: hid[3], x: 3, y: 8, z: true, l: hl[3]),
            new PlacementModel(w: hid[4], x: 0, y: 9, z: true, l: hl[4]),

            new PlacementModel(w: vid[0], x: 4, y: 6, z: false, l: vl[0]),
            new PlacementModel(w: vid[1], x: 5, y: 6, z: false, l: vl[1]),
            new PlacementModel(w: vid[2], x: 6, y: 0, z: false, l: vl[2]),
            new PlacementModel(w: vid[3], x: 7, y: 4, z: false, l: vl[3])
        };

        var shape = new ShapeModel(width: 16, height: 15, score: 226, placements: placements);

        return new List<ShapeModel> { shape };
    }
	}