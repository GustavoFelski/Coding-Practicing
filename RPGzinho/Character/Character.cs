using System;
using System.Collections.Generic;
using System.Text;

namespace RPGzinho.Character
{
    class Character
    {
        private string Name;
        private string Classe;
        private double Life;
        private double Resistence;
    
        private int Speed;
        private double CriticalChance;
        private double CriticalDamage;

        //Gets and Sets
        #region
        public string CharacterName
        {
            get { return Name; }
            set { Name = value; }
        }
        public string ClassCharacter{
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
        public double CriticalDamageUpdate
        {
            get { return CriticalDamage; }
            set { CriticalDamage = value; }
        }
        #endregion
        public void Attack() { }
        public void Defence() { }
        public void UsePotionLife () { }

    }
}
