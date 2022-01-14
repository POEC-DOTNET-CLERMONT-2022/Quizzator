using System;
using System.Collections.Generic;
using System.Text;

namespace Quizzator.Quizzator.Dtos
{
    internal class UserDtos
    {
        private int _UserId { get; set; }
        private string _Username { get; set; }
        private string _PasswordSalted { get; set; }
        private string _Email { get; set; }
    }
}
