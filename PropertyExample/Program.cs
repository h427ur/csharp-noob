using System;

class PropertyExample{
    private int privateVal;

    public int PrivateVal{
        get{ return privateVal; }
        set{ privateVal = value; }
    }

    public void PrintValue(){
        Console.WriteLine("Hidden Value = " + privateVal);

    }
}

class Hawawa{
    public static void Main(){
        int num;
        PropertyExample prop = new();

        prop.PrivateVal = 100;
        prop.PrintValue();

        num = prop.PrivateVal;

        Console.WriteLine("Value = " + num);
    }
}