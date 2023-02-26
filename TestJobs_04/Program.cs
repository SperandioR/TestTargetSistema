/*4) Dado o valor de faturamento mensal de uma distribuidora, detalhado por estado:

SP – R$67.836,43
RJ – R$36.678,66
MG – R$29.229,88
ES – R$27.165,48
Outros – R$19.849,53

Escreva um programa na linguagem que desejar onde calcule o percentual de representação que cada estado teve dentro do valor total mensal da distribuidora.*/

using System.Globalization;

CultureInfo CI = CultureInfo.InvariantCulture;

// Define os valores de faturamento de cada estado
double sp = 67836.43;
double rj = 36678.66;
double mg = 29229.88;
double es = 27165.48;
double outros = 19849.53;

// Calcula o total de faturamento mensal da distribuidora
double total = sp + rj + mg + es + outros;

// Calcula o percentual de representação de cada estado
double pctSp = (sp / total) * 100;
double pctRj = (rj / total) * 100;
double pctMg = (mg / total) * 100;
double pctEs = (es / total) * 100;
double pctOutros = (outros / total) * 100;

// Exibe os resultados
Console.WriteLine("Percentual de representação por estado:");
Console.WriteLine($"SP: {pctSp.ToString("F2", CI)}%");
Console.WriteLine($"RJ: {pctRj.ToString("F2", CI)}%");
Console.WriteLine($"MG: {pctMg.ToString("F2", CI)}%");
Console.WriteLine($"ES: {pctEs.ToString("F2", CI)}%");
Console.WriteLine($"Outros: {pctOutros.ToString("F2", CI)}%");

