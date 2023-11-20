using CrozzleInterfaces;

namespace CrozzleShapeMaker;

public class WinningShapesCalculator
{
    public static List<ShapeModel> execute(
        int gameId,
        in List<string> words)
    {
        var unsorted = execute2(gameId, words);
        return ShapeList.SortAndSetHistory(unsorted);
    }

    private static List<ShapeModel> execute2(int gameId, in List<string> words)
    {
        var end = WordList.Reversed(words);
        var len = WordList.Lengths(words);
        var letterIndex = new LetterIndexModel(words);

        switch (gameId)
        {
            case 8612:
                return Shapes_8612(words: words, end: end, len: len, letterIndex: letterIndex);
            case 8704:
                return Shapes_8704(words: words, end: end, len: len, letterIndex: letterIndex);
            case 8705:
                return Shapes_8705(words: words, end: end, len: len, letterIndex: letterIndex);
            case 8710:
                return Shapes_8710(words: words, end: end, len: len, letterIndex: letterIndex);
            case 8711:
                return Shapes_8711(words: words, end: end, len: len, letterIndex: letterIndex);
            case 8712:
                return Shapes_8712(words: words, end: end, len: len, letterIndex: letterIndex);
            case 8802:
                return Shapes_8802(words: words, end: end, len: len, letterIndex: letterIndex);
            case 8803:
                return Shapes_8803(words: words, end: end, len: len, letterIndex: letterIndex);
            case 8804:
                return Shapes_8804(words: words, end: end, len: len, letterIndex: letterIndex);
            case 8805:
                return Shapes_8805(words: words, end: end, len: len, letterIndex: letterIndex);
            case 8806:
                return Shapes_8806(words: words, end: end, len: len, letterIndex: letterIndex);
            case 8807:
                return Shapes_8807(words: words, end: end, len: len, letterIndex: letterIndex);
            case 8808:
                return Shapes_8808(words: words, end: end, len: len, letterIndex: letterIndex);
            case 8809:
                return Shapes_8809(words: words, end: end, len: len, letterIndex: letterIndex);
            case 8810:
                return Shapes_8810(words: words, end: end, len: len, letterIndex: letterIndex);
            case 8811:
                return Shapes_8811(words: words, end: end, len: len, letterIndex: letterIndex);
            case 8812:
                return Shapes_8812(words: words, end: end, len: len, letterIndex: letterIndex);
            case 8902:
                return Shapes_8902(words: words, end: end, len: len, letterIndex: letterIndex);
            case 8903:
                return Shapes_8903(words: words, end: end, len: len, letterIndex: letterIndex);
            case 8904:
                return Shapes_8904(words: words, end: end, len: len, letterIndex: letterIndex);
            case 8905:
                return Shapes_8905(words: words, end: end, len: len, letterIndex: letterIndex);
            case 8906:
                return Shapes_8906(words: words, end: end, len: len, letterIndex: letterIndex);
            case 8907:
                return Shapes_8907(words: words, end: end, len: len, letterIndex: letterIndex);
            case 8908:
                return Shapes_8908(words: words, end: end, len: len, letterIndex: letterIndex);
            case 8909:
                return Shapes_8909(words: words, end: end, len: len, letterIndex: letterIndex);
            case 8910:
                return Shapes_8910(words: words, end: end, len: len, letterIndex: letterIndex);
            case 8911:
                return Shapes_8911(words: words, end: end, len: len, letterIndex: letterIndex);
            case 8912:
                return Shapes_8912(words: words, end: end, len: len, letterIndex: letterIndex);
            case 9001:
                return Shapes_9001(words: words, end: end, len: len, letterIndex: letterIndex);
            case 9002:
                return Shapes_9002(words: words, end: end, len: len, letterIndex: letterIndex);
            case 9003:
                return Shapes_9003(words: words, end: end, len: len, letterIndex: letterIndex);
            case 9004:
                return Shapes_9004(words: words, end: end, len: len, letterIndex: letterIndex);
            case 9005:
                return Shapes_9005(words: words, end: end, len: len, letterIndex: letterIndex);
            case 9006:
                return Shapes_9006(words: words, end: end, len: len, letterIndex: letterIndex);
            case 9007:
                return Shapes_9007(words: words, end: end, len: len, letterIndex: letterIndex);
            case 9008:
                return Shapes_9008(words: words, end: end, len: len, letterIndex: letterIndex);
            case 9009:
                return Shapes_9009(words: words, end: end, len: len, letterIndex: letterIndex);
            case 9010:
                return Shapes_9010(words: words, end: end, len: len, letterIndex: letterIndex);
            case 9011:
                return Shapes_9011(words: words, end: end, len: len, letterIndex: letterIndex);
            case 9012:
                return Shapes_9012(words: words, end: end, len: len, letterIndex: letterIndex);
            case 9101:
                return Shapes_9101(words: words, end: end, len: len, letterIndex: letterIndex);
            case 9102:
                return Shapes_9102(words: words, end: end, len: len, letterIndex: letterIndex);
            case 9103:
                return Shapes_9103(words: words, end: end, len: len, letterIndex: letterIndex);
            case 9104:
                return Shapes_9104(words: words, end: end, len: len, letterIndex: letterIndex);
            case 9105:
                return Shapes_9105(words: words, end: end, len: len, letterIndex: letterIndex);
            case 9106:
                return Shapes_9106(words: words, end: end, len: len, letterIndex: letterIndex);
            case 9107:
                return Shapes_9107(words: words, end: end, len: len, letterIndex: letterIndex);
            case 9108:
                return Shapes_9108(words: words, end: end, len: len, letterIndex: letterIndex);
            case 9109:
                return Shapes_9109(words: words, end: end, len: len, letterIndex: letterIndex);
            case 9110:
                return Shapes_9110(words: words, end: end, len: len, letterIndex: letterIndex);
            case 9111:
                return Shapes_9111(words: words, end: end, len: len, letterIndex: letterIndex);
            case 9112:
                return Shapes_9112(words: words, end: end, len: len, letterIndex: letterIndex);
            case 9201:
                return Shapes_9201(words: words, end: end, len: len, letterIndex: letterIndex);
            case 9202:
                return Shapes_9202(words: words, end: end, len: len, letterIndex: letterIndex);
            case 9203:
                return Shapes_9203(words: words, end: end, len: len, letterIndex: letterIndex);
            case 9204:
                return Shapes_9204(words: words, end: end, len: len, letterIndex: letterIndex);
            case 9206:
                return Shapes_9206(words: words, end: end, len: len, letterIndex: letterIndex);
            case 9207:
                return Shapes_9207(words: words, end: end, len: len, letterIndex: letterIndex);
            case 9208:
                return Shapes_9208(words: words, end: end, len: len, letterIndex: letterIndex);
            case 9209:
                return Shapes_9209(words: words, end: end, len: len, letterIndex: letterIndex);
            case 9210:
                return Shapes_9210(words: words, end: end, len: len, letterIndex: letterIndex);
            case 9211:
                return Shapes_9211(words: words, end: end, len: len, letterIndex: letterIndex);
            case 9212:
                return Shapes_9212(words: words, end: end, len: len, letterIndex: letterIndex);
            case 9301:
                return Shapes_9301(words: words, end: end, len: len, letterIndex: letterIndex);
            case 9302:
                return Shapes_9302(words: words, end: end, len: len, letterIndex: letterIndex);
            case 9303:
                return Shapes_9303(words: words, end: end, len: len, letterIndex: letterIndex);
            case 9304:
                return Shapes_9304(words: words, end: end, len: len, letterIndex: letterIndex);
            case 9305:
                return Shapes_9305(words: words, end: end, len: len, letterIndex: letterIndex);
            case 9306:
                return Shapes_9306(words: words, end: end, len: len, letterIndex: letterIndex);
            case 9307:
                return Shapes_9307(words: words, end: end, len: len, letterIndex: letterIndex);
            case 9308:
                return Shapes_9308(words: words, end: end, len: len, letterIndex: letterIndex);
            case 9309:
                return Shapes_9309(words: words, end: end, len: len, letterIndex: letterIndex);
            case 9310:
                return Shapes_9310(words: words, end: end, len: len, letterIndex: letterIndex);
            case 9311:
                return Shapes_9311(words: words, end: end, len: len, letterIndex: letterIndex);
            case 9312:
                return Shapes_9312(words: words, end: end, len: len, letterIndex: letterIndex);
            case 9401:
                return Shapes_9401(words: words, end: end, len: len, letterIndex: letterIndex);
            case 9402:
                return Shapes_9402(words: words, end: end, len: len, letterIndex: letterIndex);
            case 9403:
                return Shapes_9403(words: words, end: end, len: len, letterIndex: letterIndex);
            case 9404:
                return Shapes_9404(words: words, end: end, len: len, letterIndex: letterIndex);
            case 9406:
                return Shapes_9406(words: words, end: end, len: len, letterIndex: letterIndex);
            case 9407:
                return Shapes_9407(words: words, end: end, len: len, letterIndex: letterIndex);
            case 9408:
                return Shapes_9408(words: words, end: end, len: len, letterIndex: letterIndex);
            case 9409:
                return Shapes_9409(words: words, end: end, len: len, letterIndex: letterIndex);
            case 9410:
                return Shapes_9410(words: words, end: end, len: len, letterIndex: letterIndex);
            case 9411:
                return Shapes_9411(words: words, end: end, len: len, letterIndex: letterIndex);
            case 9412:
                return Shapes_9412(words: words, end: end, len: len, letterIndex: letterIndex);
            case 9501:
                return Shapes_9501(words: words, end: end, len: len, letterIndex: letterIndex);
            case 9502:
                return Shapes_9502(words: words, end: end, len: len, letterIndex: letterIndex);
            case 9503:
                return Shapes_9503(words: words, end: end, len: len, letterIndex: letterIndex);
            case 9504:
                return Shapes_9504(words: words, end: end, len: len, letterIndex: letterIndex);
            case 9505:
                return Shapes_9505(words: words, end: end, len: len, letterIndex: letterIndex);
            case 9506:
                return Shapes_9506(words: words, end: end, len: len, letterIndex: letterIndex);
            case 9507:
                return Shapes_9507(words: words, end: end, len: len, letterIndex: letterIndex);
            case 9508:
                return Shapes_9508(words: words, end: end, len: len, letterIndex: letterIndex);
            case 9509:
                return Shapes_9509(words: words, end: end, len: len, letterIndex: letterIndex);
            case 9510:
                return Shapes_9510(words: words, end: end, len: len, letterIndex: letterIndex);
            case 9511:
                return Shapes_9511(words: words, end: end, len: len, letterIndex: letterIndex);
            case 9512:
                return Shapes_9512(words: words, end: end, len: len, letterIndex: letterIndex);
            case 9601:
                return Shapes_9601(words: words, end: end, len: len, letterIndex: letterIndex);
            case 9602:
                return Shapes_9602(words: words, end: end, len: len, letterIndex: letterIndex);
            case 9603:
                return Shapes_9603(words: words, end: end, len: len, letterIndex: letterIndex);
            case 9604:
                return Shapes_9604(words: words, end: end, len: len, letterIndex: letterIndex);
            case 9605:
                return Shapes_9605(words: words, end: end, len: len, letterIndex: letterIndex);
            default:
                return new List<ShapeModel>();
        }
    }

    private static List<ShapeModel> Shapes_8612(in List<string> words, in List<string> end, in List<int> len, LetterIndexModel letterIndex)
    {
        var edges = EdgeCalculator.Execute(
            words: words,
            scoreMin: 22,
            widthMax: 8,
            heightMax: 7);

        var rectangle3x4 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 136,
            widthMax: 10,
            heightMax: 6);

        var rectangle4x5 = RectangleCalculator.Rectangle(
            interlockWidth: 3,
            interlockHeight: 4,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 90,
            widthMax: 7,
            heightMax: 6);

