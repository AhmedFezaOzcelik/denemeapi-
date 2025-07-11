namespace Enoca.Models
{
    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Pokemon_Category> Pokemon_Categories { get; set; }
    }
}
