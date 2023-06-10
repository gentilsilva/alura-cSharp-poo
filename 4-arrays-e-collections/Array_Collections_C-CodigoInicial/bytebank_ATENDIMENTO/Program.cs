using bytebank.Modelos.Conta;
using bytebank_ATENDIMENTO.bytebank.Exceptions;
using bytebank_ATENDIMENTO.bytebank.Util;
using System.Collections;
using System.Linq.Expressions;
using System.Threading.Channels;

Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");

#region Exmplos Arrays em C#
void TestaArrayInt()
{
    float media = 0;
    int[] idades = new int[5];
    idades[0] = 30;
    idades[1] = 40;
    idades[2] = 17;
    idades[3] = 21;
    idades[4] = 18;

    Console.WriteLine($"Tamanho do Array {idades.Length}");
    
    for(int i = 0; i < idades.Length; i++)
    {
        Console.WriteLine($"Índice = [{i}] = {idades[i]}");
        media += idades[i];
    }

    media = media / idades.Length;
    Console.WriteLine($"Média de idades = {media}");
}
//TestaArrayInt();

void TestaBuscarPalavra()
{
    string[] arrayDePalavras = new string[5];
    string palavraBuscada;

    for(int i = 0; i < arrayDePalavras.Length; i++)
    {
        Console.Write($"Digite a {i + 1}º palavra: ");
        arrayDePalavras[i] = Console.ReadLine();
    }

    Console.Write("Digite a palavra a ser encontrada: ");
    palavraBuscada = Console.ReadLine();

    foreach(string palavra in arrayDePalavras)
    {
        if(palavra.Equals(palavraBuscada))
        {
            Console.WriteLine($"Palavra encontrada = {palavraBuscada}.");
            break;
        }
    }
}
//TestaBuscarPalavra();

Array amostra = Array.CreateInstance(typeof(double), 5);
amostra.SetValue(5.9, 0);
amostra.SetValue(1.8, 1);
amostra.SetValue(7.1, 2);
amostra.SetValue(10, 3);
amostra.SetValue(6.9, 4);

void TestaMediana(Array array)
{
    if(array == null || array.Length == 0) Console.WriteLine("Array para cálculo de mediana está vazio ou nulo.");

    double[] numerosOrdenados = (double[]) array.Clone();
    Array.Sort(numerosOrdenados);

    int tamanhoArray = numerosOrdenados.Length;
    int meio = tamanhoArray / 2;
    double mediana = (tamanhoArray % 2 != 0) ? numerosOrdenados[meio] : (numerosOrdenados[meio - 1]) / 2;

    Console.WriteLine($"Com base na amostra a mediana = {mediana}");
}
//TestaMediana(amostra);

void TestaArrayDeContasCorrentes()
{
    ListaDeContasCorrentes listaDeContas = new ListaDeContasCorrentes();
    listaDeContas.Adicionar(new ContaCorrente(874, "5679787-A"));
    listaDeContas.Adicionar(new ContaCorrente(874, "4456668-B"));
    listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C"));
    var ContaDoGentil = new ContaCorrente(963, "123456-X");
    listaDeContas.Adicionar(ContaDoGentil);
    //listaDeContas.ExibirLista();
    //Console.WriteLine("===============");
    //listaDeContas.Remover(ContaDoGentil);
    //listaDeContas.ExibirLista();

    for (int i = 0; i < listaDeContas.Tamanho; i++)
    {
        ContaCorrente conta = listaDeContas[i];
        Console.WriteLine($"Índice[{i}] - Conta: {conta.Conta}/{conta.Numero_agencia}");
    }
}
//TestaArrayDeContasCorrentes();
#endregion 
#region Exemplos de uso do List
//List<string> nomesDosEscolhidos = new List<string>()
//{
//    "Bruce Wayne",
//    "Carlos Vilagran",
//    "Richard Grayson",
//    "Bob Kane",
//    "Will Farrel",
//    "Lois Lane",
//    "General Welling",
//    "Perla Letícia",
//    "Uxas",
//    "Diana Prince",
//    "Elisabeth Romanova",
//    "Anakin Wayne"
//};

//bool ExisteNaLista(string escolha, List<string> lista)
//{
//    return lista.Contains(escolha);
//}

//Console.WriteLine(ExisteNaLista("Anakin Wayne", nomesDosEscolhidos));




//Generica<int> testeUm = new Generica<int>();
//testeUm.MostrarMensagem(10);

//Generica<string> testeDois = new Generica<string>();
//testeDois.MostrarMensagem("Olá");

//public class Generica<T>
//{
//    public void MostrarMensagem(T t)
//    {
//        Console.WriteLine($"Exibindo {t}");
//    }
//}



//List<ContaCorrente> _listaDeContasDois = new List<ContaCorrente>()
//{
//    new ContaCorrente(874, "5679787-A"),
//    new ContaCorrente(874, "4456668-B"),
//    new ContaCorrente(874, "7781438-C"),
//};

