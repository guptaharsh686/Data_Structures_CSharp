internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        string s = "{}({})[]({[])";

        var balenced =  isBalenced(s);

        var ans = balenced == true ? "yes" : "no";

        Console.WriteLine(ans);


    }

    private static bool isBalenced(string str)
    {
        Stack<int> s = new Stack<int>();

        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == '(' || str[i] == '[' || str[i] == '{')
            {
                s.Push(str[i]);
            }
            else
            {
                if(s.Count == 0)
                {
                    return false;
                }
                else if (isMatching((char)s.Peek(), str[i]) == false)
                {
                    return false;
                }
                s.Pop();

            }
        }
        if(s.Count == 0)
            return true;
        else
        {
            return false;
        }

    }

    private static bool isMatching(char v1, char v2)
    {
        if(v1 == '{' &&  v2 == '}')
        {
            return true;
        }
        else if(v1 == '(' && v2 == ')') 
        {
            return true; 
        }
        else if(v1 == '[' && v2 == ']')
        {
            return true;
        }
        else { return false; }
    }
}
