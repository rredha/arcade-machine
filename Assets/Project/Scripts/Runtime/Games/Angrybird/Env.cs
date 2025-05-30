using UnityEngine;
using System.Collections;

namespace Arcade.Project.Runtime.Games.AngryBird
{
  public class Env : MonoBehaviour
  {
    [SerializeField] private Rigidbody2D _envRigidBody;
    private bool hasMoved;
    public bool DidItReallyMove()
    {
      return _envRigidBody.linearVelocity.magnitude != 0f;
    }

    public bool HasMoved
    {
      get { return hasMoved; }
      private set { hasMoved = DidItMove(); }
    }

    private bool DidItMove()
    {
      return _envRigidBody.linearVelocity.magnitude != 0f;
    }
  }
}
