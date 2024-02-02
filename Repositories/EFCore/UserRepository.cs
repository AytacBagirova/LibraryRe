using Entities;
using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EFCore
{
    public class UserRepository : RepositoryManager<User>, IUserRepository
    {
        public UserRepository(RepositoryContext context):base(context)
        {
        }
    }
}
