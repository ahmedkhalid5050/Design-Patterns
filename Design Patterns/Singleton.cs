using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns
{
    internal class Singleton
    {
        private static Singleton instance;
        private Singleton() { }

        public static Singleton GetSingleton()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }

    }
}
