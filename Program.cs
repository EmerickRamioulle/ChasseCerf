/*
Arthur dispose de 5 flèches pour chasser un cerf.

Consignes :
- Demander au joueur si chaque tir touche ou rate la cible.
- Décrémenter le nombre de flèches après chaque tir.
- Compter le nombre de tirs réussis.
- Arrêter la chasse lorsque les 5 flèches sont utilisées.
- Arrêter immédiatement la chasse si le cerf est touché 3 fois.
- Si la saisie est invalide, demander une nouvelle réponse
sans consommer de flèche.
- Afficher le bilan final de la chasse.
*/
int fleche = 5;
int reussite = 0;
string solution = "touche";
do
{
    Console.WriteLine("Ta fleche touche ou rate ?");
    string answer = Console.ReadLine();

    if (answer == solution)
    {
        reussite++;
        Console.WriteLine("Tu as touché ta cible");
        Console.WriteLine("Il te reste " + fleche);
    }
    else
    {
        fleche--;
        Console.WriteLine("Tu as raté ta cible");
        Console.WriteLine("Il te reste " + fleche);
    }

} while (fleche > 0 && reussite < 3);
if (reussite == 3)
{
    Console.WriteLine("Félicitations ! ");
}
else
{
    Console.WriteLine("Perdu... ");
}
