// Pen gelPen = new Pen("red",5.0,"gel","medium");
Pen gelPen = new Pen("green",5.0,"gel","medium");

gelPen.Print();
Console.WriteLine();
Pen feltPen = new Pen("blue", 4, "felt", "small");

feltPen.Print();

gelPen.Draw(5);
gelPen.Print();
gelPen.Draw(7);
gelPen.Print();
gelPen.Refill();
gelPen.Print();
Console.WriteLine();

Console.WriteLine(gelPen);

class Pen
{
    public string inkColor;
    public double length;
    public string pointType;
    public string pointSize;
    public int inkAmount;

    public Pen(string _inkColor, double _length, string _pointType, string _pointSize )
    {
        inkColor = _inkColor;
        length = _length;
        pointType = _pointType;
        pointSize = _pointSize;
        inkAmount = 10;
    }

    public void Print()
    {
        Console.WriteLine("This pen:");
        Console.WriteLine($"   Color:{inkColor} Length:{length} Type:{pointType} Size{pointSize} amount of Ink: {inkAmount}");
    }

    public void Draw(int lineLength)
    {
        if (lineLength > inkAmount)
        {
            Console.WriteLine("Sorry, not enough ink for that.");
        }
        else
        {
            inkAmount -= lineLength;
            if (inkAmount < 0)
            {
                inkAmount = 0;
            }
        }

    }

    public void Refill()
    {
        inkAmount = 10;
    }

    public override string ToString()
    {
        return $"Color:{inkColor}   Length:{length}     Type:{pointType}    Size:{pointSize}    Amount:{inkAmount}";
    }

}