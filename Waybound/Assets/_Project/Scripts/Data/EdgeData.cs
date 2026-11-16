using System.Collections.Generic;
using UnityEngine;

namespace Waybound
{
    [CreateAssetMenu(menuName = "Waybound/Edge Data", fileName = "NewEdge")]
    public class EdgeData : ScriptableObject
    {
        public string edgeId;
        public int seed;
        public List<SegmentData> segments = new List<SegmentData>();

        public float TotalLength
        {
            get
            {
                float total = 0f;
                foreach (var s in segments) total += s.length;
                return total;
            }
        }

        public SegmentData GetSegmentData(float d)
        {
            float start = 0f;
            foreach (var s in segments)
            {
                float end = start + s.length;
                if (d >= start && d < end) return s;
                start = end;
            }
            return null;
        }
    }
}
