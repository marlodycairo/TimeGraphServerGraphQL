using HotChocolate;
using System.Linq;
using TimeGraphServerGraphQL.Database;
using TimeGraphServerGraphQL.Models;

namespace TimeGraphServerGraphQL.GraphQL
{
    public class Query
    {
        //private readonly TimeGraphContext dbContext;

        //public Query(TimeGraphContext dbContext)
        //public IQueryable<Project> GetProjects([Service(ServiceKind.Synchronized)] TimeGraphContext dbcontext)
        public IQueryable<Project> GetProjects(TimeGraphContext dbcontext)
        {
            return dbcontext.Projects;
        }

        //public IQueryable<TimeLog> GetTimeLogs([Service(ServiceKind.Synchronized)] TimeGraphContext dbcontext)
        public IQueryable<TimeLog> GetTimeLogs(TimeGraphContext dbcontext)
        {
            return dbcontext.TimeLogs;
        }

        //public IQueryable<Project> Projects => dbContext.Projects;
        //public IQueryable<TimeLog> TimeLogs => dbContext.TimeLogs;
    }
}
