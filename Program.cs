
void PrintMenu()
{
    Console.WriteLine("============PIZZARIA FAMILIA OLIVEIRA================");
    Console.WriteLine(                     "CARDAPIO"                        );
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
PrintMenu();


int SaborEscolhido()
{
    Console.WriteLine("Escolha o sabor");
    int valorDigitado = int.Parse(Console.ReadLine());
    return valorDigitado;
}

while(opcao == 1)
{
    int valorDigitado = SaborEscolhido();
    switch(valorDigitado)
    {
        case 1:
        Thread.Sleep(1000);
        Console.WriteLine("você escolheu a pizza de MUÇARELA");
        valortotal += valorMucarela;
        break;

        case 2:
        Thread.Sleep(1000);
        Console.WriteLine("Você escolheu a pizza de CALABRESA");
        valortotal += valorCalabresa;
        break;

        case 3:
        Thread.Sleep(1000);
        Console.WriteLine("Você escolheu a pizza de frango");
        valortotal += valorFrango;
        break;
        
        case 4:
        Thread.Sleep(1000);
        Console.WriteLine("Você escolheu a pizza de dois amores"); 
        valortotal += valorDoisAmores;
        break;

        case 5:
        Thread.Sleep(1000);
        Console.WriteLine("Você escolheu a pizza de abacaxí"); 
        valortotal += valorAbacaxi;
        break;

    }
    Console.WriteLine("Gostaria de escolher um nov1o sabor? 1-SIM  0-NAO");
    opcao = int.Parse(Console.ReadLine());

    if(opcao != 1)
        Console.WriteLine("O valor da conta deu: " + valortotal + " REAIS, PODENDO SER PAGOS EM MAMADAS");
}


 
  




