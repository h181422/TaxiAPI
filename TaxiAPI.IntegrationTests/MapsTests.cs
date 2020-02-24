using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Domain;
using NUnit.Framework;

namespace TaxiAPI.IntegrationTests
{
    public class MapsTests
    {
        private IMaps _maps;
        public MapsTests()
        {
            _maps = container.Resolve<IMaps>();
        }
        
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task GetTest_ReturnsYey()
        {
            Assert.True((await _maps.GetTest()) == "yey");
        }
    }
}