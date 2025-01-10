using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace Exercise
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            var circle1 = new Area.Circle(); 
            circle1.radius = 10;
            circle1.CallArea();


            var rectangle1 = new Area.Rectangle();
            rectangle1.Length = 10;
            rectangle1.Breadth = 20;
            rectangle1.CallArea();

            var triangle1 = new Area.Triangle();
            triangle1.Base_ = 10;
            triangle1.Height = 20;
            triangle1.CallArea();




        }
    }
}
