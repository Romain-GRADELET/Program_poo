using System;
using System.Linq;

namespace program_poo
{
    class Enfant : Etudiant
    {
        string classeEcole;
        Dictionary<string, float> notes;

        public Enfant(string nom_param, int age_param, string classeEcole, Dictionary<string, float> notes) : base(nom_param, age_param, null)
        {
            this.classeEcole = classeEcole;
            this.notes = notes;
        }
        public override void Afficher()
        {
            AfficherNomEtAge();
            Console.WriteLine(" Enfant en classe de " + classeEcole);

            if ((notes != null)&&(notes.Count != 0)){
                Console.WriteLine("Notes moyennes : ");
                foreach (var note in notes)
                {
                    Console.WriteLine("  " + note.Key + " : " + note.Value + " / 10");
                }
            }
            
            AfficherProfesseurPrincipal();
        }
    }

    class Etudiant : Personne 
    {
        protected string infoEtude;
        public Personne professeurPrincipal { get; init; }

        public Etudiant(string nom_param, int age_param, string infoEtude_param) : base(nom_param, age_param, "Etudiant")
        {
            this.infoEtude = infoEtude_param;
        }
        public override void Afficher()
        {
            AfficherNomEtAge();
            Console.WriteLine(" Etudiant en " + infoEtude);
            AfficherProfesseurPrincipal();
        }

        protected void AfficherProfesseurPrincipal()
        {
            if (professeurPrincipal != null)
            {
                Console.WriteLine("Le professeur principal est : ");
                professeurPrincipal.Afficher();
            }
            else
            {
                Console.WriteLine(" Aucun professeur principal spécifié");
            }
        }
    }

    class Personne : IAffichable
    {
        static int nombreDePersonne = 0;

        public string nom {  get; init; }
        public int age { get; init; }

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

    class TableMultiplication : IAffichable
    {
        int numero;

        public TableMultiplication(int numero)
        {
            this.numero = numero;
        }

        public void Afficher()
        {
            Console.WriteLine("Table de multiplication de " + numero);
            for (int i = 1; i <=10; i++)
            {
                Console.WriteLine(i + " x " + numero + " = " + (i * numero));
            }
        }
    }

    interface IAffichable
    {
        void Afficher()
        {
            throw new NotImplementedException();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var elements = new List<IAffichable>()
            {
                new Personne("Paul", 30, "Développeur"),
                new Personne("Jacques", 35, "Professeur"),
                new Etudiant("David", 20, "Etudiant"),
                new Enfant("Juliette", 8, "CP", null),
                new TableMultiplication(2)
            };

            //********************
            //**** Where & is ****
            //********************
            //personnes = personnes.OrderBy(p => p.nom).ToList();
            //personnes = personnes.Where(p => p.age >= 25).ToList();
            //personnes = personnes.Where(p => p is Etudiant).ToList();
            //personnes = personnes.Where(p => (p.nom[0] == 'J')&&(p.age >= 25)).ToList();
            foreach (var element in elements)
            {
                element.Afficher();
                //Personne.AfficherNombreDePersonne();
            }

            Console.WriteLine();

            //var table = new TableMultiplication(2);
            //table.Afficher();

            //------------------------------------------------------------------------

            //var personne1 = new Personne { nom = "Paul", age = 20, emploi = "ingénieur" };
            //var personne2 = new Personne { nom = "Jacques", age = 35};

            //var personne1 = new Personne("Paul", 35, "Professeur");

            /*var etudiant = new Etudiant("David", 20, "école d'ingénieur informatique") { professeurPrincipal = new Personne("Paul", 35, "Professeur") };
            etudiant.Afficher();

            Console.WriteLine();

            var NoteMoyenne = new Dictionary<string, float> {
                { "Maths", 5f },{ "Geo", 8.5f },{"Dictée", 3.3f}
            };

            var enfant = new Enfant("Sophie", 8, "CP", null)
            {
                professeurPrincipal = new Personne("Jean", 35, "Professeur des écoles")
            };
            enfant.Afficher();*/

        }
    }
}