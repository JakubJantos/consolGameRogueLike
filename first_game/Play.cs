using System;

namespace first_game
{
    public class Play
    {
        public void StartGame()
        {
            
            
            
            Dialogs dialogs = new Dialogs();
            dialogs.StartingDialogs();

            Menu menu = new Menu();
            menu.InGameMenu();

            MapRendering mapRendering = new MapRendering();
            mapRendering.MapRender(false);

            PlayerMovment playerMovment = new PlayerMovment();
            playerMovment.Move();
        }
    }
}