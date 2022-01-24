using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class StaticSingleton
    {
        private static readonly StaticSingleton _instance = new StaticSingleton();
        static StaticSingleton()
        {

        }
        
        private StaticSingleton()
        {

        }

        public static StaticSingleton Instance
        {
            get
            {
                return _instance;
            }
        }

        public async Task GetMethodAsync()
        {
            await Task.CompletedTask;
        }
    }
}
