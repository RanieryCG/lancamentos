using Lancamentos.Domain.Enums;

namespace Lancamentos.Domain.Entidades
{
    public class LancamentoEntidade : Entidade
    {
        public LancamentoEntidade(double valor, string descricao, DateTime data, TipoLancamentoEnum tipo)
        {
            Valor = valor;
            Descricao = descricao;
            Data = data;
            Tipo = tipo;
        }

        public double Valor { get; private set; }
        public string Descricao { get; private set; }
        public DateTime Data { get; private set; }
        public TipoLancamentoEnum Tipo { get; private set; }
    }
}
