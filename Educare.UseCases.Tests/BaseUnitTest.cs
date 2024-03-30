using System.Net.Security;
using AutoFixture;

namespace Educare.UseCases.Tests
{
    public class BaseUnitTest()
    {
        protected Fixture _fixture => new Fixture();
    }
}