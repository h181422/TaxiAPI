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
    }
}