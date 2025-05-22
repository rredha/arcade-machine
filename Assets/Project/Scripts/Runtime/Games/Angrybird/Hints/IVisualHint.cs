using UnityEngine;
using System.Collections;
using Arcade.Project.Runtime.Games.AngryBird.Interfaces;
using Arcade.Project.Runtime.Games.AngryBird.Configurations;

namespace Arcade.Project.Runtime.Games.AngryBird.Hints
{
  public interface IVisualHint
  {
    public void Initialize(SpriteRenderer sp, Color color);

    public void OnHintEnabled();

    public void OnHintDisabled();

    public void HintToggle();
  }
}
