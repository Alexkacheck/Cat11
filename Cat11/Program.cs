using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cat11
{
 


    public class Cat
    {
        private int hungerLevel = 70;

        public void Eat(FoodType foodType)
        {
            int foodValue = GetFoodValue(foodType);
            hungerLevel += foodValue;

            Console.WriteLine($"Коту понравилось { foodType}! РОВЕНЬ голода: {hungerLevel}");
        }

        private int GetFoodValue(FoodType foodType)
        {
            switch (foodType)
            {
                case FoodType.Корм:
                    return 20;
                case FoodType.Сыр:
                    return 15;
                case FoodType.Колбаса:
                    return 10;
                default:
                    return 0;
            }
        }
    }

    public enum FoodType
    {
        Корм,
        Сыр,
        Колбаса
    }

    class CatProgram
    {
        static void Main()
        {
            Cat myCat = new Cat();

            Console.WriteLine("Уровень голода кошки перед едой: 70");

            Console.WriteLine("Выберите корм для кошки Корм, сыр, колбаса:");
            string userChoice = Console.ReadLine();

            if (Enum.TryParse<FoodType>(userChoice, out FoodType selectedFood))
            {
                myCat.Eat(selectedFood);
            }
            else
            {
                Console.WriteLine("Неправильный выбор продуктов питания.");
            }
        }
    }
}
