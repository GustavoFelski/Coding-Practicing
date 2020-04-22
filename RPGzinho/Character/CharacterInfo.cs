using System;
using System.Collections.Generic;
using System.Text;

namespace RPGzinho.Character
{
    public class CharacterInfo 
    {

        Character character;
        String HP;

        //This function is to display hearts Instead of Numbers
        protected void HPInfo()
        {
            StringBuilder ADD = new StringBuilder();
            for (int i = 0; i <= character.LifeUpdate; i +=25)
            {
                ADD.Append("<3");
            }
            HP = ADD.ToString();
        }
        //This function is to display characters information 
        public void Info()
        {
            Console.WriteLine(  $"HP: {HP} | Potions HP: {character.PotionsUpdate.ToString()} | " +
                                $"Potion MP: {character.MPupdade.ToString()}| " +
                                $"Classe:{character.ClassCharacter} | " +
                                $"Chance Critica {character.CriticalChanceUpdate.ToString()} %\n" +
                                $"Resistencia a Dano: {character.ResistenceUpdate.ToString()} | " +
                                $"Velocidade: {character.SpeedUpdate.ToString()}" );
        }
    }
}
