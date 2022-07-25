Console.Write("Введите трехзначное число: \nДля выхода из программы введите команду Stop. ");

while(true)
    {
        string userEnter = Console.ReadLine();
        if(!userEnter.Equals("Stop"))
        {
            Console.WriteLine("{0}->{1}", userEnter, userEnter[1]);
        }
        else
            break;
    }