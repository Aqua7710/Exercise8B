// See https://aka.ms/new-console-template for more information

int counter, userInput;
Console.Write("Hello user, this program will display a certain amount of even numbers depending on how many you want.\nHow many even numbers would you like printed? ");
userInput = Convert.ToInt32(Console.ReadLine());  
for (counter = 2; counter <= userInput * 2; counter++)
{
    if (counter % 2 == 0)
    {
        Console.WriteLine(counter.ToString());
    }
}