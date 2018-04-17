using System;
using System.Collections.Generic;

namespace SuperStack
{
    class Program
    {
        static void superStack(string[] operations)
        {
            Stack<int> stack = new Stack<int>();
            Stack<int> auxStack = new Stack<int>();

            foreach (string str in operations)
            {
                var words = str.Split(null);

                switch (words[0])
                {
                    case "push":

                        stack.Push(Convert.ToInt32(words[1]));

                        if (stack.Count != 0)
                            Console.WriteLine(stack.Peek());
                        else
                            Console.WriteLine("EMPTY");

                        break;

                    case "pop":

                        stack.Pop();

                        if (stack.Count != 0)
                            Console.WriteLine(stack.Peek());
                        else
                            Console.WriteLine("EMPTY");

                        break;

                    case "inc":

                        var count = Convert.ToInt32(words[1]);
                        var increment = Convert.ToInt32(words[2]);
                        var stackLen = stack.Count;

                        for (var j = 0; j < stackLen; ++j)
                        {
                            auxStack.Push(stack.Pop());
                        }

                        stack.Clear();

                        for (var i = 0; i < stackLen; ++i)
                        {
                            if (count != 0)
                            {
                                stack.Push(auxStack.Pop() + increment);
                                count--;
                            }
                            else
                            {
                                stack.Push(auxStack.Pop());
                            }
                        }

                        if (stack.Count != 0)
                            Console.WriteLine(stack.Peek());
                        else
                            Console.WriteLine("EMPTY");
                        break;

                    default:
                        break;
                }
            }
        }

        static void Main(string[] args)
        {

            //int _operations_size = 0;
            //_operations_size = Convert.ToInt32(Console.ReadLine());
            //string[] _operations = new string[_operations_size];
            //string _operations_item;
            //for (int _operations_i = 0; _operations_i < _operations_size; _operations_i++)
            //{
            //    _operations_item = Console.ReadLine();
            //    _operations[_operations_i] = _operations_item;
            //}

            string[] _operations = new string[13];
            _operations[0] = "12";
            _operations[1] = "push 4";
            _operations[2] = "pop";
            _operations[3] = "push 3";
            _operations[4] = "push 5";
            _operations[5] = "push 2";
            _operations[6] = "inc 3 1";
            _operations[7] = "pop";
            _operations[8] = "push 1";
            _operations[9] = "inc 2 2";
            _operations[10] = "push 4";
            _operations[11] = "pop";
            _operations[12] = "pop";

            superStack(_operations);
        }
    }
}
