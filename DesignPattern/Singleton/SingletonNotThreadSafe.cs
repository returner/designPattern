using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Singleton
{
    public sealed class SingletonNotThreadSafe
    {
        private SingletonNotThreadSafe()
        {

        }

        private static SingletonNotThreadSafe? _instance = null;
        public static SingletonNotThreadSafe Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new SingletonNotThreadSafe();
                return _instance;
            }
        }

        public async Task GetMethodAsync()
        {
            await Task.CompletedTask;
        }
    }
}