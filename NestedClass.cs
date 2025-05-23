using System;
using System.Web;



class OuterClass
{
    public class InnerClass  // 🚀 افتراضيًا Private
    {
        public void ShowMessage()
        {
            Console.WriteLine("Hello from InnerClass!");
        }
    }

    // public InnerClass y = new InnerClass();

    public InnerClass Inner;

    public void AccessInnerClass()
    {
        InnerClass obj = new InnerClass();  // ✅ مسموح لأنه داخل نفس الكلاس
        obj.ShowMessage();
    }
}

class Program
{
    static void Main()
    {
        OuterClass i = new OuterClass();
        i.Inner.ShowMessage();


    }
}