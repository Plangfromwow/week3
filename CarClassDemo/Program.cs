/* Access demo */

Car first = new Car("Honda", "Civic", color.Red);

Console.WriteLine(first.getMake()); // this is how we have to get make 
Console.WriteLine(first.getModel());
Console.WriteLine(first.getColor());
first.setColor(color.Black);
Console.WriteLine(first.getColor());

bool yesno = false; //two possible choices for boolean variable 
int n = 100; // so many possible choices for int options
double p = 3.14; // so many 
color carcolor = color.Black; // we have only a few options that we set below. 
color pianoColor = color.Black;
Console.WriteLine(pianoColor);

enum color
{
    Red,
    Green,
    Blue,
    Black,
    Silver
}




class Car
{
    // attributes that cannot be changed
    private string make;
    private string model;

    // attributes that can be changed 
    private color carColor;
    
    public Car(string _make, string _model, color _color)
    {
        this.make = _make;
        this.model = _model;
        this.carColor = _color;
    }
    // make only has a getter, so we can only look at it, we cannot change it. 
    public string getMake()
    {
        return make;
    }
    // only has a getter, just like the make can only look at it we cannot change it 
    public string getModel()
    {
        return model;
    }
    // color has both a getter and setter, so we can look at it and change it. 
    public color getColor()
    {
        return carColor;
    }
    // setter function doesn't return anything
    public void setColor(color _color)
    {
        // Lets do some validation to make sure it's a valid color.
        //if (_color == color.Red || _color == color.Green || _color == color.Blue || _color == color.Black)
        //{
            carColor = _color;
        //}

        // with an enum we don't need to validate, because it locks down the thingy
    }

}

