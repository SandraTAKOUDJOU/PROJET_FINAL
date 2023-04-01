namespace Projet.Models
{
    public class Pays
    {
        public int Id { get; set; }
        public string nom { get; set; }

        public string continent { get; set; }

        public ICollection<Population> population { get; set; }

        //Test

    }
}
