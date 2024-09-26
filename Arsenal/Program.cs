using System.Text.Json;

string contents = File.ReadAllText("Weapons.json");

Weapons Zero = JsonSerializer.Deserialize<Weapons>(contents);

Console.WriteLine("Attack");

int numAttacks = 0;
string numAttacksStr = "";

while (!int.TryParse(numAttacksStr, out numAttacks))
{
    numAttacksStr = Console.ReadLine();
}

int damageSum = 0;

