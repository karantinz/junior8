Console.Write("Ваше сообщение: ");
string userMessage = Console.ReadLine();

Console.Write("Сколько раз это сообщение должно повториться: ");
int numberOfRepetitions = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < numberOfRepetitions; i++)
{
    Console.WriteLine(userMessage);
}