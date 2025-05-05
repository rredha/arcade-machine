using UnityEngine;

namespace Arcade._Project.Core.UI
{
    public static class Countdown
    {
        private static int _countDownInSeconds = 5;
        private static float _inBetweenCountsInSeconds = 5f;
        private static bool _countDownRunning = false;

        public static void Enable()
        {
            _countDownRunning = true;
        }
        public static void Disable()
        {
            _countDownRunning = true;
        }

        public static void Begin()
        {
            if (_countDownRunning)
            {
                if (_inBetweenCountsInSeconds > 0f)
                {
                    _inBetweenCountsInSeconds -= Time.deltaTime;
                    Debug.Log(_inBetweenCountsInSeconds.ToString());
                }
                else
                {
                    Debug.Log("Let the game begin !");
                    _countDownRunning = false;
                }

            }
        }
    }
}
