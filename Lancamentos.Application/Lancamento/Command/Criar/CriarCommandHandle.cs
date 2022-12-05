using Lancamentos.Application.Common.Command;
using Lancamentos.Application.Common.Persistence;
using Lancamentos.Application.Lancamento.Mapper;
using Lancamentos.Domain.Entidades;
using System.Net;

namespace Lancamentos.Application.Lancamento.Command.Criar;

public class CriarCommandHandle : ICriarCommand
{
    private readonly ILancamentoRepositorio _repositorio;

    public CriarCommandHandle(ILancamentoRepositorio repositorio)
    {
        _repositorio = repositorio;
    }

    public Result<CriarCommandResult> CriarCredito(CriarCommand command)
    {
        //Validar se o command é válido
        command.Validar();

        if (!command.Valido)
            return new Result<CriarCommandResult>(statusCode: (int)HttpStatusCode.BadRequest, erros: command.Erros, null);

        //Mapear para a camada de domínio
        LancamentoEntidade lancamentoEntidade = MapperApplication.CommandCreditoParaEntidade(command);

        //Salvar no banco de dados
        _repositorio.Criar(lancamentoEntidade);

        //Retornar o result
        return new Result<CriarCommandResult>(statusCode: (int)HttpStatusCode.OK, erros: command.Erros, new CriarCommandResult(command, lancamentoEntidade));
    }

    public Result<CriarCommandResult> CriarDebito(CriarCommand command)
    {
        //Validar se o command é válido
        command.Validar();

        if (!command.Valido)
            return new Result<CriarCommandResult>(statusCode: (int)HttpStatusCode.BadRequest, erros: command.Erros, null);

        //Mapear para a camada de domínio
        LancamentoEntidade lancamentoEntidade = MapperApplication.CommandDebitoParaEntidade(command);

        //Salvar no banco de dados
        _repositorio.Criar(lancamentoEntidade);
        
        //Retornar o result
        return new Result<CriarCommandResult>(statusCode: (int)HttpStatusCode.OK, erros: command.Erros, new CriarCommandResult(command, lancamentoEntidade));


    }
}
