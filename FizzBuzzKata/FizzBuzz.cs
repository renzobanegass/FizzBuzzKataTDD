using System;

namespace FizzBuzzKata
{
    public class FizzBuzzKata
    {
        static void Main(string[] args)
        {

            object[] FizzBuzzList = GetList();

            for (int i = 0; i < FizzBuzzList.Length; i++)
            {
                Console.WriteLine(FizzBuzzList[i]);
            }
            
        }

        public static object[] GetList()
        {
            object[] List = new object[20];

            for (int i = 0; i < List.Length; i++)
            {
                int number = i + 1;

                if(number % 3 == 0 && number % 5 == 0)
                {
                    List[i] = "FizzBuzz";
                }
                else if(number % 3 == 0)
                {
                    List[i] = "Fizz";
                }
                else if(number % 5 == 0)
                {
                    List[i] = "Buzz";
                }
                else
                {
                    List[i] = number;
                }                
            }            

            return List;
        }
    }
}
