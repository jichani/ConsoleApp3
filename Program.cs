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
    class Person
    {
        public string Name = null;

        public void Eat()
        {
            Console.WriteLine(Name + "(이)가 식사를 합니다.");
        }
    }
    class PersonProgram
    {
        public static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Name = "서준";
            p1.Eat();
        }
    }