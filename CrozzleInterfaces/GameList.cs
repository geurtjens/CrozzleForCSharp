﻿using System;
namespace CrozzleInterfaces
{
    public class GameList
    {


        public static GameIdList Games()
        {
            return new GameIdList {
            8612, 8704, 8705, 8710, 8711, 8712,
            8802, 8803, 8804, 8805, 8806, 8807, 8808, 8809, 8810, 8811, 8812,
            8902, 8903, 8904, 8905, 8906, 8907, 8908, 8909, 8910, 8911, 8912,
            9001, 9002, 9003, 9004, 9005, 9006, 9007, 9008, 9009, 9010, 9011, 9012,
            9101, 9102, 9103, 9104, 9105, 9106, 9107, 9108, 9109, 9110, 9111, 9112,
            9201, 9202, 9203, 9204, 9206, 9207, 9208, 9209, 9210, 9211, 9212,
            9301, 9302, 9303, 9304, 9305, 9306, 9307, 9308, 9309, 9310, 9311, 9312,
            9401, 9402, 9403, 9404, 9406, 9407, 9408, 9409, 9410, 9411, 9412,
            9501, 9502, 9503, 9504, 9505, 9506, 9507, 9508, 9509, 9510, 9511, 9512,
            9601, 9602, 9603, 9604, 9605 };
        }


