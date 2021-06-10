using System;
using System.Collections.Generic;
using System.Text;

namespace GeometriSOLID
{
    public class Square
    {
        public Double Siden { get; private set; }

        public Square(Double a)
        {
            Siden = a;

        }

        public virtual Double Circumference()
        {
            return Siden * 4;
        }

        public virtual Double Areal()
        {
            return Math.Pow(Siden, 2);
        }
    }

    class Rektangel : Square
    {
        public Double Siden_2 { get; private set; }
        public Rektangel(Double a, Double b) : base(a)
        {
            Siden_2 = b;
        }
        public override Double Circumference()
        {
            return Siden * 2 + Siden_2 * 2;
        }
        public override Double Areal()
        {
            return Siden * Siden_2;
        }
    }

    class parallelogram : Square
    {
        //
        public Double Siden_2 { get; private set; }
        public Double angle { get; private set; }
        public parallelogram(Double a, Double b, Double c) : base(a)
        {
            Siden_2 = b;
            angle = c;
        }
        public override Double Circumference()
        {
            return 2 * Siden + 2 * Siden_2;
        }
        public override Double Areal()
        {
            double H = Siden * Siden_2 ;
            return Siden * Siden_2 * Math.Sin(angle);
            //sin(vinkel)
        }
    }

    class Trapez : Square
    {
        public Double Siden_2 { get; private set; }
        public Double Siden_3 { get; private set; }
        public Double Siden_4 { get; private set; }
        public Trapez(Double a, Double b, Double c, Double d) : base(a)
        {
            Siden_2 = b;
            Siden_3 = c;
            Siden_4 = d;
        }
        public override Double Circumference()
        {
            Double S = Siden + Siden_2 - Siden_3 + Siden_4 / 2;
            Double Hdel_1 = Siden - Siden_3 / 2;
            Double Hdel_2_1 = S - Siden + Siden_3;
            Double Hdel_2_2 = S - Siden_2;
            Double Hdel_2_3 = S - Siden_4;
            Double Hdel_2_4 = S * Hdel_2_1 * Hdel_2_2 * Hdel_2_3;
            Double Hdel_2_5 = Math.Sqrt(Hdel_2_4);
            Double H = Hdel_1 * Hdel_2_5;

            Double OmkredsDel_1 = Siden + Siden_2 + H;


            Double A = Math.Pow(Math.Sin(H / Siden_4), -1);
            Double B = Math.Pow(Math.Sin(H / Siden_2), -1);
            Double OmkredsDel_2_1 = 1 / Math.Sin(A);
            Double OmkredsDel_2_2 = 1 / Math.Sin(B);
            Double OmkredsDel_2_3 = OmkredsDel_2_1 + OmkredsDel_2_2;

            return OmkredsDel_1 - OmkredsDel_2_3;

        }
        public override Double Areal()
        {
            Double S = Siden + Siden_2 - Siden_3 + Siden_4 / 2;
            Double Hdel_1 = Siden - Siden_3 / 2;
            Double Hdel_2_1 = S - Siden + Siden_3;
            Double Hdel_2_2 = S - Siden_2;
            Double Hdel_2_3 = S - Siden_4;
            Double Hdel_2_4 = S * Hdel_2_1 * Hdel_2_2 * Hdel_2_3;
            Double Hdel_2_5 = Math.Sqrt(Hdel_2_4);
            Double H = Hdel_1 * Hdel_2_5;

            return Siden + Siden_3 * H / 2;
        }
    }

    class triangle : Square
    {
        public Double Siden_2 { get; private set; }
        public Double Siden_3 { get; private set; }
        public triangle(Double a, Double b, Double c) : base(a)
        {
            Siden_2 = b;
            Siden_3 = c;
        }
        public override Double Circumference()
        {
            return Siden + Siden_2 + Siden_3;
        }
        public override Double Areal()
        {
            return Siden * Siden_2 / 2;
        }
    }
}
