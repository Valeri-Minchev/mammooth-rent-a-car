using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mammooth.Domain.DTOs
{
    public class UserUpdateModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CitizenId { get; set; }
        public string PhoneNumber { get; set; }
        public string UserName { get; set; }
        public string NormalizedUserName { get; set; }
        public string Email { get; set; }
        public string NormalizedEmail { get; set; }

    }
}