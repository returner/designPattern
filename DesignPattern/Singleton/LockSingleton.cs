using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    /// <summary>
    /// 성능 문제가 생길 가능성이 있음
    /// </summary>
    public sealed class LockSingleton
    {
        private static LockSingleton? _instance = null;
        private static readonly object padlock = new object();

        LockSingleton()
        {

        }

        public static LockSingleton Instance
        {
            get
            {
                lock (padlock)
                {
                    if (_instance == null)
                    {
                        _instance = new LockSingleton();
                    }

                    return _instance;
                }
            }
        }

        public async Task GetMethodAsync()
        {
            await Task.CompletedTask;
        }
    }
}
