

string[] snacks = { "sushi", "pizza", "burger", "chiken wings", "Asian takeway" };

Random rnd = new Random();

int randomIndex = rnd.Next(0, snacks.Length);

Console.WriteLine($"Tonighte we are going to eat {snacks[randomIndex]}.");