//List<ContaCorrente> _listaDeContasTres = new List<ContaCorrente>()
//{
//    new ContaCorrente(874, "5679787-E"),
//    new ContaCorrente(874, "4456668-F"),
//    new ContaCorrente(874, "7781438-G"),
//};

//_listaDeContasDois.AddRange(_listaDeContasTres);
//_listaDeContasDois.Reverse();
//for(int i = 0; i < _listaDeContasDois.Count; i++)
//{
//    Console.WriteLine($"Índice[{i}] = Conta [{_listaDeContasDois[i].Conta}]");
//}

//Console.WriteLine("\n\n");

//var range = _listaDeContasTres.GetRange(0, 1);
//for (int i = 0; i < range.Count; i++)
//{
//    Console.WriteLine($"Índice[{i}] = Conta [{range[i].Conta}]");
//}

//Console.WriteLine("\n\n");

//_listaDeContasTres.Clear();
//for (int i = 0; i < _listaDeContasTres.Count; i++)
//{
//    Console.WriteLine($"Índice[{i}] = Conta [{_listaDeContasTres[i].Conta}]");
//}
#endregion 

List<ContaCorrente> _listaDeContas = new List<ContaCorrente>()
{
    new ContaCorrente(95, "123456-X") {Saldo = 100},
    new ContaCorrente(95, "951258-X") {Saldo = 200},
    new ContaCorrente(95, "987321-W") {Saldo = 60}
};

AtendimentoCliente();

void AtendimentoCliente()
{
    try
    {
        char opcao = '0';
        while (opcao != '6')
        {
            Console.Clear();
            Console.WriteLine("===============================");
            Console.WriteLine("===       Atendimento       ===");
            Console.WriteLine("=== 1 - Cadastrar Conta     ===");
            Console.WriteLine("=== 2 - Lista Contas        ===");
            Console.WriteLine("=== 3 - Remover Conta       ===");
            Console.WriteLine("=== 4 - Ordenar Contas      ===");
            Console.WriteLine("=== 5 - Pesquisar Conta     ===");
            Console.WriteLine("=== 6 - Sair do Sistema     ===");
            Console.WriteLine("\n\n");
            Console.Write("Digite a opção desejada: ");
            try
            {
                opcao = Console.ReadLine()[0];
            }
            catch (Exception excecao)
            {
                throw new ByteBankException(excecao.Message);
            }
            switch (opcao)
            {
                case '1':
                    CadastrarConta();
                    break;
                case '2':
                    ListarContas();
                    break;
                default:
                    Console.WriteLine("Opção não implementada.");
                    break;

            }
        }
    }
    catch (ByteBankException excecao)
    {
        Console.WriteLine($"{excecao.Message}"); ;
    }
}

void CadastrarConta()
{
    Console.Clear();
    Console.WriteLine("===============================");
    Console.WriteLine("===    CADASTRO DE CONTA    ===");
    Console.WriteLine("===============================");
    Console.WriteLine("\n");
    Console.WriteLine("=== Informe dados da conta  ===");

    Console.Write("Numero da conta: ");
    string numeroDaConta = Console.ReadLine();

    Console.Write("Número da Agência: ");
    int numeroAgencia = int.Parse(Console.ReadLine());

    ContaCorrente conta = new ContaCorrente(numeroAgencia, numeroDaConta);

    Console.Write("Informe o saldo inicial: ");
    conta.Saldo = double.Parse(Console.ReadLine());

    Console.Write("Informe o nome do Titular: ");
    conta.Titular.Nome = Console.ReadLine();

    Console.Write("Informe CPF do Titular: ");
    conta.Titular.Cpf = Console.ReadLine();

    Console.Write("Informe a profissão do Titular: ");
    conta.Titular.Profissao = Console.ReadLine();

    _listaDeContas.Add(conta);

    Console.WriteLine("... Conta cadastrada com sucesso! ...");
    Console.ReadKey();
}

void ListarContas()
{
    Console.Clear();
    Console.WriteLine("===============================");
    Console.WriteLine("===    LISTAR CONTAS    ===");
    Console.WriteLine("===============================");
    Console.WriteLine("\n");

    if (_listaDeContas.Count <= 0)
    {
        Console.WriteLine("... Não há contas cadastradas! ...");
        Console.ReadKey();
        return;
    }
    foreach ( ContaCorrente item in _listaDeContas )
    {
        Console.WriteLine("===   Dados da Conta   ===");
        Console.WriteLine("Número da conta: " + item.Conta);
        Console.WriteLine("Titular da conta: " + item.Titular.Nome);
        Console.WriteLine("CPF do Titular: " + item.Titular.Cpf);
        Console.WriteLine("Profissão do Titular: " + item.Titular.Profissao);
        Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
        Console.ReadKey();
    }
}


