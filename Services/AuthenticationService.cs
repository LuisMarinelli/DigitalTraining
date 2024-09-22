using DigitalTraining.Interfaces;

namespace DigitalTraining.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        // Implementar a lógica de autenticação aqui
        public bool Authenticate(string email, string password)
        {
            // Aqui vai a lógica de validação do usuário
            return true; // Temporário para o exemplo
        }
    }

}
