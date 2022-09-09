// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

System.Console.WriteLine("Введите число: ");
string S=System.Console.ReadLine();
int sum=Sumfun(S);
System.Console.WriteLine(sum);



int Sumfun(string str)
{
    
    int sum=0; 
    for (int i=0; i<str.Length;i++)
    {
    
        sum=sum+Convert.ToInt32(Convert.ToString(str[i]));
    }
    return sum;
}
