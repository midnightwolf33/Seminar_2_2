Console.Write("Введите число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int Length2 = num2.ToString().Length;
if (Length2 >= 3){
    while (num2 > 999)
    {
    num2 = num2 / 10;
    }
    int result = num2 % 10;
    Console.WriteLine("Третья цифра: " + result);
}   
else {
    Console.WriteLine("Третьей цифры нет");
}