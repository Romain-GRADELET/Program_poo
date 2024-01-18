using System;
using System.Linq;

namespace program_poo
{
    class Personne
    {
        static int nombreDePersonne = 0;

        public string nom { get; init; }

        int _age;
        public int age {
            get
            {
                //Console.WriteLine("Je suis dans le get de age");
                return _age;
            } 
            set 
            {
                //Console.WriteLine("Je suis dans le set de age");
                if (value >= 0)
                {
                    _age = value;
                }
                
            } 
        }
        public string emploi { get; init; }

        int numeroPersonne;


       /*public string GetNom()
        {
            return nom;
        }

        public string SetNom(string value)
        {
            return nom = value;
        }*/

        public Personne()
        {
            nombreDePersonne++;
            this.numeroPersonne = nombreDePersonne;
        }

        // :this() permet d'exécuter le premier constructeur l44
        public Personne(string nom_param, int age_param, string emploi_param = null) : this()
        {

            this.nom = nom_param;
            this.age = age_param;
            this.emploi = emploi_param;

           
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

            var personne1 = new Personne { nom = "Paul", age = 20, emploi = "ingénieur" };
            var personne2 = new Personne { nom = "Jacques", age = 35};

            //personne1.nom = "toto";

            personne1.age = 5;

            personne1.Afficher();
            personne2.Afficher();


        }
    }
}