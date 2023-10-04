using MediatR;

namespace api.Features.Commands.InserirNovoCurso
{
    public class InserirNovoCursoCommand : IRequest
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Coordenador { get; set; }
        public int CargaHoraria { get; set; }
    }
}
