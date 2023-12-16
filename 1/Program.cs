string str;
int num = 0;
int sum = 0;

void InputNum()
{
    while (true)
    {
        Console.Write("Введите Num ");
        str = Console.ReadLine();
        if (str == "q")
        {
            break;
        }
        num = int.Parse(str);
        while (num > 0)
        {
            sum = sum + (num % 10);
            num = num / 10;
        }
        if (sum % 2 == 0)
        {
            break;
        }
    }
}

InputNum();