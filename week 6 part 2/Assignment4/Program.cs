namespace Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.start();
        }

        void start()
        {
            //Ask the user for the radius of the circle
            Console.Write("Enter the radius of the circle: ");
            double radius = double.Parse(Console.ReadLine());

            //Create a circle object
            Circle circle = new Circle(radius);

            //Display the information
            circle.DisplayInfo();

            Console.ReadKey();
        }

    }

    class Circle
    {
        //Private fields
        private double _radius;

        //Initialize the radius
        public Circle(double radius)
        {
            _radius = radius;
        }

        //Calculated property for Area
        public double Area
        {
            get { return Math.PI * _radius * _radius; }
        }

        //Method to display the circle information
        public void DisplayInfo()
        {
            Console.WriteLine($"Radius: {_radius}");
            Console.WriteLine($"Area: {Area:F2}");
        }
    }
}