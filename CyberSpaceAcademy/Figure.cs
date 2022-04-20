using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberSpaceAcademy
{
    public class Figure
    {
        public int X { get; set; }

        public static Figure operator +(Figure left, Figure right)
        {
            Figure result = new Figure()
            {
                X = left.X + right.X,
            };
            return result;
        }

        public static Figure operator -(Figure left, Figure right)
        {
            Figure result = new Figure()
            {
                X = left.X - right.X,
            };
            return result;
        }

        public static bool operator ==(Figure left, Figure right)
        {
            bool a = false;
            if (left.X == right.X)
                a = true;
            return a;
        }

        public static bool operator !=(Figure left, Figure right)
        {
            bool a = false;
            if (left.X != right.X)
                a = true;
            return a;
        }

    }
}
