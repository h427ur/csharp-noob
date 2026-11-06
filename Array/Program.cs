int[] vector;
short[,] matrix; //16bit matrix
long[][] doubleArr;
object[] arr1, arr2;

vector = new int[100];
matrix = new short[10, 100];
//arr1 = new Point[3];

for(int i = 0; i < vector.Length; i++){
    vector[i] = i + 1;
}

for(int i = 0; i < vector.Length; i++){
    Console.WriteLine("{vector[i]}");
}