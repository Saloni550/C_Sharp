//inheritance
class vechicle
{
    public string brand = "Ford";
    public void honk()
    {
        Console.WriteLine("Tuut,tuut!");
    }
}
class car : vechicle 
{
    public string modelname = "Mustang";
}
class program
{
    static void Main(string[] args)
    {
        //create a mycar object
        car mycar = new car();
        //call the honk() method(from the vechicle class)on the my car object
        mycar.honk();
        //Display the valiue of the brand field (from the vehicle class) and the value of the module
        Console.WriteLine(mycar.brand + " " + mycar.modelname);
    }
}
