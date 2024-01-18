using System;
using System.Linq;

namespace program_poo
{
    class Personne
    {
        static int nombreDePersonne = 0;

        string nom;
        int age;
        string emploi;
        int numeroPersonne;


       /* public Personne(string nom_param, int age_param) : this(nom_param, age_param, "(non spécifié)")
        {

        }*/
        public Personne(string nom_param, int age_param, string emploi_param = null)
        {

            this.nom = nom_param;
            this.age = age_param;
            this.emploi = emploi_param;

            nombreDePersonne++;

            this.numeroPersonne = nombreDePersonne;
        }

        public void Afficher()
        {
            Console.WriteLine("N° : " + numeroPersonne);
            Console.WriteLine("NOM : " + nom);
            Console.WriteLine(" AGE : " + age + " ans");

            if (emploi != null)
            {
                Console.WriteLine(" EMPLOI : " + emploi);
            }
            else
            {
            Console.WriteLine(" Aucun emploi spécifié");
            }
            Console.WriteLine();
        }

        public static void AfficherNombreDePersonne()
        {
            Console.WriteLine("Nombre total de personne : " + nombreDePersonne);

        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            /*var noms = new List<string>() {"Paul", "Jacques", "David", "Juliette" };
            var ages = new List<int>() { 30, 35, 20, 8 };
            var emplois = new List<string>() { "Développeur", "Professeur", "Etudiant", "CP" };

            for (int i = 0; i < noms.Count; i++)
            {
                AfficherInfoPersonne(noms[i], ages[i], emplois[i]);
            }*/

            //Personne personne1 = new Personne("Paul", 30, "Développeur");
            //personne1.Afficher();

            //Personne personne2 = new Personne("Jacques", 35, "Professeur");
            //personne2.Afficher();

            //---------------------------------------------------------------

            /*var personnes = new List<Personne>()
            {
                new Personne("Paul", 30, "Développeur"),
                new Personne("Jacques", 35, "Professeur"),
                new Personne("David", 20, "Etudiant"),
                new Personne("Juliette", 8, "CP")
            };

            //personnes = personnes.OrderBy(p => p.nom).ToList();

            foreach (var personne in personnes)
            {
                personne.Afficher();
                Personne.AfficherNombreDePersonne();
            }*/

            var personne1 = new Personne("Paul", 30, "Développeur");
            personne1.Afficher();

            
        }
    }
}