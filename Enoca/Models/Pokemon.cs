namespace Enoca.Models
{
    public class Pokemon
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public DateTime Birthdate { get; set; }

        //Bire - Çok İlişki:Bir Pokemon un birden fazla Review i olabilir.
        public ICollection<Review> Reviews { get; set; }

        public ICollection<Pokemon_Owner> Pokemon_Owners { get; set; }
        public ICollection<Pokemon_Category> Pokemon_Categories { get; set; }
    }
}
