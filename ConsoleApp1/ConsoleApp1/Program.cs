using ConsoleApp1.Models.Exceptions;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Custom newCustom = null;

            try
            {
                newCustom = new Custom();
                newCustom.CapacityLimitException = 123;

                ValidateCustom(newCustom);
            }
            catch (CustomExceptions ex)
            {
                Console.WriteLine(ex.Message);
            }


            Console.ReadKey();
        }

        private static void ValidateCustom(object newStudent)
        {
            throw new NotImplementedException();
        }
    }
    }

