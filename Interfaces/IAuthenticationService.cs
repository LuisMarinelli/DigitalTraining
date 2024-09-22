namespace DigitalTraining.Interfaces
{
    public interface IAuthenticationService
    {
        bool Authenticate(string email, string password);
    }
}
