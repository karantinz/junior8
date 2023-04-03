Console.Write("Ваше сообщение: ");
string userMessage = Console.ReadLine();

Console.Write("Сколько раз это сообщение должно повториться: ");
int numberOfRepetitions = Convert.ToInt32(Console.ReadLine());

while (numberOfRepetitions-- > 0)
{
    Console.WriteLine(userMessage);
}