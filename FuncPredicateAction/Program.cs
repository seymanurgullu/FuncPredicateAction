using System;

namespace FuncPredicateAction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action<int> action = new Action<int>(SomeMethod);
            //Action bir delegate method'dur. Birşey return etmez.
            //0 veya daha fazla input parametresi alabilir
            action(1);

            Func<int, int> func = new Func<int, int>(SquareSomething);
            //Func da bir delagate method'dur.
            //Actiondan farkı value return eder. Linq'da kullanılır genelde
            Console.WriteLine(func(2));

            Predicate<int> isPositive = new Predicate<int>(IsBiggerThanZero);
            //Predicate özel bir Func'tur.
            //Genellikle Karşılaştırma için kullanılır bool return eder.
            Console.WriteLine(isPositive(1));
        }

        static void SomeMethod(int i)
        {
            Console.WriteLine(i);
        }

        static int SquareSomething(int i)
        {
            return i * i;
        }

        static bool IsBiggerThanZero(int i)
        {
            return i > 0;

        }

    }
}
