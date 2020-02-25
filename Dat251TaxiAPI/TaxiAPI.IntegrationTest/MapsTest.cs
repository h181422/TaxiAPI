using System;
using System.Threading.Tasks;
using Domain;
using Xunit;

namespace TaxiAPI.IntegrationTest
{
    public class MapsTests
    {
        private readonly IMaps _maps;
        
        public MapsTests()
        {
            _maps = new Maps();
        }
        
        [Fact]
        public async Task GetTest_returnsYey()
        {
            Assert.True((await _maps.GetTest()) == "yey");
        }
        
        [Fact]
        public async Task GetFagOgGruppeNummer_returnsFagOgGruppenummerAsString()
        {
            Assert.True((await _maps.GetFagOgGruppeNummer()) == "Dat251 Gruppe 1");
        }
    }
}