namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placaAdd = Console.ReadLine();
            veiculos.Add(placaAdd);
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            // Pedir para o usuário digitar a placa e armazenar na variável placa
            string placaRemove = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placaRemove.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                string horasEstacionado = Console.ReadLine();

                int horas = 0;
                decimal valorTotal = 0;

                if (int.TryParse(horasEstacionado, out int horasInt))
                {
                    horas = horasInt;
                    valorTotal = precoInicial + precoPorHora * horas;
                }
                else
                {
                    Console.WriteLine("Valor definido para quantidade de horas invalido!");
                }


                veiculos.Remove(placaRemove);

                Console.WriteLine($"O veículo {placaRemove} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");

                for (int quantidadeVeiculo = 0; quantidadeVeiculo < veiculos.Count; quantidadeVeiculo++)
                {
                    Console.WriteLine($"Veiculo Nº: {quantidadeVeiculo + 1} - Placa: {veiculos[quantidadeVeiculo]}");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
