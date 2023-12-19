using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace testing;

[TestFixture]
public class Param_Volume_Tests
{
    [TestCaseSource(typeof(Param_Volume_Data), nameof(Param_Volume_Data.TestCases))]
    public int Param_Volume_Test(int d, int w, int h)
    {
        //return n / d;
        return new Cube(d, w, h).GetVolume();
    }
}

public class Param_Volume_Data
{
    public static IEnumerable<TestCaseData> TestCases
    {
        get
        {
            yield return new TestCaseData(2, 2, 2).Returns(8);
            yield return new TestCaseData(1, 1, 1).Returns(1);
            yield return new TestCaseData(1, 1, 0).Returns(0);
        }
    }
}