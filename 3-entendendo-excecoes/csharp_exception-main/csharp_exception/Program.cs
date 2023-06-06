using csharp_exception.Titular;
using csharp_exception.Contas;


try
{
    ContaCorrente contaUm = new(278, "1234-X");
    contaUm.Sacar(50);
    Console.WriteLine(contaUm.GetSaldo());
    contaUm.Sacar(150);
    Console.WriteLine(contaUm.GetSaldo());
}
catch (ArgumentException ex)
{
    //Console.WriteLine("Parâmetro com erro: " + ex.ParamName);
    //Console.WriteLine("Não é possível criar uma conta com o número de agência menor ou igual a zero!");
    Console.WriteLine(ex.Message);
}