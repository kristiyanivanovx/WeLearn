using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

using WeLearn.Data.Models.LessonModule;

namespace WeLearn.Tests.HelperClasses
{
    internal class TestingDbAsyncEnumerator<T> : IAsyncEnumerator<T>
    {
        private readonly IEnumerator<T> inner;
        private IEnumerator<Lesson> enumerator;

        public TestingDbAsyncEnumerator(IEnumerator<T> inner)
        {
            this.inner = inner;
        }

        public TestingDbAsyncEnumerator(IEnumerator<Lesson> enumerator)
        {
            this.enumerator = enumerator;
        }

        public T Current => this.inner.Current;

        public void Dispose()
        {
            this.inner.Dispose();
        }

        public Task<bool> MoveNextAsync(CancellationToken cancellationToken)
        {
            return Task.FromResult(this.inner.MoveNext());
        }

        public ValueTask<bool> MoveNextAsync()
        {
            return ValueTask.FromResult(this.inner.MoveNext());
        }

        public ValueTask DisposeAsync()
        {
            this.Dispose();
            return ValueTask.CompletedTask;
        }
    }
}
