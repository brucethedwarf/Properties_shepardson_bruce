namespace Properties_shepardson_bruce
{
    // Define the namespace (optional depending on project structure)
    internal class Program
    {
        // Entry point of the application
        static void Main(string[] args)
        {
            // Create a new Car object called car
            Car car = new Car();
            car.Make = "Ford";        // Set the make of the car
            car.Model = "Mustang";    // Set the model of the car

            // Print the make and model of the first car
            Console.WriteLine($"make: {car.Make}, Model:{car.Model}");

            // Create another Car object called car2
            Car car2 = new Car();
            car.Make = "chevy";        // This incorrectly modifies 'car', not 'car2'
            car2.Model = "comero";     // Set the model of car2

            // Print the make and model of the second car
            Console.WriteLine($"make: {car2.Make}, Model:{car2.Model}");
            // NOTE: car2.Make will still be null or default unless Car has a default value

            // Create a third Car object called car3
            Car car3 = new Car();

            // Print the make and model of the third car
            Console.WriteLine($"make: {car3.Make}, Model:{car3.Model}");
            // Both values will likely be null or default unless Car sets defaults internally
        }
    }

}