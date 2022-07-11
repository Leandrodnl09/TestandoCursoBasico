using System.Globalization;

// Testando exercício "Extremamente Básico"

// Console.WriteLine("Digite o valor de A:");
// int A = int.Parse(Console.ReadLine());
// Console.WriteLine("Digite o valor de B:");
// int B = int.Parse(Console.ReadLine());

// int X = A + B;

// Console.WriteLine("O valor de X é: " + X);



// Testando exercício "Área do Circulo"

// double n = 3.14159;
// double raio, area;

// raio = double.Parse(Console.ReadLine());

// area = n * (raio * raio);

// Console.WriteLine("A=" + area.ToString("F4"));



// Testando exercício "Média 1 - Ponderada"

// double Altura, Base, Area, Diagonal, Perimetro;

// Base = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
// Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

// Area = Base * Altura;
// Perimetro = 2 * (Altura + Base);
// Diagonal = Math.Sqrt(Math.Pow(Base, 2.0) + Math.Pow(Altura, 2.0));

// Console.WriteLine("AREA = " + Area.ToString("F4"));
// Console.WriteLine("PERIMETRO = " + Perimetro.ToString("F4"), CultureInfo.InvariantCulture);
// Console.WriteLine("DIAGONAL = " + Diagonal.ToString("F4"), CultureInfo.InvariantCulture);



// Testando Exerícios "Nélio Alves com Strings"

// string Nome1, Nome2;
// int Idade1, Idade2;
// double Media;

// string [] vet;

// vet = Console.ReadLine().Split(' ');
// Nome1 = vet[0];
// Idade1 = int.Parse(vet[1]);
// vet = Console.ReadLine().Split(' ');
// Nome2 = vet[0];
// Idade2 = int.Parse(vet[1]);
// Console.WriteLine(" ");

// Media = (Idade1 + Idade2) / 2.0;

// Console.WriteLine("A idade média de " + Nome1 + " e " + Nome2 + 
// " é de " + Media.ToString("F1", CultureInfo.InvariantCulture) + " anos!");



// Testando Exercício "Salário dom Bônus"

// string Nome;
// double Total, Salario, Vendas;

// Nome = Console.ReadLine();
// Salario = double.Parse(Console.ReadLine());
// Vendas = double.Parse(Console.ReadLine());

// Vendas = Vendas * 0.15;
// Total = Vendas + Salario;

// Console.WriteLine("TOTAL = R$ " + Total.ToString("F2"));



// Testando Exercício "Calculo Simples"

// int Cod1, Cod2, Quantidade1, Quantidade2;
// double Valor1, Valor2, Total;

// string [] vet;
// vet = Console.ReadLine().Split(' ');
// Cod1= int.Parse(vet[0]);
// Quantidade1 = int.Parse(vet[1]);
// Valor1 = double.Parse(vet[2]);

// vet = Console.ReadLine().Split(' ');
// Cod2= int.Parse(vet[0]);
// Quantidade2 = int.Parse(vet[1]);
// Valor2 = double.Parse(vet[2]);

// Valor1 = Valor1 * Quantidade1;
// Valor2 = Valor2 * Quantidade2;
// Total = Valor1 + Valor2;

// Console.WriteLine("VALOR A PAGAR = R$ " + Total.ToString("F2"));


// Testando Exercícios de Calculos:

// double Pi, Volume, Raio;

// Raio = double.Parse(Console.ReadLine());

// Pi = 3.14159;
// Volume = (4.0 / 3) * Pi * (Math.Pow(Raio, 3));

// Console.WriteLine("VOLUME = " + Volume.ToString("F3"));



// double A, B, C, pi, Triangulo, Circulo, Trapezio, Quadrado, Retangulo;

// pi = 3.14159;

// string [] vet;
// vet = Console.ReadLine().Split(' ');
// A = double.Parse(vet[0]);
// B = double.Parse(vet[1]);
// C = double.Parse(vet[2]);

// Triangulo = (A * C) / 2;
// Circulo = pi * Math.Pow(C, 2);
// Trapezio = (A + B) * C / 2;
// Quadrado = Math.Pow(B, 2);
// Retangulo = A * B;

