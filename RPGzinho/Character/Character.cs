using System;
using System.Collections.Generic;
using System.Text;

namespace RPGzinho.Character
{
    /// <summary>
    /// Class Character attributes and Attacks
    /// </summary>
    public class Character : ICharacter
    {
        private string Name;
        private string Classe;
        private double Life;
        private double Resistence;
        private double Damage;
        private int Potions;
        private int MagicPoits;
        private int Speed;
        private double CriticalChance;

        #region Gets and Sets
        /// <summary> Name Characters Get/Set.</summary>
        public string NameUpdate
        {
            get { return Name; }
            set { Name = value; }
        }
        /// <summary> Classe Characters Get/Set.</summary>
        public string ClasseUpdate
        {
            get { return Classe; }
            set { Classe = value; }
        }
        /// <summary> Resistence Value Characters Get/Set. </summary>
        public double ResistenceUpdate
        {
            get { return Resistence; }
            set { Resistence = value; }
        }
        /// <summary> Hit points Characters Get/Set. </summary>
        public double LifeUpdate
        {
            get { return Life; }
            set { Life = value; }
        }
        /// <summary> Damae base attack Characters Get/Set. </summary>
        public double DamageUpdate
        {
            get { return Damage; }
            set { Damage = value; }
        }
        /// <summary> Number to Potions Uses The Characters can use, Get/Set. </summary>
        public int PotionsUpdate
        {
            get { return Potions; }
            set { Potions = value; }
        }
        /// <summary> Magic Points to Characters can use Heavy Attack ability, Get/Set. </summary>
        public int MagicPointsUpdate
        {
            get { return MagicPoits; }
            set { MagicPoits = value; }
        }
        /// <summary> Speed Combate Character (Slow -5 until 5 Quick), Get/Set. </summary>
        public int SpeedUpdate
        {
            get { return Speed; }
            set { Speed = value; }
        }
        /// <summary> Critical Chance is a value improve Attack base, Get/Set. </summary>
        public double CriticalChanceUpdate
        {
            get { return CriticalChance; }
            set { CriticalChance = value; }
        }
        #endregion
    }
}
