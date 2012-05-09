using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using arti.Models;

namespace arti.Queries
{
    public static class ArtifactQueries
    {
        public static Artifact FindById(this IQueryable<Artifact> artifacts, string id) {
            return artifacts.SingleOrDefault(a => a.id == id);
        }

        public static IEnumerable<Artifact> GetRecent(this IQueryable<Artifact> artifacts, int start = 0, int stop = 7)
        {
            start++;
            stop++;
            return artifacts.OrderByDescending(a => a.timestamp).Skip(start - 1).Take(stop - start + 1).ToList();
        }

        public static IEnumerable<Artifact> GetPopular(this IQueryable<Artifact> artifacts, int start = 0, int stop = 7)
        {
            start++;
            stop++;
            return artifacts.OrderByDescending(a => a.views).Skip(start - 1).Take(stop - start + 1).ToList();
        }

        public static IEnumerable<Artifact> GetFeatured(this IQueryable<Artifact> artifacts, int start = 0, int stop = 7)
        {
            start++;
            stop++;
            return artifacts.Where(a => a.featured == true).OrderBy(a => a.timestamp).Skip(start - 1).Take(stop - start + 1).ToList();
        }


        public static IEnumerable<Artifact> GetFavorites(this IQueryable<Artifact> artifacts, int start = 0, int stop = 7)
        {
            start++;
            stop++;
            return artifacts.OrderByDescending(a => a.stars).Skip(start - 1).Take(stop - start + 1).ToList();
        }
    }
}