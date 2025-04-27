
using System.Diagnostics;

void PrintMenu()
{
    Console.WriteLine("============PIZZARIA FAMILIA OLIVEIRA================");
    Console.WriteLine("CARDAPIO");
    Console.WriteLine("1: Pizza de muçarela ........................R$ 70,00");
    Console.WriteLine("2: Pizza de calabresa .......................R$ 73,00");
    Console.WriteLine("3: Pizza de frango ..........................R$ 78,00");
    Console.WriteLine("4: Pizza dois amores ........................R$ 78,00");
    Console.WriteLine("5: Pizza de abacaxi .........................R$ 80,00");
    Console.WriteLine("================ESCOLHA O SABOR======================");
}
double valorMucarela = 70;
double valorCalabresa = 73;
double valorFrango = 78;
double valorDoisAmores = 78;
double valorAbacaxi = 80;
double valortotal = 0;
var opcao = 1;
List<string> saborDaPizza = new List<string>();
List<string> metodoPagamento = new List<string>();


int SaborEscolhido()
{
    PrintMenu();
    if (!int.TryParse(Console.ReadLine(), out int valorDigitado))
    {
        System.Console.WriteLine("Opção inválida, tente novamente");
        return SaborEscolhido();
    }
    return valorDigitado;
}

while (opcao == 1)
{
    int valorDigitado = SaborEscolhido();
    switch (valorDigitado)
    {
        case 1:
            Thread.Sleep(1000);
            Console.WriteLine("você escolheu a pizza de MUÇARELA");
            valortotal += valorMucarela;
            saborDaPizza.Add("Muçarela");
            break;

        case 2:
            Thread.Sleep(1000);
            Console.WriteLine("Você escolheu a pizza de CALABRESA");
            valortotal += valorCalabresa;
            saborDaPizza.Add("Calabresa");
            break;

        case 3:
            Thread.Sleep(1000);
            Console.WriteLine("Você escolheu uma pizza de frango");
            valortotal += valorFrango;
            saborDaPizza.Add("Frango");
            break;

        case 4:
            Thread.Sleep(1000);
            Console.WriteLine("Você escolheu a pizza de dois amores");
            valortotal += valorDoisAmores;
            saborDaPizza.Add("Dois amores");
            break;

        case 5:
            Thread.Sleep(1000);
            Console.WriteLine("Você escolheu a pizza de abacaxí");
            valortotal += valorAbacaxi;
            saborDaPizza.Add("Abacaxi");
            break;

    }

    Console.WriteLine("Gostaria de escolher um nov1o sabor? 1-SIM  0-NAO");
    opcao = int.Parse(Console.ReadLine());

    if (opcao != 1)
        Console.WriteLine("O valor da conta deu " + valortotal + " Reais. Gostaria de seguir para a finalização da compra? 1:SIM   2:NÃO");
}

int aceitarCompra = int.Parse(Console.ReadLine());
if (aceitarCompra == 1)
    formasDePagamento();
else
    Console.WriteLine("Obrigado, até a próxima");

int formasDePagamento()

{
    Console.WriteLine("==========METODOS DE PAGAMENTO===========");
    Console.WriteLine("1: Pagamento com Débito");
    Console.WriteLine("2: Pagamento com Crédito");
    Console.WriteLine("3: Pagamento com pix");
    Console.WriteLine("4: Pagamento em dinheiro");
    Console.WriteLine("==========================================");
    Console.WriteLine("Selecione o método de pagamento");

    if (!int.TryParse(Console.ReadLine(), out int EscolhaPagamento))
    {
        Console.WriteLine("Opção inválida, tente novamente");
        return formasDePagamento();
    }
    switch (EscolhaPagamento)
    {
        case 1:
            Console.WriteLine("O tipo de pagamento selecionado foi DÉBITO e será cobrado um valor de: " + valortotal + " reais");
            metodoPagamento.Add("Débito");
            break;

        case 2:
            Console.WriteLine("O tipo de pagamento escolhido foi CRÉDITO e será cobrado um valor de : " + valortotal + " reais");
            metodoPagamento.Add("Crédito");
            break;

        case 3:
            Console.WriteLine("O tipo de pagamento escolhido foi PIX e será cobrado um valor de : " + valortotal + " reais");
            metodoPagamento.Add("Pix");
            break;

        case 4:
            Console.WriteLine("O tipo de pagamento escolhido foi em DINHEIRO e será cobrado um valor de : " + valortotal + " reais");
            metodoPagamento.Add("Dinheiro");
            break;
    }
    return EscolhaPagamento;
}

string DadosUsuario()
{
    Console.WriteLine("Digite seu NOME:");
    string nomeUser = Console.ReadLine();
    return nomeUser;
}
string User = DadosUsuario();

string Endereco()
{
    Console.WriteLine("Digite seu ENDEREÇO");
    string Enderecouser = Console.ReadLine();
    return Enderecouser;
}
string Local = Endereco();


Console.WriteLine("================PIZZARIA FAMILIA OLIVEIRA===============");
Console.WriteLine("              Obrigado por comprar conosco            ");
Console.WriteLine($"Nome do cliente: {User}");
foreach (string pizza in saborDaPizza)
{
    Console.WriteLine($"Sabor(es) escolhido(s): {pizza} ");
}
foreach (string metodo in metodoPagamento)
{
    Console.WriteLine($"Metodo de pagamnto: {metodo}");
}
Console.WriteLine($"Endereço: {Local}");
Console.WriteLine("              Sua pizza está sendo preparada!");
Console.WriteLine("========================================================");

// Quero fazer a lista aparecer o sabor, acho que pra isso preciso declarar uma variavel string (sabor da pizza)
// HAHAHAHHAHAHAHA AAAAAAAAAAAAAAAAAAI BOLSONARO
// Certo, declarar uma variável maior que englobe o sabor das pizzas (SaborPizza), abrir variaveis menores dos sabores que 
