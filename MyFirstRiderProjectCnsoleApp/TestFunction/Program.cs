// See https://aka.ms/new-console-template for more information

using System.Drawing;


Chair chair = new Chair(2, Color.Yellow, 2);
myPrint();
anotherPrint("Coucou :D");


Console.WriteLine("Chair's feet : "+ chair.feet);
chair.AddOneFootToChair(chair);
Console.WriteLine("Chair's feet : "+ chair.feet);


return;

void myPrint()
{
    Console.WriteLine("Hello, World!");
}
void anotherPrint(string input)
{
    Console.WriteLine(input);
}

class Chair
{

    public Chair(int feet,Color color,int size)
    {
        this.feet = feet;
        this.color = color;
        this.size = size;
    }
    public int feet;
    private Color color;
    private int size;

    public void AddOneFootToChair(Chair chair)
    {
        this.feet++;
    }
}