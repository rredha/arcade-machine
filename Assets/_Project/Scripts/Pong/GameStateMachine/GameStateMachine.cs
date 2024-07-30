using UnityEngine;

namespace Arcade._Project.Pong.GameStateMachine
{
    public class GameStateMachine : Core.StateMachine.StateMachine<GameStateMachine.GameStateEnum>
    {
        public enum GameStateEnum
        {
            Init,
            Playing,
            Win,
            Lose,
        }

        [SerializeField] private GameManager _gameManager;
        [SerializeField] private GameObject _playerPaddle;
        [SerializeField] private GameObject _computerPaddle;
        [SerializeField] private GameObject _ball;
        private GameStateContext _context;

        private void Awake()
        {
            _context = new GameStateContext(_gameManager, _playerPaddle, _computerPaddle, _ball);
            InitializeState();
        }

        private void InitializeState()
        {
            States.Add(GameStateEnum.Init, new InitState(_context, GameStateEnum.Init));
            States.Add(GameStateEnum.Playing, new PlayingState(_context, GameStateEnum.Playing));
            CurrentState = States[GameStateEnum.Init];
        }
    }
}