// Console.WriteLine("TRIANGULO: " + Triangulo.ToString("F3"));
// Console.WriteLine("CIRCULO: " + Circulo.ToString("F3"));
// Console.WriteLine("TRAPEZIO: " + Trapezio.ToString("F3"));
// Console.WriteLine("QUADRADO: " + Quadrado.ToString("F3"));
// Console.WriteLine("RETANGULO: " + Retangulo.ToString("F3"));



// Testando exercício URI "Maior usando função ABS"

// int A, B, C, MaiorAB, Maior;

// string [] vet;
// vet = Console.ReadLine().Split(' ');
// A = int.Parse(vet[0]);
// B = int.Parse(vet[1]);
// C = int.Parse(vet[2]);

// MaiorAB = (A + B + Math.Abs(A - B)) / 2;
// Maior = (MaiorAB + C + Math.Abs(MaiorAB - C)) / 2;

// Console.WriteLine(Maior + " eh o maior");



// Tewtando exercício de consumo da URI

// int X;
// double Y, Media;

// X = int.Parse(Console.ReadLine());
// Y = double.Parse(Console.ReadLine());

// Media = X / Y;

// Console.WriteLine(Media.ToString("F3") + " km/l");



// Testando distancia entre dois pontos "Exercício URI"

// double Distancia, X1, X2, Y1, Y2;

// string [] vet;

// vet = Console.ReadLine().Split(' ');
// X1 = double.Parse(vet[0]);
// Y1 = double.Parse(vet[1]);

// vet = Console.ReadLine().Split(' ');
// X2 = double.Parse(vet[0]);
// Y2 = double.Parse(vet[1]);

// Distancia = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));

// Console.WriteLine(Distancia.ToString("F4"));



// Testando exercício "Média"

// int Tempo, Velocidade;
// double QuatidadeLitros;

// Tempo = int.Parse(Console.ReadLine());
// Velocidade = int.Parse(Console.ReadLine());

// QuatidadeLitros = (double) Tempo * Velocidade / 12;

// Console.WriteLine(QuatidadeLitros.ToString("F3"));



// Testando exercício "Cédulas"

// int N, Resto, Quociente, Nota;

// N = int.Parse(Console.ReadLine());

// Console.WriteLine(N);

// Resto = N;

// Nota = 100;
// Quociente = Resto / Nota;
// Console.WriteLine(Quociente + " nota(s) de R$ " + Nota + ",00");
// Resto = Resto % Nota;

// Nota = 50;
// Quociente = Resto / Nota;
// Console.WriteLine(Quociente + " nota(s) de R$ " + Nota + ",00");
// Resto = Resto % Nota;

// Nota = 20;
// Quociente = Resto / Nota;
// Console.WriteLine(Quociente + " nota(s) de R$ " + Nota + ",00");
// Resto = Resto % Nota;

// Nota = 10;
// Quociente = Resto / Nota;
// Console.WriteLine(Quociente + " nota(s) de R$ " + Nota + ",00");
// Resto = Resto % Nota;

// Nota = 5;
// Quociente = Resto / Nota;
// Console.WriteLine(Quociente + " nota(s) de R$ " + Nota + ",00");
// Resto = Resto % Nota;

// Nota = 2;
// Quociente = Resto / Nota;
// Console.WriteLine(Quociente + " nota(s) de R$ " + Nota + ",00");
// Resto = Resto % Nota;

// Console.WriteLine(Resto + " nota(s) de R$ 1,00");



// Testando exercício "Conversão de tempo"

// int Segundos, Minutos, Horas, Resto, N;

// N = int.Parse(Console.ReadLine());

// Horas = N / 3600;
// Resto = N % 3600;
// Minutos = Resto / 60;
// Segundos = Resto % 60;

// Console.WriteLine(Horas + ":" + Minutos + ":" + Segundos);



// Testando exercício "Idade em dias"

// int Ano, Mes, Dias, Resto, N;

// N = int.Parse(Console.ReadLine());

// Ano = N / 365;
// Console.WriteLine(Ano + " ano(s)");
// Resto = N % 365;

// Mes = Resto / 30;
// Console.WriteLine(Mes + " mes(es)");
// Dias = Resto % 30;

// Console.WriteLine(Dias + " dia(s)");



// Testando exercício "Notas e Moedas"

// double N;
// int quociente, resto, nota, moeda;

