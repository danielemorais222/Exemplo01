public class Program
{
   public static void Main (string[] args)
    {
        veiculoDAO vdao = new veiculoDAO();
        do
        {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1.Cadastras Veículo");
            Console.WriteLine("2.Listar Todos");
            Console.WriteLine("3.Remover");
            Console.WriteLine("4.Buscar");
            Console.WriteLine("0.Sair");
            Console.WriteLine("Digite Cadastrar");
            int opcao = int.Parse(Console.ReadLine());
            if (opcao == 1)
            {
                Console.WriteLine("Qual placa?");
                string placa = Console.ReadLine();
                
                Console.WriteLine("qual Modelo?");
                string modelo = Console.ReadLine();

                Veiculo v = new Veiculo(placa, modelo);


                vdao.cadastrar(v);

            }
            else if (opcao == 2)
            {
                List<Veiculo> veiculos = vdao.ListarTodos();
                foreach (Veiculo veiculo in veiculos)
                {

                    Console.WriteLine(veiculo.modelo + "" + veiculo.placa);
                }

            }
            else
            {
               if(opcao == 3)
               {

               }
                else
                {
                   if(opcao == 4)
                    {
                        Console.WriteLine("qual placa");
                        string placa = Console.ReadLine();
                        Veiculo vplaca = vdao.BuscarPlaca(placa);
                        Console.WriteLine(vplaca.modelo);
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }while (true);
   }
}