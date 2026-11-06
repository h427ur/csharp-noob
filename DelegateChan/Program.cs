using System;

delegate void SampleDelegate();

class DelegateChan{
    public void Method1(){
        Console.WriteLine("Method1 호출됨.");
    }
    public void Method2(){
        Console.WriteLine("Method2 호출됨.");
    }
    public void Method3(){
        Console.WriteLine("Method3 호출됨.");
    }

}

class Hawawa{
    public static void Main(){
        DelegateChan deleChan = new();

        //SampleDelegate 객체를 생성 후
        //deleChan 객체의 Method1를 참조
        SampleDelegate sample = new(deleChan.Method1);
        sample();
        Console.WriteLine();

        //Delegate는 객체처럼 생성할 수 있으며 메소드를 참조하고 호출 시 참조한 메소드를 실행한다.
        //그러면 한 Delegate로 여러 메소드를 연결해볼 수 있을까?
        //물론 메소드와 매개변수가 똑같아야하는 조건으로

        SampleDelegate sample2 = new(deleChan.Method2);
        sample2();
        Console.WriteLine();

        SampleDelegate sample3 = new(deleChan.Method3);
        sample3();
    }
}