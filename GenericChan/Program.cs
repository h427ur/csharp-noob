using System;

class Stack<T>{
    private T[] stack = new T[100];
    private int cur = -1;

    public void Push(T item){
        stack[++cur] = item;
    }

    public T Pop(){
        return stack[cur--];
    }
}

class Hawawa{
    public static void Main(){
        Stack<int> stkInts = new();
        Stack<double> stkDoubles = new();

        stkInts.Push(1);
        stkInts.Push(2);
        stkInts.Push(3);
        
        Console.WriteLine("intager stack: " + stkInts.Pop() + ", " + stkInts.Pop() + ", " + stkInts.Pop()); //3, 2, 1


        stkDoubles.Push(1.2);
        stkDoubles.Push(2.3);
        stkDoubles.Push(3.4);
        
        Console.WriteLine("double stack: " + stkDoubles.Pop() + ", " + stkDoubles.Pop() + ", " + stkDoubles.Pop()); //3.4, 2.3, 1.2
    }
}