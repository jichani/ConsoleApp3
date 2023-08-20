//class Program
//{
//    public static void Main(string[] args)
//    {
// 1. 데이터를 저장하는 상자 변수
//bool boolvariable = true;
//int intvariable = 10;
//float floatvariable = 10.4f;
//char charvariable = 'a';

//Console.WriteLine(boolvariable);
//Console.WriteLine(intvariable);
//Console.WriteLine(floatvariable);
//Console.WriteLine(charvariable);

// 2. 프로그램의 흐름 제어를 위한 조건문
//int num = 10;

//if (num == 0) {
//    Console.WriteLine("num이 0입니다.");
//} else if (num == 9) {
//    Console.WriteLine("num이 9입니다.");
//} else {
//    Console.WriteLine("num이 둘다 속하지 않습니다.");
//}

// 3. 프로그램 흐름 제어를 위한 반복문
//for (int i = 0; i <= 10; i++)
//{
//    Console.WriteLine(i);
//}

//int j = 0;
//while(j <= 10)
//{
//    Console.WriteLine(j++);
//}

// 4. 데이터를 연산자로 요리하기
//int num = 0;

//Console.WriteLine(num++);
//Console.WriteLine(num);
//Console.WriteLine(--num);
//Console.WriteLine(num);

// 5. 데이터를 옮겨 담기 - 형 변환(Type Conversion)
// sbyte는 부호있는 정수로서 -128 ~ 127까지 범위가 주어진다. 크기는 1(8비트)
//sbyte value1 = 64;
//sbyte value2 = 64;
//// sbyte value3 = value1 + value2; 로 하면 오버플로우 현상 때문에 에러가 발생한다. so,
//int value3 = value1 + value2;
//Console.WriteLine(value3);
//}
// 섹션 3 - 1 클래스와 인스턴스
//class Person
//{
//    public string Name = null;

//    public void Eat()
//    {
//        Console.WriteLine(Name + "(이)가 식사를 합니다.");
//    }
//}
//class PersonProgram
//{
//    public static void Main(string[] args)
//    {
//        Person p1 = new Person();
//        p1.Name = "서준";
//        p1.Eat();
//    }
//}

// 섹션 3 - 2 클래스의 시작과 종료
//class Cat
//{
//    public string Name;

//    public Cat(string name)
//    {
//        Name = name;
//        Console.WriteLine("고양이의 이름은 "+ Name + " 입니다.");
//    }
//}

//class Program
//{
//    public static void Main(string[] args)
//    {
//        Cat myCat1 = new Cat("코코");
//        Cat myCat2 = new Cat("몰리");
//    }
//}

// 메서드 오버로딩(Overloading) : 여러개를 선언해두고 개수나 형식에 맞게 호출이 된다.
//class Cat
//{
//    public string Name;
//    public int Weight;

//    public Cat(string name)
//    {
//        Name = name;
//        Console.WriteLine("고양이의 이름은 " + Name + " 입니다.");
//    }

//    public Cat(string name, int weight)
//    {
//        Name = name;
//        Weight = weight;
//        Console.WriteLine("고양이의 이름은 " + Name + " 몸무게는 " + Weight + "입니다.");
//    }
//}

//class Program
//{
//    public static void Main(string[] args)
//    {
//        Cat myCat1 = new Cat("코코");
//        Cat myCat2 = new Cat("몰리", 5);
//    }
//}

// 클래스의 종료 - 소멸자 (Destructor)
//class Cat
//{
//    public string Name;

//    public Cat(string name)
//    {
//        Name = name;
//        Console.WriteLine("고양이의 이름은 " + Name + " 입니다.");
//    }

//    // 소멸자는 .net 프레임워크를 통해서 사라진다.
//    ~Cat() {
//        Console.WriteLine(Name + "이(가) 사라집니다.");
//    }
//}

//class Program
//{
//    public static void Main(string[] args)
//    {
//        Cat myCat1 = new Cat("코코");
//        Cat myCat2 = new Cat("몰리");
//    }
//}

// 클래스를 상속으로 재사용하기
//class Robot
//{
//    public void Move()
//    {
//        Console.WriteLine("로봇이 움직입니다.");
//    }
//}
//// : Robot 이라고 적으면 Robot으로 부터 상속을 받는다.
//class CleanRobot : Robot
//{
//    public void Clean()
//    {
//        Console.WriteLine("로봇이 청소를 합니다.");
//    }
//}
//class Program
//{
//    public static void Main(string[] args)
//    {
//        CleanRobot cr = new CleanRobot();
//        cr.Move();
//        cr.Clean();
//    }
//}
// 클래스를 상속으로 재사용하기 - 오버라이딩(Overriding) : 재정의한다.
//class Robot
//{
//    public void Move()
//    {
//        Console.WriteLine("로봇이 움직입니다.");
//    }
//}
//// : Robot 이라고 적으면 Robot으로 부터 상속을 받는다.
//class CleanRobot : Robot
//{
//    public void Move()
//    {
//        Console.WriteLine("청소 로봇이 움직입니다.");
//    }
//}
//class RescueRobot : Robot
//{
//    public void Move()
//    {
//        Console.WriteLine("구조 로봇이 움직입니다.");
//    }
//}
//class Program
//{
//    public static void Main(string[] args)
//    {
//        CleanRobot cr = new CleanRobot();
//        RescueRobot rr = new RescueRobot();
//        cr.Move();
//        rr.Move();
//    }
//}
// 클래스의 데이터 전달 - 멤버 변수
//class Cat
//{
//    public string Name;

//    public Cat (string name)
//    {
//        Name = name;
//        Console.WriteLine("고양이의 이름은 " + Name + "입니다.");
//    }
//}

//class Program
//{
//    public static void Main(string[] args)
//    {
//        Cat myCat = new Cat("코코");
//        myCat.Name = "몰리";
//        Console.WriteLine("고양이의 이름은 " + myCat.Name + "입니다.");
//    }
//}

// 클래스의 데이터 전달 - private, this 키워드
class Cat
{
    private string name;

    public Cat(string name)
    {
       this.name = name;
        Console.WriteLine("고양이의 이름은 " + name + "입니다.");
    }

    public void SetName (string name)
    {
        this.name = name;
    }

    public string GetName ()
    {
        return this.name;
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Cat myCat = new Cat("코코");
        myCat.SetName("몰리");
        Console.WriteLine("고양이의 이름은 " + myCat.GetName() + "입니다.");
    }
}