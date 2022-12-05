using Lancamentos.Application.Common.Validation;

namespace Lancamentos.Application.Lancamento.Command.Criar;
public record CriarCommand(string Descricao, double Valor, DateTime Data, Guid IdUsuario) : Validation
{
    public override void Validar()
    {
        if (string.IsNullOrEmpty(Descricao))
            AdicionarErro("O campo descrição não pode ser nulo ou vazio");

        if (Valor <= 0)
            AdicionarErro("O campo Valor deve ser maior que zero");


        if (Data.ToUniversalTime().Date < DateTime.UtcNow.Date)
            AdicionarErro("O campo Data deve ser maior ou igual a hoje");

        if (IdUsuario == Guid.Empty)
            AdicionarErro("O cmapo Id Usuairo deve conter um valor Guid válido");
    }
}
