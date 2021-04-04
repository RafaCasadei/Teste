using AutoMapper;
using Examples.Charge.Application.Interfaces;
using Examples.Charge.Application.Messages.Request;
using Examples.Charge.Domain.Aggregates.PersonAggregate.Interfaces;
using System.Threading.Tasks;

namespace Examples.Charge.Application.Facade
{
    public class PhoneFacade : IPhoneFacade
    {
        private readonly IPersonPhoneService _phoneNumberService;
        private readonly IPhoneNumberTypeRepository _phoneNumberTypeRepository;
        private readonly IMapper _mapper;

        public PhoneFacade(IPersonPhoneService phoneNumberService, IMapper mapper)
        {
            _phoneNumberService = phoneNumberService;
            _mapper = mapper;
        }

        public async Task Alterar(int id, PersonPhoneInputRequest request)
        {
            var phoneType = await _phoneNumberTypeRepository.Find(request.PhoneNumberType);
            await _phoneNumberService.Alterar(new Domain.Aggregates.PersonAggregate.PersonPhone
            {
                PhoneNumber = request.PhoneNumber,
                PhoneNumberType = phoneType
            });
        }

        public async Task Salvar(PersonPhoneInputRequest request)
        {
            var phoneType = await _phoneNumberTypeRepository.Find(request.PhoneNumberType);
            await _phoneNumberService.Alterar(new Domain.Aggregates.PersonAggregate.PersonPhone
            {
                PhoneNumber = request.PhoneNumber,
                PhoneNumberType = phoneType
            });
        }

        public async Task Remover(int id)
        {
            await _phoneNumberService.Remover(id);
        }
    }
}
