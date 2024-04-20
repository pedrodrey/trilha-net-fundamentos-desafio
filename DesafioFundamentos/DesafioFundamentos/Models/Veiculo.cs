namespace DesafioFundamentos.Models
{
    public class Veiculo
    {
        public string NomeCondutor { get; set; }
        public long CpfCondutor { get; set; }
        public string Placa { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }

        public Veiculo(string nomeCondutor, long cpfCondutor, string placa, string marca, string modelo)
        {
            NomeCondutor = nomeCondutor;
            CpfCondutor = cpfCondutor;
            Placa = placa;
            Marca = marca;
            Modelo = modelo;
        }

        public bool ValidarPlaca()
        {
            return Placa.Length >= 7 && Placa.Length <= 8;
        }

        public bool VerificarDadosNulosOuVazios()
        {
            if (string.IsNullOrEmpty(NomeCondutor) || CpfCondutor == 0 || string.IsNullOrEmpty(Placa) || string.IsNullOrEmpty(Marca) || string.IsNullOrEmpty(Modelo))
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return Marca + ", " + Modelo + ", Placa: " + Placa; 
        }
    }
}
