using Microsoft.AspNetCore.Identity;
using Microsoft.Identity.Client;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using WebPhim.Data;
using WebPhim.Models;
using WebPhim.Repositories.Interfaces;
using WebPhim.Services;


namespace WebPhim.Repositories
{
    public class UserRepository : IUserRepository
    {

        private readonly WebPhimDbContext _context;

        private readonly PasswordHasher<User> _passwordHasher;

        //Generated Id
        private readonly IdGeneratorService _idGenerator = new IdGeneratorService();
        public UserRepository(WebPhimDbContext context)
        {
            _context = context;
            _passwordHasher = new PasswordHasher<User>();
        }
        public bool CheckPassword(User user, string password)
        {
            //Ktra mat khau:
            var result = _passwordHasher.VerifyHashedPassword(user, user.PasswordHash, password);
            return result == PasswordVerificationResult.Success;
        }

        public User GetById(string userID)
        {
            var user = _context.Users.FirstOrDefault(x => x.UserID == userID);
            if (user == null)
            {
                throw new Exception("User not found");

            }
            return user;

        }

        public User GetUserByEmail(string email)
        {
            var user = _context.Users.FirstOrDefault(x =>x.Email == email);
            if (user == null)
            {
               
            }
            return user;
        }

        public void Register(User user, string password)
        {
            user.UserID = _idGenerator.GenerateId("U", 7);
            user.PasswordHash = _passwordHasher.HashPassword(user, password);
            user.CreatedAt = DateTime.Now;
            user.Status = "Active";
            user.IsVerified = false;
            user.Role = "User";

            
            _context.Users.Add(user);
            _context.SaveChanges();
        }




    }
}
