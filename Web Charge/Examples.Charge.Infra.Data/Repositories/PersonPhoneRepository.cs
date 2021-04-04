using Examples.Charge.Domain.Aggregates.PersonAggregate;
using Examples.Charge.Domain.Aggregates.PersonAggregate.Interfaces;
using Examples.Charge.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Examples.Charge.Infra.Data.Repositories
{
    public class PersonPhoneRepository : IPersonPhoneRepository
    {
        private readonly ExampleContext _context;

        public PersonPhoneRepository(ExampleContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<IEnumerable<PersonPhone>> FindAllAsync() => await Task.Run(() => _context.PersonPhone);

        public async Task Update(PersonPhone phoneNumber) => await Task.Run(() =>
            _context.PersonPhone.Update(phoneNumber));

        public async Task Inserir(PersonPhone phoneNumber) => await Task.Run(() =>
                     _context.PersonPhone.Add(phoneNumber));

        public async Task Remover(PersonPhone phoneNumber) => await Task.Run(() =>
             _context.PersonPhone.Remove(phoneNumber));

        public async Task<PersonPhone> Obter(int id) => await Task.Run(() =>
             _context.PersonPhone.Find(id));
    }
}
