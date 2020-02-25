using System;
using System.Threading.Tasks;

namespace Domain
{
    public class Maps : IMaps
    {
        public async Task<string> GetTest()
        {
            return "yey";
        }

        public async Task<string> GetFagOgGruppeNummer()
        {
            return "Dat251 Gruppe 1";
        }
    }
}