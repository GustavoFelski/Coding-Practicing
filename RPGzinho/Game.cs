using System;
using System.Collections.Generic;
using System.Text;

namespace RPGzinho.Character
{
    public class Game
    {

        //CharacterCreate
        CreateCharacter NewCharacter = new CreateCharacter();
        
        //game loop
        public void gameLoop(){
            //Create character part
            NewCharacter.ShowCreation();
            CharacterInfo characterInfo = new CharacterInfo();

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
