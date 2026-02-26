using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Ecommerce.App.Athentication.Dtos
{
    public class UserDto
    {
        public string Id { get; set; } 
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Name { get; set; }
        public bool IsEmailConfirmed { get; set; }
        public IList<string> Roles { get; set; }
    }
}
