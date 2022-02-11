using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino_Simulator.Models
{
    class Balls
    {
        // All chip colors
        public enum ChipColor
        {
            Red,
            White,
            Blue,
            Yellow,
            Green,
            Pink,
            Grey,
            Black,
            Purple
        }
        // Holds Chip values based on color, cannot be edited
        public static readonly Dictionary<ChipColor, int> ChipValue = new()
        {
            {ChipColor.Red, 1 },
            {ChipColor.White, 5 },
            {ChipColor.Blue, 10 },
            {ChipColor.Yellow, 20 },
            {ChipColor.Green, 50 },
            {ChipColor.Pink, 100 },
            {ChipColor.Grey, 500 },
            {ChipColor.Black, 1000 },
            {ChipColor.Purple, 5000 }
        };
    }
}
