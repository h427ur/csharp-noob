using System;
class Even{
    int evenNum;
    public Even(int num){
        evenNum = (num % 2 == 0) ? num : num + 1;

    }

    public static Even operator++(Even e){
        e.evenNum += 2;
        
        return e;
    }

    public static Even operator--(Even e){
        e.evenNum -= 2;

        return e;
    }

    public void PrintEven(){
        Console.WriteLine("짝수: " + evenNum);
    }
}

class Hawawa{
    public static void Main(){
        Even e = new(3);
        e.PrintEven(); //4

        e++; //6
        e.PrintEven();

        --e;
        e.PrintEven(); //4
    }
}