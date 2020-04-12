using System;

namespace DesignaStack
{
    partial class Program
    {

        static void Main(string[] args)
        {
            var stack = new Stack();
            //Specifices the size of the Stack List of objects.
            int ini = 0;
            int max = 5;
            for (int i = ini; i <= max; i++)
            {
                stack.Push(i);

            }            

            for (int i = ini; i <= max; i++)
            {
                Console.WriteLine(stack.Pop());

            }

            Console.ReadLine();

            stack.Clear();






        }
    }
}
