using UnityEngine;
using UnityEngine.EventSystems;

namespace Arcade._Project.Pong
{
    public class PongScoringZone : MonoBehaviour
    {
        public EventTrigger.TriggerEvent scoreTrigger;

        private void OnCollisionEnter2D(Collision2D col)
        {
            //gives us the object that collided with our object
            Ball ball = col.gameObject.GetComponent<Ball>();

            if (ball != null)
            {
                BaseEventData eventData = new BaseEventData(EventSystem.current);
                scoreTrigger.Invoke(eventData);
            }
        }
    }
}
