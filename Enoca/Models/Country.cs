namespace Enoca.Models
{
    public class Country
    {
        public int Id { get; set; }

        public  string Name { get; set; }
        //Bire - Çok ilişki :Bir Country nin birden fazla Owner ı olabilir.
        public ICollection<Owner> Owners { get; set; }
    }
}
