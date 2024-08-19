// Questão 1
int A = 10;
float B = 1.2f;
string C = "Olá";
bool D = true;

Console.WriteLine(A);
Console.WriteLine(B);
Console.WriteLine(C);
Console.WriteLine(D);

// Questão 2
Console.WriteLine("Digite dois números inteiros");
string[] numeros = Console.ReadLine().Split(' ');

int A = int.Parse(numeros[0]);
int B = int.Parse(numeros[1]);

Console.WriteLine($"Soma = {A + B}");
Console.WriteLine($"Subtração = {A - B}");
Console.WriteLine($"Divisão = {A / B}");
Console.WriteLine($"Multiplicação = {A * B}");

// Questão 3
Console.WriteLine("Digite seu nome e sua idade");
string[] nomeidade = Console.ReadLine().Split(' ');

string nome = nomeidade[0];
int idade = int.Parse(nomeidade[1]);

Console.WriteLine($"Olá, {nome}, você tem {idade} anos.");

// Questão 4
Console.WriteLine("Digite um número");
string A = Console.ReadLine();
double num = double.Parse(A);
 if (num > 0)
{Console.WriteLine("O número é positivo.");
}
            else if (num < 0)
            {
                Console.WriteLine("O número é negativo.");
            }
            else if (num == 0)
            {
                Console.WriteLine("O número é zero.");
            }
        
        else
        {
            Console.WriteLine("Entrada inválida. Por favor, digite um número.");
        }

// Questão 5
for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }

// Questão 6
Console.WriteLine("Digite sua idade");
double idade = double.Parse(Console.ReadLine());
if(idade >= 18)
{
Console.WriteLine("Apto a votar e dirigir.");
} 
else if(idade == 16)
{
    Console.WriteLine("Apto a votar.");
}
else
{
    Console.WriteLine("Não está apto a votar e nem dirigir.");
}

// Questão 7
static float CalcularMedia(float nota1, float nota2, float nota3)
{
    float media = (nota1 + nota2 + nota3) / 3;
    return media;
}

static void Main()
{
    Console.WriteLine("Digite as três notas separadas por espaço:");

    string[] entrada = Console.ReadLine().Split(' ');
    float nota1 = float.Parse(entrada[0]);
    float nota2 = float.Parse(entrada[1]);
    float nota3 = float.Parse(entrada[2]);

    float media = CalcularMedia(nota1, nota2, nota3);

    Console.WriteLine("A média das notas é: " + media);
}
//Questão 8
Console.WriteLine("Escreva 3 números.");
string[] entrada = Console.ReadLine().Split(' ');
int numeros0 = int.Parse(entrada[0]);
int numeros1 = int.Parse(entrada[1]);
int numeros2 = int.Parse(entrada[2]);

 int maior = numeros0;
        if (numeros1 > maior)
        {
            maior = numeros1;
        }
        if (numeros2 > maior)
        {
            maior = numeros2;
        }

        int menor = numeros0;
        if (numeros1 < menor)
        {
            menor = numeros1;
        }
        if (numeros2 < menor)
        {
            menor = numeros2;
        }

        Console.WriteLine($"Maior: {maior}" );
        Console.WriteLine($"Menor: {menor}");

// Questão 9 
int soma = 0;
        int numero;
        do
        {
            Console.WriteLine("Digite um número (digite 0 para sair):");
            numero = int.Parse(Console.ReadLine());

            soma += numero;

        } while (numero != 0); 
        Console.WriteLine("A soma de todos os números digitados é: " + soma);

// Questão 10
Console.WriteLine("Digite o valor em reais que deseja converter.");
double reais = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a cotação atual do dólar.");
double dolar = double.Parse(Console.ReadLine());

double Resultado = reais * dolar;

Console.WriteLine("Resultado: " + Resultado +  " Dólares.");

// Questão 11
static void Main(string[] args)
    {
        Console.Write("Digite um número para calcular o fatorial: ");
        int n = int.Parse(Console.ReadLine());

        int resultado = CalcularFatorial(n);

        if (resultado != -1)
        {
            Console.WriteLine($"O fatorial de {n} é: {resultado}");
        }
        else
        {
            Console.WriteLine("Não é possível calcular o fatorial de um número negativo.");
        }
    }

    static int CalcularFatorial(int n)
    {
        if (n < 0)
        {
            return -1; // Retorna -1 para indicar que o fatorial de um número negativo não é definido.
        }
        else if (n == 0)
        {
            return 1; // Caso base: o fatorial de 0 é 1.
        }
        else
        {
            return n * CalcularFatorial(n - 1); // Chamada recursiva.
        }
    }

// Questão 12
Console.WriteLine("Digite um número positivo maior que zero para gerar a sequência de Fibonacci:");
        int n = int.Parse(Console.ReadLine());

        
        if (n <= 0)
        {
            Console.WriteLine("Número inválido. Por favor, insira um número positivo maior que zero.");
        }
        else
        {
            Console.WriteLine($"Sequência de Fibonacci até {n}:");
            
            int a = 0, b = 1, proximo;

            
            Console.Write(a);

            
            while (b <= n)
            {
                Console.Write(", " + b);
                proximo = a + b;
                a = b;
                b = proximo;
            }
        }

// Questão 13
        string input = Console.ReadLine();

        
        string[] nomes = input.Split(',');

               for (int i = 0; i < nomes.Length; i++)
        {
            nomes[i] = nomes[i].Trim();
        }

        
        OrdenarNomes(nomes);

        
        Console.WriteLine("Lista de nomes ordenada:");
        foreach (string nome in nomes)
        {
            Console.WriteLine(nome);
        }
    

    static void OrdenarNomes(string[] nomes)
    {
        int n = nomes.Length;
        bool houveTroca;

               for (int i = 0; i < n - 1; i++)
        {
            houveTroca = false;

            for (int j = 0; j < n - i - 1; j++)
            {
                if (nomes[j].CompareTo(nomes[j + 1]) > 0)
                {
string temp = nomes[j];
                    nomes[j] = nomes[j + 1];
                    nomes[j + 1] = temp;

                    houveTroca = true;
                }
            }
        }
    }

