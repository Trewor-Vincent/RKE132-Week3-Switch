
int weekDay = Convert.ToInt32(DateTime.Now.DayOfWeek);

if (weekDay == 0)
{
    Console.WriteLine("Its's Sunday!");
}
else if (weekDay == 1)
{
    Console.WriteLine("Its's Monday!");
}
else if (weekDay == 2)
{
    Console.WriteLine("Its's Tuesday!");
}
else if (weekDay == 3)
{
    Console.WriteLine("Its's Wednesday!");
}
else if (weekDay == 4)
{
    Console.WriteLine("Its's Thursday!");
}
else if (weekDay == 5)
{
    Console.WriteLine("Its's Friday!");
}
else if (weekDay == 6)
{
    Console.WriteLine("Its's Saturday!");
}

Console.WriteLine("Have a nice day!");