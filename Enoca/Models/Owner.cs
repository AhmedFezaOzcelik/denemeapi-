namespace Enoca.Models
{
    public class Owner
    {
        public int Id { get; set; }

        public  string FirstName { get; set; }

        public string LastName { get; set; }



        public string Gym { get; set; }

        //Birebir ilişki:Her Owner (sahip) in bir Country si (ülkesi) olur.
        public Country Country { get; set; }

        public ICollection<Pokemon_Owner> Pokemon_Owners { get; set; }
    }
}
