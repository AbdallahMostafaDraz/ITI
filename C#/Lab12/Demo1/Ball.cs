namespace Demo1
{
    public class Ball : Element
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Point Postion { get; set; }
        
        public DeltaXY DeltaXY { get; set; }
        public Ball(int id, string name, Point postion) : base(id, name, postion) { }
        
        public event EventHandler<DeltaXY> OnBallPostionChanged;
        public void Move(DeltaXY deltaXY)
        {
            Move(this, deltaXY);
            OnBallPostionChanged?.Invoke(this, deltaXY);
        }
    }
}
