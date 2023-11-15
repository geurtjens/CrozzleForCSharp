using System;
namespace CrozzleInterfaces
{
	public readonly record struct ShapeModel
	{
		public readonly byte width;
		public readonly byte height;
		public readonly ushort score;
		public readonly List<PlacementModel> placements;



		public ShapeModel(ushort score, byte width, byte height, in List<PlacementModel> placements)
		{
            this.score = score;
            this.width = width;
			this.height = height;
			
			this.placements = placements;
		}

        public ShapeModel(in List<PlacementModel> placements)
        {
            width = 0;
            height = 0;
            score = 0;
            this.placements = placements;
        }
    }
}

