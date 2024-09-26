using System.Text.Json.Serialization;

public class Weapons
{
    public string Name;

    private int DamageMin;

    private int DamageMax;

    public int Attack;
    {
        return Random.Shared.Next(DamageMin, DamageMax);
    }
}