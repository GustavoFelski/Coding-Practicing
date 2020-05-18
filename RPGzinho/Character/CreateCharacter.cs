using System;
using System.Collections.Generic;
using System.Text;

namespace RPGzinho.Character
{
    public class CreateCharacter : ICharacter
    {
        //TODO Create a interface from character and Character create 
        //TODO Create a Overload to create a enemy charaters
        private static Character Character = new Character();

        public string ClasseUpdate { get ; set; }
        public double CriticalChanceUpdate { get ; set ; }
        public double DamageUpdate { get; set; }
        public double LifeUpdate { get ; set ; }
        public int MagicPointsUpdate { get ; set ; }
        public string NameUpdate { get ; set; }
        public int PotionsUpdate { get ; set ; }
        public double ResistenceUpdate { get; set ; }
        public int SpeedUpdate { get ; set ; }

        public void ShowCreation()
        {
            bool opc = true;
            string Aux;
            
            // Chosse the adventures name
            #region Name
            Console.WriteLine("Bem Vindo Aventureiro\nQual o seu nome?");
            Character.NameUpdate = Console.ReadLine();
            #endregion

            do {
            #region Chossing the class
            //TODO Change this description to english 
            Console.WriteLine($"{Character.NameUpdate}, neste jogo você tem a opção de escolher entre as classes\n" +
                $"Guerreiro: Maior vida e resistencia porem o dano é o mais baixo dentre as demais classes\n" +
                $"Mago: Maior dano e dano dano critico, tem uma chance critica baixa e uma vida e resistencia baixa\n" +
                $"Ladino: Maior chance critica, dano critico e vida moderados e baixa resistencia\n" +
                $"Escreva o nome da classe que vc deseja jogar");

                //TODO change this for read a file with the class hero parameters 
            Aux = Console.ReadLine();
            Aux.ToUpper();

                switch (Aux)
                {
                    case "GUERREIRO":
                        {
                            Character.ClassCharacter = "warrior";
                            Character.LifeUpdate = 150;
                            Character.CriticalChanceUpdate = 10;
                            Character.ResistenceUpdate = 30;
                            Character.SpeedUpdate = -2;
                            Character.PotionsUpdate = 2;
                            Character.MPupdade = 2;
                            opc = true;
                            break;
                        }
                    case "MAGO":
                        {
                            Character.ClassCharacter = "mage";
                            Character.LifeUpdate = 50;
                            Character.CriticalChanceUpdate = 10;
                            Character.ResistenceUpdate = 10;
                            Character.SpeedUpdate = -1;
                            Character.PotionsUpdate = 5;
                            Character.MPupdade = 6;
                            opc = true;
                            break;
                        }
                    case "LADINO":
                        {
                            Character.ClassCharacter = "ladino";
                            Character.LifeUpdate = 100;
                            Character.CriticalChanceUpdate = 30;
                            Character.ResistenceUpdate = 20;
                            Character.SpeedUpdate = -0;
                            Character.PotionsUpdate = 3;
                            Character.MPupdade = 4;
                            opc = true;
                            break;
                        }
                    default:
                        Console.WriteLine("Entrada incorreta, por favor digite novamente uma opção.");
                        opc = false;
                        break;
                }
                
            } while (opc != true);
        #endregion

        }

    }
}
