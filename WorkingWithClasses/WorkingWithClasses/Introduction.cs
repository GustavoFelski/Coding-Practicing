using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Introduction
{
    public void Intro()
    {
        Character mainCharacter = new Character();
        Console.WriteLine("Welcome Adventure, What is your name?");
        mainCharacter.Name = Console.ReadLine();
        Console.WriteLine("And what is your Profession?");
        mainCharacter.Job = Console.ReadLine();
        Console.WriteLine("all right and now, Where did you born?");
        mainCharacter.Origem = Console.ReadLine();

        Console.WriteLine("well done, Prepare to your adventure!");
    }
}
