﻿using System;

namespace SingletonPattern
{
    public class SingletonTester
    {
        public static bool IsSingleton(Func<object> func)
        {
            var obj1 = func();
            var obj2 = func();

            return obj1 == obj2;
        }
    }
}
