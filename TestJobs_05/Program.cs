/*5) Escreva um programa que inverta os caracteres de um string.

IMPORTANTE:
a) Essa string pode ser informada através de qualquer entrada de sua preferência ou pode ser previamente definida no código;
b) Evite usar funções prontas, como, por exemplo, reverse;*/



// Definindo a string a ser invertida
string original = "Exemplo de string a ser invertida";

// Convertendo a string em um array de caracteres
char[] caracteres = original.ToCharArray();

// Invertendo os caracteres do array
for (int i = 0; i < caracteres.Length / 2; i++)
{
    char temp = caracteres[i];
    caracteres[i] = caracteres[caracteres.Length - i - 1];
    caracteres[caracteres.Length - i - 1] = temp;
}

// Convertendo o array de caracteres de volta para uma string
string invertida = new string(caracteres);

// Exibindo a string invertida
Console.WriteLine(invertida);


