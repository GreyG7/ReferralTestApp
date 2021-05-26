namespace DataAccessLibrary.Models
{
    public interface IPersonModel
    {
        string EmailAddress { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }
}