        var rectangle3x4_BottomLeft = RectangleCalculator.BottomLeftRectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 64,
            widthMax: 10,
            heightMax: 7);

        var square3x3 = RectangleCalculator.Square(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 52,
            widthMax: 11,
            heightMax: 8);

        var shapes = ShapeCalculator.CombineShapes(new List<List<ShapeModel>> { edges, rectangle3x4, rectangle4x5, rectangle3x4_BottomLeft, square3x3 });

        //Console.WriteLine($"{edges.Count}, {rectangle3x4.Count}, {rectangle4x5.Count}, {rectangle3x4_BottomLeft.Count}, {square3x3.Count}");
        return shapes;
    }


    //private static List<ShapeModel> Shapes_8702(in List<string> words, in List<string> end, in List<int> len, LetterIndexModel letterIndex)
    //{
    //    var pacman3x3_BottomRight = PacmanCalculator.BottomRight3x3(
    //        letterIndex: letterIndex,
    //        words: words,
    //        end: end,
    //        len: len,
    //        scoreMin: 144,
    //        widthMax: 9,
    //        heightMax: 8);

    //    var c2x2 = ClusterCalculator.C2x2(
    //        letterIndex: letterIndex,
    //        words: words,
    //        end: end,
    //        len: len,
    //        scoreMin: 106,
    //        widthMax: 10,
    //        heightMax: 8);

    //    var edges = EdgeCalculator.Execute(
    //        words: words,
    //        scoreMin: 22,
    //        widthMax: 8,
    //        heightMax: 7);

    //    var square3x3 = RectangleCalculator.Square(
    //        interlockWidth: 2,
    //        letterIndex: letterIndex,
    //        words: words,
    //        lengths: len,
    //        scoreMin: 74,
    //        widthMax: 9,
    //        heightMax: 8);

    //    var square4x4 = RectangleCalculator.Square(
    //        interlockWidth: 3,
    //        letterIndex: letterIndex,
    //        words: words,
    //        lengths: len,
    //        scoreMin: 76,
    //        widthMax: 8,
    //        heightMax: 6);

    //    var square3x3_TopLeft = RectangleCalculator.TopLeftSquare(
    //        interlockWidth: 2,
    //        letterIndex: letterIndex,
    //        words: words,
    //        lengths: len,
    //        scoreMin: 72,
    //        widthMax: 10,
    //        heightMax: 8);

    //    var square3x3_TopRight = RectangleCalculator.TopRightSquare(
    //        interlockWidth: 2,
    //        letterIndex: letterIndex,
    //        words: words,
    //        lengths: len,
    //        scoreMin: 80,
    //        widthMax: 8,
    //        heightMax: 7);

    //    var shapes = ShapeCalculator.CombineShapes(new List<List<ShapeModel>> { pacman3x3_BottomRight, c2x2, edges, square3x3, square4x4, square3x3_TopLeft, square3x3_TopRight });
    //    foreach (var shape in shapes)
    //    {
    //        var text = ShapeCalculator.ToTextDebug(shape, words);
    //        Console.WriteLine(text);
    //    }
    //    return shapes;
    //}


    //private static List<ShapeModel> Shapes_8703(
    //    in List<string> words,
    //    in List<string> end,
    //    in List<int> len,
    //    LetterIndexModel letterIndex)
    //{
    //    var c2x2 = ClusterCalculator.C2x2(
    //        letterIndex: letterIndex,
    //        words: words,
    //        end: end,
    //        len: len,
    //        scoreMin: 70,
    //        widthMax: 10,
    //        heightMax: 8);

    //    var c2x3 = ClusterCalculator.C2x3(
    //        letterIndex: letterIndex,
    //        words: words,
    //        end: end,
    //        len: len,
    //        scoreMin: 102,
    //        widthMax: 13,
    //        heightMax: 10);

    //    var edges = EdgeCalculator.Execute(
    //        words: words,
    //        scoreMin: 22,
    //        widthMax: 7,
    //        heightMax: 6);

    //    var rectangle3x4 = RectangleCalculator.Rectangle(
    //        interlockWidth: 2,
    //        interlockHeight: 3,
    //        letterIndex: letterIndex,
    //        words: words,
    //        lengths: len,
    //        scoreMin: 74,
    //        widthMax: 7,
    //        heightMax: 7);

    //    var special8703 = SpecialShapesCalculator.C8703(words: words);

    //    var square3x3 = RectangleCalculator.Square(
    //        interlockWidth: 2,
    //        letterIndex: letterIndex,
    //        words: words,
    //        lengths: len,
    //        scoreMin: 68,
    //        widthMax: 10,
    //        heightMax: 7);

    //    var square3x3_BottomRight = RectangleCalculator.BottomRightSquare(
    //        interlockWidth: 2,
    //        letterIndex: letterIndex,
    //        words: words,
    //        lengths: len,
    //        scoreMin: 66,
    //        widthMax: 8,
    //        heightMax: 7);

    //    var square3x3_TopLeft = RectangleCalculator.TopLeftSquare(
    //        interlockWidth: 2,
    //        letterIndex: letterIndex,
    //        words: words,
    //        lengths: len,
    //        scoreMin: 58,
    //        widthMax: 10,
    //        heightMax: 5);

    //    var shapes = ShapeCalculator.CombineShapes(new List<List<ShapeModel>> { c2x2, c2x3, edges, rectangle3x4, special8703, square3x3, square3x3_BottomRight, square3x3_TopLeft });

    //    return shapes;
    //}


    private static List<ShapeModel> Shapes_8704(in List<string> words, in List<string> end, in List<int> len, LetterIndexModel letterIndex)
    {
        var c2x3 = ClusterCalculator.C2x3(
            letterIndex: letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: 104,
            widthMax: 9,
            heightMax: 7);

        var edges = EdgeCalculator.Execute(
            words: words,
            scoreMin: 22,
            widthMax: 9,
            heightMax: 8);

        var rectangle3x4 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 100,
            widthMax: 9,
            heightMax: 9);

        var rectangle3x5 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 4,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 92,
            widthMax: 9,
            heightMax: 7);

        var rectangle3x4_TopRight = RectangleCalculator.TopRightRectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 72,
            widthMax: 8,
            heightMax: 8);

        var square3x3 = RectangleCalculator.Square(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 96,
            widthMax: 8,
            heightMax: 7);

        var square4x4_TopLeft = RectangleCalculator.TopLeftSquare(
            interlockWidth: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 72,
            widthMax: 8,
            heightMax: 7);

        var shapes = ShapeCalculator.CombineShapes(new List<List<ShapeModel>> { c2x3, edges, rectangle3x4, rectangle3x5, rectangle3x4_TopRight, square3x3, square4x4_TopLeft });
        
        return shapes;
    }


    private static List<ShapeModel> Shapes_8705(in List<string> words, in List<string> end, in List<int> len, LetterIndexModel letterIndex)
    {
        var c2x2 = ClusterCalculator.C2x2(
            letterIndex: letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: 66,
            widthMax: 10,
            heightMax: 9);
        
        var c2x3 = ClusterCalculator.C2x3(
            letterIndex: letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: 106,
            widthMax: 13,
            heightMax: 8);
        
        var c2x4 = ClusterCalculator.C2x4(
            letterIndex: letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: 132,
            widthMax: 10,
            heightMax: 7);
        
        var edges = EdgeCalculator.Execute(
            words: words,
            scoreMin: 24,
            widthMax: 9,
            heightMax: 6);

        var rectangle3x4 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 80,
            widthMax: 8,
            heightMax: 6);

        var rectangle3x4_TopLeft = RectangleCalculator.TopLeftRectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 88,
            widthMax: 10,
            heightMax: 8);

        var square3x3 = RectangleCalculator.Square(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 78,
            widthMax: 9,
            heightMax: 7);

        var square3x3_BottomRight = RectangleCalculator.BottomRightSquare(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 74,
            widthMax: 9,
            heightMax: 7);

        var shapes = ShapeCalculator.CombineShapes(new List<List<ShapeModel>> { c2x2, c2x3, c2x4, edges, rectangle3x4, rectangle3x4_TopLeft, square3x3, square3x3_BottomRight });
        
        return shapes;
    }

    private static List<ShapeModel> Shapes_8710(in List<string> words, in List<string> end, in List<int> len, LetterIndexModel letterIndex)
    {
        var pacman3x3_TopLeft = PacmanCalculator.TopLeft3x3(
            letterIndex: letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: 132,
            widthMax: 11,
            heightMax: 10);
        
        var c2x2 = ClusterCalculator.C2x2(
            letterIndex: letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: 84,
            widthMax: 10,
            heightMax: 9);

        var c2x3 = ClusterCalculator.C2x3(
            letterIndex: letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: 102,
            widthMax: 10,
            heightMax: 10);

        var edges = EdgeCalculator.Execute(
            words: words,
            scoreMin: 22,
            widthMax: 6,
            heightMax: 6);

        var rectangle3x4 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 84,
            widthMax: 11,
            heightMax: 9);

        var rectangle3x5_TopLeft = RectangleCalculator.TopLeftRectangle(
            interlockWidth: 2,
            interlockHeight: 4,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 104,
            widthMax: 9,
            heightMax: 8);

        var rectangle3x5_TopRight = RectangleCalculator.TopRightRectangle(
            interlockWidth: 2,
            interlockHeight: 4,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 72,
            widthMax: 11,
            heightMax: 9);

        var square4x4 = RectangleCalculator.Square(
            interlockWidth: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 100,
            widthMax: 10,
            heightMax: 6);

        var square5x5_TopRight = RectangleCalculator.TopRightSquare(
            interlockWidth: 4,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 74,
            widthMax: 9,
            heightMax: 7);

        var shapes = ShapeCalculator.CombineShapes(new List<List<ShapeModel>> { pacman3x3_TopLeft, c2x2, c2x3, edges, rectangle3x4, rectangle3x5_TopLeft, rectangle3x5_TopRight, square4x4, square5x5_TopRight });

        return shapes;
    }


    private static List<ShapeModel> Shapes_8711(in List<string> words, in List<string> end, in List<int> len, LetterIndexModel letterIndex)
    {
        var c2x2 = ClusterCalculator.C2x2(
            letterIndex: letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: 82,
            widthMax: 9,
            heightMax: 8);

        var c2x3 = ClusterCalculator.C2x3(
            letterIndex: letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: 118,
            widthMax: 9,
            heightMax: 8);

        var c2x5 = ClusterCalculator.C2x5(
            letterIndex: letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: 204,
            widthMax: 13,
            heightMax: 7);

        var edges = EdgeCalculator.Execute(
            words: words,
            scoreMin: 22,
            widthMax: 9,
            heightMax: 6);

        var rectangle3x4 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 82,
            widthMax: 8,
            heightMax: 7);

        var rectangle3x5 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 4,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 116,
            widthMax: 9,
            heightMax: 7);

        var rectangle3x4_TopLeft = RectangleCalculator.TopLeftRectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 82,
            widthMax: 9,
            heightMax: 7);

        var rectangle3x4_TopRight = RectangleCalculator.TopRightRectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 96,
            widthMax: 8,
            heightMax: 7);

        var square3x3 = RectangleCalculator.Square(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 60,
            widthMax: 9,
            heightMax: 7);

        var square3x3_TopLeft = RectangleCalculator.TopLeftSquare(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 96,
            widthMax: 10,
            heightMax: 8);

        var shapes = ShapeCalculator.CombineShapes(new List<List<ShapeModel>> { c2x2, c2x3, c2x5, edges, rectangle3x4, rectangle3x5, rectangle3x4_TopLeft, rectangle3x4_TopRight, square3x3, square3x3_TopLeft });

        return shapes;
    }


    private static List<ShapeModel> Shapes_8712(in List<string> words, in List<string> end, in List<int> len, LetterIndexModel letterIndex)
    {
        var c2x2 = ClusterCalculator.C2x2(
            letterIndex: letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: 108,
            widthMax: 11,
            heightMax: 8);

        var c2x3 = ClusterCalculator.C2x3(
            letterIndex: letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: 118,
            widthMax: 11,
            heightMax: 7);

        var edges = EdgeCalculator.Execute(
            words: words,
            scoreMin: 28,
            widthMax: 8,
            heightMax: 7);

        var rectangle3x4 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 82,
            widthMax: 9,
            heightMax: 8);

        var rectangle3x5 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 4,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 96,
            widthMax: 10,
            heightMax: 8);

        var rectangle4x5 = RectangleCalculator.Rectangle(
            interlockWidth: 3,
            interlockHeight: 4,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 108,
            widthMax: 11,
            heightMax: 8);

        var rectangle3x4_BottomRight = RectangleCalculator.BottomRightRectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 80,
            widthMax: 13,
            heightMax: 7);

        var square3x3 = RectangleCalculator.Square(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 78,
            widthMax: 8,
            heightMax: 8);

        var square3x3_TopLeft = RectangleCalculator.TopLeftSquare(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 74,
            widthMax: 11,
            heightMax: 10);

        var shapes = ShapeCalculator.CombineShapes(new List<List<ShapeModel>> { c2x2, c2x3, edges, rectangle3x4, rectangle3x5, rectangle4x5, rectangle3x4_BottomRight, square3x3, square3x3_TopLeft });

        return shapes;
    }

    private static List<ShapeModel> Shapes_8802(in List<string> words, in List<string> end, in List<int> len, LetterIndexModel letterIndex)
    {
        var c2x2 = ClusterCalculator.C2x2(
            letterIndex: letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: 74,
            widthMax: 10,
            heightMax: 8);

        var c2x4 = ClusterCalculator.C2x4(
            letterIndex: letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: 148,
            widthMax: 11,
            heightMax: 7);

        var edges = EdgeCalculator.Execute(
            words: words,
            scoreMin: 28,
            widthMax: 8,
            heightMax: 7);

        var rectangle3x4_BottomRight = RectangleCalculator.BottomRightRectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 82,
            widthMax: 10,
            heightMax: 7);
        
        var rectangle3x4_TopRight = RectangleCalculator.TopRightRectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 60,
            widthMax: 9,
            heightMax: 7);

        var square3x3_TopLeft = RectangleCalculator.TopLeftSquare(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 92,
            widthMax: 10,
            heightMax: 9);

        var square4x4_TopLeft = RectangleCalculator.TopLeftSquare(
            interlockWidth: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 80,
            widthMax: 9,
            heightMax: 8);

        var square3x3_TopRight = RectangleCalculator.TopRightSquare(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 120,
            widthMax: 8,
            heightMax: 7);

        var shapes = ShapeCalculator.CombineShapes(new List<List<ShapeModel>> { c2x2, c2x4, edges, rectangle3x4_BottomRight, rectangle3x4_TopRight, square3x3_TopLeft, square4x4_TopLeft, square3x3_TopRight });

        return shapes;
    }


    private static List<ShapeModel> Shapes_8803(in List<string> words, in List<string> end, in List<int> len, LetterIndexModel letterIndex)
    {
        var pacman3x3_TopRight = PacmanCalculator.TopRight3x3(
            letterIndex: letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: 136,
            widthMax: 10,
            heightMax: 9);

        var c2x2 = ClusterCalculator.C2x2(
            letterIndex: letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: 88,
            widthMax: 11,
            heightMax: 10);


        var edges = EdgeCalculator.Execute(
            words: words,
            scoreMin: 24,
            widthMax: 8,
            heightMax: 8);


        var rectangle3x4 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 68,
            widthMax: 7,
            heightMax: 7);


        var rectangle3x6_BottomLeft = RectangleCalculator.BottomLeftRectangle(
            interlockWidth: 2,
            interlockHeight: 5,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 96,
            widthMax: 9,
            heightMax: 6);


        var square3x3 = RectangleCalculator.Square(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 56,
            widthMax: 11,
            heightMax: 9);


        var square3x3_TopRight = RectangleCalculator.TopRightSquare(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 88,
            widthMax: 9,
            heightMax: 6);


        var shapes = ShapeCalculator.CombineShapes(new List<List<ShapeModel>> { pacman3x3_TopRight, c2x2, edges, rectangle3x4, rectangle3x6_BottomLeft, square3x3, square3x3_TopRight });


        return shapes;
    }


    private static List<ShapeModel> Shapes_8804(in List<string> words, in List<string> end, in List<int> len, LetterIndexModel letterIndex)
    {

        var c2x2 = ClusterCalculator.C2x2(
            letterIndex: letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: 84,
            widthMax: 8,
            heightMax: 6);

        var c2x3 = ClusterCalculator.C2x3(
            letterIndex: letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: 108,
            widthMax: 9,
            heightMax: 8);

        var edges = EdgeCalculator.Execute(
            words: words,
            scoreMin: 22,
            widthMax: 9,
            heightMax: 7);

        var square3x3 = RectangleCalculator.Square(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 74,
            widthMax: 9,
            heightMax: 7);

        var square3x3_TopRight = RectangleCalculator.TopRightSquare(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 68,
            widthMax: 8,
            heightMax: 6);

        var shapes = ShapeCalculator.CombineShapes(new List<List<ShapeModel>> { c2x2, c2x3, edges, square3x3, square3x3_TopRight });


        return shapes;
    }


    private static List<ShapeModel> Shapes_8805(in List<string> words, in List<string> end, in List<int> len, LetterIndexModel letterIndex)
    {

        var c2x2 = ClusterCalculator.C2x2(
            letterIndex: letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: 74,
            widthMax: 12,
            heightMax: 8);

        var edges = EdgeCalculator.Execute(
            words: words,
            scoreMin: 22,
            widthMax: 7,
            heightMax: 7);

        var special8805 = SpecialShapesCalculator.C8805(words: words);

        var square3x3 = RectangleCalculator.Square(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 118,
            widthMax: 10,
            heightMax: 9);

        var square4x4_TopRight = RectangleCalculator.TopRightSquare(
            interlockWidth: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 116,
            widthMax: 9,
            heightMax: 7);

        var square5x5_TopRight = RectangleCalculator.TopRightSquare(
            interlockWidth: 4,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 88,
            widthMax: 7,
            heightMax: 7);

        var shapes = ShapeCalculator.CombineShapes(new List<List<ShapeModel>> { c2x2, edges, special8805, square3x3, square4x4_TopRight, square5x5_TopRight });


        return shapes;
    }


    private static List<ShapeModel> Shapes_8806(in List<string> words, in List<string> end, in List<int> len, LetterIndexModel letterIndex)
    {

        var c2x2 = ClusterCalculator.C2x2(
            letterIndex: letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: 62,
            widthMax: 11,
            heightMax: 6);

        var c2x3 = ClusterCalculator.C2x3(
            letterIndex: letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: 108,
            widthMax: 10,
            heightMax: 7);


        var edges = EdgeCalculator.Execute(
            words: words,
            scoreMin: 22,
            widthMax: 10,
            heightMax: 7);


        var square3x3 = RectangleCalculator.Square(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 78,
            widthMax: 10,
            heightMax: 8);


        var square3x3_TopLeft = RectangleCalculator.TopLeftSquare(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 64,
            widthMax: 10,
            heightMax: 8);


        var shapes = ShapeCalculator.CombineShapes(new List<List<ShapeModel>> { c2x2, c2x3, edges, square3x3, square3x3_TopLeft });


        return shapes;
    }


    private static List<ShapeModel> Shapes_8807(in List<string> words, in List<string> end, in List<int> len, LetterIndexModel letterIndex)
    {

        var edges = EdgeCalculator.Execute(
            words: words,
            scoreMin: 22,
            widthMax: 9,
            heightMax: 7);


        var outer2x3 = OuterCalculator.C2x3(
            letterIndex: letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: 90,
            widthMax: 10,
            heightMax: 7);


        var rectangle3x5_TopLeft = RectangleCalculator.TopLeftRectangle(
            interlockWidth: 2,
            interlockHeight: 4,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 96,
            widthMax: 12,
            heightMax: 8);


        var square3x3 = RectangleCalculator.Square(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 104,
            widthMax: 10,
            heightMax: 9);

        var shapes = ShapeCalculator.CombineShapes(new List<List<ShapeModel>> { edges, outer2x3, rectangle3x5_TopLeft, square3x3 });


        return shapes;
    }


    private static List<ShapeModel> Shapes_8808(in List<string> words, in List<string> end, in List<int> len, LetterIndexModel letterIndex)
    {

        var c2x2 = ClusterCalculator.C2x2(
            letterIndex: letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: 68,
            widthMax: 11,
            heightMax: 10);


        var c3x3 = ClusterCalculator.C3x3(
            letterIndex: letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: 190,
            widthMax: 12,
            heightMax: 8);


        var edges = EdgeCalculator.Execute(
            words: words,
            scoreMin: 24,
            widthMax: 9,
            heightMax: 7);


        var rectangle3x5 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 4,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 74,
            widthMax: 9,
            heightMax: 7);


        var rectangle3x4_TopLeft = RectangleCalculator.TopLeftRectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 88,
            widthMax: 9,
            heightMax: 9);


        var square3x3 = RectangleCalculator.Square(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 136,
            widthMax: 9,
            heightMax: 9);


        var square4x4_TopRight = RectangleCalculator.TopRightSquare(
            interlockWidth: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 48,
            widthMax: 9,
            heightMax: 9);


        var shapes = ShapeCalculator.CombineShapes(new List<List<ShapeModel>> { c2x2, c3x3, edges, rectangle3x5, rectangle3x4_TopLeft, square3x3, square4x4_TopRight });


        return shapes;
    }


    private static List<ShapeModel> Shapes_8809(in List<string> words, in List<string> end, in List<int> len, LetterIndexModel letterIndex)
    {

        var c2x2 = ClusterCalculator.C2x2(
            letterIndex: letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: 104,
            widthMax: 11,
            heightMax: 10);


        var edges = EdgeCalculator.Execute(
            words: words,
            scoreMin: 22,
            widthMax: 9,
            heightMax: 8);


        var rectangle3x4 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 76,
            widthMax: 11,
            heightMax: 7);


        var rectangle3x5_BottomRight = RectangleCalculator.BottomRightRectangle(
            interlockWidth: 2,
            interlockHeight: 4,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 68,
            widthMax: 12,
            heightMax: 10);


        var rectangle3x4_TopLeft = RectangleCalculator.TopLeftRectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 76,
            widthMax: 11,
            heightMax: 8);


        var rectangle3x5_TopLeft = RectangleCalculator.TopLeftRectangle(
            interlockWidth: 2,
            interlockHeight: 4,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 72,
            widthMax: 12,
            heightMax: 9);


        var square3x3 = RectangleCalculator.Square(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 68,
            widthMax: 14,
            heightMax: 7);


        var shapes = ShapeCalculator.CombineShapes(new List<List<ShapeModel>> { c2x2, edges, rectangle3x4, rectangle3x5_BottomRight, rectangle3x4_TopLeft, rectangle3x5_TopLeft, square3x3 });


        return shapes;
    }


    private static List<ShapeModel> Shapes_8810(in List<string> words, in List<string> end, in List<int> len, LetterIndexModel letterIndex)
    {

        var c2x2 = ClusterCalculator.C2x2(
            letterIndex: letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: 66,
            widthMax: 9,
            heightMax: 9);


        var edges = EdgeCalculator.Execute(
            words: words,
            scoreMin: 24,
            widthMax: 9,
            heightMax: 7);


        var rectangle3x4 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 96,
            widthMax: 9,
            heightMax: 8);


        var square3x3 = RectangleCalculator.Square(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 70,
            widthMax: 8,
            heightMax: 7);


        var shapes = ShapeCalculator.CombineShapes(new List<List<ShapeModel>> { c2x2, edges, rectangle3x4, square3x3 });


        return shapes;
    }


    private static List<ShapeModel> Shapes_8811(in List<string> words, in List<string> end, in List<int> len, LetterIndexModel letterIndex)
    {

        var c2x2 = ClusterCalculator.C2x2(
            letterIndex: letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: 82,
            widthMax: 12,
            heightMax: 8);


        var c2x3 = ClusterCalculator.C2x3(
            letterIndex: letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: 142,
            widthMax: 11,
            heightMax: 9);


        var edges = EdgeCalculator.Execute(
            words: words,
            scoreMin: 28,
            widthMax: 8,
            heightMax: 8);


        var rectangle3x4 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 92,
            widthMax: 9,
            heightMax: 8);


        var rectangle3x5 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 4,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 84,
            widthMax: 10,
            heightMax: 8);


        var rectangle4x5 = RectangleCalculator.Rectangle(
            interlockWidth: 3,
            interlockHeight: 4,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 80,
            widthMax: 8,
            heightMax: 6);


        var rectangle3x5_BottomLeft = RectangleCalculator.BottomLeftRectangle(
            interlockWidth: 2,
            interlockHeight: 4,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 54,
            widthMax: 11,
            heightMax: 10);


        var rectangle4x6_TopRight = RectangleCalculator.TopRightRectangle(
            interlockWidth: 3,
            interlockHeight: 5,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 66,
            widthMax: 8,
            heightMax: 8);


        var square3x3 = RectangleCalculator.Square(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 60,
            widthMax: 10,
            heightMax: 6);


        var shapes = ShapeCalculator.CombineShapes(new List<List<ShapeModel>> { c2x2, c2x3, edges, rectangle3x4, rectangle3x5, rectangle4x5, rectangle3x5_BottomLeft, rectangle4x6_TopRight, square3x3 });


        return shapes;
    }


    private static List<ShapeModel> Shapes_8812(in List<string> words, in List<string> end, in List<int> len, LetterIndexModel letterIndex)
    {

        var pacman3x3_TopRight = PacmanCalculator.TopRight3x3(
            letterIndex: letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: 152,
            widthMax: 9,
            heightMax: 9);


        var c2x2 = ClusterCalculator.C2x2(
            letterIndex: letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: 86,
            widthMax: 9,
            heightMax: 8);


        var edges = EdgeCalculator.Execute(
            words: words,
            scoreMin: 24,
            widthMax: 7,
            heightMax: 6);


        var rectangle3x4 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 72,
            widthMax: 9,
            heightMax: 7);


        var rectangle3x4_TopLeft = RectangleCalculator.TopLeftRectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 82,
            widthMax: 8,
            heightMax: 7);


        var rectangle3x5_TopLeft = RectangleCalculator.TopLeftRectangle(
            interlockWidth: 2,
            interlockHeight: 4,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 76,
            widthMax: 8,
            heightMax: 8);


        var square3x3 = RectangleCalculator.Square(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 66,
            widthMax: 9,
            heightMax: 8);


        var square3x3_TopRight = RectangleCalculator.TopRightSquare(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 60,
            widthMax: 8,
            heightMax: 7);


        var shapes = ShapeCalculator.CombineShapes(new List<List<ShapeModel>> { pacman3x3_TopRight, c2x2, edges, rectangle3x4, rectangle3x4_TopLeft, rectangle3x5_TopLeft, square3x3, square3x3_TopRight });


        return shapes;
    }


    private static List<ShapeModel> Shapes_8902(in List<string> words, in List<string> end, in List<int> len, LetterIndexModel letterIndex)
    {

        var c2x3 = ClusterCalculator.C2x3(
            letterIndex: letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: 154,
            widthMax: 10,
            heightMax: 8);


        var edges = EdgeCalculator.Execute(
            words: words,
            scoreMin: 28,
            widthMax: 8,
            heightMax: 7);


        var rectangle3x5 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 4,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 132,
            widthMax: 13,
            heightMax: 7);


        var square3x3 = RectangleCalculator.Square(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 74,
            widthMax: 13,
            heightMax: 7);


        var square3x3_TopLeft = RectangleCalculator.TopLeftSquare(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 76,
            widthMax: 9,
            heightMax: 9);


        var square5x5_TopRight = RectangleCalculator.TopRightSquare(
            interlockWidth: 4,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 88,
            widthMax: 7,
            heightMax: 7);


        var shapes = ShapeCalculator.CombineShapes(new List<List<ShapeModel>> { c2x3, edges, rectangle3x5, square3x3, square3x3_TopLeft, square5x5_TopRight });


        return shapes;
    }


    private static List<ShapeModel> Shapes_8903(in List<string> words, in List<string> end, in List<int> len, LetterIndexModel letterIndex)
    {

        var edges = EdgeCalculator.Execute(
            words: words,
            scoreMin: 24,
            widthMax: 10,
            heightMax: 8);


        var rectangle3x4 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 82,
            widthMax: 14,
            heightMax: 9);


        var square3x3_TopRight = RectangleCalculator.TopRightSquare(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 82,
            widthMax: 14,
            heightMax: 9);


        var shapes = ShapeCalculator.CombineShapes(new List<List<ShapeModel>> { edges, rectangle3x4, square3x3_TopRight });


        return shapes;
    }


    private static List<ShapeModel> Shapes_8904(in List<string> words, in List<string> end, in List<int> len, LetterIndexModel letterIndex)
    {

        var c2x3 = ClusterCalculator.C2x3(
            letterIndex: letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: 126,
            widthMax: 8,
            heightMax: 7);


        var c2x4 = ClusterCalculator.C2x4(
            letterIndex: letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: 168,
            widthMax: 12,
            heightMax: 7);


        var edges = EdgeCalculator.Execute(
            words: words,
            scoreMin: 22,
            widthMax: 9,
            heightMax: 8);


        var rectangle3x4_BottomLeft = RectangleCalculator.BottomLeftRectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 76,
            widthMax: 8,
            heightMax: 8);


        var square3x3 = RectangleCalculator.Square(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 78,
            widthMax: 9,
            heightMax: 7);


        var shapes = ShapeCalculator.CombineShapes(new List<List<ShapeModel>> { c2x3, c2x4, edges, rectangle3x4_BottomLeft, square3x3 });


        return shapes;
    }


    private static List<ShapeModel> Shapes_8905(in List<string> words, in List<string> end, in List<int> len, LetterIndexModel letterIndex)
    {

        var c2x3 = ClusterCalculator.C2x3(
            letterIndex: letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: 84,
            widthMax: 10,
            heightMax: 7);


        var c2x4 = ClusterCalculator.C2x4(
            letterIndex: letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: 160,
            widthMax: 12,
            heightMax: 10);


        var edges = EdgeCalculator.Execute(
            words: words,
            scoreMin: 22,
            widthMax: 8,
            heightMax: 7);


        var rectangle3x4 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 66,
            widthMax: 8,
            heightMax: 8);


        var square3x3_BottomRight = RectangleCalculator.BottomRightSquare(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 114,
            widthMax: 8,
            heightMax: 8);


        var square3x3_TopLeft = RectangleCalculator.TopLeftSquare(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 120,
            widthMax: 11,
            heightMax: 8);


        var square3x3_TopRight = RectangleCalculator.TopRightSquare(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 68,
            widthMax: 9,
            heightMax: 7);


        var shapes = ShapeCalculator.CombineShapes(new List<List<ShapeModel>> { c2x3, c2x4, edges, rectangle3x4, square3x3_BottomRight, square3x3_TopLeft, square3x3_TopRight });


        return shapes;
    }


    private static List<ShapeModel> Shapes_8906(in List<string> words, in List<string> end, in List<int> len, LetterIndexModel letterIndex)
    {

        var c2x2 = ClusterCalculator.C2x2(
            letterIndex: letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: 66,
            widthMax: 11,
            heightMax: 10);


        var c2x3 = ClusterCalculator.C2x3(
            letterIndex: letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: 162,
            widthMax: 12,
            heightMax: 8);


        var edges = EdgeCalculator.Execute(
            words: words,
            scoreMin: 22,
            widthMax: 8,
            heightMax: 8);


        var rectangle3x4 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 62,
            widthMax: 8,
            heightMax: 7);


        var square3x3 = RectangleCalculator.Square(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 144,
            widthMax: 10,
            heightMax: 8);


        var shapes = ShapeCalculator.CombineShapes(new List<List<ShapeModel>> { c2x2, c2x3, edges, rectangle3x4, square3x3 });


        return shapes;
    }


    private static List<ShapeModel> Shapes_8907(in List<string> words, in List<string> end, in List<int> len, LetterIndexModel letterIndex)
    {

        var pacman3x3_BottomRight = PacmanCalculator.BottomRight3x3(
            letterIndex: letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: 180,
            widthMax: 11,
            heightMax: 10);


        var edges = EdgeCalculator.Execute(
            words: words,
            scoreMin: 24,
            widthMax: 9,
            heightMax: 8);


        var outer2x3 = OuterCalculator.C2x3(
            letterIndex: letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: 140,
            widthMax: 9,
            heightMax: 7);


        var rectangle3x4 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 116,
            widthMax: 9,
            heightMax: 8);


        var rectangle3x4_BottomLeft = RectangleCalculator.BottomLeftRectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 66,
            widthMax: 8,
            heightMax: 7);


        var square3x3 = RectangleCalculator.Square(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 78,
            widthMax: 8,
            heightMax: 8);


        var square3x3_TopLeft = RectangleCalculator.TopLeftSquare(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 58,
            widthMax: 12,
            heightMax: 7);


        var shapes = ShapeCalculator.CombineShapes(new List<List<ShapeModel>> { pacman3x3_BottomRight, edges, outer2x3, rectangle3x4, rectangle3x4_BottomLeft, square3x3, square3x3_TopLeft });


        return shapes;
    }


    private static List<ShapeModel> Shapes_8908(in List<string> words, in List<string> end, in List<int> len, LetterIndexModel letterIndex)
    {

        var c2x3 = ClusterCalculator.C2x3(
            letterIndex: letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: 94,
            widthMax: 11,
            heightMax: 7);


        var edges = EdgeCalculator.Execute(
            words: words,
            scoreMin: 22,
            widthMax: 10,
            heightMax: 8);


        var rectangle3x4 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 78,
            widthMax: 8,
            heightMax: 8);


        var rectangle3x6_TopRight = RectangleCalculator.TopRightRectangle(
            interlockWidth: 2,
            interlockHeight: 5,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 116,
            widthMax: 10,
            heightMax: 8);


        var square3x3 = RectangleCalculator.Square(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 104,
            widthMax: 12,
            heightMax: 9);


        var shapes = ShapeCalculator.CombineShapes(new List<List<ShapeModel>> { c2x3, edges, rectangle3x4, rectangle3x6_TopRight, square3x3 });


        return shapes;
    }


    private static List<ShapeModel> Shapes_8909(in List<string> words, in List<string> end, in List<int> len, LetterIndexModel letterIndex)
    {

        var c2x3 = ClusterCalculator.C2x3(
            letterIndex: letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: 132,
            widthMax: 11,
            heightMax: 9);


        var edges = EdgeCalculator.Execute(
            words: words,
            scoreMin: 22,
            widthMax: 8,
            heightMax: 7);


        var rectangle3x4 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 148,
            widthMax: 9,
            heightMax: 8);


        var rectangle3x5 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 4,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 92,
            widthMax: 7,
            heightMax: 7);


        var rectangle3x4_TopLeft = RectangleCalculator.TopLeftRectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 120,
            widthMax: 9,
            heightMax: 8);


        var square3x3 = RectangleCalculator.Square(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 76,
            widthMax: 10,
            heightMax: 9);


        var square3x3_TopLeft = RectangleCalculator.TopLeftSquare(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 66,
            widthMax: 9,
            heightMax: 8);


        var shapes = ShapeCalculator.CombineShapes(new List<List<ShapeModel>> { c2x3, edges, rectangle3x4, rectangle3x5, rectangle3x4_TopLeft, square3x3, square3x3_TopLeft });


        return shapes; ;
    }


    private static List<ShapeModel> Shapes_8910(in List<string> words, in List<string> end, in List<int> len, LetterIndexModel letterIndex)
    {

        var c3x4 = ClusterCalculator.C3x4(
            letterIndex: letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: 186,
            widthMax: 12,
            heightMax: 11);


        var edges = EdgeCalculator.Execute(
            words: words,
            scoreMin: 28,
            widthMax: 9,
            heightMax: 8);


        var outer2x3 = OuterCalculator.C2x3(
            letterIndex: letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: 108,
            widthMax: 10,
            heightMax: 8);


        var rectangle3x4 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 70,
            widthMax: 11,
            heightMax: 7);


        var rectangle3x6 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 5,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 108,
            widthMax: 11,
            heightMax: 10);


        var square3x3 = RectangleCalculator.Square(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 52,
            widthMax: 10,
            heightMax: 8);


        var shapes = ShapeCalculator.CombineShapes(new List<List<ShapeModel>> { c3x4, edges, outer2x3, rectangle3x4, rectangle3x6, square3x3 });


        return shapes;
    }


    private static List<ShapeModel> Shapes_8911(in List<string> words, in List<string> end, in List<int> len, LetterIndexModel letterIndex)
    {

        var pacman3x3_BottomRight = PacmanCalculator.BottomRight3x3(
            letterIndex: letterIndex,
            words: words,
            end: end,


            len: len,
            scoreMin: 138,
            widthMax: 14,
            heightMax: 10);


        var c3x3 = ClusterCalculator.C3x3(
            letterIndex: letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: 142,
            widthMax: 8,
            heightMax: 8);


        var edges = EdgeCalculator.Execute(
            words: words,
            scoreMin: 22,
            widthMax: 9,
            heightMax: 7);


        var square3x3 = RectangleCalculator.Square(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 62,
            widthMax: 9,
            heightMax: 8);


        var shapes = ShapeCalculator.CombineShapes(new List<List<ShapeModel>> { pacman3x3_BottomRight, c3x3, edges, square3x3 });


        return shapes;
    }


    private static List<ShapeModel> Shapes_8912(in List<string> words, in List<string> end, in List<int> len, LetterIndexModel letterIndex)
    {

        var c2x2 = ClusterCalculator.C2x2(
            letterIndex: letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: 86,
            widthMax: 10,
            heightMax: 8);


        var edges = EdgeCalculator.Execute(
            words: words,
            scoreMin: 24,
            widthMax: 8,
            heightMax: 7);


        var rectangle3x4 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 106,
            widthMax: 8,
            heightMax: 6);


        var rectangle3x5 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 4,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 96,
            widthMax: 7,
            heightMax: 7);


        var rectangle4x5 = RectangleCalculator.Rectangle(
            interlockWidth: 3,
            interlockHeight: 4,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 90,
            widthMax: 11,
            heightMax: 7);


        var rectangle3x4_TopRight = RectangleCalculator.TopRightRectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 90,
            widthMax: 9,
            heightMax: 8);


        var square3x3 = RectangleCalculator.Square(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 128,
            widthMax: 12,
            heightMax: 9);


        var square4x4 = RectangleCalculator.Square(
            interlockWidth: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 84,
            widthMax: 9,
            heightMax: 8);


        var shapes = ShapeCalculator.CombineShapes(new List<List<ShapeModel>> { c2x2, edges, rectangle3x4, rectangle3x5, rectangle4x5, rectangle3x4_TopRight, square3x3, square4x4 });


        return shapes;
    }


    private static List<ShapeModel> Shapes_9001(in List<string> words, in List<string> end, in List<int> len, LetterIndexModel letterIndex)
    {

        var edges = EdgeCalculator.Execute(
            words: words,
            scoreMin: 22,
            widthMax: 9,
            heightMax: 8);


        var rectangle4x5 = RectangleCalculator.Rectangle(
            interlockWidth: 3,
            interlockHeight: 4,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 90,
            widthMax: 9,
            heightMax: 7);


        var square3x3 = RectangleCalculator.Square(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 70,
            widthMax: 12,
            heightMax: 7);


        var square3x3_TopRight = RectangleCalculator.TopRightSquare(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 84,
            widthMax: 13,
            heightMax: 7);


        var shapes = ShapeCalculator.CombineShapes(new List<List<ShapeModel>> { edges, rectangle4x5, square3x3, square3x3_TopRight });


        return shapes;
    }


    private static List<ShapeModel> Shapes_9002(in List<string> words, in List<string> end, in List<int> len, LetterIndexModel letterIndex)
    {

        var edges = EdgeCalculator.Execute(
            words: words,
            scoreMin: 22,
            widthMax: 9,
            heightMax: 7);


        var special9002a = SpecialShapesCalculator.C9002a(words: words);


        var special9002b = SpecialShapesCalculator.C9002b(words: words);


        var square3x3 = RectangleCalculator.Square(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 98,
            widthMax: 12,
            heightMax: 9);


        var square4x4 = RectangleCalculator.Square(
            interlockWidth: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 124,
            widthMax: 9,
            heightMax: 8);


        var shapes = ShapeCalculator.CombineShapes(new List<List<ShapeModel>> { edges, special9002a, special9002b, square3x3, square4x4 });


        return shapes;
    }


    private static List<ShapeModel> Shapes_9003(in List<string> words, in List<string> end, in List<int> len, LetterIndexModel letterIndex)
    {

        var edges = EdgeCalculator.Execute(
            words: words,
            scoreMin: 22,
            widthMax: 9,
            heightMax: 7);


        var rectangle3x4 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 84,
            widthMax: 9,
            heightMax: 9);


        var rectangle3x5 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 4,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 82,
            widthMax: 9,
            heightMax: 9);


        var square3x3_TopRight = RectangleCalculator.TopRightSquare(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 52,
            widthMax: 9,
            heightMax: 7);


        var shapes = ShapeCalculator.CombineShapes(new List<List<ShapeModel>> { edges, rectangle3x4, rectangle3x5, square3x3_TopRight });


        return shapes;
    }


    private static List<ShapeModel> Shapes_9004(in List<string> words, in List<string> end, in List<int> len, LetterIndexModel letterIndex)
    {

        var c2x2 = ClusterCalculator.C2x2(
            letterIndex: letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: 54,
            widthMax: 12,
            heightMax: 12);


        var edges = EdgeCalculator.Execute(
            words: words,
            scoreMin: 22,
            widthMax: 10,
            heightMax: 9);


        var rectangle3x4_BottomLeft = RectangleCalculator.BottomLeftRectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 96,
            widthMax: 9,
            heightMax: 8);


        var square3x3 = RectangleCalculator.Square(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 80,
            widthMax: 8,
            heightMax: 8);


        var square4x4 = RectangleCalculator.Square(
            interlockWidth: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 96,
            widthMax: 10,
            heightMax: 8);


        var shapes = ShapeCalculator.CombineShapes(new List<List<ShapeModel>> { c2x2, edges, rectangle3x4_BottomLeft, square3x3, square4x4 });


        return shapes;
    }


    private static List<ShapeModel> Shapes_9005(in List<string> words, in List<string> end, in List<int> len, LetterIndexModel letterIndex)
    {

        var c2x2 = ClusterCalculator.C2x2(
            letterIndex: letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: 90,
            widthMax: 9,
            heightMax: 8);


        var c2x3 = ClusterCalculator.C2x3(
            letterIndex: letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: 102,
            widthMax: 10,
            heightMax: 7);


        var edges = EdgeCalculator.Execute(
            words: words,
            scoreMin: 22,
            widthMax: 9,
            heightMax: 7);


        var rectangle3x4 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 68,
            widthMax: 9,
            heightMax: 7);


        var rectangle3x4_TopRight = RectangleCalculator.TopRightRectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 128,
            widthMax: 9,
            heightMax: 8);


        var square3x3 = RectangleCalculator.Square(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 88,
            widthMax: 9,
            heightMax: 8);


        var shapes = ShapeCalculator.CombineShapes(new List<List<ShapeModel>> { c2x2, c2x3, edges, rectangle3x4, rectangle3x4_TopRight, square3x3 });


        return shapes;
    }


    private static List<ShapeModel> Shapes_9006(in List<string> words, in List<string> end, in List<int> len, LetterIndexModel letterIndex)
    {

        var c2x2 = ClusterCalculator.C2x2(
            letterIndex: letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: 84,
            widthMax: 14,
            heightMax: 8);


        var c2x3 = ClusterCalculator.C2x3(
            letterIndex: letterIndex,
            words: words,
            end: end,


            len: len,
            scoreMin: 136,
            widthMax: 12,
            heightMax: 9);


        var edges = EdgeCalculator.Execute(
            words: words,
            scoreMin: 22,
            widthMax: 10,
            heightMax: 8);


        var rectangle3x4 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 70,
            widthMax: 8,
            heightMax: 7);


        var rectangle3x5 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 4,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 98,
            widthMax: 8,
            heightMax: 6);


        var rectangle3x5_BottomRight = RectangleCalculator.BottomRightRectangle(
            interlockWidth: 2,
            interlockHeight: 4,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 80,
            widthMax: 12,
            heightMax: 9);


        var square3x3 = RectangleCalculator.Square(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 68,
            widthMax: 12,
            heightMax: 9);


        var square3x3_TopRight = RectangleCalculator.TopRightSquare(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 74,
            widthMax: 13,
            heightMax: 8);


        var shapes = ShapeCalculator.CombineShapes(new List<List<ShapeModel>> { c2x2, c2x3, edges, rectangle3x4, rectangle3x5, rectangle3x5_BottomRight, square3x3, square3x3_TopRight });


        return shapes;
    }


    private static List<ShapeModel> Shapes_9007(in List<string> words, in List<string> end, in List<int> len, LetterIndexModel letterIndex)
    {

        var c2x3 = ClusterCalculator.C2x3(
            letterIndex: letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: 134,
            widthMax: 15,
            heightMax: 9);


        var edges = EdgeCalculator.Execute(
            words: words,
            scoreMin: 36,
            widthMax: 9,
            heightMax: 9);


        var rectangle3x5 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 4,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 62,
            widthMax: 10,
            heightMax: 10);


        var rectangle3x7 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 6,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 100,
            widthMax: 10,
            heightMax: 7);


        var rectangle3x4_BottomLeft = RectangleCalculator.BottomLeftRectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 96,
            widthMax: 12,
            heightMax: 7);


        var rectangle3x4_TopRight = RectangleCalculator.TopRightRectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 58,
            widthMax: 8,
            heightMax: 6);


        var square3x3 = RectangleCalculator.Square(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 92,
            widthMax: 9,
            heightMax: 7);


        var shapes = ShapeCalculator.CombineShapes(new List<List<ShapeModel>> { c2x3, edges, rectangle3x5, rectangle3x7, rectangle3x4_BottomLeft, rectangle3x4_TopRight, square3x3 });


        return shapes;
    }


    private static List<ShapeModel> Shapes_9008(in List<string> words, in List<string> end, in List<int> len, LetterIndexModel letterIndex)
    {

        var edges = EdgeCalculator.Execute(
            words: words,
            scoreMin: 22,
            widthMax: 12,
            heightMax: 10);


        var outer2x3 = OuterCalculator.C2x3(
            letterIndex: letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: 130,
            widthMax: 12,
            heightMax: 10);


        var rectangle3x4 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 58,
            widthMax: 12,
            heightMax: 10);


        var rectangle4x5 = RectangleCalculator.Rectangle(
            interlockWidth: 3,
            interlockHeight: 4,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 92,
            widthMax: 12,
            heightMax: 7);


        var square3x3 = RectangleCalculator.Square(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 80,
            widthMax: 12,
            heightMax: 7);


        var square3x3_BottomRight = RectangleCalculator.BottomRightSquare(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 66,
            widthMax: 9,
            heightMax: 9);


        var square3x3_TopLeft = RectangleCalculator.TopLeftSquare(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 80,
            widthMax: 14,
            heightMax: 7);


        var shapes = ShapeCalculator.CombineShapes(new List<List<ShapeModel>> { edges, outer2x3, rectangle3x4, rectangle4x5, square3x3, square3x3_BottomRight, square3x3_TopLeft });


        return shapes;
    }


    private static List<ShapeModel> Shapes_9009(in List<string> words, in List<string> end, in List<int> len, LetterIndexModel letterIndex)
    {

        var c2x2 = ClusterCalculator.C2x2(
            letterIndex: letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: 82,
            widthMax: 11,
            heightMax: 10);


        var c2x4 = ClusterCalculator.C2x4(
            letterIndex: letterIndex,
            words: words,
            end: end,


            len: len,
            scoreMin: 150,
            widthMax: 13,
            heightMax: 9);


        var edges = EdgeCalculator.Execute(
            words: words,
            scoreMin: 22,
            widthMax: 9,
            heightMax: 8);


        var rectangle3x4 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 112,
            widthMax: 8,
            heightMax: 6);


        var rectangle3x4_BottomLeft = RectangleCalculator.BottomLeftRectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 60,
            widthMax: 8,
            heightMax: 7);


        var square3x3 = RectangleCalculator.Square(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 82,
            widthMax: 11,
            heightMax: 8);


        var square4x4 = RectangleCalculator.Square(
            interlockWidth: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 96,
            widthMax: 10,
            heightMax: 9);


        var shapes = ShapeCalculator.CombineShapes(new List<List<ShapeModel>> { c2x2, c2x4, edges, rectangle3x4, rectangle3x4_BottomLeft, square3x3, square4x4 });


        return shapes;
    }


    private static List<ShapeModel> Shapes_9010(in List<string> words, in List<string> end, in List<int> len, LetterIndexModel letterIndex)
    {

        var c2x3 = ClusterCalculator.C2x3(
            letterIndex: letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: 100,
            widthMax: 8,
            heightMax: 7);


        var c3x4 = ClusterCalculator.C3x4(
            letterIndex: letterIndex,
            words: words,
            end: end,


            len: len,
            scoreMin: 170,
            widthMax: 10,
            heightMax: 8);


        var edges = EdgeCalculator.Execute(
            words: words,
            scoreMin: 24,
            widthMax: 8,
            heightMax: 7);


        var rectangle3x4 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 72,
            widthMax: 10,
            heightMax: 8);


        var rectangle3x5_BottomRight = RectangleCalculator.BottomRightRectangle(
            interlockWidth: 2,
            interlockHeight: 4,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 66,
            widthMax: 10,
            heightMax: 8);


        var square4x4_TopRight = RectangleCalculator.TopRightSquare(
            interlockWidth: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 74,
            widthMax: 10,
            heightMax: 8);


        var shapes = ShapeCalculator.CombineShapes(new List<List<ShapeModel>> { c2x3, c3x4, edges, rectangle3x4, rectangle3x5_BottomRight, square4x4_TopRight });


        return shapes;
    }


    private static List<ShapeModel> Shapes_9011(in List<string> words, in List<string> end, in List<int> len, LetterIndexModel letterIndex)
    {

        var c2x3 = ClusterCalculator.C2x3(
            letterIndex: letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: 104,
            widthMax: 9,
            heightMax: 7);


        var edges = EdgeCalculator.Execute(
            words: words,
            scoreMin: 24,
            widthMax: 10,
            heightMax: 7);


        var rectangle3x4 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 96,
            widthMax: 9,
            heightMax: 8);


        var rectangle3x4_BottomLeft = RectangleCalculator.BottomLeftRectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 74,
            widthMax: 11,
            heightMax: 7);


        var square3x3 = RectangleCalculator.Square(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 64,
            widthMax: 12,
            heightMax: 8);


        var square3x3_TopRight = RectangleCalculator.TopRightSquare(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 52,
            widthMax: 10,
            heightMax: 8);


        var shapes = ShapeCalculator.CombineShapes(new List<List<ShapeModel>> { c2x3, edges, rectangle3x4, rectangle3x4_BottomLeft, square3x3, square3x3_TopRight });


        return shapes;
    }


    private static List<ShapeModel> Shapes_9012(in List<string> words, in List<string> end, in List<int> len, LetterIndexModel letterIndex)
    {
        var c2x2 = ClusterCalculator.C2x2(
            letterIndex: letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: 78,
            widthMax: 11,
            heightMax: 8);

        var edges = EdgeCalculator.Execute(
            words: words,
            scoreMin: 22,
            widthMax: 8,
            heightMax: 8);

        var rectangle3x4 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 74,
            widthMax: 10,
            heightMax: 8);

        var square3x3 = RectangleCalculator.Square(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 72,
            widthMax: 8,
            heightMax: 7);

        var square3x3_TopLeft = RectangleCalculator.TopLeftSquare(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 72,
            widthMax: 11,
            heightMax: 9);

        var square3x3_TopRight = RectangleCalculator.TopRightSquare(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 62,
            widthMax: 9,
            heightMax: 6);

        var shapes = ShapeCalculator.CombineShapes(new List<List<ShapeModel>> { c2x2, edges, rectangle3x4, square3x3, square3x3_TopLeft, square3x3_TopRight });

        return shapes;
    }


    private static List<ShapeModel> Shapes_9101(in List<string> words, in List<string> end, in List<int> len, LetterIndexModel letterIndex)
    {
        var c2x2 = ClusterCalculator.C2x2(
            letterIndex: letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: 82,
            widthMax: 9,
            heightMax: 7);

        var c2x4 = ClusterCalculator.C2x4(
            letterIndex: letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: 168,
            widthMax: 10,
            heightMax: 7);

        var edges = EdgeCalculator.Execute(
            words: words,
            scoreMin: 22,
            widthMax: 11,
            heightMax: 8);

        var rectangle3x4_TopLeft = RectangleCalculator.TopLeftRectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 80,
            widthMax: 10,
            heightMax: 7);

        var special9101 = SpecialShapesCalculator.C9101(words: words);

        var square3x3_TopRight = RectangleCalculator.TopRightSquare(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 74,
            widthMax: 10,
            heightMax: 8);

        var shapes = ShapeCalculator.CombineShapes(new List<List<ShapeModel>> { c2x2, c2x4, edges, rectangle3x4_TopLeft, special9101, square3x3_TopRight });

        return shapes;
    }


    private static List<ShapeModel> Shapes_9102(in List<string> words, in List<string> end, in List<int> len, LetterIndexModel letterIndex)
    {
        var c2x3 = ClusterCalculator.C2x3(
            letterIndex: letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: 136,
            widthMax: 12,
            heightMax: 7);

        var edges = EdgeCalculator.Execute(
            words: words,
            scoreMin: 22,
            widthMax: 8,
            heightMax: 8);

        var rectangle3x6 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 5,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 96,
            widthMax: 8,
            heightMax: 6);

        var rectangle3x5_BottomLeft = RectangleCalculator.BottomLeftRectangle(
            interlockWidth: 2,
            interlockHeight: 4,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 96,
            widthMax: 8,
            heightMax: 7);

        var special9102 = SpecialShapesCalculator.C9102(words: words);

        var square3x3 = RectangleCalculator.Square(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 56,
            widthMax: 8,
            heightMax: 7);

        var shapes = ShapeCalculator.CombineShapes(new List<List<ShapeModel>> { c2x3, edges, rectangle3x6, rectangle3x5_BottomLeft, special9102, square3x3 });

        return shapes;
    }


    private static List<ShapeModel> Shapes_9103(in List<string> words, in List<string> end, in List<int> len, LetterIndexModel letterIndex)
    {
        var c2x2 = ClusterCalculator.C2x2(
            letterIndex: letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: 82,
            widthMax: 15,
            heightMax: 12);

        var edges = EdgeCalculator.Execute(
            words: words,
            scoreMin: 22,
            widthMax: 10,
            heightMax: 7);

        var rectangle3x4 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 72,
            widthMax: 12,
            heightMax: 6);

        var rectangle3x4_BottomLeft = RectangleCalculator.BottomLeftRectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 62,
            widthMax: 12,
            heightMax: 10);

        var square3x3 = RectangleCalculator.Square(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 66,
            widthMax: 11,
            heightMax: 10);

        var square4x4_TopLeft = RectangleCalculator.TopLeftSquare(
            interlockWidth: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 52,
            widthMax: 7,
            heightMax: 7);

        var shapes = ShapeCalculator.CombineShapes(new List<List<ShapeModel>> { c2x2, edges, rectangle3x4, rectangle3x4_BottomLeft, square3x3, square4x4_TopLeft });

        return shapes;
    }


    private static List<ShapeModel> Shapes_9104(in List<string> words, in List<string> end, in List<int> len, LetterIndexModel letterIndex)
    {
        var c2x4 = ClusterCalculator.C2x4(
            letterIndex: letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: 128,
            widthMax: 11,
            heightMax: 7);

        var edges = EdgeCalculator.Execute(
            words: words,
            scoreMin: 22,
            widthMax: 9,
            heightMax: 7);

        var rectangle3x4 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 78,
            widthMax: 7,
            heightMax: 7);

        var rectangle3x6 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 5,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 112,
            widthMax: 8,
            heightMax: 6);

        var square3x3 = RectangleCalculator.Square(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 68,
            widthMax: 9,
            heightMax: 8);

        var shapes = ShapeCalculator.CombineShapes(new List<List<ShapeModel>> { c2x4, edges, rectangle3x4, rectangle3x6, square3x3 });

        return shapes;
    }


    private static List<ShapeModel> Shapes_9105(in List<string> words, in List<string> end, in List<int> len, LetterIndexModel letterIndex)
    {
        var c2x4 = ClusterCalculator.C2x4(
            letterIndex: letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: 116,
            widthMax: 12,
            heightMax: 9);

        var edges = EdgeCalculator.Execute(
            words: words,
            scoreMin: 28,
            widthMax: 9,
            heightMax: 9);

        var rectangle3x4 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 98,
            widthMax: 9,
            heightMax: 9);

        var rectangle4x5 = RectangleCalculator.Rectangle(
            interlockWidth: 3,
            interlockHeight: 4,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 74,
            widthMax: 11,
            heightMax: 8);

        var rectangle3x4_TopLeft = RectangleCalculator.TopLeftRectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 60,
            widthMax: 10,
            heightMax: 10);

        var square3x3 = RectangleCalculator.Square(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 80,
            widthMax: 11,
            heightMax: 9);

        var shapes = ShapeCalculator.CombineShapes(new List<List<ShapeModel>> { c2x4, edges, rectangle3x4, rectangle4x5, rectangle3x4_TopLeft, square3x3 });

        return shapes;
    }


    private static List<ShapeModel> Shapes_9106(in List<string> words, in List<string> end, in List<int> len, LetterIndexModel letterIndex)
    {
        var edges = EdgeCalculator.Execute(
            words: words,
            scoreMin: 28,
            widthMax: 9,
            heightMax: 7);

        var rectangle3x4 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 80,
            widthMax: 11,
            heightMax: 8);

        var square3x3 = RectangleCalculator.Square(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 62,
            widthMax: 12,
            heightMax: 10);

        var shapes = ShapeCalculator.CombineShapes(new List<List<ShapeModel>> { edges, rectangle3x4, square3x3 });

        return shapes;
    }


    private static List<ShapeModel> Shapes_9107(in List<string> words, in List<string> end, in List<int> len, LetterIndexModel letterIndex)
    {
        var c2x3 = ClusterCalculator.C2x3(
            letterIndex: letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: 110,
            widthMax: 10,
            heightMax: 9);

        var edges = EdgeCalculator.Execute(
            words: words,
            scoreMin: 22,
            widthMax: 9,
            heightMax: 7);

        var rectangle3x4 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 68,
            widthMax: 10,
            heightMax: 9);

        var rectangle3x4_TopRight = RectangleCalculator.TopRightRectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 72,
            widthMax: 9,
            heightMax: 9);

        var square3x3 = RectangleCalculator.Square(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 82,
            widthMax: 9,
            heightMax: 6);

        var square4x4 = RectangleCalculator.Square(
            interlockWidth: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 84,
            widthMax: 9,
            heightMax: 8);

        var square3x3_TopRight = RectangleCalculator.TopRightSquare(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 58,
            widthMax: 8,
            heightMax: 7);

        var shapes = ShapeCalculator.CombineShapes(new List<List<ShapeModel>> { c2x3, edges, rectangle3x4, rectangle3x4_TopRight, square3x3, square4x4, square3x3_TopRight });

        return shapes;
    }


    private static List<ShapeModel> Shapes_9108(in List<string> words, in List<string> end, in List<int> len, LetterIndexModel letterIndex)
    {
        var c2x3 = ClusterCalculator.C2x3(
            letterIndex: letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: 132,
            widthMax: 12,
            heightMax: 8);

        var edges = EdgeCalculator.Execute(
            words: words,
            scoreMin: 22,
            widthMax: 8,
            heightMax: 7);

        var rectangle3x4 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 64,
            widthMax: 8,
            heightMax: 7);

        var rectangle4x5 = RectangleCalculator.Rectangle(
            interlockWidth: 3,
            interlockHeight: 4,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 84,
            widthMax: 9,
            heightMax: 8);

        var square3x3 = RectangleCalculator.Square(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 84,
            widthMax: 8,
            heightMax: 8);

        var square3x3_TopRight = RectangleCalculator.TopRightSquare(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 88,
            widthMax: 9,
            heightMax: 9);

        var shapes = ShapeCalculator.CombineShapes(new List<List<ShapeModel>> { c2x3, edges, rectangle3x4, rectangle4x5, square3x3, square3x3_TopRight });

        return shapes;
    }


    private static List<ShapeModel> Shapes_9109(in List<string> words, in List<string> end, in List<int> len, LetterIndexModel letterIndex)
    {
        var edges = EdgeCalculator.Execute(
            words: words,
            scoreMin: 28,
            widthMax: 10,
            heightMax: 9);

        var rectangle3x4 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 68,
            widthMax: 8,
            heightMax: 7);

        var rectangle3x5 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 4,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 66,
            widthMax: 8,
            heightMax: 8);

        var rectangle3x4_TopLeft = RectangleCalculator.TopLeftRectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 82,
            widthMax: 11,
            heightMax: 9);

        var special9109 = SpecialShapesCalculator.C9109(words: words);

        var square3x3 = RectangleCalculator.Square(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 74,
            widthMax: 11,
            heightMax: 7);

        var square4x4 = RectangleCalculator.Square(
            interlockWidth: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 78,
            widthMax: 8,
            heightMax: 6);

        var square3x3_BottomRight = RectangleCalculator.BottomRightSquare(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 96,
            widthMax: 7,
            heightMax: 7);

        var shapes = ShapeCalculator.CombineShapes(new List<List<ShapeModel>> { edges, rectangle3x4, rectangle3x5, rectangle3x4_TopLeft, special9109, square3x3, square4x4, square3x3_BottomRight });

        return shapes;
    }


    private static List<ShapeModel> Shapes_9110(in List<string> words, in List<string> end, in List<int> len, LetterIndexModel letterIndex)
    {
        var c2x2 = ClusterCalculator.C2x2(
            letterIndex: letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: 84,
            widthMax: 13,
            heightMax: 10);

        var edges = EdgeCalculator.Execute(
            words: words,
            scoreMin: 22,
            widthMax: 9,
            heightMax: 7);

        var rectangle3x4 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 78,
            widthMax: 10,
            heightMax: 9);

        var square3x3 = RectangleCalculator.Square(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 80,
            widthMax: 15,
            heightMax: 12);

        var square4x4_BottomRight = RectangleCalculator.BottomRightSquare(
            interlockWidth: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 76,
            widthMax: 8,
            heightMax: 8);

        var shapes = ShapeCalculator.CombineShapes(new List<List<ShapeModel>> { c2x2, edges, rectangle3x4, square3x3, square4x4_BottomRight });

        return shapes;
    }


    private static List<ShapeModel> Shapes_9111(in List<string> words, in List<string> end, in List<int> len, LetterIndexModel letterIndex)
    {
        var edges = EdgeCalculator.Execute(
            words: words,
            scoreMin: 28,
            widthMax: 10,
            heightMax: 8);

        var rectangle3x4 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 76,
            widthMax: 10,
            heightMax: 8);

        var rectangle3x5 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 4,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 104,
            widthMax: 12,
            heightMax: 8);

        var square3x3 = RectangleCalculator.Square(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 56,
            widthMax: 12,
            heightMax: 10);

        var shapes = ShapeCalculator.CombineShapes(new List<List<ShapeModel>> { edges, rectangle3x4, rectangle3x5, square3x3 });

        return shapes;
    }


    private static List<ShapeModel> Shapes_9112(in List<string> words, in List<string> end, in List<int> len, LetterIndexModel letterIndex)
    {
        var c2x2 = ClusterCalculator.C2x2(
            letterIndex: letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: 86,
            widthMax: 12,
            heightMax: 11);

        var edges = EdgeCalculator.Execute(
            words: words,
            scoreMin: 28,
            widthMax: 10,
            heightMax: 8);

        var rectangle3x4 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 82,
            widthMax: 10,
            heightMax: 8);

        var square3x3 = RectangleCalculator.Square(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 128,
            widthMax: 10,
            heightMax: 9);

        var shapes = ShapeCalculator.CombineShapes(new List<List<ShapeModel>> { c2x2, edges, rectangle3x4, square3x3 });

        return shapes;
    }


    private static List<ShapeModel> Shapes_9201(in List<string> words, in List<string> end, in List<int> len, LetterIndexModel letterIndex)
    {
        var edges = EdgeCalculator.Execute(
            words: words,
            scoreMin: 22,
            widthMax: 12,
            heightMax: 11);

        var rectangle3x4 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 62,
            widthMax: 12,
            heightMax: 10);

        var square3x3 = RectangleCalculator.Square(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 70,
            widthMax: 12,
            heightMax: 11);

        var square3x3_TopRight = RectangleCalculator.TopRightSquare(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 80,
            widthMax: 10,
            heightMax: 8);

        var shapes = ShapeCalculator.CombineShapes(new List<List<ShapeModel>> { edges, rectangle3x4, square3x3, square3x3_TopRight });

        return shapes;
    }


    private static List<ShapeModel> Shapes_9202(in List<string> words, in List<string> end, in List<int> len, LetterIndexModel letterIndex)
    {
        var edges = EdgeCalculator.Execute(
            words: words,
            scoreMin: 24,
            widthMax: 9,
            heightMax: 8);

        var rectangle3x4 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 70,
            widthMax: 10,
            heightMax: 9);

        var square3x3 = RectangleCalculator.Square(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 140,
            widthMax: 10,
            heightMax: 9);

        var square3x3_TopRight = RectangleCalculator.TopRightSquare(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 60,
            widthMax: 12,
            heightMax: 8);

        var shapes = ShapeCalculator.CombineShapes(new List<List<ShapeModel>> { edges, rectangle3x4, square3x3, square3x3_TopRight });

        return shapes;
    }


    private static List<ShapeModel> Shapes_9203(in List<string> words, in List<string> end, in List<int> len, LetterIndexModel letterIndex)
    {
        var c2x4 = ClusterCalculator.C2x4(
            letterIndex: letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: 166,
            widthMax: 12,
            heightMax: 7);


        var edges = EdgeCalculator.Execute(
            words: words,
            scoreMin: 22,
            widthMax: 9,
            heightMax: 9);


        var rectangle3x4 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 106,
            widthMax: 9,
            heightMax: 9);


        var square3x3 = RectangleCalculator.Square(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 62,
            widthMax: 9,
            heightMax: 9);


        var shapes = ShapeCalculator.CombineShapes(new List<List<ShapeModel>> { c2x4, edges, rectangle3x4, square3x3 });


        return shapes;
    }


    private static List<ShapeModel> Shapes_9204(in List<string> words, in List<string> end, in List<int> len, LetterIndexModel letterIndex)
    {

        var edges = EdgeCalculator.Execute(
            words: words,
            scoreMin: 22,
            widthMax: 10,
            heightMax: 7);


        var rectangle3x4 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 76,
            widthMax: 10,
            heightMax: 7);


        var special9204 = SpecialShapesCalculator.C9204(words: words);


        var square3x3 = RectangleCalculator.Square(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 88,
            widthMax: 8,
            heightMax: 7);


        var shapes = ShapeCalculator.CombineShapes(new List<List<ShapeModel>> { edges, rectangle3x4, special9204, square3x3 });


        return shapes;
    }


    private static List<ShapeModel> Shapes_9206(in List<string> words, in List<string> end, in List<int> len, LetterIndexModel letterIndex)
    {

        var c2x3 = ClusterCalculator.C2x3(
            letterIndex: letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: 102,
            widthMax: 11,
            heightMax: 9);


        var edges = EdgeCalculator.Execute(
            words: words,
            scoreMin: 22,
            widthMax: 9,
            heightMax: 8);


        var rectangle3x5 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 4,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 84,
            widthMax: 8,
            heightMax: 8);


        var rectangle3x4_BottomRight = RectangleCalculator.BottomRightRectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 54,
            widthMax: 9,
            heightMax: 9);


        var square3x3 = RectangleCalculator.Square(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 60,
            widthMax: 12,
            heightMax: 8);


        var square3x3_BottomRight = RectangleCalculator.BottomRightSquare(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 74,
            widthMax: 10,
            heightMax: 8);


        var shapes = ShapeCalculator.CombineShapes(new List<List<ShapeModel>> { c2x3, edges, rectangle3x5, rectangle3x4_BottomRight, square3x3, square3x3_BottomRight });


        return shapes;
    }


    private static List<ShapeModel> Shapes_9207(in List<string> words, in List<string> end, in List<int> len, LetterIndexModel letterIndex)
    {

        var edges = EdgeCalculator.Execute(
            words: words,
            scoreMin: 36,
            widthMax: 11,
            heightMax: 8);


        var rectangle3x4 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 82,
            widthMax: 11,
            heightMax: 10);


        var rectangle3x4_BottomRight = RectangleCalculator.BottomRightRectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 80,
            widthMax: 11,
            heightMax: 8);


        var square3x3 = RectangleCalculator.Square(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 86,
            widthMax: 11,
            heightMax: 10);


        var shapes = ShapeCalculator.CombineShapes(new List<List<ShapeModel>> { edges, rectangle3x4, rectangle3x4_BottomRight, square3x3 });


        return shapes;
    }


    private static List<ShapeModel> Shapes_9208(in List<string> words, in List<string> end, in List<int> len, LetterIndexModel letterIndex)
    {

        var edges = EdgeCalculator.Execute(
            words: words,
            scoreMin: 24,
            widthMax: 12,
            heightMax: 10);


        var rectangle3x4 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 66,
            widthMax: 12,
            heightMax: 9);


        var rectangle3x5 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 4,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 120,
            widthMax: 12,
            heightMax: 12);


        var rectangle5x6 = RectangleCalculator.Rectangle(
            interlockWidth: 4,
            interlockHeight: 5,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 140,
            widthMax: 13,
            heightMax: 12);


        var square3x3 = RectangleCalculator.Square(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 82,
            widthMax: 12,
            heightMax: 10);


        var shapes = ShapeCalculator.CombineShapes(new List<List<ShapeModel>> { edges, rectangle3x4, rectangle3x5, rectangle5x6, square3x3 });


        return shapes;
    }


    private static List<ShapeModel> Shapes_9209(in List<string> words, in List<string> end, in List<int> len, LetterIndexModel letterIndex)
    {
        var pacman3x3_BottomRight = PacmanCalculator.BottomRight3x3(
            letterIndex: letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: 124,
            widthMax: 10,
            heightMax: 10);

        var edges = EdgeCalculator.Execute(
            words: words,
            scoreMin: 22,
            widthMax: 11,
            heightMax: 8);

        var rectangle3x4 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 58,
            widthMax: 12,
            heightMax: 9);

        var special9209 = SpecialShapesCalculator.C9209(words: words);

        var square3x3 = RectangleCalculator.Square(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 74,
            widthMax: 11,
            heightMax: 8);

        var shapes = ShapeCalculator.CombineShapes(new List<List<ShapeModel>> {
            pacman3x3_BottomRight, // We have 2 of these but it should be just 1
            edges,
            rectangle3x4,
            special9209,
            square3x3 });

        //Console.WriteLine(ShapeCalculator.ToTextDebug(edges[0], words);
        //Console.WriteLine(ShapeCalculator.ToTextDebug(pacman3x3_BottomRight[1], words);
        //Console.WriteLine(ShapeCalculator.ToTextDebug(pacman3x3_BottomRight[0], words);
        
        return shapes;
    }


    private static List<ShapeModel> Shapes_9210(in List<string> words, in List<string> end, in List<int> len, LetterIndexModel letterIndex)
    {

        var c2x3 = ClusterCalculator.C2x3(
            letterIndex: letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: 100,
            widthMax: 12,
            heightMax: 9);


        var edges = EdgeCalculator.Execute(
            words: words,
            scoreMin: 22,
            widthMax: 12,
            heightMax: 7);


        var rectangle3x5 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 4,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 112,
            widthMax: 12,
            heightMax: 8);


        var square3x3 = RectangleCalculator.Square(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 64,
            widthMax: 14,
            heightMax: 7);


        var square3x3_BottomRight = RectangleCalculator.BottomRightSquare(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 76,
            widthMax: 8,
            heightMax: 8);


        var square3x3_TopLeft = RectangleCalculator.TopLeftSquare(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 72,
            widthMax: 9,
            heightMax: 9);


        var shapes = ShapeCalculator.CombineShapes(new List<List<ShapeModel>> { c2x3, edges, rectangle3x5, square3x3, square3x3_BottomRight, square3x3_TopLeft });


        return shapes;
    }


    private static List<ShapeModel> Shapes_9211(in List<string> words, in List<string> end, in List<int> len, LetterIndexModel letterIndex)
    {

        var c2x2 = ClusterCalculator.C2x2(
            letterIndex: letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: 96,
            widthMax: 13,
            heightMax: 10);


        var edges = EdgeCalculator.Execute(
            words: words,
            scoreMin: 22,
            widthMax: 11,
            heightMax: 8);


        var rectangle3x5 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 4,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 126,
            widthMax: 11,
            heightMax: 7);


        var rectangle3x4_BottomRight = RectangleCalculator.BottomRightRectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 80,
            widthMax: 11,
            heightMax: 9);


        var square3x3 = RectangleCalculator.Square(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 66,
            widthMax: 12,
            heightMax: 8);


        var square4x4 = RectangleCalculator.Square(
            interlockWidth: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 82,
            widthMax: 9,
            heightMax: 7);


        var shapes = ShapeCalculator.CombineShapes(new List<List<ShapeModel>> { c2x2, edges, rectangle3x5, rectangle3x4_BottomRight, square3x3, square4x4 });


        return shapes;
    }


    private static List<ShapeModel> Shapes_9212(in List<string> words, in List<string> end, in List<int> len, LetterIndexModel letterIndex)
    {

        var c2x2 = ClusterCalculator.C2x2(
            letterIndex: letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: 82,
            widthMax: 11,
            heightMax: 9);


        var edges = EdgeCalculator.Execute(
            words: words,
            scoreMin: 22,
            widthMax: 10,
            heightMax: 8);


        var rectangle3x4 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 118,
            widthMax: 10,
            heightMax: 10);


        var rectangle4x5 = RectangleCalculator.Rectangle(
            interlockWidth: 3,
            interlockHeight: 4,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 96,
            widthMax: 10,
            heightMax: 8);


        var rectangle3x4_TopRight = RectangleCalculator.TopRightRectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 68,
            widthMax: 10,
            heightMax: 8);


        var square3x3 = RectangleCalculator.Square(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 68,
            widthMax: 12,
            heightMax: 10);


        var shapes = ShapeCalculator.CombineShapes(new List<List<ShapeModel>> { c2x2, edges, rectangle3x4, rectangle4x5, rectangle3x4_TopRight, square3x3 });


        return shapes;
    }


    private static List<ShapeModel> Shapes_9301(in List<string> words, in List<string> end, in List<int> len, LetterIndexModel letterIndex)
    {

        var edges = EdgeCalculator.Execute(
            words: words,
            scoreMin: 22,
            widthMax: 10,
            heightMax: 7);


        var rectangle3x4 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 84,
            widthMax: 10,
            heightMax: 9);


        var rectangle3x4_BottomLeft = RectangleCalculator.BottomLeftRectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 128,
            widthMax: 11,
            heightMax: 10);


        var rectangle4x5_BottomLeft = RectangleCalculator.BottomLeftRectangle(
            interlockWidth: 3,
            interlockHeight: 4,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 104,
            widthMax: 7,
            heightMax: 7);


        var square3x3 = RectangleCalculator.Square(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 62,
            widthMax: 10,
            heightMax: 8);


        var shapes = ShapeCalculator.CombineShapes(new List<List<ShapeModel>> { edges, rectangle3x4, rectangle3x4_BottomLeft, rectangle4x5_BottomLeft, square3x3 });


        return shapes;
    }


    private static List<ShapeModel> Shapes_9302(in List<string> words, in List<string> end, in List<int> len, LetterIndexModel letterIndex)
    {

        var edges = EdgeCalculator.Execute(
            words: words,
            scoreMin: 22,
            widthMax: 11,
            heightMax: 10);


        var square3x3 = RectangleCalculator.Square(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 62,
            widthMax: 12,
            heightMax: 8);


        var square3x3_BottomRight = RectangleCalculator.BottomRightSquare(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 68,
            widthMax: 13,
            heightMax: 8);


        var shapes = ShapeCalculator.CombineShapes(new List<List<ShapeModel>> { edges, square3x3, square3x3_BottomRight });


        return shapes;
    }


    private static List<ShapeModel> Shapes_9303(in List<string> words, in List<string> end, in List<int> len, LetterIndexModel letterIndex)
    {

        var c2x2 = ClusterCalculator.C2x2(
            letterIndex: letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: 98,
            widthMax: 10,
            heightMax: 10);


        var edges = EdgeCalculator.Execute(
            words: words,
            scoreMin: 22,
            widthMax: 9,
            heightMax: 7);


        var rectangle3x4 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 88,
            widthMax: 8,
            heightMax: 8);


        var rectangle3x5 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 4,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 106,
            widthMax: 10,
            heightMax: 10);


        var rectangle3x4_TopLeft = RectangleCalculator.TopLeftRectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 88,
            widthMax: 7,
            heightMax: 7);


        var square3x3 = RectangleCalculator.Square(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 74,
            widthMax: 10,
            heightMax: 8);


        var square4x4 = RectangleCalculator.Square(
            interlockWidth: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 108,
            widthMax: 12,
            heightMax: 10);


        var square3x3_TopRight = RectangleCalculator.TopRightSquare(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 64,
            widthMax: 11,
            heightMax: 8);


        var shapes = ShapeCalculator.CombineShapes(new List<List<ShapeModel>> { c2x2, edges, rectangle3x4, rectangle3x5, rectangle3x4_TopLeft, square3x3, square4x4, square3x3_TopRight });


        return shapes;
    }


    private static List<ShapeModel> Shapes_9304(in List<string> words, in List<string> end, in List<int> len, LetterIndexModel letterIndex)
    {

        var c2x2 = ClusterCalculator.C2x2(
            letterIndex: letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: 130,
            widthMax: 13,
            heightMax: 11);


        var c2x3 = ClusterCalculator.C2x3(
            letterIndex: letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: 132,
            widthMax: 10,
            heightMax: 6);


        var c2x4 = ClusterCalculator.C2x4(
            letterIndex: letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: 122,
            widthMax: 12,
            heightMax: 11);


        var edges = EdgeCalculator.Execute(
            words: words,
            scoreMin: 22,
            widthMax: 9,
            heightMax: 7);


        var rectangle3x5 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 4,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 70,
            widthMax: 11,
            heightMax: 8);


        var rectangle3x4_BottomRight = RectangleCalculator.BottomRightRectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 66,
            widthMax: 9,
            heightMax: 8);


        var square3x3 = RectangleCalculator.Square(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 58,
            widthMax: 11,
            heightMax: 8);


        var square3x3_TopRight = RectangleCalculator.TopRightSquare(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 60,
            widthMax: 10,
            heightMax: 7);


        var shapes = ShapeCalculator.CombineShapes(new List<List<ShapeModel>> { c2x2, c2x3, c2x4, edges, rectangle3x5, rectangle3x4_BottomRight, square3x3, square3x3_TopRight });


        return shapes;
    }


    private static List<ShapeModel> Shapes_9305(in List<string> words, in List<string> end, in List<int> len, LetterIndexModel letterIndex)
    {

        var c2x3 = ClusterCalculator.C2x3(
            letterIndex: letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: 104,
            widthMax: 10,
            heightMax: 7);


        var edges = EdgeCalculator.Execute(
            words: words,
            scoreMin: 22,
            widthMax: 10,
            heightMax: 8);


        var rectangle3x4 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 96,
            widthMax: 10,
            heightMax: 8);


        var rectangle3x6 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 5,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 106,
            widthMax: 9,
            heightMax: 8);


        var square3x3 = RectangleCalculator.Square(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 84,
            widthMax: 9,
            heightMax: 8);


        var shapes = ShapeCalculator.CombineShapes(new List<List<ShapeModel>> { c2x3, edges, rectangle3x4, rectangle3x6, square3x3 });


        return shapes;
    }


    private static List<ShapeModel> Shapes_9306(in List<string> words, in List<string> end, in List<int> len, LetterIndexModel letterIndex)
    {

        var edges = EdgeCalculator.Execute(
            words: words,
            scoreMin: 22,
            widthMax: 11,
            heightMax: 9);


        var rectangle3x4 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 96,
            widthMax: 11,
            heightMax: 10);


        var rectangle3x6 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 5,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 88,
            widthMax: 15,
            heightMax: 11);


        var rectangle5x6 = RectangleCalculator.Rectangle(
            interlockWidth: 4,
            interlockHeight: 5,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 146,
            widthMax: 13,
            heightMax: 11);


        var square3x3 = RectangleCalculator.Square(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 68,
            widthMax: 12,
            heightMax: 8);


        var shapes = ShapeCalculator.CombineShapes(new List<List<ShapeModel>> { edges, rectangle3x4, rectangle3x6, rectangle5x6, square3x3 });


        return shapes;
    }


    private static List<ShapeModel> Shapes_9307(in List<string> words, in List<string> end, in List<int> len, LetterIndexModel letterIndex)
    {

        var edges = EdgeCalculator.Execute(
            words: words,
            scoreMin: 22,
            widthMax: 11,
            heightMax: 9);


        var rectangle3x4 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 130,
            widthMax: 11,
            heightMax: 8);


        var square3x3 = RectangleCalculator.Square(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 106,
            widthMax: 12,
            heightMax: 10);


        var square3x3_TopLeft = RectangleCalculator.TopLeftSquare(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 50,
            widthMax: 10,
            heightMax: 7);


        var square5x5_TopRight = RectangleCalculator.TopRightSquare(
            interlockWidth: 4,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 84,
            widthMax: 8,
            heightMax: 7);


        var shapes = ShapeCalculator.CombineShapes(new List<List<ShapeModel>> { edges, rectangle3x4, square3x3, square3x3_TopLeft, square5x5_TopRight });


        return shapes;
    }


    private static List<ShapeModel> Shapes_9308(in List<string> words, in List<string> end, in List<int> len, LetterIndexModel letterIndex)
    {

        var c2x2 = ClusterCalculator.C2x2(
            letterIndex: letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: 68,
            widthMax: 15,
            heightMax: 12);


        var edges = EdgeCalculator.Execute(
            words: words,
            scoreMin: 24,
            widthMax: 11,
            heightMax: 8);


        var rectangle3x4_BottomRight = RectangleCalculator.BottomRightRectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 82,
            widthMax: 9,
            heightMax: 7);


        var square3x3 = RectangleCalculator.Square(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 68,
            widthMax: 13,
            heightMax: 9);


        var square5x5 = RectangleCalculator.Square(
            interlockWidth: 4,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 90,
            widthMax: 8,
            heightMax: 8);


        var shapes = ShapeCalculator.CombineShapes(new List<List<ShapeModel>> { c2x2, edges, rectangle3x4_BottomRight, square3x3, square5x5 });


        return shapes;
    }


    private static List<ShapeModel> Shapes_9309(in List<string> words, in List<string> end, in List<int> len, LetterIndexModel letterIndex)
    {

        var c2x2 = ClusterCalculator.C2x2(
            letterIndex: letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: 68,
            widthMax: 12,
            heightMax: 8);


        var edges = EdgeCalculator.Execute(
            words: words,
            scoreMin: 24,
            widthMax: 11,
            heightMax: 7);


        var rectangle3x4 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 130,
            widthMax: 12,
            heightMax: 11);


        var rectangle4x5 = RectangleCalculator.Rectangle(
            interlockWidth: 3,
            interlockHeight: 4,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 104,
            widthMax: 11,
            heightMax: 7);


        var square3x3 = RectangleCalculator.Square(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 56,
            widthMax: 12,
            heightMax: 11);


        var square3x3_TopRight = RectangleCalculator.TopRightSquare(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 66,
            widthMax: 13,
            heightMax: 8);


        var shapes = ShapeCalculator.CombineShapes(new List<List<ShapeModel>> { c2x2, edges, rectangle3x4, rectangle4x5, square3x3, square3x3_TopRight });


        return shapes;
    }


    private static List<ShapeModel> Shapes_9310(in List<string> words, in List<string> end, in List<int> len, LetterIndexModel letterIndex)
    {

        var edges = EdgeCalculator.Execute(
            words: words,
            scoreMin: 36,
            widthMax: 13,
            heightMax: 11);


        var rectangle3x4 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 108,
            widthMax: 13,
            heightMax: 10);


        var square3x3 = RectangleCalculator.Square(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 76,
            widthMax: 13,
            heightMax: 12);


        var square3x3_TopLeft = RectangleCalculator.TopLeftSquare(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 80,
            widthMax: 16,
            heightMax: 12);


        var shapes = ShapeCalculator.CombineShapes(new List<List<ShapeModel>> { edges, rectangle3x4, square3x3, square3x3_TopLeft });


        return shapes;
    }


    private static List<ShapeModel> Shapes_9311(in List<string> words, in List<string> end, in List<int> len, LetterIndexModel letterIndex)
    {

        var edges = EdgeCalculator.Execute(
            words: words,
            scoreMin: 22,
            widthMax: 11,
            heightMax: 9);


        var rectangle3x4 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 96,
            widthMax: 15,
            heightMax: 9);


        var rectangle3x5 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 4,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 82,
            widthMax: 10,
            heightMax: 6);


        var rectangle3x4_TopLeft = RectangleCalculator.TopLeftRectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 68,
            widthMax: 10,
            heightMax: 9);


        var square3x3 = RectangleCalculator.Square(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 112,
            widthMax: 12,
            heightMax: 9);


        var square4x4_BottomRight = RectangleCalculator.BottomRightSquare(
            interlockWidth: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 72,
            widthMax: 10,
            heightMax: 6);


        var shapes = ShapeCalculator.CombineShapes(new List<List<ShapeModel>> { edges, rectangle3x4, rectangle3x5, rectangle3x4_TopLeft, square3x3, square4x4_BottomRight });


        return shapes;
    }


    private static List<ShapeModel> Shapes_9312(in List<string> words, in List<string> end, in List<int> len, LetterIndexModel letterIndex)
    {

        var c2x3 = ClusterCalculator.C2x3(
            letterIndex: letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: 112,
            widthMax: 15,
            heightMax: 11);


        var edges = EdgeCalculator.Execute(
            words: words,
            scoreMin: 22,
            widthMax: 11,
            heightMax: 10);


        var rectangle3x4 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 124,
            widthMax: 12,
            heightMax: 9);


        var square4x4 = RectangleCalculator.Square(
            interlockWidth: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 84,
            widthMax: 11,
            heightMax: 7);


        var shapes = ShapeCalculator.CombineShapes(new List<List<ShapeModel>> { c2x3, edges, rectangle3x4, square4x4 });


        return shapes;
    }


    private static List<ShapeModel> Shapes_9401(in List<string> words, in List<string> end, in List<int> len, LetterIndexModel letterIndex)
    {

        var edges = EdgeCalculator.Execute(
            words: words,
            scoreMin: 22,
            widthMax: 10,
            heightMax: 8);


        var rectangle3x4 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 92,
            widthMax: 11,
            heightMax: 9);


        var rectangle4x5 = RectangleCalculator.Rectangle(
            interlockWidth: 3,
            interlockHeight: 4,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 88,
            widthMax: 9,
            heightMax: 8);


        var shapes = ShapeCalculator.CombineShapes(new List<List<ShapeModel>> { edges, rectangle3x4, rectangle4x5 });


        return shapes;
    }


    private static List<ShapeModel> Shapes_9402(in List<string> words, in List<string> end, in List<int> len, LetterIndexModel letterIndex)
    {

        var c2x3 = ClusterCalculator.C2x3(
            letterIndex: letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: 102,
            widthMax: 15,
            heightMax: 12);


        var edges = EdgeCalculator.Execute(
            words: words,
            scoreMin: 22,
            widthMax: 13,
            heightMax: 9);


        var rectangle3x4 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 82,
            widthMax: 10,
            heightMax: 9);


        var rectangle3x5 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 4,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 82,
            widthMax: 9,
            heightMax: 9);


        var rectangle3x4_BottomLeft = RectangleCalculator.BottomLeftRectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 72,
            widthMax: 9,
            heightMax: 8);


        var square3x3 = RectangleCalculator.Square(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 92,
            widthMax: 17,
            heightMax: 10);


        var square4x4 = RectangleCalculator.Square(
            interlockWidth: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 88,
            widthMax: 9,
            heightMax: 8);


        var square5x5 = RectangleCalculator.Square(
            interlockWidth: 4,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 64,
            widthMax: 13,
            heightMax: 8);


        var shapes = ShapeCalculator.CombineShapes(new List<List<ShapeModel>> { c2x3, edges, rectangle3x4, rectangle3x5, rectangle3x4_BottomLeft, square3x3, square4x4, square5x5 });


        return shapes;
    }


    private static List<ShapeModel> Shapes_9403(in List<string> words, in List<string> end, in List<int> len, LetterIndexModel letterIndex)
    {

        var edges = EdgeCalculator.Execute(
            words: words,
            scoreMin: 22,
            widthMax: 9,
            heightMax: 7);


        var rectangle3x4 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 82,
            widthMax: 13,
            heightMax: 8);


        var rectangle4x6 = RectangleCalculator.Rectangle(
            interlockWidth: 3,
            interlockHeight: 5,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 82,
            widthMax: 10,
            heightMax: 8);


        var rectangle3x4_TopRight = RectangleCalculator.TopRightRectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 72,
            widthMax: 14,
            heightMax: 8);


        var square3x3 = RectangleCalculator.Square(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 68,
            widthMax: 15,
            heightMax: 9);


        var square4x4 = RectangleCalculator.Square(
            interlockWidth: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 88,
            widthMax: 8,
            heightMax: 8);


        var square3x3_BottomRight = RectangleCalculator.BottomRightSquare(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 54,
            widthMax: 14,
            heightMax: 9);


        var shapes = ShapeCalculator.CombineShapes(new List<List<ShapeModel>> { edges, rectangle3x4, rectangle4x6, rectangle3x4_TopRight, square3x3, square4x4, square3x3_BottomRight });


        return shapes;
    }


    private static List<ShapeModel> Shapes_9404(in List<string> words, in List<string> end, in List<int> len, LetterIndexModel letterIndex)
    {

        var edges = EdgeCalculator.Execute(
            words: words,
            scoreMin: 24,
            widthMax: 9,
            heightMax: 8);


        var rectangle3x4 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 118,
            widthMax: 13,
            heightMax: 8);


        var rectangle3x5 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 4,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 78,
            widthMax: 15,
            heightMax: 9);


        var rectangle3x4_BottomLeft = RectangleCalculator.BottomLeftRectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 52,
            widthMax: 9,
            heightMax: 8);


        var rectangle3x5_TopLeft = RectangleCalculator.TopLeftRectangle(
            interlockWidth: 2,
            interlockHeight: 4,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 62,
            widthMax: 13,
            heightMax: 8);


        var square3x3 = RectangleCalculator.Square(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 68,
            widthMax: 10,
            heightMax: 9);


        var shapes = ShapeCalculator.CombineShapes(new List<List<ShapeModel>> { edges, rectangle3x4, rectangle3x5, rectangle3x4_BottomLeft, rectangle3x5_TopLeft, square3x3 });


        return shapes;
    }


    private static List<ShapeModel> Shapes_9406(in List<string> words, in List<string> end, in List<int> len, LetterIndexModel letterIndex)
    {

        var edges = EdgeCalculator.Execute(
            words: words,
            scoreMin: 24,
            widthMax: 11,
            heightMax: 9);


        var rectangle3x4 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 82,
            widthMax: 8,
            heightMax: 8);


        var rectangle3x7 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 6,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 100,
            widthMax: 11,
            heightMax: 9);


        var rectangle4x5 = RectangleCalculator.Rectangle(
            interlockWidth: 3,
            interlockHeight: 4,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 96,
            widthMax: 9,
            heightMax: 8);


        var rectangle5x6 = RectangleCalculator.Rectangle(
            interlockWidth: 4,
            interlockHeight: 5,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 104,
            widthMax: 10,
            heightMax: 8);


        var square3x3 = RectangleCalculator.Square(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 68,
            widthMax: 11,
            heightMax: 9);


        var shapes = ShapeCalculator.CombineShapes(new List<List<ShapeModel>> { edges, rectangle3x4, rectangle3x7, rectangle4x5, rectangle5x6, square3x3 });


        return shapes;
    }


    private static List<ShapeModel> Shapes_9407(in List<string> words, in List<string> end, in List<int> len, LetterIndexModel letterIndex)
    {

        var edges = EdgeCalculator.Execute(
            words: words,
            scoreMin: 22,
            widthMax: 10,
            heightMax: 8);


        var rectangle3x4 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 90,
            widthMax: 10,
            heightMax: 8);


        var rectangle3x6 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 5,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 92,
            widthMax: 12,
            heightMax: 10);


        var rectangle4x6 = RectangleCalculator.Rectangle(
            interlockWidth: 3,
            interlockHeight: 5,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 90,
            widthMax: 9,
            heightMax: 8);


        var rectangle4x5_BottomRight = RectangleCalculator.BottomRightRectangle(
            interlockWidth: 3,
            interlockHeight: 4,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 140,
            widthMax: 10,
            heightMax: 10);


        var special9407 = SpecialShapesCalculator.C9407(words: words);


        var square3x3 = RectangleCalculator.Square(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 88,
            widthMax: 12,
            heightMax: 10);


        var square4x4 = RectangleCalculator.Square(
            interlockWidth: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 92,
            widthMax: 9,
            heightMax: 8);


        var shapes = ShapeCalculator.CombineShapes(new List<List<ShapeModel>> { edges, rectangle3x4, rectangle3x6, rectangle4x6, rectangle4x5_BottomRight, special9407, square3x3, square4x4 });


        return shapes;
    }


    private static List<ShapeModel> Shapes_9408(in List<string> words, in List<string> end, in List<int> len, LetterIndexModel letterIndex)
    {

        var c2x2 = ClusterCalculator.C2x2(
            letterIndex: letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: 76,
            widthMax: 13,
            heightMax: 12);


        var edges = EdgeCalculator.Execute(
            words: words,
            scoreMin: 22,
            widthMax: 8,
            heightMax: 8);


        var rectangle3x4 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 60,
            widthMax: 9,
            heightMax: 9);


        var rectangle3x4_TopRight = RectangleCalculator.TopRightRectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 80,
            widthMax: 11,
            heightMax: 7);


        var square3x3 = RectangleCalculator.Square(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 62,
            widthMax: 12,
            heightMax: 9);


        var square4x4 = RectangleCalculator.Square(
            interlockWidth: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 76,
            widthMax: 9,
            heightMax: 9);


        var shapes = ShapeCalculator.CombineShapes(new List<List<ShapeModel>> { c2x2, edges, rectangle3x4, rectangle3x4_TopRight, square3x3, square4x4 });


        return shapes;
    }


    private static List<ShapeModel> Shapes_9409(in List<string> words, in List<string> end, in List<int> len, LetterIndexModel letterIndex)
    {

        var edges = EdgeCalculator.Execute(
            words: words,
            scoreMin: 22,
            widthMax: 10,
            heightMax: 8);


        var rectangle3x4 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 58,
            widthMax: 12,
            heightMax: 8);


        var rectangle4x5_BottomLeft = RectangleCalculator.BottomLeftRectangle(
            interlockWidth: 3,
            interlockHeight: 4,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 64,
            widthMax: 12,
            heightMax: 10);


        var rectangle3x4_TopLeft = RectangleCalculator.TopLeftRectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 80,
            widthMax: 9,
            heightMax: 8);


        var square3x3 = RectangleCalculator.Square(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 74,
            widthMax: 15,
            heightMax: 9);


        var square3x3_TopRight = RectangleCalculator.TopRightSquare(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 104,
            widthMax: 11,
            heightMax: 10);


        var shapes = ShapeCalculator.CombineShapes(new List<List<ShapeModel>> { edges, rectangle3x4, rectangle4x5_BottomLeft, rectangle3x4_TopLeft, square3x3, square3x3_TopRight });


        return shapes;
    }


    private static List<ShapeModel> Shapes_9410(in List<string> words, in List<string> end, in List<int> len, LetterIndexModel letterIndex)
    {

        var pacman3x3_BottomRight = PacmanCalculator.BottomRight3x3(
            letterIndex: letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: 152,
            widthMax: 14,
            heightMax: 13);


        var edges = EdgeCalculator.Execute(
            words: words,
            scoreMin: 22,
            widthMax: 10,
            heightMax: 9);


        var rectangle3x4 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 82,
            widthMax: 11,
            heightMax: 9);


        var rectangle3x5 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 4,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 78,
            widthMax: 11,
            heightMax: 9);


        var shapes = ShapeCalculator.CombineShapes(new List<List<ShapeModel>> { pacman3x3_BottomRight, edges, rectangle3x4, rectangle3x5 });


        return shapes;
    }


    private static List<ShapeModel> Shapes_9411(in List<string> words, in List<string> end, in List<int> len, LetterIndexModel letterIndex)
    {

        var c2x4 = ClusterCalculator.C2x4(
            letterIndex: letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: 116,
            widthMax: 14,
            heightMax: 8);


        var edges = EdgeCalculator.Execute(
            words: words,
            scoreMin: 22,
            widthMax: 10,
            heightMax: 9);


        var rectangle3x4 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 68,
            widthMax: 11,
            heightMax: 10);


        var rectangle3x5 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 4,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 136,
            widthMax: 10,
            heightMax: 10);


        var square3x3 = RectangleCalculator.Square(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 66,
            widthMax: 9,
            heightMax: 9);


        var shapes = ShapeCalculator.CombineShapes(new List<List<ShapeModel>> { c2x4, edges, rectangle3x4, rectangle3x5, square3x3 });


        return shapes;
    }


    private static List<ShapeModel> Shapes_9412(in List<string> words, in List<string> end, in List<int> len, LetterIndexModel letterIndex)
    {

        var c2x2 = ClusterCalculator.C2x2(
            letterIndex: letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: 104,
            widthMax: 11,
            heightMax: 9);


        var c2x3 = ClusterCalculator.C2x3(
            letterIndex: letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: 86,
            widthMax: 9,
            heightMax: 9);


        var edges = EdgeCalculator.Execute(
            words: words,
            scoreMin: 22,
            widthMax: 9,
            heightMax: 7);


        var rectangle3x4 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 70,
            widthMax: 10,
            heightMax: 8);


        var rectangle3x4_BottomLeft = RectangleCalculator.BottomLeftRectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 108,
            widthMax: 8,
            heightMax: 8);


        var rectangle3x4_TopRight = RectangleCalculator.TopRightRectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 104,
            widthMax: 7,
            heightMax: 6);


        var square3x3 = RectangleCalculator.Square(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 100,
            widthMax: 8,
            heightMax: 7);


        var square4x4 = RectangleCalculator.Square(
            interlockWidth: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 84,
            widthMax: 10,
            heightMax: 8);


        var shapes = ShapeCalculator.CombineShapes(new List<List<ShapeModel>> { c2x2, c2x3, edges, rectangle3x4, rectangle3x4_BottomLeft, rectangle3x4_TopRight, square3x3, square4x4 });


        return shapes;
    }


    private static List<ShapeModel> Shapes_9501(in List<string> words, in List<string> end, in List<int> len, LetterIndexModel letterIndex)
    {

        var c2x6 = ClusterCalculator.C2x6(
            letterIndex: letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: 222,
            widthMax: 17,
            heightMax: 9);


        var edges = EdgeCalculator.Execute(
            words: words,
            scoreMin: 22,
            widthMax: 11,
            heightMax: 7);


        var rectangle3x5 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 4,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 70,
            widthMax: 10,
            heightMax: 8);


        var rectangle3x4_BottomLeft = RectangleCalculator.BottomLeftRectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 66,
            widthMax: 11,
            heightMax: 8);


        var rectangle3x5_BottomRight = RectangleCalculator.BottomRightRectangle(
            interlockWidth: 2,
            interlockHeight: 4,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 76,
            widthMax: 7,
            heightMax: 7);


        var square3x3 = RectangleCalculator.Square(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 96,
            widthMax: 9,
            heightMax: 8);


        var square3x3_TopLeft = RectangleCalculator.TopLeftSquare(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 74,
            widthMax: 8,
            heightMax: 8);


        var shapes = ShapeCalculator.CombineShapes(new List<List<ShapeModel>> { c2x6, edges, rectangle3x5, rectangle3x4_BottomLeft, rectangle3x5_BottomRight, square3x3, square3x3_TopLeft });


        return shapes;
    }


    private static List<ShapeModel> Shapes_9502(in List<string> words, in List<string> end, in List<int> len, LetterIndexModel letterIndex)
    {

        var edges = EdgeCalculator.Execute(
            words: words,
            scoreMin: 22,
            widthMax: 11,
            heightMax: 10);


        var rectangle3x4 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 76,
            widthMax: 13,
            heightMax: 11);


        var rectangle3x5 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 4,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 54,
            widthMax: 13,
            heightMax: 8);


        var rectangle3x6 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 5,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 82,
            widthMax: 10,
            heightMax: 9);


        var square3x3 = RectangleCalculator.Square(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 62,
            widthMax: 13,
            heightMax: 8);


        var square3x3_BottomRight = RectangleCalculator.BottomRightSquare(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 66,
            widthMax: 10,
            heightMax: 10);


        var shapes = ShapeCalculator.CombineShapes(new List<List<ShapeModel>> { edges, rectangle3x4, rectangle3x5, rectangle3x6, square3x3, square3x3_BottomRight });


        return shapes;
    }


    private static List<ShapeModel> Shapes_9503(in List<string> words, in List<string> end, in List<int> len, LetterIndexModel letterIndex)
    {

        var c2x2 = ClusterCalculator.C2x2(
            letterIndex: letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: 70,
            widthMax: 10,
            heightMax: 8);


        var edges = EdgeCalculator.Execute(
            words: words,
            scoreMin: 22,
            widthMax: 10,
            heightMax: 8);


        var rectangle3x4 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 70,
            widthMax: 10,
            heightMax: 9);


        var rectangle3x6 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 5,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 76,
            widthMax: 10,
            heightMax: 8);


        var rectangle4x5 = RectangleCalculator.Rectangle(
            interlockWidth: 3,
            interlockHeight: 4,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 108,
            widthMax: 10,
            heightMax: 7);


        var rectangle4x5_BottomRight = RectangleCalculator.BottomRightRectangle(
            interlockWidth: 3,
            interlockHeight: 4,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 92,
            widthMax: 8,
            heightMax: 6);


        var square3x3_TopLeft = RectangleCalculator.TopLeftSquare(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 96,
            widthMax: 14,
            heightMax: 11);


        var shapes = ShapeCalculator.CombineShapes(new List<List<ShapeModel>> { c2x2, edges, rectangle3x4, rectangle3x6, rectangle4x5, rectangle4x5_BottomRight, square3x3_TopLeft });


        return shapes;
    }


    private static List<ShapeModel> Shapes_9504(in List<string> words, in List<string> end, in List<int> len, LetterIndexModel letterIndex)
    {

        var c2x2 = ClusterCalculator.C2x2(
            letterIndex: letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: 70,
            widthMax: 9,
            heightMax: 7);


        var c2x3 = ClusterCalculator.C2x3(
            letterIndex: letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: 110,
            widthMax: 9,
            heightMax: 7);


        var edges = EdgeCalculator.Execute(
            words: words,
            scoreMin: 22,
            widthMax: 12,
            heightMax: 7);


        var rectangle3x4 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 140,
            widthMax: 12,
            heightMax: 9);


        var rectangle4x5 = RectangleCalculator.Rectangle(
            interlockWidth: 3,
            interlockHeight: 4,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 140,
            widthMax: 12,
            heightMax: 9);


        var square3x3 = RectangleCalculator.Square(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 76,
            widthMax: 11,
            heightMax: 9);


        var square4x4 = RectangleCalculator.Square(
            interlockWidth: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 84,
            widthMax: 10,
            heightMax: 8);


        var square3x3_TopLeft = RectangleCalculator.TopLeftSquare(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 80,
            widthMax: 8,
            heightMax: 7);


        var square3x3_TopRight = RectangleCalculator.TopRightSquare(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 96,
            widthMax: 13,
            heightMax: 9);


        var shapes = ShapeCalculator.CombineShapes(new List<List<ShapeModel>> { c2x2, c2x3, edges, rectangle3x4, rectangle4x5, square3x3, square4x4, square3x3_TopLeft, square3x3_TopRight });


        return shapes;
    }


    private static List<ShapeModel> Shapes_9505(in List<string> words, in List<string> end, in List<int> len, LetterIndexModel letterIndex)
    {
        var c2x3 = ClusterCalculator.C2x3(
            letterIndex: letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: 98,
            widthMax: 9,
            heightMax: 8);

        var edges = EdgeCalculator.Execute(
            words: words,
            scoreMin: 22,
            widthMax: 9,
            heightMax: 9);

        var rectangle3x4 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 68,
            widthMax: 9,
            heightMax: 7);

        var rectangle4x7_BottomLeft = RectangleCalculator.BottomLeftRectangle(
            interlockWidth: 3,
            interlockHeight: 6,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 128,
            widthMax: 9,
            heightMax: 9);

        var rectangle3x5_BottomRight = RectangleCalculator.BottomRightRectangle(
            interlockWidth: 2,
            interlockHeight: 4,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 74,
            widthMax: 8,
            heightMax: 7);

        var rectangle3x4_TopLeft = RectangleCalculator.TopLeftRectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 66,
            widthMax: 11,
            heightMax: 11);

        var rectangle3x5_TopLeft = RectangleCalculator.TopLeftRectangle(
            interlockWidth: 2,
            interlockHeight: 4,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 74,
            widthMax: 9,
            heightMax: 8);

        var square3x3 = RectangleCalculator.Square(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 92,
            widthMax: 9,
            heightMax: 8);

        var shapes = ShapeCalculator.CombineShapes(new List<List<ShapeModel>> { c2x3, edges, rectangle3x4, rectangle4x7_BottomLeft, rectangle3x5_BottomRight, rectangle3x4_TopLeft, rectangle3x5_TopLeft, square3x3 });

        return shapes;
    }


    private static List<ShapeModel> Shapes_9506(in List<string> words, in List<string> end, in List<int> len, LetterIndexModel letterIndex)
    {
        var c2x2 = ClusterCalculator.C2x2(
            letterIndex: letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: 88,
            widthMax: 10,
            heightMax: 10);

        var c2x4 = ClusterCalculator.C2x4(
            letterIndex: letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: 142,
            widthMax: 14,
            heightMax: 10);

        var edges = EdgeCalculator.Execute(
            words: words,
            scoreMin: 22,
            widthMax: 10,
            heightMax: 8);

        var rectangle3x4 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 72,
            widthMax: 11,
            heightMax: 9);

        var rectangle3x4_BottomRight = RectangleCalculator.BottomRightRectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 68,
            widthMax: 8,
            heightMax: 7);

        var rectangle3x5_BottomRight = RectangleCalculator.BottomRightRectangle(
            interlockWidth: 2,
            interlockHeight: 4,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 66,
            widthMax: 11,
            heightMax: 8);

        var square3x3 = RectangleCalculator.Square(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 80,
            widthMax: 10,
            heightMax: 9);

        var square4x4 = RectangleCalculator.Square(
            interlockWidth: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 136,
            widthMax: 9,
            heightMax: 9);

        var square3x3_TopLeft = RectangleCalculator.TopLeftSquare(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 80,
            widthMax: 11,
            heightMax: 8);

        var shapes = ShapeCalculator.CombineShapes(new List<List<ShapeModel>> { c2x2, c2x4, edges, rectangle3x4, rectangle3x4_BottomRight, rectangle3x5_BottomRight, square3x3, square4x4, square3x3_TopLeft });

        return shapes;
    }


    private static List<ShapeModel> Shapes_9507(in List<string> words, in List<string> end, in List<int> len, LetterIndexModel letterIndex)
    {
        var c2x2 = ClusterCalculator.C2x2(
            letterIndex: letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: 62,
            widthMax: 13,
            heightMax: 12);

        var edges = EdgeCalculator.Execute(
            words: words,
            scoreMin: 22,
            widthMax: 13,
            heightMax: 9);

        var outer2x3 = OuterCalculator.C2x3(
            letterIndex: letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: 96,
            widthMax: 11,
            heightMax: 9);

        var rectangle4x5 = RectangleCalculator.Rectangle(
            interlockWidth: 3,
            interlockHeight: 4,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 84,
            widthMax: 7,
            heightMax: 6);

        var square3x3 = RectangleCalculator.Square(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 70,
            widthMax: 13,
            heightMax: 9);

        var shapes = ShapeCalculator.CombineShapes(new List<List<ShapeModel>> { c2x2, edges, outer2x3, rectangle4x5, square3x3 });

        return shapes;
    }


    private static List<ShapeModel> Shapes_9508(in List<string> words, in List<string> end, in List<int> len, LetterIndexModel letterIndex)
    {
        var c2x2 = ClusterCalculator.C2x2(
            letterIndex: letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: 78,
            widthMax: 10,
            heightMax: 9);

        var c2x3 = ClusterCalculator.C2x3(
            letterIndex: letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: 148,
            widthMax: 14,
            heightMax: 14);

        var edges = EdgeCalculator.Execute(
            words: words,
            scoreMin: 22,
            widthMax: 11,
            heightMax: 7);

        var outer2x3 = OuterCalculator.C2x3(
            letterIndex: letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: 98,
            widthMax: 11,
            heightMax: 10);

        var rectangle3x4 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 92,
            widthMax: 9,
            heightMax: 8);

        var rectangle4x5 = RectangleCalculator.Rectangle(
            interlockWidth: 3,
            interlockHeight: 4,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 86,
            widthMax: 12,
            heightMax: 8);

        var shapes = ShapeCalculator.CombineShapes(new List<List<ShapeModel>> { c2x2, c2x3, edges, outer2x3, rectangle3x4, rectangle4x5 });

        return shapes;
    }


    private static List<ShapeModel> Shapes_9509(in List<string> words, in List<string> end, in List<int> len, LetterIndexModel letterIndex)
    {
        var c2x2 = ClusterCalculator.C2x2(
            letterIndex: letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: 64,
            widthMax: 13,
            heightMax: 10);

        var edges = EdgeCalculator.Execute(
            words: words,
            scoreMin: 22,
            widthMax: 10,
            heightMax: 8);

        var rectangle3x4 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 98,
            widthMax: 8,
            heightMax: 7);

        var rectangle3x5 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 4,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 144,
            widthMax: 10,
            heightMax: 7);

        var square3x3 = RectangleCalculator.Square(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 78,
            widthMax: 10,
            heightMax: 9);

        var square3x3_TopRight = RectangleCalculator.TopRightSquare(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 88,
            widthMax: 12,
            heightMax: 10);

        var shapes = ShapeCalculator.CombineShapes(new List<List<ShapeModel>> { c2x2, edges, rectangle3x4, rectangle3x5, square3x3, square3x3_TopRight });

        return shapes;
    }


    private static List<ShapeModel> Shapes_9510(in List<string> words, in List<string> end, in List<int> len, LetterIndexModel letterIndex)
    {
        var edges = EdgeCalculator.Execute(
            words: words,
            scoreMin: 22,
            widthMax: 10,
            heightMax: 7);

        var rectangle3x4 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 132,
            widthMax: 11,
            heightMax: 8);

        var rectangle3x5 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 4,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 88,
            widthMax: 11,
            heightMax: 7);

        var rectangle3x6 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 5,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 126,
            widthMax: 11,
            heightMax: 9);

        var rectangle4x5 = RectangleCalculator.Rectangle(
            interlockWidth: 3,
            interlockHeight: 4,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 60,
            widthMax: 9,
            heightMax: 8);

        var square3x3 = RectangleCalculator.Square(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 70,
            widthMax: 11,
            heightMax: 10);

        var square3x3_BottomRight = RectangleCalculator.BottomRightSquare(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 120,
            widthMax: 11,
            heightMax: 7);

        var shapes = ShapeCalculator.CombineShapes(new List<List<ShapeModel>> { edges, rectangle3x4, rectangle3x5, rectangle3x6, rectangle4x5, square3x3, square3x3_BottomRight });

        return shapes;
    }


    private static List<ShapeModel> Shapes_9511(in List<string> words, in List<string> end, in List<int> len, LetterIndexModel letterIndex)
    {
        var pacman3x3_BottomRight = PacmanCalculator.BottomRight3x3(
            letterIndex: letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: 138,
            widthMax: 12,
            heightMax: 10);

        var c2x2 = ClusterCalculator.C2x2(
            letterIndex: letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: 62,
            widthMax: 12,
            heightMax: 10);

        var edges = EdgeCalculator.Execute(
            words: words,
            scoreMin: 22,
            widthMax: 11,
            heightMax: 9);

        var rectangle3x4 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 96,
            widthMax: 11,
            heightMax: 10);

        var rectangle3x4_BottomLeft = RectangleCalculator.BottomLeftRectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 60,
            widthMax: 12,
            heightMax: 6);

        var square3x3 = RectangleCalculator.Square(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 76,
            widthMax: 9,
            heightMax: 7);

        var square4x4 = RectangleCalculator.Square(
            interlockWidth: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 104,
            widthMax: 11,
            heightMax: 9);

        var square3x3_BottomRight = RectangleCalculator.BottomRightSquare(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 74,
            widthMax: 10,
            heightMax: 8);

        var square3x3_TopRight = RectangleCalculator.TopRightSquare(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 66,
            widthMax: 11,
            heightMax: 10);

        var shapes = ShapeCalculator.CombineShapes(new List<List<ShapeModel>> { pacman3x3_BottomRight, c2x2, edges, rectangle3x4, rectangle3x4_BottomLeft, square3x3, square4x4, square3x3_BottomRight, square3x3_TopRight });

        return shapes;
    }


    private static List<ShapeModel> Shapes_9512(in List<string> words, in List<string> end, in List<int> len, LetterIndexModel letterIndex)
    {
        var c2x2 = ClusterCalculator.C2x2(
            letterIndex: letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: 82,
            widthMax: 11,
            heightMax: 10);

        var edges = EdgeCalculator.Execute(
            words: words,
            scoreMin: 28,
            widthMax: 11,
            heightMax: 9);

        var rectangle3x4 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 86,
            widthMax: 10,
            heightMax: 10);

        var rectangle3x6 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 5,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 92,
            widthMax: 9,
            heightMax: 8);

        var square3x3 = RectangleCalculator.Square(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 54,
            widthMax: 11,
            heightMax: 10);

        var shapes = ShapeCalculator.CombineShapes(new List<List<ShapeModel>> { c2x2, edges, rectangle3x4, rectangle3x6, square3x3 });

        return shapes;
    }


    private static List<ShapeModel> Shapes_9601(in List<string> words, in List<string> end, in List<int> len, LetterIndexModel letterIndex)
    {
        var c2x2 = ClusterCalculator.C2x2(
            letterIndex: letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: 84,
            widthMax: 9,
            heightMax: 6);

        var edges = EdgeCalculator.Execute(
            words: words,
            scoreMin: 22,
            widthMax: 9,
            heightMax: 8);

        var outer2x4 = OuterCalculator.C2x4(
            letterIndex: letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: 150,
            widthMax: 11,
            heightMax: 8);

        var rectangle4x5 = RectangleCalculator.Rectangle(
            interlockWidth: 3,
            interlockHeight: 4,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 96,
            widthMax: 9,
            heightMax: 9);

        var square3x3 = RectangleCalculator.Square(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 76,
            widthMax: 12,
            heightMax: 9);

        var shapes = ShapeCalculator.CombineShapes(new List<List<ShapeModel>> { c2x2, edges, outer2x4, rectangle4x5, square3x3 });

        return shapes;
    }


    private static List<ShapeModel> Shapes_9602(in List<string> words, in List<string> end, in List<int> len, LetterIndexModel letterIndex)
    {
        var c2x2 = ClusterCalculator.C2x2(
            letterIndex: letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: 74,
            widthMax: 11,
            heightMax: 6);

        var c2x3 = ClusterCalculator.C2x3(
            letterIndex: letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: 110,
            widthMax: 9,
            heightMax: 7);

        var edges = EdgeCalculator.Execute(
            words: words,
            scoreMin: 24,
            widthMax: 11,
            heightMax: 9);

        var rectangle3x5 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 4,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 80,
            widthMax: 11,
            heightMax: 10);

        var square3x3 = RectangleCalculator.Square(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 76,
            widthMax: 13,
            heightMax: 9);

        var square3x3_BottomRight = RectangleCalculator.BottomRightSquare(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 120,
            widthMax: 11,
            heightMax: 8);

        var shapes = ShapeCalculator.CombineShapes(new List<List<ShapeModel>> { c2x2, c2x3, edges, rectangle3x5, square3x3, square3x3_BottomRight });

        return shapes;
    }


    private static List<ShapeModel> Shapes_9603(in List<string> words, in List<string> end, in List<int> len, LetterIndexModel letterIndex)
    {
        var edges = EdgeCalculator.Execute(
            words: words,
            scoreMin: 22,
            widthMax: 9,
            heightMax: 9);

        var rectangle3x5 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 4,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 78,
            widthMax: 10,
            heightMax: 8);

        var square3x3 = RectangleCalculator.Square(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 70,
            widthMax: 11,
            heightMax: 9);

        var square3x3_TopRight = RectangleCalculator.TopRightSquare(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 60,
            widthMax: 12,
            heightMax: 9);

        var shapes = ShapeCalculator.CombineShapes(new List<List<ShapeModel>> { edges, rectangle3x5, square3x3, square3x3_TopRight });

        return shapes;
    }

    private static List<ShapeModel> Shapes_9604(in List<string> words, in List<string> end, in List<int> len, LetterIndexModel letterIndex)
    {
        var c2x2 = ClusterCalculator.C2x2(
            letterIndex: letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: 74,
            widthMax: 13,
            heightMax: 10);

        var edges = EdgeCalculator.Execute(
            words: words,
            scoreMin: 22,
            widthMax: 11,
            heightMax: 10);

        var outer2x4 = OuterCalculator.C2x4(
            letterIndex: letterIndex,
            words: words,
            end: end,
            len: len,
            scoreMin: 94,
            widthMax: 15,
            heightMax: 9);

        var rectangle3x4 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 90,
            widthMax: 11,
            heightMax: 10);

        var square3x3 = RectangleCalculator.Square(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 68,
            widthMax: 13,
            heightMax: 10);

        var square4x4 = RectangleCalculator.Square(
            interlockWidth: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 74,
            widthMax: 7,
            heightMax: 6);

        var shapes = ShapeCalculator.CombineShapes(new List<List<ShapeModel>> { c2x2, edges, outer2x4, rectangle3x4, square3x3, square4x4 });

        return shapes;
    }


    private static List<ShapeModel> Shapes_9605(in List<string> words, in List<string> end, in List<int> len, LetterIndexModel letterIndex)
    {
        var edges = EdgeCalculator.Execute(
            words: words,
            scoreMin: 24,
            widthMax: 9,
            heightMax: 9);

        var rectangle3x4 = RectangleCalculator.Rectangle(
            interlockWidth: 2,
            interlockHeight: 3,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 90,
            widthMax: 10,
            heightMax: 9);

        var rectangle3x5_TopLeft = RectangleCalculator.TopLeftRectangle(
            interlockWidth: 2,
            interlockHeight: 4,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 66,
            widthMax: 9,
            heightMax: 8);

        var special9605 = SpecialShapesCalculator.C9605(words: words);

        var square3x3 = RectangleCalculator.Square(
            interlockWidth: 2,
            letterIndex: letterIndex,
            words: words,
            lengths: len,
            scoreMin: 74,
            widthMax: 11,
            heightMax: 11);

        var shapes = ShapeCalculator.CombineShapes(new List<List<ShapeModel>> { edges, rectangle3x4, rectangle3x5_TopLeft, special9605, square3x3 });

        return shapes;
    }

    
}


