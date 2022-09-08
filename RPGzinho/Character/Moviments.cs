using System;
using System.Collections.Generic;
using System.Text;

namespace RPGzinho.Character
{
    class Moviments
    {
        //TODO Create a interface form character and Combate
        
        public double LightAttack()
        {
            double DamageAttack;
            Random crit = new Random();
            if (crit.Next(0, 100) <= CriticalChance)
                return DamageAttack = (Damage / 2) + ((Damage * (CriticalChance / 2)) / 100);
            else
                return DamageAttack = (Damage / 2);
        }
        public double HeavyAttack()
        {
            double DamageAttack;
            Random crit = new Random();
            if (crit.Next(0, 100) <= CriticalChance)
                return DamageAttack = Damage + ((Damage * CriticalChance) / 100);
            else
                return DamageAttack = Damage;
        }

        public void Defence(double attack)
        {

            Random crit = new Random();
            if (crit.Next(0, 100) <= CriticalChance)
                Life -= (attack - Resistence);
            else
                Life -= (attack - Resistence / 2);
        }
        public void UsePotionLife()
        {
            if (this.ClassCharacter == "warrior") Life = 150;
            if (this.ClassCharacter == "mage") Life = 50;
            if (this.ClassCharacter == "ladino") Life = 100;
        }
    }
}
