using System;
using System.Runtime.Intrinsics.X86;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        // Expressão regular que aceita AA-99-99, 99-AA-99 ou 99-99-AA
        string erString = @"^([A-Z]{2}-\d{2}-\d{2}|\d{2}-[A-Z]{2}-\d{2}|\d{2}-\d{2}-[A-Z]{2})$";
        Regex r = new Regex(erString);

        string matricula;
        bool matriculaOk;

        while (true)
        {
            Console.WriteLine("Escreva uma matrícula na forma AA-99-99, 99-AA-99, 99-99-AA (ou '.' para sair):");
            matricula = Console.ReadLine();

            // Sai do ciclo se o utilizador escrever '.'
            if (matricula == ".")
                break;

            try
            {
                matriculaOk = r.IsMatch(matricula);

                if (matriculaOk)
                    Console.WriteLine("Matrícula válida!");
                else
                    Console.WriteLine("Matrícula inválida!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
        }

        Console.WriteLine("Programa terminado.");
        // O símbolo '@' permite criar uma "string literal" de várias linhas
        const string example = @"“Uma string
com duas linhas";

        const string example2 = @"ola olé
ola
ola dfd
ola";

        // Regex para cada linha
        MatchCollection matches = Regex.Matches(example2, "^(.+)$", RegexOptions.Multiline);

        // ^(.+)$ -> ^ = início da linha, .+ = 1 ou mais caracteres, $ = fim da linha

        foreach (Match m in matches)
        {
            foreach (Capture capture in m.Captures)
            {
                // Mostrar cada linha
                Console.WriteLine("--" + capture.Value);
            }
        }
    }
}
