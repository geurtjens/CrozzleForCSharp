using CrozzleBranchAndBound;
using CrozzleInterfaces;

namespace BranchAndBound_Tests;

public class BranchAndBoundV3_Tests
{

    [Fact]
    public void test_ExecuteGame_8802()
    {
        int gameId = 8802;

        GameModel game = GameList.FindGame(gameId: gameId);
        int winningScore = game.winningScore;
        List<string> words = game.winningWords;



        var result = BranchAndBoundV3.ExecuteGame(
            gameId: gameId,
            words: words,
            lookaheadDepth: 1,
            beamWidth: 1,
            maxDepth: 30,
            rootWidth: 1,
            winningScore: winningScore,
            useGuidedScores: true);

        Assert.Equal(winningScore, result.score);
    }


    [Fact]
    public void test_ExecuteGame_8803()
    {

        /// The order of execution should be
        /// 1. `[QuItO, zUrICH], [SuEz, tOrONTO]`
        /// 2. `[toKYO, LAGos], [TORONto, osLO]`
        /// 3. `TOKyO:yORK`
        /// 4. `[BoNn, LaGos], [oSaKA, TOROnTo]`
        /// 5. `[LaGOs, CaIRo], [OSaKa, OsLo]`
        /// 6.  `rOME:YOrK`
        /// 7. `ZURICh:OMAhA`
        /// 8. `BoGOTA:oMAHA`
        /// 9. `BOGOtA:tOLEDO`
        /// 10. `[DeLhI, BoMbAY], [TOLeDo, hObART]`
        /// 11. `[DELhi, omsK, BOMbay], [hobART, Lima, syDNEY]`
        /// 12. `[oMsK, aYR], [HoBART, sYDNEy]`
        /// 13. `[rEnO, AyR], [HOBArT, SYDnEy]`
        /// 14. `OMSk:CORk`


        int gameId = 8803;


        GameModel game = GameList.FindGame(gameId: gameId);
        int winningScore = game.winningScore;
        List<string> words = game.winningWords;



        var result = BranchAndBoundV3.ExecuteGame(
            gameId: gameId,
            words: words,
            lookaheadDepth: 3,
            beamWidth: 10,
            maxDepth: 30,
            rootWidth: 1,
            winningScore: winningScore,
            useGuidedScores: true);

        Assert.Equal(winningScore, result.score);
    }
}



