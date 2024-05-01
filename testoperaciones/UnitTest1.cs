namespace testoperaciones;

public class UnitTest1
{
    [Theory]
    [InlineData(2, 3, 5)]
    [InlineData(11, 4, 15)]
    [InlineData(4, 1, 5)]
    [InlineData(8, 3, 11)]
    [InlineData(11, 2, 13)]
    public void testsuma(int a, int b, int resultadoesperado)
    {
        ///AAA Arange Act Assert
        ///Arange
        int resultadoreal;
        ///Act
        resultadoreal=operacionesbasicas.suma(a,b);
        ///Assert
        Assert.Equal(resultadoesperado, resultadoreal)

    }
}
