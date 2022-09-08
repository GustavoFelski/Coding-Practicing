using System;

public class GameLooping
{
	public GameLooping(){
		
	}
	public void Game()
	{
		bool die = false;

		do {
			Introduction Intro = new Introduction();
			Intro.Intro();
		
		} while(die == false);
	}
}
