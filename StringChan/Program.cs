using System;

class StringChan{
    public static void Main(){
        string str1 = "하와왕";
        string str2 = new string("하와와왕");
        string str3 = new("하왕왕왕왕");

        Console.WriteLine(str1);
        Console.WriteLine(str2);
        Console.WriteLine(str3);

        //concatenation string
        Console.WriteLine(str1 + str2);
        Console.WriteLine(str1 + str3);
        Console.WriteLine(str2 + str3);
        Console.WriteLine(str1 + str2 + str3);

    }
}