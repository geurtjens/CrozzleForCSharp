using System;
using CrozzleInterfaces;

namespace CrozzleShapeMerger;

public readonly record struct ShapeIndex
{
	public readonly List<int> Start;
	public readonly List<byte> WordCount;
	public readonly List<byte> W;
	public readonly List<byte> X;
    public readonly List<byte> Y;
    public readonly List<byte> Z;
    public readonly List<byte> L;



	public ShapeIndex(in List<ShapeModel> shapes)
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

            int wordsCount = (int)shape.placements.Count;
            wordCount.Add((byte)wordsCount);
            for (int placementId = 0; placementId < wordsCount; placementId++)
            {
                PlacementModel placement = shape.placements[placementId];

                w.Add(placement.w);
                x.Add(placement.x);
                y.Add(placement.y);
                l.Add(placement.l);
                if (placement.z == true) {
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