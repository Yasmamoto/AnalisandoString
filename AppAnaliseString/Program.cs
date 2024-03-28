// exemplo 1
string str = "Hello";
string resultado = str.Replace("l", "w");

Console.WriteLine($"\n{resultado}");

//exemplo 2
str = "Feijão com Arroz";
resultado = str.Replace("Arroz", "batata");

Console.WriteLine($"\n{resultado}");

//exemplo 3
string str2 = "Oi";
string texto = str2 + " Mundo";

Console.WriteLine($"\n{texto}");

//exemplo 4
int n = 3;
string texto2 = n + " palavra";

Console.WriteLine($"\n{texto2}");

//exemplo 5

string st = "Hello";
string maisc = st.ToUpper();
Console.WriteLine($"\n{maisc}");

//exemplo 6

string st2 = "Hello";
string minusc = st2.ToLower();
Console.WriteLine($"\n{minusc}");

// exemplo 7

string str4 = " Vamos aprender Python? ";
Console.WriteLine($"\n{str4}");
string res = str4.Trim();
Console.WriteLine($"\n{res}");

// exemplo 8
string s1 = "Hello";
string s2 = "HELLO";
bool b1 = s1.Equals("Hello");
bool b2 = s1.Equals(s2);
Console.WriteLine($"\nb1: {b1}");
Console.WriteLine($"\nb2: {b2}");

//exemplo 9
string frase = "FICO EM CASA";
int tamanho = frase.Length;
Console.WriteLine($"\nTamanho da string: {tamanho}");
Console.WriteLine($"\nSubstring (2, 4): {frase.Substring(2,4)}");
Console.WriteLine($"\nSubstring (5,7): {frase.Substring(5,7)}");

//Exemplo 10
string num = "69999502431";
string ddd = num.Substring(0, 2);
string num1 = num.Substring(2, 5);
string num2 = num.Substring(7, 4);

string msk = $"({ddd})-{num1}-{num2}";
Console.WriteLine($"\nTelefone com máscara: {msk}");

//Exemplo 11
string numMsk = "(69)-99950-2431";
string dddMsk = numMsk.Substring(1, 2);
string num1Msk = numMsk.Substring(5, 5);
string num2Msk = numMsk.Substring(11, 4);
string semMask = dddMsk + num1Msk + num2Msk;
Console.WriteLine($"\nTelelfone SEM máscara: {semMask}");

//Exemplo 12
string frase2 = "FOCO; NO; CURSO";
string[] registro = frase2.Split(';');
Console.WriteLine($"\nPosição: [0] {registro[0]}");
Console.WriteLine($"\nPosição: [1] {registro[1]}");
Console.WriteLine($"\n:posição [2] {registro[2]}");

// Exemplo 13
string frase3 = "FOCO/NO/CURSO/ADS";
string[] registro2 = frase3.Split('/');
Console.WriteLine($"\nPosição [0]: {registro2[0]}");
Console.WriteLine($"\nPosição [1]: {registro2[1]}");
Console.WriteLine($"\nPosição [2]: {registro2[2]}");
Console.WriteLine($"\nPosição [3]: {registro2[3]}");

Console.ReadKey();