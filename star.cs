    class Program
    {
        public const char _zero = ' ';
        public const char _one = '*';       
        static void Main(string[] args)
        {
            Show_Star();
        }
        public static void Show_Star(int N = 15, char zero = _zero, char one = _one)
        {
            int Q1 = N / 4 + N % 2;
            int Long_line = N * 2 - 1;
            int Tall_line = N + Q1;
            int Carry = N % 2;

            for (int i = 0; i < Tall_line; i++)
            {
                for (int j = 0; j < Long_line; j++)
                    Console.Write(i == Q1                   ||   //      Top long line
                                i + Q1 + Carry == Tall_line ||   //      butten long line
                                i + j + Carry == N          ||   //      left '/'
                                i + N == j + Carry          ||   //      right '\'
                                i == j + Q1                 ||   //      left '\'
                                i + j + Carry == Q1 + Long_line  //      right '/'
                                ? one : zero);
                Console.WriteLine();
            }
        }
    }
