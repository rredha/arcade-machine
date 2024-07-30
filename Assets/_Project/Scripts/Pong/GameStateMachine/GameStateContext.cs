using UnityEngine;

namespace Arcade._Project.Pong.GameStateMachine
{
    public class GameStateContext 
    {
        private GameManager _gameManager;
        private GameObject _playerPaddle;
        private GameObject _computerPaddle;
        private GameObject _ball;

        public GameStateContext(GameManager gameManager, GameObject playerPaddle,GameObject computerPaddle,GameObject ball)
        {
            _gameManager = gameManager;
            _playerPaddle = playerPaddle;
            _computerPaddle = computerPaddle;
            _ball = ball;
        }

        public GameManager GameManager => _gameManager;
        public GameObject PlayerPaddle => _playerPaddle;
        public GameObject ComputerPaddle => _computerPaddle;
        public GameObject Ball => _ball;
    }
}