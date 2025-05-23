using System;







namespace Anas
{




class Program
{

    static void StartMoving(IMovable movableObject)
    {
        movableObject.Move();
    }

    static void Main()
    {

        Parent b = new Child(12);


        b.SayHello();


        Child C = (Child)b;

        if (b == C)
        {
            Console.WriteLine("A");
        }

        C.SayHello();

        Child i = new Child(12);
        i.SayHello();
        Console.WriteLine(i.ToString());

        Child u = new MyClass(12);
        u.SayHello();
        Console.WriteLine(u.ToString());

        MyClass My = new MyClass1(1);

        Console.WriteLine(My.ToString());
        Console.WriteLine(My);
        Console.WriteLine(typeof(MyClass1));
        Console.WriteLine(My.GetType());
        Console.WriteLine(My.Name());

        var e = new MyClass1(1);

        MyInterface vvv = new Child(6);

        IMovable myCar = new Car();
        IMovable myCat = new Cat();
        myCar.Move();
        myCat.Move();
        Cat yy = new Cat();
        yy.Move();
        Console.WriteLine(yy);
        Console.WriteLine("-----------");
        StartMoving(myCar);
        Console.WriteLine("-----------");
        StartMoving(myCat);






    }


    interface IMovable
    {
        void Move();


    }

    class Car : IMovable
    {

        public void Move()
        {
            Console.WriteLine("Car is moving...");
        }
        public void Print()
        {
            Console.WriteLine("Panch");
        }
    }

    class Cat : IMovable
    {

        public override string ToString()
        {
            return "Anas";
        }
        public void Move()
        {
            Console.WriteLine("Cat");
        }

        void IMovable.Move()
        {
            Console.WriteLine(" ");
        }
    }





    interface MyInterface
    {
        void move();
    }

    abstract class Parent : MyInterface
    {
        public void move()
        {

        }


        public abstract void SayHello();



        public int i;

        protected Parent()
        {

        }



        protected Parent(int value)
        {
            this.i = value;
        }


    }

    class Child : Parent, MyInterface
    {

        public Child(int value) : base(value)
        {

        }
        public override void SayHello() => Console.WriteLine("Child");
        public virtual string Name()
        {
            return "Anas";
        }

    }

    class MyClass : Child
    {
        public MyClass(int value) : base(value)
        {

        }
        public override void SayHello() => Console.WriteLine("MyCalss");

    }

    class MyClass1 : MyClass
    {
        public MyClass1(int value) : base(value)
        {

        }

        public override string Name()
        {
            return "A";
        }
    }

}




}


interface IEngine
{
    void Start();
}

class PetrolEngine : IEngine
{
    public void Start()
    {
        Console.WriteLine("Petrol Engine started.");
    }
}

class ElectricEngine : IEngine
{
    public void Start()
    {
        Console.WriteLine("Electric Engine started.");
    }
}

class Car
{
    private IEngine engine; // ✅ ارتباط رخو: يعتمد على `Interface` بدلاً من كائن محدد

    public Car(IEngine engine)
    {
        this.engine = engine;
    }

    public void StartCar()
    {
        engine.Start();
    }
}

// الاستخدام:
class Program
{
    static void Main()
    {
        IEngine petrolEngine = new PetrolEngine();
        Car car1 = new Car(petrolEngine);
        car1.StartCar(); // ✅ يعمل بمحرك بنزين

        IEngine electricEngine = new ElectricEngine();
        Car car2 = new Car(electricEngine);
        car2.StartCar(); // ✅ يعمل بمحرك كهربائي
    }
}

