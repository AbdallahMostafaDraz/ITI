namespace Demo1
{
    public abstract class Element
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Point Postion { get; set; } = new(0, 0);
        public Element(int id, string name , Point postion)
        {
            Id = id;
            Name = name;
            Postion = postion;
        }

        public override string ToString()
        {
            return $"[{Id}]: {Name}";
        }

        public virtual void Move(object sender, DeltaXY deltaXY)
        {   
            Postion.X += deltaXY.DeltaX;
            Postion.Y += deltaXY.DeltaY;
            Console.WriteLine($"{GetType().Name} ({Name}) Has Been Moved With X += {deltaXY.DeltaX}, Y += {deltaXY.DeltaY}, Current Postions:({Postion.X}, {Postion.Y})");
        }
    }
}
