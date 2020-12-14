using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonePattern
{
     public sealed class StaticConstratorSingletone
    {
        private static readonly StaticConstratorSingletone _instance;
        static StaticConstratorSingletone()
        {
            _instance= new StaticConstratorSingletone();
            Console.WriteLine("static ctr!");
        }
        private StaticConstratorSingletone()
        {
            Console.WriteLine("private ctr!");
        }

        public static StaticConstratorSingletone Instance
        {
            get => _instance;
        }
    }
}
