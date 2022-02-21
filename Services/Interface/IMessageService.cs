using Models.DTO;
using System;
using System.Threading.Tasks;

namespace Services.Interface
{
    public interface IMessageService
    {
        Task<Tuple<bool, string>> SendMessage(MessageToAddDto model);
    }
}
