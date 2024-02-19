using System.Threading.Channels;

namespace ListCreate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vuvedete spisuk ot cvetove (done za krai): ");
            List<string> colorList= new List <string>();
            string input = Console.ReadLine();
            do
            {
                colorList.Add(input);
                input = Console.ReadLine();

            } while (input != "done");
            Console.WriteLine();
            //for (int i = 0; i < colorList.Count; i++)
            //{
            //    Console.WriteLine(colorList[i]);
            //}
            Console.WriteLine("Koe mahame 0-"+ (colorList.Count-1));
            int index= int.Parse(Console.ReadLine());
            colorList.RemoveAt(index); 
            foreach (string item in colorList)
            {
                Console.WriteLine(item);
            }
            colorList[0] = "Rozovo";
             
        }
    }
}
