using System;
using System.Collections.Generic;
using System.Text;

namespace RPGzinho.Character
{
    public class Enemy
    {
        private string Name;
        private double Life;
        private double Resistence;
        private int Speed;
        private double Damage;
        private double CriticalChance;
        private int HeavyAttacksCount;
        private string HeavyAttackName;
        Enemy(int type)
        {
            if (type == 1)
            {
                this.Name = "Goblin";
                this.Life = 50;
                this.Damage = 15;
                this.Resistence = 10;
                this.Speed = 0;
                this.CriticalChance = 20;
                this.HeavyAttacksCount = 4;
                this.HeavyAttackName = "Dinamite improvisada";

            }
            if (type == 2)
            {
                this.Name = "Orc";
                this.Life = 125;
                this.Damage = 25;
                this.Resistence = 30;
                this.Speed = -3;
                this.CriticalChance = 0;
                this.HeavyAttacksCount = 3;
                this.HeavyAttackName = "Masmagador de Cranios";
            }
            if (type == 3)
            {
                this.Name = "Werewolf";
                this.Life = 150;
                this.Resistence = 20;
                this.Damage = 35;
                this.Speed = -2;
                this.CriticalChance = 20;
                this.HeavyAttacksCount = 2;
                this.HeavyAttackName = "Retalhacao";
            }
        }


            public string NameHeavyAttack { get; set; }
            public string EnemyName { get; set; }

        public double LightAttack()
        {
            double DamageAttack;
            Random crit = new Random();
            if(crit.Next(0, 100) <= CriticalChance)            
                return DamageAttack = (Damage/2) + ((Damage * (CriticalChance / 2)) / 100);
            else
                return DamageAttack = (Damage/2);
        }
        public double HeavyAttack()
        {
            double DamageAttack;
            Random crit = new Random(); 
            if (crit.Next(0, 100) <= CriticalChance)
                return DamageAttack = (Damage) + ((Damage * CriticalChance) / 100);
            else
                return DamageAttack = (Damage);
        }

        public void Defence(double attack)
        {
            Random crit = new Random();

            if (crit.Next(0, 100) <= CriticalChance)
                Life -= (attack - Resistence);
            else
                Life -= (attack - Resistence / 2);
        }
    }

}
