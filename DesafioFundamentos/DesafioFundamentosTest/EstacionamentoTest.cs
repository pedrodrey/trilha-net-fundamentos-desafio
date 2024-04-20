using DesafioFundamentos.Models;

namespace DesafioFundamentosTest
{
    public class EstacionamentoTest
    {
        [Theory]
        [InlineData("ABC1D34")] // Placa válida com 7 caracteres
        [InlineData("XYZ-6789")] // Placa válida com 8 caracteres
        [InlineData("ABC123")] // Placa inválida com menos de 7 caracteres
        [InlineData("ABCDEFGHIJ")] // Placa inválida com mais de 8 caracteres
        public void ValidarPlacaVeiculo(string placa)
        {
            //Arrange
            Estacionamento estacionamento = new Estacionamento(1, 1);
            Veiculo veiculo = new Veiculo("Pedro", 11122233300, placa, "Volkswagen", "Jetta");

            //Act
            bool placaValida = veiculo.ValidarPlaca();

            //Assert
            Assert.True(placaValida);
        }

        [Fact]
        public void VerificarDadosNulosOuVazios()
        {
            // Arrange
            Veiculo veiculo1 = new Veiculo(null, 0, "ABC1234", "Volkswagen", "Jetta");
            Veiculo veiculo2 = new Veiculo("", 12345678900, "ABC-1234", "Volkswagen", "Jetta");
            Veiculo veiculo3 = new Veiculo("João", 12345678900, null, "Volkswagen", "Jetta");
            Veiculo veiculo4 = new Veiculo("Maria", 0, "DEF5678", "Volkswagen", "Jetta");
            Veiculo veiculo5 = new Veiculo("Pedro", 12345678900, "ABC7N77", "Volkswagen", "Jetta");

            // Act
            bool resultado1 = veiculo1.VerificarDadosNulosOuVazios();
            bool resultado2 = veiculo2.VerificarDadosNulosOuVazios();
            bool resultado3 = veiculo3.VerificarDadosNulosOuVazios();
            bool resultado4 = veiculo4.VerificarDadosNulosOuVazios();
            bool resultado5 = veiculo5.VerificarDadosNulosOuVazios();


            // Assert
            Assert.True(resultado1);
            Assert.True(resultado2);
            Assert.True(resultado3);
            Assert.True(resultado4);
            Assert.False(resultado5);

        }
    }
}