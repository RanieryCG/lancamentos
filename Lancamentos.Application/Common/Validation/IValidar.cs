namespace Lancamentos.Application.Common.Validation;

public interface IValidar
{
    void Validar();

    void AdicionarErro(string erro);
}
