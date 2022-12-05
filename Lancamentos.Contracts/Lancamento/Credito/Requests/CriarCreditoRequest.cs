namespace Lancamentos.Contracts.Lancamento.Credito.Requests;

public record CriarCreditoRequest(string Descricao, double Valor, DateTime Data, Guid IdUsuario);
