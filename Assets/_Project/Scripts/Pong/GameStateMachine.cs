using Arcade._Project.Core.StateMachine;

namespace Arcade._Project.Pong
{
    public class GameStateMachine : StateMachine<GameStateMachine.GameStateEnum>
    {
        public enum GameStateEnum
        {
            Init,
            Playing,
            Win,
            Lost,
        }

        private void Start()
        {
           InitialiazeStates(); 
        }
        
        private void InitialiazeStates()
        {
            States.Add(GameStateEnum.Init, gameObject.AddComponent<InitState>());
            //States.Add(LevelState.Playing, new Playing(LevelState.Playing, snakeHead, segmentPrefab));
            States.Add(GameStateEnum.Playing, gameObject.AddComponent<PlayingState>());
            CurrentState = States[GameStateEnum.Init];
        }
    }
}