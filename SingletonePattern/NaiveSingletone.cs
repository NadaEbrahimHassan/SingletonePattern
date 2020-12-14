using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonePattern
{
   public  class NaiveSingletone
    {
        private static NaiveSingletone _instance;
        private NaiveSingletone()
        {

        }

        public static NaiveSingletone Instance
        {
            get
            {
                return _instance ??= new NaiveSingletone();
            }
        }
    }
}
