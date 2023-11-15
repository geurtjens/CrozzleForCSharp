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
        public static List<ShapeModel> CombineShapes(in List<List<ShapeModel>> listOfShapeLists)
        {
            var result = new List<ShapeModel>();
            foreach (var item in listOfShapeLists)
            {
                result.AddRange(item);
            }
            return result;
        }
    }
}