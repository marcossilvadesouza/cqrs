using core.Entity;
using infra.Context;
using MediatR;

namespace api.Features.Commands.InserirNovoCurso
{
    public class InserirNovoCursoCommandHandler : IRequestHandler<InserirNovoCursoCommand>
    {
        private readonly CqrsContext _crqsContext;

        public InserirNovoCursoCommandHandler(CqrsContext cqrsContext)
        {
            _crqsContext = cqrsContext;
        }

        public async Task Handle(InserirNovoCursoCommand request, CancellationToken cancellationToken)
        {
            var curso = new Curso
            {
                Id = request.Id,
                CargaHoraria = request.CargaHoraria,
                Coordenador = request.Coordenador,
                Nome = request.Nome                
            };

            _crqsContext.Add(curso);
            _crqsContext.SaveChanges();
        }
    }
}
