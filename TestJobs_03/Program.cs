/*3) Dado um vetor que guarda o valor de faturamento diário de uma distribuidora, faça um programa, na linguagem que desejar, que calcule e retorne:
• O menor valor de faturamento ocorrido em um dia do mês;
• O maior valor de faturamento ocorrido em um dia do mês;
• Número de dias no mês em que o valor de faturamento diário foi superior à média mensal.

IMPORTANTE:
a) Usar o json ou xml disponível como fonte dos dados do faturamento mensal;
b) Podem existir dias sem faturamento, como nos finais de semana e feriados. Estes dias devem ser ignorados no cálculo da média;*/



using Newtonsoft.Json;

// Dados de exemplo em formato JSON
string json = @"{'faturamento_diario': [500.0, 800.0, 0.0, 1200.0, 600.0, 0.0, 1500.0, 1000.0, 700.0, 900.0, 1100.0, 1300.0, 0.0, 1400.0, 2000.0, 1800.0, 1700.0, 1900.0, 2500.0, 2200.0, 0.0, 2700.0, 3000.0, 2800.0, 2600.0, 2400.0, 2100.0, 0.0, 1600.0, 400.0]}";

// Deserializa o JSON para um objeto
dynamic dados = JsonConvert.DeserializeObject(json);

// Extrai o vetor de faturamento diário
double[] faturamento = dados.faturamento_diario.ToObject<double[]>();

// Calcula o menor valor de faturamento diário
double menor = faturamento.Min();

// Calcula o maior valor de faturamento diário
double maior = faturamento.Max();

// Calcula a média mensal ignorando os dias sem faturamento
double media = faturamento.Where(valor => valor > 0).Average();

// Calcula o número de dias com faturamento diário superior à média mensal
int acimaDaMedia = faturamento.Count(valor => valor > media);

// Imprime os resultados
Console.WriteLine($"Menor valor: {menor}");
Console.WriteLine($"Maior valor: {maior}");
Console.WriteLine($"Dias acima da média: {acimaDaMedia}");

