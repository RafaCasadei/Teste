using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Examples.Charge.Domain.Aggregates.PersonAggregate.Interfaces
{
    public interface IPersonPhoneService
    {
        Task Alterar(PersonPhone personPhone);
        Task Inserir(PersonPhone personPhone);
        Task Remover(int id);
    }
}
