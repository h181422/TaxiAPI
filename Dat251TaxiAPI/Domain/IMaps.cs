using System;
using System.Threading.Tasks;

namespace Domain
{
    public interface IMaps
    {
        Task<string> GetTest();
        Task<string> GetFagOgGruppeNummer();
    }
}