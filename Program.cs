using Cadastro_Pessoa_FS1.Classes;

Console.WriteLine(@$"
=================================================
|     Bem Vindo ao sistema de cadastro de       |
|       Pessoas Fisicas e Juridicas             |
=================================================
");

Console.BackgroundColor = ConsoleColor.DarkCyan;
Console.ForegroundColor = ConsoleColor.Red;

Console.Write("Carregando");

for (var contador = 0; contador < 10; contador++)
{
    Console.Write(".");
    Thread.Sleep(500);
}
string? opcao;
do
{

    Console.ResetColor();

    Console.WriteLine(@$"
=================================================
|       Escolha uma das opções abaixo           |
-------------------------------------------------
|           1 - Pessoa Física                   |
|           2 - Pessoa Jurídica                 |
|                                               |
|           0 - Sair                            |
=================================================
");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            PessoaFisica metodoPf = new PessoaFisica();

            PessoaFisica novaPf = new PessoaFisica();
            Endereco novoEnd = new Endereco();

            novaPf.ValidarDataNasc(new DateTime(2000, 01, 01));


            novaPf.nome = "Odirlei";
            novaPf.dataNascimento = "01/01/2000";
            novaPf.cpf = "1234567890";
            novaPf.rendimento = 15000.5f;

            novoEnd.logradouro = "Alameda Barão de Limeira";
            novoEnd.numero = 539;
            novoEnd.complemento = "SENAI Informática";
            novoEnd.endComercial = true;

            novaPf.endereco = novoEnd;

            Console.WriteLine(@$"
Nome: {novaPf.nome}
Endereço: {novaPf.endereco.logradouro}, {novaPf.endereco.numero}
Maior de idade: {((bool)metodoPf.ValidaDataNascimento(novaPf.dataNascimento) ? "Sim" : "Não")}
Taxa de imposto a ser paga é: {metodoPf.PagarImposto(novaPf.rendimento).ToString "C"}
");

if ((bool)metodoPf.ValidaDataNascimento(novaPf.dataNascimento))
{
    Console.WriteLine($"Sim");
}
else
{
    Console.WriteLine($"Não");
}

            Console.WriteLine($"Aperte 'Enter' para continuar");
            Console.ReadLine();

            break;

        case "2":
            PessoaJuridica metodoPj = new PessoaJuridica();
            PessoaJuridica novoPj = new PessoaJuridica();
            Endereco novoEndPj = new Endereco();

            novoPj.nome = "Nome Pj";
            novoPj.Cnpj = "00.000.000/0001.00";
            novoPj.RazaoSocial = "Razão Social Pj";
            novoPj.rendimento = 8000.5f;

            novoEndPj.logradouro = "Alameda Barão de Limeira";
            novoEndPj.numero = 539;
            novoEndPj.complemento = "SENAI Informática";
            novoEndPj.endComercial = true;

            novoPj.endereco = novoEndPj;

            Console.Clear();
            Console.WriteLine($"
            Nome: { novoPj.nome}
            Razao Social: { novoPj.RazaoSocial}
        CNPJ: { novoPj.Cnpj}
            CNPJ Válido}
    metodoPj.ValidarCnpj(novoPj.cnpj)"});

            Console.WriteLine($"Aperte 'Enter' para continuar");
    Console.ReadLine();

    break;

        case "0";

            Console.Clear();
    Console.WriteLine($"Obrigado por utilizar nosso sistema");

    BarraCarregamento("Finalizando");

    break;

    default:
            Console.WriteLine($"Opção inválida, por favor digite outra opção");
    Thread.Sleep(2000);
    break;

    while (opcao != "0") ;

    void BarraCarregamento(string v)
    {
        throw new NotImplementedException();
    }

    static void BarraCarregamento(string texto, int tempo)
    {
        Console.BackgroundColor = ConsoleColor.DarkCyan;
        Console.ForegroundColor = ConsoleColor.Red;

        Console.Write($"{texto}");

        for (var contador = 0; contador < 10; contador++)
        {
            Console.Write(".");
            Thread.Sleep(tempo);
        }

        Console.ResetColor();

    }