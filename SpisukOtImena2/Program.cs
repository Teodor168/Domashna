namespace SpisukOtImena2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Dai imena: ");
            List<string> names = Console.ReadLine().Split(", ").ToList();
            for (int i = 0; i < names.Count; i++) 
            {
                string[] parts = names[i].Split(' ');
                string firstName = parts[0];
                string lastName = parts[1];
                Console.WriteLine($"{lastName} {firstName}");
            }
        }
    }
}
