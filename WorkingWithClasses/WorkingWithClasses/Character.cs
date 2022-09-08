using System;

public class Character
{
    public Character()
    {
        string Name = "";
        string Origem = "";
        string Job = "";
        int life = 100;
    }

    public string Name { get; set; }
    public string Origem { get; set; }
    public string Job { get; set; }
    public int Life { get; set; }
    static void fight() { }
    static void fly() { }
    static void Die() { }


}
