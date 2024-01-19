using System;
using System.Linq;

namespace program_poo
{
    class Etudiant : Personne
    {
        string infoEtude;
        public Personne professeurPrincipal { get; init; }

        public Etudiant(string nom_param, int age_param, string infoEtude_param) : base(nom_param, age_param, "Etudiant")
        {
            this.infoEtude = infoEtude_param;
        }
        public override void Afficher()
        {
            AfficherNomEtAge();
            Console.WriteLine(" Etudiant en " + infoEtude);
            if (professeurPrincipal != null)
            {
                Console.WriteLine(" Le professeur principal est : ");
                professeurPrincipal.Afficher();
            }
            else
            {
                Console.WriteLine(" Aucun professeur principal spécifié");
            }
        }
    }

    class Personne
    {
        static int nombreDePersonne = 0;

        protected string nom;
        protected int age;
        protected string emploi;
        protected int numeroPersonne;

        public Personne(string nom_param, int age_param, string emploi_param = null)
        {
            this.nom = nom_param;
            this.age = age_param;
            this.emploi = emploi_param;

            nombreDePersonne++;
            this.numeroPersonne = nombreDePersonne;
        }

        public virtual void Afficher()
        {
            AfficherNomEtAge();

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

        protected void AfficherNomEtAge()
        {
            Console.WriteLine("N° : " + numeroPersonne);
            Console.WriteLine("NOM : " + nom);
            Console.WriteLine(" AGE : " + age + " ans");
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

            //var personne1 = new Personne { nom = "Paul", age = 20, emploi = "ingénieur" };
            //var personne2 = new Personne { nom = "Jacques", age = 35};

            //var personne1 = new Personne("Paul", 35, "Professeur");

            var etudiant = new Etudiant("David", 20, "école d'ingénieur informatique") { professeurPrincipal = new Personne("Paul", 35, "Professeur") };
            etudiant.Afficher();

        }
    }
}