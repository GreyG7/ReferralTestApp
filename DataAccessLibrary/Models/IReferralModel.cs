namespace DataAccessLibrary.Models
{
    public interface IReferralModel
    {
        string Category { get; set; }
        string Company { get; set; }
        // byte[] Image { get; set; }
        int Id { get; set; }
        string Instructions { get; set; }
        string Referral { get; set; }
        string Website { get; set; }
    }
}