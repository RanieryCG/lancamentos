using Lancamentos.Domain.Entidades;

namespace Lancamentos.Application.Lancamento.Command.Criar;

public record CriarCommandResult : CriarCommand
{
    public Guid Id { get; private set; }
    public DateTime DataCriacao { get; private set; }

    public DateTime DataAtualizacao { get; private set; }

    public CriarCommandResult(CriarCommand command, LancamentoEntidade lancamentoEntidade) : base(command.Descricao, command.Valor, command.Data, command.IdUsuario)
    {
        Id = lancamentoEntidade.Id;
        DataCriacao = lancamentoEntidade.DataCriacao.ToLocalTime();
        DataAtualizacao = lancamentoEntidade.DataAtualizacao.ToLocalTime();
    }
}
