// strings
string name = "Angelo";
char letraInicial = 'A';
char tipoSanguineo = 'O';

//numbers
int idade = 19;
long populacaoDaTerra = 8100000000L;
short numeroDoAndar = 12;

double alturaEmMetros = 1.82;
float pesoEmKg = 75.5f;
decimal salarioMensal = 4550.99m;

//boolean values
bool clienteAtivo = true;
bool pagamentoEfetuado = false;

//The compiler "know" how which is the type 
var cidade = "São Paulo";
var quanti = 183.2;

//some kind of specif examples
DateTime dataDeNascimento = new DateTime(1995, 10, 25);
DateTime agora = DateTime.Now;

// Example of formated print
string msg = $"Hello Word!, I'am {name} and I'am {idade} years old";

Console.WriteLine(msg);

//or do in the Console Command
Console.WriteLine($"Name:{name}, Age:{idade}, height:{quanti}");