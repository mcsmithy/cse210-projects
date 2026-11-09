class Program
{
    static void Main()
    {
        Shape sshape = new Square(5, "red");
        Shape rshape = new Rectangle(3,6, "purple");
        Shape cshape = new Circle(4, "green");

        List<Shape> shapes = [sshape, rshape, cshape];

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Shape: {shape.GetColor()} {shape.GetArea()}");   
        }

        sshape.SetColor("blue");
        rshape.SetColor("purple");
        cshape.SetColor("orange");

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Shape: {shape.GetColor()} {shape.GetArea()}");   
        }
    }
}