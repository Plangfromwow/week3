Triangle first = new Triangle(4,3);
Console.WriteLine(first.getHypotenuse());
Console.WriteLine(first.getPerimeter());
Console.WriteLine(first.getArea());



class Triangle 
{
    // We have a package, like a capsule 
    // The verb we use is "encapsulate"
    // We've packaged together lenght and height into a triangle concept. 
    // We have "encapsulated" lenght and height into our triangle

    private double length;
    private double height;
    private double area;

    // Constructor is initilizing the data of our object
    public Triangle(double _length, double _height)
    {
        length = _length;
        height = _height;
        area = length * height / 2;
    }

    public double getArea()
    {
        return area;
    }

    public double getHypotenuse()
    {
        return  Math.Sqrt(length*length + height*height);
    }

    public double getPerimeter()
    {
        return length + height + getHypotenuse();
    }

}
