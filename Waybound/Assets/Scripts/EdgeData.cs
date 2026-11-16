using System.Collections.Generic;
using UnityEngine;

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
}