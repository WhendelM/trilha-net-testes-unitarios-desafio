using TestesUnitarios.Desafio.Console.Services;

namespace TestesUnitarios.Desafio.Tests;

public class ValidacoesListaTests
{
    private ValidacoesLista _validacoes = new ValidacoesLista();

    [Fact]
    public void DeveRemoverNumerosNegativosDeUmaLista()
    {
        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var resultadoEsperado = new List<int> { 5, 9 };

        // Act
        var resultado = _validacoes.RemoverNumerosNegativos(lista);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void DeveConterONumero9NaLista()
    {
        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var numeroParaProcurar = 9;

        // Act
        var resultado = _validacoes.ListaContemDeterminadoNumero(lista, numeroParaProcurar);

        // Assert
        Assert.True(resultado);
    }

    [Fact]
    public void NaoDeveConterONumero10NaLista()
    {
        //Método implementado!

        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var numeroParaProcurar = 10;

        // Act
        bool NaoConter10 = _validacoes.ListaContemDeterminadoNumero(lista, 10);
        // Assert
        Assert.False(NaoConter10);
    }

    [Fact]
    public void DeveMultiplicarOsElementosDaListaPor2()
    {
        //Método implementado!
        // Arrange
        var lista = new List<int> { 5, 7, 8, 9 };
        var resultadoEsperado = new List<int> { 10, 14, 16, 18 };
        
        // Act
        var MultiplicaPor2 = _validacoes.MultiplicarNumerosLista(lista,2);
        // Assert
        Assert.Equal(resultadoEsperado, MultiplicaPor2);
    }

    [Fact]
    public void DeveRetornar9ComoMaiorNumeroDaLista()
    {
        //Método implementado!

        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };

        // Act
        var MaiorNumero9 = _validacoes.RetornarMaiorNumeroLista(lista);
        // Assert
        //Assert corrigido!
        Assert.Equal(9, MaiorNumero9);
    }

    [Fact]
    public void DeveRetornarOitoNegativoComoMenorNumeroDaLista()
    {
        //Método implementado!

        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        
        // Act
        var resultado = _validacoes.RetornarMenorNumeroLista(lista);

        // Assert
        //Assert corrigido!
        Assert.Equal(-8, resultado);
    }
}
