using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Ques2
{
	internal class Program
	{
		static List<ingredients> items = new List<ingredients>();
		static void Main(string[] args)
		{
			ingredients ingredient1 = new ingredients("Strawberries", 1.50);
			items.Add(ingredient1);
			ingredients ingredient2 = new ingredients("Banana", 0.50);
			items.Add(ingredient2);
			ingredients ingredient3 = new ingredients("Mango", 2.50);
			items.Add(ingredient3);
			ingredients ingredient4 = new ingredients("Blueberries", 1.00);
			items.Add(ingredient4);
			ingredients ingredient5 = new ingredients("Raspberries", 1.00);
			items.Add(ingredient5);
			ingredients ingredient6 = new ingredients("Apple", 1.75);
			items.Add(ingredient6);
			ingredients ingredient7 = new ingredients("Pineapple", 3.50);
			items.Add(ingredient7);

			List<string> smoothies = GetSmoothieFromInput();
			Smoothie s = new Smoothie(smoothies);
			outputResult(s);
		}

		public static void outputResult(Smoothie s)
		{

			Console.WriteLine(Math.Round(s.GetCost(), 2));
			Console.WriteLine(Math.Round(s.GetPrice(), 2));
			Console.WriteLine(s.GetName());
		}
		public static List<string> GetSmoothieFromInput()
		{
			int n = int.Parse(Console.ReadLine());
			List<string> ingredients = new List<string>();
			for (int i = 0; i < n; ++i)
			{
				string _params = Console.ReadLine();
				ingredients.Add(_params);
			}
			return ingredients;
		}

		public class Smoothie
		{
			public List<string> Ingredients = new List<string>();
			public Smoothie(List<string> Ingredients)
			{
				// Write Code Here
				this.Ingredients = Ingredients;
				
			}

			public double GetCost()
			{
				// Write Code Here
				double cost = 0;
				for(int idx = 0; idx < Ingredients.Count; idx++)
                {
					if(Ingredients[idx] == "Stawberries")
                    {
						cost = cost + 1.50F;
                    }
					if (Ingredients[idx] == "Banana")
					{
						cost = cost + 0.50F;
					}
					if (Ingredients[idx] == "Mango")
					{
						cost = cost + 2.50F;
					}
					if (Ingredients[idx] == "Blueberries")
					{
						cost = cost + 1.00F;
					}
					if (Ingredients[idx] == "Raspberries")
					{
						cost = cost + 1.00F;
					}
					if (Ingredients[idx] == "Apple")
					{
						cost = cost + 1.75F;
					}
					if (Ingredients[idx] == "Pineapple")
					{
						cost = cost + 3.50F;
					}
				}
				return cost;
			}
			public double GetPrice()
			{
				// Write Code Here
			}
			public string GetName()
			{

				// Write Code Here
			}


		}
		public class ingredients
		{
			public string name;
			public double price;

			public ingredients(string name, double price)
			{
				// Write Code Here	
				this.name = name;
				this.price = price;
			}
		}


	}
}