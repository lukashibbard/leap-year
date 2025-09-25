// See https://aka.ms/new-console-template for more information
Console.WriteLine("please give me a year i will tell you if its a leap year");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 399)
{
    int check = num / 4;
    int modcheck = check % 2;
    if (modcheck == 1)
    {
        Console.WriteLine("it is a leap year");
    }
    else
    {
        Console.WriteLine("it is not a leap year");
    }

}2000
if (num > 400)
{
    int check = num / 4;
    int check2 = num / 400;
    int check3 = num / 100;
    int modcheck = check % 2;
    int modcheck2 = check2 % 2;
    int modcheck3 = check3 % 2;
    if (modcheck == 1 || modcheck2 == 1 || modcheck3 == 1)
    {
        Console.WriteLine("it is a leap year");
    }
    else
    {
        Console.WriteLine("it is not a leap year");
    }
}