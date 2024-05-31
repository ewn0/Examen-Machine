using System;

public class Program
{
    public static int[] CreerTableau()
    {
        Console.WriteLine("Saisir le nombre d'éléments harmoniques");
        int Taille = Convert.ToInt32(Console.ReadLine());
        /*if (Taille! > 0)
        {
            throw new Exception("Le nombre d'éléments doit être un nombre supérieur à 0.");
        }*/
        int[] tableau = new int[Taille];
        return tableau;

    }
    public static void AfficherTableau(int[] tableau)
    {
        Console.WriteLine("Le tableau résultat contient :");
        foreach (int valeur in tableau) { Console.WriteLine(valeur + " "); }
    }
}