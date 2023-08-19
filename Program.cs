class Program
{
    public static void Main(string[] args)
    {
        // 1. 변수
        bool boolvariable = true;
        int intvariable = 10;
        float floatvariable = 10.4f;
        char charvariable = 'a';

        Console.WriteLine(boolvariable);
        Console.WriteLine(intvariable);
        Console.WriteLine(floatvariable);
        Console.WriteLine(charvariable);

        // 2. 조건문
        int num = 10;

        if (num == 0) {
            Console.WriteLine("num이 0입니다.");
        } else if (num == 9) {
            Console.WriteLine("num이 9입니다.");
        } else {
            Console.WriteLine("num이 둘다 속하지 않습니다.");
        }

    }
}
