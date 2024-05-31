using System;
using System.Linq.Expressions;

public class Program
{
    public static int[] CreerTableau()
    {
        Console.WriteLine("Saisir le nombre d'éléments harmoniques");
        try
        {
            int Taille = Convert.ToInt32(Console.ReadLine());
            int[] tableau = new int[Taille];
            return tableau;
        } 
        
        catch(Exception e)
        {
            Console.WriteLine($"Erreur {e.Message}");
            return [];
        }
        
    }
    public static void AfficherTableau(int[] tableau)
    {
        Console.WriteLine("Le tableau résultat contient :");
        foreach (int valeur in tableau) { Console.WriteLine(valeur + " "); }
    }

    public static void Calcul_Harmonique(int[] tableau)
    {
        tableau[0] = 1;
        for(int valeur = 1; valeur < tableau.Length; valeur++)
        {
            tableau[valeur] = tableau[valeur - 1] + (1/valeur+1);
        }
    }

    public static void Main(string[] args)
    {
        int[] tab;
        try
        {
            tab = CreerTableau();
            Calcul_Harmonique(tab);
            AfficherTableau(tab);
        } catch(Exception e) { Console.WriteLine(e.ToString()); }
        
    }
}