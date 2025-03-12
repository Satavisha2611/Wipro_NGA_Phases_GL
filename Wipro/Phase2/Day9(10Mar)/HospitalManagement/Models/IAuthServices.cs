namespace HospitalManagement.Models
{
    public interface IAuthServices
    {
        Task<string> Authenticate(string username, string password);
    }
}
