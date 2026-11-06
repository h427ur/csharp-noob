class CoffeeMachine{
    public bool onState;

    public void StartMachine(){
        if (onState){
            Console.WriteLine("The Coffee Machine is already on.");
        }
        else{
            onState = true;
            Console.WriteLine("The Coffee Machine is now on.");
        }
    }

    public void StopMachine(){
        if (onState){
            onState = false;
            Console.WriteLine("The Coffee Machine is now off");
        }
        else{
            Console.WriteLine("The Coffee Machine is already off.");
        }
    }
}

class Hawawa{
    public static void Main(){
        CoffeeMachine coffeeMachine = new();
        coffeeMachine.StartMachine();
        coffeeMachine.StartMachine();

        Console.WriteLine("");

        coffeeMachine.StopMachine();
        coffeeMachine.StopMachine();
    }
}