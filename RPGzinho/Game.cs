using System;
using System.Collections.Generic;
using System.Text;

namespace RPGzinho.Character
{
    public class Game
    {

        //CharacterCreate
        CreateCharacter NewCharacter = new CreateCharacter();
        CharacterInfo characterInfo = new CharacterInfo();

        //game loop
        public void gameLoop(){
            //Create character part
            NewCharacter.ShowCreation();
            do
            {
                //Character Info
                Console.Clear();
                characterInfo.Info();
                //Storyteller
                //fight
            } while (NewCharacter.CharacterUpdate.LifeUpdate > 0);
            //End Game
        } 

    }
}
