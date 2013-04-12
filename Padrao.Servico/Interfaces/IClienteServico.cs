using System.Collections.Generic;
using Padrao.Dominio.Entidades;
using Padrao.Servico.Base.Interfaces;

namespace Padrao.Servico.Interfaces
{
    public interface IClienteServico : IBaseServico<Cliente>
    {
        IEnumerable<Cliente> Listar();
    }
}