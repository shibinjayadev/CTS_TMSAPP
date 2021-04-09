using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TMSApp.Application.DTO;
using TMSApp.Infrastructure.DataAccess;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace TMSApp.Infrastructure.Repository
{
    public class TMSQueryRepository : ITMSQueryRepository
    {

        private readonly DbHelper _dbhelpercontext;

        public TMSQueryRepository(DbHelper dbhelpercontext)
        {

            _dbhelpercontext = dbhelpercontext;
        }
        public async  Task<TMSDto> Create(TMSDto tms)
        {
            _dbhelpercontext.TMSDto.Add(tms);
            await _dbhelpercontext.SaveChangesAsync();
            //throw new NotImplementedException();
            return tms;
        }

        public async Task Delete(int id)
        {

            var tmstoDelete = await _dbhelpercontext.TMSDto.FindAsync(id);
            _dbhelpercontext.TMSDto.Remove(tmstoDelete);
            await _dbhelpercontext.SaveChangesAsync();

           // throw new NotImplementedException();
        }

        //public Task Delete(TMSDto tms)
        //{
        //    throw new NotImplementedException();
        //}

        public async Task<IEnumerable<TMSDto>> Get()
        {
            return await _dbhelpercontext.TMSDto.ToListAsync();
            //throw new NotImplementedException();
        }

        public async Task<TMSDto> Get(int id)
        {
            return await _dbhelpercontext.TMSDto.FindAsync(id);
            
            //throw new NotImplementedException();
        }

        public async Task Update(TMSDto tms)
        {
            _dbhelpercontext.Entry(tms).State=EntityState.Modified;
            await _dbhelpercontext.SaveChangesAsync();
        }



    }
}
