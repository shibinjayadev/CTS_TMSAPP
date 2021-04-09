using Microsoft.VisualStudio.TestTools.UnitTesting;
using TMSApp.Application;
using TMSApp.Infrastructure;
using TMSApp.Infrastructure.Repository;

namespace TMSTest
{
    [TestClass]
    public class TMSTest
    {

      //  private readonly ITMSQueryRepository _tmsRepository;

        //public TMSTest(ITMSQueryRepository tmsRepository)
        //{

        //    _tmsRepository = tmsRepository;

        //}

        

        [TestMethod]
        public void BIATestForProject()
        {
            TMSQueryRepository _tmsRepository = new TMSQueryRepository();



            await _tmsRepository.Get();

           
        }
    }
}
