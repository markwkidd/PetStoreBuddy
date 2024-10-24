using System;
using System.Text.Json;

namespace PetStore
{
    class PetStoreBuddy
    {
        static void Main()
        {
            string? userInput = String.Empty;
            ProductLogic logic = new ProductLogic();

            Console.WriteLine("***PET STORE BUDDY***");
            do
            {
                Console.Write("\n");
                Console.WriteLine("Enter '1' to add a product");
                Console.WriteLine("Enter '2' to search for a dog leash");
                Console.WriteLine("Enter '8' to lits all products");
                Console.WriteLine("Enter 'exit' to quit\n");
                Console.Write("> ");

                userInput = Console.ReadLine();
                if (userInput == null) return;
                Console.Write("\n\n");

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

                    logic.AddProduct(testProduct);
                    Console.WriteLine($"Product: {testProduct.Name} has been added to inventory.");

                } else if (userInput == "2")
                {
                    DogLeash? retrieved = null;
                    Console.Write("Product search\nEnter the name of the dog leash: ");
                    userInput = Console.ReadLine();
                    if (userInput != null) retrieved = logic.GetDogLeashByName(userInput.Trim());
                    if (retrieved == null)
                    {
                        Console.Write("Product not found.");
                    }
                    Console.WriteLine("Product found.");
                    Console.WriteLine(JsonSerializer.Serialize(retrieved));


                }
                else if (userInput == "8")
                {
                    List<Product> products = logic.GetAllProducts();
                    foreach (var product in products)
                    {
                        Console.WriteLine(JsonSerializer.Serialize(product));
                    }
                }
            } while (userInput != null && userInput.ToLower() != "exit"); // testing for null here only to silence a warning

        }
    }
}

