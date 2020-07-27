using Xunit;
using UnitTestsNetCore;

namespace XUnitTestProject1
{
    public class CalculadoraTest
    {
        private readonly Calculadora _sut;
        public CalculadoraTest()
        {
            _sut = new Calculadora();
        }

        [Theory]
        [InlineData(3, 2, 1)]
        [InlineData(1, 2, -1)]
        [InlineData(20, 20, 0)]
        public void Somar_DeveRetornarValor_QuandoInformadoAmbosNumeros(decimal esperado,
                                                                        decimal Num1,
                                                                        decimal Num2)
        {
            var resultado = _sut.Somar(Num1, Num2);
            Assert.Equal(esperado, resultado);
        }
        
        [Theory]
        [InlineData(0, 2, 2)]
        [InlineData(-2, 0, 2)]
        [InlineData(20, 40, 20)]
        public void Subtrair_DeveRetornarValor_QuandoInformadoAmbosNumeros(decimal esperado,
                                                                       decimal Num1,
                                                                       decimal Num2)
        {
            var resultado = _sut.Subtrair(Num1, Num2);
            Assert.Equal(esperado, resultado);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(0, 0, 2)]
        [InlineData(2, 40, 20)]
        public void Dividir_DeveRetornarValor_QuandoInformadoAmbosNumeros(decimal esperado,
                                                                       decimal Num1,
                                                                       decimal Num2)
        {
            var resultado = _sut.Dividir(Num1, Num2);
            Assert.Equal(esperado, resultado);
        }

        [Theory]
        [InlineData(4, 2, 2)]
        [InlineData(0, 0, 2)]
        [InlineData(800, 40, 20)]
        public void Multiplicar_DeveRetornarValor_QuandoInformadoAmbosNumeros(decimal esperado,
                                                                       decimal Num1,
                                                                       decimal Num2)
        {
            var resultado = _sut.Multiplicar(Num1, Num2);
            Assert.Equal(esperado, resultado);
        }
    }
}