// N = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

// // Vamos multiplicar N por 100 e forçar a conversão para int.
// // Desse modo, por exemplo, 576.73 vai se tornar 57673

// // Vamos tambem somar 0.5 antes de converter, para assegurar 
// // que o numero seja devidamente arredondado, pois o tipo double
// // as vezes da problema de arredondamento (por exemplo: se digitarmos
// // 576.81 e multiplicarmos por 100, o resultado sera 57680.99999999,
// // dai o casting resultaria em 57680 e nao 57681 como desejado)

// resto = (int)(N * 100.0 + 0.5);

// Console.WriteLine("NOTAS:");

// // como multiplicamos o valor por 100 acima, o valor de cada nota
// // também deverá ser multiplicado por 100 a seguir

// nota = 100;
// quociente = resto / (nota * 100);
// Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
// resto = resto % (nota * 100);

// nota = 50;
// quociente = resto / (nota * 100);
// Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
// resto = resto % (nota * 100);

// nota = 20;
// quociente = resto / (nota * 100);
// Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
// resto = resto % (nota * 100);

// nota = 10;
// quociente = resto / (nota * 100);
// Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
// resto = resto % (nota * 100);

// nota = 5;
// quociente = resto / (nota * 100);
// Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
// resto = resto % (nota * 100);

// nota = 2;
// quociente = resto / (nota * 100);
// Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
// resto = resto % (nota * 100);

// Console.WriteLine("MOEDAS:");

// // o valor de cada moeda deverá ser representado em centavos

// moeda = 100;
// quociente = resto / moeda;
// Console.WriteLine(quociente + " moeda(s) de R$ 1.00");
// resto = resto % moeda;

// moeda = 50;
// quociente = resto / moeda;
// Console.WriteLine(quociente + " moeda(s) de R$ 0.50");
// resto = resto % moeda;

// moeda = 25;
// quociente = resto / moeda;
// Console.WriteLine(quociente + " moeda(s) de R$ 0.25");
// resto = resto % moeda;

// moeda = 10;
// quociente = resto / moeda;
// Console.WriteLine(quociente + " moeda(s) de R$ 0.10");
// resto = resto % moeda;

// moeda = 5;
// quociente = resto / moeda;
// Console.WriteLine(quociente + " moeda(s) de R$ 0.05");
// resto = resto % moeda;

// Console.WriteLine(resto + " moeda(s) de R$ 0.01");




// Testando exercício "Teste de seleção 1"

// int A, B, C, D;

// string [] vet;

// vet = (Console.ReadLine().Split(' '));

// A = int.Parse(vet [0]);
// B = int.Parse(vet [1]);
// C = int.Parse(vet [2]);
// D = int.Parse(vet [3]);

// if (B > C && D > A && C + D > A + B && C > 0 && D > 0 && A % 2 == 0){
//     Console.WriteLine("Valores aceitos");
// }else{
//     Console.WriteLine("Valores nao aceitos");
// }



// Testando exercício "Baskara"

// double A, B, C, R1, R2, delta;

// string [] vet = Console.ReadLine().Split(' ');

// A = double.Parse(vet[0]);
// B = double.Parse(vet[1]);
// C = double.Parse(vet[2]);

// delta = 0;
// delta = (Math.Pow(B, 2)) - (4 * A * C);

// if (A == 0 || delta < 0)
// {
//     Console.WriteLine("Impossivel calcular");
// }
// else
// {
//     R1 = ((-B) + Math.Sqrt(delta)) / (2 * A);
//     Console.WriteLine("R1 = " + R1.ToString("F5"));
//     R2 = ((-B) - Math.Sqrt(delta)) / (2 * A);
//     Console.WriteLine("R2 = " + R2.ToString("F5"));
// }



// Testando exeecício "Intervalo"

double numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

if (numero < 0.0 || numero > 100.0)
{
    Console.WriteLine("Fora de intervalo");
}
else if (numero <= 25.0)
{
    Console.WriteLine("Intervalo [0,25]");
}
else if (numero <= 50.0)
{
    Console.WriteLine("Intervalo (25,50]");
}
else if (numero <= 75.0)
{
    Console.WriteLine("Intervalo (50,75]");
}
else
{
    Console.WriteLine("Intervalo (75,100]");
}