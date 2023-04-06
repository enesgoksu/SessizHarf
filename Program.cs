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
                for (int i = 0; i < harf.Length - 1; i++)
                {
                   if (unsuz.Contains(harf[i]) && unsuz.Contains(harf[i + 1]))
                    {
                        kontrol = true;
                        
                    }

                }
                    Console.Write(" "+ kontrol);
            }

        }
    }
}