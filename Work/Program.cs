using System;

namespace work
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Metni daxil edin: ");
            string text = Console.ReadLine();

            Console.WriteLine("Tersden yazilmasi: ");
            Console.WriteLine(Text(text));

            Console.WriteLine("Sozlerin sayi: ");
            Console.WriteLine(WordCount(text));

            Console.WriteLine($"{text} Characteri daxil edin: ");
            char chr = Convert.ToChar(Console.ReadLine());

            foreach (var item in FindIndex(text, chr))
            {
                Console.Write(item + " ");
            }
        }

        //1. Verilmis string deyerini ters sekilde qaytaran metod.
        

        static string Text(string txt)
        {
            string Text = "";
            for (int i = txt.Length - 1; i >= 0; i--)
            {
                Text += txt[i];
            }
            return Text;

        }

        //2. Verilmis string deyerinde olan sozlerin sayini qaytaran metod.metoda istenilen formada string gonderildikde icerideki sozlerin sayi qayitmalidir,
        

        static int WordCount(string text)
        {
            int count = 1;
            for (int i = 0; i < text.Length - 1; i++)
            {
                if (text[i] == ' ' && text[i + 1] != ' ')
                {
                    count++;
                }
            }
            return count;
        }

        //3.3. Verilmis string deyerinde verilmis char-in indexlerinden ibaret array qaytaran metod
        

        static int[] FindIndex(string text, char chr)
        {
            int[] arr = new int[0];
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == chr)
                {
                    int[] temp = arr;
                    arr = new int[arr.Length + 1]; 
                    for (int k = 0; k < temp.Length; k++) 
                    {
                        arr[k] = temp[k];
                    }
                    arr[arr.Length - 1] = i; 

                }

            }
            return arr;





        }

    }
}