using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        string matricula = "";
        bool matriculaok = false;

        // Expressão regular para validar o formato AA-99-99
        string erString = @"^[A-Z]{2}-[0-9]{2}-\d{2}$";

        Console.WriteLine("Escreva uma matrícula na forma AA-99-99:");
        matricula = Console.ReadLine();

        try
        {
            Regex r = new Regex(erString);
            matriculaok = r.IsMatch(matricula);

            if (matriculaok)
                Console.WriteLine("Matrícula válida");
            else
                Console.WriteLine("Matrícula inválida");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro: " + ex.Message);
        }
    }
}
