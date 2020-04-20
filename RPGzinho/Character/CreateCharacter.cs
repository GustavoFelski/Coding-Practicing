using System;
using System.Collections.Generic;
using System.Text;

namespace RPGzinho.Character
{
    public class CreateCharacter
    {

        static Character Character = new Character();
        public void ShowCreation()
        {
            bool opc = true;
            string Aux;
            
            
            #region Name
            Console.WriteLine("Bem Vindo Aventureiro\nQual o seu nome?");
            Character.CharacterName = Console.ReadLine();
            #endregion

            do {
            #region Chossing the class
            Console.WriteLine($"{Character.CharacterName}, neste jogo você tem a opção de escolher entre as classes\n" +
                $"Guerreiro: Maior vida e resistencia porem o dano é o mais baixo dentre as demais classes\n" +
                $"Mago: Maior dano e dano dano critico, tem uma chance critica baixa e uma vida e resistencia baixa\n" +
                $"Ladino: Maior chance critica, dano critico e vida moderados e baixa resistencia\n" +
                $"Escreva o nome da classe que vc deseja jogar");

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
