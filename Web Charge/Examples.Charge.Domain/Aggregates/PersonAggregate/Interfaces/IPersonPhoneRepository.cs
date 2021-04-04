using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Examples.Charge.Domain.Aggregates.PersonAggregate.Interfaces
{
    public interface IPersonPhoneRepository
    {
        Task<IEnumerable<PersonAggregate.PersonPhone>> FindAllAsync();
        Task Update(PersonPhone phoneNumber);
        Task Inserir(PersonPhone phoneNumber);
        Task Remover(PersonPhone phoneNumber);
        Task<PersonPhone> Obter(int id);
    }
}
