using CrozzleInterfaces;
using CrozzleShapeMaker;

namespace CrozzleShapeMaker_Tests;

public class PacmanCalculator_Tests
{
    
    [Fact]
    public void test_Pacman3x3_TopRight_8803()
    {
        var game = GameList.FindGame(8803);

        var words = game.winningWords;
        var letterIndex = new LetterIndexModel(words);
        var end = WordList.Reversed(words);
        var len = WordList.Lengths(words);

        var pacman3x3_TopRight = PacmanCalculator.TopRight3x3(
                letterIndex: letterIndex,
                words: words,
                end: end,
                len: len,
                scoreMin: 136,
                widthMax: 10,
                heightMax: 9);

        foreach (var shape in pacman3x3_TopRight)
        {
            var text = shape.ToTextDebug(words);
            if (text.Contains("#"))
            {
                var swiftCode = shape.ToSwiftCode();
                var csharpCode = shape.ToCSharpCode();
                Console.WriteLine();
            }
            Assert.True(text.Contains("#") == false);
            Console.WriteLine(text);
        }
    }
}