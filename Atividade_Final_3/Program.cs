using Atividade_Final_3;

List<Cliente> clientes;
List<Funcionarios> funcionarios;
List<CadastroDeServicos> cadastroDeServicos;

Cliente _cliente;
Funcionarios _func = new Funcionarios();
CadastroDeServicos _cadastroDeServicos;
Console.WriteLine("Escolha uma das opções:");
Console.WriteLine("(1) para cadastrar clientes:");
Console.WriteLine("(2) para cadastrar funcionários:");
Console.WriteLine("(3) para cadastrar serviços:");
int opcao = int.Parse(Console.ReadLine());

if (opcao == 1)
{
    clientes = new List<Cliente>();
    _cliente = new Cliente();
    Console.WriteLine("Digite o nome do cliente:");
    _cliente.Nome = Console.ReadLine();
    Console.WriteLine("Digite o telefone:");
    _cliente.Telefone = Console.ReadLine();

}