using Tetris;

namespace NewTetris
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.SetWindowSize(40, 30);
            Console.SetBufferSize(40, 30);

            Figure f = new Square(1, 1, '*');
            f.Draw();

            Thread.Sleep(1000);
            f.Hide();
            f.Move(Direction.LEFT);
            f.Draw();

            Thread.Sleep(1000);
            f.Hide();
            f.Move(Direction.DOWN);
            f.Draw();

            Thread.Sleep(1000);
            f.Hide();
            f.Move(Direction.RIGHT);
            f.Draw();

            /*
            Figure[] f = new Figure[2];
            f[0] = new Square(2, 2, '*');
            f[1] = new Stick(5, 5, '*');

            foreach (Figure f2 in f) 
            {
                f2.Draw();
            }

            /*
            Square s = new Square(2, 5, '*');
            s.Draw();

            Stick st = new Stick(6, 6, '*');
            st.Draw();

            Point p1 = new Point(2, 5, '*');
            p1.Draw();

            Point p2 = new Point(5, 2, '*');
            p2.Draw();
            */

            Console.ReadLine();
        }
    }
}