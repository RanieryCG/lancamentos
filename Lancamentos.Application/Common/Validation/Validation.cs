using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lancamentos.Application.Common.Validation;

public record Validation : IValidar
{
    private readonly List<string> _erros = new List<string>();
    public bool Valido => _erros.Any() == false;

    public IReadOnlyCollection<string> Erros => _erros;

    public void AdicionarErro(string erro)
    {
        _erros.Add(erro);
    }

    public virtual void Validar()
    {
        
    }
}
