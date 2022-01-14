using System;
using System.Security.Cryptography;
using System.Text;

namespace Quizzator.Quizzator.Models
{
    internal class User
    {
        #region Init
        private Guid _UserId { get; set; }
        private string _Username { get; set; }
        private string _Salt;
        private string _PasswordSalted { get; set; }
        private string _Email { get; set; }

        public User(string Username, string Password, string Email)
        {
            _UserId = new Guid();
            _Username = Username;
            setSalt(GenerateSalt());
            _PasswordSalted = ComputeHash(Encoding.UTF8.GetBytes(Password), Encoding.UTF8.GetBytes(getSalt()));
            _Email = Email;
        }
        public User(Guid UserId, string Username, string Password, string Email):this(Username, Password, Email)
        {
            _UserId= UserId;
        }
        #endregion
        #region Getter & Setter

        #region Password
        internal bool MatchPassword(string Password)
        {
            if (ComputeHash(Encoding.UTF8.GetBytes(Password), Encoding.UTF8.GetBytes(getSalt())) == _PasswordSalted)
                return true;
            return false;
        }
        internal string ComputeHash(byte[] bytesToHash, byte[] salt)
        {
            var byteResult = new Rfc2898DeriveBytes(bytesToHash, salt, 10000);
            return Convert.ToBase64String(byteResult.GetBytes(24));
        }
        internal string GenerateSalt()
        {
            var bytes = new byte[128 / 8];
            var rng = new RNGCryptoServiceProvider();
            rng.GetBytes(bytes);
            return Convert.ToBase64String(bytes);
        }
        #endregion
        private string getSalt() { return _Salt; }
        private void setSalt(string value) { _Salt = value; }
        
        #endregion
    }
}
