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
                var shape = grid.ToShape(words);
                result.Add(shape);
            }
            return result;
        }


        public static List<GridList> findWinningGame(int gameId)
        {
            switch (gameId)
            {
                case 8612:

                    return new List<GridList> {

                    new GridList {
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
                    },new GridList {
                        "      . .  ",
                        ".NAZARETH. ",
                        "      V O  ",
                        "    .BELLS.",
                        "      . L  ",
                        "        Y  ",
                        "        .  "
                    },new GridList {
                        "   . ",
                        "   H ",
                        "   O ",
                        "   L ",
                        "   L ",
                        ".JOY.",
                        "   . "
                    },new GridList {
                        "     .    ",
                        "    .JOY. ",
                        "     E  S ",
                        ".HAZELNUT.",
                        "     L  A ",
                        "     Y  R ",
                        "     .  . "
                    },new GridList {
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
                    },new GridList {
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
                    },new GridList {
                        "  .   ",
                        "  T   ",
                        "  U   ",
                        "  R   ",
                        "  K   ",
                        "  E   ",
                        ".HYMN.",
                        "  .   "
                    },new GridList {
                        "  .     ",
                        "  S     ",
                        "  A     ",
                        ".TURKEY.",
                        "  C     ",
                        "  E     ",
                        "  .     "
                    },new GridList {
                        " .  . ",
                        ".TOYS.",
                        " O  A ",
                        " A  U ",
                        " S  C ",
                        ".TREE.",
                        " .  . "
                    },new GridList {
                        "   .  ",
                        "   F  ",
                        "   A  ",
                        "   M  ",
                        "   I  ",
                        "   L  ",
                        ".TOYS.",
                        "   .  "
                    },new GridList {
                        "    . ",
                        "    I ",
                        "    N ",
                        ".HYMN.",
                        "    . "
                    },new GridList {
                        "    .   ",
                        "    P   ",
                        "    O   ",
                        "    R   ",
                        ".TURKEY.",
                        "    .   "
                    },new GridList {
                        "    .   ",
                        "    W   ",
                        "    H   ",
                        ".FAMILY.",
                        "    T   ",
                        "    E   ",
                        "    .   "
                    },new GridList {
                        "    . ",
                        ".SNOW.",
                        "    H ",
                        "    I ",
                        "    T ",
                        "    E ",
                        "    . "
                    },new GridList {
                        "     . ",
                        "     C ",
                        "     A ",
                        "     K ",
                        ".WHITE.",
                        "     . "
                    }
                };

                case 8704:

                    return new List<GridList> {

                    new GridList {
                        "  .  .  ",
                        "  F  P  ",
                        ".HOMER. ",
                        "  O  I  ",
                        ".STANZA.",
                        "  .  E  ",
                        "     .  "
                    },new GridList {
                        " .      ",
                        ".STANZA.",
                        " L      ",
                        " E      ",
                        " S      ",
                        " S      ",
                        " O      ",
                        " R      ",
                        " .      "
                    },new GridList {
                        "       . ",
                        "       H ",
                        "    .  A ",
                        ".SLESSOR.",
                        "    C  D ",
                        "  .POESY.",
                        "    T  . ",
                        "    T    ",
                        "    .    "
                    },new GridList {
                        "     . ",
                        "     S ",
                        " .   L ",
                        ".DONNE.",
                        " O   S ",
                        ".YEATS.",
                        " L   O ",
                        " E   R ",
                        " .   . "
                    },new GridList {
                        "   ..    ",
                        "  .DONNE.",
                        ".HOOD.   ",
                        "  .YEATS.",
                        "   L.    ",
                        "   E     ",
                        "   .     "
                    },new GridList {
                        "  .    ",
                        "  S    ",
                        "  C .  ",
                        ".POESY.",
                        "  T A  ",
                        " .TEXT.",
                        "  . E  ",
                        "    .  "
                    },new GridList {
                        "    .   ",
                        " .  M   ",
                        " H  I   ",
                        " O  L   ",
                        ".POET.  ",
                        " E  O   ",
                        " .DONNE.",
                        "    .   "
                    },new GridList {
                        "    .  ",
                        " .LAMB.",
                        " H  I  ",
                        " O  L  ",
                        ".POET. ",
                        " E  O  ",
                        " .  N  ",
                        "    .  "
                    },new GridList {
                        " .    ",
                        ".HYMN.",
                        " O    ",
                        " O    ",
                        " D    ",
                        " .    "
                    },new GridList {
                        "     . . ",
                        ".BRIDGES.",
                        "     R C ",
                        "     A A ",
                        "   .HYMN.",
                        "     . . "
                    },new GridList {
                        " .     ",
                        " B     ",
                        ".RHYME.",
                        " I     ",
                        " D     ",
                        " G     ",
                        " E     ",
                        " S     ",
                        " .     "
                    },new GridList {
                        "   .   ",
                        "   E   ",
                        "   L   ",
                        "   E   ",
                        "   G   ",
                        ".RHYME.",
                        "   .   "
                    },new GridList {
                        " .     ",
                        " P     ",
                        " O     ",
                        ".ELEGY.",
                        " .     "
                    }
                };

                case 8705:

                    return new List<GridList> {

                    new GridList {
                        "     .    ",
                        "    .E    ",
                        "   .PANSY.",
                        ".MOWER.   ",
                        "   .STALK.",
                        " .PATH.   ",
                        "    ..    "
                    },new GridList {
                        "     . ",
                        "     L ",
                        "     I ",
                        "     L ",
                        ".PANSY.",
                        "     . "
                    },new GridList {
                        "    .     ",
                        "    S     ",
                        "    T.    ",
                        ".SWEEP.   ",
                        "   .MOWER.",
                        "    .P    ",
                        "     P    ",
                        "     Y    ",
                        "     .    "
                    },new GridList {
                        "     .    ",
                        "     P    ",
                        "   .MOWER.",
                        "   P P    ",
                        "   O P    ",
                        ".PEONY.   ",
                        "   L .    ",
                        "   .      "
                    },new GridList {
                        "     .       ",
                        "     G       ",
                        "     R.      ",
                        "    .ALYSSUM.",
                        ".MIMOSA.     ",
                        "    .SWEEP.  ",
                        "     .N      ",
                        "      .      "
                    },new GridList {
                        "      .  ",
                        "    . B  ",
                        ".ALYSSUM.",
                        "    T D  ",
                        ".SWEEP.  ",
                        "    M    ",
                        "    .    "
                    },new GridList {
                        "   .     ",
                        "   M     ",
                        "   A     ",
                        ".ALYSSUM.",
                        "   .     "
                    },new GridList {
                        "  .    ",
                        "  E .  ",
                        ".PANSY.",
                        "  R A  ",
                        ".STALK.",
                        "  H V  ",
                        "  . I  ",
                        "    A  ",
                        "    .  "
                    },new GridList {
                        " . .    ",
                        ".POT.   ",
                        " A R    ",
                        " L I    ",
                        ".MIMOSA.",
                        " . .    "
                    },new GridList {
                        "  .  ",
                        "  S  ",
                        "  A  ",
                        "  L  ",
                        "  V  ",
                        ".DIG.",
                        "  A  ",
                        "  .  "
                    },new GridList {
                        " .     ",
                        " T     ",
                        " A     ",
                        ".PEONY.",
                        " .     "
                    }
                };

                case 8710:

                    return new List<GridList> {

                    new GridList {
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
                    },new GridList {
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
                    },new GridList {
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
                    },new GridList {
                        "  .   ",
                        ".ROC. ",
                        "  W C ",
                        "  L H ",
                        "  E A ",
                        " .TIT.",
                        "  . . "
                    },new GridList {
                        "      .    ",
                        "      R    ",
                        "  .   O    ",
                        "  R   O    ",
                        "  O   S    ",
                        ".TOMTIT.   ",
                        "  K   E    ",
                        "  .SPARROW.",
                        "      .    "
                    },new GridList {
                        "    .     ",
                        "   .A     ",
                        "  .TURKEY.",
                        ".ROOK.    ",
                        "   M.     ",
                        "   T      ",
                        "   I      ",
                        "   T      ",
                        "   .      "
                    },new GridList {
                        "      . ",
                        "  .   S ",
                        "  A   K ",
                        ".TURKEY.",
                        "  K   L ",
                        "  .SKUA.",
                        "      R ",
                        "      K ",
                        "      . "
                    },new GridList {
                        "      . ",
                        "  .IBIS.",
                        "  A   K ",
                        ".TURKEY.",
                        "  K   L ",
                        "  .   A ",
                        "      R ",
                        "      K ",
                        "      . "
                    },new GridList {
                        "    . .    ",
                        "    E R    ",
                        "   .GROUSE.",
                        "    R O    ",
                        "    E S    ",
                        ".TOMTIT.   ",
                        "    . E    ",
                        "      R    ",
                        "      .    "
                    },new GridList {
                        " .   .   ",
                        ".SNIPE.  ",
                        " H   G   ",
                        " A   R   ",
                        " G   E   ",
                        " .TOMTIT.",
                        "     .   "
                    },new GridList {
                        "   . ",
                        ".TUI.",
                        "   B ",
                        "   I ",
                        "   S ",
                        "   . "
                    },new GridList {
                        " .   ",
                        ".TUI.",
                        " E   ",
                        " A   ",
                        " L   ",
                        " .   "
                    },new GridList {
                        "  .  ",
                        "  E  ",
                        "  M  ",
                        ".TUI.",
                        "  .  "
                    },new GridList {
                        " .   ",
                        " H   ",
                        ".EMU.",
                        " N   ",
                        " .   "
                    },new GridList {
                        "    . ",
                        "    S ",
                        "    H ",
                        ".MYNA.",
                        "    G ",
                        "    . "
                    },new GridList {
                        "   . ",
                        "   M ",
                        ".JAY.",
                        "   N ",
                        "   A ",
                        "   . "
                    }
                };

                case 8711:

                    return new List<GridList> {

                    new GridList {
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
                    },new GridList {
                        "       . ",
                        "       D ",
                        ".ZOFFANY.",
                        "       C ",
                        "       K ",
                        "       . "
                    },new GridList {
                        "  . .  ",
                        ".AZURE.",
                        "  O O  ",
                        "  F U  ",
                        "  F G  ",
                        ".LAKE. ",
                        "  N .  ",
                        "  Y    ",
                        "  .    "
                    },new GridList {
                        "    .     ",
                        "    E     ",
                        "    B     ",
                        "  .COLOUR.",
                        "  H N     ",
                        ".RUBY.    ",
                        "  E .     ",
                        "  .       "
                    },new GridList {
                        "    .   ",
                        "   .H   ",
                        "  .RUBY.",
                        ".BLUE.  ",
                        "   B.   ",
                        "   E    ",
                        "   N    ",
                        "   S    ",
                        "   .    "
                    },new GridList {
                        "  .  .  ",
                        "  B  S  ",
                        "  L  A  ",
                        ".RUBENS.",
                        "  E  D  ",
                        "  .BAY. ",
                        "     .  "
                    },new GridList {
                        "   .   ",
                        " . R   ",
                        ".BLUE. ",
                        " R B   ",
                        " U E   ",
                        ".SANDY.",
                        " H S   ",
                        " . .   "
                    },new GridList {
                        " .    ",
                        " R    ",
                        " O    ",
                        " U    ",
                        ".GREY.",
                        " E    ",
                        " .    "
                    },new GridList {
                        "    .    ",
                        "   .G    ",
                        "  .SOOTY.",
                        ".GREY.   ",
                        "  .PAINT.",
                        "   I.    ",
                        "   A     ",
                        "   .     "
                    },new GridList {
                        "     . ",
                        "     R ",
                        "     U ",
                        "  .RED.",
                        "  G  D ",
                        ".SOOTY.",
                        "  Y  . ",
                        "  A    ",
                        "  .    "
                    },new GridList {
                        "  .    ",
                        "  G .  ",
                        ".SOOTY.",
                        "  Y O  ",
                        ".PAINT.",
                        "  . E  ",
                        "    .  "
                    },new GridList {
                        "   .     ",
                        "   U     ",
                        "   M .   ",
                        ".AMBER.  ",
                        "   E E   ",
                        "  .RUDDY.",
                        "   . .   "
                    },new GridList {
                        " .   ",
                        " S   ",
                        " E   ",
                        " P   ",
                        " I   ",
                        ".ART.",
                        " .   "
                    },new GridList {
                        " .     ",
                        " T     ",
                        " U     ",
                        " B     ",
                        ".EBONY.",
                        " .     "
                    },new GridList {
                        " .    ",
                        ".TUBE.",
                        " A    ",
                        " N    ",
                        " .    "
                    },new GridList {
                        "   . ",
                        "   T ",
                        "   A ",
                        ".DUN.",
                        "   . "
                    },new GridList {
                        " .   ",
                        " J   ",
                        " A   ",
                        ".DUN.",
                        " E   ",
                        " .   "
                    }
                };

                case 8712:

                    return new List<GridList> {

                    new GridList {
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
                    },new GridList {
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
                    },new GridList {
                        "   .    ",
                        "   R .  ",
                        " .TOYS. ",
                        "   A W  ",
                        "   S E  ",
                        ".NUTMEG.",
                        "   . T  ",
                        "     S  ",
                        "     .  "
                    },new GridList {
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
                    },new GridList {
                        " .    ",
                        " D .  ",
                        " A J  ",
                        ".TREE.",
                        " E L  ",
                        ".SALT.",
                        " . Y  ",
                        "   .  "
                    },new GridList {
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
                    },new GridList {
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
                    },new GridList {
                        "         .   ",
                        "       . B   ",
                        "      .PLUMS.",
                        "       O S   ",
                        "       R H   ",
                        ".PRESENTS.   ",
                        "       .     "
                    },new GridList {
                        "    .   ",
                        "  . E   ",
                        " .SUGAR.",
                        "  A G   ",
                        ".GUESTS.",
                        "  C .   ",
                        "  E     ",
                        "  .     "
                    },new GridList {
                        "      . ",
                        ".WISHES.",
                        "      P ",
                        "      I ",
                        "      C ",
                        "      E ",
                        "      . "
                    },new GridList {
                        " .      ",
                        " W      ",
                        " I      ",
                        ".NUTMEG.",
                        " E      ",
                        " .      "
                    }
                };

                case 8802:

                    return new List<GridList> {

                    new GridList {
                        "  . .  ",
                        "  S B  ",
                        "  P L  ",
                        "  O A  ",
                        ".PRIZE.",
                        "  T E  ",
                        "  .ART.",
                        "    .  "
                    },new GridList {
                        "    .   ",
                        "    C   ",
                        "    A   ",
                        "    P   ",
                        " .MATES.",
                        " A  A   ",
                        " R  I   ",
                        ".TENNIS.",
                        " .  .   "
                    },new GridList {
                        "    .      ",
                        "   .M      ",
                        "  .CAPTAIN.",
                        ".SWOT.     ",
                        "  .PHYSICS.",
                        ".BOYS.     ",
                        "   ..      "
                    },new GridList {
                        "     .    ",
                        "     S    ",
                        "     P    ",
                        "    .O    ",
                        "   .PRIZE.",
                        ".QUIET.   ",
                        "    N.    ",
                        "    .     "
                    },new GridList {
                        "     .    ",
                        "     P    ",
                        "   .CLASS.",
                        "   Q A    ",
                        ".STUDY.   ",
                        "   I .    ",
                        "   E      ",
                        "   T      ",
                        "   .      "
                    },new GridList {
                        " .     ",
                        " L     ",
                        " I     ",
                        " N     ",
                        " E     ",
                        ".SPORT.",
                        " .     "
                    },new GridList {
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
                    },new GridList {
                        " .     ",
                        " S     ",
                        " U     ",
                        " M     ",
                        ".STUDY.",
                        " .     "
                    },new GridList {
                        "   .     ",
                        ".TERM.   ",
                        "   O C   ",
                        "   L A   ",
                        "  .LINES.",
                        "   . E   ",
                        "     .   "
                    },new GridList {
                        " .    ",
                        " T    ",
                        " A    ",
                        " B    ",
                        " L    ",
                        " E    ",
                        ".SUMS.",
                        " .    "
                    },new GridList {
                        "      . ",
                        "      I ",
                        ".CRAYON.",
                        "      K ",
                        "      . "
                    }
                };

                case 8803:

                    return new List<GridList> {

                    new GridList {
                        "  .       ",
                        "  Q .     ",
                        ".SUEZ.    ",
                        "  I U     ",
                        " .TORONTO.",
                        "  O I     ",
                        "  . C     ",
                        "    H     ",
                        "    .     "
                    },new GridList {
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
                    },new GridList {
                        "    .  ",
                        ".TOKYO.",
                        "    O  ",
                        "    R  ",
                        "    K  ",
                        "    .  "
                    },new GridList {
                        "     . .   ",
                        "     B L   ",
                        "    .OSAKA.",
                        "     N G   ",
                        ".TORONTO.  ",
                        "     . S   ",
                        "       .   "
                    },new GridList {
                        "   . . ",
                        "   L C ",
                        ".OSAKA.",
                        "   G I ",
                        "   O R ",
                        " .OSLO.",
                        "   . . "
                    },new GridList {
                        "   .  ",
                        ".YORK.",
                        "   O  ",
                        "   M  ",
                        "   E  ",
                        "   .  "
                    },new GridList {
                        "      . ",
                        "      O ",
                        "      M ",
                        "      A ",
                        ".ZURICH.",
                        "      A ",
                        "      . "
                    },new GridList {
                        "  .     ",
                        ".BOGOTA.",
                        "  M     ",
                        "  A     ",
                        "  H     ",
                        "  A     ",
                        "  .     "
                    },new GridList {
                        "     .  ",
                        ".BOGOTA.",
                        "     O  ",
                        "     L  ",
                        "     E  ",
                        "     D  ",
                        "     O  ",
                        "     .  "
                    },new GridList {
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
                    },new GridList {
                        "  . .     ",
                        "  D B     ",
                        "  E O     ",
                        "  L.M     ",
                        " .HOBART. ",
                        ".LIMA.    ",
                        "  .SYDNEY.",
                        "   K.     ",
                        "   .      "
                    },new GridList {
                        "  .      ",
                        ".HOBART. ",
                        "  M    A ",
                        " .SYDNEY.",
                        "  K    R ",
                        "  .    . "
                    },new GridList {
                        "     .   ",
                        ".HOBART. ",
                        "     E A ",
                        " .SYDNEY.",
                        "     O R ",
                        "     . . "
                    },new GridList {
                        "    . ",
                        "    C ",
                        "    O ",
                        "    R ",
                        ".OMSK.",
                        "    . "
                    }
                };

                case 8804:

                    return new List<GridList> {

                    new GridList {
                        " . .   ",
                        ".HUM.  ",
                        " Y A   ",
                        ".MEZZO.",
                        " N U   ",
                        " . R   ",
                        "   K   ",
                        "   A   ",
                        "   .   "
                    },new GridList {
                        "   . . ",
                        "   M V ",
                        "   A I ",
                        ".MEZZO.",
                        "   U L ",
                        " .ARIA.",
                        "   K . ",
                        "   A   ",
                        "   .   "
                    },new GridList {
                        "  .   ",
                        "  K   ",
                        "  E   ",
                        ".HYMN.",
                        "  .   "
                    },new GridList {
                        "    . ",
                        "    S ",
                        "    I ",
                        "    G ",
                        ".HYMN.",
                        "    . "
                    },new GridList {
                        " .    ",
                        ".SONG.",
                        " I    ",
                        " G    ",
                        " N    ",
                        " .    "
                    },new GridList {
                        "   .    ",
                        ".SONG.  ",
                        "   O T  ",
                        "  .TRIO.",
                        "   E E  ",
                        "   . .  "
                    },new GridList {
                        "    .   ",
                        "   .D   ",
                        "  .TUNE.",
                        ".TRIO.  ",
                        "   E.   ",
                        "   .    "
                    },new GridList {
                        "  . .   ",
                        "  D R   ",
                        ".TUNE.  ",
                        "  O S   ",
                        "  .STOP.",
                        "    .   "
                    },new GridList {
                        "  . .   ",
                        "  R H   ",
                        "  E.A   ",
                        " .STRUM.",
                        ".STOP.  ",
                        "  .N.   ",
                        "   E    ",
                        "   .    "
                    },new GridList {
                        "   . . ",
                        "  .HIT.",
                        "   A I ",
                        ".STRUM.",
                        "   P E ",
                        "   . . "
                    },new GridList {
                        "    .  ",
                        "  . T  ",
                        " .STOP.",
                        "  L N  ",
                        ".MUTE. ",
                        "  R .  ",
                        "  .    "
                    },new GridList {
                        "       . ",
                        "       B ",
                        ".MAZURKA.",
                        "       S ",
                        "       S ",
                        "       O ",
                        "       . "
                    },new GridList {
                        "    .    ",
                        "    S    ",
                        "   .C    ",
                        "  .MOOD. ",
                        ".SLUR.   ",
                        "  .TEMPO.",
                        "   E.    ",
                        "   .     "
                    },new GridList {
                        "     . ",
                        "   . H ",
                        ".BASSO.",
                        "   C L ",
                        " .MOOD.",
                        "   R . ",
                        "   E   ",
                        "   .   "
                    },new GridList {
                        "     . ",
                        "   . F ",
                        ".TEMPO.",
                        "   A R ",
                        " .FRET.",
                        "   C E ",
                        "   H . ",
                        "   .   "
                    },new GridList {
                        "     . ",
                        "     E ",
                        "     C ",
                        ".MARCH.",
                        "     O ",
                        "     . "
                    },new GridList {
                        " .   ",
                        " V   ",
                        " I   ",
                        " O   ",
                        ".LOW.",
                        " A   ",
                        " .   "
                    },new GridList {
                        "    . ",
                        "    L ",
                        "    O ",
                        ".SLOW.",
                        "    . "
                    }
                };

                case 8805:

                    return new List<GridList> {

                    new GridList {
                        "  . .     ",
                        "  W G     ",
                        " .HARVEST.",
                        "  E A     ",
                        ".MAIZE.   ",
                        "  T I     ",
                        "  . N     ",
                        "    G     ",
                        "    .     "
                    },new GridList {
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
                    },new GridList {
                        "        .   ",
                        "       .B   ",
                        "      .SILO.",
                        ".ROTATION.  ",
                        "       I.   ",
                        "       L    ",
                        "       .    "
                    },new GridList {
                        "    .    ",
                        "    W    ",
                        "    H    ",
                        "   .E    ",
                        "  .MAIZE.",
                        ".ROOT.   ",
                        "   W.    ",
                        "   .     "
                    },new GridList {
                        " .   . ",
                        ".STRAW.",
                        " E   H ",
                        " E   E ",
                        " D   A ",
                        " .ROOT.",
                        "     . "
                    },new GridList {
                        "  .    ",
                        "  C    ",
                        "  A    ",
                        "  R    ",
                        ".STRAW.",
                        "  .    "
                    },new GridList {
                        "    .  ",
                        "    G  ",
                        "    R  ",
                        " .  A  ",
                        ".MAIZE.",
                        " O  I  ",
                        " W  N  ",
                        " .PIG. ",
                        "    .  "
                    },new GridList {
                        "    . ",
                        "    H ",
                        ".SILO.",
                        "    E ",
                        "    . "
                    },new GridList {
                        "    . ",
                        ".SOIL.",
                        "    A ",
                        "    M ",
                        "    B ",
                        "    . "
                    },new GridList {
                        " .   ",
                        " R   ",
                        " A   ",
                        " K   ",
                        ".EWE.",
                        " .   "
                    },new GridList {
                        " .   ",
                        ".RYE.",
                        " A   ",
                        " K   ",
                        " E   ",
                        " .   "
                    },new GridList {
                        "  .  ",
                        "  H  ",
                        "  A  ",
                        ".RYE.",
                        "  .  "
                    },new GridList {
                        "    .  ",
                        ".STOCK.",
                        "    A  ",
                        "    R  ",
                        "    T  ",
                        "    .  "
                    },new GridList {
                        " .    ",
                        ".STUD.",
                        " T    ",
                        " O    ",
                        " C    ",
                        " K    ",
                        " .    "
                    },new GridList {
                        "   .  ",
                        "   S  ",
                        "   E  ",
                        ".SHED.",
                        "   D  ",
                        "   .  "
                    },new GridList {
                        " .     ",
                        ".SHEEP.",
                        " H     ",
                        " E     ",
                        " D     ",
                        " .     "
                    },new GridList {
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

                    return new List<GridList> {

                    new GridList {
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
                    },new GridList {
                        "   .  ",
                        "   A  ",
                        "  .H  ",
                        " .BOW.",
                        ".GUY. ",
                        "  O.  ",
                        "  Y   ",
                        "  .   "
                    },new GridList {
                        "    .   ",
                        "   .P   ",
                        "  .MOOR.",
                        ".SPAR.  ",
                        "  .STAY.",
                        "   T.   ",
                        "   .    "
                    },new GridList {
                        "   . ",
                        "   B ",
                        "   U ",
                        "   O ",
                        ".PLY.",
                        "   . "
                    },new GridList {
                        "    .     ",
                        "    H     ",
                        "  .YAW.   ",
                        "  F W     ",
                        ".BOWSPRIT.",
                        "  G E     ",
                        "  . R     ",
                        "    .     "
                    },new GridList {
                        "    .     ",
                        "    H     ",
                        "    A .   ",
                        "    W C   ",
                        ".BOWSPRIT.",
                        "    E E   ",
                        "  .PROW.  ",
                        "    . .   "
                    },new GridList {
                        "   .       ",
                        "  .F       ",
                        " .BOWSPRIT.",
                        ".LOG.      ",
                        "  X.       ",
                        "  .        "
                    },new GridList {
                        "        . ",
                        "        W ",
                        "        A ",
                        ".BOWSPRIT.",
                        "        C ",
                        "        H ",
                        "        . "
                    },new GridList {
                        "   . ",
                        "   M ",
                        "   A ",
                        "   S ",
                        ".SET.",
                        "   . "
                    },new GridList {
                        " .   ",
                        ".SET.",
                        " H   ",
                        " I   ",
                        " P   ",
                        " .   "
                    },new GridList {
                        "    .   ",
                        "  .DORY.",
                        "  P A   ",
                        ".MOOR.  ",
                        "  R .   ",
                        "  T     ",
                        "  .     "
                    },new GridList {
                        "    . ",
                        "    D ",
                        "    O ",
                        "    R ",
                        ".QUAY.",
                        "    . "
                    },new GridList {
                        "   .  ",
                        ".QUAY.",
                        "   F  ",
                        "   T  ",
                        "   .  "
                    },new GridList {
                        "     . ",
                        "     A ",
                        "     F ",
                        ".YACHT.",
                        "     . "
                    },new GridList {
                        "     . ",
                        ".JETTY.",
                        "     A ",
                        "     C ",
                        "     H ",
                        "     T ",
                        "     . "
                    },new GridList {
                        " .     ",
                        ".JETTY.",
                        " U     ",
                        " N     ",
                        " K     ",
                        " .     "
                    },new GridList {
                        "      . ",
                        "      J ",
                        "      U ",
                        ".ASTERN.",
                        "      K ",
                        "      . "
                    },new GridList {
                        "   . .   ",
                        ".TRANSOM.",
                        "   S A   ",
                        "  .TRIM. ",
                        "   E L   ",
                        "   R .   ",
                        "   N     ",
                        "   .     "
                    },new GridList {
                        " .       ",
                        ".TRANSOM.",
                        " A       ",
                        " C       ",
                        " K       ",
                        " .       "
                    }
                };

                case 8807:

                    return new List<GridList> {

                    new GridList {
                        "    .     ",
                        "   .C     ",
                        ".LIZA.    ",
                        "  .SIDNEY.",
                        ".ALAN.    ",
                        "   .E     ",
                        "    .     "
                    },new GridList {
                        "  . . ",
                        ".ALDA.",
                        "  I L ",
                        " .ZSA.",
                        "  A N ",
                        "  . . "
                    },new GridList {
                        "    . .   ",
                        "    D T   ",
                        "    U A   ",
                        ".SIDNEY.  ",
                        "    A L   ",
                        "   .WOODY.",
                        "    A R   ",
                        "    Y .   ",
                        "    .     "
                    },new GridList {
                        "     . ",
                        "     F ",
                        "     A ",
                        ".WOODY.",
                        "     E ",
                        "     . "
                    },new GridList {
                        "    . ",
                        "    D ",
                        "    U ",
                        "    N ",
                        "    A ",
                        "    W ",
                        "    A ",
                        ".TONY.",
                        "    . "
                    },new GridList {
                        " .      ",
                        ".TAYLOR.",
                        " O      ",
                        " M      ",
                        " .      "
                    },new GridList {
                        " .    ",
                        " S    ",
                        ".TONY.",
                        " E    ",
                        " V    ",
                        " E    ",
                        " .    "
                    },new GridList {
                        "    .    ",
                        "    N.   ",
                        "   .OMAR.",
                        ".STEVE.  ",
                        "   .AL.  ",
                        "    K.   ",
                        "    .    "
                    },new GridList {
                        " .     ",
                        " J     ",
                        " O     ",
                        " H     ",
                        ".NOVAK.",
                        " .     "
                    },new GridList {
                        "    . ",
                        ".OMAR.",
                        "    O ",
                        "    D ",
                        "    . "
                    },new GridList {
                        "   . ",
                        ".ROD.",
                        "   E ",
                        "   A ",
                        "   N ",
                        "   . "
                    },new GridList {
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
                    },new GridList {
                        "    . . ",
                        "    B R ",
                        "  .JUDY.",
                        "    R A ",
                        ".DUSTIN.",
                        "    . . "
                    },new GridList {
                        "    .   ",
                        ".MURPHY.",
                        "    E   ",
                        "    T   ",
                        "    E   ",
                        "    R   ",
                        "    .   "
                    },new GridList {
                        "   .   ",
                        ".PETER.",
                        "   A   ",
                        "   B   ",
                        "   .   "
                    },new GridList {
                        " .   ",
                        " T   ",
                        " A   ",
                        ".BOW.",
                        " .   "
                    }
                };

                case 8808:

                    return new List<GridList> {

                    new GridList {
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
                    },new GridList {
                        "   .     ",
                        "   R     ",
                        "   E .   ",
                        "  .NOMAD.",
                        "   A A   ",
                        ".STUTZ.  ",
                        "   L D   ",
                        "   T A   ",
                        "   . .   "
                    },new GridList {
                        " . .     ",
                        ".RENAULT.",
                        " O O     ",
                        " L M     ",
                        " L A     ",
                        ".SEDAN.  ",
                        " . .     "
                    },new GridList {
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
                    },new GridList {
                        " .       ",
                        " C       ",
                        " O       ",
                        " L       ",
                        ".TELSTAR.",
                        " .       "
                    },new GridList {
                        "  .    ",
                        "  A    ",
                        ".SUPRA.",
                        "  D    ",
                        "  I    ",
                        "  .    "
                    },new GridList {
                        "  .    ",
                        "  C    ",
                        ".ROCKY.",
                        "  L    ",
                        "  T    ",
                        "  .    "
                    },new GridList {
                        "     .   ",
                        "     C   ",
                        "     A   ",
                        "  .ROMEO.",
                        "  C  R   ",
                        ".ROCKY.  ",
                        "  L  .   ",
                        "  T      ",
                        "  .      "
                    },new GridList {
                        "     . ",
                        "     R ",
                        "     O ",
                        "     M ",
                        "     E ",
                        ".TURBO.",
                        "     . "
                    },new GridList {
                        " .       ",
                        " V       ",
                        " O       ",
                        " R  .    ",
                        ".TURBO.  ",
                        " E  E    ",
                        " X  N    ",
                        " .SUZUKI.",
                        "    .    "
                    },new GridList {
                        " .  ",
                        ".VW.",
                        " O  ",
                        " R  ",
                        " T  ",
                        " E  ",
                        " X  ",
                        " .  "
                    },new GridList {
                        "  . ",
                        "  B ",
                        "  M ",
                        ".VW.",
                        "  . "
                    },new GridList {
                        "  .  ",
                        ".BMW.",
                        "  G  ",
                        "  .  "
                    },new GridList {
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

                    return new List<GridList> {

                    new GridList {
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
                    },new GridList {
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
                    },new GridList {
                        "      . ",
                        "      P ",
                        "      A ",
                        "      R ",
                        "      S ",
                        "      L ",
                        "      E ",
                        ".TURKEY.",
                        "      . "
                    },new GridList {
                        "      .    ",
                        "    . G    ",
                        "   .TURKEY.",
                        "    A A    ",
                        "    R V    ",
                        ".PASTRY.   ",
                        "    . .    "
                    },new GridList {
                        "   .    ",
                        "   G .  ",
                        ".TURKEY.",
                        "   A D  ",
                        "  .VEAL.",
                        "   Y M  ",
                        "   . .  "
                    },new GridList {
                        "     .      ",
                        "     S      ",
                        "   .STEAK.  ",
                        "   P I      ",
                        "   E L      ",
                        "   A T      ",
                        ".GORGONZOLA.",
                        "   . N      ",
                        "     .      "
                    },new GridList {
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
                    },new GridList {
                        " . .  ",
                        ".LAMB.",
                        " O I  ",
                        " I N  ",
                        ".NUTS.",
                        " . S  ",
                        "   .  "
                    },new GridList {
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
                    },new GridList {
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
                    },new GridList {
                        "    . ",
                        "    M ",
                        "    I ",
                        "    L ",
                        ".PORK.",
                        "    . "
                    },new GridList {
                        " .    ",
                        ".MEAT.",
                        " I    ",
                        " L    ",
                        " K    ",
                        " .    "
                    },new GridList {
                        "    . ",
                        ".MEAT.",
                        "    E ",
                        "    A ",
                        "    . "
                    },new GridList {
                        "  .   ",
                        "  P   ",
                        "  I   ",
                        ".MEAT.",
                        "  .   "
                    },new GridList {
                        "  .    ",
                        ".SPICE.",
                        "  I    ",
                        "  E    ",
                        "  .    "
                    }
                };

                case 8810:

                    return new List<GridList> {

                    new GridList {
                        "    .  ",
                        ".ORCZY.",
                        "    O  ",
                        "    L  ",
                        "    A  ",
                        "    .  "
                    },new GridList {
                        "  .    ",
                        "  R  . ",
                        "  O  H ",
                        "  H  E ",
                        " .MANN.",
                        "  E  R ",
                        ".ORCZY.",
                        "  .  . "
                    },new GridList {
                        "    .    ",
                        "    R    ",
                        "    O    ",
                        "    H    ",
                        "   .M    ",
                        ".POPE.   ",
                        "  .ORCZY.",
                        "   E.    ",
                        "   .     "
                    },new GridList {
                        "     . ",
                        "   . R ",
                        "   H O ",
                        ".WAUGH.",
                        "   G M ",
                        " .POPE.",
                        "   . R ",
                        "     . "
                    },new GridList {
                        "    . ",
                        ".SHAW.",
                        "    A ",
                        "    U ",
                        "    G ",
                        "    H ",
                        "    . "
                    },new GridList {
                        " .    ",
                        " G    ",
                        " A    ",
                        ".SHAW.",
                        " K    ",
                        " I    ",
                        " N    ",
                        " .    "
                    },new GridList {
                        " .     ",
                        ".PEPYS.",
                        " O     ",
                        " P     ",
                        " E     ",
                        " .     "
                    },new GridList {
                        "   . .  ",
                        "   K G  ",
                        ".HEYER. ",
                        "   N E  ",
                        " .PEPYS.",
                        "   . .  "
                    },new GridList {
                        " .    ",
                        ".GLYN.",
                        " A    ",
                        " S    ",
                        " K    ",
                        " I    ",
                        " N    ",
                        " .    "
                    },new GridList {
                        "  .      ",
                        ".CHEYNEY.",
                        "  E      ",
                        "  N      ",
                        "  R      ",
                        "  Y      ",
                        "  .      "
                    },new GridList {
                        "   .    ",
                        "   C    ",
                        "   H    ",
                        "   E  . ",
                        ".SAYERS.",
                        "   N  A ",
                        "  .EDEN.",
                        "   Y  D ",
                        "   .  . "
                    },new GridList {
                        "   .   ",
                        " . H   ",
                        " S A   ",
                        ".AYRES.",
                        " N D   ",
                        ".DOYLE.",
                        " . .   "
                    },new GridList {
                        "   . ",
                        "   C ",
                        "   H ",
                        "   E ",
                        "   Y ",
                        "   N ",
                        "   E ",
                        ".HAY.",
                        "   . "
                    },new GridList {
                        " .      ",
                        " D      ",
                        " U      ",
                        " M      ",
                        " A      ",
                        ".SAYERS.",
                        " .      "
                    },new GridList {
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

                    return new List<GridList> {

                    new GridList {
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
                    },new GridList {
                        "   . .    ",
                        "  .PAPAYA.",
                        "   E E    ",
                        ".GUAVA.   ",
                        "   . R    ",
                        "     .    "
                    },new GridList {
                        " .   ",
                        " P   ",
                        " A   ",
                        " P   ",
                        " A   ",
                        ".YAM.",
                        " A   ",
                        " .   "
                    },new GridList {
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
                    },new GridList {
                        "    . .   ",
                        "    O L   ",
                        ".CHERRY.  ",
                        "    A C   ",
                        "    N H   ",
                        "    G E   ",
                        "  .CELERY.",
                        "    . .   "
                    },new GridList {
                        "       . ",
                        "       C ",
                        "       E ",
                        "    .  L ",
                        " .LYCHEE.",
                        "    O  R ",
                        ".PARSLEY.",
                        "    .  . "
                    },new GridList {
                        " .     ",
                        ".MAIZE.",
                        " A     ",
                        " N     ",
                        " G     ",
                        " O     ",
                        " .     "
                    },new GridList {
                        " .      ",
                        " P      ",
                        " E    . ",
                        ".CITRUS.",
                        " A    A ",
                        " N    G ",
                        " .MANGO.",
                        "      . "
                    },new GridList {
                        "     .      ",
                        "     P      ",
                        "     L.     ",
                        ".CITRUS.    ",
                        "    .MARROW.",
                        "     .G     ",
                        "      O     ",
                        "      .     "
                    },new GridList {
                        " .   .  ",
                        ".POTATO.",
                        " L   A  ",
                        " U   R  ",
                        ".MARROW.",
                        " .   .  "
                    },new GridList {
                        "   .    ",
                        "   D    ",
                        "   A    ",
                        ".CITRUS.",
                        "   E    ",
                        "   .    "
                    },new GridList {
                        "    .   ",
                        ".MARROW.",
                        "    A   ",
                        "    I   ",
                        "    S   ",
                        "    I   ",
                        "    N   ",
                        "    .   "
                    },new GridList {
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

                    return new List<GridList> {

                    new GridList {
                        "   . .   ",
                        " .AZALEA.",
                        "   I E   ",
                        ".ANNUAL. ",
                        "   N F   ",
                        "   I .   ",
                        "   A     ",
                        "   .     "
                    },new GridList {
                        "   .    ",
                        " . Z    ",
                        " W I    ",
                        ".ANNUAL.",
                        " T N    ",
                        ".TRIM.  ",
                        " L A    ",
                        " E .    ",
                        " .      "
                    },new GridList {
                        "      . ",
                        "  .ALOW.",
                        "  V   A ",
                        ".VIOLET.",
                        "  N   T ",
                        "  E   L ",
                        "  .   E ",
                        "      . "
                    },new GridList {
                        "  .     ",
                        "  V .   ",
                        ".VIOLET.",
                        "  N O   ",
                        ".PEST.  ",
                        "  . U   ",
                        "    S   ",
                        "    .   "
                    },new GridList {
                        "    .    ",
                        "    L    ",
                        "   .O    ",
                        ".PEST.   ",
                        "  .TUBER.",
                        " .HOSE.  ",
                        "   C.D   ",
                        "   K .   ",
                        "   .     "
                    },new GridList {
                        "     . ",
                        ".TUBER.",
                        "     O ",
                        "     S ",
                        "     E ",
                        "     . "
                    },new GridList {
                        " .   ",
                        " R   ",
                        " O   ",
                        ".SOW.",
                        " E   ",
                        " .   "
                    },new GridList {
                        "   . ",
                        "   L ",
                        "   A ",
                        ".SOW.",
                        "   N ",
                        "   . "
                    },new GridList {
                        "   .     ",
                        " . P     ",
                        ".LILY.   ",
                        " A A     ",
                        " W N     ",
                        ".NATIVES.",
                        " . .     "
                    },new GridList {
                        "    .    ",
                        "   .M    ",
                        "  .PANSY.",
                        ".LILY.   ",
                        "   A.    ",
                        "   N     ",
                        "   T     ",
                        "   .     "
                    },new GridList {
                        "     . ",
                        "     P ",
                        "     O ",
                        "  .TAP.",
                        "  M  P ",
                        ".PANSY.",
                        "  Y  . ",
                        "  .    "
                    },new GridList {
                        " .   ",
                        " P   ",
                        " O   ",
                        ".TAP.",
                        " .   "
                    },new GridList {
                        "  .    ",
                        "  M .  ",
                        ".PANSY.",
                        "  Y P  ",
                        "  .CAN.",
                        "    D  ",
                        "    E  ",
                        "    .  "
                    },new GridList {
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

                    return new List<GridList> {

                    new GridList {
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
                    },new GridList {
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
                    },new GridList {
                        " .     ",
                        " P     ",
                        " E     ",
                        ".WORDS.",
                        " .     "
                    },new GridList {
                        "    . ",
                        ".TRIP.",
                        "    E ",
                        "    W ",
                        "    . "
                    },new GridList {
                        "    . .   ",
                        "    P P   ",
                        "    O.O   ",
                        ".GUESTS.  ",
                        "   .TRYST.",
                        "    .I.   ",
                        "     P    ",
                        "     .    "
                    },new GridList {
                        "   .   ",
                        "   P . ",
                        "  .OLD.",
                        "   S A ",
                        ".TRYST.",
                        "   . E ",
                        "     . "
                    },new GridList {
                        "   .   ",
                        "   G   ",
                        ".TRUST.",
                        "   E   ",
                        "   S   ",
                        "   T   ",
                        "   S   ",
                        "   .   "
                    },new GridList {
                        " .     ",
                        ".TAXI. ",
                        " O   G ",
                        " A   I ",
                        " S   F ",
                        ".TRUST.",
                        " .   . "
                    },new GridList {
                        "   .  ",
                        "   M  ",
                        "   I  ",
                        ".TAXI.",
                        "   .  "
                    },new GridList {
                        "   .  ",
                        ".HYMN.",
                        "   I  ",
                        "   X  ",
                        "   .  "
                    },new GridList {
                        "   . ",
                        "   H ",
                        ".JOY.",
                        "   M ",
                        "   N ",
                        "   . "
                    },new GridList {
                        "    . ",
                        "    W ",
                        "    I ",
                        ".HYMN.",
                        "    . "
                    },new GridList {
                        " .   ",
                        ".WIN.",
                        " I   ",
                        " N   ",
                        " E   ",
                        " .   "
                    },new GridList {
                        "    .    ",
                        "    R    ",
                        "    O    ",
                        "  .USHER.",
                        "  G E    ",
                        ".KISS.   ",
                        "  F .    ",
                        "  T      ",
                        "  .      "
                    },new GridList {
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

                    return new List<GridList> {

                    new GridList {
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
                    },new GridList {
                        "    .  .   ",
                        "    Y  G   ",
                        "    E  U   ",
                        ".GERMANY.  ",
                        "    E  A   ",
                        " .TANZANIA.",
                        "    .  A   ",
                        "       .   "
                    },new GridList {
                        "  .  .    ",
                        ".ITALY.   ",
                        "  O  E    ",
                        " .GERMANY.",
                        "  O  E    ",
                        "  .  N    ",
                        "     .    "
                    },new GridList {
                        "      . .     ",
                        "      G H     ",
                        "     .URUGUAY.",
                        "      Y N     ",
                        "      A G     ",
                        ".TANZANIA.    ",
                        "      A R     ",
                        "      . Y     ",
                        "        .     "
                    },new GridList {
                        "       . ",
                        "       S ",
                        ".URUGUAY.",
                        "       R ",
                        "       I ",
                        "       A ",
                        "       . "
                    },new GridList {
                        "      . .     ",
                        "      G H     ",
                        "      U U     ",
                        "      Y N     ",
                        "      A G     ",
                        ".TANZANIA.    ",
                        "      A R     ",
                        "      .CYPRUS.",
                        "        .     "
                    },new GridList {
                        "     .   ",
                        "     C   ",
                        ".URUGUAY.",
                        "     B   ",
                        "     A   ",
                        "     .   "
                    },new GridList {
                        "     .  ",
                        "   . B  ",
                        ".CYPRUS.",
                        "   E R  ",
                        "   R M  ",
                        " .SUDAN.",
                        "   . .  "
                    },new GridList {
                        " .        ",
                        ".TANZANIA.",
                        " U        ",
                        " R        ",
                        " K        ",
                        " E        ",
                        " Y        ",
                        " .        "
                    },new GridList {
                        "      . ",
                        "      K ",
                        "      E ",
                        "      N ",
                        ".TURKEY.",
                        "      A ",
                        "      . "
                    },new GridList {
                        "    .  ",
                        "    T  ",
                        "    U  ",
                        ".ZAIRE.",
                        "    K  ",
                        "    E  ",
                        "    Y  ",
                        "    .  "
                    },new GridList {
                        " .     ",
                        " B     ",
                        " E     ",
                        " L     ",
                        " I     ",
                        ".ZAIRE.",
                        " E     ",
                        " .     "
                    },new GridList {
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

                    return new List<GridList> {

                    new GridList {
                        " .      ",
                        ".ZIGZAG.",
                        " I      ",
                        " P      ",
                        " P      ",
                        " E      ",
                        " R      ",
                        " .      "
                    },new GridList {
                        "      .     ",
                        "     .P     ",
                        "    .WALLET.",
                        ".ZIPPER.    ",
                        "    .STAGE. ",
                        "  .CITY.    ",
                        "     ..     "
                    },new GridList {
                        "     .  ",
                        "     W  ",
                        "     A  ",
                        "     L  ",
                        "     L  ",
                        "     E  ",
                        ".TAHITI.",
                        "     .  "
                    },new GridList {
                        "    . ",
                        ".EAST.",
                        "    A ",
                        "    H ",
                        "    I ",
                        "    T ",
                        "    I ",
                        "    . "
                    },new GridList {
                        " .    ",
                        ".CITY.",
                        " A    ",
                        " R    ",
                        " D    ",
                        " S    ",
                        " .    "
                    },new GridList {
                        " .   ",
                        " C   ",
                        " A   ",
                        " R   ",
                        " D   ",
                        ".SUN.",
                        " .   "
                    },new GridList {
                        "     .  ",
                        "     M  ",
                        "    .O  ",
                        "  .SUN. ",
                        "   .SEA.",
                        ".RELAY. ",
                        "    ..  "
                    },new GridList {
                        "  .    ",
                        ".MONEY.",
                        "  R    ",
                        "  I    ",
                        "  E    ",
                        "  N    ",
                        "  T    ",
                        "  .    "
                    },new GridList {
                        "   .   ",
                        "   A   ",
                        "   I   ",
                        ".CARDS.",
                        "   .   "
                    },new GridList {
                        "   .    ",
                        "   O    ",
                        " . R    ",
                        ".SWIM.  ",
                        " K E    ",
                        " I N    ",
                        " .ITALY.",
                        "   .    "
                    },new GridList {
                        "   . ",
                        "   I ",
                        "   T ",
                        "   A ",
                        "   L ",
                        ".FLY.",
                        "   . "
                    },new GridList {
                        "  .   ",
                        ".KEYS.",
                        "  A   ",
                        "  S   ",
                        "  T   ",
                        "  .   "
                    },new GridList {
                        "   .  ",
                        "   J  ",
                        "   O  ",
                        "   U  ",
                        "   R  ",
                        "   N  ",
                        "   E  ",
                        ".KEYS.",
                        "   .  "
                    },new GridList {
                        "   . .   ",
                        ".PORTS.  ",
                        "   O A   ",
                        ".JOURNEY.",
                        "   T D   ",
                        "   E .   ",
                        "   .     "
                    },new GridList {
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

                    return new List<GridList> {

                    new GridList {
                        "   . .  ",
                        "   S C  ",
                        "   H R  ",
                        "   I U  ",
                        "  .ROSE.",
                        "   A H  ",
                        ".FIZZ.  ",
                        "   .    "
                    },new GridList {
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
                    },new GridList {
                        "  .     ",
                        "  S     ",
                        "  C  .  ",
                        "  O  S  ",
                        " .TOKAY.",
                        "  C  C  ",
                        ".WHISKY.",
                        "  .  .  "
                    },new GridList {
                        "   .       ",
                        "   B       ",
                        " .PORPHYRY.",
                        " C O       ",
                        ".OUZO.     ",
                        " L E       ",
                        " A .       ",
                        " .         "
                    },new GridList {
                        "    .  ",
                        "    B  ",
                        "  . O  ",
                        "  C O  ",
                        " .OUZO.",
                        "  L E  ",
                        ".BAR.  ",
                        "  .    "
                    },new GridList {
                        "  .   ",
                        ".ASTI.",
                        "  C   ",
                        "  O   ",
                        "  T   ",
                        "  C   ",
                        "  H   ",
                        "  .   "
                    },new GridList {
                        "    . ",
                        "    A ",
                        "    S ",
                        ".PORT.",
                        "    I ",
                        "    . "
                    },new GridList {
                        " .    ",
                        " N    ",
                        " I    ",
                        ".PORT.",
                        " .    "
                    },new GridList {
                        "   .  ",
                        ".WINE.",
                        "   I  ",
                        "   P  ",
                        "   .  "
                    },new GridList {
                        " .     ",
                        ".WATER.",
                        " I     ",
                        " N     ",
                        " E     ",
                        " .     "
                    },new GridList {
                        "   . .   ",
                        "   M W   ",
                        "   I A   ",
                        ".SPLIT.  ",
                        "   K E   ",
                        "   .GROG.",
                        "     .   "
                    },new GridList {
                        " .     ",
                        ".SPLIT.",
                        " P     ",
                        " I     ",
                        " R     ",
                        " I     ",
                        " T     ",
                        " .     "
                    },new GridList {
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
                    },new GridList {
                        "  .  ",
                        "  T  ",
                        "  O  ",
                        "  D  ",
                        "  D  ",
                        ".RYE.",
                        "  .  "
                    },new GridList {
                        "   . ",
                        ".RUM.",
                        "   I ",
                        "   L ",
                        "   K ",
                        "   . "
                    },new GridList {
                        "    . ",
                        "    M ",
                        ".COKE.",
                        "    A ",
                        "    D ",
                        "    . "
                    }
                };

                case 8906:

                    return new List<GridList> {

                    new GridList {
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
                    },new GridList {
                        " . .   ",
                        " M C   ",
                        ".EPOCH.",
                        " T S   ",
                        " E M   ",
                        ".OZONE.",
                        " R S   ",
                        " . .   "
                    },new GridList {
                        "   . . ",
                        "   C P ",
                        ".EPOCH.",
                        "   S A ",
                        "   M S ",
                        ".OZONE.",
                        "   S . ",
                        "   .   "
                    },new GridList {
                        "   .    ",
                        "   C    ",
                        "   O    ",
                        "   M    ",
                        "   E    ",
                        ".METEOR.",
                        "   .    "
                    },new GridList {
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
                    },new GridList {
                        "   . .    ",
                        "  .SYZYGY.",
                        "   A E    ",
                        ".TITAN.   ",
                        "   U I    ",
                        "   R T    ",
                        "   N H    ",
                        "   . .    "
                    },new GridList {
                        "  .     ",
                        "  D     ",
                        "  A     ",
                        ".SYZYGY.",
                        "  .     "
                    },new GridList {
                        "    .   ",
                        "    S   ",
                        "    K   ",
                        ".SYZYGY.",
                        "    .   "
                    },new GridList {
                        "  .    ",
                        "  C    ",
                        "  R    ",
                        "  A    ",
                        "  T    ",
                        "  E    ",
                        ".ARIES.",
                        "  .    "
                    },new GridList {
                        " .     ",
                        ".ARIES.",
                        " R     ",
                        " C     ",
                        " .     "
                    },new GridList {
                        "      . ",
                        ".SYZYGY.",
                        "      E ",
                        "      A ",
                        "      R ",
                        "      . "
                    },new GridList {
                        " .   ",
                        ".SKY.",
                        " T   ",
                        " A   ",
                        " R   ",
                        " .   "
                    },new GridList {
                        " .     ",
                        " L     ",
                        " I     ",
                        " G     ",
                        " H     ",
                        ".TITAN.",
                        " .     "
                    },new GridList {
                        " .    ",
                        " T    ",
                        " I    ",
                        ".MOON.",
                        " E    ",
                        " .    "
                    },new GridList {
                        " .   ",
                        " A   ",
                        " R   ",
                        " I   ",
                        " E   ",
                        ".SUN.",
                        " .   "
                    },new GridList {
                        "  .  ",
                        ".SUN.",
                        "  R  ",
                        "  A  ",
                        "  N  ",
                        "  U  ",
                        "  S  ",
                        "  .  "
                    },new GridList {
                        "      . ",
                        "      U ",
                        "      R ",
                        ".URANUS.",
                        "      A ",
                        "      . "
                    },new GridList {
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

                    return new List<GridList> {

                    new GridList {
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
                    },new GridList {
                        "    .   ",
                        ".PUZZLE.",
                        "    I   ",
                        "    P   ",
                        "    P   ",
                        "    E   ",
                        "    R   ",
                        "    .   "
                    },new GridList {
                        "      .     ",
                        "      N     ",
                        "    .QUARTZ.",
                        "    H T     ",
                        ".SCRAPS.    ",
                        "    T .     ",
                        "    .       "
                    },new GridList {
                        "  . .  ",
                        ".BRUSH.",
                        "  O C  ",
                        "  D R  ",
                        "  .HAT.",
                        "    P  ",
                        "    S  ",
                        "    .  "
                    },new GridList {
                        "   .    ",
                        "   Q    ",
                        "   U  . ",
                        "   A  J ",
                        "  .ROPE.",
                        "   T  W ",
                        ".PUZZLE.",
                        "   .  L ",
                        "      . "
                    },new GridList {
                        "       .    ",
                        "     .BRUSH.",
                        "     B O    ",
                        ".PLYWOOD.   ",
                        "     W .    ",
                        "     .      "
                    },new GridList {
                        "   .   ",
                        "   P   ",
                        "   L.  ",
                        ".TOYS. ",
                        "  .WAX.",
                        " .BOW. ",
                        "   O.  ",
                        "   D   ",
                        "   .   "
                    },new GridList {
                        " .    ",
                        " L    ",
                        " A    ",
                        ".TOYS.",
                        " H    ",
                        " .    "
                    },new GridList {
                        "     . ",
                        ".TOOLS.",
                        "     H ",
                        "     A ",
                        "     P ",
                        "     E ",
                        "     . "
                    },new GridList {
                        " .     ",
                        " P     ",
                        " A     ",
                        " I     ",
                        " N     ",
                        ".TOOLS.",
                        " .     "
                    },new GridList {
                        "   .   ",
                        "   W   ",
                        ".TOOLS.",
                        "   O   ",
                        "   L   ",
                        "   .   "
                    },new GridList {
                        "    . ",
                        "    A ",
                        "    W ",
                        ".WOOL.",
                        "    . "
                    },new GridList {
                        "  .  ",
                        ".AWL.",
                        "  H  ",
                        "  E  ",
                        "  E  ",
                        "  L  ",
                        "  S  ",
                        "  .  "
                    },new GridList {
                        "     .  ",
                        "   . C  ",
                        ".WHEELS.",
                        "   A O  ",
                        "  .SEW. ",
                        "   E N  ",
                        "   L .  ",
                        "   .    "
                    },new GridList {
                        " .   ",
                        " C   ",
                        " L   ",
                        " O   ",
                        " W   ",
                        ".NET.",
                        " .   "
                    },new GridList {
                        "   . ",
                        "   N ",
                        "   E ",
                        ".CUT.",
                        "   . "
                    },new GridList {
                        "    .   ",
                        "    S   ",
                        ".ZIPPER.",
                        "    I   ",
                        "    N   ",
                        "    .   "
                    },new GridList {
                        "      . ",
                        "      D ",
                        ".ZIPPER.",
                        "      A ",
                        "      W ",
                        "      . "
                    }
                };

                case 8908:

                    return new List<GridList> {

                    new GridList {
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
                    },new GridList {
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
                    },new GridList {
                        "    .      ",
                        "    L.     ",
                        " .SKIS.    ",
                        "   .FLURRY.",
                        ".WHITE.    ",
                        "    .D     ",
                        "     .     "
                    },new GridList {
                        "    . ",
                        ".PASS.",
                        "    K ",
                        "    I ",
                        "    S ",
                        "    . "
                    },new GridList {
                        "   .  ",
                        "   G  ",
                        "   L  ",
                        "   O  ",
                        "   V  ",
                        "   E  ",
                        ".PASS.",
                        "   .  "
                    },new GridList {
                        "   . .  ",
                        "  .GEAR.",
                        "   L L  ",
                        "   O P  ",
                        ".DAVOS. ",
                        "   E .  ",
                        "   S    ",
                        "   .    "
                    },new GridList {
                        " .   ",
                        ".WET.",
                        " H   ",
                        " I   ",
                        " T   ",
                        " E   ",
                        " .   "
                    },new GridList {
                        "   . ",
                        "   Q ",
                        "   U ",
                        "   I ",
                        "   E ",
                        ".WET.",
                        "   . "
                    },new GridList {
                        "    . ",
                        "    C ",
                        "    O ",
                        ".SNOW.",
                        "    . "
                    },new GridList {
                        "  .    ",
                        "  L    ",
                        ".QUIET.",
                        "  G    ",
                        "  E    ",
                        "  .    "
                    },new GridList {
                        "        . ",
                        "        F ",
                        "        R ",
                        "        O ",
                        ".OLYMPICS.",
                        "        T ",
                        "        . "
                    },new GridList {
                        " .      ",
                        " P      ",
                        " O      ",
                        " W      ",
                        " D      ",
                        " E      ",
                        ".RESORT.",
                        " .      "
                    },new GridList {
                        " .     ",
                        " W     ",
                        " H     ",
                        ".ITALY.",
                        " T     ",
                        " E     ",
                        " .     "
                    },new GridList {
                        "     . ",
                        "     G ",
                        "     E ",
                        "     R ",
                        "     M ",
                        "     A ",
                        "     N ",
                        ".ITALY.",
                        "     . "
                    },new GridList {
                        " .     ",
                        " C     ",
                        " O     ",
                        " L     ",
                        ".DAVOS.",
                        " .     "
                    },new GridList {
                        " .   ",
                        " I   ",
                        ".COW.",
                        " E   ",
                        " .   "
                    }
                };

                case 8909:

                    return new List<GridList> {

                    new GridList {
                        "    .   ",
                        " .  P   ",
                        " A  A   ",
                        ".ZINNIA.",
                        " A  S   ",
                        ".LILY.  ",
                        " E  .   ",
                        " A      ",
                        " .      "
                    },new GridList {
                        "    .   ",
                        " .POPPY.",
                        " A  A   ",
                        ".ZINNIA.",
                        " A  S   ",
                        " L  Y   ",
                        " E  .   ",
                        " A      ",
                        " .      "
                    },new GridList {
                        "   . ",
                        "   P ",
                        "   O ",
                        "   P ",
                        "   P ",
                        ".MAY.",
                        "   . "
                    },new GridList {
                        " .   ",
                        " M   ",
                        " I   ",
                        ".MAY.",
                        " O   ",
                        " S   ",
                        " A   ",
                        " .   "
                    },new GridList {
                        "     .  ",
                        ".MIMOSA.",
                        "     A  ",
                        "     G  ",
                        "     E  ",
                        "     .  "
                    },new GridList {
                        "      . ",
                        ".AZALEA.",
                        "      L ",
                        "      O ",
                        "      E ",
                        "      . "
                    },new GridList {
                        " .     ",
                        " A     ",
                        " L     ",
                        ".OXLIP.",
                        " E     ",
                        " .     "
                    },new GridList {
                        "     .   ",
                        "     L   ",
                        "   . U   ",
                        ".OXLIP.  ",
                        "   O I   ",
                        "  .TANSY.",
                        "   U .   ",
                        "   S     ",
                        "   .     "
                    },new GridList {
                        "     .     ",
                        "     L     ",
                        "     O.    ",
                        "    .TANSY.",
                        ".CACTUS.   ",
                        "    .STOCK.",
                        "     .E    ",
                        "      R    ",
                        "      .    "
                    },new GridList {
                        "   . . ",
                        ".TULIP.",
                        "   U E ",
                        "   P O ",
                        "   I N ",
                        ".TANSY.",
                        "   . . "
                    },new GridList {
                        "   .     ",
                        "   B     ",
                        " .CACTUS.",
                        " I L     ",
                        ".ROSE.   ",
                        " I A     ",
                        " S M     ",
                        " . .     "
                    },new GridList {
                        "       .  ",
                        "       B  ",
                        "     . A  ",
                        "     I L  ",
                        "    .ROSE.",
                        "     I A  ",
                        ".ALYSSUM. ",
                        "     . .  "
                    },new GridList {
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

                    return new List<GridList> {

                    new GridList {
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
                    },new GridList {
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
                    },new GridList {
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
                    },new GridList {
                        " .      ",
                        ".PORTER.",
                        " I      ",
                        " L      ",
                        " O      ",
                        " T      ",
                        " .      "
                    },new GridList {
                        "  .     ",
                        "  S     ",
                        "  H     ",
                        "  E     ",
                        "  A     ",
                        "  R     ",
                        "  E     ",
                        ".BREWER.",
                        "  .     "
                    },new GridList {
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
                    },new GridList {
                        "     .    ",
                        "     C    ",
                        "    .R    ",
                        "   .VICAR.",
                        ".VALET.   ",
                        "   .TILER.",
                        "    .C    ",
                        "     .    "
                    },new GridList {
                        "   .   ",
                        ".NAVVY.",
                        "   A   ",
                        "   L   ",
                        "   E   ",
                        "   T   ",
                        "   .   "
                    },new GridList {
                        "     . ",
                        "     A ",
                        ".NAVVY.",
                        "     A ",
                        "     H ",
                        "     . "
                    },new GridList {
                        " .     ",
                        " M     ",
                        " O     ",
                        ".NAVVY.",
                        " K     ",
                        " .     "
                    },new GridList {
                        " .    ",
                        ".MONK.",
                        " A    ",
                        " I    ",
                        " D    ",
                        " .    "
                    },new GridList {
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

                    return new List<GridList> {

                    new GridList {
                        "  . .    ",
                        "  P F    ",
                        ".TRAINER.",
                        "  I E    ",
                        " .ZULU.  ",
                        "  E D    ",
                        "  . .    "
                    },new GridList {
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
                    },new GridList {
                        "       . ",
                        "       M ",
                        "       O ",
                        "       N ",
                        "       E ",
                        ".TUESDAY.",
                        "       . "
                    },new GridList {
                        "  . .   ",
                        "  T.W   ",
                        ".KIWI.  ",
                        " .MONEY.",
                        ".BETS.  ",
                        "  .A.   ",
                        "   N    ",
                        "   .    "
                    },new GridList {
                        "    .    ",
                        ".TUESDAY.",
                        "    I    ",
                        "    L    ",
                        "    K    ",
                        "    S    ",
                        "    .    "
                    },new GridList {
                        "     . ",
                        "     O ",
                        "     W ",
                        ".WOTAN.",
                        "     E ",
                        "     R ",
                        "     . "
                    },new GridList {
                        "  .  ",
                        "  C  ",
                        "  O  ",
                        ".RUN.",
                        "  R  ",
                        "  S  ",
                        "  E  ",
                        "  .  "
                    },new GridList {
                        "  .      ",
                        "  T .    ",
                        ".TUESDAY.",
                        "  R I    ",
                        " .FILLY. ",
                        "  . K    ",
                        "    S    ",
                        "    .    "
                    },new GridList {
                        " .     ",
                        " S     ",
                        " I     ",
                        " L     ",
                        " K     ",
                        ".START.",
                        " .     "
                    },new GridList {
                        "     . ",
                        "     C ",
                        "     O ",
                        "     L ",
                        ".START.",
                        "     . "
                    },new GridList {
                        " .   ",
                        ".CUP.",
                        " O   ",
                        " L   ",
                        " T   ",
                        " .   "
                    },new GridList {
                        " .    ",
                        " C    ",
                        " U    ",
                        ".POST.",
                        " .    "
                    },new GridList {
                        " .      ",
                        " T      ",
                        " R      ",
                        " A      ",
                        ".COURSE.",
                        " K      ",
                        " .      "
                    },new GridList {
                        " .   ",
                        ".TAB.",
                        " R   ",
                        " A   ",
                        " C   ",
                        " K   ",
                        " .   "
                    },new GridList {
                        "  .  ",
                        "  M  ",
                        "  A  ",
                        "  L  ",
                        "  U  ",
                        ".TAB.",
                        "  .  "
                    },new GridList {
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

                    return new List<GridList> {

                    new GridList {
                        "    .   ",
                        "    B   ",
                        ".HOLLY. ",
                        "    I C ",
                        "    T A ",
                        " .RAZOR.",
                        "    E D ",
                        "    N . ",
                        "    .   "
                    },new GridList {
                        "   .      ",
                        "   H      ",
                        "   O      ",
                        "  .L      ",
                        " .BLITZEN.",
                        ".JOY.     ",
                        "  X.      ",
                        "  .       "
                    },new GridList {
                        "        .   ",
                        "        B   ",
                        "        L   ",
                        "      . I   ",
                        "      I T   ",
                        "     .RAZOR.",
                        "      O E   ",
                        ".SEASONING. ",
                        "      . .   "
                    },new GridList {
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
                    },new GridList {
                        " .     ",
                        " W     ",
                        " A     ",
                        " T     ",
                        " C     ",
                        ".HOLLY.",
                        " .     "
                    },new GridList {
                        "   .    ",
                        ".TOYS.  ",
                        "   U W  ",
                        "   L A  ",
                        ".SWEETS.",
                        "   . C  ",
                        "     H  ",
                        "     .  "
                    },new GridList {
                        " . .    ",
                        ".TOYS.  ",
                        " I U    ",
                        " E L    ",
                        ".SWEETS.",
                        " . .    "
                    },new GridList {
                        "  . .  ",
                        " .VASE.",
                        "  I O  ",
                        "  D C  ",
                        "  E K  ",
                        ".TOYS. ",
                        "  . .  "
                    },new GridList {
                        "  .     ",
                        ".SWEETS.",
                        "  I     ",
                        "  N     ",
                        "  E     ",
                        "  .     "
                    },new GridList {
                        " .     ",
                        ".WATCH.",
                        " A     ",
                        " L     ",
                        " L     ",
                        " E     ",
                        " T     ",
                        " .     "
                    },new GridList {
                        "   .    ",
                        "   T    ",
                        "   I  . ",
                        "  .NUTS.",
                        "   S  A ",
                        "   E  N ",
                        ".WALLET.",
                        "   .  A ",
                        "      . "
                    },new GridList {
                        " .      ",
                        ".TINSEL.",
                        " R      ",
                        " E      ",
                        " E      ",
                        " .      "
                    }
                };

                case 9001:

                    return new List<GridList> {

                    new GridList {
                        "   . . ",
                        "   L M ",
                        " .EYRE.",
                        "   O N ",
                        ".JANTZ.",
                        "   S I ",
                        "   . E ",
                        "     S ",
                        "     . "
                    },new GridList {
                        "       . ",
                        "       F ",
                        "       I ",
                        ".MENZIES.",
                        "       K ",
                        "       . "
                    },new GridList {
                        " .       ",
                        ".MENZIES.",
                        " A       ",
                        " W       ",
                        " S       ",
                        " O       ",
                        " N       ",
                        " .       "
                    },new GridList {
                        " .     ",
                        " M     ",
                        " A     ",
                        " W     ",
                        " S     ",
                        ".OXLEY.",
                        " N     ",
                        " .     "
                    },new GridList {
                        "     . ",
                        "     B ",
                        "     O ",
                        ".OXLEY.",
                        "     D ",
                        "     . "
                    },new GridList {
                        "   .   ",
                        "   G   ",
                        "   O   ",
                        ".OXLEY.",
                        "   D   ",
                        "   .   "
                    },new GridList {
                        " .    ",
                        ".FYSH.",
                        " I    ",
                        " S    ",
                        " K    ",
                        " .    "
                    },new GridList {
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
                    },new GridList {
                        "    . ",
                        "    C ",
                        "    H ",
                        "    I ",
                        "    F ",
                        "    L ",
                        "    E ",
                        ".QUAY.",
                        "    . "
                    },new GridList {
                        "   .   ",
                        "   M   ",
                        ".STURT.",
                        "   R   ",
                        "   R   ",
                        "   A   ",
                        "   Y   ",
                        "   .   "
                    },new GridList {
                        "   .   . ",
                        ".ROBERTS.",
                        "   A   M ",
                        "   S   I ",
                        "  .STURT.",
                        "   .   H ",
                        "       . "
                    },new GridList {
                        "    . .     ",
                        "   .ROBERTS.",
                        "    E A     ",
                        ".SIRIUS.    ",
                        "    D S     ",
                        "    . .     "
                    },new GridList {
                        " .      ",
                        " F      ",
                        " I      ",
                        ".SIRIUS.",
                        " H      ",
                        " E      ",
                        " R      ",
                        " .      "
                    },new GridList {
                        "  .   ",
                        "  H   ",
                        ".QUAY.",
                        "  M   ",
                        "  E   ",
                        "  .   "
                    },new GridList {
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

                    return new List<GridList> {

                    new GridList {
                        " .  .   ",
                        ".AENEAS.",
                        " M  R   ",
                        " A  O   ",
                        ".ZEUS.  ",
                        " O  .   ",
                        " N      ",
                        " S      ",
                        " .      "
                    },new GridList {
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
                    },new GridList {
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
                    },new GridList {
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
                    },new GridList {
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
                    },new GridList {
                        "       . ",
                        "       E ",
                        "       R ",
                        "       I ",
                        ".ROMULUS.",
                        "       . "
                    },new GridList {
                        "       . ",
                        "       C ",
                        "       H ",
                        "       A ",
                        "       O ",
                        ".ULYSSES.",
                        "       . "
                    },new GridList {
                        "      .  ",
                        ".AMAZONS.",
                        "      I  ",
                        "      K  ",
                        "      E  ",
                        "      .  "
                    },new GridList {
                        "   .  ",
                        ".NIKE.",
                        "   A  ",
                        "   M  ",
                        "   A  ",
                        "   .  "
                    }
                };

                case 9003:

                    return new List<GridList> {

                    new GridList {
                        "       . ",
                        "    .  S ",
                        "    B  Y ",
                        "    R  D ",
                        "   .EDEN.",
                        "    E  E ",
                        ".FITZROY.",
                        "    A  . ",
                        "    .    "
                    },new GridList {
                        "  .      ",
                        "  B      ",
                        "  U      ",
                        "  N .    ",
                        " .BREEZA.",
                        "  U D    ",
                        "  R E    ",
                        ".SYDNEY. ",
                        "  . .    "
                    },new GridList {
                        "  .      ",
                        "  Q .    ",
                        ".BUNBURY.",
                        "  I R    ",
                        "  L E    ",
                        "  P E    ",
                        ".FITZROY.",
                        "  E A    ",
                        "  . .    "
                    },new GridList {
                        "      .  ",
                        ".FITZROY.",
                        "      U  ",
                        "      Y  ",
                        "      E  ",
                        "      N  ",
                        "      .  "
                    },new GridList {
                        "  .  ",
                        "  O  ",
                        "  U  ",
                        ".AYR.",
                        "  E  ",
                        "  N  ",
                        "  .  "
                    },new GridList {
                        "    .  ",
                        "    O  ",
                        "    U  ",
                        "    Y  ",
                        "    E  ",
                        ".YOUNG.",
                        "    .  "
                    },new GridList {
                        " .     ",
                        " H     ",
                        " A     ",
                        ".YOUNG.",
                        " .     "
                    },new GridList {
                        "    .    ",
                        "    N    ",
                        "    H    ",
                        "    I    ",
                        "    L    ",
                        ".QUILPIE.",
                        "    .    "
                    },new GridList {
                        "    .  ",
                        ".LORNE.",
                        "    H  ",
                        "    I  ",
                        "    L  ",
                        "    L  ",
                        "    .  "
                    },new GridList {
                        "   .   ",
                        "   E . ",
                        ".TEXAS.",
                        "   E C ",
                        "   T O ",
                        "   E N ",
                        ".LORNE.",
                        "   . . "
                    },new GridList {
                        " . .   ",
                        " S E   ",
                        ".TEXAS.",
                        " A E   ",
                        " W T   ",
                        " E E   ",
                        ".LORNE.",
                        " L .   ",
                        " .     "
                    },new GridList {
                        "    .    ",
                        ".SCONE.  ",
                        "    O B  ",
                        "   .WYEE.",
                        "    R G  ",
                        "    A A  ",
                        "    . .  "
                    },new GridList {
                        "   .     ",
                        "   B     ",
                        ".WYEE.   ",
                        "   G M   ",
                        "  .AVOCA.",
                        "   . E   ",
                        "     .   "
                    },new GridList {
                        "  .    ",
                        ".SCONE.",
                        "  A    ",
                        "  I    ",
                        "  R    ",
                        "  N    ",
                        "  S    ",
                        "  .    "
                    },new GridList {
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

                    return new List<GridList> {

                    new GridList {
                        " .    ",
                        " Q    ",
                        " U    ",
                        " A    ",
                        " R    ",
                        " T    ",
                        ".ZINC.",
                        " .    "
                    },new GridList {
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
                    },new GridList {
                        "        . ",
                        "        P ",
                        ".PORPHYRY.",
                        "        R ",
                        "        I ",
                        "        T ",
                        "        E ",
                        "        S ",
                        "        . "
                    },new GridList {
                        "      . ",
                        "      C ",
                        "      L ",
                        "      A ",
                        ".QUARRY.",
                        "      . "
                    },new GridList {
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
                    },new GridList {
                        " . .     ",
                        " R G     ",
                        ".ONYX.   ",
                        " C P     ",
                        " K S     ",
                        " .QUARTZ.",
                        "   M     ",
                        "   .     "
                    },new GridList {
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
                    },new GridList {
                        " . .    ",
                        ".JET.   ",
                        " A A    ",
                        ".SILVER.",
                        " P C    ",
                        " E .    ",
                        " R      ",
                        " .      "
                    },new GridList {
                        " .        ",
                        ".PORPHYRY.",
                        " E        ",
                        " W        ",
                        " T        ",
                        " E        ",
                        " R        ",
                        " .        "
                    },new GridList {
                        "    . . ",
                        " .TOPAZ.",
                        "    I I ",
                        ".PEWTER.",
                        "    . C ",
                        "      O ",
                        "      N ",
                        "      . "
                    },new GridList {
                        "      . ",
                        "      I ",
                        "      R ",
                        "      O ",
                        ".ZIRCON.",
                        "      . "
                    },new GridList {
                        "   .  ",
                        ".IRON.",
                        "   C  ",
                        "   H  ",
                        "   R  ",
                        "   E  ",
                        "   .  "
                    },new GridList {
                        "    .  ",
                        "    F  ",
                        "    A  ",
                        "    C  ",
                        ".STEEL.",
                        "    .  "
                    },new GridList {
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

                    return new List<GridList> {

                    new GridList {
                        "   .     ",
                        "   B .   ",
                        "   I J   ",
                        ".MEZZO.  ",
                        "   E A   ",
                        "  .TENOR.",
                        "   . .   "
                    },new GridList {
                        "     .    ",
                        "    .T    ",
                        ".TENOR.   ",
                        "   .PINZA.",
                        "  .DUO.   ",
                        "    S.    ",
                        "    .     "
                    },new GridList {
                        "   .    ",
                        " . P    ",
                        ".TRIO.  ",
                        " E N    ",
                        ".MOZART.",
                        " P A    ",
                        " O .    ",
                        " .      "
                    },new GridList {
                        "   .     ",
                        "   P  .  ",
                        "   I  B  ",
                        "   N  A  ",
                        ".MOZART. ",
                        "   A  O  ",
                        "   .LIND.",
                        "      .  "
                    },new GridList {
                        "    .   ",
                        "    C   ",
                        "    H   ",
                        "    O   ",
                        "   .R   ",
                        "  .DUET.",
                        ".OPUS.  ",
                        "   O.   ",
                        "   .    "
                    },new GridList {
                        "   . .  ",
                        "   S D  ",
                        ".CHORUS.",
                        "   L E  ",
                        " .FORTE.",
                        "   . .  "
                    },new GridList {
                        "  . .  ",
                        "  R T  ",
                        ".TUNE. ",
                        "  F M  ",
                        "  F P  ",
                        " .OBOE.",
                        "  . .  "
                    },new GridList {
                        " .      ",
                        " D      ",
                        " A      ",
                        " N      ",
                        ".CHORUS.",
                        " E      ",
                        " .      "
                    },new GridList {
                        "     . ",
                        "     D ",
                        "  .  A ",
                        ".HAYDN.",
                        "  L  C ",
                        ".STAGE.",
                        "  O  . ",
                        "  .    "
                    },new GridList {
                        "       . ",
                        "       H ",
                        "       A ",
                        ".SCENERY.",
                        "       D ",
                        "       N ",
                        "       . "
                    },new GridList {
                        " .  .    ",
                        ".BASSO.  ",
                        " A  O    ",
                        ".SCENERY.",
                        " S  G    ",
                        " .  .    "
                    }
                };

                case 9006:

                    return new List<GridList> {

                    new GridList {
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
                    },new GridList {
                        "        .     ",
                        "        D     ",
                        "       .O     ",
                        "      .BRONZE.",
                        ".STINGRAY.    ",
                        "       S.     ",
                        "       S      ",
                        "       .      "
                    },new GridList {
                        "  .     ",
                        "  D   . ",
                        ".ZANDER.",
                        "  R   A ",
                        " .TUNNY.",
                        "  .   . "
                    },new GridList {
                        "       .     ",
                        "       B     ",
                        ".STINGRAY.   ",
                        "       S T   ",
                        "      .SQUID.",
                        "       . N   ",
                        "         A   ",
                        "         .   "
                    },new GridList {
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
                    },new GridList {
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
                    },new GridList {
                        "      .  ",
                        "      W  ",
                        "    . H  ",
                        "   .SEAL.",
                        "    A L  ",
                        ".BRONZE. ",
                        "    D R  ",
                        "    . .  "
                    },new GridList {
                        "      . ",
                        ".MINNOW.",
                        "      H ",
                        "      A ",
                        "      L ",
                        "      E ",
                        "      R ",
                        "      . "
                    },new GridList {
                        "   . . ",
                        ".BREAM.",
                        "   X A ",
                        "   P N ",
                        ".TROUT.",
                        "   R A ",
                        "   T . ",
                        "   .   "
                    },new GridList {
                        " .        ",
                        " N        ",
                        " E        ",
                        " T        ",
                        ".STINGRAY.",
                        " .        "
                    },new GridList {
                        " .    ",
                        " L    ",
                        " I    ",
                        ".NETS.",
                        " E    ",
                        " .    "
                    },new GridList {
                        " . .  ",
                        ".SOLE.",
                        " H I  ",
                        " A N  ",
                        ".ROE. ",
                        " K .  ",
                        " .    "
                    },new GridList {
                        " .   ",
                        ".BOX.",
                        " O   ",
                        " N   ",
                        " I   ",
                        " T   ",
                        " O   ",
                        " .   "
                    },new GridList {
                        "   . ",
                        "   L ",
                        "   A ",
                        ".BOX.",
                        "   . "
                    },new GridList {
                        " .   ",
                        " E   ",
                        " E   ",
                        ".LAX.",
                        " .   "
                    },new GridList {
                        "    . ",
                        "    O ",
                        "    R ",
                        "    C ",
                        ".TUNA.",
                        "    . "
                    }
                };

                case 9007:

                    return new List<GridList> {

                    new GridList {
                        "    . . ",
                        "  .JAZZ.",
                        "    D O ",
                        "    A N ",
                        "    M E ",
                        ".KANSAS.",
                        "    . . "
                    },new GridList {
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
                    },new GridList {
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
                    },new GridList {
                        "    .   ",
                        ".NIXON. ",
                        "    H L ",
                        "    I E ",
                        "  .HOWE.",
                        "    . . "
                    },new GridList {
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
                    },new GridList {
                        "  . .       ",
                        "  B T       ",
                        ".JULY.      ",
                        "  S L       ",
                        "  H E       ",
                        "  .ARKANSAS.",
                        "    .       "
                    },new GridList {
                        " .     ",
                        ".TYLER.",
                        " E     ",
                        " X     ",
                        " A     ",
                        " S     ",
                        " .     "
                    },new GridList {
                        "    .    ",
                        ".WEBSTER.",
                        "    E    ",
                        "    Q    ",
                        "    U    ",
                        "    O    ",
                        "    I    ",
                        "    A    ",
                        "    .    "
                    },new GridList {
                        "    .    ",
                        "    Q .  ",
                        ".SEQUOIA.",
                        "    O O  ",
                        "  .STOWE.",
                        "    A A  ",
                        "    . .  "
                    },new GridList {
                        "    . ",
                        "    W ",
                        "    E ",
                        "    B ",
                        "    S ",
                        ".TAFT.",
                        "    E ",
                        "    R ",
                        "    . "
                    },new GridList {
                        "  .   ",
                        ".UTAH.",
                        "  A   ",
                        "  F   ",
                        "  T   ",
                        "  .   "
                    }
                };

                case 9008:

                    return new List<GridList> {

                    new GridList {
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
                    },new GridList {
                        "    .         ",
                        "    Q         ",
                        "  .EUCALYPTUS.",
                        "  G E         ",
                        ".HUON.        ",
                        "  M A         ",
                        "  . .         "
                    },new GridList {
                        "    .    ",
                        "    B    ",
                        "    U    ",
                        "    T .  ",
                        "    T Y  ",
                        "  .CORAL.",
                        "    N M  ",
                        ".SASSY.  ",
                        "    .    "
                    },new GridList {
                        "   . .    ",
                        ".SASSY.   ",
                        "   I A    ",
                        "   M L    ",
                        ".SALTBUSH.",
                        "   A A    ",
                        "   X H    ",
                        "   . .    "
                    },new GridList {
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
                    },new GridList {
                        "   . ",
                        "   S ",
                        "   I ",
                        "   M ",
                        "   L ",
                        "   A ",
                        ".WAX.",
                        "   . "
                    },new GridList {
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
                    },new GridList {
                        "     .    ",
                        "     Y    ",
                        "     A    ",
                        "     L  . ",
                        ".SALTBUSH.",
                        "     A  O ",
                        "    .HOOP.",
                        "     .  . "
                    },new GridList {
                        "    . .     ",
                        "    Y M     ",
                        ".EUCALYPTUS.",
                        "    C A     ",
                        "   .COLANE. ",
                        "    A L     ",
                        "    . .     "
                    },new GridList {
                        "  .  ",
                        ".HOP.",
                        "  A  ",
                        "  K  ",
                        "  .  "
                    },new GridList {
                        "      . ",
                        "      H ",
                        ".MYRTLE.",
                        "      A ",
                        "      T ",
                        "      H ",
                        "      . "
                    },new GridList {
                        "  .      ",
                        "  M      ",
                        ".CYPRESS.",
                        "  R      ",
                        "  T      ",
                        "  L      ",
                        "  E      ",
                        "  .      "
                    },new GridList {
                        "      .  ",
                        "      A  ",
                        ".CYPRESS.",
                        "      H  ",
                        "      .  "
                    }
                };

                case 9009:

                    return new List<GridList> {

                    new GridList {
                        "    . . ",
                        ".ZIGZAG.",
                        "    O U ",
                        "    N L ",
                        "  .REEF.",
                        "    . . "
                    },new GridList {
                        " .      ",
                        ".ZIGZAG.",
                        " E      ",
                        " N      ",
                        " I      ",
                        " T      ",
                        " H      ",
                        " .      "
                    },new GridList {
                        "     ..      ",
                        "    .WIND.   ",
                        ".CABLES.     ",
                        "    .STREETS.",
                        ".ZENITH.     ",
                        "     .M      ",
                        "      U      ",
                        "      S      ",
                        "      .      "
                    },new GridList {
                        "     . .   ",
                        ".ISTHMUS.  ",
                        "     E E   ",
                        "  .ESTUARY.",
                        "     R .   ",
                        "     E     ",
                        "     S     ",
                        "     .     "
                    },new GridList {
                        "       . ",
                        "       B ",
                        "       A ",
                        ".ESTUARY.",
                        "       . "
                    },new GridList {
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
                    },new GridList {
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
                    },new GridList {
                        "     .  ",
                        "     R  ",
                        "   . O  ",
                        "   S U  ",
                        " .SOUTH.",
                        "   I E  ",
                        ".ATLAS. ",
                        "   . .  "
                    },new GridList {
                        " . .   ",
                        " A C   ",
                        ".SPACE.",
                        " I B   ",
                        " A L   ",
                        " .WEST.",
                        "   S   ",
                        "   .   "
                    },new GridList {
                        "  .   ",
                        ".EAST.",
                        "  T   ",
                        "  L   ",
                        "  A   ",
                        "  S   ",
                        "  .   "
                    },new GridList {
                        "   .  ",
                        "   T  ",
                        "   R  ",
                        "   E  ",
                        "   E  ",
                        ".EAST.",
                        "   .  "
                    },new GridList {
                        "    . ",
                        ".EAST.",
                        "    R ",
                        "    O ",
                        "    P ",
                        "    I ",
                        "    C ",
                        "    . "
                    },new GridList {
                        "    .  ",
                        ".PORTS.",
                        "    R  ",
                        "    E  ",
                        "    E  ",
                        "    S  ",
                        "    .  "
                    },new GridList {
                        "   .   ",
                        "   A   ",
                        "   R   ",
                        ".TREES.",
                        "   A   ",
                        "   .   "
                    }
                };

                case 9010:

                    return new List<GridList> {

                    new GridList {
                        "  .    ",
                        "  D .  ",
                        ".TRICK.",
                        "  A R  ",
                        "  M A  ",
                        ".JAZZ. ",
                        "  . Y  ",
                        "    .  "
                    },new GridList {
                        "    . ",
                        "    T ",
                        "    R ",
                        "    I ",
                        "    C ",
                        ".MASK.",
                        "    . "
                    },new GridList {
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
                    },new GridList {
                        "  .       ",
                        "  A  .    ",
                        "  C  D    ",
                        ".STAGE.   ",
                        "  O  B    ",
                        "  R  U    ",
                        "  .MOTLEY.",
                        "     .    "
                    },new GridList {
                        "   .    ",
                        "   D  . ",
                        "   E  P ",
                        "  .BILL.",
                        "   U  A ",
                        ".MOTLEY.",
                        "   .  . "
                    },new GridList {
                        "       .  ",
                        "       A  ",
                        "   .   C  ",
                        "   C   T  ",
                        "  .AUTHOR.",
                        "   S   R  ",
                        ".SATIRE.  ",
                        "   .      "
                    },new GridList {
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
                    },new GridList {
                        "     .  ",
                        "     P  ",
                        "     I  ",
                        ".TIGHTS.",
                        "     .  "
                    },new GridList {
                        " .      ",
                        " H      ",
                        " I      ",
                        ".TIGHTS.",
                        " .      "
                    },new GridList {
                        "     . ",
                        ".WINGS.",
                        "     M ",
                        "     A ",
                        "     S ",
                        "     H ",
                        "     . "
                    },new GridList {
                        "   .   ",
                        "  .B.  ",
                        ".SHOW. ",
                        " .EXIT.",
                        "  R.N  ",
                        "  O G  ",
                        "  . S  ",
                        "    .  "
                    },new GridList {
                        "  . . ",
                        ".SHOW.",
                        "  E I ",
                        "  R N ",
                        ".SONG.",
                        "  . S ",
                        "    . "
                    },new GridList {
                        " .   ",
                        ".SET.",
                        " O   ",
                        " N   ",
                        " G   ",
                        " .   "
                    },new GridList {
                        " .    ",
                        " G    ",
                        " O    ",
                        " D    ",
                        ".SHOW.",
                        " .    "
                    },new GridList {
                        " .    ",
                        ".GODS.",
                        " A    ",
                        " G    ",
                        " .    "
                    }
                };

                case 9011:

                    return new List<GridList> {

                    new GridList {
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
                    },new GridList {
                        "   .      ",
                        "   T .    ",
                        "   I W    ",
                        ".ZIMBABWE.",
                        "   E L    ",
                        "   .TEA.  ",
                        "     S    ",
                        "     .    "
                    },new GridList {
                        "     .   ",
                        "     C   ",
                        "    .L   ",
                        "   .TAXI.",
                        ".WALES.  ",
                        "   .ASIA.",
                        "    ..   "
                    },new GridList {
                        "   . .   ",
                        "   T A   ",
                        ".CLASS.  ",
                        "   X I   ",
                        "  .ITALY.",
                        "   . .   "
                    },new GridList {
                        "    . ",
                        "    I ",
                        "    T ",
                        "    A ",
                        "    L ",
                        ".ORLY.",
                        "    . "
                    },new GridList {
                        "       .  ",
                        "       V  ",
                        "       I  ",
                        "       E  ",
                        ".ZIMBABWE.",
                        "       .  "
                    },new GridList {
                        " .      ",
                        " I      ",
                        ".TURKEY.",
                        " A      ",
                        " L      ",
                        " Y      ",
                        " .      "
                    },new GridList {
                        "   .  .  ",
                        "   P  O  ",
                        "   A  X  ",
                        ".TURKEY. ",
                        "   I  G  ",
                        "  .SLEEP.",
                        "   .  N  ",
                        "      .  "
                    },new GridList {
                        "   .  .  ",
                        "  .PILOT.",
                        "   A  X  ",
                        ".TURKEY. ",
                        "   I  G  ",
                        "   S  E  ",
                        "   .  N  ",
                        "      .  "
                    },new GridList {
                        "   .   ",
                        "   S . ",
                        "   A P ",
                        "   F I ",
                        " .MEAL.",
                        "   T O ",
                        ".EGYPT.",
                        "   . . "
                    },new GridList {
                        "    .      ",
                        ".TRAVEL.   ",
                        "    I  M   ",
                        "   .SAFETY.",
                        "    A  A   ",
                        "    .  L   ",
                        "       .   "
                    },new GridList {
                        " .   ",
                        " T   ",
                        ".RUG.",
                        " A   ",
                        " V   ",
                        " E   ",
                        " L   ",
                        " .   "
                    },new GridList {
                        " .      ",
                        " I      ",
                        ".NARITA.",
                        " D      ",
                        " I      ",
                        " A      ",
                        " .      "
                    },new GridList {
                        "  .   ",
                        "  F   ",
                        ".VIEW.",
                        "  N   ",
                        "  .   "
                    }
                };

                case 9012:

                    return new List<GridList> {

                    new GridList {
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
                    },new GridList {
                        " . .    ",
                        ".FUTURE.",
                        " I U    ",
                        " R R    ",
                        ".MONEY. ",
                        " . E    ",
                        "   R    ",
                        "   .    "
                    },new GridList {
                        " .      ",
                        " D      ",
                        " R      ",
                        " E      ",
                        " A      ",
                        ".MARLEY.",
                        " .      "
                    },new GridList {
                        "  .     ",
                        "  T     ",
                        "  U     ",
                        "  R     ",
                        "  N     ",
                        "  E     ",
                        ".FROSTY.",
                        "  .     "
                    },new GridList {
                        "      . ",
                        "      H ",
                        "      A ",
                        "      P ",
                        "      P ",
                        ".FROSTY.",
                        "      . "
                    },new GridList {
                        "  . .   ",
                        " .HAPPY.",
                        "  O A   ",
                        ".BLESS. ",
                        "  L T   ",
                        "  Y .   ",
                        "  .     "
                    },new GridList {
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
                    },new GridList {
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
                    },new GridList {
                        "    .  ",
                        " .  W  ",
                        " F  I  ",
                        " O  N  ",
                        ".GRATE.",
                        " G  E  ",
                        ".YEAR. ",
                        " .  .  "
                    },new GridList {
                        "   .      ",
                        "   B      ",
                        "   L      ",
                        "   E.     ",
                        ".PAST.    ",
                        "  .SILVER.",
                        "   .M     ",
                        "    .     "
                    },new GridList {
                        "      .  ",
                        "      P  ",
                        "    .BOB.",
                        "    E O  ",
                        ".SILVER. ",
                        "    E .  ",
                        "    .    "
                    },new GridList {
                        "    .    ",
                        ".GHOST.  ",
                        "    O N  ",
                        "  .SLEET.",
                        "    E W  ",
                        "    . .  "
                    },new GridList {
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

                    return new List<GridList> {

                    new GridList {
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
                    },new GridList {
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
                    },new GridList {
                        " .     ",
                        ".SPORT.",
                        " L     ",
                        " E     ",
                        " E     ",
                        " P     ",
                        " .     "
                    },new GridList {
                        "    .    ",
                        "    O    ",
                        "    A.   ",
                        ".SPORT.  ",
                        "   .SAND.",
                        "    .N   ",
                        "     .   "
                    },new GridList {
                        "  .     ",
                        ".FOREST.",
                        "  A     ",
                        "  R     ",
                        "  S     ",
                        "  .     "
                    },new GridList {
                        "     .  ",
                        ".FOREST.",
                        "     P  ",
                        "     A  ",
                        "     D  ",
                        "     E  ",
                        "     .  "
                    },new GridList {
                        " .         ",
                        " S         ",
                        " P         ",
                        ".AMUSEMENT.",
                        " D         ",
                        " E         ",
                        " .         "
                    },new GridList {
                        "    .      ",
                        "   .C.     ",
                        "  .BAT.    ",
                        ".AMUSEMENT.",
                        "  .SUN.    ",
                        "  .HAT.    ",
                        "   .L.     ",
                        "    .      "
                    },new GridList {
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
                    },new GridList {
                        "      .   ",
                        "      D   ",
                        "    .QUAY.",
                        "    F N   ",
                        "    U E   ",
                        ".TENNIS.  ",
                        "    . .   "
                    },new GridList {
                        "    . ",
                        "    F ",
                        "    L ",
                        ".QUAY.",
                        "    I ",
                        "    N ",
                        "    G ",
                        "    . "
                    },new GridList {
                        "       .   ",
                        "       R   ",
                        "       E   ",
                        ".AMUSEMENT.",
                        "       F   ",
                        "       .   "
                    },new GridList {
                        " .   ",
                        ".ROD.",
                        " E   ",
                        " E   ",
                        " F   ",
                        " .   "
                    }
                };

                case 9102:

                    return new List<GridList> {

                    new GridList {
                        "    .    ",
                        "    L    ",
                        "   .A    ",
                        "  .SPEED.",
                        " .DOT.   ",
                        ".CANON.  ",
                        " .TYPE.  ",
                        "  A..C   ",
                        "  .  .   "
                    },new GridList {
                        " .      ",
                        " S      ",
                        " C      ",
                        " R      ",
                        " O      ",
                        ".LAPTOP.",
                        " L      ",
                        " .      "
                    },new GridList {
                        "  . .  ",
                        "  F S  ",
                        ".PITCH.",
                        "  L R  ",
                        ".ZERO. ",
                        "  . L  ",
                        "    L  ",
                        "    .  "
                    },new GridList {
                        " .    ",
                        ".ZERO.",
                        " E    ",
                        " N    ",
                        " I    ",
                        " T    ",
                        " H    ",
                        " .    "
                    },new GridList {
                        "     .  ",
                        ".ZENITH.",
                        "     A  ",
                        "     P  ",
                        "     E  ",
                        "     .  "
                    },new GridList {
                        "  .    ",
                        "  T    ",
                        "  A    ",
                        ".EPSON.",
                        "  E    ",
                        "  .    "
                    },new GridList {
                        "   .  ",
                        "   E  ",
                        "   P  ",
                        "   S  ",
                        "   O  ",
                        ".MENU.",
                        "   .  "
                    },new GridList {
                        " . .   ",
                        ".MOUSE.",
                        " E N   ",
                        " N I   ",
                        " U S   ",
                        " .WYSE.",
                        "   S   ",
                        "   .   "
                    },new GridList {
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
                    },new GridList {
                        " . .  ",
                        ".WYSE.",
                        " I C  ",
                        " N R  ",
                        " D E  ",
                        " O E  ",
                        ".WANG.",
                        " . .  "
                    },new GridList {
                        "     .  ",
                        "     V  ",
                        "     I  ",
                        "     D  ",
                        "     E  ",
                        ".WINDOW.",
                        "     .  "
                    },new GridList {
                        "  . .  ",
                        ".DRIVE.",
                        "  A I  ",
                        " .MODE.",
                        "  . E  ",
                        "    O  ",
                        "    .  "
                    },new GridList {
                        "   .    ",
                        ".UNISYS.",
                        "   B    ",
                        "   M    ",
                        "   .    "
                    }
                };

                case 9103:

                    return new List<GridList> {

                    new GridList {
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
                    },new GridList {
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
                    },new GridList {
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
                    },new GridList {
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
                    },new GridList {
                        "      .     ",
                        "      A     ",
                        "      L.    ",
                        "     .PELEE.",
                        ".EVEREST.   ",
                        "      .N    ",
                        "       A    ",
                        "       .    "
                    },new GridList {
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
                    },new GridList {
                        "      . .   ",
                        ".JUNGFRAU.  ",
                        "      I R   ",
                        "      G A   ",
                        "  .MCKINLEY.",
                        "      . .   "
                    },new GridList {
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
                    },new GridList {
                        "    . ",
                        ".SNOW.",
                        "    H ",
                        "    I ",
                        "    T ",
                        "    E ",
                        "    . "
                    },new GridList {
                        "    .  ",
                        " .ALPS.",
                        " P  E  ",
                        " E  L  ",
                        ".ANDES.",
                        " K  E  ",
                        " .  .  "
                    },new GridList {
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

                    return new List<GridList> {

                    new GridList {
                        " .    ",
                        ".ZERO.",
                        " E    ",
                        " N    ",
                        " I    ",
                        " T    ",
                        " H    ",
                        " .    "
                    },new GridList {
                        "      .    ",
                        "     .E    ",
                        "    .WAVES.",
                        " .STEER.   ",
                        "    .STARS.",
                        ".ZENITH.   ",
                        "     ..    "
                    },new GridList {
                        "    ..     ",
                        "   .TABLES.",
                        "  .FIX.    ",
                        "   .MIDDAY.",
                        ".WAVES.    ",
                        "    ..     "
                    },new GridList {
                        " . .  ",
                        ".TIME.",
                        " A I  ",
                        " B D  ",
                        " L D  ",
                        " E A  ",
                        ".SKY. ",
                        " . .  "
                    },new GridList {
                        "   .    ",
                        "   S    ",
                        "   E .  ",
                        "   X W  ",
                        " .STEER.",
                        "   A S  ",
                        ".ZENITH.",
                        "   T .  ",
                        "   .    "
                    },new GridList {
                        "   . . ",
                        ".PILOT.",
                        "   E R ",
                        " .ZERO.",
                        "   . P ",
                        "     I ",
                        "     C ",
                        "     S ",
                        "     . "
                    },new GridList {
                        "     . ",
                        ".STARS.",
                        "     I ",
                        "     G ",
                        "     N ",
                        "     S ",
                        "     . "
                    },new GridList {
                        " .  .  ",
                        " S  O  ",
                        " I  R  ",
                        ".GLOBE.",
                        " N  I  ",
                        ".SOUTH.",
                        " .  .  "
                    },new GridList {
                        " .   ",
                        ".SUN.",
                        " E   ",
                        " X   ",
                        " T   ",
                        " A   ",
                        " N   ",
                        " T   ",
                        " .   "
                    },new GridList {
                        " .     ",
                        " L     ",
                        ".ORBIT.",
                        " G     ",
                        " .     "
                    },new GridList {
                        "    .  ",
                        "    M  ",
                        "    O  ",
                        "    O  ",
                        ".SIGNS.",
                        "    .  "
                    },new GridList {
                        "  .  ",
                        "  M  ",
                        ".BOX.",
                        "  O  ",
                        "  N  ",
                        "  .  "
                    },new GridList {
                        "  .      ",
                        "  R      ",
                        "  A      ",
                        "  N      ",
                        "  G      ",
                        ".SEXTANT.",
                        "  .      "
                    },new GridList {
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

                    return new List<GridList> {

                    new GridList {
                        "       . ",
                        "       M ",
                        "     . A ",
                        "     L J ",
                        "   .COLE.",
                        "     U S ",
                        "     I T ",
                        ".DYNASTY.",
                        "     . . "
                    },new GridList {
                        "  .      ",
                        "  R      ",
                        "  O      ",
                        "  Y      ",
                        "  A      ",
                        "  L      ",
                        "  T      ",
                        ".DYNASTY.",
                        "  .      "
                    },new GridList {
                        "     . .   ",
                        "     H A   ",
                        "     E T   ",
                        ".CABINET.  ",
                        "     R I   ",
                        "  .ROYALTY.",
                        "     . A   ",
                        "       .   "
                    },new GridList {
                        "     .     ",
                        "   . H     ",
                        "   O E     ",
                        ".CABINET.  ",
                        "   E R     ",
                        "  .ROYALTY.",
                        "   O .     ",
                        "   N       ",
                        "   .       "
                    },new GridList {
                        "     .  ",
                        "     O  ",
                        "     B  ",
                        "     E  ",
                        "     R  ",
                        "     O  ",
                        ".REGENT.",
                        "     .  "
                    },new GridList {
                        "      .     ",
                        "      E     ",
                        "      M     ",
                        "     .P     ",
                        "    .REGENT.",
                        ".ARTHUR.    ",
                        "    .LORD.  ",
                        ".BANNER.    ",
                        "     ..     "
                    },new GridList {
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
                    },new GridList {
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
                    },new GridList {
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

                    return new List<GridList> {

                    new GridList {
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
                    },new GridList {
                        "      . .   ",
                        ".ZEPHYRUS.  ",
                        "      H A   ",
                        "    .NESTOR.",
                        "      A U   ",
                        "      . R   ",
                        "        N   ",
                        "        .   "
                    },new GridList {
                        "   .  . ",
                        "   N  A ",
                        "   E  D ",
                        "   S  O ",
                        ".SATURN.",
                        "   O  I ",
                        ".FURIES.",
                        "   .  . "
                    },new GridList {
                        "   . .  ",
                        ".ADONIS.",
                        "   D O  ",
                        ".ORION. ",
                        "   N I  ",
                        "   . A  ",
                        "     .  "
                    },new GridList {
                        "  . .  ",
                        ".JASON.",
                        "  D R  ",
                        " .ODIN.",
                        "  N O  ",
                        "  I N  ",
                        "  S .  ",
                        "  .    "
                    },new GridList {
                        "     .     ",
                        "   . C     ",
                        "  .MERCURY.",
                        "   A E     ",
                        "   R O     ",
                        ".JASON.    ",
                        "   . .     "
                    },new GridList {
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
                    },new GridList {
                        "    .     ",
                        "    O .   ",
                        "    L I   ",
                        " .ULYSSES.",
                        "    M I   ",
                        ".NYMPHS.  ",
                        "    U .   ",
                        "    S     ",
                        "    .     "
                    },new GridList {
                        "       . ",
                        "       A ",
                        "       B ",
                        "       A ",
                        ".OLYMPUS.",
                        "       . "
                    },new GridList {
                        " .     ",
                        " U     ",
                        " L     ",
                        " Y     ",
                        " S     ",
                        " S     ",
                        " E     ",
                        ".SATYR.",
                        " .     "
                    },new GridList {
                        "     . ",
                        "     P ",
                        "     A ",
                        ".SATYR.",
                        "     I ",
                        "     S ",
                        "     . "
                    },new GridList {
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

                    return new List<GridList> {

                    new GridList {
                        "     .    ",
                        "     B    ",
                        "     E    ",
                        "   . N    ",
                        "  .DAZZLE.",
                        "   U I    ",
                        "   T N    ",
                        ".ROYCE.   ",
                        "   . .    "
                    },new GridList {
                        "    .     ",
                        "    S     ",
                        "    P.    ",
                        ".ROTOR.   ",
                        "   .ROLLS.",
                        " .DUTY.   ",
                        "    .C    ",
                        "     E    ",
                        "     .    "
                    },new GridList {
                        " .  .  ",
                        ".SPORT.",
                        " E  O  ",
                        " A  L  ",
                        ".TAIL. ",
                        " S  S  ",
                        " .  .  "
                    },new GridList {
                        "  .     ",
                        "  R .   ",
                        ".ROYCE. ",
                        "  L A   ",
                        "  L R   ",
                        " .SPEED.",
                        "  . .   "
                    },new GridList {
                        " .  .  ",
                        " C  S  ",
                        " A  P  ",
                        ".ROTOR.",
                        " S  R  ",
                        " .DUTY.",
                        "    .  "
                    },new GridList {
                        "   . ",
                        "   C ",
                        "   A ",
                        "   R ",
                        ".GAS.",
                        "   . "
                    },new GridList {
                        "   .  . ",
                        "  .BELT.",
                        "   E  Y ",
                        "   N  R ",
                        ".DAZZLE.",
                        "   I  . ",
                        "   N    ",
                        "   E    ",
                        "   .    "
                    },new GridList {
                        " .  .    ",
                        " G  B    ",
                        ".AXLE.   ",
                        " S  N    ",
                        " .DAZZLE.",
                        "    I    ",
                        "    N    ",
                        "    E    ",
                        "    .    "
                    },new GridList {
                        " .   ",
                        " B   ",
                        " E   ",
                        " N   ",
                        " Z   ",
                        " I   ",
                        ".NUT.",
                        " E   ",
                        " .   "
                    },new GridList {
                        "   .   ",
                        ".TYRE. ",
                        "   O B ",
                        "  .AIR.",
                        "   D A ",
                        "   . K ",
                        "     E ",
                        "     . "
                    },new GridList {
                        " .    ",
                        " L    ",
                        " O    ",
                        ".CARS.",
                        " K    ",
                        " .    "
                    },new GridList {
                        " .    ",
                        ".BOOT.",
                        " R    ",
                        " A    ",
                        " K    ",
                        " E    ",
                        " .    "
                    },new GridList {
                        "   .   ",
                        "   B   ",
                        "  .O.  ",
                        " .HORN.",
                        ".AUTO. ",
                        "  B.O  ",
                        "  S F  ",
                        "  . .  "
                    },new GridList {
                        "  . .    ",
                        "  H R    ",
                        ".AUTO.   ",
                        "  B O    ",
                        " .SAFETY.",
                        "  . .    "
                    },new GridList {
                        "   . ",
                        "   S ",
                        "   A ",
                        "   F ",
                        "   E ",
                        "   T ",
                        ".KEY.",
                        "   . "
                    },new GridList {
                        "     . ",
                        "     B ",
                        "     R ",
                        "     A ",
                        "     K ",
                        ".SPARE.",
                        "     . "
                    },new GridList {
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

                    return new List<GridList> {

                    new GridList {
                        "  ..     ",
                        ".LOW.    ",
                        " .ZEPHYR.",
                        ".HOT.    ",
                        "  N.     ",
                        "  E      ",
                        "  .      "
                    },new GridList {
                        "     .  ",
                        "     D  ",
                        "     U  ",
                        "     S  ",
                        "     T  ",
                        ".ZEPHYR.",
                        "     .  "
                    },new GridList {
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
                    },new GridList {
                        "   . . ",
                        "   D S ",
                        " .GUST.",
                        "   L O ",
                        ".POLAR.",
                        "   . M ",
                        "     . "
                    },new GridList {
                        "  . .    ",
                        "  C C    ",
                        "  L U    ",
                        "  O M    ",
                        ".EURUS.  ",
                        "  D L    ",
                        "  .DUSTY.",
                        "    S    ",
                        "    .    "
                    },new GridList {
                        " .     ",
                        " S     ",
                        " T     ",
                        " O     ",
                        " R     ",
                        ".MUGGY.",
                        " .     "
                    },new GridList {
                        "     . ",
                        "     F ",
                        "     O ",
                        "     G ",
                        "     G ",
                        ".MUGGY.",
                        "     . "
                    },new GridList {
                        " .  .   ",
                        ".FROSTS.",
                        " O  L   ",
                        ".GALE.  ",
                        " G  E   ",
                        " Y  T   ",
                        " .  .   "
                    },new GridList {
                        " .    ",
                        " S    ",
                        " L    ",
                        " E    ",
                        " E    ",
                        ".THAW.",
                        " .    "
                    },new GridList {
                        "    . ",
                        "    T ",
                        "    H ",
                        "    A ",
                        ".SNOW.",
                        "    . "
                    },new GridList {
                        "  .      ",
                        "  M   .  ",
                        "  E   H  ",
                        " .TROPIC.",
                        "  E   L  ",
                        "  O   L  ",
                        ".FROSTS. ",
                        "  .   .  "
                    },new GridList {
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

                    return new List<GridList> {

                    new GridList {
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
                    },new GridList {
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
                    },new GridList {
                        " .  . ",
                        ".LIST.",
                        " E  A ",
                        " T  P ",
                        ".TIME.",
                        " E  . ",
                        " R    ",
                        " .    "
                    },new GridList {
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
                    },new GridList {
                        "   . . ",
                        "   M L ",
                        "   O I ",
                        ".BONUS.",
                        "   E T ",
                        ".KEYS. ",
                        "   .   "
                    },new GridList {
                        "  . .  ",
                        ".KEYS. ",
                        "  A C  ",
                        "  R R  ",
                        ".INDEX.",
                        "  . E  ",
                        "    N  ",
                        "    .  "
                    },new GridList {
                        "     . .   ",
                        ".COPYPAPER.",
                        "     A A   ",
                        "    .POST. ",
                        "     E T   ",
                        "     R E   ",
                        "     . .   "
                    },new GridList {
                        "      . ",
                        "  .   E ",
                        "  E   R ",
                        ".ANSWER.",
                        "  T   O ",
                        ".TELLER.",
                        "  R   . ",
                        "  .     "
                    },new GridList {
                        "   .  ",
                        "   S  ",
                        "   C  ",
                        "   R  ",
                        "   E  ",
                        "   E  ",
                        ".SEND.",
                        "   .  "
                    },new GridList {
                        "       .  ",
                        "       B  ",
                        "       A  ",
                        ".MAGAZINE.",
                        "       K  ",
                        "       .  "
                    }
                };

                case 9110:

                    return new List<GridList> {

                    new GridList {
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
                    },new GridList {
                        "  .      ",
                        "  A      ",
                        "  P      ",
                        ".FREEZER.",
                        "  O      ",
                        "  N      ",
                        "  .      "
                    },new GridList {
                        "     . ",
                        "     F ",
                        "     A ",
                        ".APRON.",
                        "     . "
                    },new GridList {
                        " .     ",
                        " T     ",
                        " E     ",
                        ".APRON.",
                        " .     "
                    },new GridList {
                        "   .  . ",
                        ".BASKET.",
                        "   C  E ",
                        "   A  A ",
                        ".TILES. ",
                        "   E    ",
                        "   S    ",
                        "   .    "
                    },new GridList {
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
                    },new GridList {
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
                    },new GridList {
                        " .  .    ",
                        ".BOTTLES.",
                        " A  I    ",
                        ".SCALES. ",
                        " K  E    ",
                        " E  S    ",
                        " T  .    ",
                        " .       "
                    },new GridList {
                        "    .   ",
                        "    S . ",
                        "  .SINK.",
                        "    E E ",
                        ".TRIVET.",
                        "    E T ",
                        "    S L ",
                        "    . E ",
                        "      . "
                    },new GridList {
                        "      .   ",
                        "      S   ",
                        "   .  I   ",
                        "   S  E   ",
                        "  .TRIVET.",
                        "   O  E   ",
                        ".SPOONS.  ",
                        "   L  .   ",
                        "   .      "
                    },new GridList {
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

                    return new List<GridList> {

                    new GridList {
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
                    },new GridList {
                        "   .      ",
                        "   C .    ",
                        "   A R    ",
                        "  .SHELLS.",
                        "   T E    ",
                        "   L F    ",
                        ".WEEDS.   ",
                        "   . .    "
                    },new GridList {
                        "   .    ",
                        "   R .  ",
                        ".SHELLS.",
                        "   E I  ",
                        "  .FINS.",
                        "   S E  ",
                        "   . .  "
                    },new GridList {
                        "    .       ",
                        "    O .     ",
                        "  .HYDROZOA.",
                        "    S O     ",
                        "    T C     ",
                        "    E K     ",
                        ".SHARKS.    ",
                        "    . .     "
                    },new GridList {
                        "      . . ",
                        ".MOLLUSCS.",
                        "      A H ",
                        "      L A ",
                        "  .OYSTER.",
                        "      . K ",
                        "        S ",
                        "        . "
                    },new GridList {
                        "       . ",
                        "       S ",
                        "       H ",
                        "       E ",
                        "       L ",
                        "       L ",
                        ".MUSSELS.",
                        "       . "
                    },new GridList {
                        "    .    ",
                        "    D    ",
                        "    U    ",
                        "    N    ",
                        "    E    ",
                        ".MUSSELS.",
                        "    .    "
                    },new GridList {
                        "    . .   ",
                        ".PRAWNS.  ",
                        "    I T   ",
                        "    N I   ",
                        "   .DUNES.",
                        "    . G   ",
                        "      .   "
                    },new GridList {
                        " .        ",
                        ".MOLLUSCS.",
                        " A        ",
                        " R        ",
                        " I        ",
                        " N        ",
                        " E        ",
                        " .        "
                    },new GridList {
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

                    return new List<GridList> {

                    new GridList {
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
                    },new GridList {
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
                    },new GridList {
                        "   . ",
                        "   B ",
                        "   R ",
                        "   A ",
                        "   N ",
                        "   D ",
                        ".TOY.",
                        "   . "
                    },new GridList {
                        " .   ",
                        " S   ",
                        ".TOY.",
                        " A   ",
                        " R   ",
                        " .   "
                    },new GridList {
                        "    . ",
                        "    T ",
                        ".STAR.",
                        "    E ",
                        "    E ",
                        "    . "
                    },new GridList {
                        " .     ",
                        ".TOAST.",
                        " R     ",
                        " E     ",
                        " E     ",
                        " .     "
                    },new GridList {
                        " .      ",
                        " T      ",
                        " O      ",
                        " A      ",
                        " S      ",
                        ".TURKEY.",
                        " .      "
                    },new GridList {
                        "      . ",
                        "      W ",
                        "      H ",
                        "      I ",
                        "      S ",
                        "      K ",
                        ".TURKEY.",
                        "      . "
                    },new GridList {
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
                    },new GridList {
                        "        . ",
                        "        D ",
                        "        A ",
                        ".MARZIPAN.",
                        "        C ",
                        "        E ",
                        "        . "
                    },new GridList {
                        "  .    ",
                        "  F    ",
                        "  O    ",
                        ".HOLLY.",
                        "  D    ",
                        "  .    "
                    },new GridList {
                        " .     ",
                        " C     ",
                        " R     ",
                        " E     ",
                        " A     ",
                        ".MERRY.",
                        " .     "
                    },new GridList {
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

                    return new List<GridList> {

                    new GridList {
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
                    },new GridList {
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
                    },new GridList {
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
                    },new GridList {
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
                    },new GridList {
                        "     . .    ",
                        "  .OPOSSUMS.",
                        "     R K    ",
                        "     E I    ",
                        ".STATION.   ",
                        "     L K    ",
                        "     L .    ",
                        "     Y      ",
                        "     .      "
                    },new GridList {
                        "     .      ",
                        "     O      ",
                        "     R      ",
                        "     E      ",
                        "     I      ",
                        "     L      ",
                        "     L      ",
                        ".LILLYPILLY.",
                        "     .      "
                    },new GridList {
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
                    },new GridList {
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
                    },new GridList {
                        " .       ",
                        " I .     ",
                        " D W     ",
                        " R O     ",
                        ".ION.    ",
                        " E G     ",
                        ".STATION.",
                        " S .     ",
                        " .       "
                    },new GridList {
                        "          . ",
                        "          M ",
                        "          U ",
                        "          L ",
                        "          G ",
                        ".MACROZAMIA.",
                        "          . "
                    },new GridList {
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

                    return new List<GridList> {

                    new GridList {
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
                    },new GridList {
                        " .  .     ",
                        ".SHUTTLE. ",
                        " E  H     ",
                        ".RAPUNZEL.",
                        " V  M     ",
                        " A  B     ",
                        " N  .     ",
                        " T        ",
                        " .        "
                    },new GridList {
                        "       . ",
                        ".SERVANT.",
                        "       R ",
                        "       O ",
                        "       L ",
                        "       L ",
                        "       S ",
                        "       . "
                    },new GridList {
                        "  .    ",
                        "  T    ",
                        "  R    ",
                        ".TOWER.",
                        "  L    ",
                        "  L    ",
                        "  S    ",
                        "  .    "
                    },new GridList {
                        "     . ",
                        "     H ",
                        "     A ",
                        ".TOWER.",
                        "     E ",
                        "     . "
                    },new GridList {
                        "      .     ",
                        ".LIZARDS.   ",
                        "      R D   ",
                        "    .BEAUTY.",
                        "      A C   ",
                        "      M K   ",
                        "      S .   ",
                        "      .     "
                    },new GridList {
                        "      . ",
                        "      G ",
                        "      R ",
                        ".BEAUTY.",
                        "      P ",
                        "      H ",
                        "      O ",
                        "      N ",
                        "      . "
                    },new GridList {
                        "   .  ",
                        "   D  ",
                        "   R  ",
                        "   E  ",
                        "   A  ",
                        "   M  ",
                        ".PUSS.",
                        "   .  "
                    },new GridList {
                        "    . ",
                        ".PUSS.",
                        "    T ",
                        "    R ",
                        "    A ",
                        "    W ",
                        "    . "
                    },new GridList {
                        "   .   ",
                        "   F   ",
                        ".STRAW.",
                        "   O   ",
                        "   G   ",
                        "   .   "
                    },new GridList {
                        "     . ",
                        ".STRAW.",
                        "     A ",
                        "     N ",
                        "     D ",
                        "     . "
                    },new GridList {
                        " .    ",
                        " S    ",
                        ".PUSS.",
                        " E    ",
                        " L    ",
                        " L    ",
                        " S    ",
                        " .    "
                    },new GridList {
                        " .    ",
                        " G  . ",
                        ".IMPS.",
                        " A  P ",
                        ".NOSE.",
                        " T  L ",
                        " .  L ",
                        "    S ",
                        "    . "
                    },new GridList {
                        "      . ",
                        "      G ",
                        "      O ",
                        "      O ",
                        ".SPELLS.",
                        "      E ",
                        "      . "
                    },new GridList {
                        "     .  ",
                        ".TROLLS.",
                        "     I  ",
                        "     E  ",
                        "     .  "
                    }
                };

                case 9203:

                    return new List<GridList> {

                    new GridList {
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
                    },new GridList {
                        "    .    ",
                        "  . A    ",
                        ".LAWSUIT.",
                        "  V S    ",
                        ".PENALTY.",
                        "  R U    ",
                        "  . L    ",
                        "    T    ",
                        "    .    "
                    },new GridList {
                        "    . ",
                        "    A ",
                        "    S ",
                        "    S ",
                        "    A ",
                        "    U ",
                        "    L ",
                        ".WRIT.",
                        "    . "
                    },new GridList {
                        " .       ",
                        ".WITNESS.",
                        " R       ",
                        " I       ",
                        " T       ",
                        " .       "
                    },new GridList {
                        "      .  ",
                        ".WITNESS.",
                        "      E  ",
                        "      A  ",
                        "      L  ",
                        "      .  "
                    },new GridList {
                        "     . ",
                        "     B ",
                        ".USHER.",
                        "     I ",
                        "     B ",
                        "     E ",
                        "     R ",
                        "     Y ",
                        "     . "
                    },new GridList {
                        "       . ",
                        "       L ",
                        "       A ",
                        "       R ",
                        "       C ",
                        "       E ",
                        "       N ",
                        ".BRIBERY.",
                        "       . "
                    },new GridList {
                        "  .     ",
                        "  L     ",
                        "  A     ",
                        "  R     ",
                        "  C     ",
                        ".FELONY.",
                        "  N     ",
                        "  Y     ",
                        "  .     "
                    },new GridList {
                        "      . ",
                        "      L ",
                        "      E ",
                        "      G ",
                        "      A ",
                        "      C ",
                        ".FELONY.",
                        "      . "
                    },new GridList {
                        "    .   ",
                        "    P   ",
                        "    R   ",
                        ".FELONY.",
                        "    O   ",
                        "    F   ",
                        "    .   "
                    },new GridList {
                        " .       ",
                        " P       ",
                        " R       ",
                        " O       ",
                        " O       ",
                        ".FORGERY.",
                        " .       "
                    },new GridList {
                        "       . ",
                        "       F ",
                        "    .  O ",
                        "    C  R ",
                        "    O  G ",
                        "  .JUDGE.",
                        "    R  R ",
                        ".CUSTODY.",
                        "    .  . "
                    },new GridList {
                        " .      ",
                        " P      ",
                        ".LEGACY.",
                        " E      ",
                        " A      ",
                        " .      "
                    }
                };

                case 9204:

                    return new List<GridList> {

                    new GridList {
                        "   .      ",
                        "   S      ",
                        "   H....  ",
                        "  .RITUAL.",
                        ".SAUCERS. ",
                        "  .BEANS. ",
                        "   .D..A  ",
                        "    .  M  ",
                        "       .  "
                    },new GridList {
                        " .  .  ",
                        ".TIPS. ",
                        " A  A  ",
                        ".SHRUB.",
                        " T  C  ",
                        " E  E  ",
                        " .  R  ",
                        "    S  ",
                        "    .  "
                    },new GridList {
                        "   .  ",
                        "   C  ",
                        "   U  ",
                        ".TIPS.",
                        "   .  "
                    },new GridList {
                        "  .   ",
                        "  A   ",
                        "  S   ",
                        "  S   ",
                        "  A   ",
                        ".AMOY.",
                        "  .   "
                    },new GridList {
                        "  .    ",
                        "  A    ",
                        "  M    ",
                        "  O    ",
                        ".HYSON.",
                        "  .    "
                    },new GridList {
                        "     . ",
                        "   . A ",
                        ".HYSON.",
                        "   P H ",
                        " .BREW.",
                        "   A E ",
                        "   Y I ",
                        "   . . "
                    },new GridList {
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
                    },new GridList {
                        " .   ",
                        " N   ",
                        " I   ",
                        ".CUP.",
                        " E   ",
                        " .   "
                    },new GridList {
                        " .    ",
                        ".AMOY.",
                        " S    ",
                        " I    ",
                        " A    ",
                        " .    "
                    },new GridList {
                        "      . ",
                        "      A ",
                        ".CHESTS.",
                        "      I ",
                        "      A ",
                        "      . "
                    },new GridList {
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
                    },new GridList {
                        "     . ",
                        ".SHOOT.",
                        "     E ",
                        "     A ",
                        "     P ",
                        "     O ",
                        "     T ",
                        "     . "
                    },new GridList {
                        "    .     ",
                        "    P     ",
                        "    E     ",
                        "    K     ",
                        "    O     ",
                        ".CEREMONY.",
                        "    .     "
                    },new GridList {
                        "    .  ",
                        "    P  ",
                        ".YEMEN.",
                        "    K  ",
                        "    O  ",
                        "    E  ",
                        "    .  "
                    },new GridList {
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

                    return new List<GridList> {

                    new GridList {
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
                    },new GridList {
                        "  .      ",
                        "  G      ",
                        "  A      ",
                        "  L      ",
                        "  E      ",
                        ".ANATOMY.",
                        "  .      "
                    },new GridList {
                        " .      ",
                        " R      ",
                        ".ECZEMA.",
                        " I      ",
                        " D      ",
                        " .      "
                    },new GridList {
                        "       . ",
                        "       E ",
                        "       Y ",
                        ".LOZENGE.",
                        "       S ",
                        "       . "
                    },new GridList {
                        "     . . ",
                        "     A S ",
                        "     N A ",
                        "    .AIL.",
                        "     T V ",
                        "     O E ",
                        ".ECZEMA. ",
                        "     Y   ",
                        "     .   "
                    },new GridList {
                        " .     ",
                        ".SALVE.",
                        " A     ",
                        " L     ",
                        " K     ",
                        " .     "
                    },new GridList {
                        " .     ",
                        " S     ",
                        " A     ",
                        " L     ",
                        ".VIRUS.",
                        " E     ",
                        " .     "
                    },new GridList {
                        "     .     ",
                        "    .D     ",
                        "   .BODY.  ",
                        ".VIRUS.    ",
                        "   .REMEDY.",
                        "    N.     ",
                        "    E      ",
                        "    T      ",
                        "    .      "
                    },new GridList {
                        "   .    ",
                        "   B    ",
                        "   O    ",
                        "   D    ",
                        ".OXYGEN.",
                        "   .    "
                    },new GridList {
                        "     .  ",
                        "     R  ",
                        " .   E  ",
                        " B   M  ",
                        ".OXYGEN.",
                        " N   D  ",
                        ".EMBRYO.",
                        " .   .  "
                    },new GridList {
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
                    },new GridList {
                        " .      ",
                        " B      ",
                        " U      ",
                        " R      ",
                        " N      ",
                        " E      ",
                        ".THOMAS.",
                        " .      "
                    },new GridList {
                        "   . .  ",
                        "   C P  ",
                        ".THOMAS.",
                        "   L I  ",
                        ".IODINE.",
                        "   . .  "
                    }
                };

                case 9207:

                    return new List<GridList> {

                    new GridList {
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
                    },new GridList {
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
                    },new GridList {
                        "       . ",
                        ".CYCLIST.",
                        "       E ",
                        "       A ",
                        "       M ",
                        "       . "
                    },new GridList {
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
                    },new GridList {
                        " .         ",
                        ".TEAMMATES.",
                        " A         ",
                        " B         ",
                        " L         ",
                        " E         ",
                        " .         "
                    },new GridList {
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
                    },new GridList {
                        " .     ",
                        ".SPORT.",
                        " C     ",
                        " U     ",
                        " L     ",
                        " L     ",
                        " S     ",
                        " .     "
                    },new GridList {
                        "      . ",
                        ".SCULLS.",
                        "      O ",
                        "      L ",
                        "      O ",
                        "      . "
                    },new GridList {
                        " .     ",
                        " S     ",
                        " P     ",
                        " O     ",
                        " R     ",
                        ".TOKYO.",
                        " .     "
                    },new GridList {
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
                    },new GridList {
                        "        . ",
                        "        W ",
                        "        I ",
                        "        N ",
                        ".ROYCROFT.",
                        "        E ",
                        "        R ",
                        "        . "
                    },new GridList {
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

                    return new List<GridList> {

                    new GridList {
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
                    },new GridList {
                        "   .        ",
                        "   T        ",
                        "   H  .     ",
                        "   E  B     ",
                        "   A  I     ",
                        ".TETRAZZINI.",
                        "   R  E     ",
                        ".OPERETTA.  ",
                        "   .  .     "
                    },new GridList {
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
                    },new GridList {
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
                    },new GridList {
                        "  .        ",
                        "  V        ",
                        "  A        ",
                        "  L        ",
                        ".DONIZETTI.",
                        "  I        ",
                        "  S        ",
                        "  .        "
                    },new GridList {
                        "      . ",
                        "      V ",
                        "      A ",
                        "      L ",
                        "      O ",
                        "      I ",
                        ".CHORUS.",
                        "      . "
                    },new GridList {
                        " .      ",
                        " U      ",
                        " L      ",
                        " A      ",
                        " N      ",
                        " O      ",
                        ".VALOIS.",
                        " A      ",
                        " .      "
                    },new GridList {
                        "    .    ",
                        "    M  . ",
                        "    A  A ",
                        " .SINGER.",
                        "    O  I ",
                        ".ULANOVA.",
                        "    .  . "
                    },new GridList {
                        "  .    ",
                        ".DUETS.",
                        "  L    ",
                        "  A    ",
                        "  N    ",
                        "  O    ",
                        "  V    ",
                        "  A    ",
                        "  .    "
                    },new GridList {
                        " .    ",
                        " D    ",
                        " U    ",
                        " E    ",
                        ".TUTU.",
                        " S    ",
                        " .    "
                    },new GridList {
                        "   .  ",
                        ".TUTU.",
                        "   R  ",
                        "   I  ",
                        "   O  ",
                        "   .  "
                    },new GridList {
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

                    return new List<GridList> {

                    new GridList {
                        "   . .   ",
                        "   R F   ",
                        ".UNIFORM.",
                        "   F R   ",
                        "   L A   ",
                        ".ENEMY.  ",
                        "   . .   "
                    },new GridList {
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
                    },new GridList {
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
                    },new GridList {
                        " .      ",
                        " F      ",
                        " O      ",
                        " R      ",
                        ".TURRET.",
                        " .      "
                    },new GridList {
                        "    .  ",
                        ".FORAY.",
                        "    L  ",
                        "    A  ",
                        "    M  ",
                        "    O  ",
                        "    .  "
                    },new GridList {
                        "      .    ",
                        "    ..F    ",
                        " .ALAMO.   ",
                        "   .CORPS. ",
                        "   .TNT.   ",
                        ".DIVISIONS.",
                        "    O.F    ",
                        "    N Y    ",
                        "    . .    "
                    },new GridList {
                        "       . ",
                        "     . F ",
                        "     A O ",
                        "     C R ",
                        "    .TNT.",
                        "     I I ",
                        "     O F ",
                        ".ALLENBY.",
                        "     . . "
                    },new GridList {
                        "     . ",
                        "     C ",
                        "     O ",
                        "     R ",
                        "     P ",
                        ".YPRES.",
                        "     . "
                    },new GridList {
                        " .     ",
                        " A     ",
                        " R     ",
                        " M     ",
                        ".YPRES.",
                        " .     "
                    },new GridList {
                        "         . ",
                        ".DIVISIONS.",
                        "         L ",
                        "         I ",
                        "         M ",
                        "         . "
                    },new GridList {
                        "     .      ",
                        "  .  A      ",
                        "  M  C      ",
                        "  E  T      ",
                        " .DIVISIONS.",
                        "  A  O      ",
                        ".ALLENBY.   ",
                        "  .  .      "
                    },new GridList {
                        "      . ",
                        "      B ",
                        ".ARMOUR.",
                        "      E ",
                        "      N ",
                        "      . "
                    }
                };

                case 9210:

                    return new List<GridList> {

                    new GridList {
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
                    },new GridList {
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
                    },new GridList {
                        "     .      ",
                        "     T      ",
                        "     O.     ",
                        ".CELLAR.    ",
                        "    .SHERRY.",
                        "  .ASTI.    ",
                        "     .N     ",
                        "      E     ",
                        "      .     "
                    },new GridList {
                        "   . ",
                        "   S ",
                        "   H ",
                        "   E ",
                        "   R ",
                        "   R ",
                        ".DRY.",
                        "   . "
                    },new GridList {
                        " .     ",
                        ".TOAST.",
                        " A     ",
                        " S     ",
                        " T     ",
                        " E     ",
                        " .     "
                    },new GridList {
                        "      . ",
                        "      T ",
                        "    . A ",
                        "    M S ",
                        " .VAULT.",
                        "    L E ",
                        ".STILL. ",
                        "    .   "
                    },new GridList {
                        "    . ",
                        "  . S ",
                        " .VAT.",
                        "  A I ",
                        ".MULL.",
                        "  L L ",
                        "  T . ",
                        "  .   "
                    },new GridList {
                        "  . .   ",
                        "  R D   ",
                        ".SHERRY.",
                        "  I E   ",
                        " .NEGUS.",
                        "  E S   ",
                        "  . .   "
                    },new GridList {
                        "  .   ",
                        ".ASTI.",
                        "  E   ",
                        "  C   ",
                        "  .   "
                    },new GridList {
                        "     . ",
                        ".PRESS.",
                        "     P ",
                        "     A ",
                        "     I ",
                        "     N ",
                        "     . "
                    },new GridList {
                        " .    ",
                        ".PORT.",
                        " R    ",
                        " E    ",
                        " S    ",
                        " S    ",
                        " .    "
                    },new GridList {
                        "    .    ",
                        "  .SWEET.",
                        "  B I    ",
                        ".DRINK.  ",
                        "  A E    ",
                        "  N .    ",
                        "  D      ",
                        "  Y      ",
                        "  .      "
                    },new GridList {
                        "   . ",
                        "   M ",
                        "   A ",
                        "   R ",
                        ".SEC.",
                        "   . "
                    }
                };

                case 9211:

                    return new List<GridList> {

                    new GridList {
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
                    },new GridList {
                        "    . .     ",
                        "    F L     ",
                        "    L A     ",
                        ".SALUKI.    ",
                        "    S K     ",
                        " .SCHNAUZER.",
                        "    . .     "
                    },new GridList {
                        "  . .      ",
                        ".SCHNAUZER.",
                        "  R A      ",
                        ".COON.     ",
                        "  F A      ",
                        "  T .      ",
                        "  S        ",
                        "  .        "
                    },new GridList {
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
                    },new GridList {
                        "      . ",
                        "    . M ",
                        "  .ASTA.",
                        "    K N ",
                        ".SPHYNX.",
                        "    E . ",
                        "    .   "
                    },new GridList {
                        "  . .       ",
                        "  C F       ",
                        "  L L       ",
                        ".SALUKI.    ",
                        "  W S       ",
                        " .SCHNAUZER.",
                        "  . .       "
                    },new GridList {
                        " .  .  ",
                        ".CATS. ",
                        " H  P  ",
                        " O  A  ",
                        ".WHINE.",
                        " .  I  ",
                        "    E  ",
                        "    L  ",
                        "    .  "
                    },new GridList {
                        "         . ",
                        "         B ",
                        "         O ",
                        "         X ",
                        "         E ",
                        ".SCHNAUZER.",
                        "         . "
                    },new GridList {
                        "  .    ",
                        ".WHINE.",
                        "  A    ",
                        "  I    ",
                        "  R    ",
                        "  .    "
                    },new GridList {
                        " .      ",
                        " S      ",
                        " P      ",
                        " A      ",
                        " N      ",
                        " I      ",
                        " E      ",
                        ".LASSIE.",
                        " .      "
                    },new GridList {
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

                    return new List<GridList> {

                    new GridList {
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
                    },new GridList {
                        "       .   ",
                        "       W   ",
                        "       A   ",
                        "       L   ",
                        "      .R   ",
                        "     .FURS.",
                        ".ESKIMOS.  ",
                        "      X.   ",
                        "      .    "
                    },new GridList {
                        "    .   ",
                        ".NORWAY.",
                        "    A   ",
                        "    L   ",
                        "    R   ",
                        "    U   ",
                        "    S   ",
                        "    .   "
                    },new GridList {
                        "      . ",
                        "      K ",
                        "      A ",
                        ".NORWAY.",
                        "      A ",
                        "      K ",
                        "      . "
                    },new GridList {
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
                    },new GridList {
                        " .   .    ",
                        ".NUNATAKS.",
                        " A   E    ",
                        " N   N    ",
                        ".SCOTT.   ",
                        " E   .    ",
                        " N        ",
                        " .        "
                    },new GridList {
                        " .    ",
                        " F    ",
                        " U    ",
                        " R    ",
                        ".SNOW.",
                        " .    "
                    },new GridList {
                        " . .      ",
                        ".BREEZE.  ",
                        " A R      ",
                        ".SOMERSET.",
                        " E I      ",
                        " . N      ",
                        "   E      ",
                        "   .      "
                    },new GridList {
                        "        . ",
                        "        A ",
                        ".SOMERSET.",
                        "        L ",
                        "        A ",
                        "        S ",
                        "        . "
                    },new GridList {
                        "    .   ",
                        "    A   ",
                        "    T   ",
                        "    L   ",
                        "    A   ",
                        ".MOSSES.",
                        "    .   "
                    },new GridList {
                        "      . ",
                        "      D ",
                        "      O ",
                        "      G ",
                        ".MOSSES.",
                        "      . "
                    },new GridList {
                        "   .   ",
                        "   N   ",
                        ".SCOTT.",
                        "   M   ",
                        "   E   ",
                        "   .   "
                    },new GridList {
                        "      . ",
                        "      I ",
                        "      C ",
                        ".ERMINE.",
                        "      . "
                    }
                };

                case 9301:

                    return new List<GridList> {

                    new GridList {
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
                    },new GridList {
                        "      .   ",
                        "      C . ",
                        ".SALZBURG.",
                        "      S I ",
                        "      T F ",
                        "    .BOAT.",
                        "      M . ",
                        "      S   ",
                        "      .   "
                    },new GridList {
                        "       . ",
                        "       A ",
                        ".CUSTOMS.",
                        "       I ",
                        "       A ",
                        "       . "
                    },new GridList {
                        " .        ",
                        ".SALZBURG.",
                        " H        ",
                        " I        ",
                        " P        ",
                        " .        "
                    },new GridList {
                        "   .  ",
                        "   S  ",
                        "   H  ",
                        ".TRIP.",
                        "   P  ",
                        "   .  "
                    },new GridList {
                        "  .  . ",
                        ".ITALY.",
                        "  R  A ",
                        "  I  C ",
                        "  P  H ",
                        "  .JET.",
                        "     . "
                    },new GridList {
                        "  .       ",
                        "  C       ",
                        "  H       ",
                        "  I       ",
                        "  N       ",
                        ".SALZBURG.",
                        "  .       "
                    },new GridList {
                        "   .   ",
                        "   B   ",
                        "   A   ",
                        "   L   ",
                        ".CHINA.",
                        "   .   "
                    },new GridList {
                        "  .  ",
                        "  B  ",
                        ".CAR.",
                        "  L  ",
                        "  I  ",
                        "  .  "
                    },new GridList {
                        " .      ",
                        ".BRAZIL.",
                        " U      ",
                        " S      ",
                        " .      "
                    },new GridList {
                        "   . ",
                        "   T ",
                        "   I ",
                        "   C ",
                        "   K ",
                        "   E ",
                        "   T ",
                        ".BUS.",
                        "   . "
                    },new GridList {
                        "     .    ",
                        "     A    ",
                        "     T    ",
                        "   . H    ",
                        ".TICKETS. ",
                        "   A N    ",
                        "  .BOSTON.",
                        "   . .    "
                    },new GridList {
                        "     . ",
                        "     A ",
                        ".EGYPT.",
                        "     H ",
                        "     E ",
                        "     N ",
                        "     S ",
                        "     . "
                    },new GridList {
                        " . .   ",
                        " V N   ",
                        " O O   ",
                        ".YORK. ",
                        " A W   ",
                        " G A   ",
                        ".EGYPT.",
                        " . .   "
                    },new GridList {
                        " . .    ",
                        ".VENICE.",
                        " O O    ",
                        ".YORK.  ",
                        " A W    ",
                        " G A    ",
                        " E Y    ",
                        " . .    "
                    },new GridList {
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

                    return new List<GridList> {

                    new GridList {
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
                    },new GridList {
                        "        .    ",
                        "      . F    ",
                        "      A I    ",
                        "     .GARNET.",
                        "      A E    ",
                        ".KUNZITE.    ",
                        "      E      ",
                        "      .      "
                    },new GridList {
                        " .        ",
                        " G        ",
                        " A        ",
                        " R        ",
                        " N        ",
                        " E        ",
                        ".TRINKETS.",
                        " .        "
                    },new GridList {
                        "      .   ",
                        "      B   ",
                        "    . U   ",
                        "    C C   ",
                        "  .LOCKET.",
                        "    I L   ",
                        ".TRINKETS.",
                        "    . .   "
                    },new GridList {
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
                    },new GridList {
                        "  .      ",
                        "  B      ",
                        "  E      ",
                        "  A      ",
                        ".KUNZITE.",
                        "  T      ",
                        "  Y      ",
                        "  .      "
                    },new GridList {
                        "      . ",
                        "      R ",
                        "      A ",
                        "      R ",
                        "      I ",
                        "      T ",
                        ".BEAUTY.",
                        "      . "
                    },new GridList {
                        "   .    ",
                        " . C    ",
                        " C A    ",
                        ".RARITY.",
                        " O A    ",
                        ".WATCH. ",
                        " N .    ",
                        " .      "
                    },new GridList {
                        "  .     ",
                        "  P     ",
                        "  Y     ",
                        "  R     ",
                        "  O     ",
                        "  P     ",
                        ".BEAUTY.",
                        "  .     "
                    },new GridList {
                        "   .  ",
                        "   P  ",
                        ".ONYX.",
                        "   R  ",
                        "   O  ",
                        "   P  ",
                        "   E  ",
                        "   .  "
                    },new GridList {
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

                    return new List<GridList> {

                    new GridList {
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
                    },new GridList {
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
                    },new GridList {
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
                    },new GridList {
                        " . .    ",
                        " P P    ",
                        " O I    ",
                        " U S    ",
                        ".NET.   ",
                        " D O    ",
                        ".SALARY.",
                        " . E    ",
                        "   .    "
                    },new GridList {
                        "      .   ",
                        "      L . ",
                        ".SECURITY.",
                        "      R I ",
                        "   .TRADE.",
                        "      . L ",
                        "        D ",
                        "        . "
                    },new GridList {
                        "    .  ",
                        "    A  ",
                        "  .BUY.",
                        "  S D  ",
                        "  O I  ",
                        ".QUOTE.",
                        "  . .  "
                    },new GridList {
                        " .   ",
                        " B   ",
                        " O   ",
                        " N   ",
                        " U   ",
                        ".SOU.",
                        " .   "
                    },new GridList {
                        " .     ",
                        " R .   ",
                        " U B   ",
                        ".PROXY.",
                        " E N   ",
                        ".ECU.  ",
                        " . S   ",
                        "   .   "
                    },new GridList {
                        "     . ",
                        "     P ",
                        "     A ",
                        ".PROXY.",
                        "     . "
                    },new GridList {
                        "     .     ",
                        ".DINERO.   ",
                        "     U B   ",
                        "    .PROXY.",
                        "     E N   ",
                        "     E U   ",
                        "     . S   ",
                        "       .   "
                    },new GridList {
                        "    .  ",
                        "    R  ",
                        "    O  ",
                        "    U  ",
                        "    B  ",
                        "    L  ",
                        ".RUPEE.",
                        "    .  "
                    },new GridList {
                        " .      ",
                        " M .    ",
                        " A D    ",
                        ".ROUBLE.",
                        " G C    ",
                        " I A    ",
                        ".NOTES. ",
                        " . .    "
                    },new GridList {
                        "     . ",
                        "     A ",
                        "     I ",
                        ".YIELD.",
                        "     . "
                    }
                };

                case 9304:

                    return new List<GridList> {

                    new GridList {
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
                    },new GridList {
                        "  . .  ",
                        ".TROY. ",
                        "  E A  ",
                        " .ACRE.",
                        "  M D  ",
                        "  . .  "
                    },new GridList {
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
                    },new GridList {
                        "  . .      ",
                        "  T P      ",
                        ".KILOHERTZ.",
                        "  E C      ",
                        "  R K      ",
                        "  C E      ",
                        ".FEET.     ",
                        "  . .      "
                    },new GridList {
                        "    .      ",
                        "    P .    ",
                        ".KILOHERTZ.",
                        "    C R    ",
                        "   .KEG.   ",
                        "    E .    ",
                        "    T      ",
                        "    .      "
                    },new GridList {
                        "   . .   ",
                        "   B D   ",
                        " .QUARTO.",
                        "   S A   ",
                        "   H M   ",
                        ".STEP.   ",
                        "   L     ",
                        "   .     "
                    },new GridList {
                        "      . ",
                        "      P ",
                        ".QUARTO.",
                        "      L ",
                        "      E ",
                        "      . "
                    },new GridList {
                        " .     ",
                        ".PROOF.",
                        " O     ",
                        " L     ",
                        " E     ",
                        " .     "
                    },new GridList {
                        " .    ",
                        " P    ",
                        " R    ",
                        " O    ",
                        " O    ",
                        ".FOOT.",
                        " .    "
                    },new GridList {
                        "   .      ",
                        ".FOOT.    ",
                        "   H P    ",
                        "  .MOIETY.",
                        "   . N    ",
                        "     T    ",
                        "     .    "
                    },new GridList {
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
                    },new GridList {
                        "   .  ",
                        "   U  ",
                        "   N  ",
                        "   I  ",
                        ".WATT.",
                        "   .  "
                    }
                };

                case 9305:

                    return new List<GridList> {

                    new GridList {
                        "      . ",
                        "      B ",
                        "      R ",
                        "      A ",
                        ".SPRITZ.",
                        "      I ",
                        "      L ",
                        "      . "
                    },new GridList {
                        " .      ",
                        " P      ",
                        " I      ",
                        " E      ",
                        ".SPRITZ.",
                        " .      "
                    },new GridList {
                        "    .     ",
                        "    G.    ",
                        ".SYRUP.   ",
                        "   .MINTS.",
                        ".RUSSE.   ",
                        "    .S    ",
                        "     .    "
                    },new GridList {
                        "  .    ",
                        "  T    ",
                        "  A    ",
                        "  F    ",
                        "  F    ",
                        ".SYRUP.",
                        "  .    "
                    },new GridList {
                        "    .  ",
                        " .  G  ",
                        ".SYRUP.",
                        " O  M  ",
                        ".RUSSE.",
                        " B  .  ",
                        " E     ",
                        " T     ",
                        " .     "
                    },new GridList {
                        "  .      ",
                        "  P .    ",
                        ".MINTS.  ",
                        "  E O    ",
                        " .SPRITZ.",
                        "  . T    ",
                        "    E    ",
                        "    .    "
                    },new GridList {
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
                    },new GridList {
                        "    . ",
                        "    M ",
                        "    I ",
                        "    N ",
                        "    T ",
                        ".NUTS.",
                        "    . "
                    },new GridList {
                        " .    ",
                        " S    ",
                        " I    ",
                        " M    ",
                        ".NUTS.",
                        " E    ",
                        " L    ",
                        " .    "
                    },new GridList {
                        "  .    ",
                        "  B    ",
                        ".TAFFY.",
                        "  R    ",
                        "  S    ",
                        "  .    "
                    },new GridList {
                        "     . ",
                        "     B ",
                        "     A ",
                        "     R ",
                        ".FLOSS.",
                        "     . "
                    },new GridList {
                        " .      ",
                        " F      ",
                        " L      ",
                        " O      ",
                        ".SWEETS.",
                        " S      ",
                        " .      "
                    },new GridList {
                        " .      ",
                        " P    . ",
                        " A    S ",
                        " S    W ",
                        ".TRIFLE.",
                        " R    E ",
                        ".YOGURT.",
                        " .    S ",
                        "      . "
                    },new GridList {
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
                    },new GridList {
                        "    .  ",
                        "    F  ",
                        "    R  ",
                        "    U  ",
                        "    I  ",
                        ".TARTS.",
                        "    .  "
                    },new GridList {
                        "  .    ",
                        "  P    ",
                        "  E    ",
                        "  E    ",
                        ".FLOSS.",
                        "  .    "
                    },new GridList {
                        "    .  ",
                        ".DROPS.",
                        "    E  ",
                        "    E  ",
                        "    L  ",
                        "    .  "
                    }
                };

                case 9306:

                    return new List<GridList> {

                    new GridList {
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
                    },new GridList {
                        "       . .  ",
                        ".BUZZARDET. ",
                        "       A A  ",
                        "    .MAYBUG.",
                        "       F .  ",
                        "       L    ",
                        "       Y    ",
                        "       .    "
                    },new GridList {
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
                    },new GridList {
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
                    },new GridList {
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
                    },new GridList {
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
                    },new GridList {
                        "         . ",
                        "         A ",
                        "         P ",
                        "         H ",
                        "         I ",
                        ".DIPTERANS.",
                        "         . "
                    },new GridList {
                        "     .  ",
                        ".DAYFLY.",
                        "     E  ",
                        "     M  ",
                        "     A  ",
                        "     .  "
                    },new GridList {
                        " .    ",
                        " L    ",
                        " E    ",
                        ".MITE.",
                        " A    ",
                        " .    "
                    },new GridList {
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

                    return new List<GridList> {

                    new GridList {
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
                    },new GridList {
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
                    },new GridList {
                        "    .     ",
                        "  .BELIZE.",
                        "  P G     ",
                        ".KENYA.   ",
                        "  R P     ",
                        "  U T     ",
                        "  . .     "
                    },new GridList {
                        "   . . ",
                        "   K A ",
                        " .PERU.",
                        "   N S ",
                        ".EGYPT.",
                        "   A R ",
                        "   . I ",
                        "     A ",
                        "     . "
                    },new GridList {
                        "        . ",
                        "        S ",
                        "        U ",
                        "        D ",
                        ".TANZANIA.",
                        "        N ",
                        "        . "
                    },new GridList {
                        " .       ",
                        " S       ",
                        ".URUGUAY.",
                        " D       ",
                        " A       ",
                        " N       ",
                        " .       "
                    },new GridList {
                        "       . ",
                        "       S ",
                        ".URUGUAY.",
                        "       R ",
                        "       I ",
                        "       A ",
                        "       . "
                    },new GridList {
                        "   .     ",
                        "   C     ",
                        ".URUGUAY.",
                        "   B     ",
                        "   A     ",
                        "   .     "
                    },new GridList {
                        "     .   ",
                        "     T   ",
                        ".URUGUAY.",
                        "     R   ",
                        "     K   ",
                        "     E   ",
                        "     Y   ",
                        "     .   "
                    },new GridList {
                        "      . ",
                        "      L ",
                        "      I ",
                        "      B ",
                        ".TURKEY.",
                        "      A ",
                        "      . "
                    },new GridList {
                        "   .   ",
                        " .FIJI.",
                        " L R   ",
                        ".ITALY.",
                        " B Q   ",
                        " Y .   ",
                        " A     ",
                        " .     "
                    },new GridList {
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

                    return new List<GridList> {

                    new GridList {
                        "         .   ",
                        "       . C   ",
                        "       R E   ",
                        ".VELAZQUEZ.  ",
                        "       B A   ",
                        "      .ERNST.",
                        "       N N   ",
                        "       S E   ",
                        "       . .   "
                    },new GridList {
                        "     .     ",
                        "     G     ",
                        "     R     ",
                        "     E     ",
                        "     U     ",
                        ".VELAZQUEZ.",
                        "     E     ",
                        "     .     "
                    },new GridList {
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
                    },new GridList {
                        "      . ",
                        "      H ",
                        "      E ",
                        ".ROMNEY.",
                        "      D ",
                        "      E ",
                        "      N ",
                        "      . "
                    },new GridList {
                        "   .    ",
                        "   E    ",
                        ".WEYDEN.",
                        "   C    ",
                        "   K    ",
                        "   .    "
                    },new GridList {
                        "  .   . ",
                        " .WATTS.",
                        "  E   C ",
                        "  Y   O ",
                        "  D   T ",
                        ".VERNET.",
                        "  N   . ",
                        "  .     "
                    },new GridList {
                        "     . . ",
                        "     R D ",
                        "   .LELY.",
                        "     D C ",
                        "     O K ",
                        ".RUBENS. ",
                        "     .   "
                    },new GridList {
                        "     . . ",
                        " .RUBENS.",
                        "     R T ",
                        ".CEZANNE.",
                        "     S E ",
                        "     T R ",
                        "     . . "
                    },new GridList {
                        "     . ",
                        "     S ",
                        "     A ",
                        "     R ",
                        "     G ",
                        "     E ",
                        "     N ",
                        ".ERNST.",
                        "     . "
                    },new GridList {
                        " .       ",
                        " H       ",
                        " A       ",
                        " L       ",
                        ".SARGENT.",
                        " .       "
                    },new GridList {
                        "  .     ",
                        "  B     ",
                        ".GREUZE.",
                        "  I     ",
                        "  L     ",
                        "  .     "
                    },new GridList {
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

                    return new List<GridList> {

                    new GridList {
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
                    },new GridList {
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
                    },new GridList {
                        "        .    ",
                        ".PIROUETTE.  ",
                        "        A V  ",
                        "     .CANCAN.",
                        "        G L  ",
                        "        O S  ",
                        "        . E  ",
                        "          .  "
                    },new GridList {
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
                    },new GridList {
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
                    },new GridList {
                        "       .   ",
                        "     . B   ",
                        ".ZAPATEADO.",
                        "     A L   ",
                        "    .POLKA.",
                        "     . .   "
                    },new GridList {
                        "       . . ",
                        "       B J ",
                        ".ZAPATEADO.",
                        "       L T ",
                        "    .POLKA.",
                        "       . . "
                    },new GridList {
                        " .       ",
                        " J       ",
                        " O       ",
                        ".TWOSTEP.",
                        " A       ",
                        " .       "
                    },new GridList {
                        "     . ",
                        "     T ",
                        "     W ",
                        "     O ",
                        "     S ",
                        ".TWIST.",
                        "     E ",
                        "     P ",
                        "     . "
                    },new GridList {
                        "   .       ",
                        ".ZAPATEADO.",
                        "   A       ",
                        "   S       ",
                        "   .       "
                    },new GridList {
                        "   .     ",
                        "   H     ",
                        ".TWOSTEP.",
                        "   P     ",
                        "   .     "
                    },new GridList {
                        "   .   ",
                        "   J   ",
                        ".TWIST.",
                        "   V   ",
                        "   E   ",
                        "   .   "
                    }
                };

                case 9310:

                    return new List<GridList> {

                    new GridList {
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
                    },new GridList {
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
                    },new GridList {
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
                    },new GridList {
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
                    },new GridList {
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
                    },new GridList {
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
                    },new GridList {
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
                    },new GridList {
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

                    return new List<GridList> {

                    new GridList {
                        "    .       ",
                        "    H       ",
                        "  . O       ",
                        " .TARPAULIN.",
                        "  R I       ",
                        ".MIZZENTOP. ",
                        "  C O       ",
                        "  E N       ",
                        "  . .       "
                    },new GridList {
                        "    .  .    ",
                        "    H  S    ",
                        "    O  C    ",
                        " .TARPAULIN.",
                        "    I  T    ",
                        ".MIZZENTOP. ",
                        "    O  L    ",
                        "    N  E    ",
                        "    .  .    "
                    },new GridList {
                        "      .  .     ",
                        "     .STOWAWAY.",
                        "      C  I     ",
                        ".TARPAULIN.    ",
                        "      T  D     ",
                        "      T  .     ",
                        "      L        ",
                        "      E        ",
                        "      .        "
                    },new GridList {
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
                    },new GridList {
                        "      .   ",
                        "  .   C   ",
                        " .AFTER.  ",
                        "  F   E   ",
                        ".STOWAWAY.",
                        "  .   .   "
                    },new GridList {
                        " .       ",
                        " H       ",
                        " A       ",
                        " T       ",
                        " C       ",
                        ".HORIZON.",
                        " .       "
                    },new GridList {
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
                    },new GridList {
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
                    },new GridList {
                        "  .        ",
                        "  S        ",
                        "  C        ",
                        "  U        ",
                        "  T        ",
                        "  T        ",
                        "  L        ",
                        ".SEAWORTHY.",
                        "  .        "
                    },new GridList {
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

                    return new List<GridList> {

                    new GridList {
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
                    },new GridList {
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
                    },new GridList {
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
                    },new GridList {
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
                    },new GridList {
                        " .    ",
                        " U    ",
                        ".ROSA.",
                        " A    ",
                        " L    ",
                        " .    "
                    },new GridList {
                        "   .  ",
                        "   A  ",
                        "   T  ",
                        "   L  ",
                        "   A  ",
                        ".ROSA.",
                        "   .  "
                    },new GridList {
                        "       . ",
                        "       A ",
                        ".EVEREST.",
                        "       L ",
                        "       A ",
                        "       S ",
                        "       . "
                    },new GridList {
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
                    },new GridList {
                        " .       ",
                        " A       ",
                        " L       ",
                        " P       ",
                        ".SIMPLON.",
                        " .       "
                    },new GridList {
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
                    },new GridList {
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

                    return new List<GridList> {

                    new GridList {
                        "     . .  ",
                        "     B T  ",
                        "     E E  ",
                        ".WALTZING.",
                        "     I N  ",
                        "     Q I  ",
                        "  .SQUASH.",
                        "     E .  ",
                        "     .    "
                    },new GridList {
                        " .        ",
                        " B        ",
                        " O        ",
                        ".WALTZING.",
                        " L        ",
                        " S        ",
                        " .        "
                    },new GridList {
                        "  .   . ",
                        "  C   B ",
                        " .RODEO.",
                        "  O   W ",
                        "  Q   L ",
                        ".QUOITS.",
                        "  E   . ",
                        "  T     ",
                        "  .     "
                    },new GridList {
                        "    . ",
                        "    C ",
                        "    R ",
                        "    O ",
                        "    Q ",
                        "    U ",
                        "    E ",
                        ".TEST.",
                        "    . "
                    },new GridList {
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
                    },new GridList {
                        "   .   ",
                        "   S   ",
                        "   K . ",
                        "   A H ",
                        ".LOTTO.",
                        "   I B ",
                        "   N B ",
                        ".RUGBY.",
                        "   . . "
                    },new GridList {
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
                    },new GridList {
                        "     .    ",
                        "     D    ",
                        "     A    ",
                        "     R    ",
                        ".SKITTLES.",
                        "     S    ",
                        "     .    "
                    },new GridList {
                        "        . ",
                        ".SKITTLES.",
                        "        K ",
                        "        I ",
                        "        I ",
                        "        N ",
                        "        G ",
                        "        . "
                    },new GridList {
                        "   .     ",
                        "   J     ",
                        "   U     ",
                        "   D     ",
                        ".CROQUET.",
                        "   .     "
                    },new GridList {
                        "   .      ",
                        "   G      ",
                        "   O      ",
                        ".WALTZING.",
                        "   F      ",
                        "   .      "
                    },new GridList {
                        "    .   ",
                        "    D   ",
                        "    I   ",
                        "    V   ",
                        ".QUOITS.",
                        "    N   ",
                        "    G   ",
                        "    .   "
                    },new GridList {
                        "      . ",
                        ".SQUASH.",
                        "      O ",
                        "      C ",
                        "      K ",
                        "      E ",
                        "      Y ",
                        "      . "
                    },new GridList {
                        "    . ",
                        "    H ",
                        "    O ",
                        "    C ",
                        "    K ",
                        "    E ",
                        ".PLAY.",
                        "    . "
                    },new GridList {
                        "  .   ",
                        "  B   ",
                        "  A   ",
                        "  L   ",
                        ".PLAY.",
                        "  .   "
                    },new GridList {
                        "  .    ",
                        "  C    ",
                        "  A    ",
                        "  N    ",
                        ".DARTS.",
                        "  S    ",
                        "  T    ",
                        "  A    ",
                        "  .    "
                    },new GridList {
                        "      .  ",
                        "      B  ",
                        "      A  ",
                        "      I  ",
                        ".CANASTA.",
                        "      .  "
                    }
                };

                case 9402:

                    return new List<GridList> {

                    new GridList {
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
                    },new GridList {
                        "     .   ",
                        "     S   ",
                        "     E . ",
                        ".ZONURUS.",
                        "     P N ",
                        "     E A ",
                        "     N K ",
                        " .TURTLE.",
                        "     . . "
                    },new GridList {
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
                    },new GridList {
                        " . .    ",
                        " T R    ",
                        " A A    ",
                        " I T    ",
                        ".PYTHON.",
                        " A L    ",
                        " N E    ",
                        " .KRAIT.",
                        "   .    "
                    },new GridList {
                        "   .    ",
                        "   R    ",
                        "   A    ",
                        "   T  . ",
                        ".PYTHON.",
                        "   L  E ",
                        "   E  W ",
                        " .KRAIT.",
                        "   .  . "
                    },new GridList {
                        "   .   .     ",
                        "  .WARAL.    ",
                        "   O   A     ",
                        "   R   M     ",
                        "   R   I     ",
                        ".STEGOSAURUS.",
                        "   L   .     ",
                        "   .         "
                    },new GridList {
                        " .           ",
                        " E           ",
                        " L           ",
                        " A           ",
                        " P           ",
                        ".STEGOSAURUS.",
                        " .           "
                    },new GridList {
                        "     .       ",
                        "     F       ",
                        "     R       ",
                        ".STEGOSAURUS.",
                        "     G       ",
                        "     .       "
                    },new GridList {
                        "   .     ",
                        "   P     ",
                        ".TUATARA.",
                        "   D     ",
                        "   D     ",
                        "   O     ",
                        "   C     ",
                        "   K     ",
                        "   .     "
                    },new GridList {
                        "       . ",
                        "   .   P ",
                        "   D   A ",
                        "   I   D ",
                        "   P   D ",
                        ".TESTUDO.",
                        "   A   C ",
                        "  .SKINK.",
                        "   .   . "
                    },new GridList {
                        "  .       ",
                        "  M .     ",
                        ".TOAD.    ",
                        "  N I     ",
                        "  I P     ",
                        " .TESTUDO.",
                        "  O A     ",
                        "  R S     ",
                        "  . .     "
                    },new GridList {
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

                    return new List<GridList> {

                    new GridList {
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
                    },new GridList {
                        "       . ",
                        "       B ",
                        ".STANLEY.",
                        "       R ",
                        "       D ",
                        "       . "
                    },new GridList {
                        "   .  .      ",
                        "   E  N      ",
                        "  .VELASQUEZ.",
                        "   A  N      ",
                        ".EANNES.     ",
                        "   S  E      ",
                        "   .  N      ",
                        "      .      "
                    },new GridList {
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
                    },new GridList {
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
                    },new GridList {
                        " .       ",
                        ".PIZZARO.",
                        " E       ",
                        " A       ",
                        " R       ",
                        " Y       ",
                        " .       "
                    },new GridList {
                        "     . ",
                        "     K ",
                        "     E ",
                        "     N ",
                        "     N ",
                        "     E ",
                        "     D ",
                        ".PEARY.",
                        "     . "
                    },new GridList {
                        "    . . ",
                        "  .COOK.",
                        "    A E ",
                        ".BURTON.",
                        "    E N ",
                        "    S E ",
                        "    . D ",
                        "      Y ",
                        "      . "
                    },new GridList {
                        " .  .   ",
                        " O  O   ",
                        " S  A   ",
                        ".BURTON.",
                        " O  E   ",
                        ".ROSS.  ",
                        " N  .   ",
                        " .      "
                    },new GridList {
                        "   . . ",
                        "   M O ",
                        ".ADAMS.",
                        "   W B ",
                        ".MOSTO.",
                        "   O R ",
                        "   N N ",
                        "   . . "
                    },new GridList {
                        " . .   ",
                        " T M   ",
                        ".ADAMS.",
                        " S W   ",
                        ".MOSTO.",
                        " A O   ",
                        " N N   ",
                        " . .   "
                    },new GridList {
                        "   .  .   ",
                        " .STEWART.",
                        "   O  U   ",
                        "   R  S   ",
                        "   R  T   ",
                        "   E  I   ",
                        ".TASMAN.  ",
                        "   .  .   "
                    },new GridList {
                        "   .  . ",
                        " .SCOTT.",
                        "   O  A ",
                        ".TORRES.",
                        "   T  M ",
                        "   E  A ",
                        "   S  N ",
                        "   .  . "
                    },new GridList {
                        " .      ",
                        " L      ",
                        ".EANNES.",
                        " I      ",
                        " F      ",
                        " .      "
                    }
                };

                case 9404:

                    return new List<GridList> {

                    new GridList {
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
                    },new GridList {
                        "    .     ",
                        "    B .   ",
                        "    A H   ",
                        ".ZINNIA.  ",
                        "    K K   ",
                        "  .ASTERS.",
                        "    . .   "
                    },new GridList {
                        "         . . ",
                        ".SCHIZANTHUS.",
                        "         E P ",
                        "         N O ",
                        "         R R ",
                        "      .THYME.",
                        "         . . "
                    },new GridList {
                        "   . .         ",
                        "  .SCHIZANTHUS.",
                        "   T E         ",
                        "   A R         ",
                        "   M B         ",
                        ".SEEDS.        ",
                        "   N .         ",
                        "   S           ",
                        "   .           "
                    },new GridList {
                        "       .  ",
                        "       L  ",
                        "     . O  ",
                        " .FORSYTH.",
                        "     E U  ",
                        ".STAMENS. ",
                        "     D .  ",
                        "     S    ",
                        "     .    "
                    },new GridList {
                        "   .      ",
                        "   V      ",
                        "   I .    ",
                        " .FORSYTH.",
                        "   L E    ",
                        ".STAMENS. ",
                        "   . D    ",
                        "     S    ",
                        "     .    "
                    },new GridList {
                        "      .      ",
                        "      F      ",
                        "    .FLOWERS.",
                        "    H O      ",
                        "    A R      ",
                        "    K E      ",
                        ".ASTERS.     ",
                        "    . .      "
                    },new GridList {
                        "  . .    ",
                        "  F T    ",
                        ".FLOWERS.",
                        "  O E    ",
                        " .REEVES.",
                        "  E D    ",
                        "  S I    ",
                        "  . E    ",
                        "    .    "
                    },new GridList {
                        "  .      ",
                        "  F .    ",
                        "  L R    ",
                        "  O E    ",
                        ".TWEEDIE.",
                        "  E V    ",
                        " .RUE.   ",
                        "  S S    ",
                        "  . .    "
                    },new GridList {
                        " . .    ",
                        " F T    ",
                        " L W    ",
                        " O E    ",
                        ".REEVES.",
                        " E D    ",
                        " S I    ",
                        " .KEW.  ",
                        "   .    "
                    },new GridList {
                        " .     ",
                        " D     ",
                        " A     ",
                        ".VIOLA.",
                        " I     ",
                        " D     ",
                        " .     "
                    },new GridList {
                        "       . ",
                        "       P ",
                        "       E ",
                        "       T ",
                        "       A ",
                        "       L ",
                        ".FLOWERS.",
                        "       . "
                    },new GridList {
                        "     . ",
                        "     P ",
                        "     E ",
                        ".FRUIT.",
                        "     A ",
                        "     L ",
                        "     S ",
                        "     . "
                    },new GridList {
                        "  .  ",
                        "  F  ",
                        "  R  ",
                        ".GUM.",
                        "  I  ",
                        "  T  ",
                        "  .  "
                    },new GridList {
                        " .      ",
                        " R      ",
                        " E      ",
                        " E      ",
                        " V      ",
                        " E      ",
                        ".SHRUBS.",
                        " .      "
                    },new GridList {
                        "      . ",
                        "      F ",
                        "      E ",
                        "      R ",
                        "      N ",
                        ".SHRUBS.",
                        "      . "
                    },new GridList {
                        "   . ",
                        ".KEW.",
                        "   A ",
                        "   R ",
                        "   D ",
                        "   . "
                    },new GridList {
                        "     .  ",
                        ".ASTERS.",
                        "     O  ",
                        "     B  ",
                        "     I  ",
                        "     N  ",
                        "     .  "
                    },new GridList {
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

                    return new List<GridList> {

                    new GridList {
                        "   . .     ",
                        ".RAMAZZINI.",
                        "   A O     ",
                        ".INSULIN.  ",
                        "   H L     ",
                        "   R N     ",
                        "   I E     ",
                        "   G R     ",
                        "   . .     "
                    },new GridList {
                        "       .   ",
                        " .     H   ",
                        ".SURGERY.  ",
                        " A     G   ",
                        ".RAMAZZINI.",
                        " P     E   ",
                        " I     N   ",
                        " .     E   ",
                        "       .   "
                    },new GridList {
                        "     .   ",
                        "     F . ",
                        ".MASHRIG.",
                        "     A E ",
                        ".ZOLLNER.",
                        "     K M ",
                        "     . S ",
                        "       . "
                    },new GridList {
                        "    . .  ",
                        "  .GERMS.",
                        "    V A  ",
                        ".TETANY. ",
                        "    N O  ",
                        "    S .  ",
                        "    .    "
                    },new GridList {
                        " .      ",
                        " M  .   ",
                        " O  E   ",
                        " R  V   ",
                        ".TETANY.",
                        " O  N   ",
                        ".NURSE. ",
                        " .  .   "
                    },new GridList {
                        "    . ",
                        ".MAYO.",
                        "    X ",
                        "    Y ",
                        "    G ",
                        "    E ",
                        "    N ",
                        "    . "
                    },new GridList {
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
                    },new GridList {
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
                    },new GridList {
                        " .      ",
                        ".HARVEY.",
                        " Y      ",
                        " G      ",
                        " I      ",
                        " E      ",
                        " N      ",
                        " E      ",
                        " .      "
                    },new GridList {
                        "         . ",
                        "         S ",
                        ".RAMAZZINI.",
                        "         M ",
                        "         P ",
                        "         S ",
                        "         O ",
                        "         N ",
                        "         . "
                    },new GridList {
                        "  .   . ",
                        "  S   F ",
                        "  I   L ",
                        " .MONRO.",
                        "  P   R ",
                        "  S   E ",
                        ".BOTANY.",
                        "  N   . ",
                        "  .     "
                    },new GridList {
                        "   .   ",
                        "   H   ",
                        "   A   ",
                        ".MONRO.",
                        "   D   ",
                        "   .   "
                    }
                };

                case 9407:

                    return new List<GridList> {

                    new GridList {
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
                    },new GridList {
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
                    },new GridList {
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
                    },new GridList {
                        "     . ",
                        "     P ",
                        "     E ",
                        "     T ",
                        "     R ",
                        "     E ",
                        "     L ",
                        ".FUCHS.",
                        "     . "
                    },new GridList {
                        "   . .      ",
                        "  .SUPPLIES.",
                        "   T E      ",
                        ".SCOTT.     ",
                        "   R R      ",
                        "   M E      ",
                        "   . L      ",
                        "     S      ",
                        "     .      "
                    },new GridList {
                        "    . .   ",
                        "    G.S   ",
                        " .INUIT.  ",
                        "   .SCOTT.",
                        ".WINTER.  ",
                        "    ..M   ",
                        "      .   "
                    },new GridList {
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
                    },new GridList {
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
                    },new GridList {
                        "        . ",
                        "        W ",
                        ".SASTRUGI.",
                        "        N ",
                        "        D ",
                        "        . "
                    },new GridList {
                        "      . ",
                        "      W ",
                        "      E ",
                        " .    A ",
                        ".WALRUS.",
                        " I    E ",
                        " N    L ",
                        ".DRIFTS.",
                        " .    . "
                    },new GridList {
                        "   .  . ",
                        "  .SNOW.",
                        "   E  E ",
                        "   A  A ",
                        ".WALRUS.",
                        "   S  E ",
                        "   .  L ",
                        "      S ",
                        "      . "
                    },new GridList {
                        "  .    ",
                        "  P    ",
                        "  O    ",
                        "  L    ",
                        ".SEALS.",
                        "  .    "
                    }
                };

                case 9408:

                    return new List<GridList> {

                    new GridList {
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
                    },new GridList {
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
                    },new GridList {
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
                    },new GridList {
                        "    .    ",
                        " .  D    ",
                        ".PAGE.   ",
                        " A  M    ",
                        ".PAPYRUS.",
                        " E  .    ",
                        " R       ",
                        " S       ",
                        " .       "
                    },new GridList {
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
                    },new GridList {
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
                    },new GridList {
                        "    .    ",
                        "    B    ",
                        " .  A    ",
                        " P  L    ",
                        ".ROLLERS.",
                        " E  O    ",
                        " S  O    ",
                        ".SEWN.   ",
                        " .  .    "
                    },new GridList {
                        " .       ",
                        " P       ",
                        " A .     ",
                        ".PAPYRUS.",
                        " E A     ",
                        " R I     ",
                        ".SCRIPT. ",
                        " . .     "
                    },new GridList {
                        "  .     ",
                        "  R .   ",
                        ".FONT.  ",
                        "  L I   ",
                        ".PLATES.",
                        "  S L   ",
                        "  . E   ",
                        "    .   "
                    },new GridList {
                        "     . ",
                        "     B ",
                        ".TITLE.",
                        "     D ",
                        "     . "
                    },new GridList {
                        "      .    ",
                        "      P    ",
                        ".ROLLERS.  ",
                        "      I B  ",
                        "      N O  ",
                        "     .TEXT.",
                        "      . .  "
                    },new GridList {
                        "   . ",
                        "   P ",
                        "   L ",
                        "   A ",
                        "   T ",
                        "   E ",
                        ".EMS.",
                        "   . "
                    },new GridList {
                        " .      ",
                        " P      ",
                        " R      ",
                        " O      ",
                        " O      ",
                        " F      ",
                        ".STYLUS.",
                        " .      "
                    },new GridList {
                        " .      ",
                        ".PROOFS.",
                        " I      ",
                        " C      ",
                        " A      ",
                        " .      "
                    },new GridList {
                        "      .    ",
                        "    . R    ",
                        ".QUARTO.   ",
                        "    E L    ",
                        "  .BALLOON.",
                        "    M E    ",
                        "    . R    ",
                        "      S    ",
                        "      .    "
                    },new GridList {
                        " . .   ",
                        " S F   ",
                        ".CROWN.",
                        " R R   ",
                        " I M   ",
                        ".PRESS.",
                        " T .   ",
                        " .     "
                    },new GridList {
                        "     . ",
                        "     I ",
                        ".CROWN.",
                        "     K ",
                        "     . "
                    }
                };

                case 9409:

                    return new List<GridList> {

                    new GridList {
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
                    },new GridList {
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
                    },new GridList {
                        "    .     ",
                        "    E     ",
                        "    J     ",
                        "    E     ",
                        "  . C     ",
                        ".CURTISS. ",
                        "  L O     ",
                        " .MERCURY.",
                        "  . .     "
                    },new GridList {
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
                    },new GridList {
                        "      . ",
                        "      B ",
                        ".SMITHY.",
                        "      R ",
                        "      D ",
                        "      . "
                    },new GridList {
                        "   . .  ",
                        "  .BYRD.",
                        "   A I  ",
                        ".WINGS. ",
                        "   K E  ",
                        "   . .  "
                    },new GridList {
                        "     . ",
                        "     S ",
                        "     H ",
                        "     U ",
                        "     T ",
                        ".STRUT.",
                        "     L ",
                        "     E ",
                        "     . "
                    },new GridList {
                        "    .    ",
                        " .STULTZ.",
                        " S  F    ",
                        ".TIRO.   ",
                        " R  .    ",
                        " U       ",
                        " T       ",
                        " .       "
                    },new GridList {
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
                    },new GridList {
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
                    },new GridList {
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
                    },new GridList {
                        "      .     ",
                        "      G     ",
                        "    . A     ",
                        ".STABILIZER.",
                        "    E I     ",
                        "    L E     ",
                        ".AIRLINER.  ",
                        "    . .     "
                    },new GridList {
                        "    . ",
                        "    E ",
                        "    J ",
                        ".DIVE.",
                        "    C ",
                        "    T ",
                        "    O ",
                        "    R ",
                        "    . "
                    },new GridList {
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

                    return new List<GridList> {

                    new GridList {
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
                    },new GridList {
                        "  .       ",
                        "  S       ",
                        "  U       ",
                        "  S       ",
                        "  P       ",
                        "  E       ",
                        "  C       ",
                        ".ATTORNEY.",
                        "  .       "
                    },new GridList {
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
                    },new GridList {
                        "     .     ",
                        "     S .   ",
                        "   .SURTAX.",
                        "     S O   ",
                        "     P R   ",
                        ".INQUEST.  ",
                        "     C .   ",
                        "     T     ",
                        "     .     "
                    },new GridList {
                        "       .   ",
                        "       S   ",
                        "   .   U   ",
                        ".WITNESS.  ",
                        "   R   P   ",
                        "  .INQUEST.",
                        "   A   C   ",
                        "   L   T   ",
                        "   .   .   "
                    },new GridList {
                        " .       ",
                        ".WITNESS.",
                        " R       ",
                        " I       ",
                        " T       ",
                        " .       "
                    },new GridList {
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
                    },new GridList {
                        "    . ",
                        "    C ",
                        "    R ",
                        "    U ",
                        "    E ",
                        "    L ",
                        "    T ",
                        ".JURY.",
                        "    . "
                    },new GridList {
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
                    },new GridList {
                        "  .   ",
                        "  J   ",
                        ".JURY.",
                        "  S   ",
                        "  T   ",
                        "  I   ",
                        "  C   ",
                        "  E   ",
                        "  .   "
                    },new GridList {
                        "    .   ",
                        "    F   ",
                        ".FELONY.",
                        "    R   ",
                        "    G   ",
                        "    E   ",
                        "    R   ",
                        "    .   "
                    },new GridList {
                        "      . ",
                        "      B ",
                        "      I ",
                        "      G ",
                        "      A ",
                        "      M ",
                        ".FELONY.",
                        "      . "
                    },new GridList {
                        " .      ",
                        " F      ",
                        " O      ",
                        " R      ",
                        ".GUILTY.",
                        " E      ",
                        " R      ",
                        " .      "
                    },new GridList {
                        "      . ",
                        "      L ",
                        "      E ",
                        "      G ",
                        "      A ",
                        "      C ",
                        ".GUILTY.",
                        "      . "
                    },new GridList {
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

                    return new List<GridList> {

                    new GridList {
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
                    },new GridList {
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
                    },new GridList {
                        "         .    ",
                        "         M    ",
                        "        .O    ",
                        "       .BRASS.",
                        "     .SHOT.   ",
                        "       .LANCE.",
                        ".DETONATOR.   ",
                        "        ..    "
                    },new GridList {
                        "    .    ",
                        "  . B    ",
                        " .MORTAR.",
                        "  A A    ",
                        ".GUNS.   ",
                        "  S S    ",
                        "  E .    ",
                        "  R      ",
                        "  .      "
                    },new GridList {
                        "  .    ",
                        "  M    ",
                        "  O  . ",
                        ".BRASS.",
                        "  T  P ",
                        ".LANCE.",
                        "  R  A ",
                        "  .  R ",
                        "     . "
                    },new GridList {
                        " .    ",
                        " D    ",
                        " A    ",
                        " R    ",
                        " T    ",
                        ".SHOT.",
                        " .    "
                    },new GridList {
                        "    .  ",
                        "    J  ",
                        "    E  ",
                        ".DARTS.",
                        "    .  "
                    },new GridList {
                        "   .   ",
                        "   S   ",
                        "   P   ",
                        "   E   ",
                        "   A   ",
                        ".ARROW.",
                        "   .   "
                    },new GridList {
                        "   . ",
                        "   A ",
                        "   R ",
                        "   R ",
                        "   O ",
                        ".BOW.",
                        "   . "
                    },new GridList {
                        "      . ",
                        ".MAUSER.",
                        "      A ",
                        "      M ",
                        "      . "
                    },new GridList {
                        " .     ",
                        ".ARROW.",
                        " X     ",
                        " E     ",
                        " .     "
                    },new GridList {
                        "   . ",
                        "   P ",
                        ".AXE.",
                        "   T ",
                        "   A ",
                        "   R ",
                        "   D ",
                        "   . "
                    },new GridList {
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
                    },new GridList {
                        "     . ",
                        ".SWORD.",
                        "     A ",
                        "     R ",
                        "     T ",
                        "     S ",
                        "     . "
                    },new GridList {
                        " .     ",
                        ".SWORD.",
                        " I     ",
                        " R     ",
                        " E     ",
                        " N     ",
                        " .     "
                    },new GridList {
                        "   . .  ",
                        "  .BOMB.",
                        "   A I  ",
                        ".SIREN. ",
                        "   B E  ",
                        "   . .  "
                    }
                };

                case 9412:

                    return new List<GridList> {

                    new GridList {
                        " .      ",
                        " E .    ",
                        " G G    ",
                        ".YULE.  ",
                        " P O    ",
                        " T R    ",
                        " .MYRRH.",
                        "   .    "
                    },new GridList {
                        "     . ",
                        "     N ",
                        "     I ",
                        "     G ",
                        "     H ",
                        ".EGYPT.",
                        "     . "
                    },new GridList {
                        "   .   ",
                        "   M   ",
                        "   A   ",
                        ".NIGHT.",
                        "   I   ",
                        "   .   "
                    },new GridList {
                        " .     ",
                        " T     ",
                        " H     ",
                        " R     ",
                        " E     ",
                        ".EGYPT.",
                        " .     "
                    },new GridList {
                        "   .   ",
                        ".WATCH.",
                        "   H   ",
                        "   R   ",
                        "   E   ",
                        "   E   ",
                        "   .   "
                    },new GridList {
                        " .    ",
                        ".WISH.",
                        " A    ",
                        " T    ",
                        " C    ",
                        " H    ",
                        " .    "
                    },new GridList {
                        "   .  ",
                        "   T  ",
                        "   I  ",
                        "   D  ",
                        "   I  ",
                        "   N  ",
                        "   G  ",
                        ".WISH.",
                        "   .  "
                    },new GridList {
                        " . .    ",
                        ".FATHER.",
                        " E I    ",
                        " A D    ",
                        ".SPIRIT.",
                        " T N    ",
                        " . G    ",
                        "   S    ",
                        "   .    "
                    },new GridList {
                        "  .  .    ",
                        "  F  S    ",
                        "  A  P    ",
                        " .TIDINGS.",
                        "  H  R    ",
                        "  E  I    ",
                        ".FROST.   ",
                        "  .  .    "
                    },new GridList {
                        "    .  ",
                        ".FROST.",
                        "    A  ",
                        "    I  ",
                        "    N  ",
                        "    T  ",
                        "    .  "
                    },new GridList {
                        "    .     ",
                        "    S     ",
                        " .  A     ",
                        ".NATIVITY.",
                        " O  N     ",
                        ".EAST.    ",
                        " L  .     ",
                        " .        "
                    },new GridList {
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
                    },new GridList {
                        "   .   ",
                        ".EAST. ",
                        "   N H ",
                        "   O A ",
                        " .AWAY.",
                        "   . . "
                    },new GridList {
                        "   .     ",
                        "   S     ",
                        "   T     ",
                        "   A.    ",
                        "  .BLESS.",
                        ".HALO.   ",
                        "  .EVE.  ",
                        "   .E    ",
                        "    .    "
                    },new GridList {
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
                    },new GridList {
                        "   . . ",
                        "   S P ",
                        " .STAR.",
                        "   A A ",
                        ".HOLLY.",
                        "   L E ",
                        "   . R ",
                        "     . "
                    },new GridList {
                        "     .  ",
                        ".SPIRIT.",
                        "     N  ",
                        "     N  ",
                        "     .  "
                    }
                };

                case 9501:

                    return new List<GridList> {

                    new GridList {
                        "        .        ",
                        "       .F        ",
                        "      .AUTOMATED.",
                        ".INTEREST.       ",
                        "      .SUM.      ",
                        ".TRANSFER.       ",
                        "      .TERMS.    ",
                        ".BUSINESS.       ",
                        "       ..        "
                    },new GridList {
                        "     .    ",
                        "     S    ",
                        " .   H    ",
                        " G   A    ",
                        ".INTEREST.",
                        " L   E    ",
                        ".TRANSFER.",
                        " .   .    "
                    },new GridList {
                        "    .      ",
                        "   .BUY.   ",
                        "    O  S   ",
                        ".AUTOMATED.",
                        "    K  A   ",
                        "    .  M   ",
                        "       P   ",
                        "       .   "
                    },new GridList {
                        "   . ",
                        "   D ",
                        "   U ",
                        "   T ",
                        ".BUY.",
                        "   . "
                    },new GridList {
                        "  .   ",
                        "  E   ",
                        "  Q   ",
                        ".DUTY.",
                        "  I   ",
                        "  T   ",
                        "  Y   ",
                        "  .   "
                    },new GridList {
                        "      . ",
                        ".EQUITY.",
                        "      I ",
                        "      E ",
                        "      L ",
                        "      D ",
                        "      . "
                    },new GridList {
                        "    .   ",
                        "    E   ",
                        "    Q   ",
                        "  .DUTY.",
                        "  F I   ",
                        ".DEBT.  ",
                        "  E Y   ",
                        "  . .   "
                    },new GridList {
                        " .      ",
                        " B      ",
                        " O      ",
                        " N      ",
                        " D      ",
                        ".SHARES.",
                        " .      "
                    },new GridList {
                        "     . ",
                        "     C ",
                        "     A ",
                        ".TERMS.",
                        "     H ",
                        "     . "
                    },new GridList {
                        "      .  ",
                        "      B  ",
                        ".AUCTION.",
                        "      N  ",
                        "      D  ",
                        "      S  ",
                        "      .  "
                    },new GridList {
                        "  .      ",
                        "  R .    ",
                        ".AUCTION.",
                        "  I I    ",
                        ".UNIT.   ",
                        "  . L    ",
                        "    E    ",
                        "    .    "
                    },new GridList {
                        "     . ",
                        ".STAMP.",
                        "     A ",
                        "     R ",
                        "     . "
                    },new GridList {
                        "   . ",
                        "   F ",
                        ".PAR.",
                        "   E ",
                        "   E ",
                        "   . "
                    },new GridList {
                        " .     ",
                        " C     ",
                        " A     ",
                        " S     ",
                        ".HOUSE.",
                        " .     "
                    },new GridList {
                        "    .  ",
                        "    T  ",
                        "    I  ",
                        "    T  ",
                        "    L  ",
                        ".BUYER.",
                        "    .  "
                    },new GridList {
                        " .   . ",
                        ".BUYER.",
                        " U   I ",
                        ".LOANS.",
                        " L   K ",
                        " S   . ",
                        " .     "
                    },new GridList {
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

                    return new List<GridList> {

                    new GridList {
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
                    },new GridList {
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
                    },new GridList {
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
                    },new GridList {
                        "      .  ",
                        "   .  O  ",
                        "   C  C  ",
                        ".EVOLUTE.",
                        "   N  A  ",
                        ".TRIDENT.",
                        "   C  T  ",
                        "   .  .  "
                    },new GridList {
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
                    },new GridList {
                        "       . .   ",
                        "       C L   ",
                        ".HYPERBOLA.  ",
                        "       N M   ",
                        "       O I   ",
                        "       I N   ",
                        "   .QUADRANT.",
                        "       . .   "
                    },new GridList {
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
                    },new GridList {
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
                    },new GridList {
                        "   . .    ",
                        "  .SECTOR.",
                        "   O O    ",
                        ".SPLINE.  ",
                        "   I E    ",
                        "   D .    ",
                        "   .      "
                    },new GridList {
                        "     . ",
                        ".LOCUS.",
                        "     P ",
                        "     L ",
                        "     I ",
                        "     N ",
                        "     E ",
                        "     . "
                    },new GridList {
                        "       . .   ",
                        "       C L   ",
                        ".HYPERBOLA.  ",
                        "       N M   ",
                        "      .OGIVE.",
                        "       I N   ",
                        "       D A   ",
                        "       . .   "
                    },new GridList {
                        "     .     ",
                        "     A     ",
                        ".HYPERBOLA.",
                        "     C     ",
                        "     .     "
                    },new GridList {
                        "      . ",
                        ".SECTOR.",
                        "      H ",
                        "      O ",
                        "      M ",
                        "      B ",
                        "      . "
                    },new GridList {
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
                    },new GridList {
                        " .         ",
                        ".TRAPEZIUM.",
                        " O         ",
                        " R         ",
                        " U         ",
                        " S         ",
                        " .         "
                    },new GridList {
                        "    .     ",
                        "    K     ",
                        ".CYLINDER.",
                        "    T     ",
                        "    E     ",
                        "    .     "
                    },new GridList {
                        "        . ",
                        "        L ",
                        "        I ",
                        "        N ",
                        ".ROULETTE.",
                        "        . "
                    }
                };

                case 9503:

                    return new List<GridList> {

                    new GridList {
                        "      .   ",
                        "  .   B   ",
                        " .TILBURY.",
                        "  A   G   ",
                        "  X   G   ",
                        ".JITNEY.  ",
                        "  .   .   "
                    },new GridList {
                        "   .      ",
                        "   W      ",
                        "  .A      ",
                        " .TILBURY.",
                        ".VAN.     ",
                        "  X.      ",
                        "  I       ",
                        "  .       "
                    },new GridList {
                        "   .  ",
                        ".YAWL.",
                        "   A  ",
                        "   I  ",
                        "   N  ",
                        "   .  "
                    },new GridList {
                        " .  . ",
                        ".SHAY.",
                        " L  A ",
                        " E  W ",
                        " D  L ",
                        ".GIG. ",
                        " E    ",
                        " .    "
                    },new GridList {
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
                    },new GridList {
                        "   .     ",
                        "   C     ",
                        "   O     ",
                        "   A .   ",
                        "  .SEDAN.",
                        "   T R   ",
                        "   E A   ",
                        ".LORRY.  ",
                        "   . .   "
                    },new GridList {
                        "     .   ",
                        "     C   ",
                        "     A   ",
                        "     R   ",
                        ".COASTER.",
                        "     .   "
                    },new GridList {
                        "   .    ",
                        ".JITNEY.",
                        "   R    ",
                        "   U    ",
                        "   C    ",
                        "   K    ",
                        "   .    "
                    },new GridList {
                        "  .    ",
                        "  T    ",
                        "  R    ",
                        ".SULKY.",
                        "  C    ",
                        "  K    ",
                        "  .    "
                    },new GridList {
                        "     . ",
                        ".SULKY.",
                        "     A ",
                        "     C ",
                        "     H ",
                        "     T ",
                        "     . "
                    },new GridList {
                        "     . ",
                        ".YACHT.",
                        "     A ",
                        "     N ",
                        "     K ",
                        "     E ",
                        "     R ",
                        "     . "
                    },new GridList {
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
                    },new GridList {
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
                    },new GridList {
                        "   .    ",
                        "   S    ",
                        "   E    ",
                        "   D    ",
                        "   A    ",
                        ".HANSOM.",
                        "   .    "
                    },new GridList {
                        "     . ",
                        "     B ",
                        "     I ",
                        ".TRUCK.",
                        "     E ",
                        "     . "
                    },new GridList {
                        " .   ",
                        ".BUS.",
                        " I   ",
                        " K   ",
                        " E   ",
                        " .   "
                    },new GridList {
                        "   . ",
                        ".BUS.",
                        "   H ",
                        "   I ",
                        "   P ",
                        "   . "
                    },new GridList {
                        "  .     ",
                        "  C     ",
                        ".JALOPY.",
                        "  B     ",
                        "  .     "
                    }
                };

                case 9504:

                    return new List<GridList> {

                    new GridList {
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
                    },new GridList {
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
                    },new GridList {
                        "   .     ",
                        "   G     ",
                        "   O.    ",
                        "  .AROMA.",
                        ".FETA.   ",
                        "  .SWISS.",
                        "   ..    "
                    },new GridList {
                        " .       ",
                        " S       ",
                        " W       ",
                        " I       ",
                        " S       ",
                        ".SAVOURY.",
                        " .       "
                    },new GridList {
                        "       . ",
                        "       D ",
                        "       A ",
                        "       I ",
                        "       R ",
                        ".SAVOURY.",
                        "       . "
                    },new GridList {
                        "     .   ",
                        "     C   ",
                        "     H   ",
                        ".SAVOURY.",
                        "     R   ",
                        "     N   ",
                        "     .   "
                    },new GridList {
                        "     .   ",
                        "     C   ",
                        "     H   ",
                        "     U   ",
                        "     R   ",
                        ".KETONES.",
                        "     .   "
                    },new GridList {
                        "   .        ",
                        "   B        ",
                        "   A        ",
                        ".GORGONZOLA.",
                        "   .        "
                    },new GridList {
                        " .          ",
                        " A          ",
                        ".GORGONZOLA.",
                        " E          ",
                        " D          ",
                        " .          "
                    },new GridList {
                        "      . ",
                        "      A ",
                        "      G ",
                        ".MATURE.",
                        "      D ",
                        "      . "
                    },new GridList {
                        " .  .     ",
                        ".SKIM.    ",
                        " A  A     ",
                        " P  T     ",
                        ".INDUSTRY.",
                        " D  R     ",
                        " .  E     ",
                        "    .     "
                    },new GridList {
                        "      . .  ",
                        "      W G  ",
                        "     .HARD.",
                        "      I U  ",
                        ".INDUSTRY. ",
                        "      E E  ",
                        "      . R  ",
                        "        E  ",
                        "        .  "
                    },new GridList {
                        "      . .    ",
                        "      W G    ",
                        "      H R    ",
                        "      I U    ",
                        ".INDUSTRY.   ",
                        "      E E    ",
                        "      .CREAM.",
                        "        E    ",
                        "        .    "
                    },new GridList {
                        "    .    ",
                        "    F.   ",
                        ".CREAM.  ",
                        "   .TINT.",
                        "    .L   ",
                        "     K   ",
                        "     .   "
                    },new GridList {
                        "   .   ",
                        "   M   ",
                        " .TINT.",
                        " B L   ",
                        ".YAK.  ",
                        " R .   ",
                        " E     ",
                        " .     "
                    },new GridList {
                        "    . ",
                        "    D ",
                        "    E ",
                        "    S ",
                        "    S ",
                        "    E ",
                        "    R ",
                        ".TINT.",
                        "    . "
                    },new GridList {
                        " . .     ",
                        " A E     ",
                        ".COWS.   ",
                        " I E     ",
                        ".DESSERT.",
                        " . .     "
                    }
                };

                case 9505:

                    return new List<GridList> {

                    new GridList {
                        " .  .    ",
                        ".PRIZE.  ",
                        " O  I    ",
                        " S  P    ",
                        " T  P    ",
                        " E  E    ",
                        " R  R    ",
                        " .ASSETS.",
                        "    .    "
                    },new GridList {
                        "  . .   ",
                        ".ASSETS.",
                        "  T W   ",
                        "  A E   ",
                        " .FIRM. ",
                        "  F S   ",
                        "  . .   "
                    },new GridList {
                        "     .   ",
                        "     L   ",
                        "    .I   ",
                        ".STAFF.  ",
                        "   .ITEM.",
                        ".EWERS.  ",
                        "    M.   ",
                        "    .    "
                    },new GridList {
                        " .  .  ",
                        ".PRIZE.",
                        " O  I  ",
                        ".SOAP. ",
                        " T  P  ",
                        " E  E  ",
                        " R  R  ",
                        " .  S  ",
                        "    .  "
                    },new GridList {
                        "     .  ",
                        "     C  ",
                        "     R  ",
                        "     E  ",
                        "     D  ",
                        "     I  ",
                        ".ASSETS.",
                        "     .  "
                    },new GridList {
                        "     .   ",
                        " .CREDIT.",
                        " S   E   ",
                        ".TRAPS.  ",
                        " O   K   ",
                        " C   .   ",
                        " K       ",
                        " .       "
                    },new GridList {
                        "     . ",
                        " .   D ",
                        " S   E ",
                        ".TRAPS.",
                        " O   K ",
                        ".CASH. ",
                        " K     ",
                        " .     "
                    },new GridList {
                        " .      ",
                        " C      ",
                        " A      ",
                        ".SHEETS.",
                        " H      ",
                        " .      "
                    },new GridList {
                        "   .     ",
                        "   S     ",
                        "   H     ",
                        "   E     ",
                        "   E     ",
                        "   T     ",
                        ".DISPLAY.",
                        "   .     "
                    },new GridList {
                        "       . ",
                        "       G ",
                        "       R ",
                        "       O ",
                        "       C ",
                        "       E ",
                        "       R ",
                        ".DISPLAY.",
                        "       . "
                    },new GridList {
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
                    },new GridList {
                        "      . ",
                        "      M ",
                        "      O ",
                        "      N ",
                        "      E ",
                        ".LUXURY.",
                        "      . "
                    },new GridList {
                        "  . .   ",
                        "  P Q   ",
                        ".LUXURY.",
                        "  R A   ",
                        " .SILK. ",
                        "  E I   ",
                        "  . T   ",
                        "    Y   ",
                        "    .   "
                    },new GridList {
                        "   .   ",
                        "   Q   ",
                        "   U   ",
                        "   A   ",
                        "   L   ",
                        "   I   ",
                        "   T   ",
                        ".BUYER.",
                        "   .   "
                    },new GridList {
                        "     . ",
                        "     W ",
                        "     A ",
                        ".BUYER.",
                        "     E ",
                        "     S ",
                        "     . "
                    },new GridList {
                        "     . ",
                        "     G ",
                        "     O ",
                        "     O ",
                        "     D ",
                        ".WARES.",
                        "     . "
                    },new GridList {
                        " .     ",
                        " S     ",
                        " A     ",
                        ".LIFTS.",
                        " E     ",
                        " .     "
                    },new GridList {
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

                    return new List<GridList> {

                    new GridList {
                        "   .     ",
                        "   Q  .  ",
                        " .CUCKOO.",
                        "   E  S  ",
                        "   T  P  ",
                        ".BUZZARD.",
                        "   A  E  ",
                        "   L  Y  ",
                        "   .  .  "
                    },new GridList {
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
                    },new GridList {
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
                    },new GridList {
                        "     . ",
                        "     E ",
                        "  .  A ",
                        "  C  G ",
                        " .RAIL.",
                        "  O  E ",
                        ".SWAN. ",
                        "  .    "
                    },new GridList {
                        "         . ",
                        "       . Q ",
                        "      .EMU.",
                        "       I A ",
                        "       D I ",
                        "       E L ",
                        ".LYREBIRD. ",
                        "       .   "
                    },new GridList {
                        " .    ",
                        " E    ",
                        " A    ",
                        ".GULL.",
                        " L    ",
                        " E    ",
                        " .    "
                    },new GridList {
                        "      . ",
                        ".ORIOLE.",
                        "      A ",
                        "      G ",
                        "      L ",
                        "      E ",
                        "      . "
                    },new GridList {
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
                    },new GridList {
                        "     .    ",
                        "     R    ",
                        "     A .  ",
                        ".BLUETIT. ",
                        "     I E  ",
                        "   .STORK.",
                        "     E N  ",
                        "     . .  "
                    },new GridList {
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
                    },new GridList {
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
                    },new GridList {
                        "     .     ",
                        "   .BROLGA.",
                        "   A A     ",
                        ".BLUETIT.  ",
                        "   K I     ",
                        "   . T     ",
                        "     E     ",
                        "     .     "
                    },new GridList {
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
                    },new GridList {
                        "   . ",
                        "   G ",
                        "   U ",
                        ".OWL.",
                        "   L ",
                        "   . "
                    },new GridList {
                        " .       ",
                        " R       ",
                        " O       ",
                        ".BUZZARD.",
                        " I       ",
                        " N       ",
                        " .       "
                    },new GridList {
                        " .       ",
                        " C       ",
                        " O       ",
                        ".BLUETIT.",
                        " .       "
                    }
                };

                case 9507:

                    return new List<GridList> {

                    new GridList {
                        "        .    ",
                        "        A    ",
                        "        R .  ",
                        ".RAZZAMATAZZ.",
                        "        I O  ",
                        "       .SHOW.",
                        "        T .  ",
                        "        S    ",
                        "        .    "
                    },new GridList {
                        "   .         ",
                        "   T         ",
                        "   R         ",
                        "   A         ",
                        "   P         ",
                        "   E         ",
                        ".RAZZAMATAZZ.",
                        "   E         ",
                        "   .         "
                    },new GridList {
                        "       .   ",
                        "       G   ",
                        "       Y   ",
                        "      .M   ",
                        "    .VAN.  ",
                        "     .CAGE.",
                        ".ARTISTS.  ",
                        "      .T   ",
                        "       .   "
                    },new GridList {
                        "  .      ",
                        "  F      ",
                        "  L      ",
                        ".GYMNAST.",
                        "  E      ",
                        "  R      ",
                        "  .      "
                    },new GridList {
                        "    . ",
                        ".SHOW.",
                        "    A ",
                        "    G ",
                        "    O ",
                        "    N ",
                        "    . "
                    },new GridList {
                        "     . ",
                        "     B ",
                        "     U ",
                        "     S ",
                        "     K ",
                        "     E ",
                        ".FLYER.",
                        "     . "
                    },new GridList {
                        "   .    ",
                        "   L    ",
                        "   I    ",
                        "   O    ",
                        "   N    ",
                        ".BUSKER.",
                        "   .    "
                    },new GridList {
                        "  .      ",
                        "  A      ",
                        "  C .    ",
                        ".STAR.   ",
                        "  O O    ",
                        ".TRAPEZE.",
                        "  S E    ",
                        "  . .    "
                    },new GridList {
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
                    },new GridList {
                        "      .      ",
                        "      B .    ",
                        ".TUMBLERS.   ",
                        "      A K    ",
                        "    .TRAINER.",
                        "      S L    ",
                        "      . L    ",
                        "        .    "
                    },new GridList {
                        " .       ",
                        " M       ",
                        ".ARTISTS.",
                        " G       ",
                        " I       ",
                        " C       ",
                        " .       "
                    },new GridList {
                        "      .    ",
                        "      T    ",
                        "      A    ",
                        "      M.   ",
                        ".TRAINER.  ",
                        "     .RISK.",
                        "      .N   ",
                        "       G   ",
                        "       .   "
                    },new GridList {
                        " .  . ",
                        ".TENT.",
                        " A  R ",
                        " M  U ",
                        " E  C ",
                        ".RISK.",
                        " .  . "
                    },new GridList {
                        "  .       ",
                        "  F       ",
                        ".TUMBLERS.",
                        "  N       ",
                        "  .       "
                    },new GridList {
                        "  .    ",
                        "  W    ",
                        "  H    ",
                        ".LIONS.",
                        "  P    ",
                        "  .    "
                    },new GridList {
                        " .    ",
                        " C    ",
                        " L    ",
                        " O    ",
                        ".WHIP.",
                        " N    ",
                        " .    "
                    },new GridList {
                        " .      ",
                        " B      ",
                        ".ACTORS.",
                        " N      ",
                        " D      ",
                        " .      "
                    },new GridList {
                        "  .   ",
                        "  C   ",
                        "  A   ",
                        "  G   ",
                        ".NETS.",
                        "  .   "
                    }
                };

                case 9508:

                    return new List<GridList> {

                    new GridList {
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
                    },new GridList {
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
                    },new GridList {
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
                    },new GridList {
                        "    .     ",
                        "    C     ",
                        "    A.    ",
                        "   .SWEET.",
                        ".VODKA.   ",
                        "    .T    ",
                        "     E    ",
                        "     R    ",
                        "     .    "
                    },new GridList {
                        "  .  .   ",
                        ".SWEET.  ",
                        "  A  O   ",
                        " .TURKEY.",
                        "  E  A   ",
                        "  R  Y   ",
                        "  .  .   "
                    },new GridList {
                        "  .  ",
                        "  T  ",
                        "  O  ",
                        "  K  ",
                        "  A  ",
                        ".RYE.",
                        "  .  "
                    },new GridList {
                        "      . ",
                        "      I ",
                        "      T ",
                        "      A ",
                        "      L ",
                        ".TURKEY.",
                        "      . "
                    },new GridList {
                        " .         ",
                        " R         ",
                        " O         ",
                        ".SLIVOVITZ.",
                        " E         ",
                        " .         "
                    },new GridList {
                        "   .  ",
                        "   G  ",
                        "   R  ",
                        "   A  ",
                        "   P  ",
                        "   E  ",
                        ".USSR.",
                        "   .  "
                    },new GridList {
                        "  .   ",
                        ".USSR.",
                        "  O   ",
                        "  I   ",
                        "  L   ",
                        "  .   "
                    },new GridList {
                        "     .  ",
                        ".WINERY.",
                        "     H  ",
                        "     O  ",
                        "     N  ",
                        "     E  ",
                        "     .  "
                    },new GridList {
                        "      . ",
                        "      M ",
                        "   .  A ",
                        "   R  L ",
                        "   H  M ",
                        " .CORKS.",
                        "   N  E ",
                        ".SHERRY.",
                        "   .  . "
                    },new GridList {
                        "   .   ",
                        ".PERRY.",
                        "   U   ",
                        "   M   ",
                        "   .   "
                    },new GridList {
                        " .    ",
                        " A    ",
                        " P    ",
                        ".PORT.",
                        " L    ",
                        " E    ",
                        " .    "
                    },new GridList {
                        "   .  ",
                        "   W  ",
                        ".SOIL.",
                        "   N  ",
                        "   E  ",
                        "   .  "
                    },new GridList {
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

                    return new List<GridList> {

                    new GridList {
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
                    },new GridList {
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
                    },new GridList {
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
                    },new GridList {
                        "    .    ",
                        "   .A    ",
                        "  .GRAIL.",
                        ".YORK.   ",
                        "   O.    ",
                        "   T     ",
                        "   T     ",
                        "   O     ",
                        "   .     "
                    },new GridList {
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
                    },new GridList {
                        " .        ",
                        " A        ",
                        " L        ",
                        ".TRANSEPT.",
                        " A        ",
                        " R        ",
                        " .        "
                    },new GridList {
                        "   .      ",
                        "   B      ",
                        "   E .    ",
                        ".TRANSEPT.",
                        "   D P    ",
                        "  .SHINTO.",
                        "   . R    ",
                        "     E    ",
                        "     .    "
                    },new GridList {
                        "     .  ",
                        ".GROTTO.",
                        "     O  ",
                        "     T  ",
                        "     E  ",
                        "     M  ",
                        "     .  "
                    },new GridList {
                        "   .  . ",
                        "   T  A ",
                        "   O  B ",
                        "  .TOMB.",
                        "   E  E ",
                        ".ROMSEY.",
                        "   .  . "
                    },new GridList {
                        "  .     ",
                        "  V .   ",
                        "  E B   ",
                        "  S I   ",
                        " .PISA. ",
                        "  E H   ",
                        ".PRIORY.",
                        "  S P   ",
                        "  . .   "
                    },new GridList {
                        " .       ",
                        " N       ",
                        " A       ",
                        ".VESPERS.",
                        " E       ",
                        " .       "
                    },new GridList {
                        "       . ",
                        ".ZEALOTS.",
                        "       H ",
                        "       R ",
                        "       I ",
                        "       N ",
                        "       E ",
                        "       . "
                    },new GridList {
                        "     .  ",
                        "     I  ",
                        "     C  ",
                        "     O  ",
                        ".SHRINE.",
                        "     .  "
                    },new GridList {
                        " .      ",
                        " K      ",
                        " I      ",
                        ".ROMSEY.",
                        " K      ",
                        " .      "
                    },new GridList {
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
                    },new GridList {
                        " .    ",
                        ".NAVE.",
                        " I    ",
                        " C    ",
                        " H    ",
                        " E    ",
                        " .    "
                    },new GridList {
                        "     .  ",
                        "     S  ",
                        "     P  ",
                        "     I  ",
                        "     R  ",
                        ".EASTER.",
                        "     .  "
                    },new GridList {
                        "   . ",
                        "   N ",
                        "   I ",
                        "   C ",
                        "   H ",
                        ".SEE.",
                        "   . "
                    },new GridList {
                        "     . ",
                        ".WELLS.",
                        "     E ",
                        "     E ",
                        "     . "
                    }
                };

                case 9510:

                    return new List<GridList> {

                    new GridList {
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
                    },new GridList {
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
                    },new GridList {
                        "       .  ",
                        "     . H  ",
                        "    .VIOL.",
                        "     I R  ",
                        ".ZAMPOGNA.",
                        "     L .  ",
                        "     I    ",
                        "     N    ",
                        "     .    "
                    },new GridList {
                        " .     ",
                        " S     ",
                        " P     ",
                        " I     ",
                        " N     ",
                        " E     ",
                        ".TUDUM.",
                        " .     "
                    },new GridList {
                        "   .     ",
                        "   C     ",
                        "   O .   ",
                        "   R F   ",
                        ".PANPIPE.",
                        "   E F   ",
                        ".ZITHER. ",
                        "   . .   "
                    },new GridList {
                        "    .   ",
                        "    P   ",
                        " .  A   ",
                        ".CORNET.",
                        " E  P   ",
                        " L  I   ",
                        " L  P   ",
                        ".OBOE.  ",
                        " .  .   "
                    },new GridList {
                        " .       ",
                        " H       ",
                        " A       ",
                        " R       ",
                        ".PANPIPE.",
                        " .       "
                    },new GridList {
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
                    },new GridList {
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
                    },new GridList {
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
                    },new GridList {
                        "    . ",
                        "    P ",
                        "    I ",
                        "    P ",
                        ".LUTE.",
                        "    . "
                    },new GridList {
                        "  .   .    ",
                        ".SPOONS.   ",
                        "  I   I    ",
                        " .PSALTERY.",
                        "  E   A    ",
                        "  .   R    ",
                        "      .    "
                    },new GridList {
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
                    },new GridList {
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

                    return new List<GridList> {

                    new GridList {
                        " .         ",
                        ".ZIGZAGGER.",
                        " I         ",
                        " P         ",
                        " P         ",
                        " E         ",
                        " R         ",
                        " S         ",
                        " .         "
                    },new GridList {
                        "    . .     ",
                        ".ZIPPERS.   ",
                        "    I E     ",
                        "    N E     ",
                        "    .PLEATS.",
                        "      .     "
                    },new GridList {
                        "     .     ",
                        ".ZIGZAGGER.",
                        "     R     ",
                        "     T     ",
                        "     .     "
                    },new GridList {
                        "   . ",
                        ".ART.",
                        "   I ",
                        "   E ",
                        "   . "
                    },new GridList {
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
                    },new GridList {
                        "     .  ",
                        "     C  ",
                        "     A  ",
                        "  .  N  ",
                        " .WEAVE.",
                        "  O  A  ",
                        ".PRESS. ",
                        "  K  .  ",
                        "  .     "
                    },new GridList {
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
                    },new GridList {
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
                    },new GridList {
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
                    },new GridList {
                        "   .     ",
                        "   D     ",
                        "   I .   ",
                        ".CROSS.  ",
                        "   R E   ",
                        "   .LACE.",
                        "     M   ",
                        "     S   ",
                        "     .   "
                    },new GridList {
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
                    },new GridList {
                        "      .    ",
                        "      V    ",
                        "      E    ",
                        "   .  L    ",
                        "  .WEAVING.",
                        "   E  E    ",
                        "   L  T    ",
                        ".SATINS.   ",
                        "   .  .    "
                    },new GridList {
                        "      .  ",
                        ".VELVETS.",
                        "      U  ",
                        "      C  ",
                        "      K  ",
                        "      .  "
                    },new GridList {
                        "  . .    ",
                        "  B W    ",
                        ".PIPED.  ",
                        "  A L    ",
                        " .SATINS.",
                        "  . .    "
                    },new GridList {
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

                    return new List<GridList> {

                    new GridList {
                        "  . .   ",
                        ".SPICES.",
                        "  I H   ",
                        "  M E   ",
                        "  E R   ",
                        "  N R   ",
                        " .THYME.",
                        "  O .   ",
                        "  .     "
                    },new GridList {
                        "    . . ",
                        ".SPICES.",
                        "    H E ",
                        "    E S ",
                        "    R A ",
                        "    R M ",
                        " .THYME.",
                        "    . . "
                    },new GridList {
                        " . .  ",
                        " S M  ",
                        " E E  ",
                        ".SALT.",
                        " A O  ",
                        ".MINT.",
                        " E S  ",
                        " . .  "
                    },new GridList {
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
                    },new GridList {
                        "      . ",
                        "      B ",
                        "      E ",
                        "      T ",
                        "      O ",
                        "      N ",
                        ".SAVORY.",
                        "      . "
                    },new GridList {
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
                    },new GridList {
                        "    .  ",
                        ".TANSY.",
                        "    A  ",
                        "    L  ",
                        "    S  ",
                        "    I  ",
                        "    F  ",
                        "    Y  ",
                        "    .  "
                    },new GridList {
                        "        . ",
                        "        S ",
                        "        A ",
                        "        L ",
                        "        S ",
                        "        I ",
                        "        F ",
                        ".COSTMARY.",
                        "        . "
                    },new GridList {
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
                    },new GridList {
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
                    },new GridList {
                        "     .    ",
                        "     L    ",
                        "     E .  ",
                        ".ROSEMARY.",
                        "     O U  ",
                        "  .FENNEL.",
                        "     . .  "
                    },new GridList {
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
                    },new GridList {
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
                    },new GridList {
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
                    },new GridList {
                        "   .       ",
                        " . B       ",
                        ".CRANBERRY.",
                        " O L       ",
                        ".COMFREY.  ",
                        " O .       ",
                        " A         ",
                        " .         "
                    },new GridList {
                        " .      ",
                        ".MELONS.",
                        " A      ",
                        " C      ",
                        " E      ",
                        " .      "
                    },new GridList {
                        "    .     ",
                        "    P     ",
                        "    O     ",
                        "    R     ",
                        ".COSTMARY.",
                        "    .     "
                    }
                };

                case 9601:

                    return new List<GridList> {

                    new GridList {
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
                    },new GridList {
                        "    .   ",
                        "  . P   ",
                        " .BARGE.",
                        "  R I   ",
                        ".MIZZEN.",
                        "  G E   ",
                        "  . .   "
                    },new GridList {
                        "   . ",
                        ".LOG.",
                        "   A ",
                        "   L ",
                        "   L ",
                        "   E ",
                        "   O ",
                        "   N ",
                        "   . "
                    },new GridList {
                        " .   ",
                        " C   ",
                        " O   ",
                        " B   ",
                        ".LOG.",
                        " E   ",
                        " .   "
                    },new GridList {
                        "     .   ",
                        "     C   ",
                        ".ROWBOAT.",
                        "     B   ",
                        "     L   ",
                        "     E   ",
                        "     .   "
                    },new GridList {
                        "    .    ",
                        "    R    ",
                        " .  O    ",
                        ".TRAWLER.",
                        " R  B    ",
                        " A  O    ",
                        " M  A    ",
                        ".PUNT.   ",
                        " .  .    "
                    },new GridList {
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
                    },new GridList {
                        "      . ",
                        "      G ",
                        "      A ",
                        "      L ",
                        "      L ",
                        "      E ",
                        ".WHERRY.",
                        "      . "
                    },new GridList {
                        "    .      ",
                        "    A.     ",
                        ".FERRY.    ",
                        "   .GALLEY.",
                        " .SCOW.    ",
                        "   .SLAVER.",
                        "    Y.     ",
                        "    .      "
                    },new GridList {
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
                    },new GridList {
                        "   .     ",
                        "  .C     ",
                        " .TOSHER.",
                        ".TUG.    ",
                        "  B.     ",
                        "  .      "
                    },new GridList {
                        "      . ",
                        ".SLAVER.",
                        "      A ",
                        "      F ",
                        "      T ",
                        "      . "
                    },new GridList {
                        "      . ",
                        "      R ",
                        "      A ",
                        "      F ",
                        ".DUGOUT.",
                        "      . "
                    },new GridList {
                        "  . .   ",
                        "  J B   ",
                        ".DUGOUT.",
                        "  N A   ",
                        " .KETCH.",
                        "  . .   "
                    },new GridList {
                        "       . ",
                        "       A ",
                        ".SHOALER.",
                        "       K ",
                        "       . "
                    },new GridList {
                        " .     ",
                        " S     ",
                        " K     ",
                        " I     ",
                        ".FERRY.",
                        " F     ",
                        " .     "
                    },new GridList {
                        " .    ",
                        ".SHIP.",
                        " K    ",
                        " I    ",
                        " F    ",
                        " F    ",
                        " .    "
                    },new GridList {
                        "   .  ",
                        "   G  ",
                        ".SHIP.",
                        "   G  ",
                        "   .  "
                    }
                };

                case 9602:

                    return new List<GridList> {

                    new GridList {
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
                    },new GridList {
                        "   .    ",
                        "   M    ",
                        " . A    ",
                        " M G    ",
                        " E N    ",
                        ".TRIPOD.",
                        " E F    ",
                        ".RAYS.  ",
                        " . .    "
                    },new GridList {
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
                    },new GridList {
                        "       . .   ",
                        "      .LEVER.",
                        "       E I   ",
                        ".MAGAZINES.  ",
                        "       S I   ",
                        "       . O   ",
                        "         N   ",
                        "         .   "
                    },new GridList {
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
                    },new GridList {
                        "    . ",
                        ".RAYS.",
                        "    H ",
                        "    O ",
                        "    T ",
                        "    . "
                    },new GridList {
                        "    . ",
                        "    S ",
                        ".SHOT.",
                        "    I ",
                        "    L ",
                        "    L ",
                        "    . "
                    },new GridList {
                        " .     ",
                        ".STILL.",
                        " N     ",
                        " A     ",
                        " P     ",
                        " .     "
                    },new GridList {
                        " .       ",
                        " T       ",
                        " I       ",
                        ".MAGNIFY.",
                        " E       ",
                        " .       "
                    },new GridList {
                        "    . ",
                        "    T ",
                        "    A ",
                        ".SNAP.",
                        "    E ",
                        "    . "
                    },new GridList {
                        "     . ",
                        ".SHOOT.",
                        "     A ",
                        "     P ",
                        "     E ",
                        "     . "
                    },new GridList {
                        " .      ",
                        " B      ",
                        " U      ",
                        " L      ",
                        " B      ",
                        ".SPOOLS.",
                        " .      "
                    },new GridList {
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
                    },new GridList {
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
                    },new GridList {
                        "    .  ",
                        "    C  ",
                        "    U  ",
                        "    B  ",
                        "    E  ",
                        ".PRISM.",
                        "    .  "
                    },new GridList {
                        "     .  ",
                        "     C  ",
                        ".COLOUR.",
                        "     B  ",
                        "     E  ",
                        "     S  ",
                        "     .  "
                    },new GridList {
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
                    },new GridList {
                        "    . ",
                        "    M ",
                        "    I ",
                        "    R ",
                        "    R ",
                        ".HYPO.",
                        "    R ",
                        "    . "
                    },new GridList {
                        "    .    ",
                        "    L    ",
                        "    I.   ",
                        ".IMAGE.  ",
                        "   .HYPO.",
                        ".PLATE.  ",
                        "    ..   "
                    },new GridList {
                        "     . ",
                        ".LEVER.",
                        "     O ",
                        "     L ",
                        "     L ",
                        "     . "
                    }
                };

                case 9603:

                    return new List<GridList> {

                    new GridList {
                        "     .    ",
                        "     P    ",
                        "   . A    ",
                        "   V L    ",
                        "   I F    ",
                        "  .GORGET.",
                        "   I E    ",
                        ".TILTYARD.",
                        "   . .    "
                    },new GridList {
                        " . .      ",
                        ".CAVALRY. ",
                        " R I      ",
                        " E G      ",
                        " S I      ",
                        ".TILTYARD.",
                        " . .      "
                    },new GridList {
                        "     .   ",
                        ".PANOPLY.",
                        "     A   ",
                        "     L   ",
                        "     F   ",
                        "     R   ",
                        "     E   ",
                        "     Y   ",
                        "     .   "
                    },new GridList {
                        "     . ",
                        "     P ",
                        "     A ",
                        "     N ",
                        "     O ",
                        "     P ",
                        "     L ",
                        ".ESSAY.",
                        "     . "
                    },new GridList {
                        "     . .   ",
                        "    .ESSAY.",
                        "     P U   ",
                        ".WARRIOR.  ",
                        "     C C   ",
                        "     . O   ",
                        "       A   ",
                        "       T   ",
                        "       .   "
                    },new GridList {
                        "   .      ",
                        "   H      ",
                        "   E .    ",
                        "   R S    ",
                        "   A P    ",
                        ".VALOUR.  ",
                        "   D R    ",
                        "   .ESSAY.",
                        "     .    "
                    },new GridList {
                        "  .     ",
                        "  C .   ",
                        ".QUIVER.",
                        "  I A   ",
                        "  R L   ",
                        "  A O   ",
                        " .SPURS.",
                        "  S R   ",
                        "  . .   "
                    },new GridList {
                        "  . .   ",
                        ".SWORD. ",
                        "  A A   ",
                        ".PRINCE.",
                        "  R K   ",
                        "  I .   ",
                        "  O     ",
                        "  R     ",
                        "  .     "
                    },new GridList {
                        " .    ",
                        ".HERO.",
                        " E    ",
                        " R    ",
                        " A    ",
                        " L    ",
                        " D    ",
                        " .    "
                    },new GridList {
                        "  .     ",
                        "  P     ",
                        "  R     ",
                        "  I     ",
                        "  N     ",
                        "  C     ",
                        ".JENNET.",
                        "  .     "
                    },new GridList {
                        "     . .    ",
                        "     E S    ",
                        "     P U    ",
                        ".WARRIOR.   ",
                        "     C C    ",
                        "     .COURT.",
                        "       A    ",
                        "       T    ",
                        "       .    "
                    },new GridList {
                        "     . ",
                        "     C ",
                        "     A ",
                        "     S ",
                        ".COURT.",
                        "     L ",
                        "     E ",
                        "     . "
                    },new GridList {
                        "   . .  ",
                        ".CASTLE.",
                        "   Q I  ",
                        " .QUEST.",
                        "   I T  ",
                        "   R S  ",
                        "   E .  ",
                        "   .    "
                    },new GridList {
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

                    return new List<GridList> {

                    new GridList {
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
                    },new GridList {
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
                    },new GridList {
                        "         .     ",
                        "        .G     ",
                        "       .PAGODA.",
                        "     .WALL.    ",
                        "       .ALETTE.",
                        ".MEZZANINE.    ",
                        "        .R     ",
                        "         Y     ",
                        "         .     "
                    },new GridList {
                        "  . .   ",
                        "  P A   ",
                        "  A L   ",
                        "  G E   ",
                        ".HOSTEL.",
                        "  D T   ",
                        ".EAVES. ",
                        "  . .   "
                    },new GridList {
                        " .         ",
                        " D         ",
                        " O         ",
                        ".MEZZANINE.",
                        " E         ",
                        " .         "
                    },new GridList {
                        " .       ",
                        " T       ",
                        " H       ",
                        " E       ",
                        ".ALCAZAR.",
                        " T       ",
                        " R       ",
                        " E       ",
                        " .       "
                    },new GridList {
                        " .       ",
                        ".ARMOURY.",
                        " T       ",
                        " R       ",
                        " I       ",
                        " U       ",
                        " M       ",
                        " .       "
                    },new GridList {
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
                    },new GridList {
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
                    },new GridList {
                        "         . ",
                        "         A ",
                        "         B ",
                        "         B ",
                        "         E ",
                        ".MONASTERY.",
                        "         . "
                    },new GridList {
                        " .  . ",
                        ".STUD.",
                        " C  O ",
                        " A  O ",
                        ".PIER.",
                        " E  . ",
                        " .    "
                    },new GridList {
                        "   . ",
                        "   A ",
                        ".HUT.",
                        "   R ",
                        "   I ",
                        "   U ",
                        "   M ",
                        "   . "
                    },new GridList {
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
                    },new GridList {
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

                    return new List<GridList> {

                    new GridList {
                        "    .  ",
                        "    A  ",
                        "    S  ",
                        "    S  ",
                        "    I  ",
                        ".PRIZE.",
                        "    E  ",
                        "    S  ",
                        "    .  "
                    },new GridList {
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
                    },new GridList {
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
                    },new GridList {
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
                    },new GridList {
                        "     . ",
                        "     J ",
                        "     U ",
                        "     R ",
                        ".USURY.",
                        "     . "
                    },new GridList {
                        "  .   ",
                        "  S   ",
                        ".JURY.",
                        "  I   ",
                        "  T   ",
                        "  .   "
                    },new GridList {
                        "    . ",
                        "    S ",
                        ".SUIT.",
                        "    E ",
                        "    A ",
                        "    L ",
                        "    . "
                    },new GridList {
                        "       . ",
                        "       E ",
                        ".SUMMONS.",
                        "       C ",
                        "       R ",
                        "       O ",
                        "       W ",
                        "       . "
                    },new GridList {
                        "     .   ",
                        "     P   ",
                        " .ESCROW.",
                        " O   I   ",
                        ".ARREST. ",
                        " T   O   ",
                        " H   N   ",
                        " .   .   "
                    },new GridList {
                        "      . ",
                        "      L ",
                        "      A ",
                        ".ESCROW.",
                        "      . "
                    },new GridList {
                        "     .   ",
                        "     P   ",
                        "     R   ",
                        "   . I   ",
                        ".ARREST. ",
                        "   O O   ",
                        "  .BENCH.",
                        "   . .   "
                    },new GridList {
                        "    . ",
                        "    O ",
                        "    A ",
                        ".WRIT.",
                        "    H ",
                        "    . "
                    },new GridList {
                        "       . ",
                        "       C ",
                        "       A ",
                        ".ASSIZES.",
                        "       E ",
                        "       . "
                    },new GridList {
                        "       . ",
                        ".LAWSUIT.",
                        "       R ",
                        "       E ",
                        "       A ",
                        "       S ",
                        "       O ",
                        "       N ",
                        "       . "
                    },new GridList {
                        " .   ",
                        " L   ",
                        " A   ",
                        " W   ",
                        " S   ",
                        ".USE.",
                        " I   ",
                        " T   ",
                        " .   "
                    },new GridList {
                        " .      ",
                        " L      ",
                        ".INSULT.",
                        " E      ",
                        " N      ",
                        " .      "
                    }
                };

                default:
                    
                    return new List<GridList>();
            }
        }
    }
}