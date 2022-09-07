//Напишите цикл, который принимает на вход два числа (А и В) и возводит число А в натуральную степень В.

// void  Derge(double num1, double num2){
      
//     double a_b = 0;
//     for (int i=1; i<=num1;i++){
//         a_b= Math.Pow(num1,num2);
//     }
//     Console.Write($"Число а в степени b равно: {a_b}");    
// }
// Console.WriteLine("Введите число a: ");
// double num1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите число b: ");
// double num2 = Convert.ToDouble(Console.ReadLine());

// Derge(num1,num2);

//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// void SumNumber(int num){
//     int sum=0;
//     for(int curr = 1; curr <= num;curr++){
//         sum = curr/100 + curr/10%10 +curr%10;
//     }
//     Console.Write($"Сумма равна {sum}");
// }

// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// SumNumber(number);

//Напишите программу, которая задает массив из произвольного элементов и выводит их на экран.

// int[] SumArray (int size){
    
//     int[] array = new int [size];
//     for(int i=0; i< size; i++){
//         Console.Write("Введите числа: ");
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }

// void ShowArr(int[] array){
//     Console.Write("[ ");
//     for (int i=0; i< array.Length; i++){
//         Console.Write(array[i] + " ");

//     }
//     Console.Write("]");
// }

// Console.WriteLine("Длинна: ");
// int size = Convert.ToInt32(Console.ReadLine());
// ShowArr(SumArray(size));
