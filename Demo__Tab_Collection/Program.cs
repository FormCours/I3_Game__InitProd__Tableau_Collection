/*******************************************************/
/**** TABLEAU                                        ***/
/*******************************************************/
Console.WriteLine("DEMO TABLEAU");


// Initialisation
// **************

// Syntaxe original
int[] tab0 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int[] tab1 = new int[5];

// Syntaxe simplifier 1 (Suppresion le "new int[]")
int[] tab2 = { 1, 2, 3, 4, 5, 6, 7 };

// Syntaxe simplifier 2 (Inspiration du Python et JS - Non supporté sur Unity)
int[] tab3 = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13];

// Utilisation
// ***********

// Affectation d'une des valeurs via l'index
tab1[2] = 42;

// Lecture d'une valeur du tableau
Console.WriteLine("Valeur du tab3: {0}, {1}, {2}", tab3[1], tab3[4], tab3[10]);
Console.WriteLine($"Valeur du tab3: {tab3[1]}, {tab3[4]}, {tab3[10]}");

// Afficher toutes les valeurs de tab0
// - Conversion en "string"
Console.WriteLine("En chaine : " + string.Join(", ", tab0));

// - Parcours via une boucle
Console.WriteLine("Via une boucle \"for\" : ");
for(int i = 0; i < tab0.Length; i++)
{
    // Possibilité de modifier le tableau
    int val = tab0[i];
    Console.WriteLine(val);
}

Console.WriteLine("Via une boucle \"foreach\" : ");
foreach(int val in tab0)
{
    // Utilisation pour de la lecture uniquement !
    Console.WriteLine(val); 
}


// Longeur de la tableau
Console.WriteLine("Longeur des tableaus : ");
Console.WriteLine(tab1.Length);
Console.WriteLine(tab2.Length);


Console.WriteLine();
Console.WriteLine();
Console.WriteLine();


Console.Clear();
/*******************************************************/
/**** COLLECTION                                     ***/
/*******************************************************/
Console.WriteLine("DEMO COLLECTION");

// Initialisation
// **************

// Liste vide
List<int> col1 = new List<int>();
List<int> col2 = new List<int>(10); // → Capacité initial (Optimisation)

// Liste avec des valeurs
List<string> col3 = new List<string>() { "Riri", "Della", "Balthazar" };
List<string> col4 = new() { "Riri", "Della", "Balthazar" };

// - Nouvelle syntaxe (Non supporté sur Unity 😭)
List<string> col5 = ["Della", "Donald", "Loulou"];

// Longeur de la collection
Console.WriteLine("Longeur des collections");
Console.WriteLine(col1.Count);
Console.WriteLine(col2.Count);


// Utilisation
// ***********

// Récuperer un élément via son index
string duck = col5[1];
Console.WriteLine(duck);

// Modifier un élément via son index
col5[2] = "Archibald";

// Ajouter des éléments
col5.Add("Balthazar");
col5.AddRange("Riri", "Fifi", "Zaza");

// Parcourir une collection
Console.WriteLine("Affichage avant les remove");
for(int i = 0; i < col5.Count; i++)
{
    // Modification possible (affectation, ajout, suppression)
    Console.WriteLine(col5[i]);
}

// Supprimer des éléments
col5.RemoveAt(2);
col5.Remove("Zaza");
col5.RemoveAll(elem => elem.Contains("i")); // Teasing des fonctions :)

// Parcourir une collection
Console.WriteLine("Affichage apres les remove");
foreach(string name in  col5)
{
    // Pas d'affectation possible
    // Plantage si on modifie le nombre d'élément !
    Console.WriteLine(name); 
}

Console.Clear();
/*******************************************************/

// Mini exo commun
// ***************

// Liste d'étudiant (unique) avec leur nom et resultat
Dictionary<string, double> exo = new Dictionary<string, double>();
bool continueAddingStudent;

do
{
    // Saisie des données
    Console.WriteLine("Veuillez encoder le nom de l'étudiant");
    string student = Console.ReadLine() ?? throw new Exception("Le nom de l'étudiant est requis 💣");

    Console.WriteLine("Quel est le resultat de l'étudiant");
    double result = double.Parse(Console.ReadLine()!);

    // Ajout des données dans le dico
    exo.Add(student, result);
    
    // Question pour continuer l'ajout
    Console.WriteLine("Ajouter un autre étudiant ? (y/N)");
    continueAddingStudent = Console.ReadLine() == "y";
    //continueAddingStudent = Console.ReadLine()!.Equals("y", StringComparison.CurrentCultureIgnoreCase);
}
while (continueAddingStudent);


Console.WriteLine();
foreach(KeyValuePair<string, double> elem in exo)
{
    string student = elem.Key;
    double result = elem.Value;

    Console.WriteLine($" - {student} : {result}");
}

/*******************************************************/


// Choix d'une collection en .Net
// https://learn.microsoft.com/fr-fr/dotnet/standard/collections/#choose-a-collection