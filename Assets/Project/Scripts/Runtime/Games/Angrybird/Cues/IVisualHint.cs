using UnityEngine;
using System.Collections;
using Arcade.Project.Runtime.Games.AngryBird.Interfaces;
using Arcade.Project.Runtime.Games.AngryBird.Configurations;

namespace Arcade.Project.Runtime.Games.AngryBird.Cues
{
  public interface IVisualHint
  {
    public void OnHintEnabled();

    public void OnHintDisabled();

    public void HintToggle();
  }
}
