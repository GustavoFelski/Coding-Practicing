using System;
using System.Collections.Generic;
using System.Text;

namespace RPGzinho.Character
{
    public class Character
    {
        private string Name;
        private string Classe;
        private double Life;
        private double Resistence;
        private double Damage;
        private int Potions;
        private int MP;
        private int Speed;
        private double CriticalChance;
        private string HeavyAttackName;

        #region Gets and Sets
        public int MPupdade { get; set; }
        public string CharacterName
        {
            get { return Name; }
            set { Name = value; }
        }
        public string ClassCharacter {
            get { return Classe; }
            set { Classe = value; }
        }
        public double LifeUpdate
        {
            get { return Life; }
            set { Life = value; }
        }
        public double ResistenceUpdate
        {
            get { return Resistence; }
            set { Resistence = value; }
        }
        public int SpeedUpdate
        {
            get { return Speed; }
            set { Speed = value; }
        }
        public double CriticalChanceUpdate
        {
            get { return CriticalChance; }
            set { CriticalChance = value; }
        }
        public int PotionsUpdate { get; set; }
        #endregion
        public double LightAttack()
        {
            double DamageAttack;
            Random crit = new Random();
            if (crit.Next(0, 100) <= CriticalChance)
                return DamageAttack = (Damage / 2) + ((Damage * (CriticalChance / 2)) / 100);
            else
                return DamageAttack = (Damage / 2);
        }
        public double HeavyAttack() {
            double DamageAttack;
            Random crit = new Random();
            if (crit.Next(0, 100) <= CriticalChance)
                return DamageAttack = Damage + ((Damage * CriticalChance) / 100);
            else
                return DamageAttack = Damage;
        }

        public void UsePotionMP() {
            if (this.ClassCharacter == "warrior") MP = 2;
            if (this.ClassCharacter == "mage") MP = 6;
            if (this.ClassCharacter == "ladino") MP =4;
        }

        public void Defence(double attack) {

            Random crit = new Random();
            if (crit.Next(0, 100) <= CriticalChance)
                Life -= (attack - Resistence);
            else
                Life -= (attack - Resistence / 2);
        }
        public void UsePotionLife () {
            if (this.ClassCharacter == "warrior") Life = 150;
            if (this.ClassCharacter == "mage") Life = 50;
            if (this.ClassCharacter == "ladino") Life = 100;
        }

    }
}
