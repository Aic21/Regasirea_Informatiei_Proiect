namespace Regasirea_Informatiei_Lab.Models
{
    public class Review
    {
        public int ReviewId { get; set; }
        public string ReviewMessage { get; set; }
        public int UserId { get; set; }
        public virtual User User  { get; set; }
    }
}
