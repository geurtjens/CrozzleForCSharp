using System;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography;
using CrozzleInterfaces;
using ShapeMakerCSharp.Calculators;
using static System.Formats.Asn1.AsnWriter;

namespace ShapeMakerCSharp
{
    public class ShapeCalculator
    {
        public static ShapeList CombineShapes(List<List<ShapeModel>> listOfShapeList)
        {
            var result = new ShapeList();
            foreach (var item in listOfShapeList)
            {
                result.AddRange(item);
            }
            return result;
        }
    }
}