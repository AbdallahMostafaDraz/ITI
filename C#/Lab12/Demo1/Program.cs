using System.Drawing;

namespace Demo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player(1, "Shikabala", new Point(0, 0));
            Player player2 = new Player(2, "Abdallah Elsaid", new Point(10, 10));
            Player player3 = new Player(3, "Elwensh", new Point(5, 5));
            Player player4 = new Player(4, "Omar Gaber", new Point(7, 7));

            Refree refree1 = new Refree(1, "Mahmoud Elbana", new Point(5, 5));
            Refree refree2 = new Refree(1, "Mahmoud Ashour", new Point(0, 0));

            Ball ball = new Ball(1, "Ball 1", new Point(10, 15));
            ball.OnBallPostionChanged += player1.Move;
            ball.OnBallPostionChanged += player2.Move;
            ball.OnBallPostionChanged += refree1.Move;
            ball.OnBallPostionChanged -= player1.Move;
            ball.Move(new DeltaXY(10, 15));
        }
    }
}
