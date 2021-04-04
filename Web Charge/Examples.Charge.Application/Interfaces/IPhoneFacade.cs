using Examples.Charge.Application.Messages.Request;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Examples.Charge.Application.Interfaces
{
    public interface IPhoneFacade
    {
        Task Alterar(int id, PersonPhoneInputRequest request);
        Task Salvar(PersonPhoneInputRequest request);
        Task Remover(int id);
    }
}
