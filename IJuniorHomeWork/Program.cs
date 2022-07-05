using System;

namespace IJuniorHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            //string bracketExpression = "(()(()))";
            //string bracketExpression = ")(";
            //string bracketExpression = "(()))(()";
            //string bracketExpression = "(()";
            //string bracketExpression = "())";
            string bracketExpression = "((()(()(()))))";
            char bracketOpen = '(';
            char bracketClose = ')';
            int maxDepth = 0;
            int depth = 0;

            foreach (var item in bracketExpression)
            {
                if (depth < 0)
                {
                    break;
                }
                else if(item.Equals(bracketOpen))
                {
                    
                    depth++;
                }
                else if (item.Equals(bracketClose))
                {
                    
                    if(maxDepth < depth)
                    {
                        maxDepth = depth;
                    }
                    depth -= 1;
                }
            }

            if(depth == 0)
            {
                Console.WriteLine("Bracket expresion " + bracketExpression + " is correct.");
                Console.WriteLine($"Depth: {maxDepth}");
            }
            else
            {
                Console.WriteLine("Bracket expresion " + bracketExpression + " is incorrect.");
            }
        }
    }
}
