namespace Enoca.Models
{
    public class Reviewer
    {
        public  int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }
        
        //Bire - Çok İlişki:Bir Reviewer in birden fazla Review i olabilir.
        public ICollection<Review> Reviews { get; set; }

    }
}
