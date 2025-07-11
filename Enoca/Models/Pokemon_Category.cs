namespace Enoca.Models
{
    public class Pokemon_Category
    {
        public  int PokemonId { get; set; }
        public int CategoryId { get; set; }

        public Pokemon Pokemon { get; set; }

        public Category Category { get; set; }
    }
}
