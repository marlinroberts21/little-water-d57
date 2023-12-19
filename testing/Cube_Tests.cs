using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace testing;

public class Volume_Tests
{
    
    public Cube test_cube;

    [SetUp]
    public void Setup()
    {
        test_cube = new Cube();
        test_cube.Width = 2;
        test_cube.Depth = 2;
        test_cube.Height = 2;
    }

    [Test]
    public void Test_Correct_Volume()
    {
        Assert.That(test_cube.GetVolume(), Is.EqualTo(8));
        //Assert.Pass();
    }

    [Test]
    public void Test_Volume_0()
    {
        test_cube.Depth =0;
        Assert.That(test_cube.GetVolume(), Is.EqualTo(0));
        //Assert.Pass();
    }

    [Test]
    public void Test_Volume_Again()
    {
        Assert.That(test_cube.GetVolume(), Is.EqualTo(8));
        //Assert.Pass();
    }

}

public class Property_Tests
{
    
    public Cube test_cube;

    [SetUp]
    public void Setup()
    {
        test_cube = new Cube();
        test_cube.Width = 2;
        test_cube.Depth = 2;
        test_cube.Height = 2;
    }

    [Test]
    public void Test_Correct_Width()
    {
        Assert.That(test_cube.Width, Is.EqualTo(2));
        //Assert.Pass();
    }

    [Test]
    public void Test_Changing_Depth()
    {
        test_cube.Depth =0;
        Assert.That(test_cube.Depth, Is.EqualTo(0));
        //Assert.Pass();
    }

    [Test]
    public void Test_Heigth()
    {
        Assert.That(test_cube.Height, Is.EqualTo(2));
        //Assert.Pass();
    }

}