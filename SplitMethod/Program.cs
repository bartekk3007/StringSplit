namespace SplitMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "3:0,2:0,3:0";
            string[] wyniki = text.Split(',');
            List<int> bramki = new List<int>();
            foreach (string wynik in wyniki)
            {
                string[] podzielonyWynik = wynik.Split(":");
                foreach (var bramka in podzielonyWynik)
                {
                    bramki.Add(int.Parse(bramka));
                }
            }

            foreach (int bramka in bramki)
            {
                Console.WriteLine(bramka);
            }
        }
    }
}
