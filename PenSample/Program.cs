// firstPen is an object that has inside it 4 variables. 
Pen firstPen = new Pen();
firstPen.inkColor = "blue";
firstPen.length = 4.5;
firstPen.pointType = "gel";
firstPen.pointSize = "small";
firstPen.inkAmount = 5;
// calling the pen variables that we set 
Console.WriteLine("First Pen");
Console.WriteLine(firstPen.inkColor);
Console.WriteLine(firstPen.length);
Console.WriteLine(firstPen.pointType);
Console.WriteLine(firstPen.pointSize);
Console.WriteLine(firstPen.inkAmount);
// using methods that we made just for pen
Console.WriteLine("Lets draw with first pen.");
firstPen.Draw();
Console.WriteLine($"The ink is now {firstPen.inkAmount}.");

Console.WriteLine();
//Second Pen
Pen secondPen = new Pen();
secondPen.inkColor = "red";
secondPen.length = 4.5;
secondPen.pointType = "ball";
secondPen.pointSize = "medium";
secondPen.inkAmount = 2;
Console.WriteLine("Second Pen");
Console.WriteLine(secondPen.inkColor);
Console.WriteLine(secondPen.length);
Console.WriteLine(secondPen.pointType);
Console.WriteLine(secondPen.pointSize);
Console.WriteLine(secondPen.inkAmount);
Console.WriteLine("Lets draw with second Pen twice");
secondPen.Draw();
secondPen.Draw();

Console.WriteLine($"Second pen now has {secondPen.inkAmount} and First Pen has {firstPen.inkAmount}");

secondPen.Draw();
Console.WriteLine($"Second pen now has {secondPen.inkAmount} and First Pen has {firstPen.inkAmount}");
secondPen.Refill();
Console.WriteLine($"Second pen now has {secondPen.inkAmount} and First Pen has {firstPen.inkAmount}");

Console.WriteLine();
Console.WriteLine("Refilling first pen with green ink...");
firstPen.Refill("Pink");
Console.WriteLine($"First pen has {firstPen.inkColor} ink and has {firstPen.inkAmount} ink points");
// third pen created and ink amount set to 10 by the constructer below 
Console.WriteLine();
Pen thirdPen = new Pen();
Console.WriteLine(thirdPen.inkAmount);

Console.WriteLine();
Console.WriteLine("Fourth Pen");
Pen fourthPen = new Pen("Orange");
Console.WriteLine(fourthPen.inkAmount);
Console.WriteLine(fourthPen.inkColor);

class Pen
{
    public string inkColor;
    public double length;
    public string pointType;
    public string pointSize;
    public int inkAmount;


    public Pen() // default constructor
    {
        inkAmount = 10;
        inkColor = "black";
    }

    public Pen(string _inkColor) //things and stuff here 
    {
        inkColor = _inkColor;
        inkAmount = 10;
    }

    // member methods
    public void Draw()
    {
        if (inkAmount > 0)
        {
            inkAmount--;
        }

    }

    public void Refill()
    {
        inkAmount = 10;
    }

    // adding another refill function, that lets us change ink color.
    public void Refill(string newColor)
    {
        inkColor = newColor;
        inkAmount = 10;
    }

}


