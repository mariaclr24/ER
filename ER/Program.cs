using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string matricula = "";
        bool matriculaOk = false;

        Console.WriteLine("Escreva uma matrícula na forma AA-99-99:");
        matricula = Console.ReadLine();

        try
        {
            Regex re = new Regex(@"^[A-Z]{2}-[0-9]{2}-\d{2}$");

            matriculaOk = re.IsMatch(matricula);

            if (matriculaOk)
                Console.WriteLine("Matrícula válida!");
            else
                Console.WriteLine("Matrícula inválida!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ocorreu um erro: " + ex.Message);
        }
    }
}
