/*2) Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre será a soma dos 2 valores anteriores (exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...), 
 * Escreva um programa na linguagem que desejar onde, informado um número, ele calcule a sequência de Fibonacci e retorne uma mensagem avisando se o número informado pertence ou não a sequência.

IMPORTANTE:
Esse número pode ser informado através de qualquer entrada de sua preferência ou pode ser previamente definido no código;*/


//Declarando cada variável.
int X = 0, Y = 1, Zi , NINF;
Console.WriteLine("Digite um número? ");//Imprimindo a frase para que digite um número.
NINF = int.Parse(Console.ReadLine()); //O número informado será indo dentro da variável.

//O loop for será executando até que o valor da Fibo chegue ao número inserido dentro da NINF verificando se o mesmo pertence a sequência da Fibonacci ou não.
for (int i = 0; Y < NINF; i++)
{
    Zi = X;
    X = Y;
    Y = X + Zi;
    Console.WriteLine(Y);

}
if (NINF == Y)
{
    Console.WriteLine(NINF + " Pertence a fibonacci");
}
else
{
    Console.WriteLine(NINF + " Não pertence a fibonacci");
}
Console.WriteLine("Pressione a tecla ENTER para sair");
Console.ReadLine();