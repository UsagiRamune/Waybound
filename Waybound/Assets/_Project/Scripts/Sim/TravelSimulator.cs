using UnityEngine;

namespace Waybound
{
    public class TravelSimulator : MonoBehaviour
    {
        [SerializeField] private EdgeData edge;
        [SerializeField] private float baseSpeed = 3f;

        public TravelState State { get; private set; }

        // segment ที่อยู่ล่าสุด ใช้เทียบว่า "เพิ่งข้ามรอยต่อไหม"
        private SegmentData currentSegment;

        private void Awake()
        {
            State = new TravelState { edgeId = edge.edgeId };
        }

        private void Update()
        {
            float dt = Time.deltaTime;
            State.d += baseSpeed * dt;
            State.gameTime += dt;

            // T2: เก็บผลลัพธ์ใหม่ไว้ตัวแปรชั่วคราวก่อน แล้วค่อยเทียบกับตัวเก่า
            SegmentData seg = edge.GetSegmentData(State.d);
            if (seg != null && seg != currentSegment)
            {
                currentSegment = seg;
                Debug.Log($"Entered segment: {seg.biomeType} (length {seg.length}) at d={State.d:F1}");
            }

            if (State.d >= edge.TotalLength)
            {
                State.d = edge.TotalLength;
                Debug.Log($"Reached the destination used {State.gameTime} seconds.");
                enabled = false;
            }
        }
    }
}
