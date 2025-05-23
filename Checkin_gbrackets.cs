using System;
using System.Collections.Generic;

class InfixToPostfixConverter
{

    static int GetPrecedence(char op)
    {
        if (op == '+' || op == '-') return 1;
        if (op == '*' || op == '/') return 2;
        return 0;
    }

    static string Convert(string infix)
    {
        Stack<char> stack = new Stack<char>();
        string postfix = "";

        foreach (char ch in infix)
        {
            if (char.IsLetterOrDigit(ch))
            {
                postfix += ch;
            }
            else if (ch == '(')
            {
                stack.Push(ch);
            }
            else if (ch == ')')
            {
                while (stack.Count > 0 && stack.Peek() != '(')
                    postfix += stack.Pop();
                stack.Pop(); // نشيل القوس المفتوح '('
            }
            else // عامل + - * /
            {
                while (stack.Count > 0 && GetPrecedence(ch) <= GetPrecedence(stack.Peek()))
                    postfix += stack.Pop();
                stack.Push(ch);
            }
        }

        // إخراج كل العمليات المتبقية
        while (stack.Count > 0)
            postfix += stack.Pop();

        return postfix;
    }

    static void Main()
    {
        /*Console.Write("Infix: ");
        string infix = Console.ReadLine();
        string postfix = Convert(infix);
        Console.WriteLine("Postfix: " + postfix);*/



        // Console.WriteLine(string.Empty);
        Console.WriteLine("g");
    }
}
































/*this.FormBorderStyle = FormBorderStyle.FixedSingle;
this.MaximizeBox = false;
this.MinimizeBox = false;
this.StartPosition = FormStartPosition.CenterScreen;*/