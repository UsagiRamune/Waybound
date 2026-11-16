using UnityEngine;

namespace Waybound
{
    // T8: Parallax 3-4 layers เป็นฟังก์ชันบริสุทธิ์ของ d  (layerX = -d * S * factor)
    // ห้ามสะสมตำแหน่งด้วย += speed * dt
    // DoD: ย้อน d แล้ว layer ย้อนตรงเป๊ะ (ไม่ drift)
    public class ParallaxLayer : MonoBehaviour
    {
    }
}