        public static GameModel FindGame(int gameId)
        {
            switch (gameId)
            {

                case 8612:
                    return new GameModel(8612, 694, 17, 12,
                        new WordList() { "ZION", "AZURE", "TOYS", "JOY", "HAZELNUT", "NUTS", "NAZARETH", "HYMN", "TURKEY", "SNOW", "MERRY", "TOAST", "STAR", "HOLLY", "JELLY", "FAMILY", "WHITE", "SING", "SAUCE", "PORK", "TREE", "EVE", "INN", "BELLS", "CAKE" },
                        new WordList() { "ZION", "AZURE", "TOYS", "JOY", "HAZELNUT", "NUTS", "NAZARETH", "HYMN", "TURKEY", "SNOW", "MERRY", "TOAST", "STAR", "HOLLY", "JELLY", "FAMILY", "WHITE", "SING", "SAUCE", "PORK", "TREE", "EVE", "INN", "BELLS", "CAKE", "GLAZE", "PARTYHATS", "TWENTYFIFTH", "WALNUT", "PEANUTS", "PRESENTS", "FRUIT", "NUTMEG", "CUSTARD", "CHRISTMAS", "MISTLETOE", "GIFTS", "SANTACLAUS", "FESTIVE", "RAISINS", "LIGHTS", "WREATH", "HOLIDAY", "WISEMEN", "CRANBERRY", "OPENHOUSE", "SILENTNIGHT", "STOCKING", "PUNCH", "WINE", "SHOPPING", "PLUMPUDDING", "WRAPPING", "NEIGHBOURS", "GREETINGS", "DECORATIONS", "ALMONDS", "LANTERN", "KRISSKRINGLE", "SPICE", "GOODWILL", "BONBON", "CHURCH", "FRIENDS", "PARCELS", "CINNAMON", "NICHOLAS", "MINCEPIES", "CHERRIES", "SLEIGH", "ALMOND", "MANGER", "RIBBON", "CHOCOLATE", "MIXEDPEEL", "DRINK", "CANDLES", "FOOD", "GINGER", "BETHLEHEM", "CAROL", "REINDEER", "GOODCHEER", "CREAM", "CORDIAL", "CHILDREN", "ICECREAM", "CHICKEN", "CARD", "DECEMBER", "PEACE" },
                        new GridList(){
                        " . . . . .  . .  ",
                        " S F C.NAZARETH. ",
                        " N A A U I  V O  ",
                        " O M K T O.BELLS.",
                        ".WHITE.SING.. L  ",
                        " . L..P. ...JOY. ",
                        ".TOYS.O . A E .S ",
                        " O .A R.HAZELNUT.",
                        " A.TURKEY.U L  A ",
                        " S  C ..MERRY. R ",
                        ".TREE.INN.E .  . ",
                        " .  .   . .      " });

                case 8704:
                    return new GameModel(8704, 704, 17, 12,
                        new WordList() { "STANZA", "PRIZE", "YEATS", "POESY", "HYMN", "TEXT", "SCOTT", "GRAY", "RHYME", "SLESSOR", "DOYLE", "HARDY", "SAXE", "ELEGY", "FOOT", "POET", "MILTON", "SCAN", "HOMER", "POE", "DONNE", "HOOD", "HOPE", "BRIDGES", "LAMB", "ODE" },
                        new WordList() { "STANZA", "PRIZE", "YEATS", "POESY", "HYMN", "TEXT", "SCOTT", "GRAY", "RHYME", "SLESSOR", "DOYLE", "HARDY", "SAXE", "ELEGY", "FOOT", "POET", "MILTON", "SCAN", "HOMER", "POE", "DONNE", "HOOD", "HOPE", "BRIDGES", "LAMB", "ODE", "SOUTHEY", "POETRY", "TENNYSON", "RHYTHM", "NURSERYRHYME", "BYRON", "BUNYAN", "ROSSETTI", "STEVENSON", "WORDSWORTH", "QUOTE", "OMARKHAYYAM", "SONNET", "KINGSLEY", "IDYLL", "SHELLEY", "SONG", "CHORUS", "LAWSON", "VERSE", "WHITTIER", "JONSON", "WRIGHT", "SPENSER", "NONSENSE", "PATERSON", "WILCOX", "CHESTERTON", "KEATS", "COUPLET", "NEWBOLT", "QUATRAIN", "THACKERAY", "PSALM", "EMERSON", "COWPER", "GOLDSMITH", "BROWNING", "HOLMES", "MARLOWE", "ELIOT", "DENNIS", "RONDEAU", "BLANKVERSE", "SAGA", "DANTE", "ADDISON", "LONGFELLOW", "SHAKESPEARE", "MEREDITH", "GILBERT", "BETJEMAN", "GILMORE", "BROOKE", "MILNE", "CARROLL", "CHAUCER", "KIPLING", "MILLER", "MASEFIELD", "LIMERICK", "DOGGEREL", "MADRIGAL", "EPIC", "LEAR", "COLERIDGE", "MACKELLAR", "BELLOC", "BARD", "LEACOCK", "BLAKE" },
                        new GridList() {
                "   .    .  .  .  ",
                ".POE..LAMB.F  P  ",
                "   L H  I.HOMER. ",
                " . E O  L .O  I  ",
                " B G.POET.STANZA.",
                ".RHYME..O L.. E  ",
                " I ...DONNE.P .  ",
                " D .HOOD..SCOTT. ",
                ".GRAY.YEATS.E E  ",
                " E  M L.  O.SAXE.",
                ".SCAN.E.HARDY.T  ",
                " .  . .   . . .  "});

                case 8705:
                    return new GameModel(8705, 610, 17, 12,
                new WordList() { "POT", "HOSE", "ALYSSUM", "MIMOSA", "SWEEP", "PANSY", "WEED", "MOWER", "STALK", "PATH", "PEONY", "DIG", "ROSE", "CAN", "PALM", "WATER", "TRIM", "EDGES", "GRASS", "TAP", "LAWN", "MAY", "POOL", "STEM", "POPPY", "BUD", "PEST", "EARTH", "SOW", "SALVIA", "LILY" },
                new WordList() { "POT", "HOSE", "ALYSSUM", "MIMOSA", "SWEEP", "PANSY", "WEED", "MOWER", "STALK", "PATH", "PEONY", "DIG", "ROSE", "CAN", "PALM", "WATER", "TRIM", "EDGES", "GRASS", "TAP", "LAWN", "MAY", "POOL", "STEM", "POPPY", "BUD", "PEST", "EARTH", "SOW", "SALVIA", "LILY", "ZINNIA", "AZALEA", "GAZANIA", "LOTUS", "DAISY", "SHRUBS", "WORDSWORTH", "OMARKHAYYAM", "BOUQUET", "DISPLAY", "TULIP", "WATTLE", "SNOWDROP", "STOCK", "NATIVES", "CACTUS", "HYACINTH", "BLOSSOM", "ASTER", "TREES", "TUBER", "CROCUS", "PRUNE", "VIOLET", "LARKSPUR", "IRIS", "SOIL", "FLOWERS", "HIBISCUS", "PLANT", "ROCKS", "VINE", "CYCLAMEN", "JONQUIL", "NITROGEN", "HYDRANGEA", "JASMIN", "BROOM", "MULCH", "VIOLA", "SPRINKLE", "ANNUAL", "BONSAI", "LILIUM", "CORM", "IXIA", "PLUMBAGO", "CARNATION", "DISEASE", "SAXIFRAGE", "BULB", "PINK", "BLOOM", "SPADE", "SHAKESPEARE", "VERBENA", "BALSAM", "FORK", "SEED", "ANEMONE", "PREPARE", "FREESIA", "ORGANIC", "LANDSCAPE", "PERENNIAL", "FERN", "MARIGOLD", "DRAIN", "GREEN", "HOE", "ORCHID", "CALENDULA", "CANNA", "GARDEN", "BEGONIA", "CLIMBER", "ALOE", "RAKE", "GARDENIA", "CLARKIA", "LOBELIA", "CAMELLIA", "DAFFODIL", "LILAC", "DAHLIA", "LEAF", "ACACIA", "BED" },
                new GridList() {
                " . . . .         ",
                ".POT.G M  .    . ",
                " A R R.A. B    L ",
                " L I.ALYSSUM.  I ",
                ".MIMOSA.T.D.E .L ",
                " . ..SWEEP.PANSY.",
                "     .N.MOWER.A. ",
                "     T.P.P.STALK.",
                "     A O.PATH.V  ",
                "    .PEONY...DIG.",
                "     . L .    A  ",
                "       .      .  "});

                case 8710:
                    return new GameModel(8710, 764, 17, 12,
                new WordList() { "LORY", "TURKEY", "JAY", "MYNA", "TIT", "TUI", "TOMTIT", "SWAN", "SKYLARK", "SKUA", "ROOSTER", "SPARROW", "SWALLOW", "OWL", "OWLET", "CANARY", "GROUSE", "EMU", "TERN", "WREN", "SNIPE", "AUK", "ROOK", "IBIS", "SHAG", "EGRET", "CHAT", "ROC", "TEAL", "HEN" },
                new WordList() { "LORY", "TURKEY", "JAY", "MYNA", "TIT", "TUI", "TOMTIT", "SWAN", "SKYLARK", "SKUA", "ROOSTER", "SPARROW", "SWALLOW", "OWL", "OWLET", "CANARY", "GROUSE", "EMU", "TERN", "WREN", "SNIPE", "AUK", "ROOK", "IBIS", "SHAG", "EGRET", "CHAT", "ROC", "TEAL", "HEN", "BUZZARD", "QUETZEL", "OSPREY", "APTERYX", "CASSOWARY", "STILT", "VULTURE", "SWIFT", "CYGNET", "THRUSH", "BOOBY", "STORK", "BUSTARD", "TOUCAN", "CROW", "PARROT", "PULLET", "OSTRICH", "ALBATROSS", "FROGMOUTH", "PIPIT", "CURLEW", "PEEWIT", "BITTERN", "LYREBIRD", "STARLING", "AVOCET", "PLOVER", "GOOSE", "FOWL", "KESTREL", "BULBUL", "PHEASANT", "RAVEN", "PENGUIN", "PHOENIX", "DOVE", "GULL", "LOON", "LINNET", "SEAGULL", "WAGTAIL", "QUAIL", "CUCKOO", "GANNET", "PETREL", "PUFFIN", "HAWK", "KITE", "SANDPIPER", "BANTAM", "MOPOKE", "SHRIKE", "ROSELLA", "COCKATOO", "MOA", "PEN", "HERON", "MACAW", "ROBIN", "WADER", "LORIKEET", "WHIPBIRD", "PARTRIDGE", "LOVEBIRD", "ORIOLE", "PIGEON", "FANTAIL", "DIPPER", "HORNBILL", "HARRIER", "DODO", "ERNE", "BLUEBIRD", "BOBOLINK", "COCKATIEL", "MAGPIE", "JACKDAW", "LARK", "CRANE", "FALCON", "GANDER", "MALLARD", "PELICAN", "COCK", "RHEA", "FINCH", "PEACOCK", "DRAKE", "EIDER", "GREBE", "BELLBIRD", "BLACKBIRD", "EAGLE", "KEA" },
                new GridList() {
                "  . .   . .  . . ",
                "  J.SNIPE.R .T C ",
                "  A H ..GROUSE.A ",
                ".MYNA.R R O.WREN.",
                "  . G.O E.SWAN.A ",
                ".HEN.TOMTIT.L. R ",
                " .M.AUK.. E.LORY.",
                ".TUI.R.SPARROW.. ",
                " E.B K K  .OWLET.",
                " A I E U   C.. I ",
                " L.SKYLARK..CHAT.",
                " . . . .       . "});

                case 8711:
                    return new GameModel(8711, 810, 17, 12,
                new WordList() { "AZURE", "ZOFFANY", "SOOTY", "RUBY", "BAY", "RUDDY", "SANDY", "GOYA", "GREY", "EBONY", "DYCK", "BRUSH", "TUBE", "ART", "DUN", "RUBENS", "TAN", "TONE", "COROT", "COLOUR", "PAINT", "ROUGE", "HUE", "JET", "UMBER", "SEPIA", "BLUE", "AMBER", "RED", "LAKE", "LAC", "JADE" },
                new WordList() { "AZURE", "ZOFFANY", "SOOTY", "RUBY", "BAY", "RUDDY", "SANDY", "GOYA", "GREY", "EBONY", "DYCK", "BRUSH", "TUBE", "ART", "DUN", "RUBENS", "TAN", "TONE", "COROT", "COLOUR", "PAINT", "ROUGE", "HUE", "JET", "UMBER", "SEPIA", "BLUE", "AMBER", "RED", "LAKE", "LAC", "JADE", "TAWNY", "CEZANNE", "RUSSET", "SCOTT", "ROMNEY", "YELLOW", "TEXTURE", "ROSSETTI", "LELY", "TINTORETTO", "REYNOLDS", "TURNER", "MIX", "STAIN", "MATISSE", "MAUVE", "WHISTLER", "AUBURN", "UTRILLO", "BROWN", "MONET", "WHITE", "SILVER", "TITIAN", "VIOLET", "PICASSO", "SARGENT", "BEARDSLEY", "CRIMSON", "GAUGUIN", "CANVAS", "PURPLE", "MURILLO", "SICKERT", "OPAQUE", "MANET", "PALETTE", "PIGMENT", "SCARLET", "FAWN", "GILT", "PUCE", "MAROON", "GAINSBOROUGH", "VERMILION", "OLIVE", "ORPEN", "CANALETTO", "CONSTABLE", "HOGARTH", "RAEBURN", "SAFFRON", "VERMEER", "HALS", "SAPPHIRE", "MILLET", "RENOIR", "REMBRANDT", "BOTTICELLI", "JOHN", "PINK", "NOLAN", "LACQUER", "MAGENTA", "MILLAIS", "CERISE", "CLARET", "COBALT", "BUFF", "OPIE", "LANDSEER", "LAVENDER", "LAWRENCE", "CHROME", "ORANGE", "CHOCOLATE", "DEGAS", "EASEL", "INDIGO", "FRAGONARD", "CORAL", "GREEN", "HENNA", "MODEL", "OCHRE", "GOLDEN", "HOLBEIN", "ANIL", "CREAM", "ENAMEL", "MICHELANGELO", "RAPHAEL", "DRAB", "BEIGE", "BLACK", "BICE" },
                new GridList() {
                " . .  .  ..  . . ",
                " J.TUBE.LAC. L D ",
                " A A  B .ZOFFANY.",
                ".DUN.COLOUR..K C ",
                " E .H N .ROUGE.K ",
                " ..RUBY.JET.R. . ",
                ".BLUE..U ..SEPIA.",
                " R B.B M .GOYA.R ",
                " U E.AMBER.O.I T ",
                ".SANDY.E E.TONE. ",
                " H S ..RUDDY.T   ",
                " . .   . . . .   "});

                case 8712:
                    return new GameModel(8712, 680, 17, 12,
                new WordList() { "TOYS", "YULE", "TURKEY", "GUESTS", "SWEETS", "HOLLY", "PLUMS", "PARSLEY", "PORT", "ROAST", "WISHES", "BUSH", "PRESENTS", "SALT", "JELLY", "SUGAR", "NUTMEG", "DATES", "SAUCE", "WINE", "MEAT", "TREE", "EGGS", "SPICE", "FARE" },
                new WordList() { "TOYS", "YULE", "TURKEY", "GUESTS", "SWEETS", "HOLLY", "PLUMS", "PARSLEY", "PORT", "ROAST", "WISHES", "BUSH", "PRESENTS", "SALT", "JELLY", "SUGAR", "NUTMEG", "DATES", "SAUCE", "WINE", "MEAT", "TREE", "EGGS", "SPICE", "FARE", "NUTS", "GLAZED", "MARZIPAN", "GRAVY", "TOAST", "RUM", "BUTTER", "MIXTURE", "SULTANAS", "TOMATO", "HATS", "BISCUITS", "CURRANTS", "POTATOES", "FRUIT", "BRANDY", "CUSTARD", "ONIONS", "STREAMERS", "GLASSES", "STUFFING", "MISTLETOE", "CELERY", "SILVER", "CASHEWS", "LETTUCE", "LIQUEUR", "RAISINS", "LIGHTS", "LIQUOR", "FLOWERS", "PUMPKIN", "APRICOTS", "FLOUR", "PUNCH", "SEASONING", "BOWL", "PEARS", "GREETINGS", "PORK", "DECORATIONS", "ALMONDS", "CLOTH", "CAROLS", "GRAPES", "VEGETABLES", "FIGS", "BALLOONS", "BASIN", "HERBS", "MIXED", "PUDDING", "MARASCHINO", "BEANS", "CARDS", "LEMON", "MELON", "TRIFLE", "CINNAMON", "CHERRIES", "BANANAS", "CRANBERRIES", "BELLS", "JUICE", "NOEL", "CARAMELS", "ORANGE", "SALAD", "CANDLES", "PEACHES", "PINEAPPLE", "GINGER", "HAM", "CHEESE", "LEMONADE", "CHAMPAGNE", "ICING", "CORDIAL", "LAMB", "PEEL", "CHICKEN", "CHEER", "DRIED", "COFFEE", "ICE", "CAKE", "BEEF" },

                new GridList() {
                "   . .   .   .   ",
                ".DATES.  F.WINE. ",
                "   R A.MEAT. U P ",
                " .JELLY..ROAST.A ",
                "   E.TURKEY. M R ",
                "  ..G.L  .SWEETS.",
                " .SAUCE. B.I G L ",
                "  U E .PLUMS.. E ",
                ".EGGS. O S.HOLLY.",
                "  A T  R H E   . ",
                ".PRESENTS..SPICE.",
                "  . .  .   .     "});

                case 8802:
                    return new GameModel(8802, 720, 17, 12,
                new WordList() { "PRIZE", "STUDY", "GYM", "BOYS", "SUMS", "SWOT", "BLAZER", "COPY", "PHYSICS", "PLAY", "SPORT", "CRAYON", "MATHS", "QUIET", "TENNIS", "MATES", "ART", "TERM", "CLASS", "TABLES", "LINES", "CAPTAIN", "PEN", "ROLL", "INK", "CANE" },
                new WordList() { "PRIZE", "STUDY", "GYM", "BOYS", "SUMS", "SWOT", "BLAZER", "COPY", "PHYSICS", "PLAY", "SPORT", "CRAYON", "MATHS", "QUIET", "TENNIS", "MATES", "ART", "TERM", "CLASS", "TABLES", "LINES", "CAPTAIN", "PEN", "ROLL", "INK", "CANE", "HISTORY", "STUDENT", "SONGS", "CHEMISTRY", "PRIMARY", "GEOMETRY", "ROSTER", "SETSQUARE", "TUCKSHOP", "MUSIC", "PLAYGROUND", "SEAT", "HOLIDAYS", "TEXTBOOK", "LABORATORY", "SECONDARY", "BIOLOGY", "WOODWORK", "BURSAR", "MASTER", "COMPASS", "LIBRARY", "MONITOR", "WRITING", "POEMS", "PROTRACTOR", "SPANISH", "PUPIL", "JUNIOR", "PROJECTS", "GEOGRAPHY", "UNIFORM", "RECESS", "SENIOR", "BOOKS", "RULER", "OVAL", "HSC", "FRACTIONS", "HOMEWORK", "VACATION", "GIRLS", "LECTURE", "PARSING", "EXAM", "SCHOOL", "LUNCH", "EDUCATION", "FORM", "LANGUAGES", "CALCULATOR", "ERASER", "RUBBER", "DRAWING", "SPELLING", "TIMETABLE", "HEADMASTER", "INDONESIAN", "DESK", "ENGLISH", "FRIENDS", "SHAKESPEARE", "FOOTBALL", "GRAMMAR", "ITALIAN", "PREFECT", "SPEECH", "PAPER", "COOKING", "CRICKET", "GERMAN", "PRINCIPAL", "SCIENCE", "TEACHER", "CRAM", "FOOD", "DECIMALS", "LOCKER", "PENCIL", "FRENCH", "READING", "CHAIR", "REFERENCE", "COLLEGE", "BLACKBOARD", "ALGEBRA", "CHALK", "BELL", "FLAG" },

                new GridList() {
                " .    .   .      ",
                ".TABLES.  P  . . ",
                " E  . U .CLASS.B ",
                ".ROLL.M Q A .W.O ",
                " M. I.STUDY.COPY.",
                " .CANE..I .MATHS.",
                "  R E .PEN. P.Y. ",
                "  A.SPORT.MATES. ",
                ".GYM.  I.A  A I  ",
                "  O.BLAZER. I C  ",
                ".INK.  E.TENNIS. ",
                "  .    . .  . .  "});

                case 8803:
                    return new GameModel(8803, 626, 17, 12,
                new WordList() { "SUEZ", "ZURICH", "SYDNEY", "AYR", "TOKYO", "YORK", "QUITO", "TORONTO", "BOMBAY", "OMSK", "OSLO", "LAGOS", "BOGOTA", "HOBART", "TOLEDO", "BONN", "RENO", "ROME", "OSAKA", "CORK", "CAIRO", "OMAHA", "LIMA", "DELHI" },
                new WordList() { "SUEZ", "ZURICH", "SYDNEY", "AYR", "TOKYO", "YORK", "QUITO", "TORONTO", "BOMBAY", "OMSK", "OSLO", "LAGOS", "BOGOTA", "HOBART", "TOLEDO", "BONN", "RENO", "ROME", "OSAKA", "CORK", "CAIRO", "OMAHA", "LIMA", "DELHI", "TUCSON", "HOUSTON", "TULSA", "BUTTE", "TURIN", "OTTAWA", "WARSAW", "BRUSSELS", "BOSTON", "MOSCOW", "PITTSBURGH", "SEOUL", "VANCOUVER", "HONOLULU", "ISTANBUL", "TASHKENT", "YOKOHAMA", "SEATTLE", "ATHENS", "JUNEAU", "DETROIT", "STOCKHOLM", "CALGARY", "GLASGOW", "PARIS", "PERTH", "BUCHAREST", "CALCUTTA", "EDMONTON", "SANTIAGO", "OXFORD", "ATLANTA", "MEMPHIS", "PHOENIX", "AMSTERDAM", "LISBON", "MUNICH", "MONTREAL", "JERUSALEM", "LIVERPOOL", "HAMILTON", "WINNIPEG", "DARWIN", "NAPLES", "PRAGUE", "VIENNA", "SINGAPORE", "RANGOON", "NOME", "MELBOURNE", "BOISE", "DENVER", "LONDON", "MADRAS", "BELFAST", "BATH", "DUBLIN", "GDANSK", "TEHERAN", "HAVANA", "BRISBANE", "SHANGHAI", "JAKARTA", "QUEBEC", "NAGASAKI", "HANOI", "MIAMI", "BUFFALO", "BREMEN", "DALLAS", "PEKING", "AUCKLAND", "ALEXANDRIA", "CARACAS", "HALIFAX", "GENOA", "COPENHAGEN", "BERLIN", "MANILA", "REGINA", "LENINGRAD", "BANGKOK", "MADRID", "CANBERRA", "CASABLANCA", "ERIE", "NICE", "CHICAGO", "KARACHI", "DAKAR", "MECCA", "BAGHDAD", "ADELAIDE", "DACCA" },

                new GridList() {
                "  .    .  .      ",
                "  S ..BOGOTA.  . ",
                ".QUITO.M  O  . C ",
                "  E O  A  L .L O ",
                " .ZURICH.DELHI.R ",
                "  . O  A  D.OMSK.",
                ".BONN. ..BOMBAY. ",
                "  S.TOKYO.. A.D  ",
                ".LAGOS.O   .RENO.",
                "  K .L.ROME.T E  ",
                ".CAIRO.K    .AYR.",
                "  .  . .      .  "});

                case 8804:
                    return new GameModel(8804, 836, 17, 12,
                new WordList() { "MEZZO", "MAZURKA", "HYMN", "STRUM", "KEY", "STOP", "SLOW", "SLUR", "MUTE", "REST", "TUNE", "HUM", "LOW", "SONG", "TRIO", "BASSO", "DUO", "NOTE", "TONE", "TEMPO", "HIT", "SIGN", "TIME", "TIE", "FORTE", "SCORE", "FRET", "VIOLA", "MOOD", "HARP", "MARCH", "HOLD", "ARIA", "ECHO" },
                new WordList() { "MEZZO", "MAZURKA", "HYMN", "STRUM", "KEY", "STOP", "SLOW", "SLUR", "MUTE", "REST", "TUNE", "HUM", "LOW", "SONG", "TRIO", "BASSO", "DUO", "NOTE", "TONE", "TEMPO", "HIT", "SIGN", "TIME", "TIE", "FORTE", "SCORE", "FRET", "VIOLA", "MOOD", "HARP", "MARCH", "HOLD", "ARIA", "ECHO", "JAZZ", "WALTZ", "PIZZICATO", "SYMPHONY", "OPUS", "RHYTHM", "TRUMPET", "SYNCOPATE", "HARMONY", "RHAPSODY", "XYLOPHONE", "LUTE", "OVERTURE", "MELODY", "STRING", "GAMUT", "LULLABY", "BASS", "DUET", "SOLO", "CHORUS", "MINUET", "VOLUME", "PAUSE", "QUAVER", "SONATA", "DRUM", "MOVEMENT", "NOCTURNE", "TENOR", "CYMBAL", "GUITAR", "SOPRANO", "FLUTE", "FUGUE", "NATURAL", "SAXOPHONE", "CONDUCTOR", "TREMOLO", "OCTAVE", "ETUDE", "SHARP", "STAFF", "TACET", "ALTO", "INTERVAL", "KEYBOARD", "TROMBONE", "CORNET", "VIOLIN", "ORCHESTRA", "CANTO", "MINOR", "HORN", "LILT", "DULCET", "CANTATA", "PITCH", "QUICK", "CONCERTO", "POLONAISE", "MINIM", "THEME", "BARITONE", "FLAT", "BREVE", "MAJOR", "ORGAN", "PIANO", "BUNGLE", "LEGATO", "PRELUDE", "OBLIGATO", "CLARINET", "ANDANTE", "TREBLE", "OPERA", "CRESCENDO", "BEAT", "PIPE", "SERENADE", "LARGO", "POLKA", "SCALE", "PICCOLO", "OBOE", "ENCORE", "ARPEGGIO", "BANJO", "CAROL", "CHORD", "ALLEGRO", "BAR", "JIG", "HIGH", "REEL", "CHIME", "FANFARE", "ADAGIO", "PEDAL", "BAND", "CODA", "REED", "BALLAD", "CLEF", "FIFE" },

                new GridList() {
                "    . .  . . . . ",
                "  ..SONG.D R.HIT.",
                "  K I O.TUNE.A I ",
                " .E.G.TRIO.STRUM.",
                ".HYMN.E.E.STOP.E ",
                " U.E.A.B..L.N. . ",
                ".MAZURKA.MUTE. E ",
                " . Z.I.SCORE.F C ",
                ".VIOLA.S O.MARCH.",
                "   .O.HOLD.P E O ",
                ".SLOW. . .FORTE. ",
                "    .      . .   "});

                case 8805:
                    return new GameModel(8805, 688, 17, 12,
                new WordList() { "MAIZE", "RYE", "GRAZING", "HAY", "STUD", "STRAW", "MOW", "OATS", "ROOT", "STOCK", "HARVEST", "WOOL", "ROTATION", "SILO", "SOIL", "WHEAT", "PLANT", "TANK", "CART", "MEAT", "EWE", "SHEEP", "SHED", "SEED", "PIG", "BIN", "HOE", "LAMB", "RAKE" },
                new WordList() { "MAIZE", "RYE", "GRAZING", "HAY", "STUD", "STRAW", "MOW", "OATS", "ROOT", "STOCK", "HARVEST", "WOOL", "ROTATION", "SILO", "SOIL", "WHEAT", "PLANT", "TANK", "CART", "MEAT", "EWE", "SHEEP", "SHED", "SEED", "PIG", "BIN", "HOE", "LAMB", "RAKE", "PRIZES", "POULTRY", "FERTILIZER", "MUSTER", "COWS", "BUTTER", "STATION", "HUSBANDRY", "AGRONOMY", "HAYSTACK", "PASTURE", "DAIRY", "SOWING", "TROUGH", "VINEYARD", "YIELD", "CULTIVATION", "TRACTOR", "AGISTMENT", "STALL", "BARLEY", "HARVESTER", "PASTURAGE", "PRUNING", "LIVESTOCK", "HARROW", "CHURN", "RURAL", "PLANTATION", "APIARIST", "AGRICULTURE", "FARROW", "MANURE", "PLOUGH", "THRESHING", "ELEVATOR", "CROFT", "DROVING", "CATTLE", "SHEAVE", "STABLE", "GRAPES", "HOMESTEAD", "PLOUGHING", "IRRIGATION", "CROP", "HOGGET", "MERINO", "MILLET", "ANIMALS", "WINDMILL", "FALLOW", "LUCERNE", "GRAFTING", "SHEARING", "RINGER", "BUCOLIC", "DIPPING", "SILAGE", "JILLAROO", "GRAIN", "FARMING", "MILKING", "REAPING", "TILLAGE", "BARN", "REAPER", "BRANDING", "JACKEROO", "FOALING", "BINDER", "DAM", "HERD", "FODDER", "PADDOCK", "BREEDING", "HEIFER", "ARABLE", "CEREAL", "CALF", "CHAFF", "FEED" },

                new GridList() {
                " .  .   .  . .   ",
                ".STOCK..RAKE.R   ",
                " T  A.HAY..WOOL. ",
                " U .R  .E.MEAT.  ",
                " D.STRAW.G .TANK.",
                " . E. .HARVEST.  ",
                ".SHED..E A  .I . ",
                " H D .MAIZE.SOIL.",
                " E .ROOT.I.BIN.A ",
                " E    W. N  L. M ",
                ".PLANT.PIG.HOE.B ",
                " .       .  .  . "});

                case 8806:
                    return new GameModel(8806, 816, 17, 12,
                new WordList() { "GUY", "YAW", "STAY", "PLY", "BUOY", "QUAY", "JETTY", "DORY", "AHOY", "SET", "YACHT", "MAST", "PORT", "PROW", "BOWSPRIT", "TRANSOM", "TRIM", "ASTERN", "BOW", "BOX", "SPAR", "HAWSER", "JUNK", "MOOR", "SHIP", "WATCH", "CREW", "AFT", "SAIL", "OAR", "TACK", "LOG", "FOG" },
                new WordList() { "GUY", "YAW", "STAY", "PLY", "BUOY", "QUAY", "JETTY", "DORY", "AHOY", "SET", "YACHT", "MAST", "PORT", "PROW", "BOWSPRIT", "TRANSOM", "TRIM", "ASTERN", "BOW", "BOX", "SPAR", "HAWSER", "JUNK", "MOOR", "SHIP", "WATCH", "CREW", "AFT", "SAIL", "OAR", "TACK", "LOG", "FOG", "MIZZEN", "HORIZON", "STORM", "SEXTANT", "VOYAGE", "STERN", "CUTTER", "HATCHWAY", "GANGWAY", "QUARTERS", "JETTISON", "KNOT", "DINGHY", "SLOOP", "STEER", "COURSE", "SCUPPER", "WINDLASS", "STEAMSHIP", "SWELL", "SQUALL", "TOPSAIL", "SLIP", "SHEET", "GALLEY", "HYDROFOIL", "STEAMBOAT", "OUTRIGGER", "CAPSTAN", "HALYARD", "STEAMER", "CANVAS", "BUNK", "DHOW", "WIND", "PENNANT", "WINDWARD", "WEATHER", "STARBOARD", "SAILOR", "SCHOONER", "PAINTER", "PITCH", "SHOAL", "NAUTICAL", "NAVIGATE", "ASHORE", "TANKER", "SPINNAKER", "BALLAST", "FORWARD", "BOOM", "ROPE", "ALOFT", "BERTH", "CHART", "WHARF", "LUGGER", "RUDDER", "TILLER", "TIDE", "WAKE", "LAUNCH", "SPLICE", "LIGHTER", "CAULK", "FLUKE", "HATCH", "KETCH", "WHEEL", "CATAMARAN", "FREIGHTER", "PIER", "FRIGATE", "RIG", "ANCHOR", "LINER", "CLIPPER", "LEEWARD", "RIGGING", "TACKLE", "LIFEBOAT", "INBOARD", "PINNACE", "LOCKER", "GALLEON", "BRIG", "HELM", "HOLD", "LINE", "BULKHEAD", "ANCHORAGE", "BOLLARD", "JIG", "DOCK", "RAKE", "BLOCK", "ABOARD", "CAREEN", "BINNACLE", "BRIDGE", "CABIN", "BEAM", "ABEAM", "BILGE", "ALEE", "DECK" },

                new GridList() {
                " . . .   . .     ",
                ".TRANSOM.S.SHIP. ",
                " A S A  .P.E . P ",
                " C.TRIM.MAST.G L ",
                " K E L.PORT.BUOY.",
                " . R .D O.AHOY.. ",
                ".JUNK.OAR.YAW. W ",
                " E . .R .F.W.C A ",
                " T.QUAY.BOWSPRIT.",
                " T   F.LOG.E E C ",
                ".YACHT. X.PROW.H ",
                " .   .  .  . . . "});

                case 8807:
                    return new GameModel(8807, 764, 17, 12,
                new WordList() { "ZSA", "LIZA", "TONY", "JUDY", "WOODY", "MURPHY", "RYAN", "TAYLOR", "DUNAWAY", "SIDNEY", "TOM", "BURT", "STEVE", "DUSTIN", "FAYE", "FINNEY", "BOW", "NOVAK", "PETER", "TAB", "OMAR", "JOHN", "ROD", "MEL", "ALAN", "CAINE", "DEAN", "AL", "ALDA" },
                new WordList() { "ZSA", "LIZA", "TONY", "JUDY", "WOODY", "MURPHY", "RYAN", "TAYLOR", "DUNAWAY", "SIDNEY", "TOM", "BURT", "STEVE", "DUSTIN", "FAYE", "FINNEY", "BOW", "NOVAK", "PETER", "TAB", "OMAR", "JOHN", "ROD", "MEL", "ALAN", "CAINE", "DEAN", "AL", "ALDA", "KOZLOWSKI", "SYLVESTER", "BEATTY", "ELIZABETH", "AUDREY", "CURTIS", "BUSTER", "SHIRLEY", "REYNOLDS", "CONNERY", "TURNER", "THORNTON", "SHELLEY", "TRAVOLTA", "EASTWOOD", "MARX", "BRONSON", "STREISAND", "ANDREWS", "BAXTER", "MARTIN", "OTOOLE", "BATES", "PAUL", "STALLONE", "DOUGLAS", "STEIGER", "NEWMAN", "ROBERT", "WARREN", "WILLIAMS", "POITIER", "SEAN", "GIBSON", "HARRIS", "OLIVER", "SOPHIA", "HEPBURN", "CLINT", "MOORE", "KEATON", "RAQUEL", "MCQUEEN", "JAMES", "LEMMON", "MARLON", "SIGRID", "JACKSON", "LONG", "HARPO", "JULIE", "LOREN", "ROBIN", "ROGER", "SHARIF", "ALBERT", "SEGAL", "WELCH", "CAPUCINE", "CHARLES", "KIM", "EDWARD", "GARNER", "PACINO", "MINNELLI", "HOGAN", "DEPARDIEU", "ANNE", "KIRK", "BRANDO", "HOFFMAN", "SELLECK", "GABOR", "ONEAL", "GEORGE", "REMICK", "REDFORD", "DIRK", "FONDA", "GERARD", "RICHARD", "JANE", "ALLEN", "LINDA", "BARBRA", "BOGARDE", "MACLAINE", "MICHAEL", "GLENDA", "CLARA", "DIANE", "REED", "JACK", "LEE", "EDDIE" },

                new GridList() {
                "  . .    .     . ",
                ".ALDA.JOHN. .  F ",
                "  I.L  ..OMAR. I ",
                " .ZSA.STEVE.O  N ",
                ".CAINE.O.AL.DEAN.",
                "  .D.. N K.D.. E ",
                ".DUNAWAY..MURPHY.",
                " . E O . J S E . ",
                ".TAYLOR.BURT.TAB.",
                " O . D   D I E O ",
                " M.FAYE.RYAN.R W ",
                " .   .   . . . . "});

                case 8808:
                    return new GameModel(8808, 696, 17, 12,
                new WordList() { "STUTZ", "SUZUKI", "BENZ", "VW", "MAZDA", "VORTEX", "ROCKY", "CAMRY", "SUPRA", "TURBO", "TELSTAR", "ASTRA", "BMW", "RENAULT", "ROLLS", "COLT", "ROMEO", "TARAGO", "AUDI", "MG", "SEDAN", "NOMAD", "SAAB", "GOLF", "ALFA", "LADA" },
                new WordList() { "STUTZ", "SUZUKI", "BENZ", "VW", "MAZDA", "VORTEX", "ROCKY", "CAMRY", "SUPRA", "TURBO", "TELSTAR", "ASTRA", "BMW", "RENAULT", "ROLLS", "COLT", "ROMEO", "TARAGO", "AUDI", "MG", "SEDAN", "NOMAD", "SAAB", "GOLF", "ALFA", "LADA", "PIAZZA", "TOYOTA", "SPORTS", "PLYMOUTH", "ROYCE", "VOLVO", "AUSTIN", "SUBARU", "SKYLINE", "HYUNDAI", "TORQUE", "CHRYSLER", "BENTLEY", "TRIUMPH", "MINX", "NISSAN", "PULSAR", "MITSUBISHI", "ROVER", "AUTOMATIC", "PEUGEOT", "VAUXHALL", "DAIHATSU", "LEYLAND", "PATROL", "NASH", "NIVA", "MASERATI", "SINGER", "FAIRMONT", "CHEVROLET", "CITROEN", "HARDTOP", "PINTARA", "PONTIAC", "PORSCHE", "EXA", "HUMBER", "MANUAL", "CRESSIDA", "FUEGO", "LASER", "INTEGRA", "FIAT", "JAGUAR", "PRELUDE", "COMMODORE", "MAVERICK", "REGATA", "BUICK", "CIVIC", "HATCH", "SECA", "LINCOLN", "PAJERO", "CABRIOLET", "MERCEDES", "KOMBI", "COROLLA", "FORD", "CALAIS", "FERRARI", "HILLMAN", "HONDA", "MAGNA", "JACKAROO", "HOLDEN", "DARRACQ", "BARINA", "CAMIRA", "CORDIA", "FALCON", "DAIMLER", "LAGONDA", "ACCORD", "FAIRLANE", "LANCIA", "LEGEND", "DODGE", "GHIA", "CHARADE", "CADILLAC", "CELICA" },

                new GridList() {
                "       .   .   . ",
                "  .    R ..ROLLS.",
                "  B  .COLT.E . E ",
                " .MG.R C E.NOMAD.",
                ".VW. O K L A.A A ",
                " O.CAMRY.STUTZ.N ",
                " R  .E . T.LADA. ",
                ".TURBO.A.ASTRA.A ",
                " E  E.SUPRA.A. L ",
                " X  N  D .A.GOLF.",
                " .SUZUKI. B O  A ",
                "    .  .  . .  . "});

                case 8809:
                    return new GameModel(8809, 676, 17, 12,
                new WordList() { "PIZZA", "NUTS", "PASTRY", "TURKEY", "GRAVY", "SOUP", "GORGONZOLA", "TART", "MINTS", "PARSLEY", "STILTON", "ROLLS", "STEAK", "SAGO", "MEAT", "PORK", "TEA", "EGGS", "SPICE", "DUCK", "LOIN", "VEAL", "MILK", "PEAR", "PIE", "LAMB", "EDAM" },
                new WordList() { "PIZZA", "NUTS", "PASTRY", "TURKEY", "GRAVY", "SOUP", "GORGONZOLA", "TART", "MINTS", "PARSLEY", "STILTON", "ROLLS", "STEAK", "SAGO", "MEAT", "PORK", "TEA", "EGGS", "SPICE", "DUCK", "LOIN", "VEAL", "MILK", "PEAR", "PIE", "LAMB", "EDAM", "OYSTERS", "SCHNITZEL", "CURRY", "MARZIPAN", "ZUCCHINI", "SWEETS", "WALNUT", "GRUYERE", "CROUTONS", "BUTTER", "OXTONGUE", "POTATO", "PRAWNS", "MUSHROOM", "CUTLET", "FRUIT", "JELLY", "SUGAR", "PLUM", "CUSTARD", "DESSERT", "BUN", "ROQUEFORT", "CELERY", "OXTAIL", "FRITTER", "LOBSTER", "GOULASH", "LYCHEE", "SALMON", "CHOPS", "SAUCE", "WINE", "SOUFFLE", "GATEAU", "LUNCH", "PARMESAN", "QUINCE", "VEGETABLES", "MERINGUE", "HERBS", "PROFITEROLE", "ENTREE", "WAFER", "TRIFLE", "AVOCADO", "SEAFOOD", "JUICE", "DINNER", "CHOCOLATE", "COCKTAIL", "SALAD", "PINEAPPLE", "GINGER", "APPLE", "HAM", "JAM", "CHEESE", "WAFFLE", "MARINADE", "BACON", "BREAM", "CREAM", "CREPE", "ICING", "PECAN", "RICE", "GARLIC", "CARAMEL", "PANCAKE", "CHEESECAKE", "CHICKEN", "ECLAIR", "MELBA", "PEACH", "BREAD", "COFFEE", "ICE", "CAKE", "BEEF" },

                new GridList() {
                " .  .   .  .     ",
                ".LOIN.  D.SPICE. ",
                " A  U.SOUP.I . P ",
                ".MINTS. C.MEAT.A ",
                " B .STEAK.I..E S ",
                " . P.I ...L.TART.",
                " . E L.PORK.U..R ",
                " E A T I O.GRAVY.",
                ".GORGONZOLA.K E. ",
                " G . N Z L .EDAM.",
                ".SAGO.PARSLEY.L  ",
                " .     . .  . .  "});

                case 8810:
                    return new GameModel(8810, 716, 17, 12,
                new WordList() { "ORCZY", "ZOLA", "PEPYS", "HAY", "SAYERS", "AYRES", "GLYN", "CHEYNEY", "GREY", "KYNE", "HENRY", "DOYLE", "HARDY", "HEYER", "SHAW", "DUMAS", "WAUGH", "HUGO", "SAND", "MANN", "POPE", "GASKIN", "ROHMER", "POE", "JACOBS", "EDEN" },
                new WordList() { "ORCZY", "ZOLA", "PEPYS", "HAY", "SAYERS", "AYRES", "GLYN", "CHEYNEY", "GREY", "KYNE", "HENRY", "DOYLE", "HARDY", "HEYER", "SHAW", "DUMAS", "WAUGH", "HUGO", "SAND", "MANN", "POPE", "GASKIN", "ROHMER", "POE", "JACOBS", "EDEN", "TOLSTOY", "BALZAC", "HUXLEY", "QUEUX", "SCOTT", "SWIFT", "FITZGERALD", "PRIESTLEY", "STEVENSON", "MONTGOMERY", "AUSTEN", "TURNER", "JOYCE", "TWAIN", "BURROUGHS", "LOOS", "HEMINGWAY", "MARX", "WREN", "CHESTERTON", "ALCOTT", "HAMMETT", "THOREAU", "CERVANTES", "BALLANTYNE", "BENNETT", "SIMENON", "PLATO", "WOOLF", "BOSWELL", "EMERSON", "BRONTE", "HILTON", "SAPPER", "STACPOOLE", "AESOP", "VERNE", "HOLMES", "CHRISTIE", "ELIOT", "DARWIN", "COLLINS", "QUENNELL", "GRIMM", "HARTE", "COWARD", "LONDON", "MAUGHAM", "STEINBECK", "BUCK", "DREISER", "FAULKNER", "BIGGERS", "BUCHAN", "VIDAL", "WILDE", "HOPE", "MELVILLE", "MITCHELL", "DICKENS", "ARNOLD", "FARNOL", "JEROME", "CHURCHILL", "DISRAELI", "MILNE", "CARROLL", "KIPLING", "CARR", "CONRAD", "GARDNER", "ARLEN", "MICHENER", "MAILER", "WALLACE", "BACON", "ARCHER", "BARRIE", "GODDEN", "GRAHAME", "LAMB", "CHANDLER", "HAGGARD", "CLARKE", "CAINE", "BOCCACCIO", "DEFOE", "DELL" },

                new GridList() {
                " . .        .  . ",
                ".GASKIN.DUMAS. H ",
                " L H . R  . A .A ",
                " Y A H O.CHEYNEY.",
                " N.WAUGH. E E D. ",
                " .H..G.MANN.R.E. ",
                "  E.POPE..R.SAND.",
                ".KYNE.ORCZY..Y.O ",
                "  E P E. O.HARDY.",
                ".GREY..  L   E L ",
                "  . S  .JACOBS.E ",
                "    .    .   . . "});

                case 8811:
                    return new GameModel(8811, 630, 17, 12,
                new WordList() { "SOY", "MAIZE", "YAM", "ZUCCHINI", "CITRUS", "PARSLEY", "POTATO", "CHERRY", "PAPAYA", "PLUM", "COS", "TARO", "CELERY", "MARROW", "GUAVA", "LYCHEE", "SAGO", "RAISIN", "MANGO", "DATE", "ORANGE", "PEAR", "PECAN", "PEA", "FIG" },
                new WordList() { "SOY", "MAIZE", "YAM", "ZUCCHINI", "CITRUS", "PARSLEY", "POTATO", "CHERRY", "PAPAYA", "PLUM", "COS", "TARO", "CELERY", "MARROW", "GUAVA", "LYCHEE", "SAGO", "RAISIN", "MANGO", "DATE", "ORANGE", "PEAR", "PECAN", "PEA", "FIG", "SPROUT", "BUTTERNUT", "STRAWBERRY", "BOYSENBERRY", "SALSIFY", "SQUASH", "WALNUT", "MUSCAT", "TURNIP", "KUMQUAT", "MULBERRY", "TOMATO", "RASPBERRY", "LOQUAT", "GOOSEBERRY", "PASSIONFRUIT", "CRESS", "PAWPAW", "PEANUT", "COCONUT", "CURRANT", "BLUEBERRY", "PRUNE", "LETTUCE", "ASPARAGUS", "PUMPKIN", "CRANBERRY", "LOGANBERRY", "PERSIMMON", "BEETROOT", "PARSNIP", "SHALLOT", "SWEDE", "MANGOSTEEN", "CARROT", "CAPSICUM", "ONION", "CASHEW", "CUCUMBER", "QUANDONG", "APRICOT", "WAXBEAN", "OLIVE", "CANTALOUPE", "DURIAN", "PIPPIN", "QUINCE", "BLACKBERRY", "CORN", "PLANTAIN", "JACKFRUIT", "LENTIL", "POMELO", "SPINACH", "TANGELO", "FOXGRAPE", "POMEGRANATE", "BLACKCURRANT", "LEMON", "RADISH", "RHUBARB", "EGGPLANT", "SCALLION", "ROCKMELON", "AVOCADO", "ENDIVE", "CHIVE", "ARTICHOKE", "BEET", "ALMOND", "MANDARIN", "CHOKO", "PINEAPPLE", "GHERKIN", "APPLE", "GRAPE", "BROCCOLI", "LIME", "BANANA", "GARLIC", "GREENGAGE", "CHILLI", "PEACH", "BEAN", "JACKBEAN", "GAGE", "KALE", "LEEK", "CABBAGE" },

                new GridList() {
                "   .    . . . .  ",
                ".PECAN. F.PAPAYA.",
                "   I .MAIZE.E A  ",
                ".DATE.A.GUAVA.M. ",
                " . R. N .C..R..P ",
                ".PLUM.G  C O.L A ",
                " O.SAGO.CHERRY.R ",
                " T .R .. I A.COS.",
                " A .RAISIN.N H L ",
                ".TARO. O I G E E ",
                " O  W  Y .CELERY.",
                " .  .  .   . . . "});

                case 8812:
                    return new GameModel(8812, 720, 17, 12,
                new WordList() { "AZALEA", "ALOW", "ANNUAL", "VIOLET", "TAP", "TRIM", "PEST", "PANSY", "TUBER", "LILY", "HOSE", "CAN", "SOW", "RAKE", "NATIVES", "VINE", "STOCK", "LOTUS", "BED", "WATTLE", "ROSE", "ZINNIA", "LAWN", "LEAF", "PLANT", "MAY", "POT", "SPADE", "POPPY" },
                new WordList() { "AZALEA", "ALOW", "ANNUAL", "VIOLET", "TAP", "TRIM", "PEST", "PANSY", "TUBER", "LILY", "HOSE", "CAN", "SOW", "RAKE", "NATIVES", "VINE", "STOCK", "LOTUS", "BED", "WATTLE", "ROSE", "ZINNIA", "LAWN", "LEAF", "PLANT", "MAY", "POT", "SPADE", "POPPY", "ALYSSUM", "GAZANIA", "PEONY", "DAISY", "STEM", "SHRUBS", "BLOSSUM", "BOUQUET", "DISPLAY", "TULIP", "SNOWDROP", "GRASS", "CACTUS", "HYACINTH", "ASTER", "SWEEP", "TREES", "WATER", "CROCUS", "MOWER", "STALK", "LARKSPUR", "IRIS", "SOIL", "FLOWERS", "HIBISCUS", "MIMOSA", "ROCKS", "PATH", "CYCLAMEN", "JONQUIL", "SALVIA", "NITROGEN", "HYDRANGEA", "POOL", "JASMIN", "BROOM", "MULCH", "VIOLA", "SPRINKLE", "BUD", "BONSAI", "LILIUM", "CORN", "IXIA", "PLUMBAGO", "CARNATION", "EARTH", "DISEASE", "SAXIFRAGE", "BULB", "PINK", "BLOOM", "PRIME", "VERBENA", "BALSAM", "FORK", "PALM", "SEED", "WEED", "ANEMONE", "PREPARE", "EDGES", "FREESIA", "ORGANIC", "LANDSCAPE", "PERENNIAL", "FERN", "MARIGOLD", "DRAIN", "GREEN", "HOE", "ORCHID", "CALENDULA", "CANNA", "GARDEN", "BEGONIA", "CLIMBER", "GARDENIA", "CLARKIA", "LOBELIA", "CAMELLIA", "DIG", "DAFFODIL", "LILAC", "DAKLIA", "ACACIA" },

                new GridList() {
                "        . .      ",
                "      .AZALEA. . ",
                "  .ALOW.I E  P P ",
                "  V ..ANNUAL.O O ",
                ".VIOLET.N F .TAP.",
                "  N.O.TRIM..M..P ",
                ".PEST.L.A..PANSY.",
                "  .TUBER.LILY.P. ",
                " .HOSE.O A A.CAN.",
                "   C.D.SOW.N  D  ",
                ".RAKE. E.NATIVES.",
                "   .   . . .  .  "});

                case 8902:
                    return new GameModel(8902, 746, 17, 12,
                new WordList() { "WALTZ", "TRYST", "POSY", "JOY", "TRUST", "RENDEZVOUS", "HYMN", "POST", "GUESTS", "TOAST", "WOO", "KISS", "ROSES", "WORDS", "TAXI", "MIX", "WIN", "USHER", "TRIP", "PEW", "FLOWERS", "WINE", "GROOM", "GIFT", "DATE", "OLD", "ADORE" },
                new WordList() { "WALTZ", "TRYST", "POSY", "JOY", "TRUST", "RENDEZVOUS", "HYMN", "POST", "GUESTS", "TOAST", "WOO", "KISS", "ROSES", "WORDS", "TAXI", "MIX", "WIN", "USHER", "TRIP", "PEW", "FLOWERS", "WINE", "GROOM", "GIFT", "DATE", "OLD", "ADORE", "PYRAMUS", "STARS", "ELIZABETH", "HAPPY", "THOUGHTS", "COURT", "SURPRISE", "WISHES", "HONEYMOON", "STROLL", "MUSIC", "TOUCH", "SWEETHEARTS", "GOWN", "SONG", "LOVERS", "PICTURES", "SENTIMENT", "SECRETS", "TREASURE", "NEW", "INVITATION", "PRESENT", "SMILES", "FIDELITY", "MINISTER", "CONGRATULATIONS", "MOON", "LETTER", "HOLIDAY", "BARRETT", "PROMISE", "CARESS", "JULIET", "HOPES", "PLANS", "LOVE", "TOGETHER", "ROBERT", "THISBE", "BROWNING", "CONFETTI", "HUSBAND", "MOONLIGHT", "VALENTINE", "HOTEL", "ROMEO", "BORROWED", "COUPLE", "POEM", "WALK", "VEIL", "ALTAR", "HEART", "VIDEO", "DREAMS", "MEETING", "BLUE", "RING", "WIFE", "CHURCH", "CORSAGE", "BREAKFAST", "TELEPHONE", "BRIDESMAIDS", "CONFIDANT", "AISLE", "ENGAGEMENT", "HOME", "PAIR", "ROMANCE", "WEDDING", "DINNER", "MARRIAGE", "HOLD", "CHAMPAGNE", "ICING", "FONDLE", "DINE", "LANE", "KNIFE", "CAMERA", "BRIDE", "CARD", "DANCE", "CALL", "CAKE" },

                new GridList() {
                "   . .   . . .   ",
                "   H.TOAST.P P . ",
                ".JOY.A   R O.OLD.",
                " ..MIX..GUESTS.A ",
                ".WIN.I K S.TRYST.",
                " I . .GIFT..I..E ",
                " N G U S .W.PEW. ",
                " E.ROSES. A . O  ",
                " . O H ..FLOWERS.",
                ".ADORE.   T O D  ",
                "   M.RENDEZVOUS. ",
                "   . .    . . .  "});

                case 8903:
                    return new GameModel(8903, 652, 17, 12,
                new WordList() { "ZAIRE", "CYPRUS", "ZAMBIA", "URUGUAY", "TANZANIA", "BELIZE", "TURKEY", "SYRIA", "ITALY", "GUYANA", "HUNGARY", "YEMEN", "KENYA", "GERMANY", "TOGO", "SUDAN", "PERU", "BURMA", "CUBA", "NIGER" },
                new WordList() { "ZAIRE", "CYPRUS", "ZAMBIA", "URUGUAY", "TANZANIA", "BELIZE", "TURKEY", "SYRIA", "ITALY", "GUYANA", "HUNGARY", "YEMEN", "KENYA", "GERMANY", "TOGO", "SUDAN", "PERU", "BURMA", "CUBA", "NIGER", "BRAZIL", "SWAZILAND", "SWITZERLAND", "VENEZUELA", "ZIMBABWE", "EGYPT", "NORWAY", "MOZAMBIQUE", "TUVALU", "VANUATU", "YUGOSLAVIA", "RUSSIA", "NAURU", "MAURITIUS", "CZECHOSLOVAKIA", "KUWAIT", "PARAGUAY", "AUSTRIA", "LIBYA", "BOTSWANA", "MALAYSIA", "LUXEMBOURG", "SEYCHELLES", "PORTUGAL", "BHUTAN", "TAIWAN", "BURUNDI", "VIETNAM", "HONDURAS", "SURINAME", "AUSTRALIA", "SWEDEN", "SPAIN", "TONGA", "LAOS", "PAKISTAN", "ANTIGUA", "QATAR", "SAMOA", "DJIBOUTI", "MAURITANIA", "LIECHTENSTEIN", "MALDIVES", "BRUNEI", "MEXICO", "TOBAGO", "SINGAPORE", "NETHERLANDS", "OMAN", "MALTA", "PHILIPPINES", "RWANDA", "BRITAIN", "MOROCCO", "SOMALIA", "GUATEMALA", "AFGHANISTAN", "CONGO", "HAITI", "GUINEA", "ISRAEL", "MALAWI", "MONACO", "ETHIOPIA", "ARGENTINA", "INDONESIA", "CAMEROON", "MONGOLIA", "TRINIDAD", "BELGIUM", "BOLIVIA", "ECUADOR", "ROMANIA", "UGANDA", "IRAN", "IRAQ", "KIRIBATI", "ANDORRA", "SENEGAL", "JORDAN", "POLAND", "NICARAGUA", "BARBADOS", "BULGARIA", "THAILAND", "BAHAMAS", "PANAMA", "DENMARK", "LEBANON", "BENIN", "GABON", "JAPAN", "KOREA", "NEPAL", "MADAGASCAR", "COLOMBIA", "DOMINICA", "ANGOLA", "BANGLADESH", "NIGERIA", "MALI", "BAHRAIN", "FINLAND", "IRELAND", "CHINA", "GHANA", "INDIA", "FRANCE", "GRENADA", "ALGERIA", "LIBERIA", "GAMBIA", "FIJI", "ALBANIA", "ICELAND", "JAMAICA", "GREECE", "CHILE", "CANADA", "CHAD" },

                new GridList()  {
                "   .  .  . . . . ",
                " .ITALY. G H C S ",
                " . O  E .URUGUAY.",
                " B.GERMANY.N B R ",
                " E O. E. A G A I ",
                " L .TANZANIA...A ",
                " I  U .A A R. B. ",
                ".ZAIRE.M .CYPRUS.",
                " E  K  B   .E R  ",
                " .  E.NIGER.R M  ",
                ".KENYA.A  .SUDAN.",
                "    .  .    . .  "});

                case 8904:
                    return new GameModel(8904, 768, 17, 12,
                new WordList() { "ZIGZAG", "ZIPPER", "CITY", "KEYS", "SUN", "PARTY", "FLY", "WEST", "ITALY", "MONEY", "USA", "PORTS", "JOURNEY", "SWIM", "ROUTE", "RELAY", "EAST", "SKI", "STAGE", "ORIENT", "TAHITI", "TREK", "JET", "WALLET", "SAND", "SEA", "CARDS", "AIR" },
                new WordList() { "ZIGZAG", "ZIPPER", "CITY", "KEYS", "SUN", "PARTY", "FLY", "WEST", "ITALY", "MONEY", "USA", "PORTS", "JOURNEY", "SWIM", "ROUTE", "RELAY", "EAST", "SKI", "STAGE", "ORIENT", "TAHITI", "TREK", "JET", "WALLET", "SAND", "SEA", "CARDS", "AIR", "COUNTRY", "SOUTH", "TOURIST", "VOYAGE", "PASSPORT", "QUEUES", "SIGHTS", "EXPRESS", "RESORT", "MOUNTAINS", "VISA", "ITINERARY", "JAUNT", "TOURING", "JETSETTER", "TRIP", "NORTH", "ADVENTURES", "OVERSEAS", "ESCORT", "QANTAS", "STREAMERS", "ROVE", "COSMETICS", "WALES", "CRUISE", "TRAVEL", "HOLIDAY", "REUNION", "TRIPPER", "JUMBO", "TRAIN", "CLOTHES", "LEISURE", "EUROPE", "TICKET", "INSURANCE", "PASSENGER", "SCOTLAND", "OUTBACK", "PASSAGE", "SUNBAKE", "HOTEL", "BOOKINGS", "MEXICO", "SAIL", "DRIVE", "WANDER", "OVERLAND", "ASIA", "DIVE", "JAVA", "ISLAND", "ACCOMMODATION", "CREDIT", "FLIGHT", "GUIDE", "CASE", "HAWAII", "JETLAG", "LINER", "LUGGAGE", "FAREWELL", "JAPAN", "NEPAL", "RANGE", "MEANDER", "FILM", "RAIL", "OCEAN", "ENGLAND", "IRELAND", "DINE", "CHINA", "INDIA", "CAMERA", "FRANCE", "AMERICA", "CABIN", "COACH", "FARE", "FIJI", "AFRICA", "DANCE", "BALI", "CANADA", "BAGGAGE", "BAG", "DECK", "BEACH" },

                new GridList() {
                " . . . .   .   . ",
                " P.JET.ZIGZAG. R ",
                " O O R I . I . E ",
                ".ROUTE.P.CARDS.L ",
                " T R K.P.I ..USA.",
                ".SAND.WEST.MONEY.",
                " ..E.PARTY. R.A. ",
                ".KEYS.L.A.SWIM.. ",
                "  A.  L G K E  F ",
                "  S   E E I N  L ",
                " .TAHITI. .ITALY.",
                "  .   .     .  . "});

                case 8905:
                    return new GameModel(8905, 764, 17, 12,
                new WordList() { "FIZZ", "OUZO", "BOOZE", "SHIRAZ", "RYE", "PORPHYRY", "WHISKY", "TOKAY", "TODDY", "RUM", "PORT", "SPLIT", "ASTI", "SPIRIT", "CRUSH", "WATER", "ROSE", "SCOTCH", "WINE", "NIP", "GROG", "SACK", "MILK", "BAR", "COKE", "COLA", "RED", "MEAD", "ICE" },
                new WordList() { "FIZZ", "OUZO", "BOOZE", "SHIRAZ", "RYE", "PORPHYRY", "WHISKY", "TOKAY", "TODDY", "RUM", "PORT", "SPLIT", "ASTI", "SPIRIT", "CRUSH", "WATER", "ROSE", "SCOTCH", "WINE", "NIP", "GROG", "SACK", "MILK", "BAR", "COKE", "COLA", "RED", "MEAD", "ICE", "SLIVOVITZ", "STOUT", "VOUVRAY", "SHERRY", "VICHY", "BURGUNDY", "SHANDY", "SQUASH", "MUSCAT", "VERMOUTH", "BUBBLY", "MIX", "BRANDY", "SAUTERNE", "GLASS", "WHITE", "LIQUEUR", "STINGER", "BOTTLE", "LIQUOR", "SCHNAPPS", "PUNCH", "TONIC", "BOURBON", "TEQUILA", "COINTREAU", "MANHATTAN", "MARTINI", "SODA", "BORDEAUX", "TRAMINER", "JULEP", "ABSINTHE", "SAKI", "PILSENER", "SPARKLING", "VODKA", "ELIXIR", "MOSELLE", "ADVOCAAT", "CHAMPERS", "REISLING", "LEMON", "MARSALA", "DAIQUIRI", "NIGHTCAP", "BEAUJOLAIS", "MARGARITA", "APERITIF", "CHIANTI", "CURACAO", "CHASER", "CLARET", "SHAKE", "DRAMBUIE", "GIN", "CHOCOLATE", "COCKTAIL", "EGGNOG", "CHABLIS", "ALCOHOL", "FLIP", "HOCK", "LIME", "LEMONADE", "CHAMPAGNE", "GRENADINE", "COGNAC", "CORDIAL", "ORANGEADE", "LAGER", "MADEIRA", "MALAGA", "CIDER", "BEER", "HIGHBALL", "ALE" },

                new GridList() {
                "   . . .  .    . ",
                ".RUM.WINE.A  . W ",
                " . I A I .SCOTCH.",
                ".SPLIT.PORT. O I ",
                " P K E . .I .K.S ",
                " I .GROG.B..SACK.",
                " R.R . .PORPHYRY.",
                ".ICE.R C O  I.U. ",
                ".TODDY.OUZO.ROSE.",
                " .K. E L E  A H  ",
                ".MEAD.BAR.FIZZ.  ",
                "  .    .    .    "});

                case 8906:
                    return new GameModel(8906, 760, 17, 12,
                new WordList() { "SYZYGY", "OZONE", "SKY", "ZENITH", "ZODIAC", "SUN", "DAY", "SATURN", "URANUS", "YEAR", "STAR", "URSA", "COSMOS", "TITAN", "EROS", "MOON", "TIME", "METEOR", "COMET", "ARIES", "CLOUD", "LIGHT", "PHASE", "CRATER", "EPOCH", "ARC" },
                new WordList() { "SYZYGY", "OZONE", "SKY", "ZENITH", "ZODIAC", "SUN", "DAY", "SATURN", "URANUS", "YEAR", "STAR", "URSA", "COSMOS", "TITAN", "EROS", "MOON", "TIME", "METEOR", "COMET", "ARIES", "CLOUD", "LIGHT", "PHASE", "CRATER", "EPOCH", "ARC", "AZIMUTH", "HORIZON", "SUNSPOT", "TAURUS", "ASTRONOMY", "GRAVITY", "VENUS", "MERCURY", "SIRIUS", "MILKY", "PLUTO", "GALAXY", "TRANSIT", "SEASONS", "NEWTON", "SAGITTARIUS", "ENERGY", "SUPERNOVA", "HYPERION", "JANUS", "CLUSTER", "PEGASUS", "PULSAR", "UNIVERSE", "EQUINOX", "QUASAR", "CANOPUS", "EQUATOR", "NEPTUNE", "ATOM", "MARS", "NOVA", "JUPITER", "TIDES", "HALLEY", "COLOUR", "PHOBOS", "ORBIT", "CONSTELLATION", "WIND", "GANYMEDE", "ATMOSPHERE", "AURORA", "EUROPA", "HESTIA", "PLOUGH", "METEORITE", "SATELLITE", "ASTEROID", "ORION", "CALLISTO", "GIANT", "IONOSPHERE", "DEIMOS", "DONATI", "HERMES", "ISOBAR", "PLANET", "EARTH", "BLUE", "DWARF", "SPACE", "CORONA", "OBERON", "PALLAS", "DEMETER", "DOPPLER", "FLARES", "NEBULA", "POLE", "ECLIPSE", "CHARON", "GEMINI", "MIRANDA", "NADIR", "LEO", "KEPLER", "ANDROMEDA", "HALO", "HOLE", "LIBRA", "GALILEO", "CIRCLE", "CRAB", "BLACK" },

                new GridList() {
                " .      .  . . . ",
                " C   .TIME.M C P ",
                ".LIGHT..O .EPOCH.",
                " O . I.COMET.S A ",
                " U.SATURN. E.M S ",
                ".DAY.A A. .OZONE.",
                " ..ZENITH.EROS.. ",
                ".SKY...E  ..D. U ",
                " T G .ARIES.I  R ",
                " A.YEAR. .URANUS.",
                " R .  C   N C  A ",
                " .    .   . .  . "});

                case 8907:
                    return new GameModel(8907, 818, 17, 12,
                new WordList() { "PUZZLE", "QUARTZ", "TOYS", "ZIPPER", "NUTS", "CUT", "SAW", "SEW", "WAX", "PLYWOOD", "TOOLS", "BRUSH", "SPIN", "WOOL", "ART", "BOW", "NET", "SCRAPS", "CLOWN", "PAINT", "RULE", "AWL", "HAT", "WHEELS", "DRAW", "LATH", "ROPE", "SHAPE", "ROD", "JEWEL", "EASEL" },
                new WordList() { "PUZZLE", "QUARTZ", "TOYS", "ZIPPER", "NUTS", "CUT", "SAW", "SEW", "WAX", "PLYWOOD", "TOOLS", "BRUSH", "SPIN", "WOOL", "ART", "BOW", "NET", "SCRAPS", "CLOWN", "PAINT", "RULE", "AWL", "HAT", "WHEELS", "DRAW", "LATH", "ROPE", "SHAPE", "ROD", "JEWEL", "EASEL", "CUBBY", "SCISSORS", "CRAYON", "STITCH", "BOLTS", "HOUSE", "TWINE", "WASHERS", "PINS", "TUBE", "FURNITURE", "PASTE", "PHOTO", "SCREW", "WOODWORK", "BOX", "EMBOSS", "SQUARE", "PATTERN", "WOOD", "CUSHION", "VARNISH", "BILLYCART", "TREEHOUSE", "KNIT", "CYLINDER", "MEASURE", "COLOUR", "SHELLS", "SCREWDRIVER", "WEAVE", "EMBROIDERY", "WIRE", "CLOTHES", "SPANNER", "MARIONETTE", "POLISH", "LOOM", "BASKET", "PLIERS", "MATERIALS", "CLOTH", "SOLDER", "ELASTIC", "GLUE", "KITE", "DOWEL", "GAMES", "METAL", "RUBBER", "VENEER", "AXLE", "BELT", "DESK", "FELT", "VICE", "DESIGN", "ADHESIVE", "THREAD", "SHELF", "PINE", "PLAN", "PATIENCE", "LEATHER", "CHISEL", "HAMMER", "RIBBON", "DECORATE", "BALSA", "TABLE", "GINGHAM", "MODEL", "PLANE", "PENCIL", "MACRAME", "DOLL", "NAIL", "BOARD", "DRILL", "FRAME", "HINGE", "ENAMEL", "KNIFE", "CAMERA", "CARDBOARD", "CALICO", "HANDLE", "BENCH", "BEAR", "FABRIC", "NEEDLE", "CHALK", "FILE", "CAGE", "BLADE" },
                new GridList() {
                " . .   . .   .   ",
                " L.PAINT.A . C   ",
                " A L.  O.WHEELS. ",
                ".TOYS.WOOL.A O C ",
                " H.WAX.L ..SEW.U ",
                " .BOW..SHAPE.NET.",
                " B O. N..RULE. . ",
                ".ROD.QUARTZ. S D ",
                " U .H T O.ZIPPER.",
                ".SCRAPS.P L  I A ",
                " H  T .JEWEL.N W ",
                " .  .   . .  . . "});

                case 8908:
                    return new GameModel(8908, 634, 17, 12,
                new WordList() { "MORITZ", "FREEZE", "SNOW", "FLURRY", "ITALY", "WET", "PASS", "OLYMPICS", "FROST", "SKIS", "RESORT", "QUIET", "GERMANY", "DAVOS", "COW", "WHITE", "GLOVES", "ALPS", "POWDER", "LIFT", "LUGE", "SLED", "COLD", "GEAR", "ICE" },
                new WordList() { "MORITZ", "FREEZE", "SNOW", "FLURRY", "ITALY", "WET", "PASS", "OLYMPICS", "FROST", "SKIS", "RESORT", "QUIET", "GERMANY", "DAVOS", "COW", "WHITE", "GLOVES", "ALPS", "POWDER", "LIFT", "LUGE", "SLED", "COLD", "GEAR", "ICE", "BLIZZARD", "TYROL", "SWITZERLAND", "NORWAY", "NIPPY", "CRYSTALS", "SLUSH", "TOWNSEND", "KLOSTERS", "SAINT", "AUSTRIA", "JUMP", "SLOPES", "SNOWDRIFT", "QUEUE", "MOUNTAIN", "HOCKEY", "SEASON", "KOSCIUSKO", "SKITUBE", "NUMB", "WARM", "SHIVER", "SAPPORO", "SNOWLINE", "EQUIPMENT", "CHARLOTTES", "PERMAFROST", "AUSTRALIA", "CALGARY", "SKATING", "CRESTA", "SWEDEN", "SNOWBALL", "SNOWFALL", "LEISURE", "SCOTLAND", "SKILIFT", "SLALOM", "TROIKA", "CHRISTIE", "SNOWFIELD", "SNOWFLAKE", "SMIGGIN", "HOLES", "TRAIL", "JASPER", "SKIING", "CURLING", "CHAMONIX", "PERISHER", "TOBOGGAN", "CHRISTIANIA", "DOWNHILL", "AXEL", "BLUE", "RINK", "SPEED", "THREDBO", "SCANDINAVIA", "HELSINKI", "TELEMARK", "HOAR", "RIME", "GLACIARIUM", "BOBSLED", "BUFFALO", "SLEDGE", "CARDRONA", "GRENOBLE", "AVALANCHE", "FINLAND", "CHILL", "CANADA" },

                new GridList() {
                "    . .    .  .  ",
                ".COLD.POWDER.ICE.",
                " .  A A .  E .O  ",
                ".GLOVES.L..SNOW. ",
                " E  O.SKIS.O L.F ",
                ".ALPS...FLURRY.R ",
                " R. .WHITE.T M E ",
                " .L  E T.D . P E ",
                ".QUIET.A .MORITZ.",
                "  G  . L     C E ",
                ".GERMANY..FROST. ",
                "  .    .     .   "});

                case 8909:
                    return new GameModel(8909, 616, 17, 12,
                new WordList() { "ZINNIA", "TANSY", "MAY", "ALYSSUM", "PANSY", "POPPY", "AZALEA", "LOTUS", "PEONY", "LILY", "TULIP", "STOCK", "CACTUS", "ASTER", "ROSE", "IRIS", "LUPIN", "OXLIP", "MIMOSA", "SAGE", "BALSAM", "NERINE", "ALOE" },
                new WordList() { "ZINNIA", "TANSY", "MAY", "ALYSSUM", "PANSY", "POPPY", "AZALEA", "LOTUS", "PEONY", "LILY", "TULIP", "STOCK", "CACTUS", "ASTER", "ROSE", "IRIS", "LUPIN", "OXLIP", "MIMOSA", "SAGE", "BALSAM", "NERINE", "ALOE", "GAZANIA", "MYRTLE", "WAX", "DAISY", "NASTURTIUM", "CANDYTUFT", "CONVOLVULUS", "SUNDEW", "NARCISSUS", "BOUQUET", "RANUNCULUS", "BUTTERCUP", "WATTLE", "SNOWDROP", "HYACINTH", "HONEYSUCKLE", "AMARYLLIS", "SUNFLOWER", "CROCUS", "DIANTHUS", "WISTARIA", "POINSETTIA", "VIOLET", "STATICE", "LARKSPUR", "AMARANTHUS", "PHLOX", "COLEUS", "PETUNIA", "HIBISCUS", "LABURNUM", "COREOPSIS", "AGAPANTHUS", "HOLLYHOCK", "PRIMROSE", "MIGNONETTE", "IMPATIENS", "CYCLAMEN", "FOXGLOVE", "JONQUIL", "SALVIA", "PRIMULA", "EDELWEISS", "HYDRANGEA", "CASSIA", "MARGUERITE", "BROOM", "VIOLA", "CLEMATIS", "DIOSMA", "GLADIOLUS", "CORNFLOWER", "SNAPDRAGON", "FUCHSIA", "PELARGONIUM", "IXIA", "GERANIUM", "PLUMBAGO", "CARNATION", "GENTIAN", "JASMINE", "GLOXINIA", "VERONICA", "PINK", "NEMESIA", "COLUMBINE", "DELPHINIUM", "CAMPANULA", "PIMPERNEL", "VERBENA", "LAVENDER", "ANEMONE", "GODETIA", "HEATHER", "FREESIA", "BIGNONIA", "MAGNOLIA", "MARIGOLD", "ORCHID", "CALENDULA", "LINARIA", "BLUEBELL", "OLEANDER", "CINERARIA", "DANDELION", "CANNA", "BEGONIA", "GERBERA", "GARDENIA", "CLARKIA", "LOBELIA", "ERICA", "DILL", "CAMELLIA", "DAFFODIL", "LILAC", "DAHLIA", "ACACIA" },

                new GridList() {
                "     . . .   . . ",
                "   .AZALEA.TULIP.",
                "   P I I L . U E ",
                " . O N L.OXLIP.O ",
                " M.PANSY.E O.I N ",
                " I P I .B..TANSY.",
                ".MAY.A.CACTUS. . ",
                " O . .I L .STOCK.",
                ".SAGE.ROSE..E    ",
                " A    I A.NERINE.",
                " .ALYSSUM.  .    ",
                "      . .        "});

                case 8910:
                    return new GameModel(8910, 576, 17, 12,
                new WordList() { "TYPIST", "NAVVY", "SURVEYOR", "VET", "AYAH", "NURSE", "UNIONIST", "SCULPTOR", "USHER", "WRITER", "PORTER", "PILOT", "VALET", "CREW", "MONK", "TILER", "AGENT", "VICAR", "BREWER", "CRITIC", "SHEARER", "MAID" },
                new WordList() { "TYPIST", "NAVVY", "SURVEYOR", "VET", "AYAH", "NURSE", "UNIONIST", "SCULPTOR", "USHER", "WRITER", "PORTER", "PILOT", "VALET", "CREW", "MONK", "TILER", "AGENT", "VICAR", "BREWER", "CRITIC", "SHEARER", "MAID", "ENVOY", "GRAZIER", "GLAZIER", "ATTORNEY", "COWBOY", "EQUERRY", "ARTIST", "QUARRYMAN", "WAITRESS", "SECRETARY", "SERVANT", "POSTMAN", "SCIENTIST", "DENTIST", "AUTHOR", "PRIEST", "BOTANIST", "OSTEOPATH", "STATIONER", "ACTRESS", "STEWARD", "SURGEON", "INVENTOR", "JOCKEY", "MATRON", "PIANIST", "DAIRYMAN", "BUTLER", "FITTER", "WAITER", "ARTISAN", "AUDITOR", "INSPECTOR", "ACCOUNTANT", "SOLICITOR", "PRINTER", "UMPIRE", "WORKER", "APIARIST", "MUSICIAN", "REPORTER", "DOCTOR", "DROVER", "BARRISTER", "FRUITERER", "LOCKSMITH", "SALESMAN", "ACTOR", "BOXER", "BUTCHER", "BISHOP", "SAILOR", "SINGER", "TAILOR", "ANNOUNCER", "COURIER", "FURRIER", "PAINTER", "PLUMBER", "TRAINER", "AUCTIONEER", "BRICKLAYER", "DRIVER", "EDITOR", "OPTICIAN", "GUARD", "CARTER", "WARDEN", "SOLDIER", "EXAMINER", "ARCHITECT", "CARPENTER", "MINER", "HAWKER", "TELLER", "FISHERMAN", "PUBLICAN", "RETAILER", "ACROBAT", "CATERER", "WELDER", "GUIDE", "BUILDER", "MILKMAN", "AIRMAN", "BROKER", "RANGER", "JEWELLER", "MILLINER", "SADDLER", "TEACHER", "BARMAN", "DRAPER", "FARMER", "RIGGER", "FARRIER", "FIREMAN", "MANAGER", "ENGINEER", "LIBRARIAN", "COMEDIAN", "GARDENER", "FINANCIER", "BANKER", "MAGICIAN", "HAND", "HERD", "PAGE", "CLERK", "BARBER", "DANCER", "BARMAID", "CLEANER", "MECHANIC", "BAKER", "COACH", "RABBI", "CHEF" },

                new GridList() {
                "      . . .      ",
                " .    T W.MAID.  ",
                ".SURVEYOR.O . A  ",
                " C   .P.I.NAVVY. ",
                ".UNIONIST.K A A  ",
                " L ..USHER..L.H  ",
                " P.PORTER..VET.  ",
                " T I S.A.CRITIC. ",
                " O L E R R C.L   ",
                " R O . E E.AGENT.",
                " . T .BREWER.R   ",
                "   .   . . . .   "});

                case 8911:
                    return new GameModel(8911, 692, 17, 12,
                new WordList() { "ZULU", "PRIZE", "TUESDAY", "POST", "MONEY", "START", "WINS", "RUN", "TURF", "WOTAN", "HATS", "FILLY", "BETS", "SILKS", "COURSE", "CUP", "OWNER", "COLT", "TIME", "KIWI", "TRAINER", "TAB", "MALUA", "TRACK", "GATE", "MARE", "PLACE", "RACE", "FIELD" },
                new WordList() { "ZULU", "PRIZE", "TUESDAY", "POST", "MONEY", "START", "WINS", "RUN", "TURF", "WOTAN", "HATS", "FILLY", "BETS", "SILKS", "COURSE", "CUP", "OWNER", "COLT", "TIME", "KIWI", "TRAINER", "TAB", "MALUA", "TRACK", "GATE", "MARE", "PLACE", "RACE", "FIELD", "FOXZAMI", "STAYER", "TAXIS", "BAYSTONE", "SIRIUS", "PUNTERS", "RUSSIA", "HYPERNO", "STEWARDS", "JOCKEYS", "GAULUS", "STATESMAN", "RIVETTE", "SKIPTON", "HORSES", "OUTSIDER", "COLOURS", "COLONUS", "QUEUE", "SWEEP", "SPRINTER", "STRAIGHT", "NUMBERS", "TRIVALVE", "ARWON", "RUNNER", "DALRAY", "PATRON", "TOPOROA", "FAVOURITE", "WHIP", "LIQUOR", "HOLIDAY", "PIASTRE", "SASANOF", "WINNER", "FASHIONS", "BETTING", "TICKET", "CROWD", "BRAVO", "POITREL", "CERT", "ODDS", "STABLE", "POSEIDON", "RAILS", "TRIAL", "GRANDSTAND", "NOVEMBER", "MALVOLIO", "SPEARFELT", "CLASSIC", "MARABOU", "DISTANCE", "MELBOURNE", "FLEMINGTON", "FINISH", "LENGTH", "MEETING", "PROGRAMME", "CATALOGUE", "KENSEI", "APPRENTICE", "NIGHTMARCH", "CARNIVAL", "DOUBLE", "JUDGE", "BACKWOOD", "WINDBAG", "WODALLA", "MACDOUGAL", "DELTA", "ACRASIA", "BITALLI", "RIMFIRE", "BOOKMAKER", "GALLOP", "BARRIER", "FARRIER", "PRICE", "RAINBIRD", "SADDLE", "CHAMPAGNE", "ARCHER", "BANKER", "HIRAJI", "GELDING", "CARBINE", "HANDICAP", "CHEER", "CARD", "LEADER", "GALILEE" },

                new GridList() {
                "   . .  .  . . . ",
                " . P.TRACK.K.B O ",
                ".MALUA. O.TIME.W ",
                " A A B.RUN.WOTAN.",
                ".RACE.G.R.WINS.E ",
                " E.E.HATS. .E. R ",
                " .P.F.TUESDAY. . ",
                ".TRAINER.I  .CUP.",
                "  I E .FILLY.O O ",
                " .ZULU.. K   L S ",
                "  E D   .START.T ",
                "  . .    .   . . "});

                case 8912:
                    return new GameModel(8912, 678, 17, 12,
                new WordList() { "RAZOR", "TOYS", "JOY", "BLITZEN", "NUTS", "YULE", "SWEETS", "HOLLY", "TOOLS", "TIES", "SOCKS", "VASE", "SANTA", "BOX", "TINSEL", "WATCH", "SEASONING", "WINE", "WALLET", "IRON", "TREE", "VIDEO", "BELT", "BELLS", "CARD" },
                new WordList() { "RAZOR", "TOYS", "JOY", "BLITZEN", "NUTS", "YULE", "SWEETS", "HOLLY", "TOOLS", "TIES", "SOCKS", "VASE", "SANTA", "BOX", "TINSEL", "WATCH", "SEASONING", "WINE", "WALLET", "IRON", "TREE", "VIDEO", "BELT", "BELLS", "CARD", "PARTY", "TURKEY", "NATIVITY", "GUESTS", "CUTLERY", "PETS", "PYJAMAS", "SURPRISE", "TOASTER", "QUILT", "PRESENTS", "SKATES", "FRUIT", "VIXEN", "TRICYCLE", "FAMILY", "STREAMERS", "INVITATION", "EPIPHANY", "CHRISTMAS", "MISTLETOE", "GIFTS", "TRADITIONS", "FESTIVE", "RAISINS", "SLIPPERS", "JEWELLERY", "SING", "AMULET", "LIGHTS", "WREATH", "HOLIDAY", "STOCKING", "RACQUET", "BOOKS", "PUNCH", "TORCH", "SHOPPING", "NEIGHBOURS", "GREETINGS", "SURFBOARD", "BASKET", "SCALES", "DECORATIONS", "ALMONDS", "BICYCLE", "HAMPERS", "FEASTING", "PENDANT", "PERFUME", "GAMES", "PUDDING", "GOODWILL", "RING", "SCARF", "CHURCH", "DONNER", "LOCKET", "FRIENDS", "LIGHTER", "PARCELS", "NICHOLAS", "FOOTBALL", "UMBRELLA", "DASHER", "SLEIGH", "HOME", "NOEL", "CRACKERS", "BROOCH", "DINNER", "RIBBON", "CHOCOLATE", "CELEBRATION", "DRINK", "TABLE", "CANDLES", "FOOD", "CAROL", "HAM", "HANDKERCHIEFS", "REINDEER", "CHAMPAGNE", "CHILDREN", "CHINA", "CLOCK", "CAMERA", "DANCER", "BANGLE", "CHEER", "PEACE" },

                new GridList() {
                "     .  .  .   . ",
                " .  .TIES..BELLS.",
                ".VIDEO..WINE.  E ",
                " A  .YULE. L   A ",
                ".SOCKS. E .TOOLS.",
                " E   .WATCH. . O ",
                " . .  A S O.IRON.",
                ".TINSEL...L  A I ",
                " R U  L .BLITZEN.",
                " E T  E.JOY. O G ",
                " E.SANTA.X.CARD. ",
                " . .  .  .   .   "});

                case 9001:
                    return new GameModel(9001, 612, 17, 12,
                new WordList() { "JANTZ", "MENZIES", "QUAY", "STURT", "LYONS", "FYSH", "OXLEY", "MURRAY", "BOYD", "EYRE", "SIRIUS", "MAWSON", "SMITH", "BASS", "ROBERTS", "HUME", "CHIFLEY", "FISK", "FISHER", "GOLD", "DARK", "REID", "DOBELL" },
                new WordList() { "JANTZ", "MENZIES", "QUAY", "STURT", "LYONS", "FYSH", "OXLEY", "MURRAY", "BOYD", "EYRE", "SIRIUS", "MAWSON", "SMITH", "BASS", "ROBERTS", "HUME", "CHIFLEY", "FISK", "FISHER", "GOLD", "DARK", "REID", "DOBELL", "STUART", "STRZELECKI", "HEYSEN", "WENTWORTH", "TURNER", "FLOREY", "WATTLE", "GREENWAY", "KELLY", "CURTIN", "HUNTER", "LAWSON", "WILLS", "BURNET", "DAWSON", "TASMAN", "DRYSDALE", "PATERSON", "LEWIS", "HOLT", "SUTHERLAND", "SCULLIN", "HUGHES", "JONES", "STEAD", "BARTON", "MACARTHUR", "RUDD", "HARTOG", "HARGRAVES", "DENNIS", "PARKES", "BURKE", "HOVELL", "HINDMARSH", "BRUCE", "GILES", "NOLAN", "BLACKETT", "MACQUARIE", "FLINDERS", "HARGRAVE", "EUREKA", "COOK", "MITCHELL", "GILMORE", "FLEET", "LALOR", "PHILLIP", "BLAXLAND", "GRAINGER", "MONCRIEFF", "DAMPIER", "HINKLER", "LEICHHARDT", "GALLIPOLI", "GRIFFIN", "EMDEN", "MACKELLAR", "DEAKIN", "BLIGH", "MELBA", "FADDEN" },

                new GridList() {
                "   .    . .   .  ",
                ".FISHER.L.MAWSON.",
                "   I  .EYRE.  X  ",
                " . R    O N.GOLD.",
                ".REID.JANTZ.  E. ",
                " O U. . S I.BOYD.",
                ".BASS.D . E  ..O ",
                " E .T A.FISK.Q B ",
                " R.MURRAY...HUME.",
                " T  R K S    A L ",
                ".SMITH.CHIFLEY.L ",
                " .  .   .    . . "});

                case 9002:
                    return new GameModel(9002, 714, 17, 12,
                new WordList() { "ZEUS", "STYX", "TROY", "AMAZONS", "SATYR", "ULYSSES", "OLYMPUS", "MUSES", "URANUS", "ROMULUS", "REMUS", "JANUS", "JUNO", "NEPTUNE", "EROS", "MARS", "MEDUSA", "JASON", "ERIS", "CHAOS", "PAN", "AENEAS", "NIKE", "KAMA" },
                new WordList() { "ZEUS", "STYX", "TROY", "AMAZONS", "SATYR", "ULYSSES", "OLYMPUS", "MUSES", "URANUS", "ROMULUS", "REMUS", "JANUS", "JUNO", "NEPTUNE", "EROS", "MARS", "MEDUSA", "JASON", "ERIS", "CHAOS", "PAN", "AENEAS", "NIKE", "KAMA", "ODYSSEUS", "TWINS", "VENUS", "SATURN", "MERCURY", "PSYCHE", "PLUTO", "VESTA", "TITANS", "CALYPSO", "CYCLOPS", "QUIRINUS", "NARCISSUS", "ORESTES", "PERSEUS", "NESTOR", "THETIS", "CLYTEMNESTRA", "POLLUX", "SPHINX", "HYPERION", "PEGASUS", "ARGONAUTS", "ORPHEUS", "MINOS", "PROMETHEUS", "MINOTAUR", "MORPHEUS", "PAX", "CASTOR", "CROCUS", "PYGMALION", "EURYDICE", "JUPITER", "ATLAS", "FURIES", "HYGEIA", "ICARUS", "VULCAN", "ARTEMIS", "GORGONS", "NEMESIS", "OEDIPUS", "CENTAUR", "EREBUS", "FATES", "PARIS", "SIREN", "LUNA", "GANYMEDE", "HESTIA", "ORION", "WODEN", "PHOENIX", "TERPSICHORE", "THEBES", "POSEIDON", "MINERVA", "HERCULES", "ADONIS", "HERMES", "PERSEPHONE", "ANTIGONE", "ATALANTA", "CASSANDRA", "CUPID", "MIDAS", "HELIOS", "BACCHUS", "HARPIES", "AJAX", "CERES", "PRIAM", "APHRODITE", "LAOCOON", "APOLLO", "ATHENA", "AGAMEMNON", "HERO", "PANDORA", "CHARON", "PENELOPE", "HADES", "ELECTRA", "GEMINI", "IRENE", "ACHILLES", "HECATE", "ANDROMEDA", "GALATEA", "GRIFFIN", "DAPHNE", "BELLONA", "QABANIL", "ECHO", "CHLOE", "HELEN", "ARIADNE", "LEANDER", "CIRCE", "DIANA", "MEDEA", "HEBE" },

                new GridList() {
                " .  . .   . .  . ",
                ".AENEAS.  J M  E ",
                " M  R T  .A E  R ",
                " A .OLYMPUS.D .I ",
                ".ZEUS.X .ROMULUS.",
                " O .. ..JANUS.L. ",
                ".NIKE.R..N.SATYR.",
                " S A.NEPTUNE. S  ",
                " . M .MARS.S  S  ",
                "   A.JUNO. .  E  ",
                "   .  S.Y.CHAOS. ",
                "      . .     .  "});

                case 9003:
                    return new GameModel(9003, 672, 17, 12,
                new WordList() { "FITZROY", "YASS", "SYDNEY", "TULLY", "AYR", "YOUNG", "BREEZA", "OUYEN", "WYEE", "HAY", "BUNBURY", "TEXAS", "STAWELL", "NOWRA", "UKI", "EXETER", "SCONE", "CAIRNS", "QUILPIE", "AVOCA", "LORNE", "MOE", "NHILL", "EDEN", "BEGA" },
                new WordList() { "FITZROY", "YASS", "SYDNEY", "TULLY", "AYR", "YOUNG", "BREEZA", "OUYEN", "WYEE", "HAY", "BUNBURY", "TEXAS", "STAWELL", "NOWRA", "UKI", "EXETER", "SCONE", "CAIRNS", "QUILPIE", "AVOCA", "LORNE", "MOE", "NHILL", "EDEN", "BEGA", "ZEEHAN", "ELIZABETH", "SNUG", "ALBURY", "TAMWORTH", "GYMPIE", "PAXTON", "QUORN", "TOWNSVILLE", "WHYALLA", "KINGAROY", "BRANXTON", "DEVONPORT", "TOOWOOMBA", "ALBANY", "MACKAY", "LAUNCESTON", "LITHGOW", "SHEPPARTON", "NORTHAM", "PERTH", "WANGARATTA", "NEWCASTLE", "NORSEMAN", "WARWICK", "BOWEN", "COWRA", "WOLLONGONG", "HORSHAM", "LISMORE", "MORWELL", "PENRITH", "JINDABYNE", "ROCKHAMPTON", "GOSFORD", "GRAFTON", "JUGIONG", "WODONGA", "QUIRINDI", "WARRNAMBOOL", "BOURKE", "BURNIE", "CASINO", "DARWIN", "HOBART", "PARKES", "OMEO", "MELBOURNE", "JUNEE", "IVANHOE", "MILDURA", "KATOOMBA", "SALE", "DUBBO", "TAREE", "BROOME", "HEXHAM", "GERALDTON", "FREMANTLE", "MAITLAND", "RENMARK", "COOMA", "MOREE", "KATHERINE", "BRISBANE", "ORANGE", "BUNDABERG", "BALLARAT", "BERRI", "KALGOORLIE", "ECHUCA", "BENDIGO", "CANBERRA", "COLLIE", "ARMIDALE", "CLARE", "ADELAIDE" },

                new GridList() {
                "  .   .   .    . ",
                ".STAWELL. Q .  S ",
                "  E   O .BUNBURY.",
                ".EXETER.  I R  D ",
                "  A. .NHILL.EDEN.",
                " .SCONE.  P E .E ",
                " T.A O.B.FITZROY.",
                ".UKI.WYEE.E.A U. ",
                " L R R G M.H.AYR.",
                " L N A.AVOCA. E  ",
                ".YASS. . E.YOUNG.",
                " . .     . .  .  "});

                case 9004:
                    return new GameModel(9004, 720, 17, 12,
                new WordList() { "TOPAZ", "ZINC", "QUARTZ", "ONYX", "ZIRCON", "RUBY", "GYPSUM", "PORPHYRY", "QUARRY", "PYRITES", "CLAY", "PIT", "TIN", "PEWTER", "SILVER", "STEEL", "JET", "IRON", "JASPER", "RADIUM", "TALC", "ROCK", "OCHRE", "REEF", "FACE" },
                new WordList() { "TOPAZ", "ZINC", "QUARTZ", "ONYX", "ZIRCON", "RUBY", "GYPSUM", "PORPHYRY", "QUARRY", "PYRITES", "CLAY", "PIT", "TIN", "PEWTER", "SILVER", "STEEL", "JET", "IRON", "JASPER", "RADIUM", "TALC", "ROCK", "OCHRE", "REEF", "FACE", "BRONZE", "ZIRCONIUM", "AMETHYST", "STRONTIUM", "MERCURY", "ANTIMONY", "TUNGSTEN", "TURQUOISE", "EMERY", "ASBESTOS", "BERYL", "TITANIUM", "TUNNEL", "URANIUM", "BRASS", "ORMOLU", "SANDSTONE", "SPAR", "RUTILE", "BAUXITE", "PLATINUM", "SHAFT", "SLATE", "DEPOSIT", "MOLYBDENITE", "ALUMINIUM", "QUICKSILVER", "LIMESTONE", "MAGNESIUM", "VEIN", "FOSSICK", "CHROMIUM", "EXCAVATE", "VANADIUM", "BASALT", "MAGNESITE", "WOLFRAM", "FLINT", "GARNET", "PUMICE", "MARCASITE", "CHALCEDONY", "DOLOMITE", "SAPPHIRE", "ANTHRACITE", "ALUMINA", "GRANITE", "ORE", "COPPER", "CADMIUM", "LIGNITE", "GRAPHITE", "COBALT", "SHALE", "MINE", "OPAL", "SILICA", "AGATE", "KAOLIN", "DIAMOND", "GOLD", "DRILL", "MARBLE", "COAL", "LODE", "MICA", "NICKEL", "EMERALD", "DIG", "DREDGE", "JADE", "LEAD" },

                new GridList() {
                " . .  . .    . . ",
                ".JASPER.G .TOPAZ.",
                " E I .ONYX.  I I ",
                ".TALC.C P.PEWTER.",
                " . V. K.S O .. C ",
                ".REEF..QUARTZ..O ",
                "  .RADIUM.P.IRON.",
                "  ..C  A. H N C. ",
                ".STEEL.RUBY.C H  ",
                "  I .  R  R . R  ",
                "  N.CLAY.PYRITES.",
                "  .    .  .   .  "});

                case 9005:
                    return new GameModel(9005, 734, 17, 12,
                new WordList() { "MEZZO", "MOZART", "BIZET", "PINZA", "OPUS", "TUNE", "SCENERY", "HAYDN", "BASS", "CHORUS", "DUET", "SOLO", "SONG", "TRIO", "BASSO", "DUO", "TEMPO", "TENOR", "STAGE", "ALTO", "BATON", "FORTE", "RUFFO", "JOAN", "OBOE", "LIND", "DANCE" },
                new WordList() { "MEZZO", "MOZART", "BIZET", "PINZA", "OPUS", "TUNE", "SCENERY", "HAYDN", "BASS", "CHORUS", "DUET", "SOLO", "SONG", "TRIO", "BASSO", "DUO", "TEMPO", "TENOR", "STAGE", "ALTO", "BATON", "FORTE", "RUFFO", "JOAN", "OBOE", "LIND", "DANCE", "DONIZETTI", "STRAUSS", "KEY", "LARYNX", "SEXTET", "TRUMPET", "FAUST", "SOLOIST", "HARMONY", "QUINTET", "QUARTET", "OVERTURE", "TURANDOT", "LOW", "MELODY", "MUSIC", "PATTI", "ROSSINI", "VOLUME", "PAVAROTTI", "TOSCA", "MASSENET", "CARUSO", "VOCALIST", "SOPRANO", "PROMPTER", "TANNHAUSER", "SING", "CONTRALTO", "SUTHERLAND", "CONDUCTOR", "RIGOLETTO", "OPERETTA", "ORATORIO", "GOUNOD", "JULIET", "TAUBER", "COMPOSER", "INTERVAL", "LIBRETTO", "MUSICIAN", "COLORATURA", "VIOLIN", "ORCHESTRA", "MINOR", "SCORE", "THEATRE", "SINGER", "NORMA", "PITCH", "ROMEO", "MIGNON", "WAGNER", "VERDI", "VOCAL", "VOICE", "PUCCINI", "BARITONE", "DIVA", "MAJOR", "DOMINGO", "PRELUDE", "CLARINET", "BORODIN", "LEONORA", "NABUCCO", "TREBLE", "OPERA", "CRESCENDO", "LOHENGRIN", "OBBLIGATO", "ENSEMBLE", "ELEKTRA", "REHEARSAL", "SERENADE", "CHOIR", "BALLET", "CARMEN", "ENCORE", "CHORD", "COMIC", "GRAND", "FIGARO", "DRAMA", "CHALIAPIN", "ARIA", "HIGH", "GIGLI", "LAKME", "FANFARE", "FINALE", "HANDEL", "MELBA", "PAGLIACCI", "AIDA" },

                new GridList() {
                " . .   .    .    ",
                ".BASS. B .  T  . ",
                " A C   I J.RUFFO.",
                " S E.MEZZO..N. B ",
                ".SONG. E A.TEMPO.",
                " O E D.TENOR.O E ",
                " ..R A . .PINZA. ",
                ".HAYDN.S.DUO.A L ",
                "  L..CHORUS. R I ",
                ".STAGE.L E.BATON.",
                "  O  .FORTE. . D ",
                "  .    . .     . "});

                case 9006:
                    return new GameModel(9006, 686, 17, 12,
                new WordList() { "TUNNY", "BRONZE", "ZANDER", "RAY", "TROUT", "DORY", "STINGRAY", "NETS", "TUNA", "EXPORT", "SQUID", "BASS", "BOX", "MINNOW", "BONITO", "SOLE", "LAX", "MANTA", "DART", "SAND", "SHARK", "ROE", "SEAL", "WHALER", "ORCA", "LINE", "BREAM", "EEL" },
                new WordList() { "TUNNY", "BRONZE", "ZANDER", "RAY", "TROUT", "DORY", "STINGRAY", "NETS", "TUNA", "EXPORT", "SQUID", "BASS", "BOX", "MINNOW", "BONITO", "SOLE", "LAX", "MANTA", "DART", "SAND", "SHARK", "ROE", "SEAL", "WHALER", "ORCA", "LINE", "BREAM", "EEL", "STARGAZER", "TURBOT", "OCTOPUS", "TREVALLY", "ANCHOVY", "SPRAT", "STURGEON", "SOCKEYE", "TRUMPETER", "SMELT", "CAVALLY", "QUINNAT", "WATER", "CRAYFISH", "SWORDFISH", "MULLET", "SKATE", "LOBSTER", "WHITING", "JELLYFISH", "PORPOISE", "POINTER", "SALMON", "DRUMMER", "SNAPPER", "WHITEBAIT", "CLOWNFISH", "DUGONG", "SINKER", "TAILOR", "HALIBUT", "JEWFISH", "CATFISH", "ELVER", "FLOAT", "GROPER", "PUFFER", "FLOUNDER", "BAIT", "HOOK", "REMORA", "BLOATER", "SARDINE", "BARRAMUNDI", "KINGFISH", "GEMFISH", "MANATEE", "MARLIN", "WHALE", "MAKO", "DOLPHIN", "HERRING", "TIDDLER", "STICKLEBACK", "PIRANHA", "CARP", "LING", "BARRACUDA", "PERCH", "ROACH", "PIKE", "BRILL", "OCEAN", "FLATHEAD", "PILCHARD", "HAMMERHEAD", "COD", "MACKEREL", "PLAICE", "HADDOCK", "HAKE" },

                new GridList() {
                " .  .         .  ",
                ".SHARK. .MINNOW. ",
                " O .O.EEL.. . H  ",
                ".LINE.. A D.SEAL.",
                " E E..BOX.O A.L  ",
                " . T. O .BRONZE. ",
                " B.STINGRAY.DART.",
                " R .R I  S.T.N.U ",
                ".EXPORT..SQUID.N ",
                " A  U O  . N E N ",
                ".MANTA..ORCA.RAY.",
                " .  .      . . . "});

                case 9007:
                    return new GameModel(9007, 626, 17, 12,
                new WordList() { "JAZZ", "ZONES", "JULY", "TYLER", "STOWE", "HAYES", "TEXAS", "QUOTA", "LIBERTY", "BUSH", "UTAH", "TWAIN", "TAFT", "WEBSTER", "NIXON", "KANSAS", "SEQUOIA", "HOWE", "IOWA", "ARKANSAS", "ADAMS", "OHIO", "LEE" },
                new WordList() { "JAZZ", "ZONES", "JULY", "TYLER", "STOWE", "HAYES", "TEXAS", "QUOTA", "LIBERTY", "BUSH", "UTAH", "TWAIN", "TAFT", "WEBSTER", "NIXON", "KANSAS", "SEQUOIA", "HOWE", "IOWA", "ARKANSAS", "ADAMS", "OHIO", "LEE", "ARIZONA", "PLYMOUTH", "WHITNEY", "PERRY", "STARS", "GETTYSBURG", "WYOMING", "KENTUCKY", "MASSACHUSETTS", "CUSTER", "STRIPES", "MISSOURI", "TRUMAN", "MISSISSIPPI", "VERMONT", "WILSON", "PENNSYLVANIA", "MAYFLOWER", "WISCONSIN", "FOURTH", "FULTON", "ROOSEVELT", "WRIGHT", "LEWIS", "KENNEDY", "MARYLAND", "JOHNSON", "MINNESOTA", "HOOVER", "CONNECTICUT", "GRANT", "EMERSON", "MONTANA", "LOUISIANA", "EISENHOWER", "MADISON", "PERSHING", "EDISON", "PENN", "ILLINOIS", "EQUAL", "CARTER", "OREGON", "REVERE", "JACKSON", "GERONIMO", "VIRGINIA", "POLK", "CABOT", "EARHART", "ROCKWELL", "JEFFERSON", "REPUBLIC", "NEBRASKA", "LINCOLN", "HAWAII", "NEVADA", "COLORADO", "FORD", "ALASKA", "BANNER", "FRANKLIN", "OKLAHOMA", "ALAMO", "MAINE", "CAROLINA", "DELAWARE", "CLEVELAND", "GEORGIA", "HARDING", "MICHIGAN", "CALIFORNIA", "REAGAN", "FLORIDA", "INDIANA", "COOLIDGE", "LINDBERGH", "INDEPENDENCE", "CLARK", "IDAHO", "GARFIELD", "ALABAMA", "BELL" },

                new GridList() {
                "  . .     .  .   ",
                "  B.TEXAS.H.UTAH.",
                ".JULY.   .A  A   ",
                "  S.LIBERTY..F   ",
                "  H E.  .WEBSTER.",
                "  .ARKANSAS.E..  ",
                " .  .A  .I. Q S  ",
                " J  .NIXON.QUOTA.",
                ".ADAMS. H.L O O  ",
                " Z   A  I E.IOWA.",
                ".ZONES.HOWE.A E  ",
                " .   .  . . . .  "});

                case 9008:
                    return new GameModel(9008, 592, 17, 12,
                new WordList() { "SASSY", "YAM", "CYPRESS", "BUTTONS", "MYRTLE", "EUCALYPTUS", "WAX", "MYALL", "SALTBUSH", "GUM", "HUON", "SIMLAX", "HIBISCUS", "YACCA", "YALBAH", "ASH", "QUENA", "HOOP", "HOP", "HEATH", "CORAL", "OAK", "COLANE" },
                new WordList() { "SASSY", "YAM", "CYPRESS", "BUTTONS", "MYRTLE", "EUCALYPTUS", "WAX", "MYALL", "SALTBUSH", "GUM", "HUON", "SIMLAX", "HIBISCUS", "YACCA", "YALBAH", "ASH", "QUENA", "HOOP", "HOP", "HEATH", "CORAL", "OAK", "COLANE", "LOTUS", "TUART", "SNEEZEWEED", "CHORIZEMA", "RUSH", "FLYTRAP", "SUNDEW", "PITURI", "WATTLE", "DRUMSTICKS", "SASSAFRAS", "SATINWOOD", "TURPENTINE", "MESSMATE", "CYMBIDIUM", "BOXWOOD", "BOTTLEBRUSH", "MAHOGANY", "MISTLETOE", "RIVERGUM", "WAXFLOWER", "BOTTLE", "TICKBUSH", "PANDANUS", "CUNJEVOI", "SPINIFEX", "OONDOROO", "SENNA", "WARATAH", "BLACKBUTT", "CASSIA", "BANGALAY", "CORKWOOD", "MANGROVE", "QUANDONG", "KURRAJONG", "DOGROSE", "KAURI", "MULGA", "CLEMATIS", "MANUKA", "CASUARINA", "FUCHSIA", "BLOODWOOD", "HOVEA", "CROWEA", "MOONAH", "SPEEDWELL", "KENTIA", "BRIGALOW", "BLACKTHORN", "ANGOPHORA", "BANGALOW", "DUCKWEED", "UMBRELLA", "BORONIA", "NALGOO", "NONDA", "IRONBARK", "BANKSIA", "GEEBUNG", "BAUERA", "BAUHINIA", "KANOOKA", "GREVILLEA", "POINCIANA", "INDIGO", "CORREA", "PAPERBARK", "FIREWEED", "JARRAH", "MELALEUCA", "BOREE", "BALDOO", "OLEARIA", "COOLABAH", "KARALLA", "MALLEE", "MACADAMIA", "CANE", "PIGFACE", "FIG", "CEDAR", "FLAG", "BAOBAB", "GIDGEE", "BELAH", "HAKEA", "ACACIA", "CABBAGE" },

                new GridList() {
                "  .   .   .  . . ",
                "  C  .HIBISCUS.W ",
                ".MYRTLE.. A  A A ",
                "  P   A C.SIMLAX.",
                "  R.BUTTONS. T . ",
                "  E  .H.R.YALBAH.",
                ".ASH.Q.YAM.  U O ",
                "  S.EUCALYPTUS.O ",
                "  .G E C.A  .HOP.",
                " .HUON.COLANE.A. ",
                "   M A A L    K  ",
                "   . . . .    .  "});

                case 9009:
                    return new GameModel(9009, 736, 17, 12,
                new WordList() { "ZIGZAG", "ZONE", "ZENITH", "ESTUARY", "WEST", "BAY", "SOUTH", "ISTHMUS", "PORTS", "ROUTES", "STREETS", "EAST", "TREES", "METRES", "ATLAS", "SOIL", "TROPIC", "WIND", "CITIES", "SEA", "GULF", "ASIA", "SPACE", "CABLES", "AREA", "REEF" },
                new WordList() { "ZIGZAG", "ZONE", "ZENITH", "ESTUARY", "WEST", "BAY", "SOUTH", "ISTHMUS", "PORTS", "ROUTES", "STREETS", "EAST", "TREES", "METRES", "ATLAS", "SOIL", "TROPIC", "WIND", "CITIES", "SEA", "GULF", "ASIA", "SPACE", "CABLES", "AREA", "REEF", "ZODIAC", "COUNTRY", "TOWNS", "INDUSTRY", "HISTORY", "TERRITORY", "PROMONTORY", "STATIONS", "STRAIT", "SOUND", "SWAMP", "VALLEY", "TRANSPORT", "TOPOGRAPHY", "BOUNDARY", "RAILWAY", "MOUNTAINS", "CONTOUR", "HIGHWAY", "CULTURE", "HARVEST", "TUNNEL", "GEOLOGY", "COAST", "NORTH", "WATER", "RESOURCES", "COMPASS", "CURRENT", "CROPS", "CLAYPAN", "ISOBARS", "CONTINENT", "EXPLORERS", "GEOGRAPHY", "LIVESTOCK", "ENVIRONMENT", "TEMPERATURE", "LIGHTHOUSE", "VEGETATION", "LATITUDE", "AIRPORT", "ORIENT", "EXPLORATION", "PLANS", "RIVER", "ROCKS", "WORLD", "TIME", "MONOLITH", "EARTHQUAKES", "MINOR", "ROADS", "HEIGHTS", "PASSAGE", "PLATEAU", "LONGITUDE", "GRAPHS", "ELEVATION", "HARBOUR", "VOLCANO", "ATOLL", "INLET", "PROJECTION", "ANTARCTIC", "PRODUCE", "WELL", "MINERALS", "BASIN", "CHART", "HILLS", "INDEX", "TRACK", "MAP", "TIDE", "FAUNA", "MAJOR", "TRADE", "ISLAND", "HEMISPHERE", "BEACONS", "ARCTIC", "LAGOON", "FALLS", "CAPRICORN", "MINE", "RAIN", "CLIMATE", "GORGE", "SCALE", "LANDSCAPE", "BORE", "BORDER", "COMMERCE", "FLORA", "RANGE", "RAILROAD", "WILDLIFE", "GRID", "LINE", "OCEAN", "CHANNEL", "DIAGRAM", "PARALLEL", "DAM", "LAND", "GLOBE", "CANCER", "GLACIER", "BRIDGE", "RELIEF", "CANAL", "CREEK", "FENCE", "LAKE" },

                new GridList() {
                "  .           .  ",
                ".ASIA..   .PORTS.",
                "  P .WIND.C   R  ",
                ".CABLES.. I.AREA.",
                " .C .STREETS..E. ",
                ".ZENITH.S I.EAST.",
                " I. ..METRES.T.R ",
                " G  R U U.SOIL.O ",
                ".ZONE.SEA..U A P ",
                " A  E ..ROUTES.I ",
                ".GULF.BAY. H . C ",
                " .  .   .  .   . "});

                case 9010:
                    return new GameModel(9010, 722, 17, 12,
                new WordList() { "JAZZ", "CRAZY", "MOTLEY", "PLAY", "SET", "SHOW", "STAR", "TIGHTS", "WINGS", "EXIT", "PIT", "SMASH", "AUTHOR", "CAST", "SONG", "BOX", "HIT", "SATIRE", "STAGE", "DEBUT", "GODS", "MASK", "ACTOR", "TRICK", "ACT", "HERO", "DRAMA", "MAGIC", "BILL", "GAG" },
                new WordList() { "JAZZ", "CRAZY", "MOTLEY", "PLAY", "SET", "SHOW", "STAR", "TIGHTS", "WINGS", "EXIT", "PIT", "SMASH", "AUTHOR", "CAST", "SONG", "BOX", "HIT", "SATIRE", "STAGE", "DEBUT", "GODS", "MASK", "ACTOR", "TRICK", "ACT", "HERO", "DRAMA", "MAGIC", "BILL", "GAG", "MYSTERY", "EXTRAVAGANZA", "VARIETY", "FANTASY", "FOYER", "REPERTORY", "SKIT", "PARODY", "SCENERY", "COMPANY", "VENTRILOQUIST", "PUPPET", "STALLS", "OVERTURE", "TRAGEDY", "PLAYER", "PROMPT", "IMPROMPTU", "MUSIC", "COMEDY", "SPOTLIGHT", "ACTRESS", "OVATION", "QUEUE", "REVUE", "AUDITORIUM", "TINSEL", "MINSTREL", "BURLESQUE", "FOOTLIGHTS", "EXOTIC", "CURTAIN", "GALLERY", "SLAPSTICK", "PRODUCTION", "PROSCENIUM", "OPERETTA", "CLOWN", "AUDITION", "LIBRETTO", "MUSICIAN", "THESPIAN", "MUSICAL", "REVIVAL", "SKETCH", "ENTERTAIN", "ORCHESTRA", "APPLAUSE", "PANTOMIME", "WAND", "CONJURER", "ENTERTAINER", "INTERLUDE", "VAUDEVILLE", "PRODUCER", "REPERTOIRE", "CONCERT", "PROGRAM", "TABLEAU", "FLAT", "SCENE", "JUGGLER", "MATINEE", "PAGEANT", "PRELUDE", "EPILOGUE", "SPECTACLE", "ACROBAT", "FOLLIES", "CLAQUE", "OPERA", "FLOP", "MIME", "REHEARSE", "PERFORMANCE", "PREMIERE", "ASIDE", "MIMIC", "BENEFIT", "BALLET", "ENCORE", "MELODRAMA", "COMIC", "AUDIENCE", "BACKDROP", "MAGICIAN", "CIRCLE", "FINALE", "PALACE", "DANCE", "FARCE", "GALA", "LEAD" },

                new GridList() {
                " .  .  .   .  .  ",
                ".GODS..SET.T  J  ",
                " A .HERO..DRAMA. ",
                " G.BOX.N.  I  Z  ",
                " . .WINGS..CRAZY.",
                ".HIT.T .MASK. .  ",
                "   I . .ACT.D  . ",
                ".MAGIC..STAGE. P ",
                "   H.AUTHOR.BILL.",
                ".PIT.S  .R. U  A ",
                "  .SATIRE.MOTLEY.",
                "   . .      .  . "});

                case 9011:
                    return new GameModel(9011, 652, 17, 12,
                new WordList() { "BRAZIL", "ORLY", "TURKEY", "ZIMBABWE", "EGYPT", "OXYGEN", "SAFETY", "ITALY", "TAXI", "VIEW", "VISA", "RUG", "CLASS", "PILOT", "TRAVEL", "WALES", "PARIS", "TIME", "NARITA", "TEA", "SLEEP", "ASIA", "FIN", "INDIA", "MEAL" },
                new WordList() { "BRAZIL", "ORLY", "TURKEY", "ZIMBABWE", "EGYPT", "OXYGEN", "SAFETY", "ITALY", "TAXI", "VIEW", "VISA", "RUG", "CLASS", "PILOT", "TRAVEL", "WALES", "PARIS", "TIME", "NARITA", "TEA", "SLEEP", "ASIA", "FIN", "INDIA", "MEAL", "TOKYO", "SWITZERLAND", "MAGAZINE", "HOSTESS", "PASSPORT", "ECONOMY", "WINGS", "MUSIC", "QUIET", "TOWEL", "AUSTRIA", "GERMANY", "TRIP", "BOMBAY", "FLYING", "STEWARD", "QUEUE", "VANCOUVER", "BUMP", "HONOLULU", "SLIPSTREAM", "ATHENS", "HOLIDAY", "DISNEYLAND", "DESTINATION", "AIRPORT", "TAHITI", "MOVIE", "PERTH", "HEATHROW", "SHOPPING", "COMFORT", "EUROPE", "PILLOW", "TICKET", "WHEELS", "FRANKFURT", "SCOTLAND", "THEATRE", "CREW", "LOUNGE", "ALTIMETER", "DARWIN", "HOBART", "MEXICO", "SINGAPORE", "LIFT", "ROME", "TAIL", "MELBOURNE", "AGENT", "RELAX", "LONDON", "RUDDER", "TARMAC", "COCKPIT", "MOROCCO", "SPEED", "ISRAEL", "DUNEDIN", "ARGENTINA", "FLIGHT", "HEIGHT", "HEADPHONES", "BRISBANE", "HAWAII", "JETLAG", "JORDAN", "THAILAND", "AILERON", "LUGGAGE", "FOOD", "ALASKA", "AUCKLAND", "JAPAN", "KOREA", "NEPAL", "HANGAR", "BANGKOK", "HOLLAND", "BOARD", "BAHRAIN", "ENGLAND", "FINLAND", "IRELAND", "BANK", "FLAP", "LAND", "FRANCE", "CHICAGO", "CABIN", "CARIBBEAN", "READ", "AFRICA", "GREECE", "BANFF", "BALI", "CANADA", "COFFEE", "BAGGAGE", "ADELAIDE" },

                new GridList() {
                "  .     . .    . ",
                ".INDIA.TRAVEL. E ",
                "  A .   U I  M G ",
                ".BRAZIL.G.SAFETY.",
                "  I I  C. A. A.P ",
                " .TIME.L ..PILOT.",
                "  A B.TAXI.A .X. ",
                "  .WALES.TURKEY. ",
                "  F B.ASIA.I  G  ",
                ".VIEW... L.SLEEP.",
                "  N E.ORLY..  N  ",
                "  . .    .    .  "});

                case 9012:
                    return new GameModel(9012, 634, 17, 12,
                new WordList() { "TINY", "FROSTY", "MONEY", "YEAR", "HAPPY", "PAST", "HOLLY", "FOGGY", "FUTURE", "TURNER", "GHOST", "MARLEY", "TIM", "WINTER", "NEW", "SILVER", "BLESS", "POOR", "SLEET", "SOLE", "EVE", "GRATE", "FIRM", "JOE", "DREAM", "BOB" },
                new WordList() { "TINY", "FROSTY", "MONEY", "YEAR", "HAPPY", "PAST", "HOLLY", "FOGGY", "FUTURE", "TURNER", "GHOST", "MARLEY", "TIM", "WINTER", "NEW", "SILVER", "BLESS", "POOR", "SLEET", "SOLE", "EVE", "GRATE", "FIRM", "JOE", "DREAM", "BOB", "FEZZIWIG", "CITY", "SHUTTERS", "MERRY", "EBENEZER", "WANT", "BUSINESS", "DESTITUTE", "QUESTION", "CHARITY", "SPIRIT", "TWELVE", "WORKHOUSE", "EXECUTOR", "PRESENT", "CHRISTMAS", "MISTLETOE", "GREEDY", "HUMBUG", "TOPPER", "MOURNER", "CRUTCH", "WILKINS", "PARLOUR", "PHANTOM", "SPECTRE", "GRINDSTONE", "MELANCHOLY", "EXTERNAL", "PETER", "SCRATCH", "WILL", "QUARREL", "SCROOGE", "GRUEL", "CRATCHIT", "MARTHA", "NEPHEW", "CLOUD", "UNCLE", "LONDON", "PUDDING", "FUNERAL", "PIGTAIL", "GENTLEMEN", "LAMPLIGHTER", "TREADMILL", "CHARLES", "DICKENS", "DANCES", "CORNHILL", "IGNORANCE", "LINK", "CAROL", "PENANCE", "GOLD", "COAL", "COLD", "CHAIN", "CLERK", "DILBER", "CHILL", "EAGER", "JACOB", "FRED", "BELINDA", "FIDDLER", "CANDLE", "OFFICE", "BELL", "DICK", "BELLE", "BLEAK", "BAH", "CAKE" },

                new GridList() {
                "   .    .    . . ",
                "   J.GHOST.FOGGY.",
                "   O .  O N. R E ",
                ".DREAM.SLEET.A A ",
                " . . A  E.WINTER.",
                ".FUTURE..B.N E.. ",
                " I U L.HOLLY..P  ",
                " R R E A E...BOB.",
                ".MONEY.PAST.E O  ",
                " . E . P.SILVER. ",
                " .FROSTY..M E .  ",
                "   .   .  . .    "});

                case 9101:
                    return new GameModel(9101, 734, 17, 12,
                new WordList() { "QUAY", "JETTY", "SUN", "PARTY", "STOVE", "SPORT", "REST", "TENT", "BUSH", "QUIET", "FLYING", "TENNIS", "DUNES", "AMUSEMENT", "FOREST", "FUN", "TAN", "OARS", "SCUBA", "HAT", "CASUAL", "SAND", "BAT", "RELAX", "SLEEP", "ROD", "SPADE", "EASE", "REEF" },
                new WordList() { "QUAY", "JETTY", "SUN", "PARTY", "STOVE", "SPORT", "REST", "TENT", "BUSH", "QUIET", "FLYING", "TENNIS", "DUNES", "AMUSEMENT", "FOREST", "FUN", "TAN", "OARS", "SCUBA", "HAT", "CASUAL", "SAND", "BAT", "RELAX", "SLEEP", "ROD", "SPADE", "EASE", "REEF", "LAZE", "MAGAZINE", "PLAY", "YACHT", "SURF", "OUTDOORS", "COSTUME", "RUG", "OUTING", "JAUNT", "TOWEL", "INSECTS", "TOURING", "COAST", "FAMILY", "SUNSCREEN", "GLASSES", "BLISTERS", "SWIMMING", "SURFING", "AQUATICS", "CRUISE", "LOTION", "ROWING", "TRAVEL", "CYCLING", "HOLIDAY", "PASTIME", "MOTORING", "WINDSURFING", "OUTBOARD", "SHELLS", "CAVES", "ROCKS", "SHORE", "TRAIN", "VACATION", "REGATTA", "SANDALS", "BUCKET", "LOUNGE", "SKINDIVING", "IDLENESS", "DRIVING", "WALK", "EXERCISE", "SPEEDBOAT", "GAMES", "JEANS", "DIVING", "BOATING", "TRAILER", "BAIT", "FISHING", "SAILING", "UMBRELLA", "BASKING", "BATHING", "CARAVAN", "BOOK", "CRICKET", "JOG", "HEALTH", "SAILBOARDING", "LINER", "WEEKEND", "CAMP", "RADIO", "HIKING", "PICNIC", "GOLF", "BARBECUE", "GLIDING", "FIRE", "GEAR", "LOAF", "RIDE", "CLIMB", "CAMERA", "BACKPACKING", "BREAK", "HIKE", "PADDLE", "BALL", "BEACH" },

                new GridList() {
                "    .  .  .  .   ",
                "  .FOREST.C..ROD.",
                " .  A. P.BAT.E . ",
                ".SPORT.AMUSEMENT.",
                " L .SAND.SUN.F E ",
                " E ..N.E.HAT.. N ",
                ".EASE.J. .L..FUN.",
                " P C.RELAX. Q  I ",
                " .QUIET.  .DUNES.",
                "   B.STOVE. A  . ",
                " .PARTY. .FLYING.",
                "   . ..     .    "});

                case 9102:
                    return new GameModel(9102, 712, 17, 12,
                new WordList() { "ZERO", "WYSE", "ZENITH", "SONY", "UNISYS", "TYPE", "MOUSE", "WINDOW", "DOT", "MENU", "EPSON", "LAPTOP", "WANG", "SCROLL", "TAPE", "PITCH", "DRIVE", "VIDEO", "SCREEN", "DISC", "RAM", "SPEED", "CANON", "DATA", "MODE", "IBM", "NEC", "FILE" },
                new WordList() { "ZERO", "WYSE", "ZENITH", "SONY", "UNISYS", "TYPE", "MOUSE", "WINDOW", "DOT", "MENU", "EPSON", "LAPTOP", "WANG", "SCROLL", "TAPE", "PITCH", "DRIVE", "VIDEO", "SCREEN", "DISC", "RAM", "SPEED", "CANON", "DATA", "MODE", "IBM", "NEC", "FILE", "QWERTY", "DAISY", "BATTERY", "MEMORY", "INSTRUMENTS", "FUJITSU", "TEXAS", "FLOPPY", "TRANSISTOR", "PORT", "STORE", "XEROX", "SAMSUNG", "DISPLAY", "SWITCH", "WORKSTATION", "BINARY", "MATRIX", "NETWORK", "TECHNOLOGY", "OLIVETTI", "SOFTWARE", "CURRENT", "HEWLETT", "MONITOR", "BOOT", "COMPUTER", "MEGABYTE", "PROCESSOR", "POWER", "ROBOT", "NASHUA", "DESKTOP", "DOCUMENT", "TRANSFER", "AMSTRAD", "CONTROL", "PRINTER", "COLOUR", "SHARP", "MACINTOSH", "KEYBOARD", "TOSHIBA", "FORMAT", "REMOTE", "ENTER", "PERSONAL", "INFORMATION", "BROTHER", "FAX", "ACCESS", "PROGRAM", "SILICON", "PANASONIC", "LASER", "CALCULATOR", "PORTABLE", "EDIT", "JOIN", "COMPAQ", "RANDOM", "GRAPHICS", "COMMODORE", "MODEM", "COMPATIBLE", "ELECTRONIC", "DATABASE", "HARDWARE", "COPIER", "RIBBON", "RICOH", "CATHODE", "DIGITAL", "INTERFACE", "LINK", "FACSIMILE", "MAINFRAME", "APPLE", "CHIP", "AMIGA", "IMAGE", "PACKARD", "ACER", "CODE", "JACK", "CABLE" },

                new GridList() {
                "  . .   .  . .   ",
                "  P.ZENITH.MOUSE.",
                ".FILE.  A  E N   ",
                "  T R..EPSON.IBM.",
                ".SCROLL.E  U.S.  ",
                "  H .A  .  .WYSE.",
                "  ..SPEED..DISC. ",
                "  .DOT..RAM.N.R  ",
                " .CANON.I O D E  ",
                "  .TYPE.VIDEO.E  ",
                "   A..C E E.WANG.",
                "   .  . . . . .  "});

                case 9103:
                    return new GameModel(9103, 518, 17, 12,
                new WordList() { "OLYMPUS", "VESUVIUS", "SNOW", "WHITNEY", "ROCKY", "EVEREST", "WHITE", "MCKINLEY", "ALPS", "JUNGFRAU", "JURA", "URAL", "ETNA", "CENIS", "ANDES", "BLUE", "WILHELM", "COOK", "RIGI", "CRAG", "PEAK", "PELEE", "HECLA" },
                new WordList() { "OLYMPUS", "VESUVIUS", "SNOW", "WHITNEY", "ROCKY", "EVEREST", "WHITE", "MCKINLEY", "ALPS", "JUNGFRAU", "JURA", "URAL", "ETNA", "CENIS", "ANDES", "BLUE", "WILHELM", "COOK", "RIGI", "CRAG", "PEAK", "PELEE", "HECLA", "KAZBEK", "CHIMBORAZO", "PARNASSUS", "PYRENEES", "SNOWDON", "POLLUX", "WOLDS", "SLOPES", "CAUCASUS", "COTSWOLD", "FUJIYAMA", "MOUNTAIN", "RUSHMORE", "KOSCIUSKO", "GHATS", "ROPES", "MOURNE", "VERNON", "QUIRAUK", "HIMALAYAS", "STROMBOLI", "ATLAS", "MASSIF", "COTOPAXI", "QUANTOCK", "MATTERHORN", "EREBUS", "PAMIRS", "CHEVIOT", "AUVERGNE", "ESCARPMENT", "PLATEAU", "WARNING", "LAURENTIAN", "POPOCATEPETL", "ANNAPURNA", "LIVERPOOL", "VOLCANO", "SINAI", "SIERRA", "GRAMPIANS", "WALL", "CATSKILL", "ARARAT", "ROCKIES", "RUAHINE", "PALISADES", "CAIRNGORM", "FLINDERS", "KRAKATOA", "PENNINE", "HEIGHT", "CARPATHIAN", "BALKANS", "MENDIP", "BLUFF", "SCALE", "TABLE", "RAINIER", "KILIMANJARO", "DIVIDE", "KILAUEA", "RANGE", "PINNACLE", "SCAFELL", "ADIRONDAK", "PRECIPICE", "CHAIN", "CLIMB", "EIGER", "RIDGE", "CASCADE", "BLANC", "BLACK", "CLIFF" },

                new GridList() {
                " .   . .      .  ",
                " S . B V   .PEAK.",
                " N.WILHELM.A  N  ",
                " O H U S . L. D  ",
                ".WHITE.U C.PELEE.",
                " . T .EVEREST.S. ",
                ".CENIS.I A .N..R ",
                " O E .JUNGFRAU.O ",
                ".OLYMPUS.. I.R C ",
                " K .  R.   G A K ",
                " .HECLA.MCKINLEY.",
                "      .    . . . "});

                case 9104:
                    return new GameModel(9104, 728, 17, 12,
                new WordList() { "ZERO", "SKY", "ZENITH", "SUN", "WEST", "SOUTH", "STARS", "SEXTANT", "WAVES", "PORT", "SIGNS", "AXIS", "TROPICS", "STEER", "BOX", "MIDDAY", "MOON", "PILOT", "ORBIT", "TIME", "FIX", "TABLES", "EARTH", "POLE", "LOG", "RANGE", "LINE", "GLOBE", "LEE" },
                new WordList() { "ZERO", "SKY", "ZENITH", "SUN", "WEST", "SOUTH", "STARS", "SEXTANT", "WAVES", "PORT", "SIGNS", "AXIS", "TROPICS", "STEER", "BOX", "MIDDAY", "MOON", "PILOT", "ORBIT", "TIME", "FIX", "TABLES", "EARTH", "POLE", "LOG", "RANGE", "LINE", "GLOBE", "LEE", "AZIMUTH", "HORIZON", "VENUS", "VOYAGE", "INSTRUMENT", "CROSS", "GYROSCOPE", "ADJUST", "EAST", "POSITION", "NORTH", "POINT", "WATER", "COURSE", "COMPASS", "CURRENT", "EQUATOR", "QUARTER", "MAPS", "SOUNDING", "OBSERVATION", "NOON", "CHARTS", "CLOUDS", "SHADOW", "DESTINATION", "LIGHTHOUSE", "ALTITUDE", "LATITUDE", "QUADRANT", "MEASURE", "RHUMB", "NAVIGATOR", "WIND", "SIGHTING", "SATELLITE", "LONGITUDE", "STARBOARD", "CRESCENT", "VERTICAL", "CHRONOMETER", "DRIFT", "SIGNAL", "MIDNIGHT", "LORAN", "TRIANGLE", "DIRECTION", "HEMISPHERE", "CELESTIAL", "MAGNETIC", "GIMBALS", "GAUGE", "GUIDE", "JUDGE", "CAPRICORN", "GREENWICH", "DATA", "MARINE", "RECKONING", "DEGREES", "NADIR", "RADIO", "LANDMARK", "MERIDIAN", "MIRAGE", "FORCE", "OCEAN", "RADAR", "BEARING", "READING", "ARC", "HIGH", "ANGLE", "BEACON", "CANCER", "HEADING", "NEEDLE", "LEAD" },

                new GridList() {
                " . .      ..   . ",
                ".POLE.   .TABLES.",
                " O I.SUN.FIX.  K ",
                ".RANGE..E.MIDDAY.",
                " T E X.WAVES.  . ",
                " . .STEER...  .  ",
                " P . A.STARS.LOG.",
                " I.ZENITH. I  R  ",
                ".LEE.T ..B.GLOBE.",
                " O R . .MOON. I  ",
                ".TROPICS.X.SOUTH.",
                " . .     . .  .  "});

                case 9105:
                    return new GameModel(9105, 506, 17, 12,
                new WordList() { "DYNASTY", "ROYALTY", "MAJESTY", "HENRY", "LOUIS", "ARTHUR", "THRONE", "IVAN", "RULE", "VICTORIA", "CORONET", "ATTILA", "REGENT", "MIDAS", "EMPEROR", "OBERON", "LORD", "RANI", "CABINET", "BANNER", "COLE" },
                new WordList() { "DYNASTY", "ROYALTY", "MAJESTY", "HENRY", "LOUIS", "ARTHUR", "THRONE", "IVAN", "RULE", "VICTORIA", "CORONET", "ATTILA", "REGENT", "MIDAS", "EMPEROR", "OBERON", "LORD", "RANI", "CABINET", "BANNER", "COLE", "CZARINA", "ELIZABETH", "COUNTESS", "SULTAN", "XERXES", "CHIVALRY", "MARQUIS", "WINDSOR", "MINOS", "CEREMONY", "EMPRESS", "SOLOMON", "TIBERIUS", "CROWN", "DUCHESS", "ROMANOV", "CONSTANTINE", "STEPHEN", "COURTIER", "PRINCESS", "GOVERNMENT", "TUTANKHAMEN", "MAGISTRATE", "CLAUDIUS", "PROTOCOL", "SCEPTRE", "CANUTE", "LUDWIG", "SOVEREIGN", "WENCESLAS", "FOOTMAN", "PRESIDENT", "DICTATOR", "PETER", "QUEEN", "CORONATION", "BEATRIX", "CHRISTINA", "STANDARD", "ALFONSO", "GARTER", "KNIGHT", "JAMES", "JEHOSHAPHAT", "DUNCAN", "ETHELBERT", "PARLIAMENT", "DUKE", "MAJOR", "PRIAM", "KAISER", "NICHOLAS", "HAMMURABI", "HARDICANUTE", "CLEOPATRA", "GUARDIAN", "MONARCH", "JUDGE", "CHARLES", "KINGDOM", "SHERIFF", "CAESAR", "EDWARD", "EMPIRE", "CATHERINE", "COMMANDER", "DAVID", "LEOPOLD", "PHARAOH", "ALEXANDER", "KING", "ETHELRED", "HEROD", "CALIGULA", "CAROLINE", "GEORGE", "HAROLD", "MIKADO", "CHANCELLOR", "RICHARD", "CHAMBERLAIN", "RAJAH", "CALIPH", "OFFICER", "MAHARAJAH", "FREDERICK", "ALARIC", "ALFRED", "PALACE", "BOADICEA" },

                new GridList() {
                " .   .     . .   ",
                " V .MIDAS. H A   ",
                " I C V   O E T   ",
                " C O A.CABINET.. ",
                ".THRONE. E R I D ",
                " O O .M .ROYALTY.",
                ".RANI.P  O ..A N ",
                " I E.REGENT.C. A ",
                ".ARTHUR. ..LOUIS.",
                " . ..LORD.  L  T ",
                ".BANNER..MAJESTY.",
                "     ..     .  . "});

                case 9106:
                    return new GameModel(9106, 676, 17, 12,
                new WordList() { "ZEUS", "ZEPHYRUS", "SATYR", "ULYSSES", "OLYMPUS", "NYMPHS", "SATURN", "MERCURY", "PLUTO", "ISIS", "NESTOR", "SETH", "EROS", "MARS", "FURIES", "JASON", "PARIS", "ORION", "ADONIS", "CREON", "ABAS", "ODIN", "IONIA", "RHEA" },
                new WordList() { "ZEUS", "ZEPHYRUS", "SATYR", "ULYSSES", "OLYMPUS", "NYMPHS", "SATURN", "MERCURY", "PLUTO", "ISIS", "NESTOR", "SETH", "EROS", "MARS", "FURIES", "JASON", "PARIS", "ORION", "ADONIS", "CREON", "ABAS", "ODIN", "IONIA", "RHEA", "AMAZONS", "ABYSRTUS", "DIONYSUS", "HIPPOLYTUS", "URANUS", "ROMULUS", "PSYCHE", "HORUS", "TITANS", "CYCLOPS", "THESEUS", "TANTALUS", "NARCISSUS", "ORESTES", "PERSEUS", "CLYTEMNESTRA", "THOTH", "OSIRIS", "POLLUX", "HORATIUS", "PEGASUS", "THOR", "ORPHEUS", "MINOS", "PROMETHEUS", "MINOTAUR", "CASTOR", "SPARTA", "PYGMALION", "NEPTUNE", "YGGDRASIL", "THULE", "ISHTAR", "JUPITER", "MITHRAS", "ATLAS", "ANUBIS", "ATHENS", "GORGONS", "NEMESIS", "CHARYBDIS", "CENTAUR", "MEDUSA", "TROJAN", "ARGOS", "GANYMEDE", "HYGIEIA", "AURORA", "EUROPA", "THISBE", "MENELAUS", "WODEN", "TELEMACHUS", "LAERTES", "TERPSICHORE", "ARES", "HATHOR", "CERBERUS", "ANTIOPE", "MINERVA", "ACHELOUS", "HERCULES", "HECTOR", "MARDUK", "PERSEPHONE", "ATALANTA", "ANTIGONE", "CASSANDRA", "ACHATES", "HEIDRUN", "CHARIS", "APHRODITE", "LAVINIA", "APOLLO", "ASGARD", "LETHE", "AGAMEMNON", "BRUNHILDE", "HERO", "PANDORA", "CHARON", "BELLEROPHON", "PENELOPE", "HADES", "ELECTRA", "LOKI", "SIEGFRIED", "NIOBE", "ACHILLES", "VALHALLA", "ANDROMEDA", "CLIO", "IPHIGENIA", "ENLIL", "DAPHNE", "ORACLE", "MIDGARD", "DIDO", "DELPHI", "LEANDER", "ALDER", "CIRCE", "DIANA", "MEDIA", "BALDER", "ALCIMEDE" },

                new GridList() {
                " .  .    .   . . ",
                ".ZEUS. . C . N A ",
                " E  E .MERCURY.B ",
                ".PLUTO.A E L M A ",
                " H .H .R.OLYMPUS.",
                " Y N.JASON.S H . ",
                ".RHEA.D.R.ISIS.P ",
                " U S .ODIN.E . A ",
                ".SATURN.O .SATYR.",
                " . O .IONIA.   I ",
                ".FURIES..  .EROS.",
                "   .  .        . "});

                case 9107:
                    return new GameModel(9107, 710, 17, 12,
                new WordList() { "DAZZLE", "DUTY", "TYRE", "NUT", "BENZINE", "KEY", "SAFETY", "SPORT", "AUTO", "VANS", "ROYCE", "SEATS", "ROTOR", "HUBS", "BOOT", "ROLLS", "GAS", "SPARE", "CARS", "HORN", "ROOF", "TAIL", "AXLE", "BELT", "SPEED", "ROAD", "AIR", "LOCK", "BRAKE", "CARE" },
                new WordList() { "DAZZLE", "DUTY", "TYRE", "NUT", "BENZINE", "KEY", "SAFETY", "SPORT", "AUTO", "VANS", "ROYCE", "SEATS", "ROTOR", "HUBS", "BOOT", "ROLLS", "GAS", "SPARE", "CARS", "HORN", "ROOF", "TAIL", "AXLE", "BELT", "SPEED", "ROAD", "AIR", "LOCK", "BRAKE", "CARE", "LUXURY", "SPORTS", "STANLEY", "BATTERY", "CUSTOM", "PISTONS", "MOTORIST", "EXHAUST", "SUSPENSION", "ROADWAY", "SWITCH", "MOTOR", "TRANSMISSION", "BENTLEY", "HIGHWAY", "TOWING", "THROTTLE", "DISTRIBUTOR", "WINDOW", "CYLINDERS", "BUGATTI", "CHASSIS", "ARROW", "GLASS", "POWER", "FLYWHEEL", "AUTOMATIC", "HYDRAULIC", "LIGHTS", "NEUTRAL", "TURBINE", "CARBURETTOR", "HORSEPOWER", "CYLINDER", "VETERAN", "PETROL", "SPARK", "INDUCTION", "MOTORCAR", "STEERING", "VOLTAGE", "HUB", "CLUTCH", "WHEELS", "WIRING", "INSURANCE", "COUPE", "DIPSTICK", "IGNITION", "AUTOMOBILE", "STUDEBAKER", "LUBRICANT", "REPAIRS", "ODOMETER", "SPEEDOMETER", "MANUAL", "COMPACT", "DRIVING", "DOOR", "TAILLIGHT", "GEARS", "LEVER", "RADIATOR", "DUESENBERG", "WINDSHIELD", "FUEL", "SEDAN", "DESIGN", "FILTER", "GASOLINE", "TAILPIPE", "HEADLIGHTS", "OLDSMOBILE", "GAUGE", "PARK", "TRAFFIC", "FORD", "ELECTRIC", "VEHICLE", "ENGINE", "RACING", "IDLING", "PIERCE", "DAIMLER", "CAM", "GEAR", "CHOKE", "GARAGE", "PEDAL" },

                new GridList() {
                " .  .  .  .    . ",
                " L  G .BELT.VANS.",
                " O .AXLE. Y .  P ",
                ".CARS. N .ROAD.A ",
                " K O.DAZZLE.I  R ",
                " . T.U I  .BRAKE.",
                ".SPORT.NUT.O.  . ",
                " E.ROYCE..HORN.. ",
                " A .L.A..AUTO. K ",
                ".TAIL.R   B.O  E ",
                " S .SPEED.SAFETY.",
                " .  . .   . .  . "});

                case 9108:
                    return new GameModel(9108, 696, 17, 12,
                new WordList() { "ZEPHYR", "OZONE", "DUSTY", "GUST", "MUGGY", "SNOW", "EURUS", "WET", "STORM", "CUMULUS", "FROSTS", "MIST", "FOGGY", "THAW", "HOT", "LOW", "SMOG", "SLEET", "TROPIC", "METEOR", "DULL", "CLOUD", "HILLS", "POLAR", "GALE" },
                new WordList() { "ZEPHYR", "OZONE", "DUSTY", "GUST", "MUGGY", "SNOW", "EURUS", "WET", "STORM", "CUMULUS", "FROSTS", "MIST", "FOGGY", "THAW", "HOT", "LOW", "SMOG", "SLEET", "TROPIC", "METEOR", "DULL", "CLOUD", "HILLS", "POLAR", "GALE", "BLIZZARD", "SULTRY", "STRATUS", "TYPHOON", "SOUTHERLY", "AUTUMN", "VORTEX", "WATERSPOUT", "HUMIDITY", "VELOCITY", "STEPPES", "SUMMER", "MOUNTAINS", "CURRENTS", "SANDSTORM", "DOWNPOUR", "NUBILOUS", "MONSOON", "METEOROLOGY", "WAVE", "NIMBUS", "SHOWER", "WINTER", "CLOUDBURST", "OVERCAST", "SIMOOM", "TUNDRA", "WESTERLIES", "CELSIUS", "EQUATOR", "FRONT", "SQUALL", "CYCLONE", "DROUGHT", "MISTRAL", "WHIRLWINDS", "VELDT", "SPRING", "ISOBARS", "THUNDER", "DOLDRUMS", "TEMPERATURE", "THUNDERBOLT", "HAILSTORM", "ALTITUDE", "LATITUDE", "DESERT", "TURBULENCE", "WIND", "HEATWAVE", "THERMALS", "EVAPORATION", "THERMOMETER", "TORNADO", "ATMOSPHERE", "AURORA", "HARMATTAN", "WEATHER", "LONGITUDE", "WEATHERVANE", "PLAINS", "FORECAST", "RAINBOW", "SIROCCO", "HUMID", "PAMPERO", "THERMAL", "WINDMILL", "BAROMETER", "LIGHTNING", "HURRICANE", "RAINCLOUD", "HEMISPHERE", "RAIN", "CHINOOK", "CLIMATE", "CIRRI", "FAHRENHEIT", "DAMP", "DELUGE", "CENTIGRADE", "FLOOD", "MERIDIAN", "FOG", "AVALANCHE", "OCEAN", "FOGBANK", "RAINFALL", "HIGH", "GLACIER", "HAIL", "FIREBALL", "CHANGEABLE" },

                new GridList() {
                "  . . . . . .    ",
                "  C C L.H.MIST.  ",
                "  L U.OZONE.M H  ",
                "  O M.WET.TROPIC.",
                ".EURUS.P. E G L  ",
                "  D.L. H .O . L  ",
                "  .DUSTY.FROSTS. ",
                " .GUST.R O. L .S ",
                "   L.O ..GALE. N ",
                ".POLAR.  G  E  O ",
                "   ..MUGGY..THAW.",
                "     .   .  .  . "});

                case 9109:
                    return new GameModel(9109, 636, 17, 12,
                new WordList() { "BUZZERS", "PAY", "KEYS", "POST", "MAGAZINE", "MONEY", "BONUS", "LIST", "PASTE", "ANSWER", "COPYPAPER", "LETTER", "TIME", "ENTER", "SEND", "TAPE", "ERROR", "INDEX", "SCREEN", "TELLER", "ORDER", "PAPER", "EARN", "BANK" },
                new WordList() { "BUZZERS", "PAY", "KEYS", "POST", "MAGAZINE", "MONEY", "BONUS", "LIST", "PASTE", "ANSWER", "COPYPAPER", "LETTER", "TIME", "ENTER", "SEND", "TAPE", "ERROR", "INDEX", "SCREEN", "TELLER", "ORDER", "PAPER", "EARN", "BANK", "TAX", "STATIONERY", "TYPEWRITER", "REPLY", "SCISSORS", "SALARY", "PHOTOCOPY", "PHOTOSTAT", "SECRETARY", "COMPANY", "QUARTO", "INVESTMENT", "STATEMENT", "CUSTOMER", "DIRECTORY", "STOREROOM", "FURNITURE", "DELIVERY", "SUPERANNUATION", "COMPUTER", "INTERVIEW", "PROCESSOR", "REPORT", "SALES", "WAGES", "AUDITOR", "DEPOSIT", "REWRITE", "EQUIPMENT", "ACCOUNTANT", "APPOINTMENT", "DOCUMENT", "DRAWERS", "STOCKTAKING", "GOODS", "STAFF", "INVOICES", "KEYBOARD", "REMUNERATION", "MESSENGER", "PORTFOLIO", "SWITCHBOARD", "JOURNAL", "PERSONNEL", "NOTEBOOK", "MEMORANDUM", "PHOTOCOPIER", "NOTEPAPER", "NOTICE", "CORRECT", "OPERATE", "FLEXITIME", "CARPET", "MEETING", "DIRECTOR", "RADIATOR", "DESK", "FIGURE", "RECEIPT", "LIGHTING", "SCHEDULE", "TELEPHONE", "AIRCONDITIONER", "CREDIT", "DOCKET", "MARGIN", "DEBT", "SAFE", "CASHIER", "CAPITAL", "INK", "RIBBON", "DEBIT", "FOLIO", "LEASE", "CARBON", "DIVIDEND", "EXCHANGE", "FACSIMILE", "BROMIDE", "MANAGER", "MAIL", "FOLDER", "PARCEL", "MACHINE", "CHAIR", "CLERK", "CALENDAR", "CHARGE", "LEDGER", "CARD", "OFFICE", "DEADLINE", "BALANCE", "FILE" },

                new GridList() {
                "   . .  .   . .  ",
                "   M.LETTER.B B  ",
                "   O I  I   U A  ",
                ".BONUS..MAGAZINE.",
                "  .E.TAPE.  Z K. ",
                ".KEYS. A. ..E .E ",
                "  A.COPYPAPER. R ",
                "  R R  .A.ANSWER.",
                ".INDEX..POST.  O ",
                "  . E   E.TELLER.",
                " .SEND.ORDER.  . ",
                "    .   . ..     "});

                case 9110:
                    return new GameModel(9110, 598, 17, 12,
                new WordList() { "SQUEEZER", "TRAY", "FREEZER", "SPOONS", "STOOL", "TRIVET", "SIEVES", "BOTTLES", "SAUCERS", "TRAYMOBILE", "GLASS", "TILES", "SHEARS", "SINK", "GAS", "KETTLE", "BASKET", "SCALES", "APRON", "TEA", "FAN" },
                new WordList() { "SQUEEZER", "TRAY", "FREEZER", "SPOONS", "STOOL", "TRIVET", "SIEVES", "BOTTLES", "SAUCERS", "TRAYMOBILE", "GLASS", "TILES", "SHEARS", "SINK", "GAS", "KETTLE", "BASKET", "SCALES", "APRON", "TEA", "FAN", "PANTRY", "STOVE", "CUTLERY", "SCISSORS", "TROLLEY", "UTENSILS", "FRYPAN", "TOASTER", "WORKTOP", "SWITCH", "TEASPOONS", "COUNTERTOP", "SPATULA", "WINDOW", "CURTAINS", "WATER", "TEAPOT", "TUREEN", "EXTRACTOR", "POWERPOINT", "ROASTER", "SHELVES", "OVEN", "PROCESSOR", "ROTISSERIE", "ELECTRICITY", "KNIVES", "TEATOWEL", "LIGHTS", "STRAINER", "EQUIPMENT", "DRAWERS", "MEASURE", "STEAMER", "NUTCRACKERS", "FORKS", "TIMER", "HOTPLATE", "THERMOMETER", "CONTAINERS", "CONVECTION", "DISHWASHER", "TABLESPOON", "CORKSCREW", "MICROWAVE", "CANISTER", "MATCHES", "SKILLET", "SKIMMER", "CUPBOARDS", "IRON", "SAUCEPAN", "TERRINE", "TENDERISER", "FUNNEL", "GRATER", "CASSEROLE", "PERCOLATOR", "GADGETS", "GASRING", "LIDS", "CABINETS", "RAMEKINS", "BASIN", "LIGHT", "COOKWARE", "FLOOR", "BLINDS", "FILTER", "LIGHTER", "CUPBOARD", "GROCERIES", "TELEPHONE", "AIRCONDITIONER", "REFRIGERATOR", "KITCHEN", "COOKER", "MINCER", "TABLE", "CLEAVER", "GRINDER", "MANDOLINE", "POACHER", "DRAIN", "GRILL", "BOILER", "BARBECUE", "COLANDER", "LARDER", "CLOCK", "BLENDER", "CEILING", "DREDGER", "GRIDDLE", "BENCH", "LADLE" },

                new GridList() {
                " .  .    . .  .  ",
                ".BOTTLES.S.GLASS.",
                " A  I .  H A. P  ",
                ".SCALES. E.STOOL.",
                " K  E Q  A..R O  ",
                " E .SAUCERS.I N  ",
                ".TEA. E .SIEVES. ",
                " . P  E T.N E .  ",
                " .FREEZER.KETTLE.",
                "   O  E A . .    ",
                ".FAN.TRAYMOBILE. ",
                "   .  . .        "});

                case 9111:
                    return new GameModel(9111, 616, 17, 12,
                new WordList() { "HYDROZOA", "PROTOZOA", "OYSTER", "MUSSELS", "SURF", "ROSES", "PRAWNS", "STING", "SALT", "MOLLUSCS", "COAST", "DUNES", "SHARKS", "SHELLS", "ROCKS", "WEEDS", "FINS", "WIND", "CASTLE", "SAND", "REEFS", "MARINE", "LINE" },
                new WordList() { "HYDROZOA", "PROTOZOA", "OYSTER", "MUSSELS", "SURF", "ROSES", "PRAWNS", "STING", "SALT", "MOLLUSCS", "COAST", "DUNES", "SHARKS", "SHELLS", "ROCKS", "WEEDS", "FINS", "WIND", "CASTLE", "SAND", "REEFS", "MARINE", "LINE", "SQUIRTS", "TURRET", "OCTOPUS", "WAVES", "SQUIDS", "TRITON", "TROCHUS", "CURRENTS", "PISTOL", "JELLY", "SHRIMPS", "TUNICATES", "SUNLIGHT", "FLATWORMS", "SPONGES", "POOLS", "WATER", "CRAYFISH", "NATURE", "SUNSCREEN", "PROTOPLASM", "NEPTUNE", "TEXTILE", "SKELETONS", "PRAWN", "CHITONS", "LETTUCE", "LIMPETS", "URCHINS", "ESTUARINE", "CRUSTACEANS", "GASTEROPODS", "MOON", "CLAWS", "TIDES", "KEYHOLE", "LOBSTER", "SEAWATER", "STROMBID", "JELLYFISH", "STRAPWEED", "UNDERWATER", "BIVALVES", "LITTORAL", "MEDUSA", "SPADES", "MITRE", "SHORE", "TENTACLES", "CUNJEVOI", "SCALLOPS", "DUMPER", "FRONDS", "WHALES", "PLANKTON", "SEASHORE", "SEAWEEDS", "RIPPLES", "SLIPPER", "SNORKEL", "WARATAH", "BUCKET", "PINCERS", "SNAIL", "TIGER", "EELGRASS", "COWRIE", "FISH", "CREVICES", "SCAVENGE", "SEABIRDS", "CLAMS", "LARVA", "MICROSCOPIC", "PLANULA", "SOLDIER", "ASCIDIANS", "LIFESAVER", "ASTEROIDEA", "BREAKWATER", "PIPI", "CRABS", "WHELK", "HELMET", "ISLAND", "FISHING", "SEAWEED", "PERIWINKLE", "ECHINODERMS", "BAITWEED", "CUNJEE", "BREAKERS", "ANEMONE", "ANCHOR", "RIBBON", "BARNACLES", "GREENWEED", "CLIFFS", "BEACHCOMBERS", "CORAL", "BUBBLE", "KELP", "OCEAN", "BAILER", "CRAB", "REEF", "CARAPACE", "PADDLE", "CILIA", "ALGAE", "BEACH" },

                new GridList() {
                "   . .  .  . . . ",
                ".ROSES..PRAWNS.M ",
                " . U A  R  I T U ",
                ".MARINE.O  N I S ",
                " O F.D  T .DUNES.",
                " L .O.. O C..G E ",
                " L.HYDROZOA.R..L ",
                " U  S O O.SHELLS.",
                ".SALT.COAST.E I. ",
                " C  E K . L.FINS.",
                ".SHARKS.WEEDS.E  ",
                " .  . .   . . .  "});

                case 9112:
                    return new GameModel(9112, 552, 17, 12,
                new WordList() { "TOY", "BLITZEN", "MARZIPAN", "TURKEY", "WHISKY", "MERRY", "TOAST", "SWEETS", "STAR", "HOLLY", "PRESENTS", "BRANDY", "SEASON", "TREE", "DONNER", "PIPER", "EGGNOG", "CREAM", "DANCE", "FOOD" },
                new WordList() { "TOY", "BLITZEN", "MARZIPAN", "TURKEY", "WHISKY", "MERRY", "TOAST", "SWEETS", "STAR", "HOLLY", "PRESENTS", "BRANDY", "SEASON", "TREE", "DONNER", "PIPER", "EGGNOG", "CREAM", "DANCE", "FOOD", "NATIVITY", "GORGONZOLA", "CUSTOMS", "GUESTS", "WALNUTS", "JANUARY", "PEANUTS", "BISCUITS", "CURRANTS", "MUSCATELS", "FESTIVITIES", "CUSTARD", "STOCKINGS", "STREAMERS", "GLASSES", "EPIPHANY", "HOGMANAY", "SINGSONG", "CHRISTMAS", "MISTLETOE", "ORNAMENTS", "TINSEL", "CASHEWS", "FESTIVE", "RAISINS", "PARTIES", "MERRYMAKING", "FESTIVAL", "PUNCH", "FIREWORKS", "SEASONING", "WENCESLAS", "WINE", "BONBONS", "SCOTLAND", "GREETINGS", "PANTOMIME", "PISTACHIO", "BOXING", "NOWELL", "DECORATIONS", "SHEPHERDS", "ALMONDS", "RIBBONS", "SINGING", "BUFFET", "CAROLS", "TINFOIL", "GIFT", "BALLOONS", "PUDDING", "GOODWILL", "MIDNIGHT", "CELEBRATIONS", "CARDS", "CHURCH", "TRIFLE", "FRIENDS", "NICHOLAS", "BAGPIPES", "CORDIALS", "HAGGIS", "SLEIGH", "BELLS", "CRACKERS", "FRANKINCENSE", "PRANCER", "CANDLES", "BETHLEHEM", "LEMONADE", "REINDEER", "CHAMPAGNE", "DANCING", "ANGEL", "DANCER", "CALENDAR", "CHICKEN", "DECEMBER", "PEACE", "CAKE" },

                new GridList() {
                "     .     .   . ",
                ".CREAM.  ..TOAST.",
                "  .  E .STAR.. U ",
                "  F .R   O E P R ",
                "  O.BRANDY.E R K ",
                ".HOLLY. ..S. E E ",
                "  D I.P D.WHISKY.",
                "  . T I A E  E . ",
                ".MARZIPAN.EGGNOG.",
                "    E E C T  T   ",
                ".DONNER.E.SEASON.",
                "    . . . .  .   "});

                case 9201:
                    return new GameModel(9201, 522, 17, 12,
                new WordList() { "STURT", "LIZARDS", "OPOSSUMS", "CASSOWARY", "MACROZAMIA", "LILLYPILLY", "STATION", "BATS", "OREILLY", "WOMBAT", "SWAGMEN", "WONGA", "IDRIESS", "SKINK", "IRON", "MULGA", "EWE", "ION", "MATILDA" },
                new WordList() { "STURT", "LIZARDS", "OPOSSUMS", "CASSOWARY", "MACROZAMIA", "LILLYPILLY", "STATION", "BATS", "OREILLY", "WOMBAT", "SWAGMEN", "WONGA", "IDRIESS", "SKINK", "IRON", "MULGA", "EWE", "ION", "MATILDA", "COUNTRY", "PLATYPUS", "GUMNUTS", "EUCALYPTUS", "BRUMBY", "MOSQUITO", "WENTWORTH", "SETTLERS", "STOCKYARD", "SYCAMORE", "WATTLE", "POTOROO", "LAWSON", "SCRUB", "WILLS", "BOTTLEBRUSH", "PATERSON", "CHRISTMAS", "DROUGHT", "LASSETER", "KIMBERLEYS", "BUSHMEN", "FLOWERS", "STOCKMAN", "WATERHOLES", "LYREBIRD", "HORSE", "REPTILES", "SPINIFEX", "JUMBUCK", "DROVER", "FERNS", "DROVING", "OUTBACK", "RABBITS", "WARATAH", "KOOKABURRAS", "CASSIA", "EXPLORER", "PIONEERS", "BUSHRANGER", "PACKHORSES", "KURRAJONG", "TEATREE", "GEEBUNGS", "CALLISTEMON", "RANGES", "TIMBER", "CALLITRIS", "CASUARINA", "HOMESTEAD", "KANGAROOS", "WALLAROO", "BURKE", "JUNGLE", "MOPOKE", "COCKATOO", "OVERLAND", "BUDGERIGARS", "SHEOAK", "TELOPEA", "TRACKER", "ANGOPHORA", "BANDICOOT", "WALLABIES", "FLINDERS", "BORONIA", "BULLOCK", "CAMELS", "LAGOON", "BOOMERANG", "CAMPDRAFT", "TELEGRAPH", "IRONBARK", "BANKSIA", "GOANNA", "DINGO", "GREVILLEA", "DAMPER", "BLAXLAND", "PADEMELON", "PAPERBARK", "BANJO", "JACKAROO", "DOG", "BROLGA", "INLAND", "KIDMAN", "SADDLE", "MELALEUCA", "ABORIGINAL", "BERNARD", "CROCODILE", "COOEE", "CICADAS", "FLANNEL", "PELICAN", "BILLABONG", "BARK", "KOALA", "GLIDER", "MALLEE", "ECHIDNA", "CEDAR", "ACACIA" },

                new GridList() {
                " .   .    . .  . ",
                " E . M.IDRIESS.L ",
                ".WOMBAT. .O T  I ",
                " E A C .WONGA. L ",
                " .STURT. P. T  L ",
                " B I O I.OREILLY.",
                " A.LIZARDS. O  P ",
                " T D A O.SKINK.I ",
                ".SWAGMEN.U  .  L ",
                " . . I . M     L ",
                ".MULGA.CASSOWARY.",
                "     .   .     . "});

                case 9202:
                    return new GameModel(9202, 558, 17, 12,
                new WordList() { "LIZARDS", "PUSS", "RAPUNZEL", "BEAUTY", "STRAW", "SHUTTLE", "GRYPHON", "TOWER", "SERVANT", "TROLLS", "THUMB", "IMPS", "NOSE", "SPELLS", "GOOSE", "WAND", "GIANT", "DREAMS", "DUCK", "FROG", "HARE", "LIE" },
                new WordList() { "LIZARDS", "PUSS", "RAPUNZEL", "BEAUTY", "STRAW", "SHUTTLE", "GRYPHON", "TOWER", "SERVANT", "TROLLS", "THUMB", "IMPS", "NOSE", "SPELLS", "GOOSE", "WAND", "GIANT", "DREAMS", "DUCK", "FROG", "HARE", "LIE", "TRUMPETS", "SISTERS", "TWOSHOES", "COURTYARD", "WHITTINGTON", "WOODCUTTER", "RUMPELSTILTSKIN", "COURTIERS", "ORPHEUS", "STEPMOTHER", "TREASURE", "DORMOUSE", "EURYDICE", "WITCH", "PIXIES", "SLIPPERS", "ELVES", "KNIGHTS", "PUMPKIN", "BROTHERS", "BROWNIES", "PRINCESS", "BANQUET", "DWARFS", "GNOMES", "WARLOCKS", "MIRROR", "SHEPHERDESS", "CHRISTIAN", "FAIRYLAND", "CASTLE", "TAILOR", "SPELLBOUND", "TWEEDLEDUM", "ENCHANTMENT", "SWINEHERD", "DRAGONS", "SPELL", "NUTCRACKER", "CHARMS", "GODMOTHER", "THUMBELINA", "GOBLINS", "BANSHEES", "GRIMM", "EMPEROR", "SOLDIER", "SPINDLE", "HANDSOME", "BEANSTALK", "EXCALIBUR", "ROBIN", "GRETEL", "HANSEL", "MERMAN", "ANDERSEN", "SLEEPING", "SHOEMAKER", "HOBGOBLINS", "GOODFELLOW", "SHEPHERD", "SINBAD", "DEMON", "GOLDILOCKS", "LEPRECHAUN", "DUCKLING", "NIGHTINGALE", "FAIRIES", "TINKERBELL", "DRAGON", "PRINCE", "CATHERINE", "PINOCCHIO", "GOLDEN", "BLUEBEARD", "DONALD", "MAIDEN", "MAGICIAN", "CHANGELING", "GINGERBREAD", "ARIEL", "GENIE", "MAGIC", "CINDERELLA", "COACH", "ALADDIN", "NEEDLE", "PALACE" },

                new GridList() {
                " .  . .   . .  . ",
                ".SHUTTLE.GIANT.G ",
                " E  H I   M O  O ",
                ".RAPUNZEL.P.S  O ",
                " V  M A ..SPELLS.",
                " A .B R B .U.. E ",
                " N T..DREAMS.F . ",
                ".TROLLS.A .STRAW.",
                " . W I.DUCK. O A ",
                "   E E  T    G N ",
                ".HARE.GRYPHON. D ",
                "   .    .      . "});

                case 9203:
                    return new GameModel(9203, 548, 17, 12,
                new WordList() { "STAY", "CUSTODY", "WITNESS", "WRIT", "LAWSUIT", "ASSAULT", "PENALTY", "COURT", "FELONY", "USHER", "FORGERY", "GUILT", "BRIBERY", "LARCENY", "LEGACY", "LAW", "AVER", "PROOF", "SEAL", "JUDGE", "PLEA" },
                new WordList() { "STAY", "CUSTODY", "WITNESS", "WRIT", "LAWSUIT", "ASSAULT", "PENALTY", "COURT", "FELONY", "USHER", "FORGERY", "GUILT", "BRIBERY", "LARCENY", "LEGACY", "LAW", "AVER", "PROOF", "SEAL", "JUDGE", "PLEA", "ASSIZES", "EMBEZZLEMENT", "TESTIMONY", "ONUS", "INJURY", "ATTORNEY", "SUMMONS", "PERJURY", "SUSPECT", "LAWYER", "TRESPASS", "RESTITUTION", "DURESS", "INQUEST", "ACCESSORY", "BURGLARY", "HEARSAY", "TRESPASSER", "STIPENDIARY", "PROSECUTOR", "CONSPIRACY", "SETTLEMENT", "ROBBERY", "PROSECUTION", "ARREST", "CORRUPTION", "JUSTICE", "TREASON", "UNLAWFUL", "ASSIGNMENT", "PETITION", "JUDICIARY", "IMPRISONMENT", "CONVICT", "COUNSEL", "CONVEYANCING", "EXTRADITION", "MAGISTRATE", "ACQUITTAL", "COLLUSION", "SOLICITOR", "PRISONER", "SUBPOENA", "FRAUDULENT", "JUDGMENT", "COMPENSATION", "CONFESSION", "BARRISTER", "VERDICT", "PROBATION", "ARBITRATION", "SENTENCE", "INDICTMENT", "LITIGATION", "MISDEMEANOUR", "FORECLOSURE", "DETECTIVE", "TRIAL", "ACTION", "CORONER", "DISORDER", "FORENSIC", "REPRIEVE", "AWARD", "FRAUD", "ACCUSED", "SLANDER", "ORDER", "PLAINTIFF", "DEFAMATION", "PAROLE", "DAMAGES", "FISCAL", "REMAND", "CRIMINAL", "DEFENDANT", "INNOCENCE", "CRIME", "PENAL", "EVIDENCE", "POLICE", "PREAMBLE", "APPEAL", "HOMICIDE", "OFFENDER", "OFFENCE", "CHARGE", "BENCH", "DECREE", "DEFENCE" },

                new GridList() {
                "   . .  .    .   ",
                "   L P .WITNESS. ",
                "  .AVER.R  . E   ",
                "   W N .I.PLEA.. ",
                " .ASSAULT. E L C ",
                "  .U.L A.. G . U ",
                ".GUILT.R P A J S ",
                " .STAY.C R.COURT.",
                "  H.W.FELONY.D O ",
                "  E .  N O . G D ",
                ".BRIBERY.FORGERY.",
                "  .    . .   . . "});

                case 9204:
                    return new GameModel(9204, 674, 17, 12,
                new WordList() { "HYSON", "SPRAY", "AMOY", "SET", "TIPS", "URN", "SHOOT", "TASTE", "YEMEN", "KENYA", "CHESTS", "SHRUB", "SAUCERS", "ASSAM", "CEREMONY", "CUP", "TEAPOT", "RITUAL", "BREW", "TEA", "ANHWEI", "ASIA", "BEANS", "MOCHA", "PEKOE", "NICE", "ICED" },
                new WordList() { "HYSON", "SPRAY", "AMOY", "SET", "TIPS", "URN", "SHOOT", "TASTE", "YEMEN", "KENYA", "CHESTS", "SHRUB", "SAUCERS", "ASSAM", "CEREMONY", "CUP", "TEAPOT", "RITUAL", "BREW", "TEA", "ANHWEI", "ASIA", "BEANS", "MOCHA", "PEKOE", "NICE", "ICED", "TANZANIA", "TWANKAY", "HUSKS", "BRAZILIAN", "POUR", "VACUUM", "INSTANT", "ROBUSTA", "TURKISH", "BOSTON", "BISCUITS", "ESPRESSO", "CEYLON", "TEASPOONS", "ASTRINGENCY", "SUGAR", "STIMULATING", "GROUNDS", "TROPICS", "WATER", "CHICORY", "NYASALAND", "ROASTING", "SOUCHONG", "EXTRACTION", "STRAINER", "CULTIVATED", "COLOUR", "LUSHAI", "SAUCER", "TANNIN", "PLANTATION", "GRANULES", "PAKISTAN", "STEEPING", "FORMOSA", "KETTLE", "POWDER", "CANISTER", "MANIPURI", "IRISH", "FILTRATION", "SANDWICHES", "INFUSED", "VOLATILE", "AFTERNOON", "OOLONG", "PERCOLATOR", "TROPICAL", "LIQUID", "JASMINE", "JAVA", "CONGO", "FILTER", "ETHIOPIA", "POWDERED", "INDONESIA", "CAPPUCCINO", "DECOCTION", "EVERGREEN", "CAUCASIA", "CHERRIES", "UGANDA", "AROMA", "FERMENTED", "CHINESE", "BREWED", "GRINDING", "THAILAND", "CAKES", "DRINK", "MILK", "IMPERIAL", "BOILING", "GREEN", "MADAGASCAR", "BEVERAGE", "COLOMBIA", "INDIAN", "INDOCHINA", "CREAM", "CADDIES", "PINHEAD", "BLENDING", "BRICK", "CHINA", "INDIA", "AMERICA", "DARJEELING", "CAMBODIA", "CHEKIANG", "DECAFFEINATED", "BOHEA", "AREA", "CAMELLIA", "AFRICA", "ARABIA", "ARABICA", "COFFEE", "CAFFEINE", "BLACK" },

                new GridList() {
                " . . .      .  . ",
                " N.TASTE.KENYA.C ",
                " I I H....  E  E ",
                ".CUP.RITUAL.M  R ",
                " E.SAUCERS.PEKOE.",
                " . ..BEANS..N  M ",
                " S M .D..A H.. O ",
                " H O  ..AMOY.B N ",
                " O.CHESTS..SPRAY.",
                " O H  E I  O E . ",
                ".TEAPOT.A.ANHWEI.",
                " . .  . .  . .   "});

                case 9206:
                    return new GameModel(9206, 590, 17, 12,
                new WordList() { "ECZEMA", "LOZENGE", "EYES", "VIRUS", "OXYGEN", "BODY", "ANATOMY", "EMBRYO", "NURSE", "PULSE", "REMEDY", "THOMAS", "BURNET", "SALVE", "CLOT", "CURE", "DOSE", "SALK", "PAIN", "BONE", "IODINE", "COLD", "GALEN", "REID", "AIL" },
                new WordList() { "ECZEMA", "LOZENGE", "EYES", "VIRUS", "OXYGEN", "BODY", "ANATOMY", "EMBRYO", "NURSE", "PULSE", "REMEDY", "THOMAS", "BURNET", "SALVE", "CLOT", "CURE", "DOSE", "SALK", "PAIN", "BONE", "IODINE", "COLD", "GALEN", "REID", "AIL", "SCHIZOID", "MURRAY", "INFLUENZA", "LARYNX", "NOSTRUM", "HYSTERICS", "HARVEY", "SYRINGE", "MYOPIA", "DYSLEXIA", "FLOREY", "SPLINT", "NEURITIS", "DRUGS", "HUNTER", "STETHOSCOPE", "PHYSICIAN", "SURGEON", "INSULIN", "COMPRESS", "LISTER", "SULPHA", "ASTHMA", "ABSCESS", "ALLERGY", "HYGIENE", "PATIENT", "RADIOLOGY", "STERILISE", "ANTISEPTIC", "HOSPITAL", "ACUTE", "GERMS", "PARACELSUS", "CAUTERISE", "POULTICE", "ANAESTHETICS", "GASTRIC", "CRAMPS", "DOCTOR", "TENDON", "ANTIDOTE", "ASPIRIN", "MEASLES", "DIAGNOSIS", "OPERATION", "HIPPOCRATES", "ATAXIA", "TABLET", "FRACTURE", "LIGATURE", "INOCULATE", "FORMULA", "COUGH", "OPIATE", "RADIUM", "ANTIBIOTIC", "FORCEPS", "HEART", "ULCER", "PEDIATRICS", "ELIXIR", "DISEASE", "LUMBAGO", "APPENDIX", "AMNESIA", "DELIRIUM", "INFECTION", "VACCINATE", "CHLOROFORM", "DIABETES", "INVALID", "NEURALGIA", "METCHNIKOFF", "SCALPEL", "JENNER", "AMBULANCE", "JAUNDICE", "CARTILAGE", "BROMIDE", "MICROBE", "PENICILLIN", "KOCH", "ADRENALIN", "CHOLERA", "MALARIA", "CLINIC", "MACLEOD", "EPIDEMIC", "MEDICINE", "BANDAGE", "EARACHE", "HEAL" },

                new GridList() {
                "     . .     . . ",
                "     A.SALK.BONE.",
                ".GALEN.A  .D X M ",
                "   ..AIL..BODY.B ",
                " .CLOT.VIRUS.G R ",
                " R O O E..REMEDY.",
                ".ECZEMA.P N..N.O ",
                " I E Y.CURE.C.P. ",
                " D N .  L.THOMAS.",
                " . G.NURSE. L I  ",
                ".EYES.  E.IODINE.",
                "   .    .   . .  "});

                case 9207:
                    return new GameModel(9207, 518, 17, 12,
                new WordList() { "TOKYO", "TROPHY", "SPORT", "CYCLIST", "ROYCROFT", "MOSCOW", "SCULLS", "OLYMPIC", "DISCUS", "SOLO", "WINTER", "MEDLEY", "TEAMMATES", "TORCH", "OATH", "TEAM", "ROME", "SOCCER", "TABLE" },
                new WordList() { "TOKYO", "TROPHY", "SPORT", "CYCLIST", "ROYCROFT", "MOSCOW", "SCULLS", "OLYMPIC", "DISCUS", "SOLO", "WINTER", "MEDLEY", "TEAMMATES", "TORCH", "OATH", "TEAM", "ROME", "SOCCER", "TABLE", "BRONZE", "SWITZERLAND", "BUTTERFLY", "GYMNASTICS", "CZECHOSLOVAKIA", "SUMMER", "FREESTYLE", "HEAVYWEIGHT", "WRESTLER", "YACHTING", "SWIMMER", "AMATEURS", "CEREMONY", "SPRINTER", "COMPETITORS", "HOCKEY", "ARMSTRONG", "RUNNER", "SILVER", "BREASTSTROKE", "ARCHERY", "CUTHBERT", "EQUESTRIAN", "ATHENS", "ROWING", "EMOTIVE", "VOLLEYBALL", "STOCKHOLM", "ATHLETES", "SKATING", "PARIS", "PENTATHLON", "HURDLES", "EUROPE", "BOXER", "CONTENDERS", "HEPTATHLON", "AMSTERDAM", "LIGHTWEIGHT", "MUNICH", "SLALOM", "MARATHON", "MONTREAL", "KONRADS", "WEIGHTLIFTER", "GOULD", "TRAINING", "SKIING", "CHAMPIONS", "STRICKLAND", "CHARLTON", "MEDALLIST", "MELBOURNE", "GAMES", "TRACK", "BACKSTROKE", "SPRINGBOARD", "DIVING", "FRASER", "LONDON", "JACKSON", "DOWNHILL", "CONTENDER", "AWARD", "FIGHT", "LAUREL", "BIATHLON", "ALBERTVILLE", "SAMARANCH", "HELSINKI", "JAVELIN", "CHAMPION", "BASKETBALL", "HAMMER", "DECATHLON", "BOBSLED", "RECORD", "CANOEING", "BERLIN", "MOCKRIDGE", "GOLD", "EXCELLENCE", "FENCING", "BARCELONA", "PEARCE", "COACH", "FLAME", "MEDAL", "HANDBALL", "GREECE", "ACCOLADE" },

                new GridList() {
                "        . .    . ",
                " .      D.SCULLS.",
                ".TABLE. I P  . O ",
                " E  ..MOSCOW.R L ",
                " A.ROME.C R. O O ",
                " M  L D U.TOKYO. ",
                " M.CYCLIST.A C   ",
                " A  M E .E.TORCH.",
                ".TROPHY. A H O   ",
                " E  I .  M . F   ",
                ".SOCCER. .WINTER.",
                " .  .        .   "});

                case 9208:
                    return new GameModel(9208, 532, 17, 12,
                new WordList() { "TETRAZZINI", "INTERMEZZO", "BIZET", "TUTU", "DONIZETTI", "DUETS", "CHORUS", "TRIO", "VALOIS", "ULANOVA", "OPERETTA", "LIBRETTO", "THEATRE", "SINGER", "MANON", "BORODIN", "CARMEN", "ARIA" },
                new WordList() { "TETRAZZINI", "INTERMEZZO", "BIZET", "TUTU", "DONIZETTI", "DUETS", "CHORUS", "TRIO", "VALOIS", "ULANOVA", "OPERETTA", "LIBRETTO", "THEATRE", "SINGER", "MANON", "BORODIN", "CARMEN", "ARIA", "STRAUSS", "DEBUSSY", "NUREYEV", "STANISLAVSKY", "FONTEYN", "FAUST", "SCENERY", "NIJINSKY", "TCHAIKOVSKY", "SYLPHIDES", "COSTUME", "QUARTET", "OVERTURE", "TOUMANOVA", "DUET", "PIROUETTE", "ORPHEUS", "MASSENET", "CARUSO", "SOPRANO", "TANNHAUSER", "BRITTEN", "CURTAIN", "MASSINE", "PAVLOVA", "CONTRALTO", "PROSCENIUM", "SUTHERLAND", "RIGOLETTO", "DANSEUR", "GOUNOD", "METROPOLITAN", "CHOREOGRAPHY", "ORCHESTRA", "PASTORALE", "APPLAUSE", "TERPSICHORE", "PETROUCHKA", "IMPRESARIO", "MIGNON", "WAGNER", "BEETHOVEN", "ENTRECHAT", "OTHELLO", "GREASEPAINT", "ARABESQUE", "PUCCINI", "BARITONE", "HARLEQUIN", "PROGRAMME", "JETE", "GLUCK", "LEOTARD", "SHEARER", "ENTRANCE", "FLAGSTAD", "CHARPENTIER", "FALSTAFF", "MASCAGNI", "OPERA", "LOHENGRIN", "HELPMANN", "REHEARSE", "BALLETOMANE", "PERFORMANCE", "SERENADE", "GISELLE", "BALLET", "CALLAS", "SIEGFRIED", "GRECO", "AUDIENCE", "COPPELIA", "BARCAROLLE", "FIREBIRD", "BALLERINA", "BALANCHINE", "FIDELIO", "ADAGIO", "MELBA", "FAME", "AIDA" },

                new GridList() {
                "    .    .   . . ",
                ".CARMEN.LIBRETTO.",
                "    A  A N   E P ",
                " .SINGER.THEATRE.",
                " D  O .I E   R R ",
                ".ULANOVA.R   A E ",
                " E .. A. M.BIZET.",
                ".TUTU.L  E   Z T ",
                " S R.DONIZETTI.A ",
                " . I  I  Z   N . ",
                ".CHORUS.BORODIN. ",
                "   .  .  .   .   "});

                case 9209:
                    return new GameModel(9209, 608, 17, 12,
                new WordList() { "SMUTS", "TNT", "YPRES", "ARMY", "TURRET", "ENEMY", "FORAY", "FORTIFY", "MONS", "ONSET", "DIVISIONS", "FORT", "CORPS", "ARMOUR", "SLIM", "ALLENBY", "UNIFORM", "PATROL", "ACTION", "BREN", "ALAMO", "RIFLE", "MEDAL" },
                new WordList() { "SMUTS", "TNT", "YPRES", "ARMY", "TURRET", "ENEMY", "FORAY", "FORTIFY", "MONS", "ONSET", "DIVISIONS", "FORT", "CORPS", "ARMOUR", "SLIM", "ALLENBY", "UNIFORM", "PATROL", "ACTION", "BREN", "ALAMO", "RIFLE", "MEDAL", "DUTY", "SCHWARZKOPF", "BADAJOZ", "ZEEBRUGGE", "BLITZKRIEG", "BAYONETS", "ASSAULT", "MONTGOMERY", "INFANTRY", "TRANSPORT", "MILITARY", "COMPANY", "PATTON", "MORTARS", "SALVO", "TANKS", "SORTIE", "TOBRUK", "ARTILLERY", "BULLETS", "SQUADRON", "SOMME", "LUCKNOW", "TACTICS", "TROOPER", "PRIVATE", "EQUIPMENT", "LIEUTENANT", "PLATOON", "GUNNER", "AGINCOURT", "SAPPER", "GUARDSMAN", "SERGEANT", "BOMBS", "BATTLE", "CHOPPERS", "FUSILIER", "EISENHOWER", "BATTALION", "SHERMAN", "PERSHING", "DRIVER", "TRENCH", "PARACHUTE", "DUNKIRK", "CROMWELL", "REGIMENT", "FORCES", "ROMMEL", "SOLDIER", "NCO", "MAJOR", "CANNON", "ARSENAL", "CAPTAIN", "CORPORAL", "NAPOLEON", "ENGINEERS", "SCRIMMAGE", "HELICOPTER", "CULLODEN", "FIGHTER", "GLIDERS", "CLIVE", "SIEGE", "KITCHENER", "FLANDERS", "GRENADES", "CATERPILLAR", "COMMAND", "COMMANDER", "COLONEL", "ALEXANDER", "CAMPAIGN", "RIFLEMAN", "GALLIPOLI", "LENINGRAD", "GENERAL", "HANNIBAL", "MAFEKING", "FLODDEN", "OFFICER", "BRIGADIER", "KHAKI", "BRIGADE", "DEFENCE" },

                new GridList() {
                "    . . .     .  ",
                ".FORT.R F .ARMY. ",
                "   .UNIFORM.. P  ",
                "  . R.F R ..F R  ",
                ".PATROL.ALAMO.E  ",
                "  R.ENEMY.CORPS. ",
                ".SMUTS.E..TNT... ",
                "  O .E.DIVISIONS.",
                "  U  T A  O.F  L ",
                ".BREN.ALLENBY. I ",
                "  .    .  . .  M ",
                "               . "});

                case 9210:
                    return new GameModel(9210, 626, 17, 12,
                new WordList() { "FIZZY", "DRY", "SHERRY", "TOAST", "VAT", "VAULT", "MANZANILLA", "SWEET", "TASTE", "PORT", "PRESS", "ASTI", "NEGUS", "BRANDY", "STILL", "MULL", "SPAIN", "WINE", "SEC", "DREGS", "DRINK", "RHINE", "MARC", "FRANCE", "CELLAR" },
                new WordList() { "FIZZY", "DRY", "SHERRY", "TOAST", "VAT", "VAULT", "MANZANILLA", "SWEET", "TASTE", "PORT", "PRESS", "ASTI", "NEGUS", "BRANDY", "STILL", "MULL", "SPAIN", "WINE", "SEC", "DREGS", "DRINK", "RHINE", "MARC", "FRANCE", "CELLAR", "PARTY", "DIONYSUS", "WHISKY", "TOKAY", "WINERY", "ITALY", "BURGUNDY", "HUNGARY", "MUSCAT", "VERMOUTH", "BOUQUET", "PORTUGUESE", "ENOLOGY", "VINEYARD", "CRUSH", "SUGAR", "GERMANY", "FESTIVITIES", "DESSERT", "EXTRACT", "VINTNER", "SAUTERNE", "CURRANT", "GLASSES", "OLOROSO", "WHITE", "AMOROSO", "COWSLIP", "LIQUEUR", "PORTUGAL", "BOTTLE", "SCOTCH", "RETSINA", "VINCENT", "CRUSHING", "BANQUET", "PRESSED", "MAGNUM", "CUVEE", "CHARDONNAY", "BOURBON", "VINTAGE", "BOTTLED", "BORDEAUX", "ELDERBERRY", "GRAPES", "CALVADOS", "SPARKLING", "BACCHUS", "MOSELLE", "REISLING", "HUNGARIAN", "GOBLET", "BARRELS", "MARSALA", "RHUBARB", "BEAUJOLAIS", "AMONTILLADO", "AMPHORA", "CHIANTI", "ITALIAN", "CLARET", "AROMA", "JUICE", "FERMENTED", "FINO", "DRAMBUIE", "SICILIAN", "COOLER", "FORTIFIED", "CELEBRATION", "JEROBOAM", "ARGOL", "TABLE", "GINGER", "CHABLIS", "LIEBFRAUMILCH", "BEVERAGE", "FLAGON", "ALCOHOL", "ARMAGNAC", "DECANTED", "CHAMPAGNE", "DANDELION", "MEDOC", "CALIFORNIA", "GREEK", "MADEIRA", "MALAGA", "PLEDGE", "BODEGA", "CARAFE", "AGED" },

                new GridList() {
                " .   . .   .   . ",
                ".PRESS.FRANCE. M ",
                " O   P I   E . A ",
                " R .MANZANILLA.R ",
                " T D I Z . L.SEC.",
                " .BRANDY.TOAST.. ",
                " S I . . A.RHINE.",
                ".WINE. M S .E.E  ",
                " E K.VAULT.DREGS.",
                " E . A L E  R U  ",
                " T .STILL.DRY.S  ",
                " .   . .    . .  "});

                case 9211:
                    return new GameModel(9211, 602, 17, 12,
                new WordList() { "SPITZ", "SPHYNX", "SCHNAUZER", "SKYE", "MACAVITY", "ASTA", "CATS", "CROFTS", "MANX", "FLUSH", "CLAWS", "SALUKI", "KORAT", "CHOW", "DOGS", "LASSIE", "BOXER", "WHINE", "COON", "SPANIEL", "FELIS", "NANA", "HAIR", "LAIKA" },
                new WordList() { "SPITZ", "SPHYNX", "SCHNAUZER", "SKYE", "MACAVITY", "ASTA", "CATS", "CROFTS", "MANX", "FLUSH", "CLAWS", "SALUKI", "KORAT", "CHOW", "DOGS", "LASSIE", "BOXER", "WHINE", "COON", "SPANIEL", "FELIS", "NANA", "HAIR", "LAIKA", "BORZOI", "HUSKY", "PUPPY", "TABBY", "LOYAL", "SETTER", "SAMOYED", "MONTMORENCY", "TURKISH", "LITTERS", "ABYSSINIAN", "CYMRIC", "GREYHOUND", "BASSET", "PYRENIAN", "PUPPIES", "OTTERHOUND", "SEALYHAM", "ROTTWEILER", "KITTEN", "TORTOISESHELL", "WHIPPET", "BURMESE", "POINTER", "ARGOS", "HOUND", "MIAOW", "THOMASINA", "TONKINESE", "WOLFHOUND", "CARNIVORES", "HIMALAYAN", "RETRIEVER", "SPRINGER", "MALTESE", "MASTIFF", "SIAMESE", "ESKIMO", "SOMALI", "CERBERUS", "PERSIAN", "TERRIER", "ALSATIAN", "MOGGIES", "GUARD", "DACHSHUND", "BLOODHOUND", "CHIHUAHUA", "WEIMARANER", "BEDLINGTON", "POMERANIAN", "SCHIPPERKE", "KEESHOND", "PAPILLON", "PEKINESE", "SHEEPDOG", "BULLDOG", "GUIDE", "BASENJI", "ANGORA", "BIRMAN", "POODLE", "DALMATIAN", "CHESHIRE", "AFFENPINSCHER", "CORGI", "DINGO", "GRIFFON", "HARRIER", "BALINESE", "DOBERMAN", "MEHITABEL", "CAIRN", "FIGARO", "KENNEL", "PARIAH", "LABRADOR", "CAMEO", "BRIARD", "CANINE", "BARK", "DHOLE", "COLLIE", "KELPIE", "ARCHANGEL", "CHINCHILLA", "PEDIGREED", "AFGHAN", "FELINE", "HEELER", "DANE", "RIDGEBACK", "AIREDALE", "CANIDAE", "FELIDAE" },

                new GridList() {
                "   .     .  .    ",
                "   S . ..CHOW.   ",
                ".CLAWS.C A..HAIR.",
                " . L.CROFTS.I  . ",
                ".FLUSH.O.SPANIEL.",
                " E K.NANA.H E. A ",
                ".LAIKA..SKYE.K S ",
                " I . U  T N.DOGS.",
                ".SPITZ.MANX. R I ",
                " .   E  . .  A E ",
                ".BOXER.MACAVITY. ",
                "     .       .   "});

                case 9212:
                    return new GameModel(9212, 576, 17, 12,
                new WordList() { "BLIZZARD", "BREEZE", "NORWAY", "SNOW", "SCOTT", "MOSSES", "FURS", "TENT", "WALRUS", "SOMERSET", "OWL", "NUNATAKS", "KAYAK", "FOX", "ESKIMOS", "ATLAS", "DOGS", "NANSEN", "NOME", "BASE", "ERMINE", "BEAR", "ICE" },
                new WordList() { "BLIZZARD", "BREEZE", "NORWAY", "SNOW", "SCOTT", "MOSSES", "FURS", "TENT", "WALRUS", "SOMERSET", "OWL", "NUNATAKS", "KAYAK", "FOX", "ESKIMOS", "ATLAS", "DOGS", "NANSEN", "NOME", "BASE", "ERMINE", "BEAR", "ICE", "HUTS", "SOUTH", "THURSTON", "MACKENZIE", "LIVERWORTS", "MAWSON", "SNOWDRIFTS", "TRACTORS", "METEOROLOGY", "HUDSON", "ASTROFIXES", "CREVASSES", "NORTH", "OATES", "TUNDRA", "PENGUINS", "VESTFOLD", "DAVIS", "SEALS", "PETRELS", "SORSDAL", "VIKINGS", "TEMPERATURE", "SPITSBERGEN", "WILDERNESS", "AMUNDSEN", "BARENTS", "SWEDEN", "LAPPS", "CRAMPONS", "THERMOMETER", "AURORA", "BARROW", "IGLOOS", "WHALES", "GEOLOGIST", "WEATHER", "EXPLORER", "EXPEDITION", "CHRONOMETER", "FJORDS", "LARSEN", "ANTARCTIC", "ROOKERIES", "SHACKLETON", "THEODOLITE", "BELUGAS", "BALLOONS", "BANKS", "FLOES", "NARWHAL", "BAROMETER", "POLAR", "CARIBOU", "HURRICANE", "MACQUARIE", "LICHENS", "ARCTIC", "POLE", "AIRCRAFT", "CLIMATE", "LEMMING", "SIBERIA", "ANORAK", "ELLESMERE", "GLACIERS", "PEMMICAN", "FAHRENHEIT", "BLUBBER", "CREVICE", "CAMP", "ALASKA", "DIESEL", "SLEDGE", "FRANKLIN", "ICEBERGS", "RADIO", "WILDLIFE", "AMPHIBIAN", "LABRADOR", "REINDEER", "GREENLAND", "FINLAND", "CIRCLE", "HEARD", "BAFFIN", "CANADA", "ADELIE" },

                new GridList() {
                " .  .     . .  . ",
                ".NANSEN...BASE.I ",
                " U  C .BEAR.O  C ",
                " N.NOME.S.ERMINE.",
                " A .T   K E E  . ",
                ".TENT.BLIZZARD.M ",
                " A O.O .M E S  O ",
                " K R W.FOX. E  S ",
                " S.WALRUS..ATLAS.",
                " . A . R.   .  E ",
                ".KAYAK.SNOW.DOGS.",
                "   .   .       . "});

                case 9301:
                    return new GameModel(9301, 636, 17, 12,
                new WordList() { "SALZBURG", "BRAZIL", "YORK", "EGYPT", "NORWAY", "CUSTOMS", "ITALY", "BUS", "TAX", "YACHT", "VOYAGE", "BOSTON", "TRIP", "TICKETS", "ATHENS", "SHIP", "JET", "BOAT", "GIFT", "ASIA", "VENICE", "CAR", "CHINA", "BALI", "CAB" },
                new WordList() { "SALZBURG", "BRAZIL", "YORK", "EGYPT", "NORWAY", "CUSTOMS", "ITALY", "BUS", "TAX", "YACHT", "VOYAGE", "BOSTON", "TRIP", "TICKETS", "ATHENS", "SHIP", "JET", "BOAT", "GIFT", "ASIA", "VENICE", "CAR", "CHINA", "BALI", "CAB", "ARIZONA", "TOKYO", "SWITZERLAND", "ZIMBABWE", "GETTYSBURG", "JOURNEY", "YELLOWSTONE", "FERRY", "PASSPORT", "TRANSPORT", "BOSPHORUS", "YORKSHIRE", "VISA", "DONKEY", "ITINERARY", "GERMANY", "BROADWAY", "HOLIDAYS", "OVERSEAS", "STREAMERS", "HONOLULU", "MOTORBOAT", "STEAMSHIP", "PORTUGAL", "HOUSEBOAT", "CRUISE", "TRAVEL", "TRAWLER", "BUDAPEST", "STEAMER", "PARIS", "SPAIN", "TRAIN", "SNOWMOBILE", "EUROPE", "MANHATTAN", "SCOTLAND", "DEVON", "DEPARTURE", "ETNA", "SCHOONER", "HOVERCRAFT", "RIVERCRAFT", "MEXICO", "SINGAPORE", "CORNWALL", "PHILIPPINES", "LONDON", "BRITAIN", "WINDJAMMER", "ANDES", "DUBLIN", "LAUNCH", "INDONESIA", "HELICOPTER", "CARAVAN", "FLIGHT", "CATAMARAN", "GREENWICH", "AIRCRAFT", "THAILAND", "LINER", "BALLOON", "GONDOLA", "LUGGAGE", "DJAKARTA", "FAREWELL", "AEROPLANE", "KOREA", "PADDLEBOAT", "COCKLESHELL", "BERLIN", "MANILA", "AMPHIBIAN", "AIRLINE", "BANGKOK", "HOLLAND", "NILE", "FLORENCE", "CANOE", "CALIFORNIA", "ENGLAND", "FINLAND", "FLORIDA", "IRELAND", "NIAGARA", "IDAHO", "INDIA", "FRANCE", "AMERICA", "AFRICA", "GREECE", "CANADA" },

                new GridList() {
                " . .    .   .  . ",
                ".VENICE.B .ITALY.",
                " O O  .CAR. R  A ",
                ".YORK.  L.SHIP.C ",
                " A W .CHINA.P  H ",
                " G A A .. L .JET.",
                ".EGYPT.BRAZIL. . ",
                " . . H U  B  B A ",
                ".TICKETS.CUSTOMS.",
                " A A N .  R  A I ",
                " X.BOSTON.GIFT.A ",
                " . . .    .  . . "});

                case 9302:
                    return new GameModel(9302, 524, 17, 12,
                new WordList() { "KUNZITE", "ONYX", "RUBY", "AMAZONITE", "AMETHYST", "BEAUTY", "RARITY", "PYROPE", "TRINKETS", "CROWN", "WATCH", "GARNET", "CARAT", "LOCKET", "COIN", "AGATE", "BUCKLE", "CORAL", "FIRE" },
                new WordList() { "KUNZITE", "ONYX", "RUBY", "AMAZONITE", "AMETHYST", "BEAUTY", "RARITY", "PYROPE", "TRINKETS", "CROWN", "WATCH", "GARNET", "CARAT", "LOCKET", "COIN", "AGATE", "BUCKLE", "CORAL", "FIRE", "IVORY", "SARDONYX", "CRYSTAL", "STONES", "TURQUOISE", "TORQUE", "BERYL", "CLUSTER", "MOONSTONE", "SNUFFBOX", "TREASURE", "CORUNDUM", "SILVER", "TRINKET", "PLATINUM", "JEWELLERY", "AVENTURINE", "CHRISOBERYL", "AMULET", "PRECIOUS", "COLOUR", "RHINESTONE", "TOURMALINE", "CORONET", "BLOODSTONE", "SERPENTINE", "OPAQUE", "POLISH", "TRANSLUCENCE", "SOLITAIRE", "HATPIN", "SPINEL", "PERIDOT", "AIGRETTE", "CHARMS", "JASPER", "PEARLS", "MARCASITE", "MORGANITE", "SINHALITE", "CHALCEDONY", "OLIVINE", "PENDANT", "EARRINGS", "MINERALS", "NEPHRITE", "SAPPHIRE", "CUFFLINKS", "PAILLETTE", "CLASP", "TIARA", "COLLARS", "FASHION", "DIAMONDS", "ANKLET", "ALABASTER", "AQUAMARINE", "DECORATION", "ALEXANDRITE", "BRILLIANT", "CAIRNGORM", "OPAL", "EMERALDS", "HAIRPIN", "BROOCH", "SCARAB", "LABRADORITE", "DURABLE", "CARBUNCLE", "OPALESCENCE", "COMB", "MALACHITE", "BEADS", "BRACELET", "GEM", "CHOKER", "GOLD", "ALMANDINE", "CARNELIAN", "AMBER", "CAMEO", "CHAIN", "FILIGREE", "BANGLE", "DIADEM", "NECKLACE", "JADE" },

                new GridList() {
                "  .         .    ",
                ".CORAL. . . F    ",
                "  N   B A A I  . ",
                ".PYROPE.M.GARNET.",
                "  X.  A A A E. R ",
                " ..C.KUNZITE.L I ",
                " C A  T O E.COIN.",
                ".RARITY.N .R C K ",
                " O A  . I.BUCKLE.",
                ".WATCH. T  B E T ",
                " N . .AMETHYST.S ",
                " .      .  . . . "});

                case 9303:
                    return new GameModel(9303, 654, 17, 12,
                new WordList() { "BUY", "PROXY", "PAY", "SOU", "ANNUITY", "SECURITY", "PENNY", "SALARY", "BONUS", "NOTES", "QUOTE", "POUNDS", "YIELD", "NET", "PISTOLE", "AUDIT", "DUCAT", "RUPEE", "ECU", "ROUBLE", "TRADE", "MARGIN", "DINERO", "LIRA", "AID" },
                new WordList() { "BUY", "PROXY", "PAY", "SOU", "ANNUITY", "SECURITY", "PENNY", "SALARY", "BONUS", "NOTES", "QUOTE", "POUNDS", "YIELD", "NET", "PISTOLE", "AUDIT", "DUCAT", "RUPEE", "ECU", "ROUBLE", "TRADE", "MARGIN", "DINERO", "LIRA", "AID", "QUETZAL", "CRUZEIRO", "MONEY", "ASSETS", "TURNOVER", "LIQUIDITY", "INVESTMENT", "FORTUNES", "DISCOUNT", "INTEREST", "SUCRE", "TIGHT", "POUND", "WAGES", "DEPOSIT", "PIASTRE", "HALFPENNY", "CONTRACT", "ACCOUNT", "CENTAVO", "REVENUE", "ESCUDO", "KORUNA", "LEGACY", "PESETA", "PROFIT", "SOVEREIGN", "VENDOR", "WALLET", "SIXPENCE", "JACOBUS", "OVERDRAFT", "CENT", "DRAW", "BUDGET", "DOUBLOON", "SHEKELS", "GOURDE", "MARKET", "BULLION", "MILREIS", "MORTGAGE", "SHARE", "KRONER", "TENDER", "BOLIVER", "GUARANI", "CREDITOR", "CARTWHEEL", "CASH", "AWARD", "COLON", "KRONA", "CENTIME", "RECEIPT", "FARTHING", "NAPOLEON", "SHILLING", "GUILDER", "MOIDORE", "CHEQUE", "CREDIT", "JUDGE", "SCHILLING", "COIN", "CAPITAL", "BROKER", "INCOME", "WINDFALL", "DEBIT", "LEMPIRA", "PFENNIG", "EARN", "EXCHANGE", "ADVANCE", "BROKE", "DINAR", "PRICE", "DOLLAR", "KOPECK", "CORDOBA", "FRANC", "OFFER", "BARGAIN", "DIME", "NICKEL", "DRACHMA", "FINANCE", "CHANGE", "BALBAO", "BALANCE" },

                new GridList() {
                "    .  .    . .  ",
                " .MARGIN.POUNDS. ",
                " D  O  O . .E A  ",
                " I.DUCAT.PISTOLE.",
                " N  B  E E E. A  ",
                " E .L. S.N C .R  ",
                ".RUPEE..ANNUITY. ",
                " O R.C.BUY.R R.. ",
                " .BONUS.D.LIRA.A ",
                "   X .O I  T D I ",
                ".PAY.QUOTE.YIELD.",
                "   .  . .  . . . "});

                case 9304:
                    return new GameModel(9304, 676, 17, 12,
                new WordList() { "OUTSIZE", "TROY", "TUN", "KILOHERTZ", "WATT", "MOIETY", "DYNE", "UNIT", "YARD", "STEP", "STONE", "QUARTO", "PINT", "FOOT", "BUSHEL", "PROOF", "OHM", "POCKET", "CASK", "TIERCE", "FEET", "POLE", "DRAM", "REAM", "ERG", "ACRE", "KEG" },
                new WordList() { "OUTSIZE", "TROY", "TUN", "KILOHERTZ", "WATT", "MOIETY", "DYNE", "UNIT", "YARD", "STEP", "STONE", "QUARTO", "PINT", "FOOT", "BUSHEL", "PROOF", "OHM", "POCKET", "CASK", "TIERCE", "FEET", "POLE", "DRAM", "REAM", "ERG", "ACRE", "KEG", "QUANTITY", "VOLT", "QUANTUM", "GROSS", "QUART", "YARDSTICK", "PENNYWEIGHT", "HEAVYWEIGHT", "MINUTE", "POTTLE", "YARDWAND", "KILOWATT", "SPOONFUL", "OCTANT", "CELSIUS", "QUARTER", "EQUIDISTANT", "QUARTERN", "POUND", "AVOIRDUPOIS", "SHEET", "SCRUPLE", "DIVISION", "MUTCHKIN", "MEASURE", "OCTAVE", "WEIGHT", "QUIRE", "ISOMETRIC", "MILESTONE", "THERMOMETER", "QUADRUPLE", "OUNCE", "FURLONG", "TARE", "PUNCHEON", "ALTIMETER", "AMPLITUDE", "BISEGMENT", "KILOCYCLE", "MODICUM", "TONNAGE", "LITRE", "CENTIMETRE", "PLATEFUL", "FATHOM", "METRIC", "DIMENSION", "CENTILITRE", "ROOD", "DISTANCE", "MEGACYCLE", "MINIM", "SECOND", "FOOLSCAP", "AREOMETER", "KILOMETRE", "AMP", "CARAT", "NOGGIN", "HECTOGRAM", "ELEPHANT", "BUNDLE", "GAUGE", "GRAMME", "SHEKEL", "HOGSHEAD", "KILOGRAM", "CUBIC", "GRAIN", "FAHRENHEIT", "HECTARE", "MILLIGRAM", "AMPERE", "FIRKIN", "GALLON", "LEAGUE", "IMPERIAL", "CENTIGRADE", "PERCH", "EQUIBALANCE", "MICROFARAD", "INCH", "MILE", "BARREL", "DRACHM", "GILL", "PECK", "CHAIN", "MILEAGE", "BRACE", "ACREAGE", "BALE", "CABLE" },

                new GridList() {
                "   . . . . .     ",
                "   B D.PROOF.    ",
                " .QUARTO.U O .   ",
                " C S A L T.OHM.. ",
                " A.H.M E S T O S ",
                ".STEP....I .PINT.",
                ".KILOHERTZ.  E.O ",
                " .E.C R.REAM.TUN.",
                "  R.KEG.O.C.DYNE.",
                "  C E ..YARD..I. ",
                ".FEET.  . E.WATT.",
                "  . .     .   .  "});

                case 9305:
                    return new GameModel(9305, 632, 17, 12,
                new WordList() { "SPRITZ", "SYRUP", "BRAZIL", "NUTS", "YOGURT", "PASTRY", "RUSSE", "TARTS", "SWEETS", "GUMS", "TAFFY", "MINTS", "TORTE", "FLOSS", "FRUIT", "SORBET", "DROPS", "TRUFFLES", "PIES", "BARS", "SIMNEL", "TRIFLE", "PEEL" },
                new WordList() { "SPRITZ", "SYRUP", "BRAZIL", "NUTS", "YOGURT", "PASTRY", "RUSSE", "TARTS", "SWEETS", "GUMS", "TAFFY", "MINTS", "TORTE", "FLOSS", "FRUIT", "SORBET", "DROPS", "TRUFFLES", "PIES", "BARS", "SIMNEL", "TRIFLE", "PEEL", "MARZIPAN", "WALNUTS", "MOUSSE", "TURNOVERS", "HONEY", "BULLSEYES", "CLUSTERS", "FLUMMERY", "STREUSEL", "DOUGHNUTS", "DESSERTS", "SUCROSE", "BISCUITS", "HUMBUGS", "ALLSORTS", "STRUDEL", "NOUGAT", "MOLASSES", "BUTTERSCOTCH", "CUSTARD", "PUFFS", "FRUCTOSE", "PRESERVES", "JUJUBES", "JUNKET", "STRAWBERRIES", "STOLLEN", "FROSTING", "ROLLS", "BROWNIES", "CRESCENTS", "PASTILLES", "PEPPERMINTS", "MARSHMALLOWS", "CONFECTIONERY", "DUMPLINGS", "CONSERVE", "SPONGE", "SUNDAE", "WAFERS", "JELLYBEANS", "BONBONS", "BRITTLE", "GLUCOSE", "JUMBLES", "POPCORN", "SHERBET", "SOUFFLE", "NAPOLEONS", "PINWHEELS", "GATEAU", "SHORTCAKE", "COMFIT", "SUGARCANE", "FONDANT", "MERINGUE", "PRALINES", "CHOCOLATES", "FONDUE", "COOKIES", "PUDDING", "WAFFLES", "BUBBLEGUM", "FRUITCAKE", "MELON", "KUCHEN", "LOLLIES", "PARFAIT", "TAPIOCA", "CINNAMON", "LOLLIPOP", "MINCEMEAT", "MACAROON", "GELATIN", "VANILLA", "CARAMELS", "PANCAKES", "TOFFEE", "CAKES", "FUDGE", "CANDIES", "JELLIES", "PRALINE", "PINEAPPLE", "ALASKA", "GINGER", "COOKIE", "BOMBE", "CAROB", "CREAM", "ICING", "LICORICE", "GINGERBREAD", "ICECREAM", "ECLAIR", "DRAGEE" },

                new GridList() {
                "    .  .  . .  . ",
                ".DROPS.B .SORBET.",
                " .  E.TAFFY.U  R ",
                " P  E .R  R.S  U ",
                " A.FLOSS.GUMS. F ",
                " S  . W.S.PIES.F ",
                ".TRIFLE.I .N.P L ",
                " R  R E M .TORTE.",
                ".YOGURT.NUTS.I S ",
                " .  I S E  . T . ",
                ".TARTS. L.BRAZIL.",
                "    .   .    .   "});

                case 9306:
                    return new GameModel(9306, 554, 17, 12,
                new WordList() { "BUZZARDET", "EPIZOON", "ZORAPTERA", "DAYFLY", "ZEUGLOPTERA", "TAU", "TSETSE", "BOTFLY", "MAYBUG", "WASP", "THRIPS", "MANTIS", "TERMITE", "MITE", "DIPTERANS", "APHIS", "BORER", "LEMA" },
                new WordList() { "BUZZARDET", "EPIZOON", "ZORAPTERA", "DAYFLY", "ZEUGLOPTERA", "TAU", "TSETSE", "BOTFLY", "MAYBUG", "WASP", "THRIPS", "MANTIS", "TERMITE", "MITE", "DIPTERANS", "APHIS", "BORER", "LEMA", "BUTTERFLY", "MOSQUITO", "LOCUST", "CHRYSALIS", "BLOWFLY", "GNATS", "LOUSE", "DYNASTIDAN", "MOTH", "MYRIAPOD", "KATYDID", "VESPA", "BOT", "BURNET", "CHURRWORM", "CHRYSOMELA", "LAMPFLY", "PUPA", "NOCTURNA", "FRITILLARY", "TARANTULA", "BRIMSTONE", "DERMESTES", "ORTHOPTERA", "NEUROPTERA", "TETRAPOD", "FIREFLY", "ACARUS", "COCCUS", "GADFLY", "HORNET", "GRASSHOPPER", "ENTOMOLITE", "MULTIPED", "GALLFLY", "WEEVIL", "PARASITE", "EMMET", "BLUEBOTTLE", "SKIPPER", "MAGGOT", "LADYBIRD", "PUPIPARA", "ROTIFER", "SPIDER", "VORTICELLA", "ANTENNA", "TICK", "SPARKLER", "HOPPER", "ROTIFERA", "COCOON", "EARWIG", "MIDGET", "DIPTERA", "ANOPHELES", "HEMIPTERA", "LONGICORN", "COLEOPTERA", "LEPIDOPTERA", "DUMBLEDOR", "WHIRLIGIG", "WOODLICE", "LARVAE", "COMMA", "DRONE", "FLIES", "CATERPILLAR", "CRICKET", "SCARAB", "COCKTAIL", "COLORADO", "CENTIPEDE", "DORBEETLE", "MICROBE", "BEDBUG", "BEETLE", "CADDIS", "BOMBARDIER", "BEEHIVE", "BULLHEAD", "EPHEMERA", "COCKROACH", "JIGGER", "DAPHNIA", "EPEIRID", "MIDGE", "CHIGOE", "CHIGGER", "ARACHNID", "COCHINEAL", "MILLEPEDE", "COCCINELLA", "COCKCHAFER", "CHAFER", "CICINDELA", "CICADA", "BEE" },

                new GridList() {
                " .        .      ",
                ".BORER.EPIZOON.. ",
                " U    B . O  . D ",
                ".ZEUGLOPTERA.M I ",
                " Z .  T E A.WASP.",
                " A M  F R P  N T ",
                " R A .L M.TSETSE.",
                ".DAYFLY.I E  I R ",
                " E B E..THRIPS.A ",
                ".TAU.MITE.A  . N ",
                " . G A  . .APHIS.",
                "   . .         . "});

                case 9307:
                    return new GameModel(9307, 610, 17, 12,
                new WordList() { "BRAZIL", "URUGUAY", "TANZANIA", "BELIZE", "TURKEY", "VENEZUELA", "EGYPT", "SYRIA", "ITALY", "YEMEN", "KENYA", "AUSTRIA", "LIBYA", "SUDAN", "PERU", "QATAR", "MALTA", "CUBA", "IRAN", "IRAQ", "FIJI" },
                new WordList() { "BRAZIL", "URUGUAY", "TANZANIA", "BELIZE", "TURKEY", "VENEZUELA", "EGYPT", "SYRIA", "ITALY", "YEMEN", "KENYA", "AUSTRIA", "LIBYA", "SUDAN", "PERU", "QATAR", "MALTA", "CUBA", "IRAN", "IRAQ", "FIJI", "CYPRUS", "SWAZILAND", "ZIMBABWE", "NORWAY", "MOZAMBIQUE", "VANUATU", "GUYANA", "HUNGARY", "MAURITIUS", "CZECHOSLOVAKIA", "KUWAIT", "TUNISIA", "PARAGUAY", "GERMANY", "TOGO", "BOTSWANA", "MALAYSIA", "LUXEMBOURG", "SEYCHELLES", "COMOROS", "LESOTHO", "PORTUGAL", "BHUTAN", "BURUNDI", "VIETNAM", "HONDURAS", "AUSTRALIA", "SWEDEN", "SPAIN", "LAOS", "PAKISTAN", "ANTIGUA", "BURMA", "DJIBOUTI", "MAURITANIA", "BRUNEI", "MEXICO", "SINGAPORE", "NETHERLANDS", "PHILIPPINES", "RWANDA", "MOROCCO", "SOMALIA", "GUATEMALA", "AFGHANISTAN", "CONGO", "HAITI", "GUINEA", "ISRAEL", "MALAWI", "ETHIOPIA", "ARGENTINA", "INDONESIA", "CAMEROON", "COLUMBIA", "MONGOLIA", "BELGIUM", "BOLIVIA", "ECUADOR", "ROMANIA", "UGANDA", "SENEGAL", "JORDAN", "POLAND", "NICARAGUA", "BARBADOS", "BULGARIA", "THAILAND", "NIGER", "BAHAMAS", "PANAMA", "DENMARK", "LEBANON", "BENIN", "GABON", "JAPAN", "NEPAL", "MADAGASCAR", "DOMINICA", "ANGOLA", "BANGLADESH", "NIGERIA", "MALI", "BAHRAIN", "FINLAND", "IRELAND", "CHINA", "GHANA", "INDIA", "FRANCE", "GRENADA", "CAMBODIA", "ALGERIA", "LIBERIA", "GAMBIA", "ALBANIA", "ICELAND", "JAMAICA", "GREECE", "CHILE", "CANADA", "CHAD" },

                new GridList() {
                "  .  .   . . . . ",
                "  M  B . S C T S ",
                ".QATAR.V.URUGUAY.",
                "  L  A E D B R R ",
                " .TANZANIA.A K I ",
                "  A .I E N . E A ",
                "  .BELIZE.LIBYA. ",
                "  P G. U F T . I ",
                ".KENYA.E.IRAQ. R ",
                "  R P  L J L   A ",
                ".AUSTRIA.I.YEMEN.",
                "  . .  . . .   . "});

                case 9308:
                    return new GameModel(9308, 598, 17, 12,
                new WordList() { "VELAZQUEZ", "GREUZE", "WATTS", "CEZANNE", "SCOTT", "ROMNEY", "LELY", "WEYDEN", "DYCK", "ERNST", "EYCK", "STEER", "RUBENS", "VERNET", "HEYDEN", "SARGENT", "HALS", "REDON", "HOOCH", "BRIL" },
                new WordList() { "VELAZQUEZ", "GREUZE", "WATTS", "CEZANNE", "SCOTT", "ROMNEY", "LELY", "WEYDEN", "DYCK", "ERNST", "EYCK", "STEER", "RUBENS", "VERNET", "HEYDEN", "SARGENT", "HALS", "REDON", "HOOCH", "BRIL", "ZOFFANY", "ROSSETTI", "ROUSSEAU", "TINTORETTO", "WATTEAU", "REYNOLDS", "MORISOT", "TURNER", "GIOTTO", "MATISSE", "FURSE", "DAUBIGNY", "PISSARRO", "WHISTLER", "DESPORTES", "UTRILLO", "MONET", "MOSER", "TITIAN", "ABBEY", "STAEL", "BUTLER", "CLOUET", "NATTIER", "PICASSO", "SUTHERLAND", "BEARDSLEY", "FABRITIUS", "AUDUBON", "GAUGUIN", "MABUSE", "MARLOW", "MEISSONIER", "BELLOTTO", "MURILLO", "COTMAN", "GIRTIN", "VILLON", "BONINGTON", "MANET", "WARHOL", "MACWHIRTER", "PERRONNEAU", "GAINSBOROUGH", "PRENDERGAST", "MOORE", "BARTOLOMMEO", "BOUDIN", "CANALETTO", "CONSTABLE", "ORCHARDSON", "HOGARTH", "RAEBURN", "VERMEER", "MILLET", "RENOIR", "REMBRANDT", "BOTTICELLI", "BOUCHER", "LAMBERT", "MILLAIS", "AVERCAMP", "BRUGGHEN", "CROME", "GIORGIONE", "SAENREDAM", "LANDSEER", "LAWRENCE", "POLLOCK", "CORREGGIO", "DELACROIX", "DOMENICHINO", "DAVID", "DEGAS", "CARAVAGGIO", "BERNINI", "BOLDONI", "ALBERTINELLI", "FRAGONARD", "GRECO", "MODIGLIANI", "DICKSEE", "HOLBEIN", "MICHELANGELO", "RAPHAEL", "BELLINI", "CARRACCI", "DALI", "BLAKE", "HEDA" },

                new GridList() {
                "      .  .     . ",
                " .HOOCH. G .HALS.",
                "      E.BRIL.. A ",
                ".ROMNEY. E . C R ",
                "   . .D  U R E G ",
                " . E.VELAZQUEZ.E ",
                ".WEYDEN..E B A N ",
                " A C R. L..ERNST.",
                " T K N.REDON.N . ",
                " T . E  L .STEER.",
                ".SCOTT.DYCK. .   ",
                " .   .  .        "});

                case 9309:
                    return new GameModel(9309, 570, 17, 12,
                new WordList() { "PASSAMEZZO", "TWIST", "TROT", "ZAPATEADO", "TWOSTEP", "POUSSETTE", "STEP", "MINUET", "PIROUETTE", "PAS", "TAP", "VALSE", "TANGO", "JOTA", "VALETA", "HOP", "HULA", "JIVE", "POLKA", "CANCAN", "FAN", "REEL", "BALL" },
                new WordList() { "PASSAMEZZO", "TWIST", "TROT", "ZAPATEADO", "TWOSTEP", "POUSSETTE", "STEP", "MINUET", "PIROUETTE", "PAS", "TAP", "VALSE", "TANGO", "JOTA", "VALETA", "HOP", "HULA", "JIVE", "POLKA", "CANCAN", "FAN", "REEL", "BALL", "MAZURKA", "SHIMMY", "STRATHSPEY", "MUSETTE", "FOXTROT", "KANTIKOY", "BOSTON", "CANTICOY", "GAVOTTE", "MAYPOLE", "ROUNDELAY", "TRIPUDIUM", "MORRIS", "ONESTEP", "QUICKSTEP", "LAVOLT", "SCHOTTISCHE", "VARSOVIENNE", "MAXIXE", "DANSEUSE", "JITTERBUG", "COURANTE", "ECOSSAISE", "FRUG", "MORESCO", "TAMBOURINE", "CORANT", "RUMBA", "CHASSE", "CHARLESTON", "HOEDOWN", "MADISON", "ROUNDEL", "POLONAISE", "SALTARELLO", "BOURREE", "SHUFFLE", "ARABESQUE", "COTILLION", "STEPDANCE", "TARANTELLA", "COUPEE", "PAVANE", "REDOWA", "HORNPIPE", "GIGUE", "SAMBA", "CANTICO", "LANCERS", "BREAKDOWN", "KRAKOWIAK", "PASODOBLE", "MORRICE", "CRACOVIENNE", "PASSACAGLIA", "MAMBO", "CORROBOREE", "QUADRILLE", "BALLROOM", "RIGADOON", "BEGUINE", "BOLERO", "SARABAND", "GALOP", "RONDEA", "CONGA", "CAPRIOLE", "CAKEWALK", "CHACONNE", "FANDANGO", "BEBOP", "BOREE", "CAPER", "FLING", "FARANDOLE", "JIG", "CARIOCA", "BARNDANCE", "GALLOPADE", "ALLEMANDE", "FOLKDANCE", "GALLIARD", "HABANERA" },

                new GridList() {
                " . .    .  .     ",
                ".PIROUETTE.F  .  ",
                " A E    A.VALETA.",
                ".STEP.CANCAN. R  ",
                " S L.   G L. .O  ",
                " A .H .POUSSETTE.",
                ".MINUET...E  W.  ",
                " E .L. B J..JIVE.",
                ".ZAPATEADO.H S   ",
                " Z A.A L.TWOSTEP.",
                " O S.POLKA.P .   ",
                " . . . . . .     "});

                case 9310:
                    return new GameModel(9310, 440, 17, 12,
                new WordList() { "SZYMANOWSKI", "DONIZETTI", "RODRIGUEZ", "STRAUSS", "MOUSSORGSKY", "DEBUSSY", "STRAVINSKY", "TOSTI", "RAYBOULD", "MARKS", "DELIUS", "GAUL", "VERDI", "MASCAGNI" },
                new WordList() { "SZYMANOWSKI", "DONIZETTI", "RODRIGUEZ", "STRAUSS", "MOUSSORGSKY", "DEBUSSY", "STRAVINSKY", "TOSTI", "RAYBOULD", "MARKS", "DELIUS", "GAUL", "VERDI", "MASCAGNI", "VIEUXTEMPS", "TCHAIKOVSKY", "ROSSINI", "BIRTWISTLE", "RAWSTHORNE", "SULLIVAN", "STOCKHAUSEN", "KABALEVSKY", "RUBINSTEIN", "SCHUBERT", "BRITTEN", "SCHUMANN", "SIBELIUS", "SCARLATTI", "GERSHWIN", "MONCKTON", "GOUNOD", "MONTEVERDI", "BERNSTEIN", "MEYERBEER", "COWEN", "NIELSON", "MENDELSSOHN", "COUPERIN", "WILLAERT", "PALESTRINA", "VIVALDI", "DIMITRIESEN", "BARTOK", "BRAHMS", "DVORAK", "WAGNER", "BEETHOVEN", "PROKOFIEV", "WALDTEUFEL", "RAVEL", "RACHMANINOV", "PUCCINI", "PURCELL", "PERGOLESI", "GLUCK", "WEBER", "ANSELL", "LAMBERT", "KREISLER", "HUMPERDINCK", "HINDEMITH", "HOLBROOK", "BORODIN", "HERMANN", "CHOPIN", "SCHOENBERG", "KERN", "LEONCAVALLO", "GERMAN", "MACDOWELL", "LOCATELLI", "ORFF", "ALBINONI", "GRAINGER", "PAGANINI", "SCHNABEL", "ADDINSELL", "BERLIN", "DELIBES", "GRIEG", "BOCCHERINI", "FRANKEL", "BLOCH", "ELGAR", "LEHAR", "BELLINI", "HANDEL", "OFFENBACH", "ANCLIFFE", "BACH", "GADE" },

                new GridList() {
                " . .     .   .   ",
                ".MARKS..STRAUSS. ",
                " A A   R O   T D ",
                ".SZYMANOWSKI.R E ",
                " C B   D T   A B ",
                " A O.VERDI.  V U ",
                ".GAUL. I .DELIUS.",
                " N L   G     N S ",
                " I D.MOUSSORGSKY.",
                " . .   E     K . ",
                "  .DONIZETTI.Y   ",
                "       .     .   "});

                case 9311:
                    return new GameModel(9311, 552, 17, 12,
                new WordList() { "MIZZENTOP", "HORIZON", "BUOY", "JETTY", "STOWAWAY", "SEAWORTHY", "MAST", "SCUTTLE", "PORT", "TARPAULIN", "WIND", "CREW", "AFT", "ASHORE", "FLOAT", "TRICE", "AFTER", "HATCH", "RIG", "EMBARGO" },
                new WordList() { "MIZZENTOP", "HORIZON", "BUOY", "JETTY", "STOWAWAY", "SEAWORTHY", "MAST", "SCUTTLE", "PORT", "TARPAULIN", "WIND", "CREW", "AFT", "ASHORE", "FLOAT", "TRICE", "AFTER", "HATCH", "RIG", "EMBARGO", "RENDEZVOUS", "SEXTANT", "SPARS", "BOWSPRIT", "GANGWAY", "CROSSTREES", "JETTISON", "ATHWART", "CROSSWIND", "YARDARM", "COMPASS", "WINDLASS", "SHIPWRIGHT", "DAVIT", "JETSAM", "FLOTSAM", "DOLDRUMS", "LIGHTHOUSE", "FOREMAST", "OUTBOARD", "HALYARD", "OAKUM", "COASTGUARD", "NAVIGATOR", "FOUL", "SHIPMATE", "BULWARK", "OARSMAN", "DRIFTWOOD", "PORTHOLE", "CHARTROOM", "AWNING", "ENSIGN", "SAILOR", "PLIMSOLL", "DOGWATCH", "NAVIGATE", "TELESCOPE", "SALVAGE", "HELMSMAN", "MARITIME", "SEMAPHORE", "BERTH", "ALONGSHORE", "MIDSHIPMAN", "FORECASTLE", "LUFF", "CRAFT", "SPLICE", "HURRICANE", "BILGEWATER", "MOORAGE", "FLOTILLA", "MARINE", "GRAPNEL", "LEEWARD", "RIGGING", "TAFFRAIL", "LANDLUBBER", "GANGPLANK", "FOG", "ENGINE", "FIGUREHEAD", "HELM", "LIFEBELT", "ANCHORAGE", "MAINBRACE", "BEACON", "CORDAGE", "BINNACLE", "BRIDGE", "DEBARK", "BECALMED", "KEDGE", "DECK" },

                new GridList() {
                "   .  .      . . ",
                " .EMBARGO.   C B ",
                " A A  I .AFTER.U ",
                " S S .G .F . E O ",
                ".HATCH..STOWAWAY.",
                " O . O  C. I . . ",
                " R.TARPAULIN.F J ",
                " E R I  T  D L E ",
                " .MIZZENTOP.PORT.",
                "   C O  L    A T ",
                "   E N.SEAWORTHY.",
                "   . .  .    . . "});

                case 9312:
                    return new GameModel(9312, 506, 17, 12,
                new WordList() { "QUIZAPU", "RUWENZORI", "VESUVIUS", "ROCKY", "BARRY", "EVEREST", "ROSA", "OLIVES", "ATLAS", "SIMPLON", "EREBUS", "ALPS", "JURA", "SULAIMAN", "URAL", "ITACULOMI", "PETEROA", "FUJI", "PELEE", "CAHA" },
                new WordList() { "QUIZAPU", "RUWENZORI", "VESUVIUS", "ROCKY", "BARRY", "EVEREST", "ROSA", "OLIVES", "ATLAS", "SIMPLON", "EREBUS", "ALPS", "JURA", "SULAIMAN", "URAL", "ITACULOMI", "PETEROA", "FUJI", "PELEE", "CAHA", "TUPUNGATO", "VOSGES", "PARNASSUS", "COTSWOLDS", "PYRENEES", "TOWNSEND", "SNOWDON", "LOOKOUT", "CAUCASUS", "MANTURK", "RUSHMORE", "KOSCIUSKO", "LAFAYETTE", "HELVELLYN", "MOURNE", "TOMBORO", "MOORFOOT", "HIMALAYAS", "STROMBOLI", "LIVINGSTONE", "VULCANO", "COTOPAXI", "MCKINLEY", "QUANTOCK", "MATTERHORN", "NELSON", "PAMIRS", "CAIRNTOUL", "JUNGFRAU", "CHEVIOT", "WELLINGTON", "TONGARIRO", "AUVERGNE", "PENNINES", "LAURENTIAN", "LIVERPOOL", "MALVERN", "SINAI", "CAIRNGORMS", "LAMMERMUIR", "ESTRELLE", "DARWIN", "HOOSAC", "CUCHULLIN", "DARDISTAN", "GRAMPIANS", "SOLFATARA", "CATSKILL", "NILGIRIS", "APENNINES", "ARARAT", "RUAHINE", "RAKAPOSHI", "BLUE", "ANDES", "MONCH", "COOPER", "DAPSANG", "CHILTERN", "WRANGELL", "MALADETTA", "KWATHLAMBA", "FAUCILLES", "FLINDERS", "KRAKATOA", "CARPATHIAN", "CHUMALARI", "BALKANS", "DEMAVEND", "GOATFELL", "KATAHDIN", "LOGAN", "RAINIER", "ACONCAGUA", "KARAKORAM", "KILIMANJARO", "SNAEFELL", "BROCKEN", "HOFFMAN", "HUALALAI", "DARLING", "ILLAMPA", "SCAFELL", "ADIRONDACK", "APPALACHIAN", "CASCADE", "BLANC", "EDGEHILL", "HECLA" },

                new GridList() {
                "  .      . .  .  ",
                ".PELEE.  P Q  F  ",
                "  V   J.VESUVIUS.",
                " .EREBUS.T I  J  ",
                "  R  .RUWENZORI. ",
                "  E.URAL.R A ..O ",
                " .S  O.A O.P R L ",
                ".ATLAS.ITACULOMI.",
                " L.  A M .A. C V ",
                " P   . A  H  K E ",
                ".SIMPLON.BARRY.S ",
                " .     .  .  . . "});

                case 9401:
                    return new GameModel(9401, 656, 17, 15,
                new WordList() { "WALTZING", "BEZIQUE", "TEST", "RUGBY", "PLAY", "QUOITS", "LOTTO", "SQUASH", "SKITTLES", "HOBBY", "BOWLS", "TENNIS", "DARTS", "HOCKEY", "CROQUET", "SKATING", "JUDO", "CANASTA", "SKIING", "DIVING", "BAIT", "RODEO", "NETBALL", "GOLF", "BALL" },
                new WordList() { "WALTZING", "BEZIQUE", "TEST", "RUGBY", "PLAY", "QUOITS", "LOTTO", "SQUASH", "SKITTLES", "HOBBY", "BOWLS", "TENNIS", "DARTS", "HOCKEY", "CROQUET", "SKATING", "JUDO", "CANASTA", "SKIING", "DIVING", "BAIT", "RODEO", "NETBALL", "GOLF", "BALL", "QUATORZE", "SWIM", "EURYTHMICS", "GYMNASTICS", "OLYMPICS", "TOURNAMENT", "FLYING", "ROULETTE", "SPELEOLOGY", "WOODWORK", "WRESTLING", "DRAUGHTS", "ROUNDERS", "EQUESTRIANISM", "ARCHERY", "SURFING", "AQUATICS", "SHUTTLECOCK", "CHESS", "ROWING", "OUTRIDE", "GYMKHANA", "VOLLEYBALL", "HOPSCOTCH", "ATHLETICS", "LACROSSE", "SCULLING", "STALKING", "SOLITAIRE", "DOMINOES", "MARATHON", "MOUNTAINEERING", "BICYCLE", "TRAMPOLINING", "WEIGHTLIFTING", "CALISTHENICS", "CURLING", "TOBOGGAN", "BADMINTON", "STEEPLECHASING", "SOCCER", "HURDLING", "ACROBATICS", "SKATEBOARD", "TOBOGGANING", "CARDS", "MARBLES", "SAILING", "RECREATION", "FOOTBALL", "EUCHRE", "KARATE", "BIATHALON", "CRICKET", "BALLOONING", "BILLIARDS", "RIDING", "ANGLING", "BACKGAMMON", "LEAPFROG", "HIKING", "GARDENING", "CLIMBING", "MANEGE", "FENCING", "GLIDING", "BASEBALL", "REFEREE", "BRIDGE" },

                new GridList() {
                "    .   . . . .  ",
                "    C . B G B T  ",
                "   .RODEO.O E E  ",
                ".JUDO.I.WALTZING.",
                " .  Q V L F I N  ",
                " N.QUOITS.. Q I. ",
                " E .E N ..SQUASH.",
                ".TEST.G C K E..O ",
                " B K... A I .B C ",
                " A A H  N T  A K ",
                ".LOTTO.DARTS.L E ",
                " L I B  S L.PLAY.",
                " . N.BAIT.E  . . ",
                ".RUGBY. A.SKIING.",
                "   . .  . .      "});

                case 9402:
                    return new GameModel(9402, 636, 17, 15,
                new WordList() { "ZONURUS", "LIZARD", "PYTHON", "STEGOSAURUS", "TESTUDO", "NEWT", "TURTLE", "TUATARA", "MONITOR", "SERPENT", "DINOSAUR", "DIPSAS", "RATTLER", "WORREL", "SKINK", "TOAD", "KRAIT", "TAIPAN", "KUFI", "ELAPS", "SNAKE", "WARAL", "FROG", "LAMIA", "PADDOCK" },
                new WordList() { "ZONURUS", "LIZARD", "PYTHON", "STEGOSAURUS", "TESTUDO", "NEWT", "TURTLE", "TUATARA", "MONITOR", "SERPENT", "DINOSAUR", "DIPSAS", "RATTLER", "WORREL", "SKINK", "TOAD", "KRAIT", "TAIPAN", "KUFI", "ELAPS", "SNAKE", "WARAL", "FROG", "LAMIA", "PADDOCK", "TYPHLOPS", "TYRANNOSAURUS", "COTYLOSAUR", "ICHTHYOSAURUS", "MOSASAURUS", "HYLAESAURUS", "BRONTOSAURUS", "TRITON", "COTTONMOUTH", "TORTOISE", "VARANUS", "OPHIOSAURUS", "PTEROSAUR", "SCINCUS", "PTERODACTYL", "CAYMAN", "BUSHMASTER", "PLESIOSAUR", "AXOLOTL", "TRICERATOPS", "DOLICHOSAURUS", "SAURIAN", "CERASTES", "BASILISKS", "SNAPPER", "RATTLESNAKE", "ACONTIAS", "MUGGER", "MATAMATA", "TERRAPIN", "DIPLODOCUS", "HAMADRYAD", "BOOMSLANG", "GALLIWASP", "SCHAAPSTICKER", "GARTERSNAKE", "LEVIATHAN", "NATTERJACK", "COBRAS", "MAMBAS", "DRAGONET", "LACHESIS", "MOCCASIN", "RINGHALS", "OPHIDIANS", "IGUANA", "COLUBER", "TADPOLE", "URODELA", "AMPHIBIANS", "ALLIGATOR", "MOLOCH", "SALAMANDER", "DRAGON", "LACERTA", "COCKATRICE", "ANOLE", "BATRACHIA", "COPPERHEAD", "CHAMELEON", "CROCODILE", "ABOMA", "CHELONE", "LABARRI", "ANACONDA", "CHELONIA", "HICCATEE", "JIBOA", "GHARIAL", "HELLBENDER", "JARARACA", "LANGAHA", "DABOIA", "ADDER", "KEELBACK" },

                new GridList() {
                " . .   . . . .   ",
                " E.WARAL.L D S   ",
                " L O . A I I E . ",
                " A R F M.ZONURUS.",
                " P R R I A O P N ",
                ".STEGOSAURUS.E A ",
                " ..L G ..D.A.N K ",
                "  M...  P.TURTLE.",
                ".TOAD.TUATARA. . ",
                "  N I . D I.T  . ",
                "  I P K D.PYTHON.",
                " .TESTUDO.A L  E ",
                "  O A F C N E  W ",
                "  R.SKINK..KRAIT.",
                "  . . . .   .  . "});

                case 9403:
                    return new GameModel(9403, 710, 17, 15,
                new WordList() { "PIZZARO", "VELASQUEZ", "ROSS", "SCOTT", "STANLEY", "MOSTO", "BYRD", "STEWART", "PEARY", "AUSTIN", "BURTON", "MAWSON", "TORRES", "HUDSON", "EVANS", "OATES", "CORTES", "TASMAN", "OSBORN", "KENNEDY", "NANSEN", "POLO", "JENKINSON", "EANNES", "ADAMS", "COOK", "LEIF" },
                new WordList() { "PIZZARO", "VELASQUEZ", "ROSS", "SCOTT", "STANLEY", "MOSTO", "BYRD", "STEWART", "PEARY", "AUSTIN", "BURTON", "MAWSON", "TORRES", "HUDSON", "EVANS", "OATES", "CORTES", "TASMAN", "OSBORN", "KENNEDY", "NANSEN", "POLO", "JENKINSON", "EANNES", "ADAMS", "COOK", "LEIF", "HURLEY", "MACKENZIE", "TRISTAM", "DULUTH", "SMITH", "OMMANNEY", "SVERDRUP", "THOMPSON", "STEFANSSON", "MORTON", "KINGSLEY", "SPIES", "COLUMBUS", "JOHNSTON", "VANCOUVER", "LEWIS", "HILLARY", "VESPUCCI", "LIVINGSTONE", "FAWCETT", "ETHERTON", "RADISSON", "ADVENTURE", "AMUNDSEN", "HAWKINS", "KROPOTKIN", "HUMBOLDT", "FREMONT", "DISCOVER", "ENDEAVOUR", "GONSALVEG", "HARTOG", "EXPLORE", "KELLETT", "AFRICANUS", "LANCASTER", "SHACKLETON", "INTREPID", "JOHANSEN", "BURKE", "BARNES", "FORBES", "FRASER", "KOSLOFF", "SHIPPEE", "TWEEDIE", "RICHARDSON", "BOUGAINVILLE", "CARTIER", "CHARCOT", "FROBISHER", "BELLINGHAUSEN", "MCCLINTOCK", "GRANVILLE", "FLINDERS", "GILBERT", "PRADO", "CHAMPION", "LAWRENCE", "PHILIP", "MANDEVILLE", "FRANKLIN", "DAMPIER", "LEICHHARDT", "BERING", "CHAMPLAIN", "BEHRING", "BELGONI", "MENDANA", "CHANCELLOR", "DANGER", "FILCHNER", "GRENFELL", "MAGELLAN", "COCKERILL", "RALEIGH", "CLIFFORD", "DRAKE", "INGLEFIELD", "ALMEIDA", "BAFFIN", "BALBOA", "CABRAL", "BEKE" },

                new GridList() {
                "   .  . . .  . . ",
                " .SCOTT.M O.COOK.",
                " S O .ADAMS. A E ",
                ".TORRES.W.BURTON.",
                " E T .MOSTO. E N ",
                " W E  A O.ROSS.E ",
                ".AUSTIN.N N. . D ",
                " R .  . ...PEARY.",
                " T E  N  H I . . ",
                " ..VELASQUEZ.P . ",
                " L A  N  D Z O B ",
                ".EANNES..STANLEY.",
                " I S  E  O R O R ",
                " F .JENKINSON. D ",
                " .    .  . .   . "});

                case 9404:
                    return new GameModel(9404, 740, 17, 15,
                new WordList() { "ZINNIA", "SCHIZANTHUS", "THYME", "FORSYTH", "LOTUS", "HENRY", "SHRUBS", "ASTERS", "STAMENS", "GUM", "FRUIT", "RUE", "SPORE", "FLOWERS", "LUPIN", "PETALS", "REEVES", "SEEDS", "KEW", "FERNS", "WARD", "VIOLA", "FLORES", "BANKS", "HERBS", "TWEEDIE", "ROBIN", "DAVID", "HAKE" },
                new WordList() { "ZINNIA", "SCHIZANTHUS", "THYME", "FORSYTH", "LOTUS", "HENRY", "SHRUBS", "ASTERS", "STAMENS", "GUM", "FRUIT", "RUE", "SPORE", "FLOWERS", "LUPIN", "PETALS", "REEVES", "SEEDS", "KEW", "FERNS", "WARD", "VIOLA", "FLORES", "BANKS", "HERBS", "TWEEDIE", "ROBIN", "DAVID", "HAKE", "BRYOPHYTA", "HYBRIDIZING", "ESCHSCHOLZ", "FORESTRY", "BOTANY", "PLINY", "WALNUT", "CUTTINGS", "TURNER", "WILLMOTT", "CULTIVARS", "WESTRING", "MORPHOLOGY", "COTYLEDON", "BOTANIST", "PISTIL", "DELAVAY", "ECOLOGY", "FORTUNE", "ARISTOTLE", "COMPTON", "GUAVA", "COULTER", "BELLAMY", "BAILEY", "ANGIOSPERMS", "PLANT", "MIGNONETTE", "LINNAEUS", "THUNBERG", "DOUGLAS", "TRADESCANT", "VEITCH", "MATTHIOLI", "PARKINSON", "JOVELLANOS", "COLLINSON", "DARWIN", "MARIES", "BARTRAM", "PROPAGATE", "STELLARIA", "GODET", "CUNNINGHAM", "MUELLER", "SOLANDER", "EUGENE", "MAGNOL", "POLLEN", "GREVILLE", "KNIPHOF", "SIEBOLD", "AGAVA", "BALSA", "LONICER", "BARONE", "FARRER", "ALLIONI", "BEGON", "GRAPE", "HERRARIA", "JARDIN", "KALM", "KAEMPFER", "GARDEN", "GERARD", "LOBB", "DEODAR", "BREEDING", "LAPAGERIA", "FOLIAGE", "BLAIKIE", "DAHL", "ABEL" },

                new GridList() {
                " .   . . .   . . ",
                " D ..SCHIZANTHUS.",
                " A F T E I . E P ",
                ".VIOLA.R N A N O ",
                " I R M.BANKS.R R ",
                " D.SEEDS.I.THYME.",
                " . Y N .HAKE.. . ",
                ".LOTUS.F ..ROBIN.",
                " U H..FLORES. .  ",
                " P .F  O E .K F  ",
                " I  R.TWEEDIE.E  ",
                " N.GUM.E V .WARD.",
                " .  I .RUE. . N  ",
                " .PETALS.SHRUBS. ",
                "    .  . .    .  "});

                case 9406:
                    return new GameModel(9406, 718, 17, 15,
                new WordList() { "RAMAZZINI", "WHYTT", "ZOLLNER", "TETANY", "MAYO", "SURGERY", "OXYGEN", "BOTANY", "HARVEY", "STOKES", "NURSE", "SIMPSON", "FLOREY", "MORTON", "VITAMINS", "EVANS", "WRIGHT", "INSULIN", "HYGIENE", "MONRO", "GERMS", "SARPI", "MASHRIG", "FRANK", "HAND", "BILE" },
                new WordList() { "RAMAZZINI", "WHYTT", "ZOLLNER", "TETANY", "MAYO", "SURGERY", "OXYGEN", "BOTANY", "HARVEY", "STOKES", "NURSE", "SIMPSON", "FLOREY", "MORTON", "VITAMINS", "EVANS", "WRIGHT", "INSULIN", "HYGIENE", "MONRO", "GERMS", "SARPI", "MASHRIG", "FRANK", "HAND", "BILE", "INFLUENZA", "VIRUS", "ANATOMY", "SHARPEY", "CHEMISTRY", "PASTEUR", "WHITLOW", "PATHOLOGY", "VESALIUS", "TRANSFUSION", "OCULIST", "SYDENHAM", "DRUGS", "HUNTER", "STETHOSCOPE", "BIOLOGY", "ARTHRITIS", "DOCTORS", "SEMMELWEISS", "IMMUNISATION", "LISTER", "MANSON", "VIRCHOW", "BASSI", "CAIUS", "JUDET", "WILLIS", "CORTISONE", "BEAUMONT", "HOSPITAL", "RONTGEN", "PARIS", "PARACELSUS", "LOWE", "ANTIBIOTICS", "QUARANTINE", "MESMER", "WITHERING", "DIAGNOSIS", "LAVOISIER", "HIPPOCRATES", "GULL", "MULLER", "SALERNO", "INCISION", "ANAESTHESIA", "DORSAL", "MONTPELLIER", "VACCINATION", "CURIE", "BRIGHT", "GORDON", "TRANCE", "DIGITALIS", "MAIMONIDES", "FEVER", "PADUA", "CULLEN", "ADDISON", "DENTAL", "AVICENNA", "NIGHTINGALE", "JENNER", "HOOKE", "CHRONIC", "HAHNEMANN", "FEMORAL", "MANIA", "PENICILLIN", "BACTERIA", "MALPIGHI", "BARNARD", "BORELLI", "FLEMING", "KOCH", "BACON", "CARREL", "AGRICOLA", "GALEN", "EHRLICH", "MEDICINE", "REED", "ACHE" },

                new GridList() {
                "  . . .     . .  ",
                " .SARPI..MORTON. ",
                "  U A N F . E U  ",
                "  R.MASHRIG.T R  ",
                "  G A U A.EVANS. ",
                "  E.ZOLLNER.N.E. ",
                " .R Z I K.MAYO.V ",
                ".HYGIENE. S..X I ",
                " A. N.. B .WHYTT.",
                " R.SIMPSON.R G A ",
                " V  .O  T.BILE.M ",
                " E.HAND.A  G N I ",
                " Y   R  N  H . N ",
                " ..FLOREY.STOKES.",
                "     .  .  .   . "});

                case 9407:
                    return new GameModel(9407, 804, 17, 15,
                new WordList() { "BLIZZARD", "SUBZERO", "FROZEN", "HORIZON", "GUST", "SNOW", "SCOTT", "STORM", "BYRD", "SKUAS", "WALRUS", "SASTRUGI", "INUIT", "SUPPLIES", "WINTER", "HILLARY", "WEASELS", "DRIFTS", "FUCHS", "PETRELS", "SEALS", "WIND", "IGLOOS", "WHALES", "POLE", "ALASKA", "ICE" },
                new WordList() { "BLIZZARD", "SUBZERO", "FROZEN", "HORIZON", "GUST", "SNOW", "SCOTT", "STORM", "BYRD", "SKUAS", "WALRUS", "SASTRUGI", "INUIT", "SUPPLIES", "WINTER", "HILLARY", "WEASELS", "DRIFTS", "FUCHS", "PETRELS", "SEALS", "WIND", "IGLOOS", "WHALES", "POLE", "ALASKA", "ICE", "SOUTH", "CRYSTALS", "FREEZING", "TENT", "SNOWSHOES", "PEARY", "FROST", "ROOKERY", "MUKLUKS", "MAWSON", "MOUNTAINS", "TRACTORS", "SNOWBOUND", "ASTROFIX", "NUNATAKS", "SNOWDRIFT", "HUSKIES", "SEISMOLOGIST", "NORTH", "GREELY", "COMPASS", "WIRELESS", "PENGUINS", "FROSTBITE", "HARNESS", "WILKINS", "CREVASSE", "EXPLORERS", "TEMPERATURE", "METEOROLOGIST", "AMUNDSEN", "LATITUDE", "SNOWMOBILE", "TOBOGGANS", "CRAMPONS", "THERMOMETER", "ISLANDS", "AURORA", "NANSEN", "CARIBOUS", "NAVIGATION", "WEATHER", "ESKIMO", "SAVAGE", "EXPEDITION", "LEMMINGS", "AXE", "FJORDS", "NANUCK", "PLANES", "SKIING", "ANTARCTIC", "PARACHUTE", "SHACKLETON", "ANTENNA", "BALLOONS", "BIRDS", "FLOES", "GLISSADE", "BAROMETER", "MONOPLANE", "SLED", "BEARS", "FAUNA", "NORGE", "HURRICANE", "ARCTIC", "AIRCRAFT", "ANORAK", "ERMINE", "GLACIERS", "PEMMICAN", "SLEDGE", "BOLLING", "PARKA", "RADIO", "WILDLIFE", "FOG", "GAP", "FOKKER", "NOBILE", "WEDDELL", "OCEAN", "CHANNEL", "BERG", "PACK", "LICHEN", "BALACLAVA", "CRACK", "ICEBERG", "ICECAP", "GLACIAL", "ADELIE" },

                new GridList() {
                "    . . .  . . . ",
                "    G.SUPPLIES.W ",
                " .INUIT.E  G A H ",
                "   .SCOTT.ALASKA.",
                ".WINTER.R  O T L ",
                "    ..M E  O R E ",
                "  .  S..L .SKUAS.",
                "  H.FUCHS.P..G . ",
                "  I  B O. O.WIND.",
                ".BLIZZARD.L A. R ",
                "  L  E I.SEALS.I ",
                "  A.FROZEN. R  F ",
                "  R  O O O  U  T ",
                ".BYRD. N.WEASELS.",
                "  .    . .  .  . "});

                case 9408:
                    return new GameModel(9408, 828, 17, 15,
                new WordList() { "STYLUS", "TYPES", "PAPYRUS", "TEXT", "TYPOGRAPHY", "DEMY", "ROYAL", "SEWN", "PRESS", "QUARTO", "SCRIPT", "PRINT", "BOX", "COSTER", "EMS", "FONT", "CROWN", "TITLE", "PROOFS", "PLATES", "ROLLS", "MOULD", "PAPERS", "QUILL", "ROLLERS", "FORME", "PAIR", "INK", "BALLOON", "REAM", "PAGE", "PICA", "BED" },
                new WordList() { "STYLUS", "TYPES", "PAPYRUS", "TEXT", "TYPOGRAPHY", "DEMY", "ROYAL", "SEWN", "PRESS", "QUARTO", "SCRIPT", "PRINT", "BOX", "COSTER", "EMS", "FONT", "CROWN", "TITLE", "PROOFS", "PLATES", "ROLLS", "MOULD", "PAPERS", "QUILL", "ROLLERS", "FORME", "PAIR", "INK", "BALLOON", "REAM", "PAGE", "PICA", "BED", "MAZARIN", "HORIZONTAL", "ROTARY", "MAGAZINE", "TYPESETTING", "MONOTYPE", "TYPEWRITER", "STEREOTYPE", "NEWS", "LINOTYPE", "SLUG", "FOUNT", "FUTURA", "SOUVENIR", "COPYRIGHT", "TIMES", "XEROGRAPHY", "CULTURE", "LETTERS", "MATRIX", "VOLUME", "BROADWAY", "LETTERPRESS", "STATIONER", "PASTE", "MANUSCRIPT", "CAXTON", "OCTAVO", "OPTIMO", "STEREO", "COMPOSITOR", "NEWSPAPERS", "LIBRARY", "LITHOGRAPHY", "VELLUM", "BAUHAUS", "HYDRAULIC", "ATLAS", "BOOKWORM", "CYLINDER", "PRINTER", "OFFSET", "BOOKS", "FORMAT", "COVER", "PUBLISHER", "GUTENBERG", "PARCHMENT", "INDEX", "METAL", "OBLIQUE", "ENGRAVER", "EXTENDED", "FOOLSCAP", "ENGRAVING", "INKWELL", "ROCKWELL", "BOOKPLATE", "BASKERVILLE", "DUODECIMO", "DESIGNER", "ELEPHANT", "CONDENSED", "BODONI", "ITALIC", "GARAMOND", "FOLIO", "CHELTENHAM", "DIGITEK", "IMPERIAL", "MEDIEVAL", "HEADLINES", "DELETE", "LIBRARIAN", "BINDING", "CAMEO", "FLATBED", "BOLD", "PREFACE", "LEADER" },

                new GridList() {
                "  .    .     . . ",
                " .PROOFS..COSTER.",
                "  I .  T M   Y O ",
                " .C D.TYPOGRAPHY.",
                ".PAGE..L U   E A ",
                " A..M.QUILL. S L ",
                ".PAPYRUS.D R . . ",
                " E A. A.B.FONT.E ",
                " R.I .REAM.L I M ",
                ".SCRIPT.L.PLATES.",
                " .R..ROLLERS.L . ",
                ".FORME. O I.BED. ",
                "  W  S  O N O.   ",
                ".INK.SEWN.TEXT.  ",
                "  .  .  . . .    "});

                case 9409:
                    return new GameModel(9409, 766, 17, 15,
                new WordList() { "STULTZ", "ROZIER", "STRUT", "SMITHY", "GYROSTAT", "ZEPPELIN", "STABILIZER", "CURTISS", "BYRD", "MERCURY", "SHUTTLE", "WINGS", "ULM", "TIRO", "UFO", "KITES", "HASTE", "PILOT", "RISE", "DIVE", "EJECTOR", "HEATH", "AIRLINER", "GREEN", "BANK", "GALIEN", "BELL" },
                new WordList() { "STULTZ", "ROZIER", "STRUT", "SMITHY", "GYROSTAT", "ZEPPELIN", "STABILIZER", "CURTISS", "BYRD", "MERCURY", "SHUTTLE", "WINGS", "ULM", "TIRO", "UFO", "KITES", "HASTE", "PILOT", "RISE", "DIVE", "EJECTOR", "HEATH", "AIRLINER", "GREEN", "BANK", "GALIEN", "BELL", "CAYLEY", "SIKORSKY", "JOYSTICK", "ASTRONAUT", "BRUNT", "STRATOJET", "COSMONAUT", "PEGASUS", "AUTOPILOT", "TURBOJET", "SUPERSONIC", "WRIGHT", "COMPASS", "HYDROGEN", "BROWN", "AUTOGIRO", "AIRBUS", "DROGUES", "AERODYNE", "AERONAUT", "ALTITUDE", "AMUNDSEN", "NAVIGATOR", "BIOT", "AVIATION", "ROBERT", "VERNE", "PHOENIX", "GODWIN", "ALTIMETER", "SPACESHIP", "RODGERS", "HOP", "ROCKET", "ORVILLE", "VOLPLANE", "BLERIOT", "COCKPIT", "LUNARDI", "RADIATOR", "MONOPLANE", "SPACE", "LEVINE", "WALKER", "AIRCREW", "EARHART", "FUSELAGE", "HELICOPTER", "HINDENBURG", "PROPELLER", "GLIDERS", "FLIGHT", "SADLER", "CHARLES", "AIRMAN", "AERODROME", "LEONARDO", "CLEAT", "LILIENTHAL", "AILERON", "RENARD", "AEROPLANE", "HINKLER", "FOKKER", "AMPHIBIAN", "BACON", "COBHAM", "BIPLANE", "LINDBERGH", "ANDREE", "GODDARD", "PICCARD", "DIRIGIBLE", "AERIAL", "ALCOCK", "GIFFARD" },

                new GridList() {
                " . . .      .  . ",
                " G D C . .STULTZ.",
                " R I.ULM.S  F  E ",
                " E V R E.TIRO. P ",
                ".EJECTOR.R ... P ",
                " N.. I C U.HASTE.",
                " .P .SHUTTLE.M L ",
                ".KITES.R.. A I I ",
                "  L  .GYROSTAT.N ",
                "  O . A.O  H.H.. ",
                ".STABILIZER.BYRD.",
                "  . E I I   A.I  ",
                "    L E E.WINGS. ",
                ".AIRLINER.  K E  ",
                "    . . .   . .  "});

                case 9410:
                    return new GameModel(9410, 688, 17, 15,
                new WordList() { "USURY", "JURY", "GUILTY", "SURTAX", "TORT", "ATTORNEY", "CRUELTY", "WITNESS", "WRIT", "SUSPECT", "TRESPASS", "INQUEST", "FELONY", "RULES", "EXECUTOR", "BIGAMY", "JUSTICE", "ACQUITTAL", "LEGACY", "OATH", "TRIAL", "CASE", "FORGER", "FALSE", "LIEN" },
                new WordList() { "USURY", "JURY", "GUILTY", "SURTAX", "TORT", "ATTORNEY", "CRUELTY", "WITNESS", "WRIT", "SUSPECT", "TRESPASS", "INQUEST", "FELONY", "RULES", "EXECUTOR", "BIGAMY", "JUSTICE", "ACQUITTAL", "LEGACY", "OATH", "TRIAL", "CASE", "FORGER", "FALSE", "LIEN", "ASSIZES", "EMBEZZLEMENT", "TESTIMONY", "INJURY", "PERJURY", "RESTITUTION", "DISTRESS", "BANKRUPTCY", "ACCESSORY", "COPYRIGHT", "EXTORTION", "BURGLARY", "HEARSAY", "STIPENDIARY", "PROSECUTOR", "FORGERY", "TRESPASSING", "ROBBERY", "JUROR", "ARREST", "ESCROW", "PRISON", "LITIGIOUS", "ARSON", "BRIBERY", "LARCENY", "PETITION", "REMISSION", "EXTRADITION", "COLLUSION", "ENDOWMENT", "SOLICITOR", "CONTRACT", "PRISONER", "FRAUDULENT", "CHANCERY", "CONFESSION", "MURDER", "BARRISTER", "LITIGANT", "VERDICT", "ARBITRATION", "PERJURER", "SENTENCE", "STEALING", "INDICTMENT", "LITIGATION", "GUARANTEE", "ADVOCATE", "FORENSIC", "REPRIEVE", "ACCUSED", "SLANDER", "AGREEMENT", "DISBAR", "JUDGE", "PLAINTIFF", "ABET", "DEFAMATION", "PAROLE", "RELEASE", "REMAND", "CRIMINAL", "ENTAILED", "DEFENDANT", "DISCHARGE", "INNOCENCE", "CRIME", "EVIDENCE", "POLICE", "REPEAL", "HOMICIDE", "DOCK", "CODICIL", "OFFENCE", "CHARGE", "MALICE", "BENCH", "BLACKMAIL", "ILLEGAL", "LEGAL", "BAILIFF", "DEFENCE" },

                new GridList() {
                "    .  .   .     ",
                ".EXECUTOR..WRIT. ",
                "    R  A   I .   ",
                ".ACQUITTAL.TRIAL.",
                "    E .H . N N   ",
                "  . L F. C.E Q . ",
                "  J.TRESPASS.U A ",
                ".JURY.L .SUSPECT.",
                "  S .FORGER..S T ",
                "  T F N U.TORT.O ",
                ".BIGAMY.I A U. R ",
                "  C L . L X.LIEN.",
                "  E S   T . E  E ",
                "  .LEGACY..USURY.",
                "    .   .   .  . "});

                case 9411:
                    return new GameModel(9411, 696, 17, 15,
                new WordList() { "HOWITZER", "MAGAZINE", "GUNS", "SHOT", "SWORD", "QUIVER", "BRASS", "DARTS", "BOW", "MAUSER", "ARROW", "MORTAR", "DETONATOR", "SIREN", "TANK", "TORPEDO", "JET", "SPEAR", "AXE", "PETARD", "HELMET", "RAM", "BOLO", "MINE", "TABARD", "BOMB", "DERINGER", "DIRK", "LANCE", "BARB" },
                new WordList() { "HOWITZER", "MAGAZINE", "GUNS", "SHOT", "SWORD", "QUIVER", "BRASS", "DARTS", "BOW", "MAUSER", "ARROW", "MORTAR", "DETONATOR", "SIREN", "TANK", "TORPEDO", "JET", "SPEAR", "AXE", "PETARD", "HELMET", "RAM", "BOLO", "MINE", "TABARD", "BOMB", "DERINGER", "DIRK", "LANCE", "BARB", "MUSKET", "CUTLASS", "BAYONET", "SPONTOON", "CROSSBOW", "PISTOL", "ARTILLERY", "ARQUEBUS", "GAUNTLET", "BLUNDERBUSS", "CATAPULT", "CLAYMORE", "TRIDENT", "REVOLVER", "GUNPOWDER", "TRUNCHEON", "MISSILE", "EXOCET", "GRAPESHOT", "SCIMITAR", "TOMAHAWK", "BOURDON", "BULLET", "CANISTER", "CORSELET", "BATON", "SLING", "BROADSWORD", "POWDERHORN", "KNOBSTICK", "BREASTPLATE", "QUARREL", "ASSEGAI", "HACKBUT", "HARPOON", "ARBALEST", "BLOWPIPE", "SHRAPNEL", "SIDEWINDER", "CLUB", "POKER", "CANNON", "RAMROD", "REPEATER", "FLINTLOCK", "CHOPPER", "BOOMERANG", "MATCHLOCK", "POIGNARD", "CALIVER", "RAPIER", "SHIELD", "CARTRIDGE", "GELIGNITE", "CLARION", "FLAGELLUM", "CUDGEL", "KNOBKERRIE", "BODKIN", "CARRONADE", "BOMBARD", "FOIL", "PIKE", "BANDOLIER", "FIRELOCK", "KNIFE", "RIFLE", "CARBINE", "GRENADE", "PLACARD", "DAGGER", "MACE", "HALBERD", "FLAIL" },

                new GridList() {
                "   .   .    .    ",
                "  .SWORD. . G  . ",
                " . I   A .MAUSER.",
                ".BARB. R .O N. A ",
                " O E.JET.BRASS.M ",
                ".MINE..SHOT..P . ",
                " B . H ..LANCE.B ",
                " .DETONATOR. A O ",
                " H   W  O..ARROW.",
                " E.QUIVER. X.. . ",
                " L   T  P.PETARD.",
                ".MAGAZINE. .A  I ",
                " E   E .DERINGER.",
                ".TABARD.O   K  K ",
                " .   .  .   .  . "});

                case 9412:
                    return new GameModel(9412, 874, 17, 15,
                new WordList() { "JOY", "YULE", "AWAY", "HAY", "EGYPT", "NATIVITY", "MYRRH", "SNOW", "GLORY", "SON", "STAR", "HOLLY", "FROST", "KISS", "PRAYER", "WISH", "SPIRIT", "SAINT", "EAST", "STALL", "BLESS", "WATCH", "TIDINGS", "FEAST", "LOVE", "NIGHT", "STABLE", "EVE", "INN", "THREE", "FATHER", "NOEL", "HALO", "MAGI" },
                new WordList() { "JOY", "YULE", "AWAY", "HAY", "EGYPT", "NATIVITY", "MYRRH", "SNOW", "GLORY", "SON", "STAR", "HOLLY", "FROST", "KISS", "PRAYER", "WISH", "SPIRIT", "SAINT", "EAST", "STALL", "BLESS", "WATCH", "TIDINGS", "FEAST", "LOVE", "NIGHT", "STABLE", "EVE", "INN", "THREE", "FATHER", "NOEL", "HALO", "MAGI", "NAZARETH", "BALTHAZAR", "SAVIOUR", "CHRISTIANITY", "TESTAMENT", "PASSOVER", "DONKEY", "WORSHIP", "WINTER", "SCRIPTURE", "CHIMNEY", "CHRISTMAS", "MISTLETOE", "GIFTS", "SERMON", "SILVER", "FESTIVE", "GOSPELS", "HOLIDAY", "DAMASCUS", "COVENANT", "FESTIVAL", "ADVENT", "WENCESLAS", "KINDNESS", "MESSIAH", "KINGS", "MESSAGE", "AURA", "NOWELL", "REVELATION", "JERUSALEM", "SHEPHERDS", "CAROLS", "GASPAR", "TEMPLE", "REDEMPTION", "BORN", "SHEEP", "DOCTRINE", "GOODWILL", "ANGELS", "CHURCH", "FLOCKS", "ISRAEL", "FLIGHT", "HEAVEN", "BELLS", "FAITH", "HOPE", "FRANKINCENSE", "LEGENDS", "MANGER", "DAVID", "JUDEA", "TEACHER", "AMEN", "FIELDS", "MELCHIOR", "BETHLEHEM", "HEROD", "DOLL", "GOLD", "CHILDREN", "HERALD", "DECEMBER", "CRADLE", "CHILD", "PEACE", "GALILEE", "BABE" },

                new GridList() {
                "  .  .  . .   .  ",
                " .FEAST.WATCH.N  ",
                "  A  P  I H   I  ",
                " .TIDINGS.R.MAGI.",
                "  H  R  H E . H  ",
                "  E .INN..EGYPT. ",
                ".FROST..J . U .M ",
                " .. A..SON.GLORY.",
                ".NATIVITY.K E. R ",
                " O .N  A. I..H R ",
                ".EAST..BLESS.O H ",
                " L N.HALO.STALL. ",
                " . O A.EVE.A L   ",
                " .AWAY..E.PRAYER.",
                "   . .  .  . .   "});

                case 9501:
                    return new GameModel(9501, 800, 17, 15,
                new WordList() { "BUY", "DUTY", "SUM", "EQUITY", "BUYER", "ASSETS", "UNIT", "FUTURES", "BUSINESS", "STAMP", "TERMS", "HOUSE", "INTEREST", "RUIN", "YIELD", "BULLS", "TITLE", "AUCTION", "AUTOMATED", "RISK", "SHARES", "TRANSFER", "LOANS", "BONDS", "GILT", "CASH", "PAR", "SALE", "BOOK", "DEBT", "FREE", "FEE" },
                new WordList() { "BUY", "DUTY", "SUM", "EQUITY", "BUYER", "ASSETS", "UNIT", "FUTURES", "BUSINESS", "STAMP", "TERMS", "HOUSE", "INTEREST", "RUIN", "YIELD", "BULLS", "TITLE", "AUCTION", "AUTOMATED", "RISK", "SHARES", "TRANSFER", "LOANS", "BONDS", "GILT", "CASH", "PAR", "SALE", "BOOK", "DEBT", "FREE", "FEE", "TAX", "ORGANIZATION", "REGISTRY", "PAYMENT", "CAPITALIZE", "INVESTORS", "STOCKS", "LIQUIDITY", "PROSPECTUS", "COMPANY", "VENTURE", "INVESTMENT", "QUOTATION", "COUPONS", "DISCOUNT", "ORDINARY", "IMPUTATION", "SPECULATORS", "MAXIMUM", "UNDERWRITERS", "OPTION", "IMPORTANT", "MULTIPLES", "SECURITIES", "WARRANT", "NOTE", "OWNERSHIP", "COMMISSION", "TRANSACTION", "VALUE", "LIABILITY", "ASSOCIATION", "CONTRACT", "ACCOUNT", "PROFIT", "DEBENTURES", "CORPORATION", "PURCHASE", "RATE", "CONTANGO", "OBLIGATIONS", "MARKET", "STOCKHOLDING", "LEGISLATION", "SELL", "WALL", "EARNINGS", "BANKS", "FACTOR", "TRADING", "BEARS", "CLIENT", "BANKERS", "MANAGEMENT", "SHAREHOLDING", "CERTIFICATE", "CAPITAL", "ACCRUE", "INCOME", "DEALERS", "CHARTERED", "DIVIDEND", "EXCHANGE", "PRICE", "BROKERAGE", "PREFERENCE", "JOBBER", "BARGAIN", "CLEARING", "CLAIM", "FINANCE", "DEFERRED" },

                new GridList() {
                "  . . . . .   .  ",
                "  A U.BULLS.  D  ",
                ".RUIN.U O A .FEE.",
                "  C I Y A L D B. ",
                " .TITLE.N.EQUITY.",
                "  I ..RISK. T .I ",
                ".BONDS. ..BUY. E ",
                " .N  H .F O .S L ",
                " G.  A.AUTOMATED.",
                ".INTEREST.K. A . ",
                " L   E.SUM.C M F ",
                ".TRANSFER. A.PAR.",
                " .   ..TERMS.. E ",
                ".BUSINESS..HOUSE.",
                "       ..  .   . "});

                case 9502:
                    return new GameModel(9502, 654, 17, 15,
                new WordList() { "ZONE", "TRAPEZIUM", "TORUS", "LOCUS", "EVOLUTE", "ROULETTE", "PRISM", "OCTANT", "SECTOR", "SHEET", "TRIDENT", "HYPERBOLA", "CYLINDER", "QUADRANT", "LUNE", "SPLINE", "OGIVE", "SOLID", "KITE", "RHOMB", "CUBE", "CONOID", "CONE", "CONIC", "LAMINA", "LINE", "ARC" },
                new WordList() { "ZONE", "TRAPEZIUM", "TORUS", "LOCUS", "EVOLUTE", "ROULETTE", "PRISM", "OCTANT", "SECTOR", "SHEET", "TRIDENT", "HYPERBOLA", "CYLINDER", "QUADRANT", "LUNE", "SPLINE", "OGIVE", "SOLID", "KITE", "RHOMB", "CUBE", "CONOID", "CONE", "CONIC", "LAMINA", "LINE", "ARC", "POLYGON", "ANNULUS", "INVOLUTE", "PYRAMID", "CATENARY", "SQUARE", "WITCH", "POLYHEDRON", "ANTIPRISM", "TAUTOCHRONE", "RADIUS", "SEGMENT", "TANGENT", "CYCLOID", "PSEUDOSPHERE", "OVAL", "HYPERBOLOID", "CISSOID", "CYLINDROID", "SERPENTINE", "MULTIFOIL", "PRISMOID", "LOXODROME", "LOOP", "FOLIUM", "SPIRAL", "EPICYCLE", "PENTAGON", "TETRAHEDRON", "DIRECTRIX", "OCTAGON", "SURFACE", "SPHERE", "ISOCHRONE", "HEPTAGON", "SPHEROID", "CRUCIFORM", "LEMNISCATE", "NORMAL", "HEXAGON", "TREFOIL", "ENVELOPE", "PENTAHEDRON", "HELIX", "TRIANGLE", "PENTANGLE", "OCTAHEDRON", "EPITROCHOID", "QUADRILATERAL", "ICOSAHEDRON", "HEMISPHERE", "ELLIPSE", "PERPENDICULAR", "NAPPE", "HEXAHEDRON", "QUADRANGLE", "CATENOID", "RHOMBOID", "WEDGE", "SEMICIRCLE", "LIMACON", "CIRCUMFERENCE", "GEODESIC", "PARALLELOGRAM", "CHORD", "PLANE", "PARABOLOID", "CONCHOID", "CONICOID", "PENCIL", "PARABOLA", "DECAGON", "CARDIOID", "CIRCLE" },

                new GridList() {
                "  .  . . .   .   ",
                "  C  A C.LOCUS.  ",
                ".HYPERBOLA.. P   ",
                "  L  C N M.SOLID.",
                ".KITE..OGIVE.I   ",
                "  N  L I.N.CONE. ",
                "  D.QUADRANT.E C ",
                " .E .N..O. O . U ",
                ".TRAPEZIUM.RHOMB.",
                " O. R.O L C. C E ",
                " R  I N.EVOLUTE. ",
                " U .SHEET.N  A   ",
                " S  M ..TRIDENT. ",
                " .  .LINE.C  T   ",
                "        . .  .   "});

                case 9503:
                    return new GameModel(9503, 746, 17, 15,
                new WordList() { "SULKY", "SHAY", "YAWL", "LORRY", "TILBURY", "BUGGY", "BUS", "YACHT", "DRAY", "JITNEY", "JALOPY", "TAXI", "TRUCK", "TUBE", "VAN", "LITTER", "SHIP", "COASTER", "HANSOM", "SALOON", "WAIN", "SAMPAN", "CART", "TANKER", "MONORAIL", "SEDAN", "SLEDGE", "GIG", "BIKE", "CAB" },
                new WordList() { "SULKY", "SHAY", "YAWL", "LORRY", "TILBURY", "BUGGY", "BUS", "YACHT", "DRAY", "JITNEY", "JALOPY", "TAXI", "TRUCK", "TUBE", "VAN", "LITTER", "SHIP", "COASTER", "HANSOM", "SALOON", "WAIN", "SAMPAN", "CART", "TANKER", "MONORAIL", "SEDAN", "SLEDGE", "GIG", "BIKE", "CAB", "ZEPPELIN", "BULLDOZER", "DROSHKY", "MOTOR", "SNOWPLOUGH", "OMNIBUS", "SCOOTER", "TRACTOR", "PADDYWAGON", "AUTOGIRO", "WAGONETTE", "PENNYFARTHING", "LIMOUSINE", "OUTBOARD", "ROADSTER", "HOTROD", "TRAIN", "WAGON", "LOCOMOTIVE", "QUADRICYCLE", "FLIVVER", "SUBMARINE", "PULLMAN", "RICKSHAW", "SCHOONER", "AUTOMOBILE", "BARQUENTINE", "FUNICULAR", "BICYCLE", "HOVERCRAFT", "LANDAULETTE", "ROCKET", "PALANQUIN", "CONVERTIBLE", "BROUGHAM", "TOBOGGAN", "SPEEDBOAT", "CHARIOT", "MONOPLANE", "SLED", "HURDLE", "LAUNCH", "PANTECHNICON", "BRIGANTINE", "HELICOPTER", "CURRICLE", "CARAVAN", "SLEIGH", "CATAMARAN", "BAROUCHE", "FRIGATE", "LINER", "BALLOON", "CLIPPER", "GONDOLA", "BUCKBOARD", "DIESEL", "CONCORDE", "LIFEBOAT", "VELOCIPEDE", "AEROPLANE", "PLANE", "CANOE", "CAR", "JEEP", "GLIDER", "CARRIAGE", "COACH", "DILIGENCE", "FIACRE", "HACK" },

                new GridList() {
                " .  .  . .   . . ",
                ".SHAY..V J ..BUS.",
                " L  A.TAXI.S I H ",
                " E .WAIN.TRUCK.I ",
                " D  L L. N L E P ",
                ".GIG. B  E K . . ",
                " E. .BUGGY.YACHT.",
                " .C C R .....  A ",
                ".JALOPY.H.SALOON.",
                "  B A . A A I  K ",
                "  ..SEDAN.M.TUBE.",
                ".CART.R S P T  R ",
                "    E A O A E  . ",
                " .LORRY.MONORAIL.",
                "    . . . . .    "});

                case 9504:
                    return new GameModel(9504, 824, 17, 15,
                new WordList() { "ENZYMES", "SAVOURY", "SWISS", "YEAST", "INDUSTRY", "YAK", "GORGONZOLA", "BYRE", "TINT", "COWS", "GRUYERE", "DAIRY", "DERBY", "GOATS", "EWES", "DESSERT", "MATURE", "RAW", "WHITE", "KETONES", "SKIM", "CHURN", "FAT", "SAPID", "AROMA", "FETA", "MILK", "CREAM", "BAR", "HARD", "ACID", "AGED" },
                new WordList() { "ENZYMES", "SAVOURY", "SWISS", "YEAST", "INDUSTRY", "YAK", "GORGONZOLA", "BYRE", "TINT", "COWS", "GRUYERE", "DAIRY", "DERBY", "GOATS", "EWES", "DESSERT", "MATURE", "RAW", "WHITE", "KETONES", "SKIM", "CHURN", "FAT", "SAPID", "AROMA", "FETA", "MILK", "CREAM", "BAR", "HARD", "ACID", "AGED", "PIZZA", "MOZZARELLA", "SWITZERLAND", "YELLOW", "GUERNSEY", "TEXTURE", "JERSEY", "STILTON", "STRONG", "PHOSPHORUS", "AYRSHIRE", "VITAMINS", "CULTURE", "PASTEURISE", "ACIDITY", "PIQUANT", "HOOPS", "ROQUEFORT", "FLAVOUR", "RICOTTA", "BUTTERMILK", "DAIRYMAIDS", "ACIDULOUS", "PROVOLONE", "CRIMSON", "PROTEIN", "MOULD", "SHARP", "SEASONING", "RENNET", "PEPTIDES", "MARES", "COTTAGE", "LACTOSE", "CURD", "SALTED", "DEVONSHIRE", "TECHNIQUE", "PARMESAN", "SMOKED", "FERMENT", "NETHERLANDS", "GOUDA", "FONDUE", "RENNIN", "MICROBES", "LIMBURGER", "CURED", "LLAMAS", "RAREBIT", "CAROTENE", "EMMENTHAL", "CASEIN", "SLICE", "CAMEMBERT", "CALCIUM", "CHESHIRE", "TABLE", "BUFFALO", "FARMER", "PENICILLIN", "BACTERIA", "ACETIC", "CACHAT", "CHEESE", "MILD", "RAIL", "BRIE", "FRANCE", "EDAM", "CHEDDAR" },

                new GridList() {
                " .  .   .   .  . ",
                ".SAPID. B .DERBY.",
                " K  N A A.  N  E ",
                " I  D.GORGONZOLA.",
                ".MATURE..O. Y  S ",
                " .. S D .AROMA.T ",
                ".WHITE.FETA.E. . ",
                "  A R C .SWISS.K ",
                ".GRUYERE... .A E ",
                " .D.. E.BYRE.V T ",
                " A.E.FAT.A   O O ",
                ".COWS.MILK.CHURN.",
                " I E  .N .   R E ",
                ".DESSERT.DAIRY.S ",
                " . .   .     . . "});

                case 9505:
                    return new GameModel(9505, 748, 17, 15,
                new WordList() { "PRIZE", "ZIPPERS", "LUXURY", "BUYER", "QUALITY", "MONEY", "ASSETS", "PURSE", "STORE", "TRAPS", "DISPLAY", "POSTER", "SHEETS", "STOCK", "GROCERY", "EWERS", "WARES", "SOAP", "LIFTS", "GOODS", "STAFF", "ITEM", "SPEND", "SILK", "CASH", "DESK", "SALE", "CREDIT", "FIRM" },
                new WordList() { "PRIZE", "ZIPPERS", "LUXURY", "BUYER", "QUALITY", "MONEY", "ASSETS", "PURSE", "STORE", "TRAPS", "DISPLAY", "POSTER", "SHEETS", "STOCK", "GROCERY", "EWERS", "WARES", "SOAP", "LIFTS", "GOODS", "STAFF", "ITEM", "SPEND", "SILK", "CASH", "DESK", "SALE", "CREDIT", "FIRM", "PAYMENT", "TOWELS", "TURNOVER", "SHOWROOMS", "BUSINESS", "RESTAURANTS", "PERFUMERY", "CONSUMERS", "DISTRIBUTOR", "IRONMONGERY", "FURNITURE", "DRAPERY", "SUPPLIER", "COSMETICS", "JEWELLERY", "MILLINERY", "DISHWASHERS", "MANUFACTURERS", "SHEARS", "EMPORIUM", "ACCOUNT", "PROFIT", "LIQUIDISERS", "NUTCRACKERS", "ESCALATORS", "PERCOLATORS", "ORDERS", "RECEIPTS", "CATALOGUES", "DEPARTMENT", "SERVICE", "HABERDASHERY", "MANCHESTER", "REFRIGERATORS", "MARKET", "VEGETABLES", "FASHION", "TRADING", "CLOTHING", "MARKETING", "SHOPKEEPER", "TRADE", "RETAIL", "LIGHTING", "BARGAINS", "MATERIAL", "TOBACCO", "APPLIANCES", "BRANCHES", "HARDWARE", "OVERHEAD", "CASHIER", "CHARGES", "MERCHANDISE", "FOOD", "RECORD", "HANDBAGS", "MANAGER", "CHAIN", "BEDDING" },

                new GridList() {
                " .  .   . .  . . ",
                ".PRIZE.STOCK.S D ",
                " O  I C R A  P I ",
                ".SOAP.R A.SHEETS.",
                " T  P E P H. N P ",
                " E  E.DESK.S D L ",
                " R .R.I .  T . A ",
                " .ASSETS.GROCERY.",
                " . T.W. L .R . . ",
                " S A.E.PURSE.B G ",
                " A.FIRM.X I. U O ",
                ".LIFTS.QUALITY.O ",
                " E .E.  R K  E D ",
                " . .MONEY..WARES.",
                "    .   .    . . "});

                case 9506:
                    return new GameModel(9506, 706, 17, 15,
                new WordList() { "BUZZARD", "QUETZAL", "OSPREY", "SWAN", "STORK", "SPARROW", "OWL", "EMU", "BLUETIT", "CROW", "TERN", "WREN", "PARROT", "BITTERN", "RATITE", "LYREBIRD", "STARLING", "AUK", "GULL", "QUAIL", "CUCKOO", "IBIS", "ROBIN", "ORIOLE", "BROLGA", "RAIL", "COB", "EIDER", "EAGLE" },
                new WordList() { "BUZZARD", "QUETZAL", "OSPREY", "SWAN", "STORK", "SPARROW", "OWL", "EMU", "BLUETIT", "CROW", "TERN", "WREN", "PARROT", "BITTERN", "RATITE", "LYREBIRD", "STARLING", "AUK", "GULL", "QUAIL", "CUCKOO", "IBIS", "ROBIN", "ORIOLE", "BROLGA", "RAIL", "COB", "EIDER", "EAGLE", "RAZORBILL", "CASSOWARY", "VULTURE", "TITMOUSE", "SKYLARK", "SWALLOW", "PITTA", "CANARY", "NUTHATCH", "HONEYEATER", "OSTRICH", "ALBATROSS", "FROGMOUTH", "STONECHAT", "SANDGROUSE", "CURRAWONG", "GOSHAWK", "GOOSE", "CORMORANT", "KITTIWAKE", "KESTREL", "FLYCATCHER", "BULBUL", "PHEASANT", "RAVEN", "WAGTAIL", "GANNET", "PETREL", "PTARMIGAN", "JACKASS", "LAPWING", "MOORHEN", "SANDPIPER", "THORNBILL", "DARTER", "ROSELLA", "COCKATOO", "SHELDUCK", "WOODCOCK", "KOOKABURRA", "WEAVERBIRD", "HUMMINGBIRD", "MOA", "HERON", "MACAW", "CONDOR", "WHIPBIRD", "PARTRIDGE", "WOODPECKER", "BUTCHERBIRD", "BOWERBIRD", "GROSBEAK", "ROLLER", "KINGFISHER", "NIGHTINGALE", "FANTAIL", "HORNBILL", "COLIN", "BUDGERIGAR", "HARRIER", "BULLFINCH", "DODO", "BLUEBIRD", "FLAMINGO", "MOCKINGBIRD", "MAGPIE", "JACKDAW", "GREENFINCH", "FALCON", "MALLARD", "PELICAN", "GOLDFINCH", "PEACOCK", "RIFLEBIRD", "BLACKBIRD", "CHAFFINCH", "DABCHICK" },

                new GridList() {
                " .   .       .   ",
                " C .BROLGA.ROBIN.",
                " O A A .  C  U   ",
                ".BLUETIT.QUETZAL.",
                " . K.I.E  C  Z . ",
                " I .STORK.K. A L ",
                ".BITTERN..OSPREY.",
                " I. A.I.CROW.D R ",
                ".SPARROW.A.A . E ",
                " .A L L .I N   B ",
                "  R I.EAGLE.   I ",
                ".WREN.. U..EIDER.",
                "  O G.OWL. M   D ",
                "  T .   L.QUAIL. ",
                "  .     .  .     "});

                case 9507:
                    return new GameModel(9507, 802, 17, 15,
                new WordList() { "RAZZAMATAZZ", "ZOO", "TRAPEZE", "GYMNAST", "ARTISTS", "SHOW", "NETS", "STAR", "TENT", "FLYER", "TRUCK", "TUMBLERS", "ACTORS", "FUN", "VAN", "BUSKER", "LIONS", "RISK", "WHIP", "CLOWN", "WAGON", "TAMER", "TRAINER", "ACT", "ROPE", "SKILL", "BEARS", "RING", "MAGIC", "BAND", "CAGE" },
                new WordList() { "RAZZAMATAZZ", "ZOO", "TRAPEZE", "GYMNAST", "ARTISTS", "SHOW", "NETS", "STAR", "TENT", "FLYER", "TRUCK", "TUMBLERS", "ACTORS", "FUN", "VAN", "BUSKER", "LIONS", "RISK", "WHIP", "CLOWN", "WAGON", "TAMER", "TRAINER", "ACT", "ROPE", "SKILL", "BEARS", "RING", "MAGIC", "BAND", "CAGE", "SAWDUST", "VARIETY", "STUNTMAN", "MONKEYS", "ASSISTANT", "SOMERSAULTS", "COSTUME", "ROUSEABOUT", "COMEDY", "HORSES", "SPOTLIGHT", "SIDESHOW", "MUSICIANS", "TIGHTWIRE", "ATTRACTION", "EQUESTRIAN", "ANTICS", "CIRCUS", "HARNESS", "BICYCLES", "TIGHTROPE", "UNIFORM", "CANVAS", "FEATS", "EXCITEMENT", "RINGMASTER", "SHOWPEOPLE", "SPANGLES", "ADVERTISING", "BARNUM", "APPLAUSE", "CAROUSEL", "CROWD", "POPCORN", "SPECTACULAR", "LAUGHTER", "ELEPHANTS", "TIGER", "FERRIS", "MAKEUP", "GREASEPAINT", "AERIALIST", "BANDSTAND", "ANIMALS", "JUGGLER", "PERFORMER", "SPECTACLE", "DAREDEVILS", "CARNIVAL", "ACROBAT", "CARAVAN", "HOOPLA", "POLE", "ROAD", "RIDER", "AUDIENCE", "MENAGERIE", "ARENA", "DANGER", "MAGICIAN", "PARADE", "BALANCING", "BILLBOARD", "FANFARE", "BALANCE", "BAREBACK" },

                new GridList() {
                "  .  .      .  . ",
                "  T.BAND.CLOWN.B ",
                ".FUN.C . .  H  U ",
                "  M.STAR.R.LIONS.",
                "  B .O O A  P. K ",
                "  L.TRAPEZE..G E ",
                ".BEARS.E Z.FLYER.",
                "  R A. . A  .M . ",
                " .SKILL. M.VAN.N ",
                " .. N. M A .CAGE.",
                ".TAMER.ARTISTS.T ",
                " E .RING.A H.T S ",
                " N  .S I.ZOO.. . ",
                ".TRUCK.C Z.WAGON.",
                " .   . . . .     "});

                case 9508:
                    return new GameModel(9508, 778, 17, 15,
                new WordList() { "SLIVOVITZ", "RYE", "USSR", "TURKEY", "TOKAY", "SHERRY", "WINERY", "ITALY", "PERRY", "RUM", "SWEET", "MALMSEY", "PORT", "AZERBAIJAN", "WATER", "ROSE", "SOIL", "CORKS", "SPAIN", "WINE", "GRAPES", "NOG", "VODKA", "CASK", "GROG", "RHONE", "CHIANTI", "GIN", "APPLE", "GREECE" },
                new WordList() { "SLIVOVITZ", "RYE", "USSR", "TURKEY", "TOKAY", "SHERRY", "WINERY", "ITALY", "PERRY", "RUM", "SWEET", "MALMSEY", "PORT", "AZERBAIJAN", "WATER", "ROSE", "SOIL", "CORKS", "SPAIN", "WINE", "GRAPES", "NOG", "VODKA", "CASK", "GROG", "RHONE", "CHIANTI", "GIN", "APPLE", "GREECE", "WHISKY", "BURGUNDY", "MANZANILLA", "HUNGARY", "SPIRITS", "MUSCAT", "VERMOUTH", "BOUQUET", "CHERRY", "CULTURE", "HARVEST", "BRANDY", "CANARY", "WINEPRESS", "DESSERT", "EXTRACT", "SAUTERNE", "ODOUR", "WHITE", "MUSCATEL", "PORTUGAL", "RETSINA", "AUSTRALIA", "DUBONNET", "PUNCH", "CHARDONNAY", "BOURBON", "VINTAGE", "CRUSHED", "WEATHER", "BORDEAUX", "CALVADOS", "SPARKLING", "KIRSCH", "MOSELLE", "AROMATIC", "RIESLING", "MARSALA", "ARGENTINE", "BEAUJOLAIS", "APERITIF", "VINIFERA", "CLARET", "AROMA", "JUICE", "DRAMBUIE", "CLIMATE", "COLLECT", "FORTIFIED", "LOIRE", "RHINE", "TABLE", "PERENNIAL", "CAMPARI", "CHABLIS", "BEVERAGE", "BENEDICTINE", "ALCOHOL", "CHAMPAGNE", "COGNAC", "FRANCE", "MADEIRA", "ALGERIA", "MALAGA", "CIDER", "PEACH", "MEAD" },

                new GridList() {
                "   .    .   . .  ",
                " . S .APPLE.U W  ",
                " R P G .O. .SOIL.",
                " O A.R.GRAPES.N  ",
                ".SLIVOVITZ. R.E  ",
                " E.NOG.N.E  .P.  ",
                " . .D. .GREECE.. ",
                ".CASK.   B  .RUM.",
                " H.WATER.A  .R A ",
                " I E.U .WINERY.L ",
                " A E R R J  H. M ",
                " N.TOKAY.A.CORKS.",
                " T . E E N  N  E ",
                ".ITALY.. .SHERRY.",
                " .   .      .  . "});

                case 9509:
                    return new GameModel(9509, 762, 17, 15,
                new WordList() { "ZEUS", "ZEALOTS", "YORK", "ROMSEY", "PRIORY", "GROTTO", "TOTEM", "VESPERS", "TRANSEPT", "PULPIT", "SHINTO", "FONT", "TOMB", "WELLS", "ABBEY", "EASTER", "SPIRE", "PISA", "BISHOP", "NAVE", "SHRINE", "SEE", "ALTAR", "ICON", "KIRK", "BEADS", "ARK", "GRAIL", "KALPA", "NICHE" },
                new WordList() { "ZEUS", "ZEALOTS", "YORK", "ROMSEY", "PRIORY", "GROTTO", "TOTEM", "VESPERS", "TRANSEPT", "PULPIT", "SHINTO", "FONT", "TOMB", "WELLS", "ABBEY", "EASTER", "SPIRE", "PISA", "BISHOP", "NAVE", "SHRINE", "SEE", "ALTAR", "ICON", "KIRK", "BEADS", "ARK", "GRAIL", "KALPA", "NICHE", "MUEZZIN", "OLYMPUS", "SANCTUARY", "MONASTERY", "SALISBURY", "SYNAGOGUE", "WESTMINSTER", "MOSQUE", "CANTERBURY", "ACOLYTE", "LAMASERY", "WORSHIP", "AVESTA", "MINSTER", "WORCESTER", "EPIPHANY", "MISSAL", "BRISTOL", "JUPITER", "GLOUCESTER", "WINCHESTER", "COMMUNION", "EXETER", "CLOISTER", "MANTRA", "OXFORD", "CHARTRES", "PETERBOROUGH", "CHESTER", "NORWICH", "STEEPLE", "PARTHENON", "LIVERPOOL", "MINARET", "NIRVANA", "REQUIEM", "DURHAM", "TEMPLE", "KRISHNA", "VICAR", "CENOTAPH", "ORGAN", "ARCHBISHOP", "APOLLO", "ASGARD", "BELLS", "CANON", "HOPE", "LINCOLN", "CARLISLE", "CHOIR", "DIOCESE", "CANDLEMAS", "VALHALLA", "CATHEDRAL", "BASILICA", "HEREFORD", "PREACHER", "PAGODA", "KEEP", "RELIC", "DEACON", "CARDINAL", "ARCHANGEL", "CHAPEL", "DEAN" },

                new GridList() {
                " . . .     .   . ",
                " W.NAVE..ALTAR.E ",
                " E I E B   R . A ",
                " L C S I.BEADS.S ",
                " L H.PISA. N H T ",
                ".SEE.E H ..SPIRE.",
                " ...PRIORY.E N R ",
                " .ZEUS.P.O P.T . ",
                "  E L. .GROTTO.A ",
                ".KALPA.ARK..O. B ",
                "  L I I A.K.TOMB.",
                ".FONT.C I I E  E ",
                "  T . O L.ROMSEY.",
                " .SHRINE. K .  . ",
                "  .   .   .      "});

                case 9510:
                    return new GameModel(9510, 706, 17, 15,
                new WordList() { "KAZOO", "ZITHER", "WURLITZER", "ZAMPOGNA", "TUDUM", "LYRE", "PSALTERY", "MUSETTE", "SPOONS", "LUTE", "SITAR", "SPINET", "DRUM", "RATTLE", "VIOL", "CORNET", "VIOLIN", "TABOR", "HORN", "PANPIPE", "DARBUK", "HARP", "PIPE", "OBOE", "OCARINA", "CELLO", "FIFE" },
                new WordList() { "KAZOO", "ZITHER", "WURLITZER", "ZAMPOGNA", "TUDUM", "LYRE", "PSALTERY", "MUSETTE", "SPOONS", "LUTE", "SITAR", "SPINET", "DRUM", "RATTLE", "VIOL", "CORNET", "VIOLIN", "TABOR", "HORN", "PANPIPE", "DARBUK", "HARP", "PIPE", "OBOE", "OCARINA", "CELLO", "FIFE", "SYMPHONIUM", "TRUMPET", "XYLOPHONE", "QUINTON", "CYMBALS", "CASTANETS", "SAXHORN", "WHISTLE", "SOUSAPHONE", "BASSOON", "VIOLETTA", "GUITAR", "GITTERN", "SACKBUT", "EUPHONIUM", "FLUTE", "AUTOHARP", "SAXOPHONE", "CONTRABASS", "KETTLEDRUM", "COMPONIUM", "TROMBONE", "TAMBOURINE", "TIMPANI", "MANDOBASS", "CORNO", "VIOLA", "TIMBALES", "FLEXATONE", "CELESTE", "CLAPPERS", "VIRGINAL", "KONIGHORN", "VIOLONCELLO", "GONG", "ORGAN", "PIANO", "SHAKER", "ALPHORN", "TRIANGLE", "FLUGELHORN", "HARPSICHORD", "CLARINET", "DULCIMER", "MARACAS", "LIRONE", "RACKET", "BUGLE", "MANDOLIN", "COWBELL", "SHIELD", "BOMBARDON", "MELODEON", "CLAVICHORD", "PICCOLO", "HARMONICA", "CARILLON", "RECORDER", "ACCORDION", "FLAGEOLET", "GADULKA", "UKELELE", "BANJO", "DIDGERIDOO", "GEKKIN", "BAGPIPE", "CALLIOPE", "BANJOLELE", "ALBOKA", "HANDBELL", "CRECELLE", "BELL", "BALALAIKA", "FIDDLE" },

                new GridList() {
                "  .    . . .   . ",
                " .DARBUK.H.CELLO.",
                "  R .  A A O . B ",
                ".WURLITZER.R F O ",
                " .M U  O.PANPIPE.",
                " S..TABOR. E F.. ",
                ".PIPE. ..ZITHER. ",
                " O S.    A . .A  ",
                ".OCARINA.MUSETTE.",
                " N L   . P P  T  ",
                ".SITAR.VIOLIN.L  ",
                " . E   I G N  E  ",
                "   R .HORN.E  .  ",
                " .LYRE.L A.TUDUM.",
                "   .   . . .     "});

                case 9511:
                    return new GameModel(9511, 772, 17, 15,
                new WordList() { "ZIGZAGGER", "ZIPPERS", "CUT", "WOOLS", "SATINS", "VELVETS", "CROSS", "PRESS", "TUCK", "WELT", "ADJUST", "MUSLIN", "WORK", "SEAMS", "ART", "SLEEVES", "PLEATS", "CANVAS", "WEAVE", "WEAVING", "TIE", "DRAWN", "IRON", "PIN", "RAISE", "BIAS", "DIOR", "PIPED", "WELDED", "REEL", "LACE" },
                new WordList() { "ZIGZAGGER", "ZIPPERS", "CUT", "WOOLS", "SATINS", "VELVETS", "CROSS", "PRESS", "TUCK", "WELT", "ADJUST", "MUSLIN", "WORK", "SEAMS", "ART", "SLEEVES", "PLEATS", "CANVAS", "WEAVE", "WEAVING", "TIE", "DRAWN", "IRON", "PIN", "RAISE", "BIAS", "DIOR", "PIPED", "WELDED", "REEL", "LACE", "TAPESTRY", "VESTMENTS", "SCISSORS", "BRUSSELS", "EYELET", "PATTERNS", "STITCHES", "TATTING", "BUTTONHOLES", "KNOT", "DARTS", "DRESS", "OVERCAST", "SEWING", "POCKETS", "RUNNING", "GARMENTS", "KNITTING", "QUILTING", "WAISTLINE", "MEASUREMENT", "MONOGRAMS", "FITTING", "DRESSMAKERS", "PUNCH", "EMBROIDERY", "HEMS", "GATHERS", "VENETIAN", "ARRAS", "BOUND", "RUFFLES", "SHIRRING", "SMOCKING", "MOSAIC", "RHODES", "ELASTIC", "TAILORING", "GODET", "INTERLINING", "RENAISSANCE", "HANGINGS", "CRAFT", "MOIRE", "SHELL", "DESIGN", "CROCHET", "GOBELINS", "MATERIAL", "TACKING", "THIMBLE", "BRAIDS", "CREWEL", "NAPKIN", "THREAD", "BATIK", "INTERFACING", "FILLET", "DECORATE", "LINEN", "ARMHOLE", "DARNING", "FEATHER", "NEEDLES", "RICHELIEU", "MEND", "FANCIFUL", "PINKED", "CANDLEWICK", "BRODERIE", "BOBBIN", "LAPPED", "BARGELLO", "DELICATE", "CHAIN", "MADEIRA", "FABRIC", "EDGE" },

                new GridList() {
                " .   .     .   . ",
                ".ZIGZAGGER.C   A ",
                " I   R     R   D ",
                " P  .TIE.DIOR. J ",
                ".PIN... P  S L.U ",
                " E  P.WORK.SEAMS.",
                ".REEL.E E W..CUT.",
                " S  E A.SLEEVES. ",
                " ..CANVAS.L E.L  ",
                " D .T E...D L I  ",
                ".RAISE.B.WEAVING.",
                " A R..PIPED.E .  ",
                ".WOOLS.A L..TUCK.",
                " N N  .SATINS.   ",
                " . .   . .  .    "});

                case 9512:
                    return new GameModel(9512, 764, 17, 15,
                new WordList() { "TANSY", "SAVORY", "CURRY", "THYME", "BAY", "COSTMARY", "BETONY", "SALSIFY", "ROSEMARY", "MULBERRY", "PORT", "SALT", "CHERRY", "MINT", "COMFREY", "RUE", "CRANBERRY", "SPICES", "PIMENTO", "CICELY", "MELONS", "SESAME", "LEMON", "LIME", "COCOA", "FENNEL", "BALM", "MACE" },
                new WordList() { "TANSY", "SAVORY", "CURRY", "THYME", "BAY", "COSTMARY", "BETONY", "SALSIFY", "ROSEMARY", "MULBERRY", "PORT", "SALT", "CHERRY", "MINT", "COMFREY", "RUE", "CRANBERRY", "SPICES", "PIMENTO", "CICELY", "MELONS", "SESAME", "LEMON", "LIME", "COCOA", "FENNEL", "BALM", "MACE", "BRAZIL", "HYSSOP", "DITTANY", "EUCALYPTUS", "PARSLEY", "MUSTARD", "CARAWAY", "NUTMEG", "SASSAFRAS", "CRESS", "SHALLOTS", "BURNET", "CHICORY", "ZINGIBERACEAE", "CLOVES", "CAYENNE", "TURMERIC", "SPEARMINT", "WOODRUFF", "SHALLOT", "SORREL", "CUMIN", "SMOKE", "LEMONGRASS", "CAPSICUM", "ONION", "PEPPERMINT", "JUNIPER", "WINTERGREEN", "CASSIA", "TARRAGON", "GRAPEFRUIT", "APRICOT", "TABASCO", "NECTARINES", "HOREHOUND", "GINSENG", "SAFFRON", "ANISE", "HERBS", "SARSAPARILLA", "BERGAMOT", "FEVERFEW", "BLACKCURRANT", "SAGE", "LOVAGE", "PEPPER", "CINNAMON", "MARJORAM", "AVOCADO", "CHERVIL", "OREGANO", "VANILLA", "VERBENA", "AROMA", "BASIL", "CHIVE", "PINE", "LAVENDER", "CARDOON", "ALMOND", "ORANGE", "FENUGREEK", "ALLSPICE", "MANDARIN", "ANISEED", "PAPRIKA", "PINEAPPLE", "GINGER", "CARDAMOM", "CORIANDER", "CAMOMILE", "CALENDULA", "DANDELION", "BORAGE", "LICORICE", "GARLIC", "DILL", "ANGELICA", "FIG", "LEEK" },

                new GridList() {
                "  . . . .    . . ",
                ".SPICES.MACE.B C ",
                "  I H E E    E O ",
                "  M E.SALT.  T S ",
                "  E R A O. .PORT.",
                "  N R.MINT. .N M ",
                " .THYME.SAVORY.A ",
                "  O..U.C.N  O..R ",
                " ..B L U.SALSIFY.",
                ".CRANBERRY. E E. ",
                " O L E R .LEMON. ",
                ".COMFREY. I A N  ",
                " O . R .  M.RUE. ",
                " A.BAY.CICELY.L  ",
                " .   .    . . .  "});

                case 9601:
                    return new GameModel(9601, 830, 17, 15,
                new WordList() { "MIZZEN", "PRIZE", "YAWL", "DORY", "PUNT", "TUG", "ARGOSY", "WHERRY", "TUB", "SCOW", "FERRY", "DUGOUT", "TOSHER", "ROWBOAT", "TRAMP", "GALLEY", "JUNK", "SHIP", "SLAVER", "TRAWLER", "BOAT", "RAFT", "SHOALER", "KETCH", "SKIFF", "LOG", "ARK", "COG", "GALLEON", "BRIG", "GIG", "BARGE", "COBLE" },
                new WordList() { "MIZZEN", "PRIZE", "YAWL", "DORY", "PUNT", "TUG", "ARGOSY", "WHERRY", "TUB", "SCOW", "FERRY", "DUGOUT", "TOSHER", "ROWBOAT", "TRAMP", "GALLEY", "JUNK", "SHIP", "SLAVER", "TRAWLER", "BOAT", "RAFT", "SHOALER", "KETCH", "SKIFF", "LOG", "ARK", "COG", "GALLEON", "BRIG", "GIG", "BARGE", "COBLE", "CAPSIZE", "YACHT", "DESTROYER", "CUTTER", "BOWSPRIT", "VESSEL", "PONTOON", "TUGBOAT", "DINGHY", "SHOWBOAT", "KAYAK", "SLOOP", "CORVETTE", "MOTORBOAT", "PUTELI", "WARSHIP", "HOUSEBOAT", "CRUISER", "GUNBOAT", "OUTRIGGER", "SMUGGLER", "COASTER", "STEAMER", "DHOW", "SAMPAN", "PRIVATEER", "SUBMARINE", "HULK", "SCHOONER", "TRIMARAN", "BARQUENTINE", "CORSAIR", "TRIREME", "UMIAK", "HOVERCRAFT", "PIRATE", "TANKER", "PROA", "SPEEDBOAT", "BARQUE", "LUGGER", "TENDER", "TRADER", "WHALEBOAT", "WINDJAMMER", "MERCHANTMAN", "CRAFT", "SHELL", "LAUNCH", "WHALER", "DRIFTER", "LIGHTER", "BRIGANTINE", "CARVEL", "PACKET", "SEALER", "CATAMARAN", "FREIGHTER", "FLAGSHIP", "FRIGATE", "LINER", "GONDOLA", "DERELICT", "LIFEBOAT", "PINNACE", "PADDLEBOAT", "INDIAMAN", "COCKLESHELL", "LOCKER", "COLLIER", "CANOE", "BIREME", "FELUCCA", "CORACLE", "DREDGER", "BINNACLE" },

                new GridList() {
                "   .   . . .   . ",
                " . G  .C W.TRAMP.",
                ".SHIP.TOSHER.. U ",
                " K G.TUG.E A C N ",
                " I .A.B..ROWBOAT.",
                ".FERRY.  R L B . ",
                " F..GALLEY.E.LOG.",
                " .SCOW.  . R E A ",
                "  H.SLAVER.. . L ",
                ".DORY. . A . P L ",
                "  A .J B F.BARGE.",
                "  L.DUGOUT.R I O ",
                "  E  N A .MIZZEN.",
                ".ARK.KETCH.G E . ",
                "  .  . .   . .   "});

                case 9602:
                    return new GameModel(9602, 844, 17, 15,
                new WordList() { "ZOOM", "RAYS", "SUN", "HYPO", "MAGAZINES", "EYE", "SHOT", "SHOOT", "SPOOLS", "VIEW", "VISION", "PRISM", "STILL", "BOX", "MAGNIFY", "SNAP", "BULBS", "COLOUR", "TRIPOD", "CUBES", "LENS", "TIME", "MAXWELL", "MIRROR", "BICONVEX", "METER", "TAPE", "LEVER", "LIGHT", "PLATE", "ROLL", "SCENE", "IMAGE" },
                new WordList() { "ZOOM", "RAYS", "SUN", "HYPO", "MAGAZINES", "EYE", "SHOT", "SHOOT", "SPOOLS", "VIEW", "VISION", "PRISM", "STILL", "BOX", "MAGNIFY", "SNAP", "BULBS", "COLOUR", "TRIPOD", "CUBES", "LENS", "TIME", "MAXWELL", "MIRROR", "BICONVEX", "METER", "TAPE", "LEVER", "LIGHT", "PLATE", "ROLL", "SCENE", "IMAGE", "CRYSTALS", "SHUTTER", "SNAPSHOTS", "RUSHES", "STUDIO", "INFINITY", "EXPOSURE", "SENSITIVE", "PHOTOGRAPHY", "POSITIVE", "BRADY", "FOCUS", "PRINT", "PORTRAIT", "ROTOGRAVURE", "SENSITISED", "GLASS", "ATTACHMENTS", "SILVER", "EMULSION", "AUTOMATIC", "FIXES", "SHADOW", "TALBOT", "PICTURE", "TELEVISION", "APERTURE", "FLUORESCENT", "MINIATURE", "TELEPHOTO", "BELLOWS", "FILTERS", "HELIOGRAPHY", "MATCHBOX", "LEAVES", "FILMS", "NEGATIVE", "DISTANCE", "VIDEO", "CARTRIDGES", "VIEWFINDER", "FIXING", "SCREEN", "LUMIERE", "PHOTOCELL", "PICTORIAL", "PAN", "BULB", "SPEED", "MAPPING", "DARKROOM", "ENLARGEMENT", "DEVELOPER", "PROJECTED", "CHARGERS", "BROMINE", "OBJECT", "REFLEX", "FLASH", "POLAROID", "FLICKS", "HERSCHEL", "CELLULOID", "RECORD", "ENLARGER", "BLADES", "DIAPHRAGM", "INFRARED", "FRAME", "ARCHER", "CINEMA", "NIEPCE", "DARK", "LOAD", "CAMERA", "LEAF" },

                new GridList() {
                "   .   . . . . . ",
                ".TIME..LEVER.I P ",
                " . A . E I O M L ",
                ".MAGAZINES.L A.A ",
                " E N O S.I.LIGHT.",
                ".TRIPOD.BOX..EYE.",
                " E F.M.SUN.B .P. ",
                ".RAYS.. L.MIRROR.",
                " . .H C B. C ..  ",
                " S .O O.SPOOLS.  ",
                " H.STILL.R N C   ",
                " O N. O  I.VIEW. ",
                " O A.CUBES.E N   ",
                ".TAPE.R .MAXWELL.",
                " . .  .  . . .   "});

                case 9603:
                    return new GameModel(9603, 680, 17, 15,
                new WordList() { "ESSAY", "SPURS", "QUEST", "LISTS", "TILTYARD", "COURT", "PANOPLY", "SWORD", "SURCOAT", "CAVALRY", "CUIRASS", "QUIVER", "SQUIRE", "VALOUR", "CREST", "ARMS", "PALFREY", "WARRIOR", "CASTLE", "GORGET", "JENNET", "VIGIL", "HERO", "RANK", "PRINCE", "EPIC", "HERALD" },
                new WordList() { "ESSAY", "SPURS", "QUEST", "LISTS", "TILTYARD", "COURT", "PANOPLY", "SWORD", "SURCOAT", "CAVALRY", "CUIRASS", "QUIVER", "SQUIRE", "VALOUR", "CREST", "ARMS", "PALFREY", "WARRIOR", "CASTLE", "GORGET", "JENNET", "VIGIL", "HERO", "RANK", "PRINCE", "EPIC", "HERALD", "SUZERAIN", "TRUMPETS", "EMBLAZONMENT", "VENTURE", "JOUSTING", "TROUBADOURS", "TOURNAMENT", "MINSTRELS", "PAGEANTRY", "CHIVALRY", "FROISSART", "GALLANTRY", "HONOUR", "PORTCULLIS", "GAUNTLET", "ARROW", "ARMOUR", "PENNONS", "BASSINET", "ABBEY", "RUEFUL", "TILTING", "ADVENTURE", "CRUSADERS", "HERALDRY", "BATTLEMENT", "ESCUTCHEON", "ARMOURER", "HELMETS", "CORSELET", "ENSIGN", "STANDARD", "BATTLEAXE", "HATCHMENT", "GUERDON", "GLOVE", "GARTER", "KNIGHT", "INTREPID", "CAPARISON", "ALTAR", "FEUDALISM", "KNIGHTHOOD", "SEEK", "AWARD", "COURAGE", "ACHIEVEMENT", "SARACEN", "DAMSEL", "FAITH", "ORDER", "CHAMPION", "GONFALON", "HAUBERK", "LEGENDS", "SHIELD", "TABARD", "BANNER", "IDEALS", "FLETCHER", "MEDIEVAL", "DRAWBRIDGE", "DEEDS", "NOBLE", "ACHIEVE", "SCABBARD", "GRAIL", "ARCHER", "MAIDEN", "CHARLEMAGNE", "CHALLENGER", "FANFARE", "LANCE", "HALL", "BALDRIC", "ALLEGIANCE", "ACCOLADE", "GALAHAD" },

                new GridList() {
                "    .    . .   . ",
                "  ..HERO.P.CREST.",
                "  Q E .  A A . I ",
                ".CUIRASS.N.VIGIL.",
                "  I A P  O A O T ",
                " .VALOUR.PALFREY.",
                "  E D.R. L R G A ",
                " .R..ESSAY.Y E R ",
                " S.P P.U .C..T.D ",
                ".WARRIOR. A Q.A. ",
                " O I C C .SQUIRE.",
                ".RANK.COURT.E M  ",
                " D C   A .LISTS. ",
                " .JENNET. E T .  ",
                "   .   .  . .    "});

                case 9604:
                    return new GameModel(9604, 720, 17, 15,
                new WordList() { "PIAZZA", "MEZZANINE", "ZIGGURAT", "STUD", "ALCAZAR", "BAY", "HUT", "ARMOURY", "MONASTERY", "ATRIUM", "WINDOW", "LABYRINTH", "HOSTEL", "ABBEY", "GALLERY", "EAVES", "COTTAGE", "THEATRE", "ALETTE", "DOOR", "WALL", "SCAPE", "PIER", "PLAN", "DOME", "PAGODA" },
                new WordList() { "PIAZZA", "MEZZANINE", "ZIGGURAT", "STUD", "ALCAZAR", "BAY", "HUT", "ARMOURY", "MONASTERY", "ATRIUM", "WINDOW", "LABYRINTH", "HOSTEL", "ABBEY", "GALLERY", "EAVES", "COTTAGE", "THEATRE", "ALETTE", "DOOR", "WALL", "SCAPE", "PIER", "PLAN", "DOME", "PAGODA", "UNIVERSITY", "BUTTRESS", "GYMNASIUM", "OBSERVATORY", "DORMITORY", "COURT", "GROTTO", "CLERESTORY", "DISPENSARY", "SKYSCRAPER", "MOSQUE", "JOIST", "EXIT", "JOINERY", "STONEMASON", "VESTIBULE", "CHIMNEY", "LIBRARY", "ROTUNDA", "BELFRY", "CASTLES", "SOLARIUM", "AQUARIUM", "PROSCENIUM", "DRAUGHTSMEN", "COLUMN", "MITRE", "BLUEPRINT", "CLOISTER", "MONOLITH", "PILASTER", "PLASTERER", "ANNEX", "STEEPLE", "APSE", "MINARET", "PAINTER", "PLUMBER", "ARCHITECTURE", "HOTEL", "BRICKLAYER", "GRANDSTAND", "INN", "CUPOLA", "TEMPLE", "ACROPOLIS", "THEODOLITE", "ROOF", "ARCHITRAVE", "INWALL", "RAFTER", "PEDIMENT", "CARPENTER", "ERECT", "CHURCH", "ENTRANCE", "LEGATION", "VERANDA", "BUILD", "BUILDER", "EXEDRA", "PLANK", "ANTECHAMBER", "CORNICE", "CATHEDRAL", "BASILICA", "CRANE", "ARCH", "BANK", "CEILING", "FIREPLACE", "EDIFICE", "FACADE" },

                new GridList() {
                " .   .  .  .  .  ",
                " T.DOME.H .SCAPE.",
                " H   E .U  T. I  ",
                " E   Z.ATRIUM.E  ",
                ".ALCAZAR. .DOOR. ",
                " T . A M   .N .  ",
                " R.WINDOW.PIAZZA.",
                " E.A.I U    S I  ",
                " .PLAN.R.COTTAGE.",
                ".GALLERY.   E G  ",
                "  G.E. .  . R U  ",
                ".HOSTEL.ABBEY.R  ",
                "  D T     A . A  ",
                ".EAVES.LABYRINTH.",
                "  . .     .   .  "});

                case 9605:
                    return new GameModel(9605, 840, 17, 15,
                new WordList() { "USURY", "PRIZE", "ASSIZES", "JURY", "SUIT", "SURTAX", "TESTIMONY", "SUMMONS", "SUE", "USE", "WITNESS", "WRIT", "INSULT", "LAWSUIT", "TESTATOR", "ARREST", "ESCROW", "PRISON", "TREASON", "RENT", "STEAL", "OATH", "LAW", "ACT", "ROB", "ABET", "CASE", "FALSE", "LIEN", "BAR", "BENCH" },
                new WordList() { "USURY", "PRIZE", "ASSIZES", "JURY", "SUIT", "SURTAX", "TESTIMONY", "SUMMONS", "SUE", "USE", "WITNESS", "WRIT", "INSULT", "LAWSUIT", "TESTATOR", "ARREST", "ESCROW", "PRISON", "TREASON", "RENT", "STEAL", "OATH", "LAW", "ACT", "ROB", "ABET", "CASE", "FALSE", "LIEN", "BAR", "BENCH", "AVIZANDUM", "GUILTY", "STATUTE", "CRUELTY", "PERJURY", "BANKRUPTCY", "ATTESTATION", "MANDATORY", "BURGLARY", "TRESPASSER", "FELONY", "INDEMNITY", "STIPENDIARY", "ESTATE", "CONSPIRACY", "EXTENUATION", "ROBBERY", "JUSTICE", "WARRANT", "ARSON", "JUDICIARY", "ABSTRACT", "INJUNCTION", "MAGISTRATE", "ACQUITTAL", "COLLUSION", "SOLICITOR", "PRISONER", "SUBPOENA", "JUDGMENT", "CONFESSION", "BARRISTER", "LITIGANT", "VERDICT", "PROBATION", "ARBITRATION", "EXAMINATION", "SENTENCE", "FORECLOSURE", "TRIAL", "ATTAINDER", "GUARANTEE", "LOITERING", "ADVOCATE", "FORENSIC", "REPRIEVE", "AWARD", "PARDON", "ACCUSED", "ALIENATION", "LICENSING", "MAINTENANCE", "JUDGE", "VALID", "PLAINTIFF", "CAPITAL", "DEFAMATION", "PAROLE", "REMAND", "DEFENDANT", "INNOCENCE", "CRIME", "EVIDENCE", "POLICE", "APPEAL", "IMPEACH", "HOMICIDE", "DOCK", "CHARGE", "BLACKMAIL", "ILLEGAL", "LIBEL", "BAIL", "DEFENCE", "FEE" },

                new GridList() {
                " . .  .  .   . . ",
                " L.ABET.LIEN.J S ",
                " A C  E  N .SUIT.",
                ".WITNESS.S S R E ",
                " S .  T..USURY.A ",
                ".USE.BAR.L M . L ",
                " I  ..TESTIMONY. ",
                ".TREASON.. O . L ",
                " . .SURTAX.N P A ",
                ".FALSE.. .ESCROW.",
                "    I.   O . I . ",
                ".PRIZE. .ARREST. ",
                "    E.WRIT.O O   ",
                " .CASE.  H.BENCH.",
                "    .    . . .   "});

                default:
                    return new GameModel();
            }
        }
    }
}