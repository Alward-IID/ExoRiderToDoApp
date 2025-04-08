// See https://aka.ms/new-console-template for more information

Console.WriteLine("Here : ");

/* EXO 1
 string input = Console.ReadLine();
string newWord = String.Empty;

for (int i = 0; i < input.Length; i++)
{
    newWord += input[input.Length -1 - i];
}
Console.WriteLine(newWord);
*/

// EXO 2
/*
string input = Console.ReadLine();
string newWord = String.Empty;

for (int i = 0; i < input.Length; i++)
{
    newWord += input[input.Length -1 - i];
}

if (newWord.Equals(input))
{
    Console.WriteLine($"newWord : {newWord} and input: {input} are the same");
}
else
{
    Console.WriteLine($"newWord : {newWord} and input: {input} aren't the same");
}
*/
// EXO 3

string input = Console.ReadLine();
int a = 0;
for (int i = 0; i < input.Length; i++)
{
    
    for (int j = 0; j < input.Length; j++)
    {
        if (input[i].Equals(input[j]))
        {
            a++;
        }
    }
    Console.WriteLine($"{input[i]} : {a}");
    a = 0;
}