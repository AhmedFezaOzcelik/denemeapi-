namespace Enoca.Models
{
    public class Review
    {
        public int Id { get; set; }

        public string Title { get; set; }
        public string Text { get; set; }
        
        //Birebir İlişki:Her Review in bir Reviewer i olur.
        public Reviewer Reviewer { get; set; }

        //Birebir İlişki:Her Review in bir Pokemon i olur.
        public Pokemon Pokemon { get; set; }

        public int Rating { get; set; }

    }
}
