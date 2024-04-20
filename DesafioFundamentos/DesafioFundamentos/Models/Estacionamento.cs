namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        //instancia classe Veiculo
        Veiculo veiculo;

        private decimal PrecoInicial = 0;
        private decimal PrecoPorHora = 0;
        //declara lista do tipo veiculo
        private List<Veiculo> veiculos = new List<Veiculo>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            PrecoInicial = precoInicial;
            PrecoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Entre com os Dados do Veículo:");

            Console.Write("Nome do Condutor: ");
            string nomeCondutor = Console.ReadLine();

            Console.Write("CPF do Condutor: ");
            long cpfCondutor = long.Parse(Console.ReadLine());

            Console.Write("Placa do Veículo: ");
            string placa = Console.ReadLine();

            Console.Write("Marca do Veículo: ");
            string marca = Console.ReadLine();

            Console.Write("Modelo do Veículo: ");
            string modelo = Console.ReadLine();

            //instancia objeto do tipo veiculo
            Veiculo veiculo = new Veiculo(nomeCondutor, cpfCondutor, placa, marca,modelo);
            //adiciona veiculo a lista Veiculos
            veiculos.Add(veiculo);
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine();

            //Obtém a placa do veiculo igual a placa digitada pelo usuario
            if (veiculos.Any(x => x.Placa.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                int horas = int.Parse(Console.ReadLine());
                decimal valorTotal = PrecoInicial + PrecoPorHora * horas;

                veiculos.RemoveAll(x => x.Placa.Equals(placa));
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("\nOs veículos estacionados são:");

                for (int i = 0; i < veiculos.Count; i++)
                {
                    Console.WriteLine(veiculos[i].ToString());
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
