
namespace BuildingShape
{
    public class Program
    {
        public static void Main()
        {
            Rectangle rectangle = new Rectangle { Name = "Rectangle", Width = 5, Height = 10 } ;
            Circle  circle = new Circle { Name = " Circle" , Raduis = 3};
            Triangle triangle = new Triangle { Name = " Triangle", Base = 4, Height = 5 };


            PrintShapeArea(rectangle);
            PrintShapeArea(circle);
            PrintShapeArea(triangle);

        }

        public static void PrintShapeArea(Shape obj)
        {
            Console.WriteLine($"{obj.Name}  {obj.calculateArea()}");
        }
    }

}
