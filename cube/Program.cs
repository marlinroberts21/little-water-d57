// Program that demonstrates using the Cube class...

internal class Program
{
    private static void Main(string[] args)
    {
        // create a new instance of a cube
        var cube = new Cube();

        // modify some public properties
        cube.Depth = 2;
        cube.Width = 2;
        cube.Height = 2;

        // call a method that returns a calculated value
        int volume = cube.GetVolume();

        // display the value
        Console.WriteLine($"The volume of the cube is: {volume}");

        
    }
}