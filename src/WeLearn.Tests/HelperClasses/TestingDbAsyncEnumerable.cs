using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;

namespace WeLearn.Tests.HelperClasses
{
    internal class TestingDbAsyncEnumerable<T> : EnumerableQuery<T>, IAsyncEnumerable<T>, IQueryable<T>
    {
        public TestingDbAsyncEnumerable(IEnumerable<T> enumerable)
            : base(enumerable)
        { }

        public TestingDbAsyncEnumerable(Expression expression)
            : base(expression)
        { }

        public IAsyncEnumerator<T> GetAsyncEnumerator(CancellationToken cancellationToken = default)
        {
            return new TestingDbAsyncEnumerator<T>(this.AsEnumerable().GetEnumerator());
        }

        IQueryProvider IQueryable.Provider
        {
            get { return new TestingDbAsyncQueryProvider<T>(this); }
        }
    }
}
