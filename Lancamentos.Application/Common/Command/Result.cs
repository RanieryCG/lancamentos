using System.Collections.Generic;

namespace Lancamentos.Application.Common.Command;
public class Result<T> where T : class
{
    private readonly List<string> _erros = new List<string>();

    public Result(int statusCode, IReadOnlyCollection<string> erros, T? data)
    {
        StatusCode = statusCode;
        Data = data;
        _erros = erros.ToList();
    }

    public IReadOnlyCollection<string> Erros => _erros;
    public int StatusCode { get; private set; }
    public T? Data { get; private set; }
}
