using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProteinTracker4.Api
{
    public class UserService : Service
    {
        public object Post(AddUser request)
        {
            //Add user
            return new AddUserResponse { UserId = 10 };
        }
    }

    public class AddUserResponse
    {
        public long UserId { get; set; }
    }

    [Route("/users", "POST")]
    public class AddUser
    {
        public string Name { get; set; }
        public int Goal { get; set; }
    }
}