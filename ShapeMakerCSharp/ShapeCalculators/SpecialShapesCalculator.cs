using System;
using CrozzleInterfaces;
using ShapeMakerCSharp;

namespace ShapeMakerCSharp
{
	public class SpecialShapesCalculator
	{
        // These shape values come from /Users/michaelgeurtjens/Downloads/CrozzleDataFromWinningGames/*.json
        public static List<ShapeModel> C8703(in WordList words)
        {
            var h = new WordList { "JIFFY", "LATE", "ALWAYS" };
            var v = new WordList { "DAILY", "FAST", "OFT", "YEAR" };

            var hid = h.ExtractPositions(words);
            var vid = v.ExtractPositions(words);

            var hl = h.LengthsInBytes();
            var vl = v.LengthsInBytes();

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


        public static List<ShapeModel> C8805(in WordList words)
        {
            var h = new WordList { "WOOL", "MEAT", "TANK", "HARVEST" };
            var v = new WordList { "EWE", "OATS", "ROTATION" };

            var hid = h.ExtractPositions(words);
            var vid = v.ExtractPositions(words);

            var hl = h.LengthsInBytes();
            var vl = v.LengthsInBytes();

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

        public static List<ShapeModel> C9002a(in WordList words)
        {
            var h = new WordList { "NEPTUNE", "MARS", "JUNO" };
            var v = new WordList { "REMUS", "PAN", "TROY", "URANUS" };

            var hid = h.ExtractPositions(words);
            var vid = v.ExtractPositions(words);

            var hl = h.LengthsInBytes();
            var vl = v.LengthsInBytes();

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

        public static List<ShapeModel> C9002b(in WordList words)
        {
            var h = new WordList { "OLYMPUS", "ROMULUS", "JANUS", "SATYR" };
            var v = new WordList { "URANUS", "JASON", "MUSES", "MEDUSA" };

            var hid = h.ExtractPositions(words);
            var vid = v.ExtractPositions(words);

            var hl = h.LengthsInBytes();
            var vl = v.LengthsInBytes();

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

        public static List<ShapeModel> C9101(in WordList words)
        {
            var h = new WordList { "BAT", "AMUSEMENT", "SUN", "HAT" };
            var v = new WordList { "BUSH", "CASUAL", "TENT" };

            var hid = h.ExtractPositions(words);
            var vid = v.ExtractPositions(words);

            var hl = h.LengthsInBytes();
            var vl = v.LengthsInBytes();

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


        public static List<ShapeModel> C9102(in WordList words)
        {
            var h = new WordList { "SPEED", "DOT", "CANON", "TYPE" };
            var v = new WordList { "DATA", "SONY", "LAPTOP", "NEC" };

            var hid = h.ExtractPositions(words);
            var vid = v.ExtractPositions(words);

            var hl = h.LengthsInBytes();
            var vl = v.LengthsInBytes();

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


        public static List<ShapeModel> C9109(in WordList words)
        {
            var h = new WordList { "COPYPAPER", "ANSWER", "POST", "TELLER", "ORDER" };
            var v = new WordList { "PASTE", "ENTER", "BUZZERS" };

            var hid = h.ExtractPositions(words);
            var vid = v.ExtractPositions(words);

            var hl = h.LengthsInBytes();
            var vl = v.LengthsInBytes();

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


        public static List<ShapeModel> C9204(in WordList words)
        {
            var h = new WordList { "RITUAL", "SAUCERS", "BEANS" };
            var v = new WordList { "SHRUB", "ICED", "TEA", "URN", "ASSAM" };

            var hid = h.ExtractPositions(words);
            var vid = v.ExtractPositions(words);

            var hl = h.LengthsInBytes();
            var vl = v.LengthsInBytes();

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


        public static List<ShapeModel> C9209(in WordList words)
        {
            var h = new WordList { "ALAMO", "CORPS", "TNT", "DIVISIONS" };
            var v = new WordList { "ACTION", "MONS", "FORTIFY" };

            var hid = h.ExtractPositions(words);
            var vid = v.ExtractPositions(words);

            var hl = h.LengthsInBytes();
            var vl = v.LengthsInBytes();

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


        public static List<ShapeModel> C9407(in WordList words)
        {
            var h = new WordList { "INUIT", "SCOTT", "WINTER" };
            var v = new WordList { "GUST", "ICE", "STORM" };

            var hid = h.ExtractPositions(words);
            var vid = v.ExtractPositions(words);
            
            var hl = h.LengthsInBytes();
            var vl = v.LengthsInBytes();

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

        public static List<ShapeModel> C9605(in WordList words)
        {
            var h = new WordList { "BAR", "TESTIMONY", "TREASON", "SURTAX", "FALSE" };
            var v = new WordList { "ASSIZES", "SUE", "TESTATOR", "RENT" };


            var hid = h.ExtractPositions(words);
            var vid = v.ExtractPositions(words);

            var hl = h.LengthsInBytes();
            var vl = v.LengthsInBytes();

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
}