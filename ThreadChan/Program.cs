using System;
using System.Threading;

class ThreadChan{
    static void Method1(){
        Console.WriteLine("Method1 호출됨.");
    }

    public static void Main(){
        //Threading에 미리 선언돼있는 델리게이트
        //그럼 다른 델리게이트여도 Thread 객체를 생성할 수 있을까?
        ThreadStart ts = new(Method1);
        Thread thread = new(ts);

        Console.WriteLine("시작");
        thread.Start(); //스레드 호출
        Console.WriteLine("끗");

        //메인문이 끝나는 시점에 스레드가 실행된다.
    }
}