using core.Entity;
using MediatR;

namespace api.Features.Querys.ListarTodosCursos
{
    public class ListarTodosCursosQuery : IRequest<List<Curso>>
    {
    }
}
