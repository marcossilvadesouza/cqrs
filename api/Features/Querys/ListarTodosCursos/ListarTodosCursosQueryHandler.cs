using core.Entity;
using infra.Context;
using MediatR;

namespace api.Features.Querys.ListarTodosCursos
{
    public class ListarTodosCursosQueryHandler : IRequestHandler<ListarTodosCursosQuery, List<Curso>>
    {
        private readonly CqrsContext _crqsContext;

        public ListarTodosCursosQueryHandler(CqrsContext cqrsContext)
        {
            _crqsContext = cqrsContext;
        }

        public async Task<List<Curso>> Handle(ListarTodosCursosQuery request, CancellationToken cancellationToken)
        {
            return _crqsContext.Curso.ToList();
        }
    }
}
