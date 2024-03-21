using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module16.UserTicketService
{
    public interface IUserRepository
    {
        IEnumerable<User> FindAll();
    }

    public class UserRepository
    {
        public IEnumerable<User> FindAll()
        {
            return null;
        }
    }

    public class User
    {
        public string Name { get; set; }
    }
}
