using System;
using CrozzleInterfaces;

namespace CrozzleShapeMerger;

public readonly record struct ShapeIndexModel
{
	public readonly List<int> Start;
	public readonly List<byte> WordCount;
	public readonly List<byte> W;
	public readonly List<byte> X;
    public readonly List<byte> Y;
    public readonly List<byte> Z;
    public readonly List<byte> L;



	public ShapeIndexModel(in List<ShapeModel> shapes)
	{
		int startPos = 0;
		List<int> start = new List<int>();
        List<byte> wordCount = new List<byte>();
        List<byte> w = new List<byte>();
        List<byte> x = new List<byte>();
        List<byte> y = new List<byte>();
        List<byte> z = new List<byte>();
        List<byte> l = new List<byte>();


        for (int shapeId=0; shapeId < shapes.Count; shapeId++)
        {
            ShapeModel shape = shapes[shapeId];

            int wordsCount = (int)shape.Placements.Count;
            wordCount.Add((byte)wordsCount);
            for (int placementId = 0; placementId < wordsCount; placementId++)
            {
                PlacementModel placement = shape.Placements[placementId];

                w.Add(placement.W);
                x.Add(placement.X);
                y.Add(placement.Y);
                l.Add(placement.L);
                if (placement.Z == true) {
                    z.Add(1);
                } else
                {
                    z.Add(0);
                }
            }

            start.Add(startPos);
            startPos += wordsCount;
        }

        Start = start;
        WordCount = wordCount;
        W = w;
        X = x;
        Y = y;
        Z = z;
        L = l;

    }
}