using System;
using System.Linq.Expressions;

public class Program
{
    public static double[] CreerTableau()
    {
        Console.WriteLine("Saisir le nombre d'éléments harmoniques");
        try
        {
            double Taille = Convert.ToInt32(Console.ReadLine());
            double[] tableau = new double[(int)Taille];
            return tableau;
        } 
        
        catch(Exception e) //ajout personnel, malgré la non nécessité de le faire.
        {
            Console.WriteLine($"Erreur {e.Message}");
            return [];
        }
        
    }
    public static void AfficherTableau(double[] tableau)
    {
        Console.WriteLine("Le tableau résultat contient :");
        foreach (float valeur in tableau) { Console.WriteLine($" {valeur:F2}"); }
    }

    public static void Calcul_Harmonique(double[] tableau)
    {
        tableau[0] = 1;
        for(int valeur = 1; valeur < tableau.Length; valeur++)
        {
            tableau[valeur] = tableau[valeur - 1] + (1/((float)valeur+1));
        }
    }

    public static void Main(string[] args)
    {
        double[] tab;
        try
        {
            tab = CreerTableau();
            Calcul_Harmonique(tab);
            AfficherTableau(tab);
        } catch(Exception e) { Console.WriteLine(e.ToString()); } //ajout personnel, malgré la non nécessité de le faire.
    }
}