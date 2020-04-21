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
        private double CriticalChance;
        private double CriticalDamage;
        Enemy(int type) {
            if(type == 1)
            {
                this.Name = "Goblin";
                this.Life = 50;
                this.Resistence = 10;
                this.Speed = 0;
                this.CriticalChance = 20;
            }
            if (type == 2)
            {
                this.Name = "Orc";
                this.Life = 125;
                this.Resistence = 30;
                this.Speed = -3;
                this.CriticalChance = 0;
            }
            if (type == 3)
            {
                this.Name = "Werewolf";
                this.Life = 150;
                this.Resistence = 20;
                this.Speed = -2;
                this.CriticalChance = 20;
            }


        } 
        public void LightAttack()
        {

        }
        public void HeavyAttack()
        {

        }

        public void Defence()
        {

        }
    }

}
