namespace ShapeAreaCalculator
{
    using System;
    using ShapeAreaCalculator.Enums;
    using ShapeAreaCalculator.Models;

    public class ConsoleMenu
    {
        public static void Run()
        {
            while (true)
            {
                DisplayMenu();
                var choice = GetUserChoice();

                switch ((int)choice)
                {
                    case 1:
                        DisplayShapes();
                        break;

                    case 2:
                        AddShape();
                        break;

                    case 3:
                        RemoveShape();
                        break;                    

                    case 4:
                        Console.Write("Are you sure you want to exit? (Y/N): ");

                        var confirmation = Console.ReadLine().ToUpper()[0];
                        Console.WriteLine();

                        if (confirmation == 'Y')
                        {
                            Console.WriteLine("Exiting...");
                            return; // Exit the Main method
                        }

                        Console.Clear();
                        continue;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear(); // Clear the console for the next iteration
            }
        }
                
        private static Shape GetShape()
        {
            DisplayShapes();
            Console.Write("\nEnter shape number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if (number <= 0 || number > ShapesContext.Shapes.Count)
            {
                Console.WriteLine("No shape found!");
                return null;
            }

            var shape = ShapesContext.Shapes[number - 1];            

            Console.WriteLine("Shape chosen:");
            Console.WriteLine(shape.ToString());

            return shape;
        }

        private static void RemoveShape()
        {
            Console.WriteLine("You chose to remove shape.");

            var shape = GetShape();
            if (shape == null) { return; }

            Console.Write($"Remove {shape.Type} from the list? (Y/N): ");
            var confirmation = Console.ReadLine().ToUpper()[0];
            Console.WriteLine();

            if (confirmation != 'Y')
            {
                return; 
            }

            ShapesContext.Shapes.Remove(shape);
            ShapesContext.SaveChanges();
            Console.WriteLine("Shape removed!");
        }

        private static void AddShape()
        {
            Console.WriteLine("You chose to sdd shape. Follow the steps:");
            DisplayShapeTypes();

            Console.Write("Enter shape type selection: ");
            ShapeType shapeType = (ShapeType)Convert.ToInt32(Console.ReadLine());

            Shape shape = null;
            
            switch ((int)shapeType)
            {
                case 1:
                    Console.Write("Enter Radius: ");
                    double radius = Convert.ToDouble(Console.ReadLine());

                    shape = new Circle(radius);
                    break;

                case 2:
                    Console.Write("Enter Side A: ");
                    double triangleA = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter Side B: ");
                    double triangleB = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter Side C: ");
                    double triangleC = Convert.ToDouble(Console.ReadLine());

                    shape = new Triangle(triangleA, triangleB, triangleC);
                    break;

                case 3:
                    Console.Write("Enter Side: ");
                    double squareSide = Convert.ToDouble(Console.ReadLine());

                    shape = new Square(squareSide);
                    break;

                case 4:
                    Console.Write("Enter Side A: ");
                    double recA = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter Side B: ");
                    double recB = Convert.ToDouble(Console.ReadLine());

                    shape = new Rectangle(recA, recB); 
                    break;

                case 5:
                    Console.Write("Start entering values from the longest parallel side.");
                    Console.Write("Enter Side A: ");
                    double trapezoidA = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter Side B: ");
                    double trapezoidB = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter Side C: ");
                    double trapezoidC = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter Side D: ");
                    double trapezoidD = Convert.ToDouble(Console.ReadLine());

                    shape = new Trapezoid(trapezoidA, trapezoidB, trapezoidC, trapezoidD);
                    break;

                case 6:
                    Console.Write("Enter Sides Count: ");
                    int count = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Side: ");
                    double polySide = Convert.ToDouble(Console.ReadLine());

                    shape = new RegularPolygon(count, polySide);
                    break;
            }

            ShapesContext.Shapes.Add(shape);
            ShapesContext.SaveChanges();

            Console.WriteLine($"New shape {shape.Type} added.");
        }

        private static void DisplayShapes()
        {
            Console.WriteLine("\n*********** Shapes ************\n");

            for (var i = 0; i < ShapesContext.Shapes.Count; i++)
            {
                var shape = ShapesContext.Shapes[i];
                Console.WriteLine($"[{i + 1}] " + shape.ToString());
                Console.WriteLine();
            }
        }

        private static MenuChoice GetUserChoice()
        {
            var input = Console.ReadLine();
            return Enum.TryParse(input, out MenuChoice choice)
                ? choice
                : 0;
        }

        private static string GetChoiceName(MenuChoice menuChoice)
        {
            return (int)menuChoice switch
            {
                1 => "Display Shapes List",
                2 => "Add Shape",
                3 => "Remove Shape",
                4 => "Exit"
            };
        }

        private static void DisplayMenu()
        {
            Console.WriteLine("************ Main Menu ************");
            Console.WriteLine("Please choose an action:\n");

            foreach (MenuChoice choice in Enum.GetValues(typeof(MenuChoice)))
            {
                if (choice != 0)
                {
                    var name = GetChoiceName(choice);
                    Console.WriteLine($"    [{(int)choice}]:    {name}");
                }
            }

            Console.Write("\nEnter your selection: ");
        }

        private static void DisplayShapeTypes()
        {
            Console.WriteLine("\nShape Types:\n");

            foreach (ShapeType shapeType in Enum.GetValues(typeof(ShapeType)))
            {
                if (shapeType != 0)
                {
                    Console.WriteLine($"    [{(int)shapeType}]:    {shapeType}");
                }
            }
            Console.WriteLine();
        }

        public static Type GetShapeType(ShapeType shapeType)
        {
            return shapeType switch
            {
                ShapeType.Circle => typeof(Circle),
                ShapeType.Triangle => typeof(Triangle),
                ShapeType.Square => typeof(Square),
                ShapeType.Rectangle => typeof(Rectangle),
                ShapeType.Trapezoid => typeof(Trapezoid),
                ShapeType.RegularPolygon => typeof(RegularPolygon),
                _ => typeof(Shape),
            };
        }
    }
}
