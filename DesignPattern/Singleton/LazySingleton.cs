using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Singleton
{
    public sealed class LazySingleton
    {
        private LazySingleton()
        {

        }

        private static readonly Lazy<LazySingleton> _instance = new Lazy<LazySingleton>(() => new LazySingleton());
        public static LazySingleton Instance
        {
            get => _instance.Value;
        }

        public async Task GetMethodAsync()
        {
            await Task.CompletedTask;
        }
    }
}
