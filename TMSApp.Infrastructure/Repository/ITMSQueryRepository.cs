using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TMSApp.Application.DTO;
using System.Linq;

namespace TMSApp.Infrastructure.Repository
{
   public interface ITMSQueryRepository
    {
        Task<IEnumerable<TMSDto>> Get();
        Task<TMSDto> Get(int id);

        Task<TMSDto> Create(TMSDto tms);

        Task Update(TMSDto tms);

        Task Delete(int id);

    }
}
