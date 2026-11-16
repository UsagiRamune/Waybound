using System;

namespace Waybound
{
    [Serializable]
    public class TravelState
    {
        public string edgeId;
        public float d;            // ระยะที่เดินไปแล้วบน edge
        public bool forward = true;
        public float gameTime;     // เวลาเกมสะสม (วินาที)
    }
}
