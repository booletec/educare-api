using Educare.Core.Repositories;
using Educare.Core.School.Entities;

namespace Educare.Application.StudentUseCases
{
    public class RegisterStudentUseCase(IStudentRepository studentRepository)
    {
        private readonly IStudentRepository _studentRepository = studentRepository;

        public async Task<Guid> ProcessAsync(Aluno aluno)
        {
            throw new NotImplementedException();
        } 
    }
}
