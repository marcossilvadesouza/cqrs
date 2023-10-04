using api.Features.Commands.InserirNovoCurso;
using api.Features.Querys.ListarTodosCursos;
using infra.Context;
using MediatR;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var appConnectionString = builder.Configuration.GetConnectionString("CrqrsDbConnection");

builder.Services.AddDbContext<CqrsContext>(o =>
    o.UseSqlServer(appConnectionString)
);

builder.Services.AddMediatR(cfg =>
{
    cfg.RegisterServicesFromAssembly(typeof(Program).Assembly);
});

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapPost("/inserir-curso", async (IMediator mediator, InserirNovoCursoCommand request) =>
{
    mediator.Send(request);
});

app.MapGet("/listar-cursos", async (IMediator mediator) =>
{
    var result = await mediator.Send(new ListarTodosCursosQuery());
    return Results.Ok(result);
});

app.Run();
