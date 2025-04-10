using System;
using System.Collections.Generic;
using System.Linq;

namespace IceCreams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IceCream> ices = GetIceCreamsFromInput();
            Console.WriteLine(SweetestIceCream(ices));
            Console.ReadKey();
        }

        public static List<IceCream> GetIceCreamsFromInput()
        {
            List<IceCream> iceCreams = new List<IceCream>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; ++i)
            {
                string[] _params = Console.ReadLine().Split(' ');
                IceCream _iceCream = new IceCream(_params[0], int.Parse(_params[1]));
                iceCreams.Add(_iceCream);
            }

            return iceCreams;
        }

        public static int SweetestIceCream(List<IceCream> icecream)
        {
            // Write your Code Here
            int sweetest = -1;
            for (int idx = 0; idx < icecream.Count; idx++)
            {
                int numSprinkles;
                if (icecream[idx].flavour == "Vanilla" || icecream[idx].flavour == "ChocolateChip")
                {
                    numSprinkles = icecream[idx].sprinkles + 5;
                }
                else if (icecream[idx].flavour == "Stawberry" || icecream[idx].flavour == "Chocolate")
                {
                    numSprinkles = icecream[idx].sprinkles + 10;
                }
                else
                {
                    numSprinkles = icecream[idx].sprinkles;
                }
                if (sweetest < numSprinkles)
                {
                    sweetest = numSprinkles;
                }
            }
            return sweetest;

        }
    }

    public class IceCream
    {
        // Write your Class Here
        public string flavour;
        public int sprinkles;
        public IceCream(string flavour, int sprinkles)
        {
            this.flavour = flavour;
            this.sprinkles = sprinkles;
        }
    }
}


