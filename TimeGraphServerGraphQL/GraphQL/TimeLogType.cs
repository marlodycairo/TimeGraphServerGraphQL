using HotChocolate.Types;
using TimeGraphServerGraphQL.Models;

namespace TimeGraphServerGraphQL.GraphQL
{
    public class TimeLogType : ObjectType<TimeLog>
    {
        protected override void Configure(IObjectTypeDescriptor<TimeLog> descriptor)
        {
            //descriptor.Authorize();
        }
    }
}
