using AutoFixture;
using Educare.Application.StudentUseCases;
using Educare.Core.Repositories;
using Educare.Core.School.Entities;
using FluentAssertions;
using NSubstitute;

namespace Educare.UseCases.Tests
{
    public class RegisterStudentTests : BaseUnitTest
    {
        private readonly IStudentRepository _studentRepository;
        private readonly RegisterStudentUseCase _sut;

        public RegisterStudentTests()
        {
            _studentRepository = Substitute.For<IStudentRepository>();
            _sut = Substitute.For<RegisterStudentUseCase>();
        }

        [Fact]
        public void ShouldRegisterStudent()
        {
            var student = _fixture.Build<Aluno>().Create();
            var expected = _sut.ProcessAsync(student);
            _studentRepository.Received(1).SaveAsync(student);

            expected.Id.Should().NotBe(null);
        }

       
    }
}
