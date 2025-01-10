using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    internal class Area
    {
        
        const decimal pi = 3.14m;

        public void CallArea()
        {
            
            CalculateArea();
            
        } 
        protected virtual void CalculateArea() 
        {
            decimal Area = 0;
            Console.WriteLine(Area);
        }


        public class Circle : Area
        {
            public decimal radius;
            protected override void CalculateArea()
            {
                decimal Area = pi * radius * radius;
                Console.WriteLine(Area);
            }

        }
        public class Rectangle : Area
        {
            public decimal Breadth;
            public decimal Length;
            protected override void CalculateArea()
            {
                decimal Area = Length * Breadth;
                Console.WriteLine(Area);
            }

        }
        public class Triangle: Area
        {
            public decimal Base_;
            public decimal Height;
            protected override void CalculateArea()
            {
                decimal Area = 0.5m * (Base_ * Height);
                Console.WriteLine(Area);
            }

        }
    }
   
}
