Console.Write("Введите цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());
void CheckingTheDayofTheWeek (int dayNumber)
{
    if (dayNumber == 6 || dayNumber == 7)
    {
        Console.WriteLine("(этот день выходной?) -> Да");
    }

    else if (dayNumber < 1 || dayNumber > 7) 
    {
        Console.WriteLine("Это не день недели");
    }
    
    
    else 
    Console.WriteLine("(Этот день не выходной) -> Нет");
}
CheckingTheDayofTheWeek(dayNumber);