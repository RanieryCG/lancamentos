namespace Lancamentos.Contracts.Lancamento.Debito.Requests;

public record CriarDebitoRequest(string Descricao, double Valor, DateTime Data, Guid IdUsuario);