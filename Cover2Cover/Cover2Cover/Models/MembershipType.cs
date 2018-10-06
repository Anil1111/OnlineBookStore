namespace Cover2Cover.Models
{
    public class MembershipType
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int DurationInMonths { get; set; }
        public int DiscountRate { get; set; }
        public int SignupFee { get; set; }
    }
}