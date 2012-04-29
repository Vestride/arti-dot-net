using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using arti.Models;

namespace arti.Queries
{
    public static class UserQueries
    {
        public static User FindByUsername(this IQueryable<User> users, string username)
        {
            User user = null;
            try
            {
                user = users.Single(u => u.username == username);
            }
            catch (InvalidOperationException e)
            {
                // Username not found
            }
            return user;
        }
    }
}