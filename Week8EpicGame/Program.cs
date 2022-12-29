string folderPath = @"C:\Data";
string heroFile = "heroes.txt";
string villainFile = "villains.txt";

string[] Heroes = File.ReadAllLines(Path.Combine(folderPath,heroFile));
string[] Villains = File.ReadAllLines(Path.Combine(folderPath, villainFile));

//string[] Heroes = { "Achilles", "Heracles", "Odysseus", "Perseus", "Theseus" };
//string[] Villains = { "Medusa", "Cerberus", "Paris", "Minotaur", "Hades" };
string[] Weapons = { "spear", "sword", "slingshot", "axe", "dagger" };

string villain = GetRandomValueFromArray(Villains);
string villainWeapon = GetRandomValueFromArray(Weapons);
Console.WriteLine($"Today {villain} is causing trouble with a {villainWeapon}...");

string hero = GetRandomValueFromArray(Heroes);
string heroWeapon = GetRandomValueFromArray(Weapons);
Console.WriteLine($"...but {hero} uses a {heroWeapon} and saves the day!");

static string GetRandomValueFromArray(string[] someArray)
{
    Random rnd = new Random();
    int randomIndex = rnd.Next(0, someArray.Length);
    string randomString = someArray[randomIndex];
    return randomString;
}