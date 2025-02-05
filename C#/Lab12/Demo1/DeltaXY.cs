namespace Demo1
{
    public class DeltaXY : EventArgs
    {
        public int DeltaX { get; set; }
        public int DeltaY { get; set; }

        public DeltaXY(int deltaX, int deltaY)
        {
            DeltaX = deltaX;
            DeltaY = deltaY;
        }
    }
}
