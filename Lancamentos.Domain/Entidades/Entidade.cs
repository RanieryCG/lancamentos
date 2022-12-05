namespace Lancamentos.Domain.Entidades;
public class Entidade
{
    public Guid Id { get; private set; } = Guid.NewGuid();  
    public DateTime DataCriacao { get; private set; } = DateTime.UtcNow;
    public DateTime DataAtualizacao { get; private set; } = DateTime.UtcNow;

    public void GerarId() => Id = Guid.NewGuid();
}
