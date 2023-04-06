namespace SessizHarf.SessizHarf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir kelime veya cümle yazınız: ");
            string ifade = Console.ReadLine();
            string[] kelime = ifade.Split(' ');
            string unsuz = "bcçdfgğhjklmnprsştvyz";

            foreach (var harf in kelime)
            {
                bool kontrol = false;
                for (int i = 1; i < harf.Length; i++)
                {
                   if (unsuz.Contains(harf[i]) && unsuz.Contains(harf[i + 1]));
                   {
                        kontrol = true;
                        break;
                   } 
                }
                Console.Write(" "+ kontrol);
            }

        }
    }
}