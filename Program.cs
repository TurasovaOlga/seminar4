
//Используя определение степени числа, напишите цикл, который принимает на вход два натуральных числа (A и B) и возводит число A в степень B.
Console.WriteLine("введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());
int x=number1;
int stepen=number2;
 Console.WriteLine ("number1^number2="+Math.Pow(x,stepen));   


//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Random rand=new Random();
int number=rand.Next(2,9999999);
Console.WriteLine("введено число" +number);
int SumNumber(int numberN){
    
    int counter = Convert.ToString(numberN).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < counter; i++){
      advance = number - number % 10;
      result = result + (number - advance);
      number = number / 10;
    }
   return result;
  }

int sumNumber = SumNumber(number);
Console.WriteLine("Сумма цифр в числе: " + sumNumber);


//Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив.

Random rand = new Random();
int value = rand.Next(0,100);
int value1 = rand.Next(0,100);
int value2 = rand.Next(0,100);
int value3 = rand.Next(0,100);
int value4 = rand.Next(0,100);
int value5 =rand.Next(0,100);
int value6 =rand.Next(0,100);
int value7 =rand.Next(0,100);

Console.WriteLine(value);
Console.WriteLine(value1);
Console.WriteLine(value2);
Console.WriteLine(value3);
Console.WriteLine(value4);
Console.WriteLine(value5);
Console.WriteLine(value6);
Console.WriteLine(value7);
int[] nums = { value, value1, value2,value3, value4, value5,value6, value7};
int temp;
for (int i = 0; i < nums.Length - 1; i++)
{
    for (int j = i + 1; j < nums.Length; j++)
    {
        if (nums[i] > nums[j])
        {
            temp = nums[i];
            nums[i] = nums[j];
            Console.WriteLine($"{nums[j]} = {temp}");
        }
    }
}
 

