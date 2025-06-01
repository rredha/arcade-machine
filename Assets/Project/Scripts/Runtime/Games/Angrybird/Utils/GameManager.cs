using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Arcade.Project.Runtime.Games.AngryBird;
using Arcade.Project.Runtime.Games.AngryBird.Utils.PlayerState;
using Arcade.Project.Runtime.Games.AngryBird.Utils.GameState;

namespace Arcade.Project.Runtime.Games.AngryBird.Utils
{
  public class GameManager : MonoBehaviour
  {
    public static GameManager Instance;

    private Arcade.Project.Runtime.Games.AngryBird.Utils.PlayerState.PlayerState _playerState;
    private Arcade.Project.Runtime.Games.AngryBird.Utils.GameState.GameState _gameState;
    private bool[] has_env_moved = new bool[3];

    private void Awake()
    {
    }

    private void FixedUpdate()
    {
    }
  }
}
