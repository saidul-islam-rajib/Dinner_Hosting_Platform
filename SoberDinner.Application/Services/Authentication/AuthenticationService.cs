using SoberDinner.Application.Common.Interfaces.Authentication;

namespace SoberDinner.Application.Services.Authentication
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IJwtTokenGenerator _jwtTokenGenerator;

        public AuthenticationService(IJwtTokenGenerator jwtTokenGenerator)
        {
            _jwtTokenGenerator = jwtTokenGenerator;
        }

        public AuthenticationResult Login(string email, string password)
        {
            

            return new AuthenticationResult(Guid.NewGuid(), "FIRST NAME", "LAST NAME", email, "HARD CODED TOKEN");
        }

        public AuthenticationResult Register(string firstName, string lastName, string email, string password)
        {
            // 1. Check if user already exits

            // 2. Create user (Generate unique ID)

            // 3. Create JWT Token
            Guid userId = Guid.NewGuid();
            var token = _jwtTokenGenerator.GenerateToken(userId, firstName, lastName);
            return new AuthenticationResult(
                userId,
                firstName,
                lastName,
                email,
                token);
        }
    }
}
