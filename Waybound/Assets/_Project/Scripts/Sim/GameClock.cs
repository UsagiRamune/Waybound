namespace Waybound
{
    // T3: Fixed timestep + time scale (1x/2x/4x)
    // DoD: กด 1/2/4 แล้ว gameTime เดินเร็วขึ้นตามนั้น, ผลลัพธ์ใกล้เคียงกันทุก framerate
    // หมายเหตุ: ห้ามใช้ Time.timeScale ตรงๆ กับทุกอย่าง และห้ามเก็บ state ใน static
    public class GameClock
    {
    }
}
