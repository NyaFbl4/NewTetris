namespace NewTetris
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.SetWindowSize(40, 30);
            Console.SetBufferSize(40, 30);            

            Console.ReadLine();
        }

        static void Drow(int x, int y, char c) 
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(c);
        }
    }
}