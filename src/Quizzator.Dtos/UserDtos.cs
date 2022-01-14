using System;


namespace Quizzator.Quizzator.Dtos
{
    internal class UserDtos
    {
        private Guid _UserId { get; set; }
        private string _Username { get; set; }
        private string _Salt { get; set; }
        private string _PasswordSalted { get; set; }
        private string _Email { get; set; }
    }
}
