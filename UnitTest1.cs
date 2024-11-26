namespace Projeto.Testes;

public class UnitTest1
{
    public Calculadora construirClasse()
    {
        string data = "25/11/2024";
        Calculadora calculadora = new Calculadora(data);

        return calculadora;
    }


    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(4, 5, 9)]
    public void TesteSomar(int num1, int num2, int resultado)
    {
        Calculadora calculadora = construirClasse();

        int resultadoCalculadora = calculadora.somar(num1, num2);
        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData(2, 1, 1)]
    [InlineData(5, 2, 3)]
    public void TesteSubtrair(int num1, int num2, int resultado)
    {
        Calculadora calculadora = construirClasse();

        int resultadoCalculadora = calculadora.subtrair(num1, num2);
        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData(1, 2, 2)]
    [InlineData(4, 5, 20)]
    public void TesteMultiplicar(int num1, int num2, int resultado)
    {
        Calculadora calculadora = construirClasse();

        int resultadoCalculadora = calculadora.multiplicar(num1, num2);
        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData(2, 1, 2)]
    [InlineData(10, 2, 5)]
    public void TesteDividir(int num1, int num2, int resultado)
    {
        Calculadora calculadora = construirClasse();

        int resultadoCalculadora = calculadora.dividir(num1, num2);
        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Fact]
    public void TestarDivisaoPorZero()
    {
        Calculadora calculadora = construirClasse();
        Assert.Throws<DivideByZeroException>(() => calculadora.dividir(3,0));
    }

        [Fact]
    public void TestarHistorico()
    {
        Calculadora calculadora = construirClasse();

        calculadora.somar(1, 2);
        calculadora.somar(3, 4);
        calculadora.somar(5, 6);
        calculadora.somar(10, 2);

        var lista = calculadora.historico();

        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count);
    }
}