namespace zad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            do
            {
                Console.WriteLine("Insert a number from 1 to 1000");
                n = int.Parse(Console.ReadLine());
            } while (n < 1 && n > 1000);

            Queue<string> q = new Queue<string>();
            HashSet<string> s = new HashSet<string>();
            string z;
            for (int i = 0; i < n; i++)
            {
                z = Console.ReadLine();
                if (!s.Contains(z))
                {
                    q.Enqueue(z);
                    s.Add(z);
                }
                else
                {
                    Console.WriteLine("Zaqvkata veche e podadena");
                }
            }
            while (q.Count > 0)
            {
                Console.WriteLine(q.Dequeue());
            }
        }
    }
}
