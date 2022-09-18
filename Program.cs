/*
Simula's Soup
:: Tuples ::
*/

using Food;

Console.Title = "Simula's Soup";
Console.Clear();

// Create tuple for souple ;)
// (string Flavor, string MainIngredient, string SoupType) soup;

AppStart();

void AppStart()
{
    DisplayMenu();

    // Take user inputs and record them to parts of tuple
    Console.Write("Please follow along to craft your very own soup:");
    (string, string, string) userInput = GetUserInput();

    // display the soup results to the user
    DisplayCreatedSoup(userInput);
}

// Menu
void DisplayMenu()
{
    Console.WriteLine("Welcome to Simula's Soup Kitchen:");
    Console.WriteLine("---------------------------------");
    Console.WriteLine("Here are your soup options:");
    Console.WriteLine($"Flavor: 1. {Flavor.Spicy}, 2. {Flavor.Salty}, 3. {Flavor.Sweet}");
    Console.WriteLine($"Main Ingredient: 1. {MainIngredient.Mushrooms}, 2. {MainIngredient.Chicken}, 3. {MainIngredient.Carrots}");
    Console.WriteLine($"Type: 1. {FoodType.Soup}, 2. {FoodType.Stew}, or 3. {FoodType.Gumbo}");
    Console.WriteLine("---------------------------------");
}

// User Input
(string, string, string) GetUserInput()
{
    Console.WriteLine("- Enter numbers for your menu choices -");
    Console.Write("Please select your flavor: ");
    string? userFlavor = Console.ReadLine();

    Console.Write("Please select your main ingredient: ");
    string? userMainIngredient = Console.ReadLine();

    Console.Write("Please select your type: ");
    string? userType = Console.ReadLine();

    // Null check
    if (userFlavor != null && userMainIngredient != null && userType != null)
    {
        return (userFlavor, userMainIngredient, userType);
    }
    else
    {
        return ("", "", "");
    }
}

// Display the results of soup creation
void DisplayCreatedSoup((string Flavor, string MainIngredient, string FoodType) userInput)
{
    // Tuple with food enums for types
    (Flavor Flavor, MainIngredient MainIngredient, FoodType FoodType) userSoup;

    // Set the tuple Flavor
    switch (userInput.Flavor)
    {
        case "1":
            userSoup.Flavor = Flavor.Spicy;
            break;
        case "2":
            userSoup.Flavor = Flavor.Salty;
            break;
        case "3":
            userSoup.Flavor = Flavor.Sweet;
            break;
        default:
            userSoup.Flavor = Flavor.Spicy;
            break;
    }
    
    // Set the tuple Main Ingredient
    switch (userInput.MainIngredient)
    {
        case "1":
            userSoup.MainIngredient = MainIngredient.Mushrooms;
            break;
        case "2":
            userSoup.MainIngredient = MainIngredient.Chicken;
            break;
        case "3":
            userSoup.MainIngredient = MainIngredient.Carrots;
            break;
        default:    
            userSoup.MainIngredient = MainIngredient.Mushrooms;
            break;
    }
    
    // Set the tuple Food Type
    switch (userInput.FoodType)
    {
        case "1":
            userSoup.FoodType = FoodType.Soup;
            break;
        case "2":
            userSoup.FoodType = FoodType.Stew;
            break;
        case "3":
            userSoup.FoodType = FoodType.Gumbo;
            break;
        default:
            userSoup.FoodType = FoodType.Soup;
            break;
    }

    // Show the delicious soup you've made
    Console.WriteLine($"Nice! We'll be right out with your - {userSoup.Flavor} {userSoup.MainIngredient} {userSoup.FoodType}!");
}