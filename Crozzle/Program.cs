// See https://aka.ms/new-console-template for more information
using CrozzleInterfaces;
using CrozzleShapeMaker;
using CrozzleBranchAndBound;

BranchAndBoundRunner.WinningWords_UseGuidedScores();


var watch = System.Diagnostics.Stopwatch.StartNew();

Console.WriteLine("Calculating Shapes, please wait!");

var games = GameList.Games();
Console.WriteLine("C#");
Console.WriteLine("Game, WinningWordShapes, AllWordShapes, growth, scoreSum, widthSum, heightSum");

var winningWordShapesCount = 0;
var wordShapesCount = 0;
var totalScoreSum = 0;
var totalWidthSum = 0;
var totalHeightSum = 0;


foreach (var gameId in games)
{
    var game = GameList.FindGame(gameId);
    //if (game.gameId == 9209)
    //{
    var scoreSum = 0;
    var widthSum = 0;
    var heightSum = 0;

    var winningWordShapes = WinningShapesCalculator.execute(game.GameId, game.WinningWords);
    foreach(var item in winningWordShapes){
        scoreSum += item.Score;
        widthSum += item.Width;
        heightSum += item.Height;
    }

    totalScoreSum += scoreSum;
    totalWidthSum += widthSum;
    totalHeightSum += heightSum;

    var wordShapes = WinningShapesCalculator.execute(game.GameId, game.Words);

    var growth = (int)((float)wordShapes.Count / (float)winningWordShapes.Count * 100) / 100;

    Console.WriteLine($"{game.GameId}, {winningWordShapes.Count}, {wordShapes.Count}, {growth}X, {scoreSum}, {widthSum}, {heightSum}");

    winningWordShapesCount += winningWordShapes.Count;
    wordShapesCount += wordShapes.Count;
   // }
}
watch.Stop();

Console.WriteLine($"produced {winningWordShapesCount} winning word shapes and {wordShapesCount} all words shapes in {watch.ElapsedMilliseconds} ms, scoreSum {totalScoreSum}, widthSum {totalWidthSum}, heightSum {totalHeightSum}");
Console.WriteLine($"completed in {watch.ElapsedMilliseconds} ms");


var gameList = new List<GameModel>();
foreach(var gameId in games)
{
    gameList.Add(GameList.FindGame(gameId));
}

var totalShapes = 0;

totalShapes += RectangleCalculatorV2.ExecuteAllSerial(gameList, 0, true);

totalShapes += RectangleCalculator.ExecuteAllSerial(gameList, 0, true);

totalShapes += EdgeCalculator.ExecuteAllSerial(gameList, 0, true);

totalShapes += ClusterCalculator.ExecuteAllSerial(gameList, 0, true);

totalShapes += PacmanCalculator.ExecuteAllSerial(gameList, 0, true);

totalShapes += OuterCalculator.ExecuteAllSerial(gameList, 0, true);


Console.WriteLine("WinningWords");
foreach(var game in gameList)
{
    var winningWordShapes = WinningShapesCalculator.execute(game.GameId, game.WinningWords);
    var wordShapes = WinningShapesCalculator.execute(game.GameId, game.Words);

    Console.WriteLine($"{game.GameId}, {winningWordShapes.Count}, {wordShapes.Count}");

}

