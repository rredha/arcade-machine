using UnityEngine;

namespace Arcade._Project.Pong.GameStateMachine
{
    public class GameStateContext 
    {
        private GameManager _gameManager;
        private GameObject _playerPaddle;
        private GameObject _computerPaddle;
        private GameObject _ball;
        private GameObject _rightWall;
        private GameObject _leftWall;

        public GameStateContext(GameManager gameManager, GameObject playerPaddle,GameObject computerPaddle,GameObject ball, GameObject rightWall, GameObject leftWall)
        {
            _gameManager = gameManager;
            _playerPaddle = playerPaddle;
            _computerPaddle = computerPaddle;
            _ball = ball;
            _rightWall = rightWall;
            _leftWall = leftWall;
        }

        public GameManager GameManager => _gameManager;
        public GameObject PlayerPaddle => _playerPaddle;
        public GameObject ComputerPaddle => _computerPaddle;
        public GameObject Ball => _ball;
        public GameObject RightWall => _rightWall;
        public GameObject LeftWall => _leftWall;
    }
}