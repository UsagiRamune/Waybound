using System;

namespace Waybound
{
    public enum BiomeType { Plains, Forest, Desert, Mountain }

    [Serializable]
    public class SegmentData
    {
        public BiomeType biomeType;
        public float length;
        public bool autosave;
    }
}
