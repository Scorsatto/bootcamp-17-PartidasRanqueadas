Console.WriteLine("Quantidade de vitórias");
int vitorias = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Quantidade de derrotas");
int derrotas = Convert.ToInt32(Console.ReadLine());

int saldoVitorias = vitorias - derrotas;

string nivel = "";

switch (saldoVitorias)
{
    case <= 10:
        nivel = "Ferro";
        break;

    case <= 20:
        nivel = "Bronze";
        break;

    case <= 50:
        nivel = "Prata";
        break;

    case <= 80:
        nivel = "Ouro";
        break;

    case <= 90:
        nivel = "Diamante";
        break;

    case <= 100:
        nivel = "Lendário";
        break;

    case > 100:
        nivel = "Imortal";
        break;
}

Console.WriteLine($"O Herói tem de saldo de {saldoVitorias} está no nível de {nivel}");