/*
Simula's Soup
:: Tuples ::
*/

// Criteria:
// DONE - Define enums for Food:
    // Type (Soup, Stew, Gumbo)
    // Main Ingredient (Mushrooms, Chicken, Carrots)
    // Flavor (Spicy, Salty, Sweet)
// DONE - Create a tuple which represents a soup composed of the 3 enum types we defined
// User selects the type, main ingredient, and flavor
// Display the contents of the soup tuple variable e.g. "Sweet Chicken Gumbo"

using Food;

Console.Title = "Simula's Soup";
Console.Clear();

// Create tuple for souple ;)
(string Flavor, string MainIngredient, string SoupType) soup;

AppStart();

void AppStart()
{
    DisplayMenu();

    // Take user inputs and record them to the parts of the tuple
    Console.Write("Please follow along to craft your very own soup:");
    GetUserInput();
    
    // display the soup results to the user
}

// Menu
void DisplayMenu()
{
    Console.WriteLine("Welcome to Simula's Soup Kitchen:");
    Console.WriteLine("---------------------------------");
    Console.WriteLine("Here are your soup options:");
    Console.WriteLine($"Flavor: {Flavor.Spicy}, {Flavor.Salty}, {Flavor.Sweet}");
    Console.WriteLine($"Main Ingredient: {MainIngredient.Mushrooms}, {MainIngredient.Chicken}, {MainIngredient.Carrots}");
    Console.WriteLine($"Type: {FoodType.Soup}, {FoodType.Stew}, or {FoodType.Gumbo}");
    Console.WriteLine("---------------------------------");
}

// User Input
void GetUserInput()
{
    Console.ReadLine();
}