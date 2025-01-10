namespace Assignment5
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
            int number = 10;

            //get the orginal value

            Console.WriteLine($"Original Value: {number}");

            //Call ModifyByValue
            ModifybyValue(number);
            Console.WriteLine($"Value after ModifyByReference: {number}");

            //Call ModifyByReference
            ModifyByReference(ref number);
            Console.WriteLine($"Value after ModifyByReference: {number}");

            Console.ReadKey();
        }

        void ModifybyValue(int value)
        {
            value += 10;
        }

        void ModifyByReference(ref int value)
        {
            value += 10;
        }
    }
}
