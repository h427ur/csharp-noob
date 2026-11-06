using System;

class PrimitiveType{
    public static void Main(){
        bool boolean;
        int intager = int.MaxValue; //32bit
        uint unsingedInt = uint.MaxValue; 
        double d = double.MaxValue;

        boolean = (intager != 0);

        Console.WriteLine("boolean = " + boolean);
        Console.WriteLine("int의 최댓값 = " + intager);
        Console.WriteLine("uint의 최댓값 = " + unsingedInt);
        Console.WriteLine("double의 최댓값 = " + d);
    }
}