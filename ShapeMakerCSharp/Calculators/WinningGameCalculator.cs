using System;
using CrozzleInterfaces;

namespace ShapeMakerCSharp.Calculators
{
    public class WinningGameCalculator
    {

        public static List<ShapeModel> execute(int gameId, List<string> words)
        {
            var grids = findWinningGame(gameId);

            var result = new List<ShapeModel>();

            foreach(var grid in grids)
            {
                var shape = GridList.ToShape(grid, words);
                result.Add(shape);
            }
            return result;
        }


        public static List<List<string>> findWinningGame(int gameId)
        {
            switch (gameId)
            {
                case 8612:

                    return new List<List<string>> {

                    new List<string> {
                        " .  . ",
                        ".NUTS.",
                        " A  I ",
                        ".ZION.",
                        " A  G ",
                        " R  . ",
                        " E    ",
                        " T    ",
                        " H    ",
                        " .    "
                    },new List<string> {
                        "      . .  ",
                        ".NAZARETH. ",
                        "      V O  ",
                        "    .BELLS.",
                        "      . L  ",
                        "        Y  ",
                        "        .  "
                    },new List<string> {
                        "   . ",
                        "   H ",
                        "   O ",
                        "   L ",
                        "   L ",
                        ".JOY.",
                        "   . "
                    },new List<string> {
                        "     .    ",
                        "    .JOY. ",
                        "     E  S ",
                        ".HAZELNUT.",
                        "     L  A ",
                        "     Y  R ",
                        "     .  . "
                    },new List<string> {
                        "   . .  ",
                        "   H M  ",
                        "   A E  ",
                        " .AZURE.",
                        "   E R  ",
                        ".JELLY. ",
                        "   N .  ",
                        "   U    ",
                        "   T    ",
                        "   .    "
                    },new List<string> {
                        "  . .  ",
                        " .HYMN.",
                        "  A E  ",
                        ".AZURE.",
                        "  E R  ",
                        "  L Y  ",
                        "  N .  ",
                        "  U    ",
                        "  T    ",
                        "  .    "
                    },new List<string> {
                        "  .   ",
                        "  T   ",
                        "  U   ",
                        "  R   ",
                        "  K   ",
                        "  E   ",
                        ".HYMN.",
                        "  .   "
                    },new List<string> {
                        "  .     ",
                        "  S     ",
                        "  A     ",
                        ".TURKEY.",
                        "  C     ",
                        "  E     ",
                        "  .     "
                    },new List<string> {
                        " .  . ",
                        ".TOYS.",
                        " O  A ",
                        " A  U ",
                        " S  C ",
                        ".TREE.",
                        " .  . "
                    },new List<string> {
                        "   .  ",
                        "   F  ",
                        "   A  ",
                        "   M  ",
                        "   I  ",
                        "   L  ",
                        ".TOYS.",
                        "   .  "
                    },new List<string> {
                        "    . ",
                        "    I ",
                        "    N ",
                        ".HYMN.",
                        "    . "
                    },new List<string> {
                        "    .   ",
                        "    P   ",
                        "    O   ",
                        "    R   ",
                        ".TURKEY.",
                        "    .   "
                    },new List<string> {
                        "    .   ",
                        "    W   ",
                        "    H   ",
                        ".FAMILY.",
                        "    T   ",
                        "    E   ",
                        "    .   "
                    },new List<string> {
                        "    . ",
                        ".SNOW.",
                        "    H ",
                        "    I ",
                        "    T ",
                        "    E ",
                        "    . "
                    },new List<string> {
                        "     . ",
                        "     C ",
                        "     A ",
                        "     K ",
                        ".WHITE.",
                        "     . "
                    }
                };

                case 8704:

                    return new List<List<string>> {

                    new List<string> {
                        "  .  .  ",
                        "  F  P  ",
                        ".HOMER. ",
                        "  O  I  ",
                        ".STANZA.",
                        "  .  E  ",
                        "     .  "
                    },new List<string> {
                        " .      ",
                        ".STANZA.",
                        " L      ",
                        " E      ",
                        " S      ",
                        " S      ",
                        " O      ",
                        " R      ",
                        " .      "
                    },new List<string> {
                        "       . ",
                        "       H ",
                        "    .  A ",
                        ".SLESSOR.",
                        "    C  D ",
                        "  .POESY.",
                        "    T  . ",
                        "    T    ",
                        "    .    "
                    },new List<string> {
                        "     . ",
                        "     S ",
                        " .   L ",
                        ".DONNE.",
                        " O   S ",
                        ".YEATS.",
                        " L   O ",
                        " E   R ",
                        " .   . "
                    },new List<string> {
                        "   ..    ",
                        "  .DONNE.",
                        ".HOOD.   ",
                        "  .YEATS.",
                        "   L.    ",
                        "   E     ",
                        "   .     "
                    },new List<string> {
                        "  .    ",
                        "  S    ",
                        "  C .  ",
                        ".POESY.",
                        "  T A  ",
                        " .TEXT.",
                        "  . E  ",
                        "    .  "
                    },new List<string> {
                        "    .   ",
                        " .  M   ",
                        " H  I   ",
                        " O  L   ",
                        ".POET.  ",
                        " E  O   ",
                        " .DONNE.",
                        "    .   "
                    },new List<string> {
                        "    .  ",
                        " .LAMB.",
                        " H  I  ",
                        " O  L  ",
                        ".POET. ",
                        " E  O  ",
                        " .  N  ",
                        "    .  "
                    },new List<string> {
                        " .    ",
                        ".HYMN.",
                        " O    ",
                        " O    ",
                        " D    ",
                        " .    "
                    },new List<string> {
                        "     . . ",
                        ".BRIDGES.",
                        "     R C ",
                        "     A A ",
                        "   .HYMN.",
                        "     . . "
                    },new List<string> {
                        " .     ",
                        " B     ",
                        ".RHYME.",
                        " I     ",
                        " D     ",
                        " G     ",
                        " E     ",
                        " S     ",
                        " .     "
                    },new List<string> {
                        "   .   ",
                        "   E   ",
                        "   L   ",
                        "   E   ",
                        "   G   ",
                        ".RHYME.",
                        "   .   "
                    },new List<string> {
                        " .     ",
                        " P     ",
                        " O     ",
                        ".ELEGY.",
                        " .     "
                    }
                };

                case 8705:

                    return new List<List<string>> {

                    new List<string> {
                        "     .    ",
                        "    .E    ",
                        "   .PANSY.",
                        ".MOWER.   ",
                        "   .STALK.",
                        " .PATH.   ",
                        "    ..    "
                    },new List<string> {
                        "     . ",
                        "     L ",
                        "     I ",
                        "     L ",
                        ".PANSY.",
                        "     . "
                    },new List<string> {
                        "    .     ",
                        "    S     ",
                        "    T.    ",
                        ".SWEEP.   ",
                        "   .MOWER.",
                        "    .P    ",
                        "     P    ",
                        "     Y    ",
                        "     .    "
                    },new List<string> {
                        "     .    ",
                        "     P    ",
                        "   .MOWER.",
                        "   P P    ",
                        "   O P    ",
                        ".PEONY.   ",
                        "   L .    ",
                        "   .      "
                    },new List<string> {
                        "     .       ",
                        "     G       ",
                        "     R.      ",
                        "    .ALYSSUM.",
                        ".MIMOSA.     ",
                        "    .SWEEP.  ",
                        "     .N      ",
                        "      .      "
                    },new List<string> {
                        "      .  ",
                        "    . B  ",
                        ".ALYSSUM.",
                        "    T D  ",
                        ".SWEEP.  ",
                        "    M    ",
                        "    .    "
                    },new List<string> {
                        "   .     ",
                        "   M     ",
                        "   A     ",
                        ".ALYSSUM.",
                        "   .     "
                    },new List<string> {
                        "  .    ",
                        "  E .  ",
                        ".PANSY.",
                        "  R A  ",
                        ".STALK.",
                        "  H V  ",
                        "  . I  ",
                        "    A  ",
                        "    .  "
                    },new List<string> {
                        " . .    ",
                        ".POT.   ",
                        " A R    ",
                        " L I    ",
                        ".MIMOSA.",
                        " . .    "
                    },new List<string> {
                        "  .  ",
                        "  S  ",
                        "  A  ",
                        "  L  ",
                        "  V  ",
                        ".DIG.",
                        "  A  ",
                        "  .  "
                    },new List<string> {
                        " .     ",
                        " T     ",
                        " A     ",
                        ".PEONY.",
                        " .     "
                    }
                };

                case 8710:

                    return new List<List<string>> {

                    new List<string> {
                        "    . ",
                        " .  C ",
                        " S  A ",
                        ".WREN.",
                        " A  A ",
                        " L  R ",
                        ".LORY.",
                        " O  . ",
                        " W    ",
                        " .    "
                    },new List<string> {
                        "      .   ",
                        "     .T   ",
                        ".GROUSE.  ",
                        "    .WREN.",
                        "  .SWAN.  ",
                        "     L.   ",
                        "     L    ",
                        "     O    ",
                        "     W    ",
                        "     .    "
                    },new List<string> {
                        "      .    ",
                        "      S    ",
                        "      W    ",
                        "      A    ",
                        "      L.   ",
                        "     .LORY.",
                        ".SPARROW.  ",
                        "    .OWLET.",
                        "     C..   ",
                        "     .     "
                    },new List<string> {
                        "  .   ",
                        ".ROC. ",
                        "  W C ",
                        "  L H ",
                        "  E A ",
                        " .TIT.",
                        "  . . "
                    },new List<string> {
                        "      .    ",
                        "      R    ",
                        "  .   O    ",
                        "  R   O    ",
                        "  O   S    ",
                        ".TOMTIT.   ",
                        "  K   E    ",
                        "  .SPARROW.",
                        "      .    "
                    },new List<string> {
                        "    .     ",
                        "   .A     ",
                        "  .TURKEY.",
                        ".ROOK.    ",
                        "   M.     ",
                        "   T      ",
                        "   I      ",
                        "   T      ",
                        "   .      "
                    },new List<string> {
                        "      . ",
                        "  .   S ",
                        "  A   K ",
                        ".TURKEY.",
                        "  K   L ",
                        "  .SKUA.",
                        "      R ",
                        "      K ",
                        "      . "
                    },new List<string> {
                        "      . ",
                        "  .IBIS.",
                        "  A   K ",
                        ".TURKEY.",
                        "  K   L ",
                        "  .   A ",
                        "      R ",
                        "      K ",
                        "      . "
                    },new List<string> {
                        "    . .    ",
                        "    E R    ",
                        "   .GROUSE.",
                        "    R O    ",
                        "    E S    ",
                        ".TOMTIT.   ",
                        "    . E    ",
                        "      R    ",
                        "      .    "
                    },new List<string> {
                        " .   .   ",
                        ".SNIPE.  ",
                        " H   G   ",
                        " A   R   ",
                        " G   E   ",
                        " .TOMTIT.",
                        "     .   "
                    },new List<string> {
                        "   . ",
                        ".TUI.",
                        "   B ",
                        "   I ",
                        "   S ",
                        "   . "
                    },new List<string> {
                        " .   ",
                        ".TUI.",
                        " E   ",
                        " A   ",
                        " L   ",
                        " .   "
                    },new List<string> {
                        "  .  ",
                        "  E  ",
                        "  M  ",
                        ".TUI.",
                        "  .  "
                    },new List<string> {
                        " .   ",
                        " H   ",
                        ".EMU.",
                        " N   ",
                        " .   "
                    },new List<string> {
                        "    . ",
                        "    S ",
                        "    H ",
                        ".MYNA.",
                        "    G ",
                        "    . "
                    },new List<string> {
                        "   . ",
                        "   M ",
                        ".JAY.",
                        "   N ",
                        "   A ",
                        "   . "
                    }
                };

                case 8711:

                    return new List<List<string>> {

                    new List<string> {
                        "   .   ",
                        "   C   ",
                        "   O   ",
                        " . L . ",
                        " L.O.J ",
                        ".AZURE.",
                        ".COROT.",
                        " .F.U. ",
                        "  F G  ",
                        "  A E  ",
                        "  N .  ",
                        "  Y    ",
                        "  .    "
                    },new List<string> {
                        "       . ",
                        "       D ",
                        ".ZOFFANY.",
                        "       C ",
                        "       K ",
                        "       . "
                    },new List<string> {
                        "  . .  ",
                        ".AZURE.",
                        "  O O  ",
                        "  F U  ",
                        "  F G  ",
                        ".LAKE. ",
                        "  N .  ",
                        "  Y    ",
                        "  .    "
                    },new List<string> {
                        "    .     ",
                        "    E     ",
                        "    B     ",
                        "  .COLOUR.",
                        "  H N     ",
                        ".RUBY.    ",
                        "  E .     ",
                        "  .       "
                    },new List<string> {
                        "    .   ",
                        "   .H   ",
                        "  .RUBY.",
                        ".BLUE.  ",
                        "   B.   ",
                        "   E    ",
                        "   N    ",
                        "   S    ",
                        "   .    "
                    },new List<string> {
                        "  .  .  ",
                        "  B  S  ",
                        "  L  A  ",
                        ".RUBENS.",
                        "  E  D  ",
                        "  .BAY. ",
                        "     .  "
                    },new List<string> {
                        "   .   ",
                        " . R   ",
                        ".BLUE. ",
                        " R B   ",
                        " U E   ",
                        ".SANDY.",
                        " H S   ",
                        " . .   "
                    },new List<string> {
                        " .    ",
                        " R    ",
                        " O    ",
                        " U    ",
                        ".GREY.",
                        " E    ",
                        " .    "
                    },new List<string> {
                        "    .    ",
                        "   .G    ",
                        "  .SOOTY.",
                        ".GREY.   ",
                        "  .PAINT.",
                        "   I.    ",
                        "   A     ",
                        "   .     "
                    },new List<string> {
                        "     . ",
                        "     R ",
                        "     U ",
                        "  .RED.",
                        "  G  D ",
                        ".SOOTY.",
                        "  Y  . ",
                        "  A    ",
                        "  .    "
                    },new List<string> {
                        "  .    ",
                        "  G .  ",
                        ".SOOTY.",
                        "  Y O  ",
                        ".PAINT.",
                        "  . E  ",
                        "    .  "
                    },new List<string> {
                        "   .     ",
                        "   U     ",
                        "   M .   ",
                        ".AMBER.  ",
                        "   E E   ",
                        "  .RUDDY.",
                        "   . .   "
                    },new List<string> {
                        " .   ",
                        " S   ",
                        " E   ",
                        " P   ",
                        " I   ",
                        ".ART.",
                        " .   "
                    },new List<string> {
                        " .     ",
                        " T     ",
                        " U     ",
                        " B     ",
                        ".EBONY.",
                        " .     "
                    },new List<string> {
                        " .    ",
                        ".TUBE.",
                        " A    ",
                        " N    ",
                        " .    "
                    },new List<string> {
                        "   . ",
                        "   T ",
                        "   A ",
                        ".DUN.",
                        "   . "
                    },new List<string> {
                        " .   ",
                        " J   ",
                        " A   ",
                        ".DUN.",
                        " E   ",
                        " .   "
                    }
                };

                case 8712:

                    return new List<List<string>> {

                    new List<string> {
                        "    .  ",
                        "    T  ",
                        "  . U  ",
                        "  M R  ",
                        "  E.K  ",
                        ".FARE. ",
                        " .TOYS.",
                        "  .A.  ",
                        "   S   ",
                        "   T   ",
                        "   .   "
                    },new List<string> {
                        "   .    ",
                        "   J    ",
                        "   E    ",
                        "   L.   ",
                        ".SALT.  ",
                        "  .YULE.",
                        "   .R   ",
                        "    K   ",
                        "    E   ",
                        "    Y   ",
                        "    .   "
                    },new List<string> {
                        "   .    ",
                        "   R .  ",
                        " .TOYS. ",
                        "   A W  ",
                        "   S E  ",
                        ".NUTMEG.",
                        "   . T  ",
                        "     S  ",
                        "     .  "
                    },new List<string> {
                        "      . ",
                        "      P ",
                        "      A ",
                        "  .   R ",
                        ".SWEETS.",
                        "  I   L ",
                        "  S   E ",
                        " .HOLLY.",
                        "  E   . ",
                        "  S     ",
                        "  .     "
                    },new List<string> {
                        " .    ",
                        " D .  ",
                        " A J  ",
                        ".TREE.",
                        " E L  ",
                        ".SALT.",
                        " . Y  ",
                        "   .  "
                    },new List<string> {
                        "    .     ",
                        "    S     ",
                        "    A     ",
                        "  .GUESTS.",
                        "  T C     ",
                        ".YULE.    ",
                        "  R .     ",
                        "  K       ",
                        "  E       ",
                        "  Y       ",
                        "  .       "
                    },new List<string> {
                        "      . ",
                        "  .   P ",
                        " .SUGAR.",
                        "  A   E ",
                        ".GUESTS.",
                        "  C   E ",
                        "  E   N ",
                        "  .   T ",
                        "      S ",
                        "      . "
                    },new List<string> {
                        "         .   ",
                        "       . B   ",
                        "      .PLUMS.",
                        "       O S   ",
                        "       R H   ",
                        ".PRESENTS.   ",
                        "       .     "
                    },new List<string> {
                        "    .   ",
                        "  . E   ",
                        " .SUGAR.",
                        "  A G   ",
                        ".GUESTS.",
                        "  C .   ",
                        "  E     ",
                        "  .     "
                    },new List<string> {
                        "      . ",
                        ".WISHES.",
                        "      P ",
                        "      I ",
                        "      C ",
                        "      E ",
                        "      . "
                    },new List<string> {
                        " .      ",
                        " W      ",
                        " I      ",
                        ".NUTMEG.",
                        " E      ",
                        " .      "
                    }
                };

                case 8802:

                    return new List<List<string>> {

                    new List<string> {
                        "  . .  ",
                        "  S B  ",
                        "  P L  ",
                        "  O A  ",
                        ".PRIZE.",
                        "  T E  ",
                        "  .ART.",
                        "    .  "
                    },new List<string> {
                        "    .   ",
                        "    C   ",
                        "    A   ",
                        "    P   ",
                        " .MATES.",
                        " A  A   ",
                        " R  I   ",
                        ".TENNIS.",
                        " .  .   "
                    },new List<string> {
                        "    .      ",
                        "   .M      ",
                        "  .CAPTAIN.",
                        ".SWOT.     ",
                        "  .PHYSICS.",
                        ".BOYS.     ",
                        "   ..      "
                    },new List<string> {
                        "     .    ",
                        "     S    ",
                        "     P    ",
                        "    .O    ",
                        "   .PRIZE.",
                        ".QUIET.   ",
                        "    N.    ",
                        "    .     "
                    },new List<string> {
                        "     .    ",
                        "     P    ",
                        "   .CLASS.",
                        "   Q A    ",
                        ".STUDY.   ",
                        "   I .    ",
                        "   E      ",
                        "   T      ",
                        "   .      "
                    },new List<string> {
                        " .     ",
                        " L     ",
                        " I     ",
                        " N     ",
                        " E     ",
                        ".SPORT.",
                        " .     "
                    },new List<string> {
                        "    .  ",
                        "    L  ",
                        "  . I  ",
                        " .CANE.",
                        "  R E  ",
                        "  A S  ",
                        ".GYM.  ",
                        "  O    ",
                        "  N    ",
                        "  .    "
                    },new List<string> {
                        " .     ",
                        " S     ",
                        " U     ",
                        " M     ",
                        ".STUDY.",
                        " .     "
                    },new List<string> {
                        "   .     ",
                        ".TERM.   ",
                        "   O C   ",
                        "   L A   ",
                        "  .LINES.",
                        "   . E   ",
                        "     .   "
                    },new List<string> {
                        " .    ",
                        " T    ",
                        " A    ",
                        " B    ",
                        " L    ",
                        " E    ",
                        ".SUMS.",
                        " .    "
                    },new List<string> {
                        "      . ",
                        "      I ",
                        ".CRAYON.",
                        "      K ",
                        "      . "
                    }
                };

                case 8803:

                    return new List<List<string>> {

                    new List<string> {
                        "  .       ",
                        "  Q .     ",
                        ".SUEZ.    ",
                        "  I U     ",
                        " .TORONTO.",
                        "  O I     ",
                        "  . C     ",
                        "    H     ",
                        "    .     "
                    },new List<string> {
                        "    .     ",
                        "    T     ",
                        "    O     ",
                        "    R     ",
                        "    O     ",
                        "    N.    ",
                        "   .TOKYO.",
                        ".LAGOS.   ",
                        "    .L    ",
                        "     O    ",
                        "     .    "
                    },new List<string> {
                        "    .  ",
                        ".TOKYO.",
                        "    O  ",
                        "    R  ",
                        "    K  ",
                        "    .  "
                    },new List<string> {
                        "     . .   ",
                        "     B L   ",
                        "    .OSAKA.",
                        "     N G   ",
                        ".TORONTO.  ",
                        "     . S   ",
                        "       .   "
                    },new List<string> {
                        "   . . ",
                        "   L C ",
                        ".OSAKA.",
                        "   G I ",
                        "   O R ",
                        " .OSLO.",
                        "   . . "
                    },new List<string> {
                        "   .  ",
                        ".YORK.",
                        "   O  ",
                        "   M  ",
                        "   E  ",
                        "   .  "
                    },new List<string> {
                        "      . ",
                        "      O ",
                        "      M ",
                        "      A ",
                        ".ZURICH.",
                        "      A ",
                        "      . "
                    },new List<string> {
                        "  .     ",
                        ".BOGOTA.",
                        "  M     ",
                        "  A     ",
                        "  H     ",
                        "  A     ",
                        "  .     "
                    },new List<string> {
                        "     .  ",
                        ".BOGOTA.",
                        "     O  ",
                        "     L  ",
                        "     E  ",
                        "     D  ",
                        "     O  ",
                        "     .  "
                    },new List<string> {
                        "  .     ",
                        "  T     ",
                        "  O     ",
                        "  L .   ",
                        ".DELHI. ",
                        "  D O   ",
                        ".BOMBAY.",
                        "  . A   ",
                        "    R   ",
                        "    T   ",
                        "    .   "
                    },new List<string> {
                        "  . .     ",
                        "  D B     ",
                        "  E O     ",
                        "  L.M     ",
                        " .HOBART. ",
                        ".LIMA.    ",
                        "  .SYDNEY.",
                        "   K.     ",
                        "   .      "
                    },new List<string> {
                        "  .      ",
                        ".HOBART. ",
                        "  M    A ",
                        " .SYDNEY.",
                        "  K    R ",
                        "  .    . "
                    },new List<string> {
                        "     .   ",
                        ".HOBART. ",
                        "     E A ",
                        " .SYDNEY.",
                        "     O R ",
                        "     . . "
                    },new List<string> {
                        "    . ",
                        "    C ",
                        "    O ",
                        "    R ",
                        ".OMSK.",
                        "    . "
                    }
                };

                case 8804:

                    return new List<List<string>> {

                    new List<string> {
                        " . .   ",
                        ".HUM.  ",
                        " Y A   ",
                        ".MEZZO.",
                        " N U   ",
                        " . R   ",
                        "   K   ",
                        "   A   ",
                        "   .   "
                    },new List<string> {
                        "   . . ",
                        "   M V ",
                        "   A I ",
                        ".MEZZO.",
                        "   U L ",
                        " .ARIA.",
                        "   K . ",
                        "   A   ",
                        "   .   "
                    },new List<string> {
                        "  .   ",
                        "  K   ",
                        "  E   ",
                        ".HYMN.",
                        "  .   "
                    },new List<string> {
                        "    . ",
                        "    S ",
                        "    I ",
                        "    G ",
                        ".HYMN.",
                        "    . "
                    },new List<string> {
                        " .    ",
                        ".SONG.",
                        " I    ",
                        " G    ",
                        " N    ",
                        " .    "
                    },new List<string> {
                        "   .    ",
                        ".SONG.  ",
                        "   O T  ",
                        "  .TRIO.",
                        "   E E  ",
                        "   . .  "
                    },new List<string> {
                        "    .   ",
                        "   .D   ",
                        "  .TUNE.",
                        ".TRIO.  ",
                        "   E.   ",
                        "   .    "
                    },new List<string> {
                        "  . .   ",
                        "  D R   ",
                        ".TUNE.  ",
                        "  O S   ",
                        "  .STOP.",
                        "    .   "
                    },new List<string> {
                        "  . .   ",
                        "  R H   ",
                        "  E.A   ",
                        " .STRUM.",
                        ".STOP.  ",
                        "  .N.   ",
                        "   E    ",
                        "   .    "
                    },new List<string> {
                        "   . . ",
                        "  .HIT.",
                        "   A I ",
                        ".STRUM.",
                        "   P E ",
                        "   . . "
                    },new List<string> {
                        "    .  ",
                        "  . T  ",
                        " .STOP.",
                        "  L N  ",
                        ".MUTE. ",
                        "  R .  ",
                        "  .    "
                    },new List<string> {
                        "       . ",
                        "       B ",
                        ".MAZURKA.",
                        "       S ",
                        "       S ",
                        "       O ",
                        "       . "
                    },new List<string> {
                        "    .    ",
                        "    S    ",
                        "   .C    ",
                        "  .MOOD. ",
                        ".SLUR.   ",
                        "  .TEMPO.",
                        "   E.    ",
                        "   .     "
                    },new List<string> {
                        "     . ",
                        "   . H ",
                        ".BASSO.",
                        "   C L ",
                        " .MOOD.",
                        "   R . ",
                        "   E   ",
                        "   .   "
                    },new List<string> {
                        "     . ",
                        "   . F ",
                        ".TEMPO.",
                        "   A R ",
                        " .FRET.",
                        "   C E ",
                        "   H . ",
                        "   .   "
                    },new List<string> {
                        "     . ",
                        "     E ",
                        "     C ",
                        ".MARCH.",
                        "     O ",
                        "     . "
                    },new List<string> {
                        " .   ",
                        " V   ",
                        " I   ",
                        " O   ",
                        ".LOW.",
                        " A   ",
                        " .   "
                    },new List<string> {
                        "    . ",
                        "    L ",
                        "    O ",
                        ".SLOW.",
                        "    . "
                    }
                };

                case 8805:

                    return new List<List<string>> {

                    new List<string> {
                        "  . .     ",
                        "  W G     ",
                        " .HARVEST.",
                        "  E A     ",
                        ".MAIZE.   ",
                        "  T I     ",
                        "  . N     ",
                        "    G     ",
                        "    .     "
                    },new List<string> {
                        "     . .   ",
                        "     E.R   ",
                        "    .WOOL. ",
                        "   .MEAT.  ",
                        "     .TANK.",
                        ".HARVEST.  ",
                        "      .I   ",
                        "       O   ",
                        "       N   ",
                        "       .   "
                    },new List<string> {
                        "        .   ",
                        "       .B   ",
                        "      .SILO.",
                        ".ROTATION.  ",
                        "       I.   ",
                        "       L    ",
                        "       .    "
                    },new List<string> {
                        "    .    ",
                        "    W    ",
                        "    H    ",
                        "   .E    ",
                        "  .MAIZE.",
                        ".ROOT.   ",
                        "   W.    ",
                        "   .     "
                    },new List<string> {
                        " .   . ",
                        ".STRAW.",
                        " E   H ",
                        " E   E ",
                        " D   A ",
                        " .ROOT.",
                        "     . "
                    },new List<string> {
                        "  .    ",
                        "  C    ",
                        "  A    ",
                        "  R    ",
                        ".STRAW.",
                        "  .    "
                    },new List<string> {
                        "    .  ",
                        "    G  ",
                        "    R  ",
                        " .  A  ",
                        ".MAIZE.",
                        " O  I  ",
                        " W  N  ",
                        " .PIG. ",
                        "    .  "
                    },new List<string> {
                        "    . ",
                        "    H ",
                        ".SILO.",
                        "    E ",
                        "    . "
                    },new List<string> {
                        "    . ",
                        ".SOIL.",
                        "    A ",
                        "    M ",
                        "    B ",
                        "    . "
                    },new List<string> {
                        " .   ",
                        " R   ",
                        " A   ",
                        " K   ",
                        ".EWE.",
                        " .   "
                    },new List<string> {
                        " .   ",
                        ".RYE.",
                        " A   ",
                        " K   ",
                        " E   ",
                        " .   "
                    },new List<string> {
                        "  .  ",
                        "  H  ",
                        "  A  ",
                        ".RYE.",
                        "  .  "
                    },new List<string> {
                        "    .  ",
                        ".STOCK.",
                        "    A  ",
                        "    R  ",
                        "    T  ",
                        "    .  "
                    },new List<string> {
                        " .    ",
                        ".STUD.",
                        " T    ",
                        " O    ",
                        " C    ",
                        " K    ",
                        " .    "
                    },new List<string> {
                        "   .  ",
                        "   S  ",
                        "   E  ",
                        ".SHED.",
                        "   D  ",
                        "   .  "
                    },new List<string> {
                        " .     ",
                        ".SHEEP.",
                        " H     ",
                        " E     ",
                        " D     ",
                        " .     "
                    },new List<string> {
                        " .     ",
                        " S     ",
                        " H     ",
                        " E     ",
                        " E     ",
                        ".PLANT.",
                        " .     "
                    }
                };

                case 8806:

                    return new List<List<string>> {

                    new List<string> {
                        " .    ",
                        " S .  ",
                        " T.B  ",
                        ".AHOY.",
                        ".YAW. ",
                        " .W.  ",
                        "  S   ",
                        "  E   ",
                        "  R   ",
                        "  .   "
                    },new List<string> {
                        "   .  ",
                        "   A  ",
                        "  .H  ",
                        " .BOW.",
                        ".GUY. ",
                        "  O.  ",
                        "  Y   ",
                        "  .   "
                    },new List<string> {
                        "    .   ",
                        "   .P   ",
                        "  .MOOR.",
                        ".SPAR.  ",
                        "  .STAY.",
                        "   T.   ",
                        "   .    "
                    },new List<string> {
                        "   . ",
                        "   B ",
                        "   U ",
                        "   O ",
                        ".PLY.",
                        "   . "
                    },new List<string> {
                        "    .     ",
                        "    H     ",
                        "  .YAW.   ",
                        "  F W     ",
                        ".BOWSPRIT.",
                        "  G E     ",
                        "  . R     ",
                        "    .     "
                    },new List<string> {
                        "    .     ",
                        "    H     ",
                        "    A .   ",
                        "    W C   ",
                        ".BOWSPRIT.",
                        "    E E   ",
                        "  .PROW.  ",
                        "    . .   "
                    },new List<string> {
                        "   .       ",
                        "  .F       ",
                        " .BOWSPRIT.",
                        ".LOG.      ",
                        "  X.       ",
                        "  .        "
                    },new List<string> {
                        "        . ",
                        "        W ",
                        "        A ",
                        ".BOWSPRIT.",
                        "        C ",
                        "        H ",
                        "        . "
                    },new List<string> {
                        "   . ",
                        "   M ",
                        "   A ",
                        "   S ",
                        ".SET.",
                        "   . "
                    },new List<string> {
                        " .   ",
                        ".SET.",
                        " H   ",
                        " I   ",
                        " P   ",
                        " .   "
                    },new List<string> {
                        "    .   ",
                        "  .DORY.",
                        "  P A   ",
                        ".MOOR.  ",
                        "  R .   ",
                        "  T     ",
                        "  .     "
                    },new List<string> {
                        "    . ",
                        "    D ",
                        "    O ",
                        "    R ",
                        ".QUAY.",
                        "    . "
                    },new List<string> {
                        "   .  ",
                        ".QUAY.",
                        "   F  ",
                        "   T  ",
                        "   .  "
                    },new List<string> {
                        "     . ",
                        "     A ",
                        "     F ",
                        ".YACHT.",
                        "     . "
                    },new List<string> {
                        "     . ",
                        ".JETTY.",
                        "     A ",
                        "     C ",
                        "     H ",
                        "     T ",
                        "     . "
                    },new List<string> {
                        " .     ",
                        ".JETTY.",
                        " U     ",
                        " N     ",
                        " K     ",
                        " .     "
                    },new List<string> {
                        "      . ",
                        "      J ",
                        "      U ",
                        ".ASTERN.",
                        "      K ",
                        "      . "
                    },new List<string> {
                        "   . .   ",
                        ".TRANSOM.",
                        "   S A   ",
                        "  .TRIM. ",
                        "   E L   ",
                        "   R .   ",
                        "   N     ",
                        "   .     "
                    },new List<string> {
                        " .       ",
                        ".TRANSOM.",
                        " A       ",
                        " C       ",
                        " K       ",
                        " .       "
                    }
                };

                case 8807:

                    return new List<List<string>> {

                    new List<string> {
                        "    .     ",
                        "   .C     ",
                        ".LIZA.    ",
                        "  .SIDNEY.",
                        ".ALAN.    ",
                        "   .E     ",
                        "    .     "
                    },new List<string> {
                        "  . . ",
                        ".ALDA.",
                        "  I L ",
                        " .ZSA.",
                        "  A N ",
                        "  . . "
                    },new List<string> {
                        "    . .   ",
                        "    D T   ",
                        "    U A   ",
                        ".SIDNEY.  ",
                        "    A L   ",
                        "   .WOODY.",
                        "    A R   ",
                        "    Y .   ",
                        "    .     "
                    },new List<string> {
                        "     . ",
                        "     F ",
                        "     A ",
                        ".WOODY.",
                        "     E ",
                        "     . "
                    },new List<string> {
                        "    . ",
                        "    D ",
                        "    U ",
                        "    N ",
                        "    A ",
                        "    W ",
                        "    A ",
                        ".TONY.",
                        "    . "
                    },new List<string> {
                        " .      ",
                        ".TAYLOR.",
                        " O      ",
                        " M      ",
                        " .      "
                    },new List<string> {
                        " .    ",
                        " S    ",
                        ".TONY.",
                        " E    ",
                        " V    ",
                        " E    ",
                        " .    "
                    },new List<string> {
                        "    .    ",
                        "    N.   ",
                        "   .OMAR.",
                        ".STEVE.  ",
                        "   .AL.  ",
                        "    K.   ",
                        "    .    "
                    },new List<string> {
                        " .     ",
                        " J     ",
                        " O     ",
                        " H     ",
                        ".NOVAK.",
                        " .     "
                    },new List<string> {
                        "    . ",
                        ".OMAR.",
                        "    O ",
                        "    D ",
                        "    . "
                    },new List<string> {
                        "   . ",
                        ".ROD.",
                        "   E ",
                        "   A ",
                        "   N ",
                        "   . "
                    },new List<string> {
                        "      . ",
                        "      F ",
                        "      I ",
                        "      N ",
                        "  .DEAN.",
                        "  D   E ",
                        ".MURPHY.",
                        "  S   . ",
                        "  T     ",
                        "  I     ",
                        "  N     ",
                        "  .     "
                    },new List<string> {
                        "    . . ",
                        "    B R ",
                        "  .JUDY.",
                        "    R A ",
                        ".DUSTIN.",
                        "    . . "
                    },new List<string> {
                        "    .   ",
                        ".MURPHY.",
                        "    E   ",
                        "    T   ",
                        "    E   ",
                        "    R   ",
                        "    .   "
                    },new List<string> {
                        "   .   ",
                        ".PETER.",
                        "   A   ",
                        "   B   ",
                        "   .   "
                    },new List<string> {
                        " .   ",
                        " T   ",
                        " A   ",
                        ".BOW.",
                        " .   "
                    }
                };

                case 8808:

                    return new List<List<string>> {

                    new List<string> {
                        "   .    ",
                        "   R    ",
                        "   E .  ",
                        "   N M  ",
                        "   A.A  ",
                        ".STUTZ. ",
                        "  .LADA.",
                        ".ASTRA. ",
                        "   .A.  ",
                        "    G   ",
                        "    O   ",
                        "    .   "
                    },new List<string> {
                        "   .     ",
                        "   R     ",
                        "   E .   ",
                        "  .NOMAD.",
                        "   A A   ",
                        ".STUTZ.  ",
                        "   L D   ",
                        "   T A   ",
                        "   . .   "
                    },new List<string> {
                        " . .     ",
                        ".RENAULT.",
                        " O O     ",
                        " L M     ",
                        " L A     ",
                        ".SEDAN.  ",
                        " . .     "
                    },new List<string> {
                        "    .     ",
                        "    T     ",
                        "    E     ",
                        "    L     ",
                        "    S     ",
                        "    T.    ",
                        "   .ASTRA.",
                        ".SUPRA.   ",
                        "    .A    ",
                        "     B    ",
                        "     .    "
                    },new List<string> {
                        " .       ",
                        " C       ",
                        " O       ",
                        " L       ",
                        ".TELSTAR.",
                        " .       "
                    },new List<string> {
                        "  .    ",
                        "  A    ",
                        ".SUPRA.",
                        "  D    ",
                        "  I    ",
                        "  .    "
                    },new List<string> {
                        "  .    ",
                        "  C    ",
                        ".ROCKY.",
                        "  L    ",
                        "  T    ",
                        "  .    "
                    },new List<string> {
                        "     .   ",
                        "     C   ",
                        "     A   ",
                        "  .ROMEO.",
                        "  C  R   ",
                        ".ROCKY.  ",
                        "  L  .   ",
                        "  T      ",
                        "  .      "
                    },new List<string> {
                        "     . ",
                        "     R ",
                        "     O ",
                        "     M ",
                        "     E ",
                        ".TURBO.",
                        "     . "
                    },new List<string> {
                        " .       ",
                        " V       ",
                        " O       ",
                        " R  .    ",
                        ".TURBO.  ",
                        " E  E    ",
                        " X  N    ",
                        " .SUZUKI.",
                        "    .    "
                    },new List<string> {
                        " .  ",
                        ".VW.",
                        " O  ",
                        " R  ",
                        " T  ",
                        " E  ",
                        " X  ",
                        " .  "
                    },new List<string> {
                        "  . ",
                        "  B ",
                        "  M ",
                        ".VW.",
                        "  . "
                    },new List<string> {
                        "  .  ",
                        ".BMW.",
                        "  G  ",
                        "  .  "
                    },new List<string> {
                        "  .     ",
                        "  L  .  ",
                        ".TARAGO.",
                        "  D  O  ",
                        "  A  L  ",
                        "  .ALFA.",
                        "     .  "
                    }
                };

                case 8809:

                    return new List<List<string>> {

                    new List<string> {
                        "   .   ",
                        "   G   ",
                        "   O   ",
                        "   R   ",
                        "   G   ",
                        "   O   ",
                        " . N   ",
                        ".PIZZA.",
                        " O O   ",
                        ".ROLLS.",
                        " K A   ",
                        " . .   "
                    },new List<string> {
                        "   .   ",
                        "   G   ",
                        "   O   ",
                        "   R   ",
                        "   G   ",
                        "   O . ",
                        "   N P ",
                        ".PIZZA.",
                        "   O R ",
                        ".ROLLS.",
                        "   A L ",
                        "   . E ",
                        "     Y ",
                        "     . "
                    },new List<string> {
                        "      . ",
                        "      P ",
                        "      A ",
                        "      R ",
                        "      S ",
                        "      L ",
                        "      E ",
                        ".TURKEY.",
                        "      . "
                    },new List<string> {
                        "      .    ",
                        "    . G    ",
                        "   .TURKEY.",
                        "    A A    ",
                        "    R V    ",
                        ".PASTRY.   ",
                        "    . .    "
                    },new List<string> {
                        "   .    ",
                        "   G .  ",
                        ".TURKEY.",
                        "   A D  ",
                        "  .VEAL.",
                        "   Y M  ",
                        "   . .  "
                    },new List<string> {
                        "     .      ",
                        "     S      ",
                        "   .STEAK.  ",
                        "   P I      ",
                        "   E L      ",
                        "   A T      ",
                        ".GORGONZOLA.",
                        "   . N      ",
                        "     .      "
                    },new List<string> {
                        "   .       ",
                        "   M       ",
                        "   I       ",
                        "   N.      ",
                        ".NUTS.     ",
                        "  .STILTON.",
                        "   .E      ",
                        "    A      ",
                        "    K      ",
                        "    .      "
                    },new List<string> {
                        " . .  ",
                        ".LAMB.",
                        " O I  ",
                        " I N  ",
                        ".NUTS.",
                        " . S  ",
                        "   .  "
                    },new List<string> {
                        "     .  ",
                        "     D  ",
                        "  .SOUP.",
                        "  S  C  ",
                        ".STEAK. ",
                        "  I  .  ",
                        "  L     ",
                        "  T     ",
                        "  O     ",
                        "  N     ",
                        "  .     "
                    },new List<string> {
                        "     .      ",
                        "     S      ",
                        "     T      ",
                        "     I      ",
                        " .   L      ",
                        " E   T      ",
                        ".GORGONZOLA.",
                        " G   N      ",
                        ".SAGO.      ",
                        " .          "
                    },new List<string> {
                        "    . ",
                        "    M ",
                        "    I ",
                        "    L ",
                        ".PORK.",
                        "    . "
                    },new List<string> {
                        " .    ",
                        ".MEAT.",
                        " I    ",
                        " L    ",
                        " K    ",
                        " .    "
                    },new List<string> {
                        "    . ",
                        ".MEAT.",
                        "    E ",
                        "    A ",
                        "    . "
                    },new List<string> {
                        "  .   ",
                        "  P   ",
                        "  I   ",
                        ".MEAT.",
                        "  .   "
                    },new List<string> {
                        "  .    ",
                        ".SPICE.",
                        "  I    ",
                        "  E    ",
                        "  .    "
                    }
                };

                case 8810:

                    return new List<List<string>> {

                    new List<string> {
                        "    .  ",
                        ".ORCZY.",
                        "    O  ",
                        "    L  ",
                        "    A  ",
                        "    .  "
                    },new List<string> {
                        "  .    ",
                        "  R  . ",
                        "  O  H ",
                        "  H  E ",
                        " .MANN.",
                        "  E  R ",
                        ".ORCZY.",
                        "  .  . "
                    },new List<string> {
                        "    .    ",
                        "    R    ",
                        "    O    ",
                        "    H    ",
                        "   .M    ",
                        ".POPE.   ",
                        "  .ORCZY.",
                        "   E.    ",
                        "   .     "
                    },new List<string> {
                        "     . ",
                        "   . R ",
                        "   H O ",
                        ".WAUGH.",
                        "   G M ",
                        " .POPE.",
                        "   . R ",
                        "     . "
                    },new List<string> {
                        "    . ",
                        ".SHAW.",
                        "    A ",
                        "    U ",
                        "    G ",
                        "    H ",
                        "    . "
                    },new List<string> {
                        " .    ",
                        " G    ",
                        " A    ",
                        ".SHAW.",
                        " K    ",
                        " I    ",
                        " N    ",
                        " .    "
                    },new List<string> {
                        " .     ",
                        ".PEPYS.",
                        " O     ",
                        " P     ",
                        " E     ",
                        " .     "
                    },new List<string> {
                        "   . .  ",
                        "   K G  ",
                        ".HEYER. ",
                        "   N E  ",
                        " .PEPYS.",
                        "   . .  "
                    },new List<string> {
                        " .    ",
                        ".GLYN.",
                        " A    ",
                        " S    ",
                        " K    ",
                        " I    ",
                        " N    ",
                        " .    "
                    },new List<string> {
                        "  .      ",
                        ".CHEYNEY.",
                        "  E      ",
                        "  N      ",
                        "  R      ",
                        "  Y      ",
                        "  .      "
                    },new List<string> {
                        "   .    ",
                        "   C    ",
                        "   H    ",
                        "   E  . ",
                        ".SAYERS.",
                        "   N  A ",
                        "  .EDEN.",
                        "   Y  D ",
                        "   .  . "
                    },new List<string> {
                        "   .   ",
                        " . H   ",
                        " S A   ",
                        ".AYRES.",
                        " N D   ",
                        ".DOYLE.",
                        " . .   "
                    },new List<string> {
                        "   . ",
                        "   C ",
                        "   H ",
                        "   E ",
                        "   Y ",
                        "   N ",
                        "   E ",
                        ".HAY.",
                        "   . "
                    },new List<string> {
                        " .      ",
                        " D      ",
                        " U      ",
                        " M      ",
                        " A      ",
                        ".SAYERS.",
                        " .      "
                    },new List<string> {
                        "     . ",
                        "     J ",
                        "     A ",
                        "     C ",
                        "     O ",
                        "     B ",
                        ".AYRES.",
                        "     . "
                    }
                };

                case 8811:

                    return new List<List<string>> {

                    new List<string> {
                        "   . .   ",
                        "   F.P   ",
                        ".MAIZE.  ",
                        "  .GUAVA.",
                        "   .C.   ",
                        "    C    ",
                        "    H    ",
                        "    I    ",
                        "    N    ",
                        "    I    ",
                        "    .    "
                    },new List<string> {
                        "   . .    ",
                        "  .PAPAYA.",
                        "   E E    ",
                        ".GUAVA.   ",
                        "   . R    ",
                        "     .    "
                    },new List<string> {
                        " .   ",
                        " P   ",
                        " A   ",
                        " P   ",
                        " A   ",
                        ".YAM.",
                        " A   ",
                        " .   "
                    },new List<string> {
                        "     .     ",
                        "     C     ",
                        ".ZUCCHINI. ",
                        "     E   C ",
                        "   .ORANGE.",
                        "     R   L ",
                        "     Y   E ",
                        "     .   R ",
                        "         Y ",
                        "         . "
                    },new List<string> {
                        "    . .   ",
                        "    O L   ",
                        ".CHERRY.  ",
                        "    A C   ",
                        "    N H   ",
                        "    G E   ",
                        "  .CELERY.",
                        "    . .   "
                    },new List<string> {
                        "       . ",
                        "       C ",
                        "       E ",
                        "    .  L ",
                        " .LYCHEE.",
                        "    O  R ",
                        ".PARSLEY.",
                        "    .  . "
                    },new List<string> {
                        " .     ",
                        ".MAIZE.",
                        " A     ",
                        " N     ",
                        " G     ",
                        " O     ",
                        " .     "
                    },new List<string> {
                        " .      ",
                        " P      ",
                        " E    . ",
                        ".CITRUS.",
                        " A    A ",
                        " N    G ",
                        " .MANGO.",
                        "      . "
                    },new List<string> {
                        "     .      ",
                        "     P      ",
                        "     L.     ",
                        ".CITRUS.    ",
                        "    .MARROW.",
                        "     .G     ",
                        "      O     ",
                        "      .     "
                    },new List<string> {
                        " .   .  ",
                        ".POTATO.",
                        " L   A  ",
                        " U   R  ",
                        ".MARROW.",
                        " .   .  "
                    },new List<string> {
                        "   .    ",
                        "   D    ",
                        "   A    ",
                        ".CITRUS.",
                        "   E    ",
                        "   .    "
                    },new List<string> {
                        "    .   ",
                        ".MARROW.",
                        "    A   ",
                        "    I   ",
                        "    S   ",
                        "    I   ",
                        "    N   ",
                        "    .   "
                    },new List<string> {
                        " .   ",
                        " R   ",
                        " A   ",
                        " I   ",
                        ".SOY.",
                        " I   ",
                        " N   ",
                        " .   "
                    }
                };

                case 8812:

                    return new List<List<string>> {

                    new List<string> {
                        "   . .   ",
                        " .AZALEA.",
                        "   I E   ",
                        ".ANNUAL. ",
                        "   N F   ",
                        "   I .   ",
                        "   A     ",
                        "   .     "
                    },new List<string> {
                        "   .    ",
                        " . Z    ",
                        " W I    ",
                        ".ANNUAL.",
                        " T N    ",
                        ".TRIM.  ",
                        " L A    ",
                        " E .    ",
                        " .      "
                    },new List<string> {
                        "      . ",
                        "  .ALOW.",
                        "  V   A ",
                        ".VIOLET.",
                        "  N   T ",
                        "  E   L ",
                        "  .   E ",
                        "      . "
                    },new List<string> {
                        "  .     ",
                        "  V .   ",
                        ".VIOLET.",
                        "  N O   ",
                        ".PEST.  ",
                        "  . U   ",
                        "    S   ",
                        "    .   "
                    },new List<string> {
                        "    .    ",
                        "    L    ",
                        "   .O    ",
                        ".PEST.   ",
                        "  .TUBER.",
                        " .HOSE.  ",
                        "   C.D   ",
                        "   K .   ",
                        "   .     "
                    },new List<string> {
                        "     . ",
                        ".TUBER.",
                        "     O ",
                        "     S ",
                        "     E ",
                        "     . "
                    },new List<string> {
                        " .   ",
                        " R   ",
                        " O   ",
                        ".SOW.",
                        " E   ",
                        " .   "
                    },new List<string> {
                        "   . ",
                        "   L ",
                        "   A ",
                        ".SOW.",
                        "   N ",
                        "   . "
                    },new List<string> {
                        "   .     ",
                        " . P     ",
                        ".LILY.   ",
                        " A A     ",
                        " W N     ",
                        ".NATIVES.",
                        " . .     "
                    },new List<string> {
                        "    .    ",
                        "   .M    ",
                        "  .PANSY.",
                        ".LILY.   ",
                        "   A.    ",
                        "   N     ",
                        "   T     ",
                        "   .     "
                    },new List<string> {
                        "     . ",
                        "     P ",
                        "     O ",
                        "  .TAP.",
                        "  M  P ",
                        ".PANSY.",
                        "  Y  . ",
                        "  .    "
                    },new List<string> {
                        " .   ",
                        " P   ",
                        " O   ",
                        ".TAP.",
                        " .   "
                    },new List<string> {
                        "  .    ",
                        "  M .  ",
                        ".PANSY.",
                        "  Y P  ",
                        "  .CAN.",
                        "    D  ",
                        "    E  ",
                        "    .  "
                    },new List<string> {
                        "   .  ",
                        "   S  ",
                        "   T  ",
                        "   O  ",
                        "   C  ",
                        ".RAKE.",
                        "   .  "
                    }
                };

                case 8902:

                    return new List<List<string>> {

                    new List<string> {
                        "     . ",
                        "     R ",
                        "     E ",
                        "     N ",
                        "   . D ",
                        "   F E ",
                        ".WALTZ.",
                        "   O V ",
                        "  .WOO.",
                        "   E U ",
                        "   R S ",
                        "   S . ",
                        "   .   "
                    },new List<string> {
                        "     . ",
                        "     R ",
                        "     E ",
                        "     N ",
                        "   . D ",
                        "   F E ",
                        ".WALTZ.",
                        "   O V ",
                        "   W O ",
                        "   E U ",
                        ".WORDS.",
                        "   S . ",
                        "   .   "
                    },new List<string> {
                        " .     ",
                        " P     ",
                        " E     ",
                        ".WORDS.",
                        " .     "
                    },new List<string> {
                        "    . ",
                        ".TRIP.",
                        "    E ",
                        "    W ",
                        "    . "
                    },new List<string> {
                        "    . .   ",
                        "    P P   ",
                        "    O.O   ",
                        ".GUESTS.  ",
                        "   .TRYST.",
                        "    .I.   ",
                        "     P    ",
                        "     .    "
                    },new List<string> {
                        "   .   ",
                        "   P . ",
                        "  .OLD.",
                        "   S A ",
                        ".TRYST.",
                        "   . E ",
                        "     . "
                    },new List<string> {
                        "   .   ",
                        "   G   ",
                        ".TRUST.",
                        "   E   ",
                        "   S   ",
                        "   T   ",
                        "   S   ",
                        "   .   "
                    },new List<string> {
                        " .     ",
                        ".TAXI. ",
                        " O   G ",
                        " A   I ",
                        " S   F ",
                        ".TRUST.",
                        " .   . "
                    },new List<string> {
                        "   .  ",
                        "   M  ",
                        "   I  ",
                        ".TAXI.",
                        "   .  "
                    },new List<string> {
                        "   .  ",
                        ".HYMN.",
                        "   I  ",
                        "   X  ",
                        "   .  "
                    },new List<string> {
                        "   . ",
                        "   H ",
                        ".JOY.",
                        "   M ",
                        "   N ",
                        "   . "
                    },new List<string> {
                        "    . ",
                        "    W ",
                        "    I ",
                        ".HYMN.",
                        "    . "
                    },new List<string> {
                        " .   ",
                        ".WIN.",
                        " I   ",
                        " N   ",
                        " E   ",
                        " .   "
                    },new List<string> {
                        "    .    ",
                        "    R    ",
                        "    O    ",
                        "  .USHER.",
                        "  G E    ",
                        ".KISS.   ",
                        "  F .    ",
                        "  T      ",
                        "  .      "
                    },new List<string> {
                        "   . .   ",
                        "   G U   ",
                        "  .ROSES.",
                        "   O H   ",
                        ".ADORE.  ",
                        "   M R   ",
                        "   . .   "
                    }
                };

                case 8903:

                    return new List<List<string>> {

                    new List<string> {
                        " .      ",
                        " T      ",
                        " A      ",
                        " N      ",
                        ".ZAMBIA.",
                        " A      ",
                        " N      ",
                        " I      ",
                        " A      ",
                        " .      "
                    },new List<string> {
                        "    .  .   ",
                        "    Y  G   ",
                        "    E  U   ",
                        ".GERMANY.  ",
                        "    E  A   ",
                        " .TANZANIA.",
                        "    .  A   ",
                        "       .   "
                    },new List<string> {
                        "  .  .    ",
                        ".ITALY.   ",
                        "  O  E    ",
                        " .GERMANY.",
                        "  O  E    ",
                        "  .  N    ",
                        "     .    "
                    },new List<string> {
                        "      . .     ",
                        "      G H     ",
                        "     .URUGUAY.",
                        "      Y N     ",
                        "      A G     ",
                        ".TANZANIA.    ",
                        "      A R     ",
                        "      . Y     ",
                        "        .     "
                    },new List<string> {
                        "       . ",
                        "       S ",
                        ".URUGUAY.",
                        "       R ",
                        "       I ",
                        "       A ",
                        "       . "
                    },new List<string> {
                        "      . .     ",
                        "      G H     ",
                        "      U U     ",
                        "      Y N     ",
                        "      A G     ",
                        ".TANZANIA.    ",
                        "      A R     ",
                        "      .CYPRUS.",
                        "        .     "
                    },new List<string> {
                        "     .   ",
                        "     C   ",
                        ".URUGUAY.",
                        "     B   ",
                        "     A   ",
                        "     .   "
                    },new List<string> {
                        "     .  ",
                        "   . B  ",
                        ".CYPRUS.",
                        "   E R  ",
                        "   R M  ",
                        " .SUDAN.",
                        "   . .  "
                    },new List<string> {
                        " .        ",
                        ".TANZANIA.",
                        " U        ",
                        " R        ",
                        " K        ",
                        " E        ",
                        " Y        ",
                        " .        "
                    },new List<string> {
                        "      . ",
                        "      K ",
                        "      E ",
                        "      N ",
                        ".TURKEY.",
                        "      A ",
                        "      . "
                    },new List<string> {
                        "    .  ",
                        "    T  ",
                        "    U  ",
                        ".ZAIRE.",
                        "    K  ",
                        "    E  ",
                        "    Y  ",
                        "    .  "
                    },new List<string> {
                        " .     ",
                        " B     ",
                        " E     ",
                        " L     ",
                        " I     ",
                        ".ZAIRE.",
                        " E     ",
                        " .     "
                    },new List<string> {
                        "     .  ",
                        "     N  ",
                        ".ZAMBIA.",
                        "     G  ",
                        "     E  ",
                        "     R  ",
                        "     .  "
                    }
                };

                case 8904:

                    return new List<List<string>> {

                    new List<string> {
                        " .      ",
                        ".ZIGZAG.",
                        " I      ",
                        " P      ",
                        " P      ",
                        " E      ",
                        " R      ",
                        " .      "
                    },new List<string> {
                        "      .     ",
                        "     .P     ",
                        "    .WALLET.",
                        ".ZIPPER.    ",
                        "    .STAGE. ",
                        "  .CITY.    ",
                        "     ..     "
                    },new List<string> {
                        "     .  ",
                        "     W  ",
                        "     A  ",
                        "     L  ",
                        "     L  ",
                        "     E  ",
                        ".TAHITI.",
                        "     .  "
                    },new List<string> {
                        "    . ",
                        ".EAST.",
                        "    A ",
                        "    H ",
                        "    I ",
                        "    T ",
                        "    I ",
                        "    . "
                    },new List<string> {
                        " .    ",
                        ".CITY.",
                        " A    ",
                        " R    ",
                        " D    ",
                        " S    ",
                        " .    "
                    },new List<string> {
                        " .   ",
                        " C   ",
                        " A   ",
                        " R   ",
                        " D   ",
                        ".SUN.",
                        " .   "
                    },new List<string> {
                        "     .  ",
                        "     M  ",
                        "    .O  ",
                        "  .SUN. ",
                        "   .SEA.",
                        ".RELAY. ",
                        "    ..  "
                    },new List<string> {
                        "  .    ",
                        ".MONEY.",
                        "  R    ",
                        "  I    ",
                        "  E    ",
                        "  N    ",
                        "  T    ",
                        "  .    "
                    },new List<string> {
                        "   .   ",
                        "   A   ",
                        "   I   ",
                        ".CARDS.",
                        "   .   "
                    },new List<string> {
                        "   .    ",
                        "   O    ",
                        " . R    ",
                        ".SWIM.  ",
                        " K E    ",
                        " I N    ",
                        " .ITALY.",
                        "   .    "
                    },new List<string> {
                        "   . ",
                        "   I ",
                        "   T ",
                        "   A ",
                        "   L ",
                        ".FLY.",
                        "   . "
                    },new List<string> {
                        "  .   ",
                        ".KEYS.",
                        "  A   ",
                        "  S   ",
                        "  T   ",
                        "  .   "
                    },new List<string> {
                        "   .  ",
                        "   J  ",
                        "   O  ",
                        "   U  ",
                        "   R  ",
                        "   N  ",
                        "   E  ",
                        ".KEYS.",
                        "   .  "
                    },new List<string> {
                        "   . .   ",
                        ".PORTS.  ",
                        "   O A   ",
                        ".JOURNEY.",
                        "   T D   ",
                        "   E .   ",
                        "   .     "
                    },new List<string> {
                        "   .     ",
                        "   R     ",
                        " . O     ",
                        ".JOURNEY.",
                        " E T     ",
                        ".TREK.   ",
                        " . .     "
                    }
                };

                case 8905:

                    return new List<List<string>> {

                    new List<string> {
                        "   . .  ",
                        "   S C  ",
                        "   H R  ",
                        "   I U  ",
                        "  .ROSE.",
                        "   A H  ",
                        ".FIZZ.  ",
                        "   .    "
                    },new List<string> {
                        "      .     ",
                        "      P     ",
                        "      O     ",
                        "      R     ",
                        "     .P     ",
                        "    .SHIRAZ.",
                        " .TOKAY.    ",
                        "    .CRUSH. ",
                        ".WHISKY.    ",
                        "     ..     "
                    },new List<string> {
                        "  .     ",
                        "  S     ",
                        "  C  .  ",
                        "  O  S  ",
                        " .TOKAY.",
                        "  C  C  ",
                        ".WHISKY.",
                        "  .  .  "
                    },new List<string> {
                        "   .       ",
                        "   B       ",
                        " .PORPHYRY.",
                        " C O       ",
                        ".OUZO.     ",
                        " L E       ",
                        " A .       ",
                        " .         "
                    },new List<string> {
                        "    .  ",
                        "    B  ",
                        "  . O  ",
                        "  C O  ",
                        " .OUZO.",
                        "  L E  ",
                        ".BAR.  ",
                        "  .    "
                    },new List<string> {
                        "  .   ",
                        ".ASTI.",
                        "  C   ",
                        "  O   ",
                        "  T   ",
                        "  C   ",
                        "  H   ",
                        "  .   "
                    },new List<string> {
                        "    . ",
                        "    A ",
                        "    S ",
                        ".PORT.",
                        "    I ",
                        "    . "
                    },new List<string> {
                        " .    ",
                        " N    ",
                        " I    ",
                        ".PORT.",
                        " .    "
                    },new List<string> {
                        "   .  ",
                        ".WINE.",
                        "   I  ",
                        "   P  ",
                        "   .  "
                    },new List<string> {
                        " .     ",
                        ".WATER.",
                        " I     ",
                        " N     ",
                        " E     ",
                        " .     "
                    },new List<string> {
                        "   . .   ",
                        "   M W   ",
                        "   I A   ",
                        ".SPLIT.  ",
                        "   K E   ",
                        "   .GROG.",
                        "     .   "
                    },new List<string> {
                        " .     ",
                        ".SPLIT.",
                        " P     ",
                        " I     ",
                        " R     ",
                        " I     ",
                        " T     ",
                        " .     "
                    },new List<string> {
                        " .     ",
                        " S     ",
                        " P     ",
                        " I .   ",
                        " R.R   ",
                        ".ICE.  ",
                        ".TODDY.",
                        " .K.   ",
                        "  E    ",
                        "  .    "
                    },new List<string> {
                        "  .  ",
                        "  T  ",
                        "  O  ",
                        "  D  ",
                        "  D  ",
                        ".RYE.",
                        "  .  "
                    },new List<string> {
                        "   . ",
                        ".RUM.",
                        "   I ",
                        "   L ",
                        "   K ",
                        "   . "
                    },new List<string> {
                        "    . ",
                        "    M ",
                        ".COKE.",
                        "    A ",
                        "    D ",
                        "    . "
                    }
                };

                case 8906:

                    return new List<List<string>> {

                    new List<string> {
                        "  . .   ",
                        "  M C   ",
                        "  E O   ",
                        "  T S   ",
                        "  E.M   ",
                        " .OZONE.",
                        ".EROS.  ",
                        "  .D.   ",
                        "   I    ",
                        "   A    ",
                        "   C    ",
                        "   .    "
                    },new List<string> {
                        " . .   ",
                        " M C   ",
                        ".EPOCH.",
                        " T S   ",
                        " E M   ",
                        ".OZONE.",
                        " R S   ",
                        " . .   "
                    },new List<string> {
                        "   . . ",
                        "   C P ",
                        ".EPOCH.",
                        "   S A ",
                        "   M S ",
                        ".OZONE.",
                        "   S . ",
                        "   .   "
                    },new List<string> {
                        "   .    ",
                        "   C    ",
                        "   O    ",
                        "   M    ",
                        "   E    ",
                        ".METEOR.",
                        "   .    "
                    },new List<string> {
                        "      .    ",
                        "      M    ",
                        "     .O    ",
                        "    .COMET.",
                        ".SATURN.   ",
                        "     A.    ",
                        "     T     ",
                        "     E     ",
                        "     R     ",
                        "     .     "
                    },new List<string> {
                        "   . .    ",
                        "  .SYZYGY.",
                        "   A E    ",
                        ".TITAN.   ",
                        "   U I    ",
                        "   R T    ",
                        "   N H    ",
                        "   . .    "
                    },new List<string> {
                        "  .     ",
                        "  D     ",
                        "  A     ",
                        ".SYZYGY.",
                        "  .     "
                    },new List<string> {
                        "    .   ",
                        "    S   ",
                        "    K   ",
                        ".SYZYGY.",
                        "    .   "
                    },new List<string> {
                        "  .    ",
                        "  C    ",
                        "  R    ",
                        "  A    ",
                        "  T    ",
                        "  E    ",
                        ".ARIES.",
                        "  .    "
                    },new List<string> {
                        " .     ",
                        ".ARIES.",
                        " R     ",
                        " C     ",
                        " .     "
                    },new List<string> {
                        "      . ",
                        ".SYZYGY.",
                        "      E ",
                        "      A ",
                        "      R ",
                        "      . "
                    },new List<string> {
                        " .   ",
                        ".SKY.",
                        " T   ",
                        " A   ",
                        " R   ",
                        " .   "
                    },new List<string> {
                        " .     ",
                        " L     ",
                        " I     ",
                        " G     ",
                        " H     ",
                        ".TITAN.",
                        " .     "
                    },new List<string> {
                        " .    ",
                        " T    ",
                        " I    ",
                        ".MOON.",
                        " E    ",
                        " .    "
                    },new List<string> {
                        " .   ",
                        " A   ",
                        " R   ",
                        " I   ",
                        " E   ",
                        ".SUN.",
                        " .   "
                    },new List<string> {
                        "  .  ",
                        ".SUN.",
                        "  R  ",
                        "  A  ",
                        "  N  ",
                        "  U  ",
                        "  S  ",
                        "  .  "
                    },new List<string> {
                        "      . ",
                        "      U ",
                        "      R ",
                        ".URANUS.",
                        "      A ",
                        "      . "
                    },new List<string> {
                        "  .    ",
                        ".CLOUD.",
                        "  I    ",
                        "  G    ",
                        "  H    ",
                        "  T    ",
                        "  .    "
                    }
                };

                case 8907:

                    return new List<List<string>> {

                    new List<string> {
                        "      .    ",
                        "      Q    ",
                        "    . U    ",
                        "    S A    ",
                        "    H.R    ",
                        "   .ART.   ",
                        "   .PUZZLE.",
                        ".EASEL.    ",
                        "    .E     ",
                        "     .     "
                    },new List<string> {
                        "    .   ",
                        ".PUZZLE.",
                        "    I   ",
                        "    P   ",
                        "    P   ",
                        "    E   ",
                        "    R   ",
                        "    .   "
                    },new List<string> {
                        "      .     ",
                        "      N     ",
                        "    .QUARTZ.",
                        "    H T     ",
                        ".SCRAPS.    ",
                        "    T .     ",
                        "    .       "
                    },new List<string> {
                        "  . .  ",
                        ".BRUSH.",
                        "  O C  ",
                        "  D R  ",
                        "  .HAT.",
                        "    P  ",
                        "    S  ",
                        "    .  "
                    },new List<string> {
                        "   .    ",
                        "   Q    ",
                        "   U  . ",
                        "   A  J ",
                        "  .ROPE.",
                        "   T  W ",
                        ".PUZZLE.",
                        "   .  L ",
                        "      . "
                    },new List<string> {
                        "       .    ",
                        "     .BRUSH.",
                        "     B O    ",
                        ".PLYWOOD.   ",
                        "     W .    ",
                        "     .      "
                    },new List<string> {
                        "   .   ",
                        "   P   ",
                        "   L.  ",
                        ".TOYS. ",
                        "  .WAX.",
                        " .BOW. ",
                        "   O.  ",
                        "   D   ",
                        "   .   "
                    },new List<string> {
                        " .    ",
                        " L    ",
                        " A    ",
                        ".TOYS.",
                        " H    ",
                        " .    "
                    },new List<string> {
                        "     . ",
                        ".TOOLS.",
                        "     H ",
                        "     A ",
                        "     P ",
                        "     E ",
                        "     . "
                    },new List<string> {
                        " .     ",
                        " P     ",
                        " A     ",
                        " I     ",
                        " N     ",
                        ".TOOLS.",
                        " .     "
                    },new List<string> {
                        "   .   ",
                        "   W   ",
                        ".TOOLS.",
                        "   O   ",
                        "   L   ",
                        "   .   "
                    },new List<string> {
                        "    . ",
                        "    A ",
                        "    W ",
                        ".WOOL.",
                        "    . "
                    },new List<string> {
                        "  .  ",
                        ".AWL.",
                        "  H  ",
                        "  E  ",
                        "  E  ",
                        "  L  ",
                        "  S  ",
                        "  .  "
                    },new List<string> {
                        "     .  ",
                        "   . C  ",
                        ".WHEELS.",
                        "   A O  ",
                        "  .SEW. ",
                        "   E N  ",
                        "   L .  ",
                        "   .    "
                    },new List<string> {
                        " .   ",
                        " C   ",
                        " L   ",
                        " O   ",
                        " W   ",
                        ".NET.",
                        " .   "
                    },new List<string> {
                        "   . ",
                        "   N ",
                        "   E ",
                        ".CUT.",
                        "   . "
                    },new List<string> {
                        "    .   ",
                        "    S   ",
                        ".ZIPPER.",
                        "    I   ",
                        "    N   ",
                        "    .   "
                    },new List<string> {
                        "      . ",
                        "      D ",
                        ".ZIPPER.",
                        "      A ",
                        "      W ",
                        "      . "
                    }
                };

                case 8908:

                    return new List<List<string>> {

                    new List<string> {
                        "    .   ",
                        " .SNOW. ",
                        "    L F ",
                        "    Y R ",
                        "    M E ",
                        "    P E ",
                        ".MORITZ.",
                        "    C E ",
                        "    S . ",
                        "    .   "
                    },new List<string> {
                        "    .    ",
                        "    R    ",
                        "    E .  ",
                        "   .SNOW.",
                        "    O L  ",
                        ".FLURRY. ",
                        "    T M  ",
                        "    . P  ",
                        "      I  ",
                        "      C  ",
                        "      S  ",
                        "      .  "
                    },new List<string> {
                        "    .      ",
                        "    L.     ",
                        " .SKIS.    ",
                        "   .FLURRY.",
                        ".WHITE.    ",
                        "    .D     ",
                        "     .     "
                    },new List<string> {
                        "    . ",
                        ".PASS.",
                        "    K ",
                        "    I ",
                        "    S ",
                        "    . "
                    },new List<string> {
                        "   .  ",
                        "   G  ",
                        "   L  ",
                        "   O  ",
                        "   V  ",
                        "   E  ",
                        ".PASS.",
                        "   .  "
                    },new List<string> {
                        "   . .  ",
                        "  .GEAR.",
                        "   L L  ",
                        "   O P  ",
                        ".DAVOS. ",
                        "   E .  ",
                        "   S    ",
                        "   .    "
                    },new List<string> {
                        " .   ",
                        ".WET.",
                        " H   ",
                        " I   ",
                        " T   ",
                        " E   ",
                        " .   "
                    },new List<string> {
                        "   . ",
                        "   Q ",
                        "   U ",
                        "   I ",
                        "   E ",
                        ".WET.",
                        "   . "
                    },new List<string> {
                        "    . ",
                        "    C ",
                        "    O ",
                        ".SNOW.",
                        "    . "
                    },new List<string> {
                        "  .    ",
                        "  L    ",
                        ".QUIET.",
                        "  G    ",
                        "  E    ",
                        "  .    "
                    },new List<string> {
                        "        . ",
                        "        F ",
                        "        R ",
                        "        O ",
                        ".OLYMPICS.",
                        "        T ",
                        "        . "
                    },new List<string> {
                        " .      ",
                        " P      ",
                        " O      ",
                        " W      ",
                        " D      ",
                        " E      ",
                        ".RESORT.",
                        " .      "
                    },new List<string> {
                        " .     ",
                        " W     ",
                        " H     ",
                        ".ITALY.",
                        " T     ",
                        " E     ",
                        " .     "
                    },new List<string> {
                        "     . ",
                        "     G ",
                        "     E ",
                        "     R ",
                        "     M ",
                        "     A ",
                        "     N ",
                        ".ITALY.",
                        "     . "
                    },new List<string> {
                        " .     ",
                        " C     ",
                        " O     ",
                        " L     ",
                        ".DAVOS.",
                        " .     "
                    },new List<string> {
                        " .   ",
                        " I   ",
                        ".COW.",
                        " E   ",
                        " .   "
                    }
                };

                case 8909:

                    return new List<List<string>> {

                    new List<string> {
                        "    .   ",
                        " .  P   ",
                        " A  A   ",
                        ".ZINNIA.",
                        " A  S   ",
                        ".LILY.  ",
                        " E  .   ",
                        " A      ",
                        " .      "
                    },new List<string> {
                        "    .   ",
                        " .POPPY.",
                        " A  A   ",
                        ".ZINNIA.",
                        " A  S   ",
                        " L  Y   ",
                        " E  .   ",
                        " A      ",
                        " .      "
                    },new List<string> {
                        "   . ",
                        "   P ",
                        "   O ",
                        "   P ",
                        "   P ",
                        ".MAY.",
                        "   . "
                    },new List<string> {
                        " .   ",
                        " M   ",
                        " I   ",
                        ".MAY.",
                        " O   ",
                        " S   ",
                        " A   ",
                        " .   "
                    },new List<string> {
                        "     .  ",
                        ".MIMOSA.",
                        "     A  ",
                        "     G  ",
                        "     E  ",
                        "     .  "
                    },new List<string> {
                        "      . ",
                        ".AZALEA.",
                        "      L ",
                        "      O ",
                        "      E ",
                        "      . "
                    },new List<string> {
                        " .     ",
                        " A     ",
                        " L     ",
                        ".OXLIP.",
                        " E     ",
                        " .     "
                    },new List<string> {
                        "     .   ",
                        "     L   ",
                        "   . U   ",
                        ".OXLIP.  ",
                        "   O I   ",
                        "  .TANSY.",
                        "   U .   ",
                        "   S     ",
                        "   .     "
                    },new List<string> {
                        "     .     ",
                        "     L     ",
                        "     O.    ",
                        "    .TANSY.",
                        ".CACTUS.   ",
                        "    .STOCK.",
                        "     .E    ",
                        "      R    ",
                        "      .    "
                    },new List<string> {
                        "   . . ",
                        ".TULIP.",
                        "   U E ",
                        "   P O ",
                        "   I N ",
                        ".TANSY.",
                        "   . . "
                    },new List<string> {
                        "   .     ",
                        "   B     ",
                        " .CACTUS.",
                        " I L     ",
                        ".ROSE.   ",
                        " I A     ",
                        " S M     ",
                        " . .     "
                    },new List<string> {
                        "       .  ",
                        "       B  ",
                        "     . A  ",
                        "     I L  ",
                        "    .ROSE.",
                        "     I A  ",
                        ".ALYSSUM. ",
                        "     . .  "
                    },new List<string> {
                        "     . ",
                        "     N ",
                        "     E ",
                        ".ASTER.",
                        "     I ",
                        "     N ",
                        "     E ",
                        "     . "
                    }
                };

                case 8910:

                    return new List<List<string>> {

                    new List<string> {
                        "  . .   ",
                        "  S U   ",
                        "  U N   ",
                        "  R I   ",
                        "  V O   ",
                        "  E N   ",
                        ".TYPIST.",
                        "  O S   ",
                        ".WRITER.",
                        "  . .   "
                    },new List<string> {
                        "    .       ",
                        "    U       ",
                        "    N .     ",
                        "    I P     ",
                        "    O.O     ",
                        "   .NURSE.  ",
                        ".TYPIST.    ",
                        "   .SHEARER.",
                        ".WRITER.    ",
                        "    .R.     ",
                        "     .      "
                    },new List<string> {
                        "  . .      ",
                        " .SCULPTOR.",
                        "  U N      ",
                        "  R I      ",
                        "  V O      ",
                        "  E N      ",
                        ".TYPIST.   ",
                        "  O S      ",
                        "  R T      ",
                        "  . .      "
                    },new List<string> {
                        " .      ",
                        ".PORTER.",
                        " I      ",
                        " L      ",
                        " O      ",
                        " T      ",
                        " .      "
                    },new List<string> {
                        "  .     ",
                        "  S     ",
                        "  H     ",
                        "  E     ",
                        "  A     ",
                        "  R     ",
                        "  E     ",
                        ".BREWER.",
                        "  .     "
                    },new List<string> {
                        "     . ",
                        "     B ",
                        "     R ",
                        "  .  E ",
                        " .CREW.",
                        "  R  E ",
                        ".VICAR.",
                        "  T  . ",
                        "  I    ",
                        "  C    ",
                        "  .    "
                    },new List<string> {
                        "     .    ",
                        "     C    ",
                        "    .R    ",
                        "   .VICAR.",
                        ".VALET.   ",
                        "   .TILER.",
                        "    .C    ",
                        "     .    "
                    },new List<string> {
                        "   .   ",
                        ".NAVVY.",
                        "   A   ",
                        "   L   ",
                        "   E   ",
                        "   T   ",
                        "   .   "
                    },new List<string> {
                        "     . ",
                        "     A ",
                        ".NAVVY.",
                        "     A ",
                        "     H ",
                        "     . "
                    },new List<string> {
                        " .     ",
                        " M     ",
                        " O     ",
                        ".NAVVY.",
                        " K     ",
                        " .     "
                    },new List<string> {
                        " .    ",
                        ".MONK.",
                        " A    ",
                        " I    ",
                        " D    ",
                        " .    "
                    },new List<string> {
                        "  .    ",
                        "  C    ",
                        "  R .  ",
                        ".VICAR.",
                        "  T G  ",
                        ".TILER.",
                        "  C N  ",
                        "  . T  ",
                        "    .  "
                    }
                };

                case 8911:

                    return new List<List<string>> {

                    new List<string> {
                        "  . .    ",
                        "  P F    ",
                        ".TRAINER.",
                        "  I E    ",
                        " .ZULU.  ",
                        "  E D    ",
                        "  . .    "
                    },new List<string> {
                        "        .     ",
                        "        C     ",
                        "        O     ",
                        "      . U     ",
                        "      G.R     ",
                        "    .HATS.    ",
                        "     .TUESDAY.",
                        ".TRAINER.     ",
                        "      .F      ",
                        "       .      "
                    },new List<string> {
                        "       . ",
                        "       M ",
                        "       O ",
                        "       N ",
                        "       E ",
                        ".TUESDAY.",
                        "       . "
                    },new List<string> {
                        "  . .   ",
                        "  T.W   ",
                        ".KIWI.  ",
                        " .MONEY.",
                        ".BETS.  ",
                        "  .A.   ",
                        "   N    ",
                        "   .    "
                    },new List<string> {
                        "    .    ",
                        ".TUESDAY.",
                        "    I    ",
                        "    L    ",
                        "    K    ",
                        "    S    ",
                        "    .    "
                    },new List<string> {
                        "     . ",
                        "     O ",
                        "     W ",
                        ".WOTAN.",
                        "     E ",
                        "     R ",
                        "     . "
                    },new List<string> {
                        "  .  ",
                        "  C  ",
                        "  O  ",
                        ".RUN.",
                        "  R  ",
                        "  S  ",
                        "  E  ",
                        "  .  "
                    },new List<string> {
                        "  .      ",
                        "  T .    ",
                        ".TUESDAY.",
                        "  R I    ",
                        " .FILLY. ",
                        "  . K    ",
                        "    S    ",
                        "    .    "
                    },new List<string> {
                        " .     ",
                        " S     ",
                        " I     ",
                        " L     ",
                        " K     ",
                        ".START.",
                        " .     "
                    },new List<string> {
                        "     . ",
                        "     C ",
                        "     O ",
                        "     L ",
                        ".START.",
                        "     . "
                    },new List<string> {
                        " .   ",
                        ".CUP.",
                        " O   ",
                        " L   ",
                        " T   ",
                        " .   "
                    },new List<string> {
                        " .    ",
                        " C    ",
                        " U    ",
                        ".POST.",
                        " .    "
                    },new List<string> {
                        " .      ",
                        " T      ",
                        " R      ",
                        " A      ",
                        ".COURSE.",
                        " K      ",
                        " .      "
                    },new List<string> {
                        " .   ",
                        ".TAB.",
                        " R   ",
                        " A   ",
                        " C   ",
                        " K   ",
                        " .   "
                    },new List<string> {
                        "  .  ",
                        "  M  ",
                        "  A  ",
                        "  L  ",
                        "  U  ",
                        ".TAB.",
                        "  .  "
                    },new List<string> {
                        "   .   ",
                        " . P   ",
                        ".MALUA.",
                        " A A   ",
                        ".RACE. ",
                        " E E   ",
                        " . .   "
                    }
                };

                case 8912:

                    return new List<List<string>> {

                    new List<string> {
                        "    .   ",
                        "    B   ",
                        ".HOLLY. ",
                        "    I C ",
                        "    T A ",
                        " .RAZOR.",
                        "    E D ",
                        "    N . ",
                        "    .   "
                    },new List<string> {
                        "   .      ",
                        "   H      ",
                        "   O      ",
                        "  .L      ",
                        " .BLITZEN.",
                        ".JOY.     ",
                        "  X.      ",
                        "  .       "
                    },new List<string> {
                        "        .   ",
                        "        B   ",
                        "        L   ",
                        "      . I   ",
                        "      I T   ",
                        "     .RAZOR.",
                        "      O E   ",
                        ".SEASONING. ",
                        "      . .   "
                    },new List<string> {
                        " .   . ",
                        ".BELLS.",
                        " E   E ",
                        " L   A ",
                        ".TOOLS.",
                        " .   O ",
                        "     N ",
                        "     I ",
                        "     N ",
                        "     G ",
                        "     . "
                    },new List<string> {
                        " .     ",
                        " W     ",
                        " A     ",
                        " T     ",
                        " C     ",
                        ".HOLLY.",
                        " .     "
                    },new List<string> {
                        "   .    ",
                        ".TOYS.  ",
                        "   U W  ",
                        "   L A  ",
                        ".SWEETS.",
                        "   . C  ",
                        "     H  ",
                        "     .  "
                    },new List<string> {
                        " . .    ",
                        ".TOYS.  ",
                        " I U    ",
                        " E L    ",
                        ".SWEETS.",
                        " . .    "
                    },new List<string> {
                        "  . .  ",
                        " .VASE.",
                        "  I O  ",
                        "  D C  ",
                        "  E K  ",
                        ".TOYS. ",
                        "  . .  "
                    },new List<string> {
                        "  .     ",
                        ".SWEETS.",
                        "  I     ",
                        "  N     ",
                        "  E     ",
                        "  .     "
                    },new List<string> {
                        " .     ",
                        ".WATCH.",
                        " A     ",
                        " L     ",
                        " L     ",
                        " E     ",
                        " T     ",
                        " .     "
                    },new List<string> {
                        "   .    ",
                        "   T    ",
                        "   I  . ",
                        "  .NUTS.",
                        "   S  A ",
                        "   E  N ",
                        ".WALLET.",
                        "   .  A ",
                        "      . "
                    },new List<string> {
                        " .      ",
                        ".TINSEL.",
                        " R      ",
                        " E      ",
                        " E      ",
                        " .      "
                    }
                };

                case 9001:

                    return new List<List<string>> {

                    new List<string> {
                        "   . . ",
                        "   L M ",
                        " .EYRE.",
                        "   O N ",
                        ".JANTZ.",
                        "   S I ",
                        "   . E ",
                        "     S ",
                        "     . "
                    },new List<string> {
                        "       . ",
                        "       F ",
                        "       I ",
                        ".MENZIES.",
                        "       K ",
                        "       . "
                    },new List<string> {
                        " .       ",
                        ".MENZIES.",
                        " A       ",
                        " W       ",
                        " S       ",
                        " O       ",
                        " N       ",
                        " .       "
                    },new List<string> {
                        " .     ",
                        " M     ",
                        " A     ",
                        " W     ",
                        " S     ",
                        ".OXLEY.",
                        " N     ",
                        " .     "
                    },new List<string> {
                        "     . ",
                        "     B ",
                        "     O ",
                        ".OXLEY.",
                        "     D ",
                        "     . "
                    },new List<string> {
                        "   .   ",
                        "   G   ",
                        "   O   ",
                        ".OXLEY.",
                        "   D   ",
                        "   .   "
                    },new List<string> {
                        " .    ",
                        ".FYSH.",
                        " I    ",
                        " S    ",
                        " K    ",
                        " .    "
                    },new List<string> {
                        "   .   ",
                        "   M   ",
                        "   U   ",
                        "   R   ",
                        ".DARK. ",
                        "   A C ",
                        " .FYSH.",
                        "   . I ",
                        "     F ",
                        "     L ",
                        "     E ",
                        "     Y ",
                        "     . "
                    },new List<string> {
                        "    . ",
                        "    C ",
                        "    H ",
                        "    I ",
                        "    F ",
                        "    L ",
                        "    E ",
                        ".QUAY.",
                        "    . "
                    },new List<string> {
                        "   .   ",
                        "   M   ",
                        ".STURT.",
                        "   R   ",
                        "   R   ",
                        "   A   ",
                        "   Y   ",
                        "   .   "
                    },new List<string> {
                        "   .   . ",
                        ".ROBERTS.",
                        "   A   M ",
                        "   S   I ",
                        "  .STURT.",
                        "   .   H ",
                        "       . "
                    },new List<string> {
                        "    . .     ",
                        "   .ROBERTS.",
                        "    E A     ",
                        ".SIRIUS.    ",
                        "    D S     ",
                        "    . .     "
                    },new List<string> {
                        " .      ",
                        " F      ",
                        " I      ",
                        ".SIRIUS.",
                        " H      ",
                        " E      ",
                        " R      ",
                        " .      "
                    },new List<string> {
                        "  .   ",
                        "  H   ",
                        ".QUAY.",
                        "  M   ",
                        "  E   ",
                        "  .   "
                    },new List<string> {
                        "    . ",
                        "    D ",
                        "    O ",
                        "    B ",
                        ".HUME.",
                        "    L ",
                        "    L ",
                        "    . "
                    }
                };

                case 9002:

                    return new List<List<string>> {

                    new List<string> {
                        " .  .   ",
                        ".AENEAS.",
                        " M  R   ",
                        " A  O   ",
                        ".ZEUS.  ",
                        " O  .   ",
                        " N      ",
                        " S      ",
                        " .      "
                    },new List<string> {
                        " .    ",
                        " A    ",
                        " E    ",
                        " N .  ",
                        ".EROS.",
                        " A L  ",
                        ".STYX.",
                        " . M  ",
                        "   P  ",
                        "   U  ",
                        "   S  ",
                        "   .  "
                    },new List<string> {
                        "       . .    ",
                        "       J M    ",
                        "      .A E    ",
                        ".OLYMPUS.D    ",
                        "     .ROMULUS.",
                        "    .JANUS.   ",
                        "      N.SATYR.",
                        "      U E.    ",
                        "      S S     ",
                        "      . .     "
                    },new List<string> {
                        "     .   ",
                        "     U   ",
                        "     R   ",
                        "  .  A   ",
                        "  R..N   ",
                        ".NEPTUNE.",
                        " .MARS.  ",
                        ".JUNO.   ",
                        "  S.Y    ",
                        "  . .    "
                    },new List<string> {
                        "    .    ",
                        "    M    ",
                        "    E    ",
                        "    D .  ",
                        ".ROMULUS.",
                        "    S L  ",
                        "  .SATYR.",
                        "    . S  ",
                        "      S  ",
                        "      E  ",
                        "      S  ",
                        "      .  "
                    },new List<string> {
                        "       . ",
                        "       E ",
                        "       R ",
                        "       I ",
                        ".ROMULUS.",
                        "       . "
                    },new List<string> {
                        "       . ",
                        "       C ",
                        "       H ",
                        "       A ",
                        "       O ",
                        ".ULYSSES.",
                        "       . "
                    },new List<string> {
                        "      .  ",
                        ".AMAZONS.",
                        "      I  ",
                        "      K  ",
                        "      E  ",
                        "      .  "
                    },new List<string> {
                        "   .  ",
                        ".NIKE.",
                        "   A  ",
                        "   M  ",
                        "   A  ",
                        "   .  "
                    }
                };

                case 9003:

                    return new List<List<string>> {

                    new List<string> {
                        "       . ",
                        "    .  S ",
                        "    B  Y ",
                        "    R  D ",
                        "   .EDEN.",
                        "    E  E ",
                        ".FITZROY.",
                        "    A  . ",
                        "    .    "
                    },new List<string> {
                        "  .      ",
                        "  B      ",
                        "  U      ",
                        "  N .    ",
                        " .BREEZA.",
                        "  U D    ",
                        "  R E    ",
                        ".SYDNEY. ",
                        "  . .    "
                    },new List<string> {
                        "  .      ",
                        "  Q .    ",
                        ".BUNBURY.",
                        "  I R    ",
                        "  L E    ",
                        "  P E    ",
                        ".FITZROY.",
                        "  E A    ",
                        "  . .    "
                    },new List<string> {
                        "      .  ",
                        ".FITZROY.",
                        "      U  ",
                        "      Y  ",
                        "      E  ",
                        "      N  ",
                        "      .  "
                    },new List<string> {
                        "  .  ",
                        "  O  ",
                        "  U  ",
                        ".AYR.",
                        "  E  ",
                        "  N  ",
                        "  .  "
                    },new List<string> {
                        "    .  ",
                        "    O  ",
                        "    U  ",
                        "    Y  ",
                        "    E  ",
                        ".YOUNG.",
                        "    .  "
                    },new List<string> {
                        " .     ",
                        " H     ",
                        " A     ",
                        ".YOUNG.",
                        " .     "
                    },new List<string> {
                        "    .    ",
                        "    N    ",
                        "    H    ",
                        "    I    ",
                        "    L    ",
                        ".QUILPIE.",
                        "    .    "
                    },new List<string> {
                        "    .  ",
                        ".LORNE.",
                        "    H  ",
                        "    I  ",
                        "    L  ",
                        "    L  ",
                        "    .  "
                    },new List<string> {
                        "   .   ",
                        "   E . ",
                        ".TEXAS.",
                        "   E C ",
                        "   T O ",
                        "   E N ",
                        ".LORNE.",
                        "   . . "
                    },new List<string> {
                        " . .   ",
                        " S E   ",
                        ".TEXAS.",
                        " A E   ",
                        " W T   ",
                        " E E   ",
                        ".LORNE.",
                        " L .   ",
                        " .     "
                    },new List<string> {
                        "    .    ",
                        ".SCONE.  ",
                        "    O B  ",
                        "   .WYEE.",
                        "    R G  ",
                        "    A A  ",
                        "    . .  "
                    },new List<string> {
                        "   .     ",
                        "   B     ",
                        ".WYEE.   ",
                        "   G M   ",
                        "  .AVOCA.",
                        "   . E   ",
                        "     .   "
                    },new List<string> {
                        "  .    ",
                        ".SCONE.",
                        "  A    ",
                        "  I    ",
                        "  R    ",
                        "  N    ",
                        "  S    ",
                        "  .    "
                    },new List<string> {
                        "   .  ",
                        " . C  ",
                        " T A  ",
                        ".UKI. ",
                        " L R  ",
                        " L N  ",
                        ".YASS.",
                        " . .  "
                    }
                };

                case 9004:

                    return new List<List<string>> {

                    new List<string> {
                        " .    ",
                        " Q    ",
                        " U    ",
                        " A    ",
                        " R    ",
                        " T    ",
                        ".ZINC.",
                        " .    "
                    },new List<string> {
                        "    .   ",
                        "    P   ",
                        " .  O   ",
                        ".QUARTZ.",
                        " U  P   ",
                        " A  H   ",
                        ".RUBY.  ",
                        " R  R   ",
                        " Y  Y   ",
                        " .  .   "
                    },new List<string> {
                        "        . ",
                        "        P ",
                        ".PORPHYRY.",
                        "        R ",
                        "        I ",
                        "        T ",
                        "        E ",
                        "        S ",
                        "        . "
                    },new List<string> {
                        "      . ",
                        "      C ",
                        "      L ",
                        "      A ",
                        ".QUARRY.",
                        "      . "
                    },new List<string> {
                        "      .     ",
                        "      G     ",
                        "      Y     ",
                        "      P     ",
                        "     .S     ",
                        "    .QUARTZ.",
                        ".RADIUM.    ",
                        "     A.     ",
                        "     R      ",
                        "     R      ",
                        "     Y      ",
                        "     .      "
                    },new List<string> {
                        " . .     ",
                        " R G     ",
                        ".ONYX.   ",
                        " C P     ",
                        " K S     ",
                        " .QUARTZ.",
                        "   M     ",
                        "   .     "
                    },new List<string> {
                        "     .    ",
                        "     R    ",
                        "     E.   ",
                        ".SILVER.  ",
                        "    .FACE.",
                        "     .D   ",
                        "      I   ",
                        "      U   ",
                        "      M   ",
                        "      .   "
                    },new List<string> {
                        " . .    ",
                        ".JET.   ",
                        " A A    ",
                        ".SILVER.",
                        " P C    ",
                        " E .    ",
                        " R      ",
                        " .      "
                    },new List<string> {
                        " .        ",
                        ".PORPHYRY.",
                        " E        ",
                        " W        ",
                        " T        ",
                        " E        ",
                        " R        ",
                        " .        "
                    },new List<string> {
                        "    . . ",
                        " .TOPAZ.",
                        "    I I ",
                        ".PEWTER.",
                        "    . C ",
                        "      O ",
                        "      N ",
                        "      . "
                    },new List<string> {
                        "      . ",
                        "      I ",
                        "      R ",
                        "      O ",
                        ".ZIRCON.",
                        "      . "
                    },new List<string> {
                        "   .  ",
                        ".IRON.",
                        "   C  ",
                        "   H  ",
                        "   R  ",
                        "   E  ",
                        "   .  "
                    },new List<string> {
                        "    .  ",
                        "    F  ",
                        "    A  ",
                        "    C  ",
                        ".STEEL.",
                        "    .  "
                    },new List<string> {
                        " .   ",
                        " S   ",
                        ".TIN.",
                        " E   ",
                        " E   ",
                        " L   ",
                        " .   "
                    }
                };

                case 9005:

                    return new List<List<string>> {

                    new List<string> {
                        "   .     ",
                        "   B .   ",
                        "   I J   ",
                        ".MEZZO.  ",
                        "   E A   ",
                        "  .TENOR.",
                        "   . .   "
                    },new List<string> {
                        "     .    ",
                        "    .T    ",
                        ".TENOR.   ",
                        "   .PINZA.",
                        "  .DUO.   ",
                        "    S.    ",
                        "    .     "
                    },new List<string> {
                        "   .    ",
                        " . P    ",
                        ".TRIO.  ",
                        " E N    ",
                        ".MOZART.",
                        " P A    ",
                        " O .    ",
                        " .      "
                    },new List<string> {
                        "   .     ",
                        "   P  .  ",
                        "   I  B  ",
                        "   N  A  ",
                        ".MOZART. ",
                        "   A  O  ",
                        "   .LIND.",
                        "      .  "
                    },new List<string> {
                        "    .   ",
                        "    C   ",
                        "    H   ",
                        "    O   ",
                        "   .R   ",
                        "  .DUET.",
                        ".OPUS.  ",
                        "   O.   ",
                        "   .    "
                    },new List<string> {
                        "   . .  ",
                        "   S D  ",
                        ".CHORUS.",
                        "   L E  ",
                        " .FORTE.",
                        "   . .  "
                    },new List<string> {
                        "  . .  ",
                        "  R T  ",
                        ".TUNE. ",
                        "  F M  ",
                        "  F P  ",
                        " .OBOE.",
                        "  . .  "
                    },new List<string> {
                        " .      ",
                        " D      ",
                        " A      ",
                        " N      ",
                        ".CHORUS.",
                        " E      ",
                        " .      "
                    },new List<string> {
                        "     . ",
                        "     D ",
                        "  .  A ",
                        ".HAYDN.",
                        "  L  C ",
                        ".STAGE.",
                        "  O  . ",
                        "  .    "
                    },new List<string> {
                        "       . ",
                        "       H ",
                        "       A ",
                        ".SCENERY.",
                        "       D ",
                        "       N ",
                        "       . "
                    },new List<string> {
                        " .  .    ",
                        ".BASSO.  ",
                        " A  O    ",
                        ".SCENERY.",
                        " S  G    ",
                        " .  .    "
                    }
                };

                case 9006:

                    return new List<List<string>> {

                    new List<string> {
                        "      .  ",
                        "      W  ",
                        "    . H  ",
                        "    S A  ",
                        "    A.L  ",
                        ".BRONZE. ",
                        "   .DART.",
                        "    .N.  ",
                        "     D   ",
                        "     E   ",
                        "     R   ",
                        "     .   "
                    },new List<string> {
                        "        .     ",
                        "        D     ",
                        "       .O     ",
                        "      .BRONZE.",
                        ".STINGRAY.    ",
                        "       S.     ",
                        "       S      ",
                        "       .      "
                    },new List<string> {
                        "  .     ",
                        "  D   . ",
                        ".ZANDER.",
                        "  R   A ",
                        " .TUNNY.",
                        "  .   . "
                    },new List<string> {
                        "       .     ",
                        "       B     ",
                        ".STINGRAY.   ",
                        "       S T   ",
                        "      .SQUID.",
                        "       . N   ",
                        "         A   ",
                        "         .   "
                    },new List<string> {
                        "       . ",
                        "       M ",
                        "   .   A ",
                        "   S   N ",
                        "  .TROUT.",
                        "   I   A ",
                        ".BONITO. ",
                        "   G     ",
                        "   R     ",
                        "   A     ",
                        "   Y     ",
                        "   .     "
                    },new List<string> {
                        "     .   ",
                        "     E   ",
                        "   . X   ",
                        "   S P   ",
                        "  .TROUT.",
                        "   I R   ",
                        ".BONITO. ",
                        "   G .   ",
                        "   R     ",
                        "   A     ",
                        "   Y     ",
                        "   .     "
                    },new List<string> {
                        "      .  ",
                        "      W  ",
                        "    . H  ",
                        "   .SEAL.",
                        "    A L  ",
                        ".BRONZE. ",
                        "    D R  ",
                        "    . .  "
                    },new List<string> {
                        "      . ",
                        ".MINNOW.",
                        "      H ",
                        "      A ",
                        "      L ",
                        "      E ",
                        "      R ",
                        "      . "
                    },new List<string> {
                        "   . . ",
                        ".BREAM.",
                        "   X A ",
                        "   P N ",
                        ".TROUT.",
                        "   R A ",
                        "   T . ",
                        "   .   "
                    },new List<string> {
                        " .        ",
                        " N        ",
                        " E        ",
                        " T        ",
                        ".STINGRAY.",
                        " .        "
                    },new List<string> {
                        " .    ",
                        " L    ",
                        " I    ",
                        ".NETS.",
                        " E    ",
                        " .    "
                    },new List<string> {
                        " . .  ",
                        ".SOLE.",
                        " H I  ",
                        " A N  ",
                        ".ROE. ",
                        " K .  ",
                        " .    "
                    },new List<string> {
                        " .   ",
                        ".BOX.",
                        " O   ",
                        " N   ",
                        " I   ",
                        " T   ",
                        " O   ",
                        " .   "
                    },new List<string> {
                        "   . ",
                        "   L ",
                        "   A ",
                        ".BOX.",
                        "   . "
                    },new List<string> {
                        " .   ",
                        " E   ",
                        " E   ",
                        ".LAX.",
                        " .   "
                    },new List<string> {
                        "    . ",
                        "    O ",
                        "    R ",
                        "    C ",
                        ".TUNA.",
                        "    . "
                    }
                };

                case 9007:

                    return new List<List<string>> {

                    new List<string> {
                        "    . . ",
                        "  .JAZZ.",
                        "    D O ",
                        "    A N ",
                        "    M E ",
                        ".KANSAS.",
                        "    . . "
                    },new List<string> {
                        "   .      ",
                        "   A      ",
                        "   R .    ",
                        "  .KANSAS.",
                        "   A I    ",
                        "   N X    ",
                        "   S O    ",
                        ".TWAIN.   ",
                        "   S .    ",
                        "   .      "
                    },new List<string> {
                        "     .   ",
                        "   . A   ",
                        "   L R   ",
                        "   I K   ",
                        "   B A   ",
                        "   E N   ",
                        "   R.S   ",
                        "  .TWAIN.",
                        ".HAYES.  ",
                        "   .B.   ",
                        "    S    ",
                        "    T    ",
                        "    E    ",
                        "    R    ",
                        "    .    "
                    },new List<string> {
                        "    .   ",
                        ".NIXON. ",
                        "    H L ",
                        "    I E ",
                        "  .HOWE.",
                        "    . . "
                    },new List<string> {
                        "     . ",
                        "   . A ",
                        ".TYLER.",
                        "   I K ",
                        "   B A ",
                        "   E N ",
                        "   R S ",
                        "   T A ",
                        ".HAYES.",
                        "   . . "
                    },new List<string> {
                        "  . .       ",
                        "  B T       ",
                        ".JULY.      ",
                        "  S L       ",
                        "  H E       ",
                        "  .ARKANSAS.",
                        "    .       "
                    },new List<string> {
                        " .     ",
                        ".TYLER.",
                        " E     ",
                        " X     ",
                        " A     ",
                        " S     ",
                        " .     "
                    },new List<string> {
                        "    .    ",
                        ".WEBSTER.",
                        "    E    ",
                        "    Q    ",
                        "    U    ",
                        "    O    ",
                        "    I    ",
                        "    A    ",
                        "    .    "
                    },new List<string> {
                        "    .    ",
                        "    Q .  ",
                        ".SEQUOIA.",
                        "    O O  ",
                        "  .STOWE.",
                        "    A A  ",
                        "    . .  "
                    },new List<string> {
                        "    . ",
                        "    W ",
                        "    E ",
                        "    B ",
                        "    S ",
                        ".TAFT.",
                        "    E ",
                        "    R ",
                        "    . "
                    },new List<string> {
                        "  .   ",
                        ".UTAH.",
                        "  A   ",
                        "  F   ",
                        "  T   ",
                        "  .   "
                    }
                };

                case 9008:

                    return new List<List<string>> {

                    new List<string> {
                        "     .    ",
                        "     E    ",
                        "     U    ",
                        "    .C    ",
                        "   .YACCA.",
                        ".CORAL.   ",
                        "   .MYALL.",
                        "    .P    ",
                        "     T    ",
                        "     U    ",
                        "     S    ",
                        "     .    "
                    },new List<string> {
                        "    .         ",
                        "    Q         ",
                        "  .EUCALYPTUS.",
                        "  G E         ",
                        ".HUON.        ",
                        "  M A         ",
                        "  . .         "
                    },new List<string> {
                        "    .    ",
                        "    B    ",
                        "    U    ",
                        "    T .  ",
                        "    T Y  ",
                        "  .CORAL.",
                        "    N M  ",
                        ".SASSY.  ",
                        "    .    "
                    },new List<string> {
                        "   . .    ",
                        ".SASSY.   ",
                        "   I A    ",
                        "   M L    ",
                        ".SALTBUSH.",
                        "   A A    ",
                        "   X H    ",
                        "   . .    "
                    },new List<string> {
                        " .        ",
                        " H        ",
                        " I        ",
                        " B        ",
                        " I .      ",
                        ".SASSY.   ",
                        " C I      ",
                        " U M      ",
                        ".SALTBUSH.",
                        " . A      ",
                        "   X      ",
                        "   .      "
                    },new List<string> {
                        "   . ",
                        "   S ",
                        "   I ",
                        "   M ",
                        "   L ",
                        "   A ",
                        ".WAX.",
                        "   . "
                    },new List<string> {
                        "    .  ",
                        "    B  ",
                        " .  U  ",
                        ".HEATH.",
                        " I  T  ",
                        " B  O  ",
                        " I  N  ",
                        ".SASSY.",
                        " C  .  ",
                        " U     ",
                        " S     ",
                        " .     "
                    },new List<string> {
                        "     .    ",
                        "     Y    ",
                        "     A    ",
                        "     L  . ",
                        ".SALTBUSH.",
                        "     A  O ",
                        "    .HOOP.",
                        "     .  . "
                    },new List<string> {
                        "    . .     ",
                        "    Y M     ",
                        ".EUCALYPTUS.",
                        "    C A     ",
                        "   .COLANE. ",
                        "    A L     ",
                        "    . .     "
                    },new List<string> {
                        "  .  ",
                        ".HOP.",
                        "  A  ",
                        "  K  ",
                        "  .  "
                    },new List<string> {
                        "      . ",
                        "      H ",
                        ".MYRTLE.",
                        "      A ",
                        "      T ",
                        "      H ",
                        "      . "
                    },new List<string> {
                        "  .      ",
                        "  M      ",
                        ".CYPRESS.",
                        "  R      ",
                        "  T      ",
                        "  L      ",
                        "  E      ",
                        "  .      "
                    },new List<string> {
                        "      .  ",
                        "      A  ",
                        ".CYPRESS.",
                        "      H  ",
                        "      .  "
                    }
                };

                case 9009:

                    return new List<List<string>> {

                    new List<string> {
                        "    . . ",
                        ".ZIGZAG.",
                        "    O U ",
                        "    N L ",
                        "  .REEF.",
                        "    . . "
                    },new List<string> {
                        " .      ",
                        ".ZIGZAG.",
                        " E      ",
                        " N      ",
                        " I      ",
                        " T      ",
                        " H      ",
                        " .      "
                    },new List<string> {
                        "     ..      ",
                        "    .WIND.   ",
                        ".CABLES.     ",
                        "    .STREETS.",
                        ".ZENITH.     ",
                        "     .M      ",
                        "      U      ",
                        "      S      ",
                        "      .      "
                    },new List<string> {
                        "     . .   ",
                        ".ISTHMUS.  ",
                        "     E E   ",
                        "  .ESTUARY.",
                        "     R .   ",
                        "     E     ",
                        "     S     ",
                        "     .     "
                    },new List<string> {
                        "       . ",
                        "       B ",
                        "       A ",
                        ".ESTUARY.",
                        "       . "
                    },new List<string> {
                        "     .     ",
                        "     M     ",
                        "     E     ",
                        "     T     ",
                        "     R.    ",
                        ".CITIES.   ",
                        "    .SOUTH.",
                        "     .I    ",
                        "      L    ",
                        "      .    "
                    },new List<string> {
                        "   .     ",
                        "   M     ",
                        "   E  .  ",
                        ".ESTUARY.",
                        "   R  O  ",
                        "   E  U  ",
                        "  .SOUTH.",
                        "   .  E  ",
                        "      S  ",
                        "      .  "
                    },new List<string> {
                        "     .  ",
                        "     R  ",
                        "   . O  ",
                        "   S U  ",
                        " .SOUTH.",
                        "   I E  ",
                        ".ATLAS. ",
                        "   . .  "
                    },new List<string> {
                        " . .   ",
                        " A C   ",
                        ".SPACE.",
                        " I B   ",
                        " A L   ",
                        " .WEST.",
                        "   S   ",
                        "   .   "
                    },new List<string> {
                        "  .   ",
                        ".EAST.",
                        "  T   ",
                        "  L   ",
                        "  A   ",
                        "  S   ",
                        "  .   "
                    },new List<string> {
                        "   .  ",
                        "   T  ",
                        "   R  ",
                        "   E  ",
                        "   E  ",
                        ".EAST.",
                        "   .  "
                    },new List<string> {
                        "    . ",
                        ".EAST.",
                        "    R ",
                        "    O ",
                        "    P ",
                        "    I ",
                        "    C ",
                        "    . "
                    },new List<string> {
                        "    .  ",
                        ".PORTS.",
                        "    R  ",
                        "    E  ",
                        "    E  ",
                        "    S  ",
                        "    .  "
                    },new List<string> {
                        "   .   ",
                        "   A   ",
                        "   R   ",
                        ".TREES.",
                        "   A   ",
                        "   .   "
                    }
                };

                case 9010:

                    return new List<List<string>> {

                    new List<string> {
                        "  .    ",
                        "  D .  ",
                        ".TRICK.",
                        "  A R  ",
                        "  M A  ",
                        ".JAZZ. ",
                        "  . Y  ",
                        "    .  "
                    },new List<string> {
                        "    . ",
                        "    T ",
                        "    R ",
                        "    I ",
                        "    C ",
                        ".MASK.",
                        "    . "
                    },new List<string> {
                        "     .  ",
                        "     A  ",
                        "     U  ",
                        "  ...T  ",
                        ".SMASH. ",
                        " .ACTOR.",
                        " .STAR. ",
                        "  K.G.  ",
                        "  . E   ",
                        "    .   "
                    },new List<string> {
                        "  .       ",
                        "  A  .    ",
                        "  C  D    ",
                        ".STAGE.   ",
                        "  O  B    ",
                        "  R  U    ",
                        "  .MOTLEY.",
                        "     .    "
                    },new List<string> {
                        "   .    ",
                        "   D  . ",
                        "   E  P ",
                        "  .BILL.",
                        "   U  A ",
                        ".MOTLEY.",
                        "   .  . "
                    },new List<string> {
                        "       .  ",
                        "       A  ",
                        "   .   C  ",
                        "   C   T  ",
                        "  .AUTHOR.",
                        "   S   R  ",
                        ".SATIRE.  ",
                        "   .      "
                    },new List<string> {
                        "   .    ",
                        "   M    ",
                        "   A  . ",
                        ".TIGHTS.",
                        "   I  A ",
                        "  .CAST.",
                        "   .  I ",
                        "      R ",
                        "      E ",
                        "      . "
                    },new List<string> {
                        "     .  ",
                        "     P  ",
                        "     I  ",
                        ".TIGHTS.",
                        "     .  "
                    },new List<string> {
                        " .      ",
                        " H      ",
                        " I      ",
                        ".TIGHTS.",
                        " .      "
                    },new List<string> {
                        "     . ",
                        ".WINGS.",
                        "     M ",
                        "     A ",
                        "     S ",
                        "     H ",
                        "     . "
                    },new List<string> {
                        "   .   ",
                        "  .B.  ",
                        ".SHOW. ",
                        " .EXIT.",
                        "  R.N  ",
                        "  O G  ",
                        "  . S  ",
                        "    .  "
                    },new List<string> {
                        "  . . ",
                        ".SHOW.",
                        "  E I ",
                        "  R N ",
                        ".SONG.",
                        "  . S ",
                        "    . "
                    },new List<string> {
                        " .   ",
                        ".SET.",
                        " O   ",
                        " N   ",
                        " G   ",
                        " .   "
                    },new List<string> {
                        " .    ",
                        " G    ",
                        " O    ",
                        " D    ",
                        ".SHOW.",
                        " .    "
                    },new List<string> {
                        " .    ",
                        ".GODS.",
                        " A    ",
                        " G    ",
                        " .    "
                    }
                };

                case 9011:

                    return new List<List<string>> {

                    new List<string> {
                        "  .     ",
                        "  N     ",
                        "  A .   ",
                        ".BRAZIL.",
                        "  I I   ",
                        " .TIME. ",
                        "  A B   ",
                        "  . A   ",
                        "    B   ",
                        "    W   ",
                        "    E   ",
                        "    .   "
                    },new List<string> {
                        "   .      ",
                        "   T .    ",
                        "   I W    ",
                        ".ZIMBABWE.",
                        "   E L    ",
                        "   .TEA.  ",
                        "     S    ",
                        "     .    "
                    },new List<string> {
                        "     .   ",
                        "     C   ",
                        "    .L   ",
                        "   .TAXI.",
                        ".WALES.  ",
                        "   .ASIA.",
                        "    ..   "
                    },new List<string> {
                        "   . .   ",
                        "   T A   ",
                        ".CLASS.  ",
                        "   X I   ",
                        "  .ITALY.",
                        "   . .   "
                    },new List<string> {
                        "    . ",
                        "    I ",
                        "    T ",
                        "    A ",
                        "    L ",
                        ".ORLY.",
                        "    . "
                    },new List<string> {
                        "       .  ",
                        "       V  ",
                        "       I  ",
                        "       E  ",
                        ".ZIMBABWE.",
                        "       .  "
                    },new List<string> {
                        " .      ",
                        " I      ",
                        ".TURKEY.",
                        " A      ",
                        " L      ",
                        " Y      ",
                        " .      "
                    },new List<string> {
                        "   .  .  ",
                        "   P  O  ",
                        "   A  X  ",
                        ".TURKEY. ",
                        "   I  G  ",
                        "  .SLEEP.",
                        "   .  N  ",
                        "      .  "
                    },new List<string> {
                        "   .  .  ",
                        "  .PILOT.",
                        "   A  X  ",
                        ".TURKEY. ",
                        "   I  G  ",
                        "   S  E  ",
                        "   .  N  ",
                        "      .  "
                    },new List<string> {
                        "   .   ",
                        "   S . ",
                        "   A P ",
                        "   F I ",
                        " .MEAL.",
                        "   T O ",
                        ".EGYPT.",
                        "   . . "
                    },new List<string> {
                        "    .      ",
                        ".TRAVEL.   ",
                        "    I  M   ",
                        "   .SAFETY.",
                        "    A  A   ",
                        "    .  L   ",
                        "       .   "
                    },new List<string> {
                        " .   ",
                        " T   ",
                        ".RUG.",
                        " A   ",
                        " V   ",
                        " E   ",
                        " L   ",
                        " .   "
                    },new List<string> {
                        " .      ",
                        " I      ",
                        ".NARITA.",
                        " D      ",
                        " I      ",
                        " A      ",
                        " .      "
                    },new List<string> {
                        "  .   ",
                        "  F   ",
                        ".VIEW.",
                        "  N   ",
                        "  .   "
                    }
                };

                case 9012:

                    return new List<List<string>> {

                    new List<string> {
                        "     .  ",
                        "     M  ",
                        "   . A  ",
                        ".FUTURE.",
                        "   U L  ",
                        "   R E  ",
                        ".MONEY. ",
                        "   E .  ",
                        "   R    ",
                        "   .    "
                    },new List<string> {
                        " . .    ",
                        ".FUTURE.",
                        " I U    ",
                        " R R    ",
                        ".MONEY. ",
                        " . E    ",
                        "   R    ",
                        "   .    "
                    },new List<string> {
                        " .      ",
                        " D      ",
                        " R      ",
                        " E      ",
                        " A      ",
                        ".MARLEY.",
                        " .      "
                    },new List<string> {
                        "  .     ",
                        "  T     ",
                        "  U     ",
                        "  R     ",
                        "  N     ",
                        "  E     ",
                        ".FROSTY.",
                        "  .     "
                    },new List<string> {
                        "      . ",
                        "      H ",
                        "      A ",
                        "      P ",
                        "      P ",
                        ".FROSTY.",
                        "      . "
                    },new List<string> {
                        "  . .   ",
                        " .HAPPY.",
                        "  O A   ",
                        ".BLESS. ",
                        "  L T   ",
                        "  Y .   ",
                        "  .     "
                    },new List<string> {
                        "    .    ",
                        "    H    ",
                        "    O    ",
                        "  .BLESS.",
                        "  W L    ",
                        ".TINY.   ",
                        "  N .    ",
                        "  T      ",
                        "  E      ",
                        "  R      ",
                        "  .      "
                    },new List<string> {
                        "  .    ",
                        "  S    ",
                        "  L    ",
                        "  E.   ",
                        ".NEW.  ",
                        " .TINY.",
                        "  .N   ",
                        "   T   ",
                        "   E   ",
                        "   R   ",
                        "   .   "
                    },new List<string> {
                        "    .  ",
                        " .  W  ",
                        " F  I  ",
                        " O  N  ",
                        ".GRATE.",
                        " G  E  ",
                        ".YEAR. ",
                        " .  .  "
                    },new List<string> {
                        "   .      ",
                        "   B      ",
                        "   L      ",
                        "   E.     ",
                        ".PAST.    ",
                        "  .SILVER.",
                        "   .M     ",
                        "    .     "
                    },new List<string> {
                        "      .  ",
                        "      P  ",
                        "    .BOB.",
                        "    E O  ",
                        ".SILVER. ",
                        "    E .  ",
                        "    .    "
                    },new List<string> {
                        "    .    ",
                        ".GHOST.  ",
                        "    O N  ",
                        "  .SLEET.",
                        "    E W  ",
                        "    . .  "
                    },new List<string> {
                        "   . ",
                        "   D ",
                        "   R ",
                        ".JOE.",
                        "   A ",
                        "   M ",
                        "   . "
                    }
                };

                case 9101:

                    return new List<List<string>> {

                    new List<string> {
                        "   . . ",
                        "   Q P ",
                        "   U A ",
                        "  .I.R ",
                        " .REST.",
                        ".JETTY.",
                        "  L.O. ",
                        "  A V  ",
                        "  X E  ",
                        "  . .  "
                    },new List<string> {
                        " .      ",
                        " S      ",
                        " L      ",
                        " E .    ",
                        ".EASE.  ",
                        " P C    ",
                        " .QUIET.",
                        "   B    ",
                        "   A    ",
                        "   .    "
                    },new List<string> {
                        " .     ",
                        ".SPORT.",
                        " L     ",
                        " E     ",
                        " E     ",
                        " P     ",
                        " .     "
                    },new List<string> {
                        "    .    ",
                        "    O    ",
                        "    A.   ",
                        ".SPORT.  ",
                        "   .SAND.",
                        "    .N   ",
                        "     .   "
                    },new List<string> {
                        "  .     ",
                        ".FOREST.",
                        "  A     ",
                        "  R     ",
                        "  S     ",
                        "  .     "
                    },new List<string> {
                        "     .  ",
                        ".FOREST.",
                        "     P  ",
                        "     A  ",
                        "     D  ",
                        "     E  ",
                        "     .  "
                    },new List<string> {
                        " .         ",
                        " S         ",
                        " P         ",
                        ".AMUSEMENT.",
                        " D         ",
                        " E         ",
                        " .         "
                    },new List<string> {
                        "    .      ",
                        "   .C.     ",
                        "  .BAT.    ",
                        ".AMUSEMENT.",
                        "  .SUN.    ",
                        "  .HAT.    ",
                        "   .L.     ",
                        "    .      "
                    },new List<string> {
                        " .      ",
                        " A      ",
                        " M      ",
                        " U      ",
                        " S      ",
                        " E      ",
                        " M      ",
                        " E      ",
                        " N      ",
                        ".TENNIS.",
                        " .      "
                    },new List<string> {
                        "      .   ",
                        "      D   ",
                        "    .QUAY.",
                        "    F N   ",
                        "    U E   ",
                        ".TENNIS.  ",
                        "    . .   "
                    },new List<string> {
                        "    . ",
                        "    F ",
                        "    L ",
                        ".QUAY.",
                        "    I ",
                        "    N ",
                        "    G ",
                        "    . "
                    },new List<string> {
                        "       .   ",
                        "       R   ",
                        "       E   ",
                        ".AMUSEMENT.",
                        "       F   ",
                        "       .   "
                    },new List<string> {
                        " .   ",
                        ".ROD.",
                        " E   ",
                        " E   ",
                        " F   ",
                        " .   "
                    }
                };

                case 9102:

                    return new List<List<string>> {

                    new List<string> {
                        "    .    ",
                        "    L    ",
                        "   .A    ",
                        "  .SPEED.",
                        " .DOT.   ",
                        ".CANON.  ",
                        " .TYPE.  ",
                        "  A..C   ",
                        "  .  .   "
                    },new List<string> {
                        " .      ",
                        " S      ",
                        " C      ",
                        " R      ",
                        " O      ",
                        ".LAPTOP.",
                        " L      ",
                        " .      "
                    },new List<string> {
                        "  . .  ",
                        "  F S  ",
                        ".PITCH.",
                        "  L R  ",
                        ".ZERO. ",
                        "  . L  ",
                        "    L  ",
                        "    .  "
                    },new List<string> {
                        " .    ",
                        ".ZERO.",
                        " E    ",
                        " N    ",
                        " I    ",
                        " T    ",
                        " H    ",
                        " .    "
                    },new List<string> {
                        "     .  ",
                        ".ZENITH.",
                        "     A  ",
                        "     P  ",
                        "     E  ",
                        "     .  "
                    },new List<string> {
                        "  .    ",
                        "  T    ",
                        "  A    ",
                        ".EPSON.",
                        "  E    ",
                        "  .    "
                    },new List<string> {
                        "   .  ",
                        "   E  ",
                        "   P  ",
                        "   S  ",
                        "   O  ",
                        ".MENU.",
                        "   .  "
                    },new List<string> {
                        " . .   ",
                        ".MOUSE.",
                        " E N   ",
                        " N I   ",
                        " U S   ",
                        " .WYSE.",
                        "   S   ",
                        "   .   "
                    },new List<string> {
                        "   .   ",
                        "   U   ",
                        "   N   ",
                        "   I   ",
                        "  .S.  ",
                        " .WYSE.",
                        ".DISC. ",
                        "  N.R  ",
                        "  D E  ",
                        "  O E  ",
                        "  W N  ",
                        "  . .  "
                    },new List<string> {
                        " . .  ",
                        ".WYSE.",
                        " I C  ",
                        " N R  ",
                        " D E  ",
                        " O E  ",
                        ".WANG.",
                        " . .  "
                    },new List<string> {
                        "     .  ",
                        "     V  ",
                        "     I  ",
                        "     D  ",
                        "     E  ",
                        ".WINDOW.",
                        "     .  "
                    },new List<string> {
                        "  . .  ",
                        ".DRIVE.",
                        "  A I  ",
                        " .MODE.",
                        "  . E  ",
                        "    O  ",
                        "    .  "
                    },new List<string> {
                        "   .    ",
                        ".UNISYS.",
                        "   B    ",
                        "   M    ",
                        "   .    "
                    }
                };

                case 9103:

                    return new List<List<string>> {

                    new List<string> {
                        "   .     ",
                        "   W     ",
                        "   H     ",
                        "   I     ",
                        " . T     ",
                        ".CENIS.  ",
                        " O E     ",
                        ".OLYMPUS.",
                        " K .     ",
                        " .       "
                    },new List<string> {
                        "       .       ",
                        "       V       ",
                        "       E       ",
                        "       S       ",
                        "       U       ",
                        "       V       ",
                        "      .I       ",
                        "     .JUNGFRAU.",
                        ".OLYMPUS.      ",
                        "      R.       ",
                        "      A        ",
                        "      .        "
                    },new List<string> {
                        "  .       ",
                        "  W       ",
                        "  I       ",
                        ".BLUE.    ",
                        "  H  E    ",
                        ".VESUVIUS.",
                        "  L  E    ",
                        "  M  R    ",
                        "  .  E    ",
                        "     S    ",
                        "     T    ",
                        "     .    "
                    },new List<string> {
                        "    .     ",
                        "    W     ",
                        "  . H     ",
                        " .WHITNEY.",
                        "  I T     ",
                        ".BLUE.    ",
                        "  H .     ",
                        "  E       ",
                        "  L       ",
                        "  M       ",
                        "  .       "
                    },new List<string> {
                        "      .     ",
                        "      A     ",
                        "      L.    ",
                        "     .PELEE.",
                        ".EVEREST.   ",
                        "      .N    ",
                        "       A    ",
                        "       .    "
                    },new List<string> {
                        "     . .  ",
                        "     E J  ",
                        ".VESUVIUS.",
                        "     E N  ",
                        "   .CRAG. ",
                        "     E F  ",
                        "     S R  ",
                        "     T A  ",
                        "     . U  ",
                        "       .  "
                    },new List<string> {
                        "      . .   ",
                        ".JUNGFRAU.  ",
                        "      I R   ",
                        "      G A   ",
                        "  .MCKINLEY.",
                        "      . .   "
                    },new List<string> {
                        "     . ",
                        "     M ",
                        "     C ",
                        "     K ",
                        "     I ",
                        "     N ",
                        "     L ",
                        "     E ",
                        ".ROCKY.",
                        "     . "
                    },new List<string> {
                        "    . ",
                        ".SNOW.",
                        "    H ",
                        "    I ",
                        "    T ",
                        "    E ",
                        "    . "
                    },new List<string> {
                        "    .  ",
                        " .ALPS.",
                        " P  E  ",
                        " E  L  ",
                        ".ANDES.",
                        " K  E  ",
                        " .  .  "
                    },new List<string> {
                        "    . ",
                        "    H ",
                        "    E ",
                        "    C ",
                        "    L ",
                        ".JURA.",
                        "    . "
                    }
                };

                case 9104:

                    return new List<List<string>> {

                    new List<string> {
                        " .    ",
                        ".ZERO.",
                        " E    ",
                        " N    ",
                        " I    ",
                        " T    ",
                        " H    ",
                        " .    "
                    },new List<string> {
                        "      .    ",
                        "     .E    ",
                        "    .WAVES.",
                        " .STEER.   ",
                        "    .STARS.",
                        ".ZENITH.   ",
                        "     ..    "
                    },new List<string> {
                        "    ..     ",
                        "   .TABLES.",
                        "  .FIX.    ",
                        "   .MIDDAY.",
                        ".WAVES.    ",
                        "    ..     "
                    },new List<string> {
                        " . .  ",
                        ".TIME.",
                        " A I  ",
                        " B D  ",
                        " L D  ",
                        " E A  ",
                        ".SKY. ",
                        " . .  "
                    },new List<string> {
                        "   .    ",
                        "   S    ",
                        "   E .  ",
                        "   X W  ",
                        " .STEER.",
                        "   A S  ",
                        ".ZENITH.",
                        "   T .  ",
                        "   .    "
                    },new List<string> {
                        "   . . ",
                        ".PILOT.",
                        "   E R ",
                        " .ZERO.",
                        "   . P ",
                        "     I ",
                        "     C ",
                        "     S ",
                        "     . "
                    },new List<string> {
                        "     . ",
                        ".STARS.",
                        "     I ",
                        "     G ",
                        "     N ",
                        "     S ",
                        "     . "
                    },new List<string> {
                        " .  .  ",
                        " S  O  ",
                        " I  R  ",
                        ".GLOBE.",
                        " N  I  ",
                        ".SOUTH.",
                        " .  .  "
                    },new List<string> {
                        " .   ",
                        ".SUN.",
                        " E   ",
                        " X   ",
                        " T   ",
                        " A   ",
                        " N   ",
                        " T   ",
                        " .   "
                    },new List<string> {
                        " .     ",
                        " L     ",
                        ".ORBIT.",
                        " G     ",
                        " .     "
                    },new List<string> {
                        "    .  ",
                        "    M  ",
                        "    O  ",
                        "    O  ",
                        ".SIGNS.",
                        "    .  "
                    },new List<string> {
                        "  .  ",
                        "  M  ",
                        ".BOX.",
                        "  O  ",
                        "  N  ",
                        "  .  "
                    },new List<string> {
                        "  .      ",
                        "  R      ",
                        "  A      ",
                        "  N      ",
                        "  G      ",
                        ".SEXTANT.",
                        "  .      "
                    },new List<string> {
                        " . .  ",
                        ".PORT.",
                        " O A  ",
                        ".LINE.",
                        " E G  ",
                        " . E  ",
                        "   .  "
                    }
                };

                case 9105:

                    return new List<List<string>> {

                    new List<string> {
                        "       . ",
                        "       M ",
                        "     . A ",
                        "     L J ",
                        "   .COLE.",
                        "     U S ",
                        "     I T ",
                        ".DYNASTY.",
                        "     . . "
                    },new List<string> {
                        "  .      ",
                        "  R      ",
                        "  O      ",
                        "  Y      ",
                        "  A      ",
                        "  L      ",
                        "  T      ",
                        ".DYNASTY.",
                        "  .      "
                    },new List<string> {
                        "     . .   ",
                        "     H A   ",
                        "     E T   ",
                        ".CABINET.  ",
                        "     R I   ",
                        "  .ROYALTY.",
                        "     . A   ",
                        "       .   "
                    },new List<string> {
                        "     .     ",
                        "   . H     ",
                        "   O E     ",
                        ".CABINET.  ",
                        "   E R     ",
                        "  .ROYALTY.",
                        "   O .     ",
                        "   N       ",
                        "   .       "
                    },new List<string> {
                        "     .  ",
                        "     O  ",
                        "     B  ",
                        "     E  ",
                        "     R  ",
                        "     O  ",
                        ".REGENT.",
                        "     .  "
                    },new List<string> {
                        "      .     ",
                        "      E     ",
                        "      M     ",
                        "     .P     ",
                        "    .REGENT.",
                        ".ARTHUR.    ",
                        "    .LORD.  ",
                        ".BANNER.    ",
                        "     ..     "
                    },new List<string> {
                        "   .    ",
                        "   C    ",
                        "   O  . ",
                        ".THRONE.",
                        "   O  M ",
                        "   N  P ",
                        "   E  E ",
                        ".ARTHUR.",
                        "   .  O ",
                        "      R ",
                        "      . "
                    },new List<string> {
                        " .      ",
                        " V .    ",
                        " I C    ",
                        " C O    ",
                        ".THRONE.",
                        " O O    ",
                        ".RANI.  ",
                        " I E    ",
                        " A T    ",
                        " . .    "
                    },new List<string> {
                        "     .    ",
                        "   .MIDAS.",
                        "   C V    ",
                        "   O A    ",
                        ".THRONE.  ",
                        "   O .    ",
                        "   N      ",
                        "   E      ",
                        "   T      ",
                        "   .      "
                    }
                };

                case 9106:

                    return new List<List<string>> {

                    new List<string> {
                        " .  .  ",
                        ".ZEUS. ",
                        " E  E  ",
                        ".PLUTO.",
                        " H  H  ",
                        " Y  .  ",
                        " R     ",
                        " U     ",
                        " S     ",
                        " .     "
                    },new List<string> {
                        "      . .   ",
                        ".ZEPHYRUS.  ",
                        "      H A   ",
                        "    .NESTOR.",
                        "      A U   ",
                        "      . R   ",
                        "        N   ",
                        "        .   "
                    },new List<string> {
                        "   .  . ",
                        "   N  A ",
                        "   E  D ",
                        "   S  O ",
                        ".SATURN.",
                        "   O  I ",
                        ".FURIES.",
                        "   .  . "
                    },new List<string> {
                        "   . .  ",
                        ".ADONIS.",
                        "   D O  ",
                        ".ORION. ",
                        "   N I  ",
                        "   . A  ",
                        "     .  "
                    },new List<string> {
                        "  . .  ",
                        ".JASON.",
                        "  D R  ",
                        " .ODIN.",
                        "  N O  ",
                        "  I N  ",
                        "  S .  ",
                        "  .    "
                    },new List<string> {
                        "     .     ",
                        "   . C     ",
                        "  .MERCURY.",
                        "   A E     ",
                        "   R O     ",
                        ".JASON.    ",
                        "   . .     "
                    },new List<string> {
                        "  .       ",
                        "  M       ",
                        "  E .     ",
                        "  R O     ",
                        "  C L     ",
                        " .ULYSSES.",
                        "  R M     ",
                        ".NYMPHS.  ",
                        "  . U     ",
                        "    S     ",
                        "    .     "
                    },new List<string> {
                        "    .     ",
                        "    O .   ",
                        "    L I   ",
                        " .ULYSSES.",
                        "    M I   ",
                        ".NYMPHS.  ",
                        "    U .   ",
                        "    S     ",
                        "    .     "
                    },new List<string> {
                        "       . ",
                        "       A ",
                        "       B ",
                        "       A ",
                        ".OLYMPUS.",
                        "       . "
                    },new List<string> {
                        " .     ",
                        " U     ",
                        " L     ",
                        " Y     ",
                        " S     ",
                        " S     ",
                        " E     ",
                        ".SATYR.",
                        " .     "
                    },new List<string> {
                        "     . ",
                        "     P ",
                        "     A ",
                        ".SATYR.",
                        "     I ",
                        "     S ",
                        "     . "
                    },new List<string> {
                        "    . ",
                        "    P ",
                        "    A ",
                        "    R ",
                        "    I ",
                        ".EROS.",
                        "    . "
                    }
                };

                case 9107:

                    return new List<List<string>> {

                    new List<string> {
                        "     .    ",
                        "     B    ",
                        "     E    ",
                        "   . N    ",
                        "  .DAZZLE.",
                        "   U I    ",
                        "   T N    ",
                        ".ROYCE.   ",
                        "   . .    "
                    },new List<string> {
                        "    .     ",
                        "    S     ",
                        "    P.    ",
                        ".ROTOR.   ",
                        "   .ROLLS.",
                        " .DUTY.   ",
                        "    .C    ",
                        "     E    ",
                        "     .    "
                    },new List<string> {
                        " .  .  ",
                        ".SPORT.",
                        " E  O  ",
                        " A  L  ",
                        ".TAIL. ",
                        " S  S  ",
                        " .  .  "
                    },new List<string> {
                        "  .     ",
                        "  R .   ",
                        ".ROYCE. ",
                        "  L A   ",
                        "  L R   ",
                        " .SPEED.",
                        "  . .   "
                    },new List<string> {
                        " .  .  ",
                        " C  S  ",
                        " A  P  ",
                        ".ROTOR.",
                        " S  R  ",
                        " .DUTY.",
                        "    .  "
                    },new List<string> {
                        "   . ",
                        "   C ",
                        "   A ",
                        "   R ",
                        ".GAS.",
                        "   . "
                    },new List<string> {
                        "   .  . ",
                        "  .BELT.",
                        "   E  Y ",
                        "   N  R ",
                        ".DAZZLE.",
                        "   I  . ",
                        "   N    ",
                        "   E    ",
                        "   .    "
                    },new List<string> {
                        " .  .    ",
                        " G  B    ",
                        ".AXLE.   ",
                        " S  N    ",
                        " .DAZZLE.",
                        "    I    ",
                        "    N    ",
                        "    E    ",
                        "    .    "
                    },new List<string> {
                        " .   ",
                        " B   ",
                        " E   ",
                        " N   ",
                        " Z   ",
                        " I   ",
                        ".NUT.",
                        " E   ",
                        " .   "
                    },new List<string> {
                        "   .   ",
                        ".TYRE. ",
                        "   O B ",
                        "  .AIR.",
                        "   D A ",
                        "   . K ",
                        "     E ",
                        "     . "
                    },new List<string> {
                        " .    ",
                        " L    ",
                        " O    ",
                        ".CARS.",
                        " K    ",
                        " .    "
                    },new List<string> {
                        " .    ",
                        ".BOOT.",
                        " R    ",
                        " A    ",
                        " K    ",
                        " E    ",
                        " .    "
                    },new List<string> {
                        "   .   ",
                        "   B   ",
                        "  .O.  ",
                        " .HORN.",
                        ".AUTO. ",
                        "  B.O  ",
                        "  S F  ",
                        "  . .  "
                    },new List<string> {
                        "  . .    ",
                        "  H R    ",
                        ".AUTO.   ",
                        "  B O    ",
                        " .SAFETY.",
                        "  . .    "
                    },new List<string> {
                        "   . ",
                        "   S ",
                        "   A ",
                        "   F ",
                        "   E ",
                        "   T ",
                        ".KEY.",
                        "   . "
                    },new List<string> {
                        "     . ",
                        "     B ",
                        "     R ",
                        "     A ",
                        "     K ",
                        ".SPARE.",
                        "     . "
                    },new List<string> {
                        "    . ",
                        ".VANS.",
                        "    P ",
                        "    A ",
                        "    R ",
                        "    E ",
                        "    . "
                    }
                };

                case 9108:

                    return new List<List<string>> {

                    new List<string> {
                        "  ..     ",
                        ".LOW.    ",
                        " .ZEPHYR.",
                        ".HOT.    ",
                        "  N.     ",
                        "  E      ",
                        "  .      "
                    },new List<string> {
                        "     .  ",
                        "     D  ",
                        "     U  ",
                        "     S  ",
                        "     T  ",
                        ".ZEPHYR.",
                        "     .  "
                    },new List<string> {
                        "   .    ",
                        "   C    ",
                        "   U    ",
                        "   M    ",
                        "   U    ",
                        "  .L.   ",
                        " .DUSTY.",
                        ".GUST.  ",
                        "  L.O   ",
                        "  L R   ",
                        "  . M   ",
                        "    .   "
                    },new List<string> {
                        "   . . ",
                        "   D S ",
                        " .GUST.",
                        "   L O ",
                        ".POLAR.",
                        "   . M ",
                        "     . "
                    },new List<string> {
                        "  . .    ",
                        "  C C    ",
                        "  L U    ",
                        "  O M    ",
                        ".EURUS.  ",
                        "  D L    ",
                        "  .DUSTY.",
                        "    S    ",
                        "    .    "
                    },new List<string> {
                        " .     ",
                        " S     ",
                        " T     ",
                        " O     ",
                        " R     ",
                        ".MUGGY.",
                        " .     "
                    },new List<string> {
                        "     . ",
                        "     F ",
                        "     O ",
                        "     G ",
                        "     G ",
                        ".MUGGY.",
                        "     . "
                    },new List<string> {
                        " .  .   ",
                        ".FROSTS.",
                        " O  L   ",
                        ".GALE.  ",
                        " G  E   ",
                        " Y  T   ",
                        " .  .   "
                    },new List<string> {
                        " .    ",
                        " S    ",
                        " L    ",
                        " E    ",
                        " E    ",
                        ".THAW.",
                        " .    "
                    },new List<string> {
                        "    . ",
                        "    T ",
                        "    H ",
                        "    A ",
                        ".SNOW.",
                        "    . "
                    },new List<string> {
                        "  .      ",
                        "  M   .  ",
                        "  E   H  ",
                        " .TROPIC.",
                        "  E   L  ",
                        "  O   L  ",
                        ".FROSTS. ",
                        "  .   .  "
                    },new List<string> {
                        " . .    ",
                        ".MIST.  ",
                        " E M    ",
                        ".TROPIC.",
                        " E G    ",
                        " O .    ",
                        " R      ",
                        " .      "
                    }
                };

                case 9109:

                    return new List<List<string>> {

                    new List<string> {
                        "         .    ",
                        "         B    ",
                        "         U    ",
                        "         Z    ",
                        "         Z    ",
                        "       ..E    ",
                        ".COPYPAPER.   ",
                        "      .ANSWER.",
                        "    .POST.    ",
                        "      .TELLER.",
                        "   .ORDER.    ",
                        "       ..     "
                    },new List<string> {
                        "   .     ",
                        " .SCREEN.",
                        " T O     ",
                        " A P     ",
                        ".PAY.    ",
                        " E P     ",
                        " . A     ",
                        "   P     ",
                        "   E     ",
                        "   R     ",
                        "   .     "
                    },new List<string> {
                        " .  . ",
                        ".LIST.",
                        " E  A ",
                        " T  P ",
                        ".TIME.",
                        " E  . ",
                        " R    ",
                        " .    "
                    },new List<string> {
                        "   .     ",
                        "   M     ",
                        "   A     ",
                        "   G     ",
                        "   A     ",
                        ".BUZZERS.",
                        "   I     ",
                        "   N     ",
                        "   E     ",
                        "   .     "
                    },new List<string> {
                        "   . . ",
                        "   M L ",
                        "   O I ",
                        ".BONUS.",
                        "   E T ",
                        ".KEYS. ",
                        "   .   "
                    },new List<string> {
                        "  . .  ",
                        ".KEYS. ",
                        "  A C  ",
                        "  R R  ",
                        ".INDEX.",
                        "  . E  ",
                        "    N  ",
                        "    .  "
                    },new List<string> {
                        "     . .   ",
                        ".COPYPAPER.",
                        "     A A   ",
                        "    .POST. ",
                        "     E T   ",
                        "     R E   ",
                        "     . .   "
                    },new List<string> {
                        "      . ",
                        "  .   E ",
                        "  E   R ",
                        ".ANSWER.",
                        "  T   O ",
                        ".TELLER.",
                        "  R   . ",
                        "  .     "
                    },new List<string> {
                        "   .  ",
                        "   S  ",
                        "   C  ",
                        "   R  ",
                        "   E  ",
                        "   E  ",
                        ".SEND.",
                        "   .  "
                    },new List<string> {
                        "       .  ",
                        "       B  ",
                        "       A  ",
                        ".MAGAZINE.",
                        "       K  ",
                        "       .  "
                    }
                };

                case 9110:

                    return new List<List<string>> {

                    new List<string> {
                        "      .   ",
                        "      F   ",
                        "      R   ",
                        "      E . ",
                        "      E T ",
                        ".SQUEEZER.",
                        "      E A ",
                        "    .TRAY.",
                        "      . M ",
                        "        O ",
                        "        B ",
                        "        I ",
                        "        L ",
                        "        E ",
                        "        . "
                    },new List<string> {
                        "  .      ",
                        "  A      ",
                        "  P      ",
                        ".FREEZER.",
                        "  O      ",
                        "  N      ",
                        "  .      "
                    },new List<string> {
                        "     . ",
                        "     F ",
                        "     A ",
                        ".APRON.",
                        "     . "
                    },new List<string> {
                        " .     ",
                        " T     ",
                        " E     ",
                        ".APRON.",
                        " .     "
                    },new List<string> {
                        "   .  . ",
                        ".BASKET.",
                        "   C  E ",
                        "   A  A ",
                        ".TILES. ",
                        "   E    ",
                        "   S    ",
                        "   .    "
                    },new List<string> {
                        "   .        ",
                        "   S        ",
                        "   C        ",
                        "   A .      ",
                        ".TILES.     ",
                        "   E A      ",
                        "  .SQUEEZER.",
                        "   . C      ",
                        "     E      ",
                        "     R      ",
                        "     S      ",
                        "     .      "
                    },new List<string> {
                        "      .      ",
                        "      S      ",
                        "      H      ",
                        "      E      ",
                        "      A.     ",
                        ".SAUCERS.    ",
                        "     .SIEVES.",
                        "      .N     ",
                        "       K     ",
                        "       .     "
                    },new List<string> {
                        " .  .    ",
                        ".BOTTLES.",
                        " A  I    ",
                        ".SCALES. ",
                        " K  E    ",
                        " E  S    ",
                        " T  .    ",
                        " .       "
                    },new List<string> {
                        "    .   ",
                        "    S . ",
                        "  .SINK.",
                        "    E E ",
                        ".TRIVET.",
                        "    E T ",
                        "    S L ",
                        "    . E ",
                        "      . "
                    },new List<string> {
                        "      .   ",
                        "      S   ",
                        "   .  I   ",
                        "   S  E   ",
                        "  .TRIVET.",
                        "   O  E   ",
                        ".SPOONS.  ",
                        "   L  .   ",
                        "   .      "
                    },new List<string> {
                        " . .    ",
                        ".GAS.   ",
                        " L T    ",
                        " A O    ",
                        ".SPOONS.",
                        " S L    ",
                        " . .    "
                    }
                };

                case 9111:

                    return new List<List<string>> {

                    new List<string> {
                        "      .   ",
                        "      P   ",
                        "      R   ",
                        "      O   ",
                        "      T . ",
                        "      O C ",
                        ".HYDROZOA.",
                        "      O S ",
                        "   .COAST.",
                        "      . L ",
                        "        E ",
                        "        . "
                    },new List<string> {
                        "   .      ",
                        "   C .    ",
                        "   A R    ",
                        "  .SHELLS.",
                        "   T E    ",
                        "   L F    ",
                        ".WEEDS.   ",
                        "   . .    "
                    },new List<string> {
                        "   .    ",
                        "   R .  ",
                        ".SHELLS.",
                        "   E I  ",
                        "  .FINS.",
                        "   S E  ",
                        "   . .  "
                    },new List<string> {
                        "    .       ",
                        "    O .     ",
                        "  .HYDROZOA.",
                        "    S O     ",
                        "    T C     ",
                        "    E K     ",
                        ".SHARKS.    ",
                        "    . .     "
                    },new List<string> {
                        "      . . ",
                        ".MOLLUSCS.",
                        "      A H ",
                        "      L A ",
                        "  .OYSTER.",
                        "      . K ",
                        "        S ",
                        "        . "
                    },new List<string> {
                        "       . ",
                        "       S ",
                        "       H ",
                        "       E ",
                        "       L ",
                        "       L ",
                        ".MUSSELS.",
                        "       . "
                    },new List<string> {
                        "    .    ",
                        "    D    ",
                        "    U    ",
                        "    N    ",
                        "    E    ",
                        ".MUSSELS.",
                        "    .    "
                    },new List<string> {
                        "    . .   ",
                        ".PRAWNS.  ",
                        "    I T   ",
                        "    N I   ",
                        "   .DUNES.",
                        "    . G   ",
                        "      .   "
                    },new List<string> {
                        " .        ",
                        ".MOLLUSCS.",
                        " A        ",
                        " R        ",
                        " I        ",
                        " N        ",
                        " E        ",
                        " .        "
                    },new List<string> {
                        " . .  ",
                        " R M  ",
                        " O A  ",
                        ".SURF.",
                        " E I  ",
                        ".SAND.",
                        " . E  ",
                        "   .  "
                    }
                };

                case 9112:

                    return new List<List<string>> {

                    new List<string> {
                        "     . . ",
                        "     M D ",
                        "     A O ",
                        "     R N ",
                        ".BLITZEN.",
                        "     I E ",
                        "  .PIPER.",
                        "     A . ",
                        "     N   ",
                        "     .   "
                    },new List<string> {
                        "     .      ",
                        "     H      ",
                        "     O      ",
                        "    .L      ",
                        "   .BLITZEN.",
                        ".MERRY.     ",
                        "    A.      ",
                        "    N       ",
                        "    D       ",
                        "    Y       ",
                        "    .       "
                    },new List<string> {
                        "   . ",
                        "   B ",
                        "   R ",
                        "   A ",
                        "   N ",
                        "   D ",
                        ".TOY.",
                        "   . "
                    },new List<string> {
                        " .   ",
                        " S   ",
                        ".TOY.",
                        " A   ",
                        " R   ",
                        " .   "
                    },new List<string> {
                        "    . ",
                        "    T ",
                        ".STAR.",
                        "    E ",
                        "    E ",
                        "    . "
                    },new List<string> {
                        " .     ",
                        ".TOAST.",
                        " R     ",
                        " E     ",
                        " E     ",
                        " .     "
                    },new List<string> {
                        " .      ",
                        " T      ",
                        " O      ",
                        " A      ",
                        " S      ",
                        ".TURKEY.",
                        " .      "
                    },new List<string> {
                        "      . ",
                        "      W ",
                        "      H ",
                        "      I ",
                        "      S ",
                        "      K ",
                        ".TURKEY.",
                        "      . "
                    },new List<string> {
                        "    .   ",
                        "    P   ",
                        " .  R   ",
                        " S  E   ",
                        ".WHISKY.",
                        " E  E   ",
                        ".EGGNOG.",
                        " T  T   ",
                        " S  S   ",
                        " .  .   "
                    },new List<string> {
                        "        . ",
                        "        D ",
                        "        A ",
                        ".MARZIPAN.",
                        "        C ",
                        "        E ",
                        "        . "
                    },new List<string> {
                        "  .    ",
                        "  F    ",
                        "  O    ",
                        ".HOLLY.",
                        "  D    ",
                        "  .    "
                    },new List<string> {
                        " .     ",
                        " C     ",
                        " R     ",
                        " E     ",
                        " A     ",
                        ".MERRY.",
                        " .     "
                    },new List<string> {
                        "      . . ",
                        "  .SWEETS.",
                        "      G E ",
                        "      G A ",
                        ".PRESENTS.",
                        "      O O ",
                        "      G N ",
                        "      . . "
                    }
                };

                case 9201:

                    return new List<List<string>> {

                    new List<string> {
                        "    .     ",
                        "  . M     ",
                        "  M A     ",
                        "  A C     ",
                        ".STURT.   ",
                        "  I O     ",
                        " .LIZARDS.",
                        "  D A     ",
                        "  A M     ",
                        "  . I     ",
                        "    A     ",
                        "    .     "
                    },new List<string> {
                        "     .     ",
                        "     M     ",
                        "     A     ",
                        "     C     ",
                        "     R .   ",
                        "     O I   ",
                        "  .LIZARDS.",
                        "     A O   ",
                        ".SWAGMEN.  ",
                        "     I .   ",
                        "     A     ",
                        "     .     "
                    },new List<string> {
                        " .      ",
                        " E .    ",
                        ".WOMBAT.",
                        " E A    ",
                        " .STURT.",
                        "   I    ",
                        "   L    ",
                        "   D    ",
                        "   A    ",
                        "   .    "
                    },new List<string> {
                        "       . ",
                        "       O ",
                        "       P ",
                        "       O ",
                        ".LIZARDS.",
                        "       S ",
                        "       U ",
                        "       M ",
                        "       S ",
                        "       . "
                    },new List<string> {
                        "     . .    ",
                        "  .OPOSSUMS.",
                        "     R K    ",
                        "     E I    ",
                        ".STATION.   ",
                        "     L K    ",
                        "     L .    ",
                        "     Y      ",
                        "     .      "
                    },new List<string> {
                        "     .      ",
                        "     O      ",
                        "     R      ",
                        "     E      ",
                        "     I      ",
                        "     L      ",
                        "     L      ",
                        ".LILLYPILLY.",
                        "     .      "
                    },new List<string> {
                        "         . ",
                        "         L ",
                        "         I ",
                        "         L ",
                        "         L ",
                        "         Y ",
                        "         P ",
                        "         I ",
                        "         L ",
                        "         L ",
                        ".CASSOWARY.",
                        "         . "
                    },new List<string> {
                        "   .        ",
                        "   W .      ",
                        "  .OPOSSUMS.",
                        "   N R      ",
                        "   G E      ",
                        ".STATION.   ",
                        "   . L      ",
                        "     L      ",
                        "     Y      ",
                        "     .      "
                    },new List<string> {
                        " .       ",
                        " I .     ",
                        " D W     ",
                        " R O     ",
                        ".ION.    ",
                        " E G     ",
                        ".STATION.",
                        " S .     ",
                        " .       "
                    },new List<string> {
                        "          . ",
                        "          M ",
                        "          U ",
                        "          L ",
                        "          G ",
                        ".MACROZAMIA.",
                        "          . "
                    },new List<string> {
                        "    . ",
                        ".BATS.",
                        "    W ",
                        "    A ",
                        "    G ",
                        "    M ",
                        "    E ",
                        "    N ",
                        "    . "
                    }
                };

                case 9202:

                    return new List<List<string>> {

                    new List<string> {
                        " . .     ",
                        " S R     ",
                        " H A     ",
                        " U P     ",
                        ".THUMB.  ",
                        " T N     ",
                        ".LIZARDS.",
                        " E E     ",
                        " . L     ",
                        "   .     "
                    },new List<string> {
                        " .  .     ",
                        ".SHUTTLE. ",
                        " E  H     ",
                        ".RAPUNZEL.",
                        " V  M     ",
                        " A  B     ",
                        " N  .     ",
                        " T        ",
                        " .        "
                    },new List<string> {
                        "       . ",
                        ".SERVANT.",
                        "       R ",
                        "       O ",
                        "       L ",
                        "       L ",
                        "       S ",
                        "       . "
                    },new List<string> {
                        "  .    ",
                        "  T    ",
                        "  R    ",
                        ".TOWER.",
                        "  L    ",
                        "  L    ",
                        "  S    ",
                        "  .    "
                    },new List<string> {
                        "     . ",
                        "     H ",
                        "     A ",
                        ".TOWER.",
                        "     E ",
                        "     . "
                    },new List<string> {
                        "      .     ",
                        ".LIZARDS.   ",
                        "      R D   ",
                        "    .BEAUTY.",
                        "      A C   ",
                        "      M K   ",
                        "      S .   ",
                        "      .     "
                    },new List<string> {
                        "      . ",
                        "      G ",
                        "      R ",
                        ".BEAUTY.",
                        "      P ",
                        "      H ",
                        "      O ",
                        "      N ",
                        "      . "
                    },new List<string> {
                        "   .  ",
                        "   D  ",
                        "   R  ",
                        "   E  ",
                        "   A  ",
                        "   M  ",
                        ".PUSS.",
                        "   .  "
                    },new List<string> {
                        "    . ",
                        ".PUSS.",
                        "    T ",
                        "    R ",
                        "    A ",
                        "    W ",
                        "    . "
                    },new List<string> {
                        "   .   ",
                        "   F   ",
                        ".STRAW.",
                        "   O   ",
                        "   G   ",
                        "   .   "
                    },new List<string> {
                        "     . ",
                        ".STRAW.",
                        "     A ",
                        "     N ",
                        "     D ",
                        "     . "
                    },new List<string> {
                        " .    ",
                        " S    ",
                        ".PUSS.",
                        " E    ",
                        " L    ",
                        " L    ",
                        " S    ",
                        " .    "
                    },new List<string> {
                        " .    ",
                        " G  . ",
                        ".IMPS.",
                        " A  P ",
                        ".NOSE.",
                        " T  L ",
                        " .  L ",
                        "    S ",
                        "    . "
                    },new List<string> {
                        "      . ",
                        "      G ",
                        "      O ",
                        "      O ",
                        ".SPELLS.",
                        "      E ",
                        "      . "
                    },new List<string> {
                        "     .  ",
                        ".TROLLS.",
                        "     I  ",
                        "     E  ",
                        "     .  "
                    }
                };

                case 9203:

                    return new List<List<string>> {

                    new List<string> {
                        "   . . ",
                        "   L P ",
                        "   A E ",
                        "   W N ",
                        "   S A ",
                        "  .U.L ",
                        ".GUILT.",
                        " .STAY.",
                        "  H.W. ",
                        "  E .  ",
                        "  R    ",
                        "  .    "
                    },new List<string> {
                        "    .    ",
                        "  . A    ",
                        ".LAWSUIT.",
                        "  V S    ",
                        ".PENALTY.",
                        "  R U    ",
                        "  . L    ",
                        "    T    ",
                        "    .    "
                    },new List<string> {
                        "    . ",
                        "    A ",
                        "    S ",
                        "    S ",
                        "    A ",
                        "    U ",
                        "    L ",
                        ".WRIT.",
                        "    . "
                    },new List<string> {
                        " .       ",
                        ".WITNESS.",
                        " R       ",
                        " I       ",
                        " T       ",
                        " .       "
                    },new List<string> {
                        "      .  ",
                        ".WITNESS.",
                        "      E  ",
                        "      A  ",
                        "      L  ",
                        "      .  "
                    },new List<string> {
                        "     . ",
                        "     B ",
                        ".USHER.",
                        "     I ",
                        "     B ",
                        "     E ",
                        "     R ",
                        "     Y ",
                        "     . "
                    },new List<string> {
                        "       . ",
                        "       L ",
                        "       A ",
                        "       R ",
                        "       C ",
                        "       E ",
                        "       N ",
                        ".BRIBERY.",
                        "       . "
                    },new List<string> {
                        "  .     ",
                        "  L     ",
                        "  A     ",
                        "  R     ",
                        "  C     ",
                        ".FELONY.",
                        "  N     ",
                        "  Y     ",
                        "  .     "
                    },new List<string> {
                        "      . ",
                        "      L ",
                        "      E ",
                        "      G ",
                        "      A ",
                        "      C ",
                        ".FELONY.",
                        "      . "
                    },new List<string> {
                        "    .   ",
                        "    P   ",
                        "    R   ",
                        ".FELONY.",
                        "    O   ",
                        "    F   ",
                        "    .   "
                    },new List<string> {
                        " .       ",
                        " P       ",
                        " R       ",
                        " O       ",
                        " O       ",
                        ".FORGERY.",
                        " .       "
                    },new List<string> {
                        "       . ",
                        "       F ",
                        "    .  O ",
                        "    C  R ",
                        "    O  G ",
                        "  .JUDGE.",
                        "    R  R ",
                        ".CUSTODY.",
                        "    .  . "
                    },new List<string> {
                        " .      ",
                        " P      ",
                        ".LEGACY.",
                        " E      ",
                        " A      ",
                        " .      "
                    }
                };

                case 9204:

                    return new List<List<string>> {

                    new List<string> {
                        "   .      ",
                        "   S      ",
                        "   H....  ",
                        "  .RITUAL.",
                        ".SAUCERS. ",
                        "  .BEANS. ",
                        "   .D..A  ",
                        "    .  M  ",
                        "       .  "
                    },new List<string> {
                        " .  .  ",
                        ".TIPS. ",
                        " A  A  ",
                        ".SHRUB.",
                        " T  C  ",
                        " E  E  ",
                        " .  R  ",
                        "    S  ",
                        "    .  "
                    },new List<string> {
                        "   .  ",
                        "   C  ",
                        "   U  ",
                        ".TIPS.",
                        "   .  "
                    },new List<string> {
                        "  .   ",
                        "  A   ",
                        "  S   ",
                        "  S   ",
                        "  A   ",
                        ".AMOY.",
                        "  .   "
                    },new List<string> {
                        "  .    ",
                        "  A    ",
                        "  M    ",
                        "  O    ",
                        ".HYSON.",
                        "  .    "
                    },new List<string> {
                        "     . ",
                        "   . A ",
                        ".HYSON.",
                        "   P H ",
                        " .BREW.",
                        "   A E ",
                        "   Y I ",
                        "   . . "
                    },new List<string> {
                        "     . ",
                        "     C ",
                        "     E ",
                        "     R ",
                        "     E ",
                        "     M ",
                        "     O ",
                        "     N ",
                        ".SPRAY.",
                        "     . "
                    },new List<string> {
                        " .   ",
                        " N   ",
                        " I   ",
                        ".CUP.",
                        " E   ",
                        " .   "
                    },new List<string> {
                        " .    ",
                        ".AMOY.",
                        " S    ",
                        " I    ",
                        " A    ",
                        " .    "
                    },new List<string> {
                        "      . ",
                        "      A ",
                        ".CHESTS.",
                        "      I ",
                        "      A ",
                        "      . "
                    },new List<string> {
                        "     . ",
                        "     T ",
                        "   . E ",
                        ".MOCHA.",
                        "   H P ",
                        "   E O ",
                        "  .SET.",
                        "   T . ",
                        "   S   ",
                        "   .   "
                    },new List<string> {
                        "     . ",
                        ".SHOOT.",
                        "     E ",
                        "     A ",
                        "     P ",
                        "     O ",
                        "     T ",
                        "     . "
                    },new List<string> {
                        "    .     ",
                        "    P     ",
                        "    E     ",
                        "    K     ",
                        "    O     ",
                        ".CEREMONY.",
                        "    .     "
                    },new List<string> {
                        "    .  ",
                        "    P  ",
                        ".YEMEN.",
                        "    K  ",
                        "    O  ",
                        "    E  ",
                        "    .  "
                    },new List<string> {
                        " .     ",
                        " K     ",
                        " E     ",
                        " N     ",
                        ".YEMEN.",
                        " A     ",
                        " .     "
                    }
                };

                case 9206:

                    return new List<List<string>> {

                    new List<string> {
                        "     .  ",
                        "     A  ",
                        "     N  ",
                        "   . A  ",
                        " .CLOT. ",
                        "   O O  ",
                        ".ECZEMA.",
                        "   E Y  ",
                        "   N .  ",
                        "   G    ",
                        "   E    ",
                        "   .    "
                    },new List<string> {
                        "  .      ",
                        "  G      ",
                        "  A      ",
                        "  L      ",
                        "  E      ",
                        ".ANATOMY.",
                        "  .      "
                    },new List<string> {
                        " .      ",
                        " R      ",
                        ".ECZEMA.",
                        " I      ",
                        " D      ",
                        " .      "
                    },new List<string> {
                        "       . ",
                        "       E ",
                        "       Y ",
                        ".LOZENGE.",
                        "       S ",
                        "       . "
                    },new List<string> {
                        "     . . ",
                        "     A S ",
                        "     N A ",
                        "    .AIL.",
                        "     T V ",
                        "     O E ",
                        ".ECZEMA. ",
                        "     Y   ",
                        "     .   "
                    },new List<string> {
                        " .     ",
                        ".SALVE.",
                        " A     ",
                        " L     ",
                        " K     ",
                        " .     "
                    },new List<string> {
                        " .     ",
                        " S     ",
                        " A     ",
                        " L     ",
                        ".VIRUS.",
                        " E     ",
                        " .     "
                    },new List<string> {
                        "     .     ",
                        "    .D     ",
                        "   .BODY.  ",
                        ".VIRUS.    ",
                        "   .REMEDY.",
                        "    N.     ",
                        "    E      ",
                        "    T      ",
                        "    .      "
                    },new List<string> {
                        "   .    ",
                        "   B    ",
                        "   O    ",
                        "   D    ",
                        ".OXYGEN.",
                        "   .    "
                    },new List<string> {
                        "     .  ",
                        "     R  ",
                        " .   E  ",
                        " B   M  ",
                        ".OXYGEN.",
                        " N   D  ",
                        ".EMBRYO.",
                        " .   .  "
                    },new List<string> {
                        "      . ",
                        "      B ",
                        "      U ",
                        "    . R ",
                        "    P N ",
                        "  .CURE.",
                        "    L T ",
                        ".NURSE. ",
                        "    E   ",
                        "    .   "
                    },new List<string> {
                        " .      ",
                        " B      ",
                        " U      ",
                        " R      ",
                        " N      ",
                        " E      ",
                        ".THOMAS.",
                        " .      "
                    },new List<string> {
                        "   . .  ",
                        "   C P  ",
                        ".THOMAS.",
                        "   L I  ",
                        ".IODINE.",
                        "   . .  "
                    }
                };

                case 9207:

                    return new List<List<string>> {

                    new List<string> {
                        "      .    ",
                        "    . M    ",
                        "    O E    ",
                        "    L D    ",
                        "  .CYCLIST.",
                        "    M E    ",
                        ".TROPHY.   ",
                        "    I .    ",
                        "    C      ",
                        "    .      "
                    },new List<string> {
                        "      .    ",
                        "      D    ",
                        "    . I    ",
                        "   .MOSCOW.",
                        "    E C    ",
                        "    D U    ",
                        ".CYCLIST.  ",
                        "    E .    ",
                        "    Y      ",
                        "    .      "
                    },new List<string> {
                        "       . ",
                        ".CYCLIST.",
                        "       E ",
                        "       A ",
                        "       M ",
                        "       . "
                    },new List<string> {
                        " .      ",
                        " T      ",
                        " E  .   ",
                        " A  O   ",
                        " M  L   ",
                        " M  Y   ",
                        " A  M   ",
                        ".TROPHY.",
                        " E  I   ",
                        ".SOCCER.",
                        " .  .   "
                    },new List<string> {
                        " .         ",
                        ".TEAMMATES.",
                        " A         ",
                        " B         ",
                        " L         ",
                        " E         ",
                        " .         "
                    },new List<string> {
                        "      . ",
                        "      C ",
                        "      Y ",
                        "   .  C ",
                        "   M  L ",
                        "   O  I ",
                        ".DISCUS.",
                        "   C  T ",
                        ".SPORT. ",
                        "   W    ",
                        "   .    "
                    },new List<string> {
                        " .     ",
                        ".SPORT.",
                        " C     ",
                        " U     ",
                        " L     ",
                        " L     ",
                        " S     ",
                        " .     "
                    },new List<string> {
                        "      . ",
                        ".SCULLS.",
                        "      O ",
                        "      L ",
                        "      O ",
                        "      . "
                    },new List<string> {
                        " .     ",
                        " S     ",
                        " P     ",
                        " O     ",
                        " R     ",
                        ".TOKYO.",
                        " .     "
                    },new List<string> {
                        "    .   ",
                        "    R   ",
                        "  . O   ",
                        ".TOKYO. ",
                        "  A C   ",
                        " .TORCH.",
                        "  H O   ",
                        "  . F   ",
                        "    T   ",
                        "    .   "
                    },new List<string> {
                        "        . ",
                        "        W ",
                        "        I ",
                        "        N ",
                        ".ROYCROFT.",
                        "        E ",
                        "        R ",
                        "        . "
                    },new List<string> {
                        "    .    ",
                        "  . M    ",
                        ".ROME.   ",
                        "  L D    ",
                        ".CYCLIST.",
                        "  M E    ",
                        "  P Y    ",
                        "  I .    ",
                        "  C      ",
                        "  .      "
                    }
                };

                case 9208:

                    return new List<List<string>> {

                    new List<string> {
                        "        .   ",
                        "        D   ",
                        "        O   ",
                        "        N   ",
                        "   .    I   ",
                        ".INTERMEZZO.",
                        "   H    E   ",
                        "   E    T   ",
                        "   A    T   ",
                        ".TETRAZZINI.",
                        "   R    .   ",
                        "   E        ",
                        "   .        "
                    },new List<string> {
                        "   .        ",
                        "   T        ",
                        "   H  .     ",
                        "   E  B     ",
                        "   A  I     ",
                        ".TETRAZZINI.",
                        "   R  E     ",
                        ".OPERETTA.  ",
                        "   .  .     "
                    },new List<string> {
                        " .          ",
                        " L .        ",
                        " I T        ",
                        " B H        ",
                        " R E        ",
                        " E A        ",
                        ".TETRAZZINI.",
                        " T R        ",
                        ".OPERETTA.  ",
                        " . .        "
                    },new List<string> {
                        "        .   ",
                        "        D   ",
                        "        O   ",
                        "        N . ",
                        "        I B ",
                        ".INTERMEZZO.",
                        "        E R ",
                        "        T O ",
                        "        T D ",
                        ".TETRAZZINI.",
                        "        . N ",
                        "          . "
                    },new List<string> {
                        "  .        ",
                        "  V        ",
                        "  A        ",
                        "  L        ",
                        ".DONIZETTI.",
                        "  I        ",
                        "  S        ",
                        "  .        "
                    },new List<string> {
                        "      . ",
                        "      V ",
                        "      A ",
                        "      L ",
                        "      O ",
                        "      I ",
                        ".CHORUS.",
                        "      . "
                    },new List<string> {
                        " .      ",
                        " U      ",
                        " L      ",
                        " A      ",
                        " N      ",
                        " O      ",
                        ".VALOIS.",
                        " A      ",
                        " .      "
                    },new List<string> {
                        "    .    ",
                        "    M  . ",
                        "    A  A ",
                        " .SINGER.",
                        "    O  I ",
                        ".ULANOVA.",
                        "    .  . "
                    },new List<string> {
                        "  .    ",
                        ".DUETS.",
                        "  L    ",
                        "  A    ",
                        "  N    ",
                        "  O    ",
                        "  V    ",
                        "  A    ",
                        "  .    "
                    },new List<string> {
                        " .    ",
                        " D    ",
                        " U    ",
                        " E    ",
                        ".TUTU.",
                        " S    ",
                        " .    "
                    },new List<string> {
                        "   .  ",
                        ".TUTU.",
                        "   R  ",
                        "   I  ",
                        "   O  ",
                        "   .  "
                    },new List<string> {
                        " .     ",
                        " C     ",
                        " A     ",
                        " R     ",
                        ".MANON.",
                        " E     ",
                        " N     ",
                        " .     "
                    }
                };

                case 9209:

                    return new List<List<string>> {

                    new List<string> {
                        "   . .   ",
                        "   R F   ",
                        ".UNIFORM.",
                        "   F R   ",
                        "   L A   ",
                        ".ENEMY.  ",
                        "   . .   "
                    },new List<string> {
                        "    . .   ",
                        "    T R   ",
                        "    U I   ",
                        "    R.F   ",
                        ".PATROL.  ",
                        "   .ENEMY.",
                        ".SMUTS.   ",
                        "    .E    ",
                        "     T    ",
                        "     .    "
                    },new List<string> {
                        "    .   ",
                        "    T   ",
                        "    U   ",
                        "  . R   ",
                        ".PATROL.",
                        "  R E   ",
                        ".SMUTS. ",
                        "  O .   ",
                        "  U     ",
                        "  R     ",
                        "  .     "
                    },new List<string> {
                        " .      ",
                        " F      ",
                        " O      ",
                        " R      ",
                        ".TURRET.",
                        " .      "
                    },new List<string> {
                        "    .  ",
                        ".FORAY.",
                        "    L  ",
                        "    A  ",
                        "    M  ",
                        "    O  ",
                        "    .  "
                    },new List<string> {
                        "      .    ",
                        "    ..F    ",
                        " .ALAMO.   ",
                        "   .CORPS. ",
                        "   .TNT.   ",
                        ".DIVISIONS.",
                        "    O.F    ",
                        "    N Y    ",
                        "    . .    "
                    },new List<string> {
                        "       . ",
                        "     . F ",
                        "     A O ",
                        "     C R ",
                        "    .TNT.",
                        "     I I ",
                        "     O F ",
                        ".ALLENBY.",
                        "     . . "
                    },new List<string> {
                        "     . ",
                        "     C ",
                        "     O ",
                        "     R ",
                        "     P ",
                        ".YPRES.",
                        "     . "
                    },new List<string> {
                        " .     ",
                        " A     ",
                        " R     ",
                        " M     ",
                        ".YPRES.",
                        " .     "
                    },new List<string> {
                        "         . ",
                        ".DIVISIONS.",
                        "         L ",
                        "         I ",
                        "         M ",
                        "         . "
                    },new List<string> {
                        "     .      ",
                        "  .  A      ",
                        "  M  C      ",
                        "  E  T      ",
                        " .DIVISIONS.",
                        "  A  O      ",
                        ".ALLENBY.   ",
                        "  .  .      "
                    },new List<string> {
                        "      . ",
                        "      B ",
                        ".ARMOUR.",
                        "      E ",
                        "      N ",
                        "      . "
                    }
                };

                case 9210:

                    return new List<List<string>> {

                    new List<string> {
                        "     . ",
                        "     B ",
                        "   . R ",
                        "   M A ",
                        ".SPAIN.",
                        "   N D ",
                        ".FIZZY.",
                        "   A . ",
                        "   N   ",
                        "   I   ",
                        "   L   ",
                        "   L   ",
                        "   A   ",
                        "   .   "
                    },new List<string> {
                        "   .    ",
                        "   M    ",
                        "   A    ",
                        " . N    ",
                        ".FIZZY. ",
                        " R A    ",
                        " A N    ",
                        " N I    ",
                        ".CELLAR.",
                        " E L    ",
                        " . A    ",
                        "   .    "
                    },new List<string> {
                        "     .      ",
                        "     T      ",
                        "     O.     ",
                        ".CELLAR.    ",
                        "    .SHERRY.",
                        "  .ASTI.    ",
                        "     .N     ",
                        "      E     ",
                        "      .     "
                    },new List<string> {
                        "   . ",
                        "   S ",
                        "   H ",
                        "   E ",
                        "   R ",
                        "   R ",
                        ".DRY.",
                        "   . "
                    },new List<string> {
                        " .     ",
                        ".TOAST.",
                        " A     ",
                        " S     ",
                        " T     ",
                        " E     ",
                        " .     "
                    },new List<string> {
                        "      . ",
                        "      T ",
                        "    . A ",
                        "    M S ",
                        " .VAULT.",
                        "    L E ",
                        ".STILL. ",
                        "    .   "
                    },new List<string> {
                        "    . ",
                        "  . S ",
                        " .VAT.",
                        "  A I ",
                        ".MULL.",
                        "  L L ",
                        "  T . ",
                        "  .   "
                    },new List<string> {
                        "  . .   ",
                        "  R D   ",
                        ".SHERRY.",
                        "  I E   ",
                        " .NEGUS.",
                        "  E S   ",
                        "  . .   "
                    },new List<string> {
                        "  .   ",
                        ".ASTI.",
                        "  E   ",
                        "  C   ",
                        "  .   "
                    },new List<string> {
                        "     . ",
                        ".PRESS.",
                        "     P ",
                        "     A ",
                        "     I ",
                        "     N ",
                        "     . "
                    },new List<string> {
                        " .    ",
                        ".PORT.",
                        " R    ",
                        " E    ",
                        " S    ",
                        " S    ",
                        " .    "
                    },new List<string> {
                        "    .    ",
                        "  .SWEET.",
                        "  B I    ",
                        ".DRINK.  ",
                        "  A E    ",
                        "  N .    ",
                        "  D      ",
                        "  Y      ",
                        "  .      "
                    },new List<string> {
                        "   . ",
                        "   M ",
                        "   A ",
                        "   R ",
                        ".SEC.",
                        "   . "
                    }
                };

                case 9211:

                    return new List<List<string>> {

                    new List<string> {
                        "     . ",
                        "     S ",
                        " .   C ",
                        " F   H ",
                        " E   N ",
                        ".LAIKA.",
                        " I   U ",
                        ".SPITZ.",
                        " .   E ",
                        "     R ",
                        "     . "
                    },new List<string> {
                        "    . .     ",
                        "    F L     ",
                        "    L A     ",
                        ".SALUKI.    ",
                        "    S K     ",
                        " .SCHNAUZER.",
                        "    . .     "
                    },new List<string> {
                        "  . .      ",
                        ".SCHNAUZER.",
                        "  R A      ",
                        ".COON.     ",
                        "  F A      ",
                        "  T .      ",
                        "  S        ",
                        "  .        "
                    },new List<string> {
                        "   .      ",
                        "   C      ",
                        "   R      ",
                        "   O      ",
                        "   F.     ",
                        ".CATS.    ",
                        "  .SPHYNX.",
                        "   .A     ",
                        "    N     ",
                        "    I     ",
                        "    E     ",
                        "    L     ",
                        "    .     "
                    },new List<string> {
                        "      . ",
                        "    . M ",
                        "  .ASTA.",
                        "    K N ",
                        ".SPHYNX.",
                        "    E . ",
                        "    .   "
                    },new List<string> {
                        "  . .       ",
                        "  C F       ",
                        "  L L       ",
                        ".SALUKI.    ",
                        "  W S       ",
                        " .SCHNAUZER.",
                        "  . .       "
                    },new List<string> {
                        " .  .  ",
                        ".CATS. ",
                        " H  P  ",
                        " O  A  ",
                        ".WHINE.",
                        " .  I  ",
                        "    E  ",
                        "    L  ",
                        "    .  "
                    },new List<string> {
                        "         . ",
                        "         B ",
                        "         O ",
                        "         X ",
                        "         E ",
                        ".SCHNAUZER.",
                        "         . "
                    },new List<string> {
                        "  .    ",
                        ".WHINE.",
                        "  A    ",
                        "  I    ",
                        "  R    ",
                        "  .    "
                    },new List<string> {
                        " .      ",
                        " S      ",
                        " P      ",
                        " A      ",
                        " N      ",
                        " I      ",
                        " E      ",
                        ".LASSIE.",
                        " .      "
                    },new List<string> {
                        "         . ",
                        "         L ",
                        "       . A ",
                        "       K S ",
                        "     .DOGS.",
                        "       R I ",
                        "       A E ",
                        ".MACAVITY. ",
                        "       .   "
                    }
                };

                case 9212:

                    return new List<List<string>> {

                    new List<string> {
                        "     .    ",
                        "   . B    ",
                        " .BEAR.   ",
                        "   S E    ",
                        "   K E    ",
                        ".BLIZZARD.",
                        "   M E    ",
                        "   O .    ",
                        "   S      ",
                        "   .      "
                    },new List<string> {
                        "       .   ",
                        "       W   ",
                        "       A   ",
                        "       L   ",
                        "      .R   ",
                        "     .FURS.",
                        ".ESKIMOS.  ",
                        "      X.   ",
                        "      .    "
                    },new List<string> {
                        "    .   ",
                        ".NORWAY.",
                        "    A   ",
                        "    L   ",
                        "    R   ",
                        "    U   ",
                        "    S   ",
                        "    .   "
                    },new List<string> {
                        "      . ",
                        "      K ",
                        "      A ",
                        ".NORWAY.",
                        "      A ",
                        "      K ",
                        "      . "
                    },new List<string> {
                        " .      ",
                        " T      ",
                        " E  .   ",
                        ".NORWAY.",
                        " T  A   ",
                        " .OWL.  ",
                        "    R   ",
                        "    U   ",
                        "    S   ",
                        "    .   "
                    },new List<string> {
                        " .   .    ",
                        ".NUNATAKS.",
                        " A   E    ",
                        " N   N    ",
                        ".SCOTT.   ",
                        " E   .    ",
                        " N        ",
                        " .        "
                    },new List<string> {
                        " .    ",
                        " F    ",
                        " U    ",
                        " R    ",
                        ".SNOW.",
                        " .    "
                    },new List<string> {
                        " . .      ",
                        ".BREEZE.  ",
                        " A R      ",
                        ".SOMERSET.",
                        " E I      ",
                        " . N      ",
                        "   E      ",
                        "   .      "
                    },new List<string> {
                        "        . ",
                        "        A ",
                        ".SOMERSET.",
                        "        L ",
                        "        A ",
                        "        S ",
                        "        . "
                    },new List<string> {
                        "    .   ",
                        "    A   ",
                        "    T   ",
                        "    L   ",
                        "    A   ",
                        ".MOSSES.",
                        "    .   "
                    },new List<string> {
                        "      . ",
                        "      D ",
                        "      O ",
                        "      G ",
                        ".MOSSES.",
                        "      . "
                    },new List<string> {
                        "   .   ",
                        "   N   ",
                        ".SCOTT.",
                        "   M   ",
                        "   E   ",
                        "   .   "
                    },new List<string> {
                        "      . ",
                        "      I ",
                        "      C ",
                        ".ERMINE.",
                        "      . "
                    }
                };

                case 9301:

                    return new List<List<string>> {

                    new List<string> {
                        "    .     ",
                        "    B     ",
                        "    R .   ",
                        "    A C   ",
                        ".SALZBURG.",
                        "    I S   ",
                        "    L T   ",
                        "    .BOAT.",
                        "      M   ",
                        "      S   ",
                        "      .   "
                    },new List<string> {
                        "      .   ",
                        "      C . ",
                        ".SALZBURG.",
                        "      S I ",
                        "      T F ",
                        "    .BOAT.",
                        "      M . ",
                        "      S   ",
                        "      .   "
                    },new List<string> {
                        "       . ",
                        "       A ",
                        ".CUSTOMS.",
                        "       I ",
                        "       A ",
                        "       . "
                    },new List<string> {
                        " .        ",
                        ".SALZBURG.",
                        " H        ",
                        " I        ",
                        " P        ",
                        " .        "
                    },new List<string> {
                        "   .  ",
                        "   S  ",
                        "   H  ",
                        ".TRIP.",
                        "   P  ",
                        "   .  "
                    },new List<string> {
                        "  .  . ",
                        ".ITALY.",
                        "  R  A ",
                        "  I  C ",
                        "  P  H ",
                        "  .JET.",
                        "     . "
                    },new List<string> {
                        "  .       ",
                        "  C       ",
                        "  H       ",
                        "  I       ",
                        "  N       ",
                        ".SALZBURG.",
                        "  .       "
                    },new List<string> {
                        "   .   ",
                        "   B   ",
                        "   A   ",
                        "   L   ",
                        ".CHINA.",
                        "   .   "
                    },new List<string> {
                        "  .  ",
                        "  B  ",
                        ".CAR.",
                        "  L  ",
                        "  I  ",
                        "  .  "
                    },new List<string> {
                        " .      ",
                        ".BRAZIL.",
                        " U      ",
                        " S      ",
                        " .      "
                    },new List<string> {
                        "   . ",
                        "   T ",
                        "   I ",
                        "   C ",
                        "   K ",
                        "   E ",
                        "   T ",
                        ".BUS.",
                        "   . "
                    },new List<string> {
                        "     .    ",
                        "     A    ",
                        "     T    ",
                        "   . H    ",
                        ".TICKETS. ",
                        "   A N    ",
                        "  .BOSTON.",
                        "   . .    "
                    },new List<string> {
                        "     . ",
                        "     A ",
                        ".EGYPT.",
                        "     H ",
                        "     E ",
                        "     N ",
                        "     S ",
                        "     . "
                    },new List<string> {
                        " . .   ",
                        " V N   ",
                        " O O   ",
                        ".YORK. ",
                        " A W   ",
                        " G A   ",
                        ".EGYPT.",
                        " . .   "
                    },new List<string> {
                        " . .    ",
                        ".VENICE.",
                        " O O    ",
                        ".YORK.  ",
                        " A W    ",
                        " G A    ",
                        " E Y    ",
                        " . .    "
                    },new List<string> {
                        " .   ",
                        ".TAX.",
                        " I   ",
                        " C   ",
                        " K   ",
                        " E   ",
                        " T   ",
                        " S   ",
                        " .   "
                    }
                };

                case 9302:

                    return new List<List<string>> {

                    new List<string> {
                        "    .    ",
                        "    A    ",
                        "    M    ",
                        "    A    ",
                        ".KUNZITE.",
                        "    O    ",
                        "    N    ",
                        "    I    ",
                        "    T    ",
                        "    E    ",
                        "    .    "
                    },new List<string> {
                        "        .    ",
                        "      . F    ",
                        "      A I    ",
                        "     .GARNET.",
                        "      A E    ",
                        ".KUNZITE.    ",
                        "      E      ",
                        "      .      "
                    },new List<string> {
                        " .        ",
                        " G        ",
                        " A        ",
                        " R        ",
                        " N        ",
                        " E        ",
                        ".TRINKETS.",
                        " .        "
                    },new List<string> {
                        "      .   ",
                        "      B   ",
                        "    . U   ",
                        "    C C   ",
                        "  .LOCKET.",
                        "    I L   ",
                        ".TRINKETS.",
                        "    . .   "
                    },new List<string> {
                        "      . ",
                        "      A ",
                        "      M ",
                        "      E ",
                        "    . T ",
                        "    B H ",
                        "  .RUBY.",
                        "    C S ",
                        ".LOCKET.",
                        "    L . ",
                        "    E   ",
                        "    .   "
                    },new List<string> {
                        "  .      ",
                        "  B      ",
                        "  E      ",
                        "  A      ",
                        ".KUNZITE.",
                        "  T      ",
                        "  Y      ",
                        "  .      "
                    },new List<string> {
                        "      . ",
                        "      R ",
                        "      A ",
                        "      R ",
                        "      I ",
                        "      T ",
                        ".BEAUTY.",
                        "      . "
                    },new List<string> {
                        "   .    ",
                        " . C    ",
                        " C A    ",
                        ".RARITY.",
                        " O A    ",
                        ".WATCH. ",
                        " N .    ",
                        " .      "
                    },new List<string> {
                        "  .     ",
                        "  P     ",
                        "  Y     ",
                        "  R     ",
                        "  O     ",
                        "  P     ",
                        ".BEAUTY.",
                        "  .     "
                    },new List<string> {
                        "   .  ",
                        "   P  ",
                        ".ONYX.",
                        "   R  ",
                        "   O  ",
                        "   P  ",
                        "   E  ",
                        "   .  "
                    },new List<string> {
                        " .    ",
                        " C    ",
                        ".ONYX.",
                        " R    ",
                        " A    ",
                        " L    ",
                        " .    "
                    }
                };

                case 9303:

                    return new List<List<string>> {

                    new List<string> {
                        "    .     ",
                        "    S     ",
                        "    E     ",
                        "    C .   ",
                        ".ANNUITY. ",
                        "    R R   ",
                        "    I A   ",
                        "    T D   ",
                        "   .YIELD.",
                        "    . .   "
                    },new List<string> {
                        "       .  ",
                        "       S  ",
                        "    .  A  ",
                        " .PISTOLE.",
                        "    E  A  ",
                        "    C  R  ",
                        ".ANNUITY. ",
                        "    R  .  ",
                        "    I     ",
                        "    T     ",
                        "    Y     ",
                        "    .     "
                    },new List<string> {
                        "   .      ",
                        "   P      ",
                        "   E      ",
                        "  .N      ",
                        " .ANNUITY.",
                        ".BUY.     ",
                        "  D.      ",
                        "  I       ",
                        "  T       ",
                        "  .       "
                    },new List<string> {
                        " . .    ",
                        " P P    ",
                        " O I    ",
                        " U S    ",
                        ".NET.   ",
                        " D O    ",
                        ".SALARY.",
                        " . E    ",
                        "   .    "
                    },new List<string> {
                        "      .   ",
                        "      L . ",
                        ".SECURITY.",
                        "      R I ",
                        "   .TRADE.",
                        "      . L ",
                        "        D ",
                        "        . "
                    },new List<string> {
                        "    .  ",
                        "    A  ",
                        "  .BUY.",
                        "  S D  ",
                        "  O I  ",
                        ".QUOTE.",
                        "  . .  "
                    },new List<string> {
                        " .   ",
                        " B   ",
                        " O   ",
                        " N   ",
                        " U   ",
                        ".SOU.",
                        " .   "
                    },new List<string> {
                        " .     ",
                        " R .   ",
                        " U B   ",
                        ".PROXY.",
                        " E N   ",
                        ".ECU.  ",
                        " . S   ",
                        "   .   "
                    },new List<string> {
                        "     . ",
                        "     P ",
                        "     A ",
                        ".PROXY.",
                        "     . "
                    },new List<string> {
                        "     .     ",
                        ".DINERO.   ",
                        "     U B   ",
                        "    .PROXY.",
                        "     E N   ",
                        "     E U   ",
                        "     . S   ",
                        "       .   "
                    },new List<string> {
                        "    .  ",
                        "    R  ",
                        "    O  ",
                        "    U  ",
                        "    B  ",
                        "    L  ",
                        ".RUPEE.",
                        "    .  "
                    },new List<string> {
                        " .      ",
                        " M .    ",
                        " A D    ",
                        ".ROUBLE.",
                        " G C    ",
                        " I A    ",
                        ".NOTES. ",
                        " . .    "
                    },new List<string> {
                        "     . ",
                        "     A ",
                        "     I ",
                        ".YIELD.",
                        "     . "
                    }
                };

                case 9304:

                    return new List<List<string>> {

                    new List<string> {
                        "      .    ",
                        "      K    ",
                        "      I    ",
                        "      L    ",
                        "      O    ",
                        "      H    ",
                        "      E    ",
                        "      R.   ",
                        "     .TROY.",
                        ".OUTSIZE.  ",
                        "      .A   ",
                        "       M   ",
                        "       .   "
                    },new List<string> {
                        "  . .  ",
                        ".TROY. ",
                        "  E A  ",
                        " .ACRE.",
                        "  M D  ",
                        "  . .  "
                    },new List<string> {
                        "   .       ",
                        "   B       ",
                        " . U       ",
                        " C S       ",
                        " A.H.      ",
                        ".STEP.     ",
                        ".KILOHERTZ.",
                        " .E.C      ",
                        "  R K      ",
                        "  C E      ",
                        "  E T      ",
                        "  . .      "
                    },new List<string> {
                        "  . .      ",
                        "  T P      ",
                        ".KILOHERTZ.",
                        "  E C      ",
                        "  R K      ",
                        "  C E      ",
                        ".FEET.     ",
                        "  . .      "
                    },new List<string> {
                        "    .      ",
                        "    P .    ",
                        ".KILOHERTZ.",
                        "    C R    ",
                        "   .KEG.   ",
                        "    E .    ",
                        "    T      ",
                        "    .      "
                    },new List<string> {
                        "   . .   ",
                        "   B D   ",
                        " .QUARTO.",
                        "   S A   ",
                        "   H M   ",
                        ".STEP.   ",
                        "   L     ",
                        "   .     "
                    },new List<string> {
                        "      . ",
                        "      P ",
                        ".QUARTO.",
                        "      L ",
                        "      E ",
                        "      . "
                    },new List<string> {
                        " .     ",
                        ".PROOF.",
                        " O     ",
                        " L     ",
                        " E     ",
                        " .     "
                    },new List<string> {
                        " .    ",
                        " P    ",
                        " R    ",
                        " O    ",
                        " O    ",
                        ".FOOT.",
                        " .    "
                    },new List<string> {
                        "   .      ",
                        ".FOOT.    ",
                        "   H P    ",
                        "  .MOIETY.",
                        "   . N    ",
                        "     T    ",
                        "     .    "
                    },new List<string> {
                        "  .   ",
                        "  M . ",
                        "  O S ",
                        "  I T ",
                        "  E.O ",
                        " .TUN.",
                        ".DYNE.",
                        "  .I. ",
                        "   T  ",
                        "   .  "
                    },new List<string> {
                        "   .  ",
                        "   U  ",
                        "   N  ",
                        "   I  ",
                        ".WATT.",
                        "   .  "
                    }
                };

                case 9305:

                    return new List<List<string>> {

                    new List<string> {
                        "      . ",
                        "      B ",
                        "      R ",
                        "      A ",
                        ".SPRITZ.",
                        "      I ",
                        "      L ",
                        "      . "
                    },new List<string> {
                        " .      ",
                        " P      ",
                        " I      ",
                        " E      ",
                        ".SPRITZ.",
                        " .      "
                    },new List<string> {
                        "    .     ",
                        "    G.    ",
                        ".SYRUP.   ",
                        "   .MINTS.",
                        ".RUSSE.   ",
                        "    .S    ",
                        "     .    "
                    },new List<string> {
                        "  .    ",
                        "  T    ",
                        "  A    ",
                        "  F    ",
                        "  F    ",
                        ".SYRUP.",
                        "  .    "
                    },new List<string> {
                        "    .  ",
                        " .  G  ",
                        ".SYRUP.",
                        " O  M  ",
                        ".RUSSE.",
                        " B  .  ",
                        " E     ",
                        " T     ",
                        " .     "
                    },new List<string> {
                        "  .      ",
                        "  P .    ",
                        ".MINTS.  ",
                        "  E O    ",
                        " .SPRITZ.",
                        "  . T    ",
                        "    E    ",
                        "    .    "
                    },new List<string> {
                        "      . ",
                        ".SORBET.",
                        "      R ",
                        "      U ",
                        "      F ",
                        "      F ",
                        "      L ",
                        "      E ",
                        "      S ",
                        "      . "
                    },new List<string> {
                        "    . ",
                        "    M ",
                        "    I ",
                        "    N ",
                        "    T ",
                        ".NUTS.",
                        "    . "
                    },new List<string> {
                        " .    ",
                        " S    ",
                        " I    ",
                        " M    ",
                        ".NUTS.",
                        " E    ",
                        " L    ",
                        " .    "
                    },new List<string> {
                        "  .    ",
                        "  B    ",
                        ".TAFFY.",
                        "  R    ",
                        "  S    ",
                        "  .    "
                    },new List<string> {
                        "     . ",
                        "     B ",
                        "     A ",
                        "     R ",
                        ".FLOSS.",
                        "     . "
                    },new List<string> {
                        " .      ",
                        " F      ",
                        " L      ",
                        " O      ",
                        ".SWEETS.",
                        " S      ",
                        " .      "
                    },new List<string> {
                        " .      ",
                        " P    . ",
                        " A    S ",
                        " S    W ",
                        ".TRIFLE.",
                        " R    E ",
                        ".YOGURT.",
                        " .    S ",
                        "      . "
                    },new List<string> {
                        " .      ",
                        " P      ",
                        " A      ",
                        " S  .   ",
                        ".TRIFLE.",
                        " R  R   ",
                        ".YOGURT.",
                        " .  I   ",
                        "    T   ",
                        "    .   "
                    },new List<string> {
                        "    .  ",
                        "    F  ",
                        "    R  ",
                        "    U  ",
                        "    I  ",
                        ".TARTS.",
                        "    .  "
                    },new List<string> {
                        "  .    ",
                        "  P    ",
                        "  E    ",
                        "  E    ",
                        ".FLOSS.",
                        "  .    "
                    },new List<string> {
                        "    .  ",
                        ".DROPS.",
                        "    E  ",
                        "    E  ",
                        "    L  ",
                        "    .  "
                    }
                };

                case 9306:

                    return new List<List<string>> {

                    new List<string> {
                        "   .   .   ",
                        ".BUZZARDET.",
                        "   E   A   ",
                        "   U   Y   ",
                        "   G   F   ",
                        "   L   L   ",
                        " .BOTFLY.  ",
                        "   P   .   ",
                        "   T       ",
                        "   E       ",
                        "   R       ",
                        "   A       ",
                        "   .       "
                    },new List<string> {
                        "       . .  ",
                        ".BUZZARDET. ",
                        "       A A  ",
                        "    .MAYBUG.",
                        "       F .  ",
                        "       L    ",
                        "       Y    ",
                        "       .    "
                    },new List<string> {
                        "   .       ",
                        "   Z       ",
                        "   E       ",
                        "   U       ",
                        "   G       ",
                        "   L       ",
                        "   O       ",
                        "   P    .  ",
                        "  .TERMITE.",
                        "   E    H  ",
                        ".ZORAPTERA.",
                        "   A    I  ",
                        "   .    P  ",
                        "        S  ",
                        "        .  "
                    },new List<string> {
                        "    .    ",
                        ".EPIZOON.",
                        "    O    ",
                        "    R    ",
                        "    A    ",
                        "    P    ",
                        "    T    ",
                        "    E    ",
                        "    R    ",
                        "    A    ",
                        "    .    "
                    },new List<string> {
                        "        .  ",
                        "        T  ",
                        "      . H  ",
                        ".ZORAPTERA.",
                        "      S I  ",
                        "      E P  ",
                        "  .MANTIS. ",
                        "      S .  ",
                        "      E    ",
                        "      .    "
                    },new List<string> {
                        "      . ",
                        "    . D ",
                        "    M I ",
                        "  .WASP.",
                        "    N T ",
                        ".TSETSE.",
                        "    I R ",
                        "    S A ",
                        "    . N ",
                        "      S ",
                        "      . "
                    },new List<string> {
                        "         . ",
                        "         A ",
                        "         P ",
                        "         H ",
                        "         I ",
                        ".DIPTERANS.",
                        "         . "
                    },new List<string> {
                        "     .  ",
                        ".DAYFLY.",
                        "     E  ",
                        "     M  ",
                        "     A  ",
                        "     .  "
                    },new List<string> {
                        " .    ",
                        " L    ",
                        " E    ",
                        ".MITE.",
                        " A    ",
                        " .    "
                    },new List<string> {
                        " .         ",
                        ".BUZZARDET.",
                        " O         ",
                        " R         ",
                        " E         ",
                        " R         ",
                        " .         "
                    }
                };

                case 9307:

                    return new List<List<string>> {

                    new List<string> {
                        "    .       ",
                        "    T .     ",
                        "    A B     ",
                        "    N E     ",
                        ".BRAZIL.    ",
                        "    A I     ",
                        " .VENEZUELA.",
                        "    I E     ",
                        "    A .     ",
                        "    .       "
                    },new List<string> {
                        "  .     ",
                        "  Q .   ",
                        ".MALTA. ",
                        "  T A   ",
                        "  A N   ",
                        ".BRAZIL.",
                        "  . A   ",
                        "    N   ",
                        "    I   ",
                        "    A   ",
                        "    .   "
                    },new List<string> {
                        "    .     ",
                        "  .BELIZE.",
                        "  P G     ",
                        ".KENYA.   ",
                        "  R P     ",
                        "  U T     ",
                        "  . .     "
                    },new List<string> {
                        "   . . ",
                        "   K A ",
                        " .PERU.",
                        "   N S ",
                        ".EGYPT.",
                        "   A R ",
                        "   . I ",
                        "     A ",
                        "     . "
                    },new List<string> {
                        "        . ",
                        "        S ",
                        "        U ",
                        "        D ",
                        ".TANZANIA.",
                        "        N ",
                        "        . "
                    },new List<string> {
                        " .       ",
                        " S       ",
                        ".URUGUAY.",
                        " D       ",
                        " A       ",
                        " N       ",
                        " .       "
                    },new List<string> {
                        "       . ",
                        "       S ",
                        ".URUGUAY.",
                        "       R ",
                        "       I ",
                        "       A ",
                        "       . "
                    },new List<string> {
                        "   .     ",
                        "   C     ",
                        ".URUGUAY.",
                        "   B     ",
                        "   A     ",
                        "   .     "
                    },new List<string> {
                        "     .   ",
                        "     T   ",
                        ".URUGUAY.",
                        "     R   ",
                        "     K   ",
                        "     E   ",
                        "     Y   ",
                        "     .   "
                    },new List<string> {
                        "      . ",
                        "      L ",
                        "      I ",
                        "      B ",
                        ".TURKEY.",
                        "      A ",
                        "      . "
                    },new List<string> {
                        "   .   ",
                        " .FIJI.",
                        " L R   ",
                        ".ITALY.",
                        " B Q   ",
                        " Y .   ",
                        " A     ",
                        " .     "
                    },new List<string> {
                        " .     ",
                        " L   . ",
                        ".ITALY.",
                        " B   E ",
                        " Y   M ",
                        " A   E ",
                        " .IRAN.",
                        "     . "
                    }
                };

                case 9308:

                    return new List<List<string>> {

                    new List<string> {
                        "         .   ",
                        "       . C   ",
                        "       R E   ",
                        ".VELAZQUEZ.  ",
                        "       B A   ",
                        "      .ERNST.",
                        "       N N   ",
                        "       S E   ",
                        "       . .   "
                    },new List<string> {
                        "     .     ",
                        "     G     ",
                        "     R     ",
                        "     E     ",
                        "     U     ",
                        ".VELAZQUEZ.",
                        "     E     ",
                        "     .     "
                    },new List<string> {
                        "      .        ",
                        "      H        ",
                        "      E        ",
                        "      Y        ",
                        "     .D        ",
                        "    .VELAZQUEZ.",
                        ".WEYDEN.       ",
                        "     R.        ",
                        "     N         ",
                        "     E         ",
                        "     T         ",
                        "     .         "
                    },new List<string> {
                        "      . ",
                        "      H ",
                        "      E ",
                        ".ROMNEY.",
                        "      D ",
                        "      E ",
                        "      N ",
                        "      . "
                    },new List<string> {
                        "   .    ",
                        "   E    ",
                        ".WEYDEN.",
                        "   C    ",
                        "   K    ",
                        "   .    "
                    },new List<string> {
                        "  .   . ",
                        " .WATTS.",
                        "  E   C ",
                        "  Y   O ",
                        "  D   T ",
                        ".VERNET.",
                        "  N   . ",
                        "  .     "
                    },new List<string> {
                        "     . . ",
                        "     R D ",
                        "   .LELY.",
                        "     D C ",
                        "     O K ",
                        ".RUBENS. ",
                        "     .   "
                    },new List<string> {
                        "     . . ",
                        " .RUBENS.",
                        "     R T ",
                        ".CEZANNE.",
                        "     S E ",
                        "     T R ",
                        "     . . "
                    },new List<string> {
                        "     . ",
                        "     S ",
                        "     A ",
                        "     R ",
                        "     G ",
                        "     E ",
                        "     N ",
                        ".ERNST.",
                        "     . "
                    },new List<string> {
                        " .       ",
                        " H       ",
                        " A       ",
                        " L       ",
                        ".SARGENT.",
                        " .       "
                    },new List<string> {
                        "  .     ",
                        "  B     ",
                        ".GREUZE.",
                        "  I     ",
                        "  L     ",
                        "  .     "
                    },new List<string> {
                        " .      ",
                        " H      ",
                        " O      ",
                        " O      ",
                        " C      ",
                        ".HEYDEN.",
                        " .      "
                    }
                };

                case 9309:

                    return new List<List<string>> {

                    new List<string> {
                        "      . .   ",
                        ".PASSAMEZZO.",
                        "      I A   ",
                        "      N P   ",
                        "    .HULA.  ",
                        "      E T   ",
                        "      T E   ",
                        "      . A   ",
                        "        D   ",
                        "        O   ",
                        "        .   "
                    },new List<string> {
                        " . .        ",
                        ".PASSAMEZZO.",
                        " I T        ",
                        ".REEL.      ",
                        " O P        ",
                        " U .        ",
                        " E          ",
                        " T          ",
                        " T          ",
                        " E          ",
                        " .          "
                    },new List<string> {
                        "        .    ",
                        ".PIROUETTE.  ",
                        "        A V  ",
                        "     .CANCAN.",
                        "        G L  ",
                        "        O S  ",
                        "        . E  ",
                        "          .  "
                    },new List<string> {
                        "   .    ",
                        "   C    ",
                        "   A    ",
                        "   N    ",
                        "  .C    ",
                        " .VALSE.",
                        ".FAN.   ",
                        "  L.    ",
                        "  E     ",
                        "  T     ",
                        "  A     ",
                        "  .     "
                    },new List<string> {
                        "    .  ",
                        "    P  ",
                        "    O  ",
                        " .  U  ",
                        ".VALSE.",
                        " A  S  ",
                        " L  E  ",
                        " E  T  ",
                        ".TROT. ",
                        " A  E  ",
                        " .  .  "
                    },new List<string> {
                        "       .   ",
                        "     . B   ",
                        ".ZAPATEADO.",
                        "     A L   ",
                        "    .POLKA.",
                        "     . .   "
                    },new List<string> {
                        "       . . ",
                        "       B J ",
                        ".ZAPATEADO.",
                        "       L T ",
                        "    .POLKA.",
                        "       . . "
                    },new List<string> {
                        " .       ",
                        " J       ",
                        " O       ",
                        ".TWOSTEP.",
                        " A       ",
                        " .       "
                    },new List<string> {
                        "     . ",
                        "     T ",
                        "     W ",
                        "     O ",
                        "     S ",
                        ".TWIST.",
                        "     E ",
                        "     P ",
                        "     . "
                    },new List<string> {
                        "   .       ",
                        ".ZAPATEADO.",
                        "   A       ",
                        "   S       ",
                        "   .       "
                    },new List<string> {
                        "   .     ",
                        "   H     ",
                        ".TWOSTEP.",
                        "   P     ",
                        "   .     "
                    },new List<string> {
                        "   .   ",
                        "   J   ",
                        ".TWIST.",
                        "   V   ",
                        "   E   ",
                        "   .   "
                    }
                };

                case 9310:

                    return new List<List<string>> {

                    new List<string> {
                        "     .     ",
                        "     R     ",
                        "     O     ",
                        "     D     ",
                        "     R     ",
                        "     I     ",
                        "     G     ",
                        "     U     ",
                        "     E     ",
                        ".DONIZETTI.",
                        "     .     "
                    },new List<string> {
                        "       .   ",
                        "       M   ",
                        "       O   ",
                        ".RODRIGUEZ.",
                        "       S   ",
                        "       S   ",
                        "       O   ",
                        "       R   ",
                        "       G   ",
                        "       S   ",
                        "       K   ",
                        "       Y   ",
                        "       .   "
                    },new List<string> {
                        "         .   ",
                        "         S . ",
                        "         T D ",
                        "         R E ",
                        "         A B ",
                        "         V U ",
                        "     .DELIUS.",
                        "         N S ",
                        ".MOUSSORGSKY.",
                        "         K . ",
                        "         Y   ",
                        "         .   "
                    },new List<string> {
                        "      .  ",
                        ".STRAUSS.",
                        "      T  ",
                        "      R  ",
                        "      A  ",
                        "      V  ",
                        "      I  ",
                        "      N  ",
                        "      S  ",
                        "      K  ",
                        "      Y  ",
                        "      .  "
                    },new List<string> {
                        "         .      ",
                        "       .STRAUSS.",
                        "       R O      ",
                        ".SZYMANOWSKI.   ",
                        "       D T      ",
                        "       R I      ",
                        "       I .      ",
                        "       G        ",
                        "       U        ",
                        "       E        ",
                        "       Z        ",
                        "       .        "
                    },new List<string> {
                        " . .         ",
                        ".MARKS.      ",
                        " A A         ",
                        ".SZYMANOWSKI.",
                        " C B         ",
                        " A O         ",
                        " G U         ",
                        " N L         ",
                        " I D         ",
                        " . .         "
                    },new List<string> {
                        " . .         ",
                        " M R         ",
                        " A A         ",
                        ".SZYMANOWSKI.",
                        " C B         ",
                        " A O         ",
                        ".GAUL.       ",
                        " N L         ",
                        " I D         ",
                        " . .         "
                    },new List<string> {
                        "         .   ",
                        "       . T   ",
                        "       R O   ",
                        ".SZYMANOWSKI.",
                        "       D T   ",
                        "    .VERDI.  ",
                        "       I .   ",
                        "       G     ",
                        "       U     ",
                        "       E     ",
                        "       Z     ",
                        "       .     "
                    }
                };

                case 9311:

                    return new List<List<string>> {

                    new List<string> {
                        "    .       ",
                        "    H       ",
                        "  . O       ",
                        " .TARPAULIN.",
                        "  R I       ",
                        ".MIZZENTOP. ",
                        "  C O       ",
                        "  E N       ",
                        "  . .       "
                    },new List<string> {
                        "    .  .    ",
                        "    H  S    ",
                        "    O  C    ",
                        " .TARPAULIN.",
                        "    I  T    ",
                        ".MIZZENTOP. ",
                        "    O  L    ",
                        "    N  E    ",
                        "    .  .    "
                    },new List<string> {
                        "      .  .     ",
                        "     .STOWAWAY.",
                        "      C  I     ",
                        ".TARPAULIN.    ",
                        "      T  D     ",
                        "      T  .     ",
                        "      L        ",
                        "      E        ",
                        "      .        "
                    },new List<string> {
                        "    . ",
                        "    S ",
                        "    T ",
                        "    O ",
                        "    W ",
                        "    A ",
                        "    W ",
                        "    A ",
                        ".BUOY.",
                        "    . "
                    },new List<string> {
                        "      .   ",
                        "  .   C   ",
                        " .AFTER.  ",
                        "  F   E   ",
                        ".STOWAWAY.",
                        "  .   .   "
                    },new List<string> {
                        " .       ",
                        " H       ",
                        " A       ",
                        " T       ",
                        " C       ",
                        ".HORIZON.",
                        " .       "
                    },new List<string> {
                        "    . ",
                        " .  H ",
                        " E  A ",
                        ".MAST.",
                        " B  C ",
                        " A  H ",
                        ".RIG. ",
                        " G    ",
                        " O    ",
                        " .    "
                    },new List<string> {
                        "    .    ",
                        " .ASHORE.",
                        " E  A    ",
                        ".MAST.   ",
                        " B  C    ",
                        " A  H    ",
                        " R  .    ",
                        " G       ",
                        " O       ",
                        " .       "
                    },new List<string> {
                        "  .        ",
                        "  S        ",
                        "  C        ",
                        "  U        ",
                        "  T        ",
                        "  T        ",
                        "  L        ",
                        ".SEAWORTHY.",
                        "  .        "
                    },new List<string> {
                        "     . ",
                        "     S ",
                        "     E ",
                        "     A ",
                        "     W ",
                        "   . O ",
                        "   P R ",
                        ".FLOAT.",
                        "   R H ",
                        ".JETTY.",
                        "   . . "
                    }
                };

                case 9312:

                    return new List<List<string>> {

                    new List<string> {
                        "    .    ",
                        "    R    ",
                        "  . U    ",
                        "  V W    ",
                        "  E E    ",
                        "  S N    ",
                        ".QUIZAPU.",
                        "  V O    ",
                        "  I R    ",
                        ".FUJI.   ",
                        "  S .    ",
                        "  .      "
                    },new List<string> {
                        "     .         ",
                        "     J.        ",
                        ".EREBUS.       ",
                        "    .RUWENZORI.",
                        "  .URAL.       ",
                        "     .A        ",
                        "      I        ",
                        "      M        ",
                        "      A        ",
                        "      N        ",
                        "      .        "
                    },new List<string> {
                        "    .    ",
                        "    R  . ",
                        "    U  I ",
                        "    W  T ",
                        ".PETEROA.",
                        "    N  C ",
                        ".QUIZAPU.",
                        "    O  L ",
                        "    R  O ",
                        "    I  M ",
                        "    .  I ",
                        "       . "
                    },new List<string> {
                        "  .    ",
                        "  I    ",
                        "  T  . ",
                        "  A  B ",
                        " .CAHA.",
                        "  U  R ",
                        "  L  R ",
                        ".ROCKY.",
                        "  M  . ",
                        "  I    ",
                        "  .    "
                    },new List<string> {
                        " .    ",
                        " U    ",
                        ".ROSA.",
                        " A    ",
                        " L    ",
                        " .    "
                    },new List<string> {
                        "   .  ",
                        "   A  ",
                        "   T  ",
                        "   L  ",
                        "   A  ",
                        ".ROSA.",
                        "   .  "
                    },new List<string> {
                        "       . ",
                        "       A ",
                        ".EVEREST.",
                        "       L ",
                        "       A ",
                        "       S ",
                        "       . "
                    },new List<string> {
                        "       . ",
                        "       S ",
                        "       U ",
                        "       L ",
                        "       A ",
                        "       I ",
                        "       M ",
                        "       A ",
                        ".SIMPLON.",
                        "       . "
                    },new List<string> {
                        " .       ",
                        " A       ",
                        " L       ",
                        " P       ",
                        ".SIMPLON.",
                        " .       "
                    },new List<string> {
                        "   .    ",
                        "   I    ",
                        "   T    ",
                        "   A    ",
                        "   C    ",
                        "   U    ",
                        "   L    ",
                        "   O    ",
                        "   M    ",
                        ".OLIVES.",
                        "   .    "
                    },new List<string> {
                        " .       ",
                        " P       ",
                        ".EVEREST.",
                        " L       ",
                        " E       ",
                        " E       ",
                        " .       "
                    }
                };

                case 9401:

                    return new List<List<string>> {

                    new List<string> {
                        "     . .  ",
                        "     B T  ",
                        "     E E  ",
                        ".WALTZING.",
                        "     I N  ",
                        "     Q I  ",
                        "  .SQUASH.",
                        "     E .  ",
                        "     .    "
                    },new List<string> {
                        " .        ",
                        " B        ",
                        " O        ",
                        ".WALTZING.",
                        " L        ",
                        " S        ",
                        " .        "
                    },new List<string> {
                        "  .   . ",
                        "  C   B ",
                        " .RODEO.",
                        "  O   W ",
                        "  Q   L ",
                        ".QUOITS.",
                        "  E   . ",
                        "  T     ",
                        "  .     "
                    },new List<string> {
                        "    . ",
                        "    C ",
                        "    R ",
                        "    O ",
                        "    Q ",
                        "    U ",
                        "    E ",
                        ".TEST.",
                        "    . "
                    },new List<string> {
                        " .     ",
                        " N     ",
                        " E .   ",
                        ".TEST. ",
                        " B K   ",
                        " A A   ",
                        ".LOTTO.",
                        " L I   ",
                        " . N   ",
                        "   G   ",
                        "   .   "
                    },new List<string> {
                        "   .   ",
                        "   S   ",
                        "   K . ",
                        "   A H ",
                        ".LOTTO.",
                        "   I B ",
                        "   N B ",
                        ".RUGBY.",
                        "   . . "
                    },new List<string> {
                        " .      ",
                        ".SQUASH.",
                        " K      ",
                        " I      ",
                        " T      ",
                        " T      ",
                        " L      ",
                        " E      ",
                        " S      ",
                        " .      "
                    },new List<string> {
                        "     .    ",
                        "     D    ",
                        "     A    ",
                        "     R    ",
                        ".SKITTLES.",
                        "     S    ",
                        "     .    "
                    },new List<string> {
                        "        . ",
                        ".SKITTLES.",
                        "        K ",
                        "        I ",
                        "        I ",
                        "        N ",
                        "        G ",
                        "        . "
                    },new List<string> {
                        "   .     ",
                        "   J     ",
                        "   U     ",
                        "   D     ",
                        ".CROQUET.",
                        "   .     "
                    },new List<string> {
                        "   .      ",
                        "   G      ",
                        "   O      ",
                        ".WALTZING.",
                        "   F      ",
                        "   .      "
                    },new List<string> {
                        "    .   ",
                        "    D   ",
                        "    I   ",
                        "    V   ",
                        ".QUOITS.",
                        "    N   ",
                        "    G   ",
                        "    .   "
                    },new List<string> {
                        "      . ",
                        ".SQUASH.",
                        "      O ",
                        "      C ",
                        "      K ",
                        "      E ",
                        "      Y ",
                        "      . "
                    },new List<string> {
                        "    . ",
                        "    H ",
                        "    O ",
                        "    C ",
                        "    K ",
                        "    E ",
                        ".PLAY.",
                        "    . "
                    },new List<string> {
                        "  .   ",
                        "  B   ",
                        "  A   ",
                        "  L   ",
                        ".PLAY.",
                        "  .   "
                    },new List<string> {
                        "  .    ",
                        "  C    ",
                        "  A    ",
                        "  N    ",
                        ".DARTS.",
                        "  S    ",
                        "  T    ",
                        "  A    ",
                        "  .    "
                    },new List<string> {
                        "      .  ",
                        "      B  ",
                        "      A  ",
                        "      I  ",
                        ".CANASTA.",
                        "      .  "
                    }
                };

                case 9402:

                    return new List<List<string>> {

                    new List<string> {
                        "         . .     ",
                        "         L D     ",
                        "         I I     ",
                        "        .ZONURUS.",
                        "         A O     ",
                        ".STEGOSAURUS.    ",
                        "         D A     ",
                        "         . U     ",
                        "           R     ",
                        "           .     "
                    },new List<string> {
                        "     .   ",
                        "     S   ",
                        "     E . ",
                        ".ZONURUS.",
                        "     P N ",
                        "     E A ",
                        "     N K ",
                        " .TURTLE.",
                        "     . . "
                    },new List<string> {
                        "      .     ",
                        "      D     ",
                        "      I     ",
                        "      N     ",
                        "      O     ",
                        "      S     ",
                        "     .A.    ",
                        "    .TURTLE.",
                        ".TUATARA.   ",
                        "     I.T    ",
                        "     P T    ",
                        "     A L    ",
                        "     N E    ",
                        "     . R    ",
                        "       .    "
                    },new List<string> {
                        " . .    ",
                        " T R    ",
                        " A A    ",
                        " I T    ",
                        ".PYTHON.",
                        " A L    ",
                        " N E    ",
                        " .KRAIT.",
                        "   .    "
                    },new List<string> {
                        "   .    ",
                        "   R    ",
                        "   A    ",
                        "   T  . ",
                        ".PYTHON.",
                        "   L  E ",
                        "   E  W ",
                        " .KRAIT.",
                        "   .  . "
                    },new List<string> {
                        "   .   .     ",
                        "  .WARAL.    ",
                        "   O   A     ",
                        "   R   M     ",
                        "   R   I     ",
                        ".STEGOSAURUS.",
                        "   L   .     ",
                        "   .         "
                    },new List<string> {
                        " .           ",
                        " E           ",
                        " L           ",
                        " A           ",
                        " P           ",
                        ".STEGOSAURUS.",
                        " .           "
                    },new List<string> {
                        "     .       ",
                        "     F       ",
                        "     R       ",
                        ".STEGOSAURUS.",
                        "     G       ",
                        "     .       "
                    },new List<string> {
                        "   .     ",
                        "   P     ",
                        ".TUATARA.",
                        "   D     ",
                        "   D     ",
                        "   O     ",
                        "   C     ",
                        "   K     ",
                        "   .     "
                    },new List<string> {
                        "       . ",
                        "   .   P ",
                        "   D   A ",
                        "   I   D ",
                        "   P   D ",
                        ".TESTUDO.",
                        "   A   C ",
                        "  .SKINK.",
                        "   .   . "
                    },new List<string> {
                        "  .       ",
                        "  M .     ",
                        ".TOAD.    ",
                        "  N I     ",
                        "  I P     ",
                        " .TESTUDO.",
                        "  O A     ",
                        "  R S     ",
                        "  . .     "
                    },new List<string> {
                        "   .     ",
                        "   D     ",
                        "   I .   ",
                        "   P K   ",
                        ".TESTUDO.",
                        "   A F   ",
                        "  .SKINK.",
                        "   . .   "
                    }
                };

                case 9403:

                    return new List<List<string>> {

                    new List<string> {
                        "   .     ",
                        "   V     ",
                        "   E     ",
                        "   L     ",
                        "   A     ",
                        "   S     ",
                        "   Q .   ",
                        " .HUDSON.",
                        "   E T   ",
                        ".PIZZARO.",
                        "   . N   ",
                        "     L   ",
                        "     E   ",
                        "     Y   ",
                        "     .   "
                    },new List<string> {
                        "       . ",
                        "       B ",
                        ".STANLEY.",
                        "       R ",
                        "       D ",
                        "       . "
                    },new List<string> {
                        "   .  .      ",
                        "   E  N      ",
                        "  .VELASQUEZ.",
                        "   A  N      ",
                        ".EANNES.     ",
                        "   S  E      ",
                        "   .  N      ",
                        "      .      "
                    },new List<string> {
                        "       . ",
                        "       J ",
                        "       E ",
                        "       N ",
                        "       K ",
                        "     . I ",
                        " .HUDSON.",
                        "     T S ",
                        ".PIZZARO.",
                        "     N N ",
                        "     L . ",
                        "     E   ",
                        "     Y   ",
                        "     .   "
                    },new List<string> {
                        "       . ",
                        "       J ",
                        "       E ",
                        "       N ",
                        "       K ",
                        "     . I ",
                        "     S N ",
                        "     T S ",
                        ".PIZZARO.",
                        "     N N ",
                        "  .POLO. ",
                        "     E   ",
                        "     Y   ",
                        "     .   "
                    },new List<string> {
                        " .       ",
                        ".PIZZARO.",
                        " E       ",
                        " A       ",
                        " R       ",
                        " Y       ",
                        " .       "
                    },new List<string> {
                        "     . ",
                        "     K ",
                        "     E ",
                        "     N ",
                        "     N ",
                        "     E ",
                        "     D ",
                        ".PEARY.",
                        "     . "
                    },new List<string> {
                        "    . . ",
                        "  .COOK.",
                        "    A E ",
                        ".BURTON.",
                        "    E N ",
                        "    S E ",
                        "    . D ",
                        "      Y ",
                        "      . "
                    },new List<string> {
                        " .  .   ",
                        " O  O   ",
                        " S  A   ",
                        ".BURTON.",
                        " O  E   ",
                        ".ROSS.  ",
                        " N  .   ",
                        " .      "
                    },new List<string> {
                        "   . . ",
                        "   M O ",
                        ".ADAMS.",
                        "   W B ",
                        ".MOSTO.",
                        "   O R ",
                        "   N N ",
                        "   . . "
                    },new List<string> {
                        " . .   ",
                        " T M   ",
                        ".ADAMS.",
                        " S W   ",
                        ".MOSTO.",
                        " A O   ",
                        " N N   ",
                        " . .   "
                    },new List<string> {
                        "   .  .   ",
                        " .STEWART.",
                        "   O  U   ",
                        "   R  S   ",
                        "   R  T   ",
                        "   E  I   ",
                        ".TASMAN.  ",
                        "   .  .   "
                    },new List<string> {
                        "   .  . ",
                        " .SCOTT.",
                        "   O  A ",
                        ".TORRES.",
                        "   T  M ",
                        "   E  A ",
                        "   S  N ",
                        "   .  . "
                    },new List<string> {
                        " .      ",
                        " L      ",
                        ".EANNES.",
                        " I      ",
                        " F      ",
                        " .      "
                    }
                };

                case 9404:

                    return new List<List<string>> {

                    new List<string> {
                        " .      ",
                        " S      ",
                        " C  .   ",
                        ".HERBS. ",
                        " I  A   ",
                        ".ZINNIA.",
                        " A  K   ",
                        " N  S   ",
                        " T  .   ",
                        " H      ",
                        " U      ",
                        " S      ",
                        " .      "
                    },new List<string> {
                        "    .     ",
                        "    B .   ",
                        "    A H   ",
                        ".ZINNIA.  ",
                        "    K K   ",
                        "  .ASTERS.",
                        "    . .   "
                    },new List<string> {
                        "         . . ",
                        ".SCHIZANTHUS.",
                        "         E P ",
                        "         N O ",
                        "         R R ",
                        "      .THYME.",
                        "         . . "
                    },new List<string> {
                        "   . .         ",
                        "  .SCHIZANTHUS.",
                        "   T E         ",
                        "   A R         ",
                        "   M B         ",
                        ".SEEDS.        ",
                        "   N .         ",
                        "   S           ",
                        "   .           "
                    },new List<string> {
                        "       .  ",
                        "       L  ",
                        "     . O  ",
                        " .FORSYTH.",
                        "     E U  ",
                        ".STAMENS. ",
                        "     D .  ",
                        "     S    ",
                        "     .    "
                    },new List<string> {
                        "   .      ",
                        "   V      ",
                        "   I .    ",
                        " .FORSYTH.",
                        "   L E    ",
                        ".STAMENS. ",
                        "   . D    ",
                        "     S    ",
                        "     .    "
                    },new List<string> {
                        "      .      ",
                        "      F      ",
                        "    .FLOWERS.",
                        "    H O      ",
                        "    A R      ",
                        "    K E      ",
                        ".ASTERS.     ",
                        "    . .      "
                    },new List<string> {
                        "  . .    ",
                        "  F T    ",
                        ".FLOWERS.",
                        "  O E    ",
                        " .REEVES.",
                        "  E D    ",
                        "  S I    ",
                        "  . E    ",
                        "    .    "
                    },new List<string> {
                        "  .      ",
                        "  F .    ",
                        "  L R    ",
                        "  O E    ",
                        ".TWEEDIE.",
                        "  E V    ",
                        " .RUE.   ",
                        "  S S    ",
                        "  . .    "
                    },new List<string> {
                        " . .    ",
                        " F T    ",
                        " L W    ",
                        " O E    ",
                        ".REEVES.",
                        " E D    ",
                        " S I    ",
                        " .KEW.  ",
                        "   .    "
                    },new List<string> {
                        " .     ",
                        " D     ",
                        " A     ",
                        ".VIOLA.",
                        " I     ",
                        " D     ",
                        " .     "
                    },new List<string> {
                        "       . ",
                        "       P ",
                        "       E ",
                        "       T ",
                        "       A ",
                        "       L ",
                        ".FLOWERS.",
                        "       . "
                    },new List<string> {
                        "     . ",
                        "     P ",
                        "     E ",
                        ".FRUIT.",
                        "     A ",
                        "     L ",
                        "     S ",
                        "     . "
                    },new List<string> {
                        "  .  ",
                        "  F  ",
                        "  R  ",
                        ".GUM.",
                        "  I  ",
                        "  T  ",
                        "  .  "
                    },new List<string> {
                        " .      ",
                        " R      ",
                        " E      ",
                        " E      ",
                        " V      ",
                        " E      ",
                        ".SHRUBS.",
                        " .      "
                    },new List<string> {
                        "      . ",
                        "      F ",
                        "      E ",
                        "      R ",
                        "      N ",
                        ".SHRUBS.",
                        "      . "
                    },new List<string> {
                        "   . ",
                        ".KEW.",
                        "   A ",
                        "   R ",
                        "   D ",
                        "   . "
                    },new List<string> {
                        "     .  ",
                        ".ASTERS.",
                        "     O  ",
                        "     B  ",
                        "     I  ",
                        "     N  ",
                        "     .  "
                    },new List<string> {
                        " .     ",
                        ".LOTUS.",
                        " U     ",
                        " P     ",
                        " I     ",
                        " N     ",
                        " .     "
                    }
                };

                case 9406:

                    return new List<List<string>> {

                    new List<string> {
                        "   . .     ",
                        ".RAMAZZINI.",
                        "   A O     ",
                        ".INSULIN.  ",
                        "   H L     ",
                        "   R N     ",
                        "   I E     ",
                        "   G R     ",
                        "   . .     "
                    },new List<string> {
                        "       .   ",
                        " .     H   ",
                        ".SURGERY.  ",
                        " A     G   ",
                        ".RAMAZZINI.",
                        " P     E   ",
                        " I     N   ",
                        " .     E   ",
                        "       .   "
                    },new List<string> {
                        "     .   ",
                        "     F . ",
                        ".MASHRIG.",
                        "     A E ",
                        ".ZOLLNER.",
                        "     K M ",
                        "     . S ",
                        "       . "
                    },new List<string> {
                        "    . .  ",
                        "  .GERMS.",
                        "    V A  ",
                        ".TETANY. ",
                        "    N O  ",
                        "    S .  ",
                        "    .    "
                    },new List<string> {
                        " .      ",
                        " M  .   ",
                        " O  E   ",
                        " R  V   ",
                        ".TETANY.",
                        " O  N   ",
                        ".NURSE. ",
                        " .  .   "
                    },new List<string> {
                        "    . ",
                        ".MAYO.",
                        "    X ",
                        "    Y ",
                        "    G ",
                        "    E ",
                        "    N ",
                        "    . "
                    },new List<string> {
                        "    .   ",
                        "    O   ",
                        "  . X   ",
                        " .WHYTT.",
                        "  R G   ",
                        ".BILE.  ",
                        "  G N   ",
                        "  H .   ",
                        "  T     ",
                        "  .     "
                    },new List<string> {
                        "      . ",
                        "      V ",
                        "  .   I ",
                        " .WHYTT.",
                        "  R   A ",
                        "  I   M ",
                        "  G   I ",
                        "  H   N ",
                        ".STOKES.",
                        "  .   . "
                    },new List<string> {
                        " .      ",
                        ".HARVEY.",
                        " Y      ",
                        " G      ",
                        " I      ",
                        " E      ",
                        " N      ",
                        " E      ",
                        " .      "
                    },new List<string> {
                        "         . ",
                        "         S ",
                        ".RAMAZZINI.",
                        "         M ",
                        "         P ",
                        "         S ",
                        "         O ",
                        "         N ",
                        "         . "
                    },new List<string> {
                        "  .   . ",
                        "  S   F ",
                        "  I   L ",
                        " .MONRO.",
                        "  P   R ",
                        "  S   E ",
                        ".BOTANY.",
                        "  N   . ",
                        "  .     "
                    },new List<string> {
                        "   .   ",
                        "   H   ",
                        "   A   ",
                        ".MONRO.",
                        "   D   ",
                        "   .   "
                    }
                };

                case 9407:

                    return new List<List<string>> {

                    new List<string> {
                        "     .     ",
                        "     S .   ",
                        "     U H   ",
                        "     B O   ",
                        ".BLIZZARD. ",
                        "     E I   ",
                        "   .FROZEN.",
                        "     O O   ",
                        "     . N   ",
                        "       .   "
                    },new List<string> {
                        "     .    ",
                        "  .  S    ",
                        "  H  U    ",
                        "  I  B    ",
                        ".BLIZZARD.",
                        "  L  E    ",
                        "  A  R    ",
                        "  R  O    ",
                        ".BYRD.    ",
                        "  .       "
                    },new List<string> {
                        "     .    ",
                        "     S .  ",
                        "   .FUCHS.",
                        "     B O  ",
                        ".BLIZZARD.",
                        "     E I  ",
                        "     R Z  ",
                        "     O O  ",
                        "     . N  ",
                        "       .  "
                    },new List<string> {
                        "     . ",
                        "     P ",
                        "     E ",
                        "     T ",
                        "     R ",
                        "     E ",
                        "     L ",
                        ".FUCHS.",
                        "     . "
                    },new List<string> {
                        "   . .      ",
                        "  .SUPPLIES.",
                        "   T E      ",
                        ".SCOTT.     ",
                        "   R R      ",
                        "   M E      ",
                        "   . L      ",
                        "     S      ",
                        "     .      "
                    },new List<string> {
                        "    . .   ",
                        "    G.S   ",
                        " .INUIT.  ",
                        "   .SCOTT.",
                        ".WINTER.  ",
                        "    ..M   ",
                        "      .   "
                    },new List<string> {
                        "      . .   ",
                        ".SUPPLIES.  ",
                        "      G A   ",
                        "      L S   ",
                        "      O T   ",
                        "      O R   ",
                        "     .SKUAS.",
                        "      . G   ",
                        "        I   ",
                        "        .   "
                    },new List<string> {
                        "    . . ",
                        "    S W ",
                        "    A H ",
                        ".ALASKA.",
                        "    T L ",
                        "    R E ",
                        " .SKUAS.",
                        "    G . ",
                        "    I   ",
                        "    .   "
                    },new List<string> {
                        "        . ",
                        "        W ",
                        ".SASTRUGI.",
                        "        N ",
                        "        D ",
                        "        . "
                    },new List<string> {
                        "      . ",
                        "      W ",
                        "      E ",
                        " .    A ",
                        ".WALRUS.",
                        " I    E ",
                        " N    L ",
                        ".DRIFTS.",
                        " .    . "
                    },new List<string> {
                        "   .  . ",
                        "  .SNOW.",
                        "   E  E ",
                        "   A  A ",
                        ".WALRUS.",
                        "   S  E ",
                        "   .  L ",
                        "      S ",
                        "      . "
                    },new List<string> {
                        "  .    ",
                        "  P    ",
                        "  O    ",
                        "  L    ",
                        ".SEALS.",
                        "  .    "
                    }
                };

                case 9408:

                    return new List<List<string>> {

                    new List<string> {
                        "   .   ",
                        "   T   ",
                        "   Y   ",
                        "   P   ",
                        " . O   ",
                        " C G   ",
                        " O R   ",
                        " S A   ",
                        ".TYPES.",
                        " E H   ",
                        ".ROYAL.",
                        " . .   "
                    },new List<string> {
                        "   . .  ",
                        "   T Q  ",
                        ".STYLUS.",
                        "   P I  ",
                        " .MOULD.",
                        "   G L  ",
                        "   R .  ",
                        "   A    ",
                        "   P    ",
                        "   H    ",
                        "   Y    ",
                        "   .    "
                    },new List<string> {
                        "      .     ",
                        "      P     ",
                        "      A     ",
                        "      P     ",
                        "      Y     ",
                        "     .R     ",
                        "    .QUARTO.",
                        ".STYLUS.    ",
                        "     I.     ",
                        "     L      ",
                        "     L      ",
                        "     .      "
                    },new List<string> {
                        "    .    ",
                        " .  D    ",
                        ".PAGE.   ",
                        " A  M    ",
                        ".PAPYRUS.",
                        " E  .    ",
                        " R       ",
                        " S       ",
                        " .       "
                    },new List<string> {
                        "     .     ",
                        "     S     ",
                        "     C     ",
                        "     R     ",
                        "     I.    ",
                        "    .PRESS.",
                        ".QUARTO.   ",
                        "     .L    ",
                        "      L    ",
                        "      E    ",
                        "      R    ",
                        "      S    ",
                        "      .    "
                    },new List<string> {
                        "     .    ",
                        "     R    ",
                        "     O    ",
                        "     L    ",
                        "     L    ",
                        "    .E    ",
                        "   .PRINT.",
                        ".ROLLS.   ",
                        "    A.    ",
                        "    T     ",
                        "    E     ",
                        "    S     ",
                        "    .     "
                    },new List<string> {
                        "    .    ",
                        "    B    ",
                        " .  A    ",
                        " P  L    ",
                        ".ROLLERS.",
                        " E  O    ",
                        " S  O    ",
                        ".SEWN.   ",
                        " .  .    "
                    },new List<string> {
                        " .       ",
                        " P       ",
                        " A .     ",
                        ".PAPYRUS.",
                        " E A     ",
                        " R I     ",
                        ".SCRIPT. ",
                        " . .     "
                    },new List<string> {
                        "  .     ",
                        "  R .   ",
                        ".FONT.  ",
                        "  L I   ",
                        ".PLATES.",
                        "  S L   ",
                        "  . E   ",
                        "    .   "
                    },new List<string> {
                        "     . ",
                        "     B ",
                        ".TITLE.",
                        "     D ",
                        "     . "
                    },new List<string> {
                        "      .    ",
                        "      P    ",
                        ".ROLLERS.  ",
                        "      I B  ",
                        "      N O  ",
                        "     .TEXT.",
                        "      . .  "
                    },new List<string> {
                        "   . ",
                        "   P ",
                        "   L ",
                        "   A ",
                        "   T ",
                        "   E ",
                        ".EMS.",
                        "   . "
                    },new List<string> {
                        " .      ",
                        " P      ",
                        " R      ",
                        " O      ",
                        " O      ",
                        " F      ",
                        ".STYLUS.",
                        " .      "
                    },new List<string> {
                        " .      ",
                        ".PROOFS.",
                        " I      ",
                        " C      ",
                        " A      ",
                        " .      "
                    },new List<string> {
                        "      .    ",
                        "    . R    ",
                        ".QUARTO.   ",
                        "    E L    ",
                        "  .BALLOON.",
                        "    M E    ",
                        "    . R    ",
                        "      S    ",
                        "      .    "
                    },new List<string> {
                        " . .   ",
                        " S F   ",
                        ".CROWN.",
                        " R R   ",
                        " I M   ",
                        ".PRESS.",
                        " T .   ",
                        " .     "
                    },new List<string> {
                        "     . ",
                        "     I ",
                        ".CROWN.",
                        "     K ",
                        "     . "
                    }
                };

                case 9409:

                    return new List<List<string>> {

                    new List<string> {
                        "   .    ",
                        "   S    ",
                        "   T    ",
                        "   A    ",
                        "   B    ",
                        " . I    ",
                        ".GALIEN.",
                        " Y I    ",
                        ".ROZIER.",
                        " O E    ",
                        " S R    ",
                        " T .    ",
                        " A      ",
                        " T      ",
                        " .      "
                    },new List<string> {
                        " .         ",
                        " C .       ",
                        " U M       ",
                        " R E       ",
                        " T R       ",
                        " I C       ",
                        ".SHUTTLE.  ",
                        " S R       ",
                        " .GYROSTAT.",
                        "   .       "
                    },new List<string> {
                        "    .     ",
                        "    E     ",
                        "    J     ",
                        "    E     ",
                        "  . C     ",
                        ".CURTISS. ",
                        "  L O     ",
                        " .MERCURY.",
                        "  . .     "
                    },new List<string> {
                        "    .   ",
                        "    G   ",
                        "    Y   ",
                        "    R   ",
                        "    O   ",
                        " .  S   ",
                        ".HEATH. ",
                        " A  A   ",
                        ".SMITHY.",
                        " T  .   ",
                        " E      ",
                        " .      "
                    },new List<string> {
                        "      . ",
                        "      B ",
                        ".SMITHY.",
                        "      R ",
                        "      D ",
                        "      . "
                    },new List<string> {
                        "   . .  ",
                        "  .BYRD.",
                        "   A I  ",
                        ".WINGS. ",
                        "   K E  ",
                        "   . .  "
                    },new List<string> {
                        "     . ",
                        "     S ",
                        "     H ",
                        "     U ",
                        "     T ",
                        ".STRUT.",
                        "     L ",
                        "     E ",
                        "     . "
                    },new List<string> {
                        "    .    ",
                        " .STULTZ.",
                        " S  F    ",
                        ".TIRO.   ",
                        " R  .    ",
                        " U       ",
                        " T       ",
                        " .       "
                    },new List<string> {
                        "      . ",
                        ".STULTZ.",
                        "      E ",
                        "      P ",
                        "      P ",
                        "      E ",
                        "      L ",
                        "      I ",
                        "      N ",
                        "      . "
                    },new List<string> {
                        "  .         ",
                        "  P         ",
                        ".KITES.     ",
                        "  L   G     ",
                        "  O   A     ",
                        ".STABILIZER.",
                        "  .   I     ",
                        "      E     ",
                        "      N     ",
                        "      .     "
                    },new List<string> {
                        "   .  . ",
                        "   S  A ",
                        "   T  I ",
                        "   A  R ",
                        "   B  L ",
                        "   I  I ",
                        ".GALIEN.",
                        "   I  E ",
                        ".ROZIER.",
                        "   E  . ",
                        "   R    ",
                        "   .    "
                    },new List<string> {
                        "      .     ",
                        "      G     ",
                        "    . A     ",
                        ".STABILIZER.",
                        "    E I     ",
                        "    L E     ",
                        ".AIRLINER.  ",
                        "    . .     "
                    },new List<string> {
                        "    . ",
                        "    E ",
                        "    J ",
                        ".DIVE.",
                        "    C ",
                        "    T ",
                        "    O ",
                        "    R ",
                        "    . "
                    },new List<string> {
                        " .       ",
                        " G       ",
                        " R       ",
                        " E       ",
                        ".EJECTOR.",
                        " N       ",
                        " .       "
                    }
                };

                case 9410:

                    return new List<List<string>> {

                    new List<string> {
                        "     . ",
                        "     A ",
                        "     T ",
                        "  .  T ",
                        "  R  O ",
                        "  U  R ",
                        " .LIEN.",
                        "  E  E ",
                        ".USURY.",
                        "  .  . "
                    },new List<string> {
                        "  .       ",
                        "  S       ",
                        "  U       ",
                        "  S       ",
                        "  P       ",
                        "  E       ",
                        "  C       ",
                        ".ATTORNEY.",
                        "  .       "
                    },new List<string> {
                        "      .      ",
                        "      T .    ",
                        "      R F    ",
                        "      E O    ",
                        "      S R    ",
                        "      P.G    ",
                        "    .CASE.   ",
                        "     .SURTAX.",
                        ".WITNESS.    ",
                        "      .P     ",
                        "       E     ",
                        "       C     ",
                        "       T     ",
                        "       .     "
                    },new List<string> {
                        "     .     ",
                        "     S .   ",
                        "   .SURTAX.",
                        "     S O   ",
                        "     P R   ",
                        ".INQUEST.  ",
                        "     C .   ",
                        "     T     ",
                        "     .     "
                    },new List<string> {
                        "       .   ",
                        "       S   ",
                        "   .   U   ",
                        ".WITNESS.  ",
                        "   R   P   ",
                        "  .INQUEST.",
                        "   A   C   ",
                        "   L   T   ",
                        "   .   .   "
                    },new List<string> {
                        " .       ",
                        ".WITNESS.",
                        " R       ",
                        " I       ",
                        " T       ",
                        " .       "
                    },new List<string> {
                        "      .  ",
                        ".CRUELTY.",
                        "      R  ",
                        "      E  ",
                        "      S  ",
                        "      P  ",
                        "      A  ",
                        "      S  ",
                        "      S  ",
                        "      .  "
                    },new List<string> {
                        "    . ",
                        "    C ",
                        "    R ",
                        "    U ",
                        "    E ",
                        "    L ",
                        "    T ",
                        ".JURY.",
                        "    . "
                    },new List<string> {
                        " . .     ",
                        " E A     ",
                        " X C     ",
                        " E Q     ",
                        ".CRUELTY.",
                        " U I     ",
                        " T T     ",
                        ".OATH.   ",
                        " R A     ",
                        " . L     ",
                        "   .     "
                    },new List<string> {
                        "  .   ",
                        "  J   ",
                        ".JURY.",
                        "  S   ",
                        "  T   ",
                        "  I   ",
                        "  C   ",
                        "  E   ",
                        "  .   "
                    },new List<string> {
                        "    .   ",
                        "    F   ",
                        ".FELONY.",
                        "    R   ",
                        "    G   ",
                        "    E   ",
                        "    R   ",
                        "    .   "
                    },new List<string> {
                        "      . ",
                        "      B ",
                        "      I ",
                        "      G ",
                        "      A ",
                        "      M ",
                        ".FELONY.",
                        "      . "
                    },new List<string> {
                        " .      ",
                        " F      ",
                        " O      ",
                        " R      ",
                        ".GUILTY.",
                        " E      ",
                        " R      ",
                        " .      "
                    },new List<string> {
                        "      . ",
                        "      L ",
                        "      E ",
                        "      G ",
                        "      A ",
                        "      C ",
                        ".GUILTY.",
                        "      . "
                    },new List<string> {
                        "    .   ",
                        "    F   ",
                        ".BIGAMY.",
                        "    L   ",
                        "    S   ",
                        "    E   ",
                        "    .   "
                    }
                };

                case 9411:

                    return new List<List<string>> {

                    new List<string> {
                        "      . . ",
                        "  .HELMET.",
                        "      A A ",
                        "      G B ",
                        "      A A ",
                        ".HOWITZER.",
                        "      I D ",
                        "      N . ",
                        "      E   ",
                        "      .   "
                    },new List<string> {
                        "  .       ",
                        "  D .     ",
                        "  E Q     ",
                        "  T U     ",
                        ".HOWITZER.",
                        "  N V     ",
                        "  A E     ",
                        " .TORPEDO.",
                        "  O .     ",
                        "  R       ",
                        "  .       "
                    },new List<string> {
                        "         .    ",
                        "         M    ",
                        "        .O    ",
                        "       .BRASS.",
                        "     .SHOT.   ",
                        "       .LANCE.",
                        ".DETONATOR.   ",
                        "        ..    "
                    },new List<string> {
                        "    .    ",
                        "  . B    ",
                        " .MORTAR.",
                        "  A A    ",
                        ".GUNS.   ",
                        "  S S    ",
                        "  E .    ",
                        "  R      ",
                        "  .      "
                    },new List<string> {
                        "  .    ",
                        "  M    ",
                        "  O  . ",
                        ".BRASS.",
                        "  T  P ",
                        ".LANCE.",
                        "  R  A ",
                        "  .  R ",
                        "     . "
                    },new List<string> {
                        " .    ",
                        " D    ",
                        " A    ",
                        " R    ",
                        " T    ",
                        ".SHOT.",
                        " .    "
                    },new List<string> {
                        "    .  ",
                        "    J  ",
                        "    E  ",
                        ".DARTS.",
                        "    .  "
                    },new List<string> {
                        "   .   ",
                        "   S   ",
                        "   P   ",
                        "   E   ",
                        "   A   ",
                        ".ARROW.",
                        "   .   "
                    },new List<string> {
                        "   . ",
                        "   A ",
                        "   R ",
                        "   R ",
                        "   O ",
                        ".BOW.",
                        "   . "
                    },new List<string> {
                        "      . ",
                        ".MAUSER.",
                        "      A ",
                        "      M ",
                        "      . "
                    },new List<string> {
                        " .     ",
                        ".ARROW.",
                        " X     ",
                        " E     ",
                        " .     "
                    },new List<string> {
                        "   . ",
                        "   P ",
                        ".AXE.",
                        "   T ",
                        "   A ",
                        "   R ",
                        "   D ",
                        "   . "
                    },new List<string> {
                        "   .  ",
                        "   D  ",
                        " . E  ",
                        " P R  ",
                        " E I  ",
                        ".TANK.",
                        " A G  ",
                        " R E  ",
                        ".DIRK.",
                        " . .  "
                    },new List<string> {
                        "     . ",
                        ".SWORD.",
                        "     A ",
                        "     R ",
                        "     T ",
                        "     S ",
                        "     . "
                    },new List<string> {
                        " .     ",
                        ".SWORD.",
                        " I     ",
                        " R     ",
                        " E     ",
                        " N     ",
                        " .     "
                    },new List<string> {
                        "   . .  ",
                        "  .BOMB.",
                        "   A I  ",
                        ".SIREN. ",
                        "   B E  ",
                        "   . .  "
                    }
                };

                case 9412:

                    return new List<List<string>> {

                    new List<string> {
                        " .      ",
                        " E .    ",
                        " G G    ",
                        ".YULE.  ",
                        " P O    ",
                        " T R    ",
                        " .MYRRH.",
                        "   .    "
                    },new List<string> {
                        "     . ",
                        "     N ",
                        "     I ",
                        "     G ",
                        "     H ",
                        ".EGYPT.",
                        "     . "
                    },new List<string> {
                        "   .   ",
                        "   M   ",
                        "   A   ",
                        ".NIGHT.",
                        "   I   ",
                        "   .   "
                    },new List<string> {
                        " .     ",
                        " T     ",
                        " H     ",
                        " R     ",
                        " E     ",
                        ".EGYPT.",
                        " .     "
                    },new List<string> {
                        "   .   ",
                        ".WATCH.",
                        "   H   ",
                        "   R   ",
                        "   E   ",
                        "   E   ",
                        "   .   "
                    },new List<string> {
                        " .    ",
                        ".WISH.",
                        " A    ",
                        " T    ",
                        " C    ",
                        " H    ",
                        " .    "
                    },new List<string> {
                        "   .  ",
                        "   T  ",
                        "   I  ",
                        "   D  ",
                        "   I  ",
                        "   N  ",
                        "   G  ",
                        ".WISH.",
                        "   .  "
                    },new List<string> {
                        " . .    ",
                        ".FATHER.",
                        " E I    ",
                        " A D    ",
                        ".SPIRIT.",
                        " T N    ",
                        " . G    ",
                        "   S    ",
                        "   .    "
                    },new List<string> {
                        "  .  .    ",
                        "  F  S    ",
                        "  A  P    ",
                        " .TIDINGS.",
                        "  H  R    ",
                        "  E  I    ",
                        ".FROST.   ",
                        "  .  .    "
                    },new List<string> {
                        "    .  ",
                        ".FROST.",
                        "    A  ",
                        "    I  ",
                        "    N  ",
                        "    T  ",
                        "    .  "
                    },new List<string> {
                        "    .     ",
                        "    S     ",
                        " .  A     ",
                        ".NATIVITY.",
                        " O  N     ",
                        ".EAST.    ",
                        " L  .     ",
                        " .        "
                    },new List<string> {
                        "   .     ",
                        "   N     ",
                        "   A     ",
                        "   T     ",
                        "   I     ",
                        "   V     ",
                        "  .I     ",
                        " .STABLE.",
                        ".JOY.    ",
                        "  N.     ",
                        "  .      "
                    },new List<string> {
                        "   .   ",
                        ".EAST. ",
                        "   N H ",
                        "   O A ",
                        " .AWAY.",
                        "   . . "
                    },new List<string> {
                        "   .     ",
                        "   S     ",
                        "   T     ",
                        "   A.    ",
                        "  .BLESS.",
                        ".HALO.   ",
                        "  .EVE.  ",
                        "   .E    ",
                        "    .    "
                    },new List<string> {
                        "   .    ",
                        "   B    ",
                        "   L    ",
                        "   E.   ",
                        ".KISS.  ",
                        "  .STAR.",
                        "   .A   ",
                        "    L   ",
                        "    L   ",
                        "    .   "
                    },new List<string> {
                        "   . . ",
                        "   S P ",
                        " .STAR.",
                        "   A A ",
                        ".HOLLY.",
                        "   L E ",
                        "   . R ",
                        "     . "
                    },new List<string> {
                        "     .  ",
                        ".SPIRIT.",
                        "     N  ",
                        "     N  ",
                        "     .  "
                    }
                };

                case 9501:

                    return new List<List<string>> {

                    new List<string> {
                        "        .        ",
                        "       .F        ",
                        "      .AUTOMATED.",
                        ".INTEREST.       ",
                        "      .SUM.      ",
                        ".TRANSFER.       ",
                        "      .TERMS.    ",
                        ".BUSINESS.       ",
                        "       ..        "
                    },new List<string> {
                        "     .    ",
                        "     S    ",
                        " .   H    ",
                        " G   A    ",
                        ".INTEREST.",
                        " L   E    ",
                        ".TRANSFER.",
                        " .   .    "
                    },new List<string> {
                        "    .      ",
                        "   .BUY.   ",
                        "    O  S   ",
                        ".AUTOMATED.",
                        "    K  A   ",
                        "    .  M   ",
                        "       P   ",
                        "       .   "
                    },new List<string> {
                        "   . ",
                        "   D ",
                        "   U ",
                        "   T ",
                        ".BUY.",
                        "   . "
                    },new List<string> {
                        "  .   ",
                        "  E   ",
                        "  Q   ",
                        ".DUTY.",
                        "  I   ",
                        "  T   ",
                        "  Y   ",
                        "  .   "
                    },new List<string> {
                        "      . ",
                        ".EQUITY.",
                        "      I ",
                        "      E ",
                        "      L ",
                        "      D ",
                        "      . "
                    },new List<string> {
                        "    .   ",
                        "    E   ",
                        "    Q   ",
                        "  .DUTY.",
                        "  F I   ",
                        ".DEBT.  ",
                        "  E Y   ",
                        "  . .   "
                    },new List<string> {
                        " .      ",
                        " B      ",
                        " O      ",
                        " N      ",
                        " D      ",
                        ".SHARES.",
                        " .      "
                    },new List<string> {
                        "     . ",
                        "     C ",
                        "     A ",
                        ".TERMS.",
                        "     H ",
                        "     . "
                    },new List<string> {
                        "      .  ",
                        "      B  ",
                        ".AUCTION.",
                        "      N  ",
                        "      D  ",
                        "      S  ",
                        "      .  "
                    },new List<string> {
                        "  .      ",
                        "  R .    ",
                        ".AUCTION.",
                        "  I I    ",
                        ".UNIT.   ",
                        "  . L    ",
                        "    E    ",
                        "    .    "
                    },new List<string> {
                        "     . ",
                        ".STAMP.",
                        "     A ",
                        "     R ",
                        "     . "
                    },new List<string> {
                        "   . ",
                        "   F ",
                        ".PAR.",
                        "   E ",
                        "   E ",
                        "   . "
                    },new List<string> {
                        " .     ",
                        " C     ",
                        " A     ",
                        " S     ",
                        ".HOUSE.",
                        " .     "
                    },new List<string> {
                        "    .  ",
                        "    T  ",
                        "    I  ",
                        "    T  ",
                        "    L  ",
                        ".BUYER.",
                        "    .  "
                    },new List<string> {
                        " .   . ",
                        ".BUYER.",
                        " U   I ",
                        ".LOANS.",
                        " L   K ",
                        " S   . ",
                        " .     "
                    },new List<string> {
                        "   . . ",
                        ".BULLS.",
                        "   O A ",
                        "   A L ",
                        "   N E ",
                        ".RISK. ",
                        "   .   "
                    }
                };

                case 9502:

                    return new List<List<string>> {

                    new List<string> {
                        "   .      ",
                        "   T      ",
                        "   R      ",
                        "   A  .   ",
                        "   P  S   ",
                        "   E  H   ",
                        "  .ZONE.  ",
                        "   I  E   ",
                        ".ROULETTE.",
                        "   M  .   ",
                        "   .      "
                    },new List<string> {
                        "     .       ",
                        "     L  .    ",
                        "   .QUADRANT.",
                        "     N  O    ",
                        ".TRAPEZIUM.  ",
                        "     .  L    ",
                        "        E    ",
                        "        T    ",
                        "        T    ",
                        "        E    ",
                        "        .    "
                    },new List<string> {
                        " .       ",
                        " R       ",
                        " O    .  ",
                        " U    O  ",
                        " L    C  ",
                        ".EVOLUTE.",
                        " T    A  ",
                        ".TRIDENT.",
                        " E    T  ",
                        " .    .  "
                    },new List<string> {
                        "      .  ",
                        "   .  O  ",
                        "   C  C  ",
                        ".EVOLUTE.",
                        "   N  A  ",
                        ".TRIDENT.",
                        "   C  T  ",
                        "   .  .  "
                    },new List<string> {
                        " .     ",
                        " T     ",
                        " R     ",
                        " A  .  ",
                        ".PRISM.",
                        " E  H  ",
                        ".ZONE. ",
                        " I  E  ",
                        " U  T  ",
                        " M  .  ",
                        " .     "
                    },new List<string> {
                        "       . .   ",
                        "       C L   ",
                        ".HYPERBOLA.  ",
                        "       N M   ",
                        "       O I   ",
                        "       I N   ",
                        "   .QUADRANT.",
                        "       . .   "
                    },new List<string> {
                        "  .        ",
                        "  C        ",
                        ".HYPERBOLA.",
                        "  L        ",
                        "  I        ",
                        "  N        ",
                        "  D        ",
                        "  E        ",
                        "  R        ",
                        "  .        "
                    },new List<string> {
                        "    .   ",
                        "    Q   ",
                        "    U   ",
                        "    A   ",
                        "    D   ",
                        "    R   ",
                        "    A   ",
                        "    N   ",
                        ".SECTOR.",
                        "    .   "
                    },new List<string> {
                        "   . .    ",
                        "  .SECTOR.",
                        "   O O    ",
                        ".SPLINE.  ",
                        "   I E    ",
                        "   D .    ",
                        "   .      "
                    },new List<string> {
                        "     . ",
                        ".LOCUS.",
                        "     P ",
                        "     L ",
                        "     I ",
                        "     N ",
                        "     E ",
                        "     . "
                    },new List<string> {
                        "       . .   ",
                        "       C L   ",
                        ".HYPERBOLA.  ",
                        "       N M   ",
                        "      .OGIVE.",
                        "       I N   ",
                        "       D A   ",
                        "       . .   "
                    },new List<string> {
                        "     .     ",
                        "     A     ",
                        ".HYPERBOLA.",
                        "     C     ",
                        "     .     "
                    },new List<string> {
                        "      . ",
                        ".SECTOR.",
                        "      H ",
                        "      O ",
                        "      M ",
                        "      B ",
                        "      . "
                    },new List<string> {
                        "        . ",
                        "        C ",
                        "      . U ",
                        "   .RHOMB.",
                        "      C E ",
                        ".EVOLUTE. ",
                        "      A   ",
                        "      N   ",
                        "      T   ",
                        "      .   "
                    },new List<string> {
                        " .         ",
                        ".TRAPEZIUM.",
                        " O         ",
                        " R         ",
                        " U         ",
                        " S         ",
                        " .         "
                    },new List<string> {
                        "    .     ",
                        "    K     ",
                        ".CYLINDER.",
                        "    T     ",
                        "    E     ",
                        "    .     "
                    },new List<string> {
                        "        . ",
                        "        L ",
                        "        I ",
                        "        N ",
                        ".ROULETTE.",
                        "        . "
                    }
                };

                case 9503:

                    return new List<List<string>> {

                    new List<string> {
                        "      .   ",
                        "  .   B   ",
                        " .TILBURY.",
                        "  A   G   ",
                        "  X   G   ",
                        ".JITNEY.  ",
                        "  .   .   "
                    },new List<string> {
                        "   .      ",
                        "   W      ",
                        "  .A      ",
                        " .TILBURY.",
                        ".VAN.     ",
                        "  X.      ",
                        "  I       ",
                        "  .       "
                    },new List<string> {
                        "   .  ",
                        ".YAWL.",
                        "   A  ",
                        "   I  ",
                        "   N  ",
                        "   .  "
                    },new List<string> {
                        " .  . ",
                        ".SHAY.",
                        " L  A ",
                        " E  W ",
                        " D  L ",
                        ".GIG. ",
                        " E    ",
                        " .    "
                    },new List<string> {
                        "       .      ",
                        "       J      ",
                        "       A      ",
                        "       L      ",
                        "     .COASTER.",
                        "     B P      ",
                        ".TILBURY.     ",
                        "     G .      ",
                        "     G        ",
                        "     Y        ",
                        "     .        "
                    },new List<string> {
                        "   .     ",
                        "   C     ",
                        "   O     ",
                        "   A .   ",
                        "  .SEDAN.",
                        "   T R   ",
                        "   E A   ",
                        ".LORRY.  ",
                        "   . .   "
                    },new List<string> {
                        "     .   ",
                        "     C   ",
                        "     A   ",
                        "     R   ",
                        ".COASTER.",
                        "     .   "
                    },new List<string> {
                        "   .    ",
                        ".JITNEY.",
                        "   R    ",
                        "   U    ",
                        "   C    ",
                        "   K    ",
                        "   .    "
                    },new List<string> {
                        "  .    ",
                        "  T    ",
                        "  R    ",
                        ".SULKY.",
                        "  C    ",
                        "  K    ",
                        "  .    "
                    },new List<string> {
                        "     . ",
                        ".SULKY.",
                        "     A ",
                        "     C ",
                        "     H ",
                        "     T ",
                        "     . "
                    },new List<string> {
                        "     . ",
                        ".YACHT.",
                        "     A ",
                        "     N ",
                        "     K ",
                        "     E ",
                        "     R ",
                        "     . "
                    },new List<string> {
                        "      . ",
                        "      T ",
                        "   .  A ",
                        ".SALOON.",
                        "   I  K ",
                        "  .TUBE.",
                        "   T  R ",
                        "   E  . ",
                        "   R    ",
                        "   .    "
                    },new List<string> {
                        "      . ",
                        "      M ",
                        " .    O ",
                        ".SAMPAN.",
                        " A    O ",
                        ".LITTER.",
                        " O    A ",
                        " O    I ",
                        " N    L ",
                        " .    . "
                    },new List<string> {
                        "   .    ",
                        "   S    ",
                        "   E    ",
                        "   D    ",
                        "   A    ",
                        ".HANSOM.",
                        "   .    "
                    },new List<string> {
                        "     . ",
                        "     B ",
                        "     I ",
                        ".TRUCK.",
                        "     E ",
                        "     . "
                    },new List<string> {
                        " .   ",
                        ".BUS.",
                        " I   ",
                        " K   ",
                        " E   ",
                        " .   "
                    },new List<string> {
                        "   . ",
                        ".BUS.",
                        "   H ",
                        "   I ",
                        "   P ",
                        "   . "
                    },new List<string> {
                        "  .     ",
                        "  C     ",
                        ".JALOPY.",
                        "  B     ",
                        "  .     "
                    }
                };

                case 9504:

                    return new List<List<string>> {

                    new List<string> {
                        "   .     ",
                        "   G     ",
                        "   O     ",
                        "   R     ",
                        "   G     ",
                        " . O     ",
                        " D N     ",
                        ".ENZYMES.",
                        " R O     ",
                        " B L     ",
                        ".YEAST.  ",
                        " . .     "
                    },new List<string> {
                        "   .     ",
                        "   G     ",
                        "   O     ",
                        "   R   . ",
                        "  .GOATS.",
                        "   O   W ",
                        "   N   I ",
                        ".ENZYMES.",
                        "   O   S ",
                        "   L   . ",
                        "   A     ",
                        "   .     "
                    },new List<string> {
                        "   .     ",
                        "   G     ",
                        "   O.    ",
                        "  .AROMA.",
                        ".FETA.   ",
                        "  .SWISS.",
                        "   ..    "
                    },new List<string> {
                        " .       ",
                        " S       ",
                        " W       ",
                        " I       ",
                        " S       ",
                        ".SAVOURY.",
                        " .       "
                    },new List<string> {
                        "       . ",
                        "       D ",
                        "       A ",
                        "       I ",
                        "       R ",
                        ".SAVOURY.",
                        "       . "
                    },new List<string> {
                        "     .   ",
                        "     C   ",
                        "     H   ",
                        ".SAVOURY.",
                        "     R   ",
                        "     N   ",
                        "     .   "
                    },new List<string> {
                        "     .   ",
                        "     C   ",
                        "     H   ",
                        "     U   ",
                        "     R   ",
                        ".KETONES.",
                        "     .   "
                    },new List<string> {
                        "   .        ",
                        "   B        ",
                        "   A        ",
                        ".GORGONZOLA.",
                        "   .        "
                    },new List<string> {
                        " .          ",
                        " A          ",
                        ".GORGONZOLA.",
                        " E          ",
                        " D          ",
                        " .          "
                    },new List<string> {
                        "      . ",
                        "      A ",
                        "      G ",
                        ".MATURE.",
                        "      D ",
                        "      . "
                    },new List<string> {
                        " .  .     ",
                        ".SKIM.    ",
                        " A  A     ",
                        " P  T     ",
                        ".INDUSTRY.",
                        " D  R     ",
                        " .  E     ",
                        "    .     "
                    },new List<string> {
                        "      . .  ",
                        "      W G  ",
                        "     .HARD.",
                        "      I U  ",
                        ".INDUSTRY. ",
                        "      E E  ",
                        "      . R  ",
                        "        E  ",
                        "        .  "
                    },new List<string> {
                        "      . .    ",
                        "      W G    ",
                        "      H R    ",
                        "      I U    ",
                        ".INDUSTRY.   ",
                        "      E E    ",
                        "      .CREAM.",
                        "        E    ",
                        "        .    "
                    },new List<string> {
                        "    .    ",
                        "    F.   ",
                        ".CREAM.  ",
                        "   .TINT.",
                        "    .L   ",
                        "     K   ",
                        "     .   "
                    },new List<string> {
                        "   .   ",
                        "   M   ",
                        " .TINT.",
                        " B L   ",
                        ".YAK.  ",
                        " R .   ",
                        " E     ",
                        " .     "
                    },new List<string> {
                        "    . ",
                        "    D ",
                        "    E ",
                        "    S ",
                        "    S ",
                        "    E ",
                        "    R ",
                        ".TINT.",
                        "    . "
                    },new List<string> {
                        " . .     ",
                        " A E     ",
                        ".COWS.   ",
                        " I E     ",
                        ".DESSERT.",
                        " . .     "
                    }
                };

                case 9505:

                    return new List<List<string>> {

                    new List<string> {
                        " .  .    ",
                        ".PRIZE.  ",
                        " O  I    ",
                        " S  P    ",
                        " T  P    ",
                        " E  E    ",
                        " R  R    ",
                        " .ASSETS.",
                        "    .    "
                    },new List<string> {
                        "  . .   ",
                        ".ASSETS.",
                        "  T W   ",
                        "  A E   ",
                        " .FIRM. ",
                        "  F S   ",
                        "  . .   "
                    },new List<string> {
                        "     .   ",
                        "     L   ",
                        "    .I   ",
                        ".STAFF.  ",
                        "   .ITEM.",
                        ".EWERS.  ",
                        "    M.   ",
                        "    .    "
                    },new List<string> {
                        " .  .  ",
                        ".PRIZE.",
                        " O  I  ",
                        ".SOAP. ",
                        " T  P  ",
                        " E  E  ",
                        " R  R  ",
                        " .  S  ",
                        "    .  "
                    },new List<string> {
                        "     .  ",
                        "     C  ",
                        "     R  ",
                        "     E  ",
                        "     D  ",
                        "     I  ",
                        ".ASSETS.",
                        "     .  "
                    },new List<string> {
                        "     .   ",
                        " .CREDIT.",
                        " S   E   ",
                        ".TRAPS.  ",
                        " O   K   ",
                        " C   .   ",
                        " K       ",
                        " .       "
                    },new List<string> {
                        "     . ",
                        " .   D ",
                        " S   E ",
                        ".TRAPS.",
                        " O   K ",
                        ".CASH. ",
                        " K     ",
                        " .     "
                    },new List<string> {
                        " .      ",
                        " C      ",
                        " A      ",
                        ".SHEETS.",
                        " H      ",
                        " .      "
                    },new List<string> {
                        "   .     ",
                        "   S     ",
                        "   H     ",
                        "   E     ",
                        "   E     ",
                        "   T     ",
                        ".DISPLAY.",
                        "   .     "
                    },new List<string> {
                        "       . ",
                        "       G ",
                        "       R ",
                        "       O ",
                        "       C ",
                        "       E ",
                        "       R ",
                        ".DISPLAY.",
                        "       . "
                    },new List<string> {
                        "     .     ",
                        "     P     ",
                        "   .LUXURY.",
                        "   G R     ",
                        "   R S     ",
                        ".STORE.    ",
                        "   C .     ",
                        "   E       ",
                        "   R       ",
                        "   Y       ",
                        "   .       "
                    },new List<string> {
                        "      . ",
                        "      M ",
                        "      O ",
                        "      N ",
                        "      E ",
                        ".LUXURY.",
                        "      . "
                    },new List<string> {
                        "  . .   ",
                        "  P Q   ",
                        ".LUXURY.",
                        "  R A   ",
                        " .SILK. ",
                        "  E I   ",
                        "  . T   ",
                        "    Y   ",
                        "    .   "
                    },new List<string> {
                        "   .   ",
                        "   Q   ",
                        "   U   ",
                        "   A   ",
                        "   L   ",
                        "   I   ",
                        "   T   ",
                        ".BUYER.",
                        "   .   "
                    },new List<string> {
                        "     . ",
                        "     W ",
                        "     A ",
                        ".BUYER.",
                        "     E ",
                        "     S ",
                        "     . "
                    },new List<string> {
                        "     . ",
                        "     G ",
                        "     O ",
                        "     O ",
                        "     D ",
                        ".WARES.",
                        "     . "
                    },new List<string> {
                        " .     ",
                        " S     ",
                        " A     ",
                        ".LIFTS.",
                        " E     ",
                        " .     "
                    },new List<string> {
                        "    .   ",
                        "    S   ",
                        "    P   ",
                        ".SHEETS.",
                        "    N   ",
                        "    D   ",
                        "    .   "
                    }
                };

                case 9506:

                    return new List<List<string>> {

                    new List<string> {
                        "   .     ",
                        "   Q  .  ",
                        " .CUCKOO.",
                        "   E  S  ",
                        "   T  P  ",
                        ".BUZZARD.",
                        "   A  E  ",
                        "   L  Y  ",
                        "   .  .  "
                    },new List<string> {
                        "      . ",
                        "      L ",
                        ".OSPREY.",
                        "      R ",
                        "      E ",
                        "      B ",
                        "      I ",
                        "      R ",
                        "      D ",
                        "      . "
                    },new List<string> {
                        "   .      ",
                        "   C      ",
                        "   U      ",
                        "   C      ",
                        "   K.     ",
                        "  .OSPREY.",
                        ".CROW.    ",
                        "   .A     ",
                        "    N     ",
                        "    .     "
                    },new List<string> {
                        "     . ",
                        "     E ",
                        "  .  A ",
                        "  C  G ",
                        " .RAIL.",
                        "  O  E ",
                        ".SWAN. ",
                        "  .    "
                    },new List<string> {
                        "         . ",
                        "       . Q ",
                        "      .EMU.",
                        "       I A ",
                        "       D I ",
                        "       E L ",
                        ".LYREBIRD. ",
                        "       .   "
                    },new List<string> {
                        " .    ",
                        " E    ",
                        " A    ",
                        ".GULL.",
                        " L    ",
                        " E    ",
                        " .    "
                    },new List<string> {
                        "      . ",
                        ".ORIOLE.",
                        "      A ",
                        "      G ",
                        "      L ",
                        "      E ",
                        "      . "
                    },new List<string> {
                        "     .    ",
                        "     R    ",
                        "     A .  ",
                        "     T T  ",
                        "    .I.E  ",
                        "   .STORK.",
                        ".BITTERN. ",
                        "    A.I.  ",
                        "    R O   ",
                        "    L L   ",
                        "    I E   ",
                        "    N .   ",
                        "    G     ",
                        "    .     "
                    },new List<string> {
                        "     .    ",
                        "     R    ",
                        "     A .  ",
                        ".BLUETIT. ",
                        "     I E  ",
                        "   .STORK.",
                        "     E N  ",
                        "     . .  "
                    },new List<string> {
                        "    . .  ",
                        "    S O  ",
                        ".BITTERN.",
                        "    A I  ",
                        ".SPARROW.",
                        "    L L  ",
                        "    I E  ",
                        "    N .  ",
                        "    G    ",
                        "    .    "
                    },new List<string> {
                        " .  .    ",
                        " I  S    ",
                        ".BITTERN.",
                        " I  A    ",
                        ".SPARROW.",
                        " .  L    ",
                        "    I    ",
                        "    N    ",
                        "    G    ",
                        "    .    "
                    },new List<string> {
                        "     .     ",
                        "   .BROLGA.",
                        "   A A     ",
                        ".BLUETIT.  ",
                        "   K I     ",
                        "   . T     ",
                        "     E     ",
                        "     .     "
                    },new List<string> {
                        "    .    ",
                        "    S    ",
                        "    T    ",
                        "  . A    ",
                        ".SPARROW.",
                        "  A L    ",
                        "  R I    ",
                        ".WREN.   ",
                        "  O G    ",
                        "  T .    ",
                        "  .      "
                    },new List<string> {
                        "   . ",
                        "   G ",
                        "   U ",
                        ".OWL.",
                        "   L ",
                        "   . "
                    },new List<string> {
                        " .       ",
                        " R       ",
                        " O       ",
                        ".BUZZARD.",
                        " I       ",
                        " N       ",
                        " .       "
                    },new List<string> {
                        " .       ",
                        " C       ",
                        " O       ",
                        ".BLUETIT.",
                        " .       "
                    }
                };

                case 9507:

                    return new List<List<string>> {

                    new List<string> {
                        "        .    ",
                        "        A    ",
                        "        R .  ",
                        ".RAZZAMATAZZ.",
                        "        I O  ",
                        "       .SHOW.",
                        "        T .  ",
                        "        S    ",
                        "        .    "
                    },new List<string> {
                        "   .         ",
                        "   T         ",
                        "   R         ",
                        "   A         ",
                        "   P         ",
                        "   E         ",
                        ".RAZZAMATAZZ.",
                        "   E         ",
                        "   .         "
                    },new List<string> {
                        "       .   ",
                        "       G   ",
                        "       Y   ",
                        "      .M   ",
                        "    .VAN.  ",
                        "     .CAGE.",
                        ".ARTISTS.  ",
                        "      .T   ",
                        "       .   "
                    },new List<string> {
                        "  .      ",
                        "  F      ",
                        "  L      ",
                        ".GYMNAST.",
                        "  E      ",
                        "  R      ",
                        "  .      "
                    },new List<string> {
                        "    . ",
                        ".SHOW.",
                        "    A ",
                        "    G ",
                        "    O ",
                        "    N ",
                        "    . "
                    },new List<string> {
                        "     . ",
                        "     B ",
                        "     U ",
                        "     S ",
                        "     K ",
                        "     E ",
                        ".FLYER.",
                        "     . "
                    },new List<string> {
                        "   .    ",
                        "   L    ",
                        "   I    ",
                        "   O    ",
                        "   N    ",
                        ".BUSKER.",
                        "   .    "
                    },new List<string> {
                        "  .      ",
                        "  A      ",
                        "  C .    ",
                        ".STAR.   ",
                        "  O O    ",
                        ".TRAPEZE.",
                        "  S E    ",
                        "  . .    "
                    },new List<string> {
                        "     .      ",
                        "     A      ",
                        "     C      ",
                        "     T      ",
                        "    .O      ",
                        "   .TRAPEZE.",
                        ".BEARS.     ",
                        "    A.      ",
                        "    I       ",
                        "    N       ",
                        "    E       ",
                        "    R       ",
                        "    .       "
                    },new List<string> {
                        "      .      ",
                        "      B .    ",
                        ".TUMBLERS.   ",
                        "      A K    ",
                        "    .TRAINER.",
                        "      S L    ",
                        "      . L    ",
                        "        .    "
                    },new List<string> {
                        " .       ",
                        " M       ",
                        ".ARTISTS.",
                        " G       ",
                        " I       ",
                        " C       ",
                        " .       "
                    },new List<string> {
                        "      .    ",
                        "      T    ",
                        "      A    ",
                        "      M.   ",
                        ".TRAINER.  ",
                        "     .RISK.",
                        "      .N   ",
                        "       G   ",
                        "       .   "
                    },new List<string> {
                        " .  . ",
                        ".TENT.",
                        " A  R ",
                        " M  U ",
                        " E  C ",
                        ".RISK.",
                        " .  . "
                    },new List<string> {
                        "  .       ",
                        "  F       ",
                        ".TUMBLERS.",
                        "  N       ",
                        "  .       "
                    },new List<string> {
                        "  .    ",
                        "  W    ",
                        "  H    ",
                        ".LIONS.",
                        "  P    ",
                        "  .    "
                    },new List<string> {
                        " .    ",
                        " C    ",
                        " L    ",
                        " O    ",
                        ".WHIP.",
                        " N    ",
                        " .    "
                    },new List<string> {
                        " .      ",
                        " B      ",
                        ".ACTORS.",
                        " N      ",
                        " D      ",
                        " .      "
                    },new List<string> {
                        "  .   ",
                        "  C   ",
                        "  A   ",
                        "  G   ",
                        ".NETS.",
                        "  .   "
                    }
                };

                case 9508:

                    return new List<List<string>> {

                    new List<string> {
                        "        .     ",
                        "        P     ",
                        "       .O.    ",
                        "      .GRAPES.",
                        ".SLIVOVITZ.   ",
                        "       N.E    ",
                        "       . R    ",
                        "         B    ",
                        "         A    ",
                        "         I    ",
                        "         J    ",
                        "         A    ",
                        "         N    ",
                        "         .    "
                    },new List<string> {
                        "  .     ",
                        "  A     ",
                        "  Z   . ",
                        "  E   P ",
                        ".GREECE.",
                        "  B   R ",
                        "  A   R ",
                        ".WINERY.",
                        "  J   . ",
                        "  A     ",
                        "  N     ",
                        "  .     "
                    },new List<string> {
                        "    .     ",
                        "    S     ",
                        "    L.    ",
                        ".SPAIN.   ",
                        "   .VODKA.",
                        " .GROG.   ",
                        "    V.    ",
                        "    I     ",
                        "    T     ",
                        "    Z     ",
                        "    .     "
                    },new List<string> {
                        "    .     ",
                        "    C     ",
                        "    A.    ",
                        "   .SWEET.",
                        ".VODKA.   ",
                        "    .T    ",
                        "     E    ",
                        "     R    ",
                        "     .    "
                    },new List<string> {
                        "  .  .   ",
                        ".SWEET.  ",
                        "  A  O   ",
                        " .TURKEY.",
                        "  E  A   ",
                        "  R  Y   ",
                        "  .  .   "
                    },new List<string> {
                        "  .  ",
                        "  T  ",
                        "  O  ",
                        "  K  ",
                        "  A  ",
                        ".RYE.",
                        "  .  "
                    },new List<string> {
                        "      . ",
                        "      I ",
                        "      T ",
                        "      A ",
                        "      L ",
                        ".TURKEY.",
                        "      . "
                    },new List<string> {
                        " .         ",
                        " R         ",
                        " O         ",
                        ".SLIVOVITZ.",
                        " E         ",
                        " .         "
                    },new List<string> {
                        "   .  ",
                        "   G  ",
                        "   R  ",
                        "   A  ",
                        "   P  ",
                        "   E  ",
                        ".USSR.",
                        "   .  "
                    },new List<string> {
                        "  .   ",
                        ".USSR.",
                        "  O   ",
                        "  I   ",
                        "  L   ",
                        "  .   "
                    },new List<string> {
                        "     .  ",
                        ".WINERY.",
                        "     H  ",
                        "     O  ",
                        "     N  ",
                        "     E  ",
                        "     .  "
                    },new List<string> {
                        "      . ",
                        "      M ",
                        "   .  A ",
                        "   R  L ",
                        "   H  M ",
                        " .CORKS.",
                        "   N  E ",
                        ".SHERRY.",
                        "   .  . "
                    },new List<string> {
                        "   .   ",
                        ".PERRY.",
                        "   U   ",
                        "   M   ",
                        "   .   "
                    },new List<string> {
                        " .    ",
                        " A    ",
                        " P    ",
                        ".PORT.",
                        " L    ",
                        " E    ",
                        " .    "
                    },new List<string> {
                        "   .  ",
                        "   W  ",
                        ".SOIL.",
                        "   N  ",
                        "   E  ",
                        "   .  "
                    },new List<string> {
                        " .     ",
                        " C     ",
                        " H     ",
                        " I     ",
                        " A     ",
                        " N     ",
                        " T     ",
                        ".ITALY.",
                        " .     "
                    }
                };

                case 9509:

                    return new List<List<string>> {

                    new List<string> {
                        "    .  ",
                        "  . P  ",
                        " .ZEUS.",
                        "  E L  ",
                        "  A P  ",
                        "  L I  ",
                        ".FONT. ",
                        "  T .  ",
                        "  S    ",
                        "  .    "
                    },new List<string> {
                        "    .     ",
                        "    V     ",
                        "    E     ",
                        "    S     ",
                        "    P     ",
                        "   .E     ",
                        "  .PRIORY.",
                        ".ZEUS.    ",
                        "   L.     ",
                        "   P      ",
                        "   I      ",
                        "   T      ",
                        "   .      "
                    },new List<string> {
                        "     .    ",
                        "     P    ",
                        "     R    ",
                        "     I    ",
                        ".BISHOP.  ",
                        "     R G  ",
                        "    .YORK.",
                        "     . O  ",
                        "       T  ",
                        "       T  ",
                        "       O  ",
                        "       .  "
                    },new List<string> {
                        "    .    ",
                        "   .A    ",
                        "  .GRAIL.",
                        ".YORK.   ",
                        "   O.    ",
                        "   T     ",
                        "   T     ",
                        "   O     ",
                        "   .     "
                    },new List<string> {
                        "    .   ",
                        "    T   ",
                        "    R   ",
                        "    A   ",
                        "    N   ",
                        "    S   ",
                        "    E   ",
                        "    P   ",
                        ".GROTTO.",
                        "    .   "
                    },new List<string> {
                        " .        ",
                        " A        ",
                        " L        ",
                        ".TRANSEPT.",
                        " A        ",
                        " R        ",
                        " .        "
                    },new List<string> {
                        "   .      ",
                        "   B      ",
                        "   E .    ",
                        ".TRANSEPT.",
                        "   D P    ",
                        "  .SHINTO.",
                        "   . R    ",
                        "     E    ",
                        "     .    "
                    },new List<string> {
                        "     .  ",
                        ".GROTTO.",
                        "     O  ",
                        "     T  ",
                        "     E  ",
                        "     M  ",
                        "     .  "
                    },new List<string> {
                        "   .  . ",
                        "   T  A ",
                        "   O  B ",
                        "  .TOMB.",
                        "   E  E ",
                        ".ROMSEY.",
                        "   .  . "
                    },new List<string> {
                        "  .     ",
                        "  V .   ",
                        "  E B   ",
                        "  S I   ",
                        " .PISA. ",
                        "  E H   ",
                        ".PRIORY.",
                        "  S P   ",
                        "  . .   "
                    },new List<string> {
                        " .       ",
                        " N       ",
                        " A       ",
                        ".VESPERS.",
                        " E       ",
                        " .       "
                    },new List<string> {
                        "       . ",
                        ".ZEALOTS.",
                        "       H ",
                        "       R ",
                        "       I ",
                        "       N ",
                        "       E ",
                        "       . "
                    },new List<string> {
                        "     .  ",
                        "     I  ",
                        "     C  ",
                        "     O  ",
                        ".SHRINE.",
                        "     .  "
                    },new List<string> {
                        " .      ",
                        " K      ",
                        " I      ",
                        ".ROMSEY.",
                        " K      ",
                        " .      "
                    },new List<string> {
                        "    .  ",
                        "  . P  ",
                        " .ZEUS.",
                        "  E L  ",
                        ".KALPA.",
                        "  L I  ",
                        "  O T  ",
                        "  T .  ",
                        "  S    ",
                        "  .    "
                    },new List<string> {
                        " .    ",
                        ".NAVE.",
                        " I    ",
                        " C    ",
                        " H    ",
                        " E    ",
                        " .    "
                    },new List<string> {
                        "     .  ",
                        "     S  ",
                        "     P  ",
                        "     I  ",
                        "     R  ",
                        ".EASTER.",
                        "     .  "
                    },new List<string> {
                        "   . ",
                        "   N ",
                        "   I ",
                        "   C ",
                        "   H ",
                        ".SEE.",
                        "   . "
                    },new List<string> {
                        "     . ",
                        ".WELLS.",
                        "     E ",
                        "     E ",
                        "     . "
                    }
                };

                case 9510:

                    return new List<List<string>> {

                    new List<string> {
                        " .    .  ",
                        ".ZITHER. ",
                        " A    A  ",
                        ".MUSETTE.",
                        " P    T  ",
                        " O    L  ",
                        " G    E  ",
                        " N    .  ",
                        " A       ",
                        " .       "
                    },new List<string> {
                        "     .    ",
                        "     V    ",
                        "   . I    ",
                        ".ZAMPOGNA.",
                        "   U L    ",
                        "  .SPINET.",
                        "   E N    ",
                        "   T .    ",
                        "   T      ",
                        "   E      ",
                        "   .      "
                    },new List<string> {
                        "       .  ",
                        "     . H  ",
                        "    .VIOL.",
                        "     I R  ",
                        ".ZAMPOGNA.",
                        "     L .  ",
                        "     I    ",
                        "     N    ",
                        "     .    "
                    },new List<string> {
                        " .     ",
                        " S     ",
                        " P     ",
                        " I     ",
                        " N     ",
                        " E     ",
                        ".TUDUM.",
                        " .     "
                    },new List<string> {
                        "   .     ",
                        "   C     ",
                        "   O .   ",
                        "   R F   ",
                        ".PANPIPE.",
                        "   E F   ",
                        ".ZITHER. ",
                        "   . .   "
                    },new List<string> {
                        "    .   ",
                        "    P   ",
                        " .  A   ",
                        ".CORNET.",
                        " E  P   ",
                        " L  I   ",
                        " L  P   ",
                        ".OBOE.  ",
                        " .  .   "
                    },new List<string> {
                        " .       ",
                        " H       ",
                        " A       ",
                        " R       ",
                        ".PANPIPE.",
                        " .       "
                    },new List<string> {
                        "   .   ",
                        "   W   ",
                        "   U   ",
                        "   R . ",
                        "   L T ",
                        "   I A ",
                        "   T B ",
                        ".KAZOO.",
                        "   E R ",
                        ".HARP. ",
                        "   .   "
                    },new List<string> {
                        "   .   ",
                        " . W   ",
                        ".DRUM. ",
                        " A R   ",
                        " R L   ",
                        " B I   ",
                        " U T   ",
                        ".KAZOO.",
                        " . E   ",
                        "   R   ",
                        "   .   "
                    },new List<string> {
                        "   .    ",
                        "   W    ",
                        "   U    ",
                        "   R .  ",
                        "  .LUTE.",
                        "   I A  ",
                        "   T B  ",
                        ".KAZOO. ",
                        "   E R  ",
                        "   R .  ",
                        "   .    "
                    },new List<string> {
                        "    . ",
                        "    P ",
                        "    I ",
                        "    P ",
                        ".LUTE.",
                        "    . "
                    },new List<string> {
                        "  .   .    ",
                        ".SPOONS.   ",
                        "  I   I    ",
                        " .PSALTERY.",
                        "  E   A    ",
                        "  .   R    ",
                        "      .    "
                    },new List<string> {
                        "  .   ",
                        "  P   ",
                        "  S   ",
                        "  A   ",
                        "  L   ",
                        "  T   ",
                        "  E   ",
                        "  R   ",
                        ".LYRE.",
                        "  .   "
                    },new List<string> {
                        "    . .    ",
                        ".SPOONS.   ",
                        "    C I    ",
                        " .PSALTERY.",
                        "    R A    ",
                        "    I R    ",
                        "    N .    ",
                        "    A      ",
                        "    .      "
                    }
                };

                case 9511:

                    return new List<List<string>> {

                    new List<string> {
                        " .         ",
                        ".ZIGZAGGER.",
                        " I         ",
                        " P         ",
                        " P         ",
                        " E         ",
                        " R         ",
                        " S         ",
                        " .         "
                    },new List<string> {
                        "    . .     ",
                        ".ZIPPERS.   ",
                        "    I E     ",
                        "    N E     ",
                        "    .PLEATS.",
                        "      .     "
                    },new List<string> {
                        "     .     ",
                        ".ZIGZAGGER.",
                        "     R     ",
                        "     T     ",
                        "     .     "
                    },new List<string> {
                        "   . ",
                        ".ART.",
                        "   I ",
                        "   E ",
                        "   . "
                    },new List<string> {
                        "      . ",
                        "      R ",
                        "    . A ",
                        "    C I ",
                        ".PLEATS.",
                        "    N E ",
                        ".WEAVE. ",
                        "    A   ",
                        "    S   ",
                        "    .   "
                    },new List<string> {
                        "     .  ",
                        "     C  ",
                        "     A  ",
                        "  .  N  ",
                        " .WEAVE.",
                        "  O  A  ",
                        ".PRESS. ",
                        "  K  .  ",
                        "  .     "
                    },new List<string> {
                        "  .       ",
                        "  W       ",
                        "  O .     ",
                        ".PRESS.   ",
                        "  K L     ",
                        "  .WELDED.",
                        "    E     ",
                        "    V     ",
                        "    E     ",
                        "    S     ",
                        "    .     "
                    },new List<string> {
                        "        . ",
                        "        A ",
                        "        D ",
                        "      . J ",
                        "      L.U ",
                        "   .SEAMS.",
                        "     .CUT.",
                        ".SLEEVES. ",
                        "      .L  ",
                        "       I  ",
                        "       N  ",
                        "       .  "
                    },new List<string> {
                        "   .       ",
                        "   S  .    ",
                        "   L  W    ",
                        "   E  E    ",
                        "   E  A    ",
                        "  .VELVETS.",
                        "   E  I    ",
                        ".MUSLIN.   ",
                        "   .  G    ",
                        "      .    "
                    },new List<string> {
                        "   .     ",
                        "   D     ",
                        "   I .   ",
                        ".CROSS.  ",
                        "   R E   ",
                        "   .LACE.",
                        "     M   ",
                        "     S   ",
                        "     .   "
                    },new List<string> {
                        "      .   ",
                        "      P   ",
                        "      I   ",
                        "     .P   ",
                        "    .WELT.",
                        ".WELDED.  ",
                        "     A.   ",
                        "     V    ",
                        "     I    ",
                        "     N    ",
                        "     G    ",
                        "     .    "
                    },new List<string> {
                        "      .    ",
                        "      V    ",
                        "      E    ",
                        "   .  L    ",
                        "  .WEAVING.",
                        "   E  E    ",
                        "   L  T    ",
                        ".SATINS.   ",
                        "   .  .    "
                    },new List<string> {
                        "      .  ",
                        ".VELVETS.",
                        "      U  ",
                        "      C  ",
                        "      K  ",
                        "      .  "
                    },new List<string> {
                        "  . .    ",
                        "  B W    ",
                        ".PIPED.  ",
                        "  A L    ",
                        " .SATINS.",
                        "  . .    "
                    },new List<string> {
                        " .     ",
                        " D .   ",
                        ".RAISE.",
                        " A R   ",
                        ".WOOLS.",
                        " N N   ",
                        " . .   "
                    }
                };

                case 9512:

                    return new List<List<string>> {

                    new List<string> {
                        "  . .   ",
                        ".SPICES.",
                        "  I H   ",
                        "  M E   ",
                        "  E R   ",
                        "  N R   ",
                        " .THYME.",
                        "  O .   ",
                        "  .     "
                    },new List<string> {
                        "    . . ",
                        ".SPICES.",
                        "    H E ",
                        "    E S ",
                        "    R A ",
                        "    R M ",
                        " .THYME.",
                        "    . . "
                    },new List<string> {
                        " . .  ",
                        " S M  ",
                        " E E  ",
                        ".SALT.",
                        " A O  ",
                        ".MINT.",
                        " E S  ",
                        " . .  "
                    },new List<string> {
                        "     .     ",
                        "     M     ",
                        "     I.    ",
                        ".MELONS.   ",
                        "    .TANSY.",
                        "     .V    ",
                        "      O    ",
                        "      R    ",
                        "      Y    ",
                        "      .    "
                    },new List<string> {
                        "      . ",
                        "      B ",
                        "      E ",
                        "      T ",
                        "      O ",
                        "      N ",
                        ".SAVORY.",
                        "      . "
                    },new List<string> {
                        "     . ",
                        "     C ",
                        "     R ",
                        "     A ",
                        "     N ",
                        "     B ",
                        "     E ",
                        "     R ",
                        "     R ",
                        ".TANSY.",
                        "     . "
                    },new List<string> {
                        "    .  ",
                        ".TANSY.",
                        "    A  ",
                        "    L  ",
                        "    S  ",
                        "    I  ",
                        "    F  ",
                        "    Y  ",
                        "    .  "
                    },new List<string> {
                        "        . ",
                        "        S ",
                        "        A ",
                        "        L ",
                        "        S ",
                        "        I ",
                        "        F ",
                        ".COSTMARY.",
                        "        . "
                    },new List<string> {
                        "    .    ",
                        "    R    ",
                        "    O .  ",
                        ".SALSIFY.",
                        "    E E  ",
                        " .LEMON. ",
                        "    A N  ",
                        "    R E  ",
                        "    Y L  ",
                        "    . .  "
                    },new List<string> {
                        "        . ",
                        "        C ",
                        "        I ",
                        "     .  C ",
                        "    .LIME.",
                        "     E  L ",
                        ".ROSEMARY.",
                        "     O  . ",
                        "     N    ",
                        "     .    "
                    },new List<string> {
                        "     .    ",
                        "     L    ",
                        "     E .  ",
                        ".ROSEMARY.",
                        "     O U  ",
                        "  .FENNEL.",
                        "     . .  "
                    },new List<string> {
                        "    .  ",
                        ".THYME.",
                        "    U  ",
                        "    L  ",
                        "    B  ",
                        "    E  ",
                        "    R  ",
                        "    R  ",
                        "    Y  ",
                        "    .  "
                    },new List<string> {
                        "    . .   ",
                        "    C C   ",
                        "    R O   ",
                        "    A M   ",
                        "    N F   ",
                        ".MULBERRY.",
                        "    E E   ",
                        " .CURRY.  ",
                        "    R .   ",
                        "    Y     ",
                        "    .     "
                    },new List<string> {
                        "   . ",
                        "   M ",
                        "   U ",
                        "   L ",
                        "   B ",
                        "   E ",
                        "   R ",
                        "   R ",
                        ".BAY.",
                        "   . "
                    },new List<string> {
                        "   .       ",
                        " . B       ",
                        ".CRANBERRY.",
                        " O L       ",
                        ".COMFREY.  ",
                        " O .       ",
                        " A         ",
                        " .         "
                    },new List<string> {
                        " .      ",
                        ".MELONS.",
                        " A      ",
                        " C      ",
                        " E      ",
                        " .      "
                    },new List<string> {
                        "    .     ",
                        "    P     ",
                        "    O     ",
                        "    R     ",
                        ".COSTMARY.",
                        "    .     "
                    }
                };

                case 9601:

                    return new List<List<string>> {

                    new List<string> {
                        "      . ",
                        "      G ",
                        "      A ",
                        "    . L ",
                        "    P L ",
                        " .BARGE.",
                        "    I O ",
                        ".MIZZEN.",
                        "    E . ",
                        "    .   "
                    },new List<string> {
                        "    .   ",
                        "  . P   ",
                        " .BARGE.",
                        "  R I   ",
                        ".MIZZEN.",
                        "  G E   ",
                        "  . .   "
                    },new List<string> {
                        "   . ",
                        ".LOG.",
                        "   A ",
                        "   L ",
                        "   L ",
                        "   E ",
                        "   O ",
                        "   N ",
                        "   . "
                    },new List<string> {
                        " .   ",
                        " C   ",
                        " O   ",
                        " B   ",
                        ".LOG.",
                        " E   ",
                        " .   "
                    },new List<string> {
                        "     .   ",
                        "     C   ",
                        ".ROWBOAT.",
                        "     B   ",
                        "     L   ",
                        "     E   ",
                        "     .   "
                    },new List<string> {
                        "    .    ",
                        "    R    ",
                        " .  O    ",
                        ".TRAWLER.",
                        " R  B    ",
                        " A  O    ",
                        " M  A    ",
                        ".PUNT.   ",
                        " .  .    "
                    },new List<string> {
                        "  .      ",
                        "  T      ",
                        "  O      ",
                        "  S .    ",
                        ".WHERRY. ",
                        "  E O    ",
                        ".TRAWLER.",
                        "  . B    ",
                        "    O    ",
                        "    A    ",
                        "    T    ",
                        "    .    "
                    },new List<string> {
                        "      . ",
                        "      G ",
                        "      A ",
                        "      L ",
                        "      L ",
                        "      E ",
                        ".WHERRY.",
                        "      . "
                    },new List<string> {
                        "    .      ",
                        "    A.     ",
                        ".FERRY.    ",
                        "   .GALLEY.",
                        " .SCOW.    ",
                        "   .SLAVER.",
                        "    Y.     ",
                        "    .      "
                    },new List<string> {
                        "    .  ",
                        "    A  ",
                        "    R  ",
                        "  . G  ",
                        " .SCOW.",
                        "  H S  ",
                        ".DORY. ",
                        "  A .  ",
                        "  L    ",
                        "  E    ",
                        "  R    ",
                        "  .    "
                    },new List<string> {
                        "   .     ",
                        "  .C     ",
                        " .TOSHER.",
                        ".TUG.    ",
                        "  B.     ",
                        "  .      "
                    },new List<string> {
                        "      . ",
                        ".SLAVER.",
                        "      A ",
                        "      F ",
                        "      T ",
                        "      . "
                    },new List<string> {
                        "      . ",
                        "      R ",
                        "      A ",
                        "      F ",
                        ".DUGOUT.",
                        "      . "
                    },new List<string> {
                        "  . .   ",
                        "  J B   ",
                        ".DUGOUT.",
                        "  N A   ",
                        " .KETCH.",
                        "  . .   "
                    },new List<string> {
                        "       . ",
                        "       A ",
                        ".SHOALER.",
                        "       K ",
                        "       . "
                    },new List<string> {
                        " .     ",
                        " S     ",
                        " K     ",
                        " I     ",
                        ".FERRY.",
                        " F     ",
                        " .     "
                    },new List<string> {
                        " .    ",
                        ".SHIP.",
                        " K    ",
                        " I    ",
                        " F    ",
                        " F    ",
                        " .    "
                    },new List<string> {
                        "   .  ",
                        "   G  ",
                        ".SHIP.",
                        "   G  ",
                        "   .  "
                    }
                };

                case 9602:

                    return new List<List<string>> {

                    new List<string> {
                        " . .   ",
                        ".METER.",
                        " A R   ",
                        " G I   ",
                        " A P   ",
                        ".ZOOM. ",
                        " I D   ",
                        " N .   ",
                        " E     ",
                        " S     ",
                        " .     "
                    },new List<string> {
                        "   .    ",
                        "   M    ",
                        " . A    ",
                        " M G    ",
                        " E N    ",
                        ".TRIPOD.",
                        " E F    ",
                        ".RAYS.  ",
                        " . .    "
                    },new List<string> {
                        "   . .  ",
                        "   M T  ",
                        "   A R  ",
                        "   G I  ",
                        "   A P  ",
                        "  .ZOOM.",
                        "   I D  ",
                        ".LENS.  ",
                        "   E    ",
                        "   S    ",
                        "   .    "
                    },new List<string> {
                        "       . .   ",
                        "      .LEVER.",
                        "       E I   ",
                        ".MAGAZINES.  ",
                        "       S I   ",
                        "       . O   ",
                        "         N   ",
                        "         .   "
                    },new List<string> {
                        "   .  ",
                        "   V  ",
                        "   I  ",
                        "   S  ",
                        "  .I  ",
                        " .BOX.",
                        ".SUN. ",
                        "  L.  ",
                        "  B   ",
                        "  S   ",
                        "  .   "
                    },new List<string> {
                        "    . ",
                        ".RAYS.",
                        "    H ",
                        "    O ",
                        "    T ",
                        "    . "
                    },new List<string> {
                        "    . ",
                        "    S ",
                        ".SHOT.",
                        "    I ",
                        "    L ",
                        "    L ",
                        "    . "
                    },new List<string> {
                        " .     ",
                        ".STILL.",
                        " N     ",
                        " A     ",
                        " P     ",
                        " .     "
                    },new List<string> {
                        " .       ",
                        " T       ",
                        " I       ",
                        ".MAGNIFY.",
                        " E       ",
                        " .       "
                    },new List<string> {
                        "    . ",
                        "    T ",
                        "    A ",
                        ".SNAP.",
                        "    E ",
                        "    . "
                    },new List<string> {
                        "     . ",
                        ".SHOOT.",
                        "     A ",
                        "     P ",
                        "     E ",
                        "     . "
                    },new List<string> {
                        " .      ",
                        " B      ",
                        " U      ",
                        " L      ",
                        " B      ",
                        ".SPOOLS.",
                        " .      "
                    },new List<string> {
                        "    .     ",
                        "    B     ",
                        "    I     ",
                        "  . C     ",
                        ".SPOOLS.  ",
                        "  R N     ",
                        "  I V     ",
                        "  S E     ",
                        " .MAXWELL.",
                        "  . .     "
                    },new List<string> {
                        "    .    ",
                        "    B    ",
                        "    I    ",
                        "    C .  ",
                        ".SPOOLS. ",
                        "    N C  ",
                        "   .VIEW.",
                        "    E N  ",
                        "    X E  ",
                        "    . .  "
                    },new List<string> {
                        "    .  ",
                        "    C  ",
                        "    U  ",
                        "    B  ",
                        "    E  ",
                        ".PRISM.",
                        "    .  "
                    },new List<string> {
                        "     .  ",
                        "     C  ",
                        ".COLOUR.",
                        "     B  ",
                        "     E  ",
                        "     S  ",
                        "     .  "
                    },new List<string> {
                        "  .     ",
                        "  B     ",
                        ".MIRROR.",
                        "  C     ",
                        "  O     ",
                        "  N     ",
                        "  V     ",
                        "  E     ",
                        "  X     ",
                        "  .     "
                    },new List<string> {
                        "    . ",
                        "    M ",
                        "    I ",
                        "    R ",
                        "    R ",
                        ".HYPO.",
                        "    R ",
                        "    . "
                    },new List<string> {
                        "    .    ",
                        "    L    ",
                        "    I.   ",
                        ".IMAGE.  ",
                        "   .HYPO.",
                        ".PLATE.  ",
                        "    ..   "
                    },new List<string> {
                        "     . ",
                        ".LEVER.",
                        "     O ",
                        "     L ",
                        "     L ",
                        "     . "
                    }
                };

                case 9603:

                    return new List<List<string>> {

                    new List<string> {
                        "     .    ",
                        "     P    ",
                        "   . A    ",
                        "   V L    ",
                        "   I F    ",
                        "  .GORGET.",
                        "   I E    ",
                        ".TILTYARD.",
                        "   . .    "
                    },new List<string> {
                        " . .      ",
                        ".CAVALRY. ",
                        " R I      ",
                        " E G      ",
                        " S I      ",
                        ".TILTYARD.",
                        " . .      "
                    },new List<string> {
                        "     .   ",
                        ".PANOPLY.",
                        "     A   ",
                        "     L   ",
                        "     F   ",
                        "     R   ",
                        "     E   ",
                        "     Y   ",
                        "     .   "
                    },new List<string> {
                        "     . ",
                        "     P ",
                        "     A ",
                        "     N ",
                        "     O ",
                        "     P ",
                        "     L ",
                        ".ESSAY.",
                        "     . "
                    },new List<string> {
                        "     . .   ",
                        "    .ESSAY.",
                        "     P U   ",
                        ".WARRIOR.  ",
                        "     C C   ",
                        "     . O   ",
                        "       A   ",
                        "       T   ",
                        "       .   "
                    },new List<string> {
                        "   .      ",
                        "   H      ",
                        "   E .    ",
                        "   R S    ",
                        "   A P    ",
                        ".VALOUR.  ",
                        "   D R    ",
                        "   .ESSAY.",
                        "     .    "
                    },new List<string> {
                        "  .     ",
                        "  C .   ",
                        ".QUIVER.",
                        "  I A   ",
                        "  R L   ",
                        "  A O   ",
                        " .SPURS.",
                        "  S R   ",
                        "  . .   "
                    },new List<string> {
                        "  . .   ",
                        ".SWORD. ",
                        "  A A   ",
                        ".PRINCE.",
                        "  R K   ",
                        "  I .   ",
                        "  O     ",
                        "  R     ",
                        "  .     "
                    },new List<string> {
                        " .    ",
                        ".HERO.",
                        " E    ",
                        " R    ",
                        " A    ",
                        " L    ",
                        " D    ",
                        " .    "
                    },new List<string> {
                        "  .     ",
                        "  P     ",
                        "  R     ",
                        "  I     ",
                        "  N     ",
                        "  C     ",
                        ".JENNET.",
                        "  .     "
                    },new List<string> {
                        "     . .    ",
                        "     E S    ",
                        "     P U    ",
                        ".WARRIOR.   ",
                        "     C C    ",
                        "     .COURT.",
                        "       A    ",
                        "       T    ",
                        "       .    "
                    },new List<string> {
                        "     . ",
                        "     C ",
                        "     A ",
                        "     S ",
                        ".COURT.",
                        "     L ",
                        "     E ",
                        "     . "
                    },new List<string> {
                        "   . .  ",
                        ".CASTLE.",
                        "   Q I  ",
                        " .QUEST.",
                        "   I T  ",
                        "   R S  ",
                        "   E .  ",
                        "   .    "
                    },new List<string> {
                        "  . .  ",
                        "  S L  ",
                        "  Q I  ",
                        ".QUEST.",
                        "  I T  ",
                        ".ARMS. ",
                        "  E .  ",
                        "  .    "
                    }
                };

                case 9604:

                    return new List<List<string>> {

                    new List<string> {
                        "    .      ",
                        "    A      ",
                        "    L .    ",
                        "    C W    ",
                        "    A I    ",
                        ".MEZZANINE.",
                        "    A D    ",
                        "  .ARMOURY.",
                        "    . W    ",
                        "      .    "
                    },new List<string> {
                        "         . ",
                        "         G ",
                        "      .  A ",
                        "      W  L ",
                        "      I  L ",
                        ".MEZZANINE.",
                        "      D  R ",
                        "  .ARMOURY.",
                        "      W  . ",
                        "      .    "
                    },new List<string> {
                        "         .     ",
                        "        .G     ",
                        "       .PAGODA.",
                        "     .WALL.    ",
                        "       .ALETTE.",
                        ".MEZZANINE.    ",
                        "        .R     ",
                        "         Y     ",
                        "         .     "
                    },new List<string> {
                        "  . .   ",
                        "  P A   ",
                        "  A L   ",
                        "  G E   ",
                        ".HOSTEL.",
                        "  D T   ",
                        ".EAVES. ",
                        "  . .   "
                    },new List<string> {
                        " .         ",
                        " D         ",
                        " O         ",
                        ".MEZZANINE.",
                        " E         ",
                        " .         "
                    },new List<string> {
                        " .       ",
                        " T       ",
                        " H       ",
                        " E       ",
                        ".ALCAZAR.",
                        " T       ",
                        " R       ",
                        " E       ",
                        " .       "
                    },new List<string> {
                        " .       ",
                        ".ARMOURY.",
                        " T       ",
                        " R       ",
                        " I       ",
                        " U       ",
                        " M       ",
                        " .       "
                    },new List<string> {
                        "   .         ",
                        "   A         ",
                        "   T         ",
                        "   R         ",
                        "   I.        ",
                        ".STUD.       ",
                        "  .MONASTERY.",
                        "   .O        ",
                        "    R        ",
                        "    .        "
                    },new List<string> {
                        "    .    ",
                        "    M    ",
                        "    O    ",
                        "    N .  ",
                        " .PIAZZA.",
                        "    S I  ",
                        ".COTTAGE.",
                        "    E G  ",
                        "    R U  ",
                        "    Y R  ",
                        "    . A  ",
                        "      T  ",
                        "      .  "
                    },new List<string> {
                        "         . ",
                        "         A ",
                        "         B ",
                        "         B ",
                        "         E ",
                        ".MONASTERY.",
                        "         . "
                    },new List<string> {
                        " .  . ",
                        ".STUD.",
                        " C  O ",
                        " A  O ",
                        ".PIER.",
                        " E  . ",
                        " .    "
                    },new List<string> {
                        "   . ",
                        "   A ",
                        ".HUT.",
                        "   R ",
                        "   I ",
                        "   U ",
                        "   M ",
                        "   . "
                    },new List<string> {
                        "        . ",
                        "        L ",
                        "        A ",
                        "        B ",
                        "        Y ",
                        "        R ",
                        "        I ",
                        "        N ",
                        ".ZIGGURAT.",
                        "        H ",
                        "        . "
                    },new List<string> {
                        "   . ",
                        "   L ",
                        "   A ",
                        "   B ",
                        ".BAY.",
                        "   R ",
                        "   I ",
                        "   N ",
                        "   T ",
                        "   H ",
                        "   . "
                    }
                };

                case 9605:

                    return new List<List<string>> {

                    new List<string> {
                        "    .  ",
                        "    A  ",
                        "    S  ",
                        "    S  ",
                        "    I  ",
                        ".PRIZE.",
                        "    E  ",
                        "    S  ",
                        "    .  "
                    },new List<string> {
                        "      .         ",
                        "      T         ",
                        "      E         ",
                        "      S         ",
                        "      T.        ",
                        "    .BAR.       ",
                        "    ..TESTIMONY.",
                        ".TREASON.       ",
                        "   .SURTAX.     ",
                        ".FALSE..        ",
                        "    I.          ",
                        "    Z           ",
                        "    E           ",
                        "    S           ",
                        "    .           "
                    },new List<string> {
                        "   .  .  ",
                        "  .ABET. ",
                        "   C  E  ",
                        ".WITNESS.",
                        "   .  T  ",
                        "      A  ",
                        "      T  ",
                        "      O  ",
                        "      R  ",
                        "      .  "
                    },new List<string> {
                        "    .      ",
                        "    I      ",
                        "    N .    ",
                        "    S S    ",
                        "   .USURY. ",
                        "    L M    ",
                        ".TESTIMONY.",
                        "    . O    ",
                        "      N    ",
                        "      S    ",
                        "      .    "
                    },new List<string> {
                        "     . ",
                        "     J ",
                        "     U ",
                        "     R ",
                        ".USURY.",
                        "     . "
                    },new List<string> {
                        "  .   ",
                        "  S   ",
                        ".JURY.",
                        "  I   ",
                        "  T   ",
                        "  .   "
                    },new List<string> {
                        "    . ",
                        "    S ",
                        ".SUIT.",
                        "    E ",
                        "    A ",
                        "    L ",
                        "    . "
                    },new List<string> {
                        "       . ",
                        "       E ",
                        ".SUMMONS.",
                        "       C ",
                        "       R ",
                        "       O ",
                        "       W ",
                        "       . "
                    },new List<string> {
                        "     .   ",
                        "     P   ",
                        " .ESCROW.",
                        " O   I   ",
                        ".ARREST. ",
                        " T   O   ",
                        " H   N   ",
                        " .   .   "
                    },new List<string> {
                        "      . ",
                        "      L ",
                        "      A ",
                        ".ESCROW.",
                        "      . "
                    },new List<string> {
                        "     .   ",
                        "     P   ",
                        "     R   ",
                        "   . I   ",
                        ".ARREST. ",
                        "   O O   ",
                        "  .BENCH.",
                        "   . .   "
                    },new List<string> {
                        "    . ",
                        "    O ",
                        "    A ",
                        ".WRIT.",
                        "    H ",
                        "    . "
                    },new List<string> {
                        "       . ",
                        "       C ",
                        "       A ",
                        ".ASSIZES.",
                        "       E ",
                        "       . "
                    },new List<string> {
                        "       . ",
                        ".LAWSUIT.",
                        "       R ",
                        "       E ",
                        "       A ",
                        "       S ",
                        "       O ",
                        "       N ",
                        "       . "
                    },new List<string> {
                        " .   ",
                        " L   ",
                        " A   ",
                        " W   ",
                        " S   ",
                        ".USE.",
                        " I   ",
                        " T   ",
                        " .   "
                    },new List<string> {
                        " .      ",
                        " L      ",
                        ".INSULT.",
                        " E      ",
                        " N      ",
                        " .      "
                    }
                };

                default:
                    
                    return new List<List<string>>();
            }
        }
    }
}