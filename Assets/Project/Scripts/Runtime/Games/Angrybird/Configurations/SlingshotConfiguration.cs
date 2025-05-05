using UnityEngine;

namespace Arcade.Project.Runtime.Games.AngryBird.Configurations
{
    [CreateAssetMenu]
    public class SlingshotConfiguration : ScriptableObject
    {
        [Range(0.1f, 3.0f)]
        public float maxLength;

        [Range(-4.0f, -3.0f)]
        public float bottomBoundary;

        [Range(1.0f, 8.0f)]
        public float force;
    }
}
