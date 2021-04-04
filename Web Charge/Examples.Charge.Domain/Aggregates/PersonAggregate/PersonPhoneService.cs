using Examples.Charge.Domain.Aggregates.PersonAggregate.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examples.Charge.Domain.Aggregates.PersonAggregate
{
    public class PersonPhoneService : IPersonPhoneService
    {
        private readonly IPersonPhoneRepository _personPhoneRepository;
        public PersonPhoneService(IPersonPhoneRepository personPhoneRepository)
        {
            _personPhoneRepository = personPhoneRepository;
        }

        public async Task<List<PersonPhone>> FindAllAsync() => (await _personPhoneRepository.FindAllAsync()).ToList();

        public async Task Alterar(PersonPhone personPhone)
        {
            await _personPhoneRepository.Update(personPhone);
        }

        public async Task Inserir(PersonPhone personPhone)
        {
            await _personPhoneRepository.Inserir(personPhone);
        }

        public async Task Remover(int id)
        {
            var personPhone = await _personPhoneRepository.Obter(id);
            await _personPhoneRepository.Remover(personPhone);
        }
    }
}
