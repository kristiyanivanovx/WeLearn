using System;

using Microsoft.EntityFrameworkCore;
using WeLearn.Data;

namespace WeLearn.Tests.Mocks
{
    public static class DatabaseMock
    {
        public static DatabaseContext Instance
        {
            get
            {
                var dbContextOptions = new DbContextOptionsBuilder<DatabaseContext>()
                    .UseInMemoryDatabase(Guid.NewGuid().ToString())
                    .Options;

                return new DatabaseContext(dbContextOptions);
            }
        }
    }
}
