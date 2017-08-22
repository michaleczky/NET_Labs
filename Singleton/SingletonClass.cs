using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    // Singleton pattern implementation using Lazy instantiation and private constructor
    class SingletonClass
    {
        private static readonly Lazy<SingletonClass> _instance = new Lazy<SingletonClass>(() => new SingletonClass());
        public static int counter = 0;

        private SingletonClass()
        {
            // private contstructor avoids direct instantiation of the SingletonClass
            counter++;
        }

        public static SingletonClass getInstance()
        {
            return _instance.Value;
        }

    }
}
