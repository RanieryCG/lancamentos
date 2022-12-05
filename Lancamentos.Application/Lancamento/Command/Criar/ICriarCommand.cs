using Lancamentos.Application.Common.Command;

namespace Lancamentos.Application.Lancamento.Command.Criar;

public interface ICriarCommand
{
    public Result<CriarCommandResult> CriarDebito(CriarCommand command);
    public Result<CriarCommandResult> CriarCredito(CriarCommand command);
}
