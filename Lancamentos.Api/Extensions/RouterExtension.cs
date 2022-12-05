using Lancamentos.Application.Lancamento.Command.Criar;
using Lancamentos.Contracts.Lancamento.Debito.Requests;
using Lancamentos.Api.Debito.Mapper;
using System.Net;
using Lancamentos.Contracts.Lancamento.Credito.Requests;

namespace Lancamentos.Api.Extensions;

public static class RouterExtension
{
    public static WebApplication MapLancamentosRouter(this WebApplication app)
    {
        app.MapGet("v1/lancamentos/is-alive", () =>
        {
            return true;
        }).WithName("ApiRespondendo").WithOpenApi();

        app.MapPost("v1/lancamentos/debito", (CriarDebitoRequest request, ICriarCommand command) =>
        {
            var result = command.CriarDebito(Mapper.RequestParaCommand(request));

            if (result.StatusCode == (int)HttpStatusCode.BadRequest)
                return Results.BadRequest(result);

            return Results.Ok(result.Data);

        }).WithName("CriarLancamentosDebito").WithOpenApi();

        app.MapPost("v1/lancamentos/credito", (CriarCreditoRequest request, ICriarCommand command) =>
        {
            var result = command.CriarCredito(Mapper.RequestParaCommand(request));

            if (result.StatusCode == (int)HttpStatusCode.BadRequest)
                return Results.BadRequest(result);

            return Results.Ok(result.Data);

        }).WithName("CriarLancamentosCredito").WithOpenApi();

        return app;
    }
}