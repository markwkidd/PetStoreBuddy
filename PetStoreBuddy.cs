using System;
using System.Text.Json;

namespace PetStore
{
    class PetStoreBuddy
    {
        static void Main()
        {
            string? userInput = String.Empty;
            do
            {
                Console.WriteLine("Type '1' to add a product");
                Console.WriteLine("Type 'exit' to quit");

                userInput = Console.ReadLine();
                if (userInput == null) return;
                if (userInput == "1")
                {
                    DogLeash testProduct = new DogLeash();
                    Console.WriteLine("Please enter product details for a dog leash.");

                    Console.Write("Name: ");
                    userInput = Console.ReadLine();
                    if (userInput != null) testProduct.Name = userInput;

                    Console.Write("Description: ");
                    userInput = Console.ReadLine();
                    if (userInput != null) testProduct.Description = userInput;

                    Console.Write("Material: ");
                    userInput = Console.ReadLine();
                    if (userInput != null) testProduct.Material = userInput;
                    
                    try
                    {
                        Console.Write("Price: ");
                        userInput = Console.ReadLine();
                        if (userInput != null) testProduct.Price = decimal.Parse(userInput);
                        Console.Write("Quantity: ");
                        userInput = Console.ReadLine();
                        if (userInput != null) testProduct.Quantity = int.Parse(userInput);
                        Console.Write("Length (inches): ");
                        userInput = Console.ReadLine();
                        if (userInput != null) testProduct.LengthInches = int.Parse(userInput);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Unable to parse input.");
                        continue;
                    }

                    Console.WriteLine(JsonSerializer.Serialize(testProduct));
                }
            } while (userInput != null && userInput.ToLower() != "exit"); // testing for null here only to silence a warning

        }
    }
}
