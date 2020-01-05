using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interview;
using NUnit.Framework;

namespace InterviewTests
{
    [TestFixture]
    public class RepositoryTests
    {
        [Test]
        public void storable_Test
        {
            Ire
        }

        /*
        More tests
        */

        private IRepository<T,I> CreateRepository()
        {
            Storable<int> id = new Storable<int>{Id = 1};
            return new Repository<string, Storable<int>>();
        }
    }
}
