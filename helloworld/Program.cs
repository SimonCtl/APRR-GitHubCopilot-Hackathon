using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.VisualBasic.FileIO;
using System.Text.RegularExpressions;

public static class Program
{
    public class Employee
    {
        public string? Nom { get; set; }
        public string? Prenom { get; set; }
        public string? Email { get; set; }
        public DateTime DateEntreeEntreprise { get; set; }
        public double TempsTravailHebdomadaire { get; set; }
    }

    public static void Main()
    {
        string CsvPath = "./employees.csv";

        // Implémenter une fonction pour calculer une factorielle
        int n = 5;
        int factorial = CalculateFactorial(n);
        Console.WriteLine($"Factorielle de {n} est {factorial}");

        // Lire les employés depuis le fichier CSV et les stocker dans une liste
        List<Employee> employees = ReadEmployeesFromCsv(CsvPath);

        // Afficher les employés et vérifier si les emails sont valides
        DisplayEmployeesAndValidateEmails(employees);

        // Trier les employés par date d'entrée dans l'entreprise
        SortEmployeesByDate(employees);

        // Afficher les employés triés par date d'entrée
        DisplaySortedEmployees(employees);

        // Convertir le temps de travail hebdomadaire au format classique et afficher
        ConvertAndDisplayTimeFormat(employees);
    }

    // Fonction pour calculer une factorielle
    private static int CalculateFactorial(int n)
    {
        if (n == 0)
            return 1;
        else
            return n * CalculateFactorial(n - 1);
    }

    // Fonction pour lire les employés depuis un fichier CSV
    private static List<Employee> ReadEmployeesFromCsv(string csvPath)
    {
        List<Employee> employees = new List<Employee>();

        string[] lines = File.ReadAllLines(csvPath);

        // Saute la ligne d'entête
        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i];
            string[] fields = line.Split(',');

            Employee employee = new Employee
            {
                Nom = fields[0],
                Prenom = fields[1],
                Email = fields[2],
                DateEntreeEntreprise = DateTime.Parse(fields[3]),
                TempsTravailHebdomadaire = double.Parse(fields[4])
            };

            employees.Add(employee);
        }

        return employees;
    }

    // Fonction pour trier les employés par date d'entrée dans l'entreprise
    private static void SortEmployeesByDate(List<Employee> employees)
    {
        employees.Sort((x, y) => x.DateEntreeEntreprise.CompareTo(y.DateEntreeEntreprise));
    }

    // Fonction pour convertir le temps de travail hebdomadaire au format classique (hh:mm)
    private static string ConvertToClassicFormat(double tempsTravailHebdomadaire)
    {
        TimeSpan timeSpan = TimeSpan.FromHours(tempsTravailHebdomadaire);
        return timeSpan.ToString(@"hh\:mm");
    }

    // Fonction pour valider une adresse email en utilisant une expression régulière
    public static bool IsValidEmail(string email)
    {
        string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
        return Regex.IsMatch(email, pattern);
    }

    // Fonction pour afficher les employés et vérifier si les emails sont valides
    private static void DisplayEmployeesAndValidateEmails(List<Employee> employees)
    {
        foreach (Employee employee in employees)
        {
            Console.WriteLine($"Nom: {employee.Nom}");
            Console.WriteLine($"Prénom: {employee.Prenom}");
            Console.WriteLine($"Email: {employee.Email}");
            Console.WriteLine($"Date d'entrée dans l'entreprise: {employee.DateEntreeEntreprise}");
            Console.WriteLine($"Temps de travail hebdomadaire: {employee.TempsTravailHebdomadaire}");

            bool isValidEmail = IsValidEmail(employee.Email);
            Console.WriteLine($"Email valide: {isValidEmail}");

            Console.WriteLine();
        }
    }

    // Fonction pour afficher les employés triés par date d'entrée
    private static void DisplaySortedEmployees(List<Employee> employees)
    {
        Console.WriteLine("Employés triés par date d'entrée dans l'entreprise:");
        foreach (Employee employee in employees)
        {
            Console.WriteLine($"Nom: {employee.Nom}");
            Console.WriteLine($"Prénom: {employee.Prenom}");
            Console.WriteLine($"Email: {employee.Email}");
            Console.WriteLine($"Date d'entrée dans l'entreprise: {employee.DateEntreeEntreprise}");
            Console.WriteLine($"Temps de travail hebdomadaire: {employee.TempsTravailHebdomadaire}");
            Console.WriteLine();
        }
    }

    // Fonction pour convertir le temps de travail hebdomadaire au format classique et afficher
    private static void ConvertAndDisplayTimeFormat(List<Employee> employees)
    {
        Console.WriteLine("Temps de travail hebdomadaire au format classique (hh:mm):");
        foreach (Employee employee in employees)
        {
            string classicFormat = ConvertToClassicFormat(employee.TempsTravailHebdomadaire);
            Console.WriteLine($"Nom: {employee.Nom}");
            Console.WriteLine($"Prénom: {employee.Prenom}");
            Console.WriteLine($"Temps de travail hebdomadaire (format classique): {classicFormat}");
            Console.WriteLine();
        }
    }
}
