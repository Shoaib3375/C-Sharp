using System;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "John Abraham";
            Console.WriteLine(name);
            int myNumber = 017;
            myNumber = 01; // declare a variable without assigning the value & Changed the myNumber value
            Console.WriteLine(myNumber);
            const float py = 342.34324f;
            Console.WriteLine(py);

            // Type of Declare variables
            // Camel Case: firstName
            // Pascal Case: FirstName
            // Hungarian Notation: strFirstName
            
            /* For local variables: Camel */  int number;
            /* For constants: Pasal Case */ const int MaxZoom = 5;
            
            float number = 1.4f;
            decimal number = 1.2;

        }
    }
}
