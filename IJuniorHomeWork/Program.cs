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
            int bracketOpenAmount = 0;
            int bracketCloseAmount = 0;
            int maxDepth = 0;
            int depth = 0;

            foreach (var item in bracketExpression)
            {
                if (bracketCloseAmount > bracketOpenAmount)
                {
                    break;
                }
                else if(item.Equals(bracketOpen))
                {
                    bracketOpenAmount++;
                    depth++;
                }
                else if (item.Equals(bracketClose))
                {
                    bracketCloseAmount++;
                    if(maxDepth < depth)
                    {
                        maxDepth = depth;
                    }
                    depth -= 1;
                }
            }

            if(bracketOpenAmount == bracketCloseAmount && maxDepth > 0)
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
