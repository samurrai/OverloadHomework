using System;

public class Tank
{
    private string _name;
    private int damage;
    private int armor;
    private int agility;
    public Random random;

    public Tank(string name)
    {
        _name = name;
        random = new Random();
        damage = random.Next(0, 100);
        armor = random.Next(0, 100);
        agility = random.Next(0, 100);
    }
    public string GetCharacteristic()
    {
        return $"{_name} : damage - {damage}, armor - {armor}, agility - {agility}";
    }

    public static int operator *(Tank first, Tank second)
    {
        if ((first.agility > second.agility && first.damage > second.damage) ||
           (first.armor > second.armor && first.damage > second.damage) ||
           (first.agility > second.agility && first.armor > second.armor))
        {
            return 1;
        }
        else if ((first.agility == second.agility && first.damage == second.damage) ||
           (first.armor == second.armor && first.damage == second.damage) ||
           (first.agility == second.agility && first.armor == second.armor))
        {
            throw new Exception();
        }
        return -1;
    }
}