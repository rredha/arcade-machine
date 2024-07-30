namespace Arcade._Project.Pong.GameStateMachine
{
    public class GameStateContext 
    {
        private GameManager _gameManager;

        public GameStateContext(GameManager gameManager)
        {
            _gameManager = gameManager;
        }

        public GameManager GameManager => _gameManager;
    }
}