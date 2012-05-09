using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using arti.Models;

namespace arti.Queries
{
    public static class MemberQueries
    {
        public static IEnumerable<TeamMember> GetRandom(this IQueryable<TeamMember> members)
        {
            return members.OrderBy(m => m.Name).ToList();
        }
    }
}