// Функция, отвечающая за длину первоначального массива.
int InitLengthMassive(string msg)
{
    Console.WriteLine(msg);
    int massLength = Convert.ToInt32(Console.ReadLine());
    return massLength;    
}
// Функция, отвечающая за инициализацию первоначального массива.
string[] InitMassive(int massLength)
{
    string[] userMassive = new string[massLength];
    for (int i = 0; i < userMassive.Length; i++)
    {
        Console.Write($"Введите {i+1} эллемент массива: ");
        userMassive[i] = Console.ReadLine();
    }
    return userMassive;
}
// Функция, отвечающая за вывод массива на экран.
void PrintMassive(string[] massive)
{
    for (int i = 0; i < massive.Length; i++)
    {
        if(i!=massive.Length-1)
        Console.Write($"{massive[i]}, ");
        else
        Console.Write($"{massive[i]}");
    }
    Console.WriteLine();
}
// Функция, отвечающая за поиск элементов, длина которых меньше либо равна 3, и создание массива из этих элементов.
string[] MassiveOnlyThreeSymbols(string[] userMassive)
{
    int k =0;
    int count = 0;

    for (int j = 0; j < userMassive.Length; j++)
    {
        if(userMassive[j].Length<=3)
        count++;
    }

    string[] resultMassive = new string[count];

    for (int i = 0; i < userMassive.Length; i++)
    {
        if(userMassive[i].Length<=3)
        {
            resultMassive[k] = userMassive[i];
            k++;
        }
    }

    return resultMassive;
}

int massiveLength = InitLengthMassive("Введите длину массива: ");
string[] massive = InitMassive(massiveLength);
PrintMassive(massive);
string[] resMass = MassiveOnlyThreeSymbols(massive);
if(resMass.Length>0)
{
Console.WriteLine("Массив из элеметов, длина которых меньше либо равна 3 символам: ");
PrintMassive(resMass);
}
else
Console.WriteLine("В заданном массиве нет элементов, длина которых меньше либо равна 3 символа");