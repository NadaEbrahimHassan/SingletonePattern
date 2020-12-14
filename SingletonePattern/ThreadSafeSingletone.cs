using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonePattern
{
   public class ThreadSafeSingletone
    {

        private static ThreadSafeSingletone _instance=null;
        private static readonly object padlock = new object();
        private ThreadSafeSingletone()
        {

        }

        public static ThreadSafeSingletone Instance
        {
            get
            {
               if(_instance== null)
                {
                    lock (padlock)
                    {
                        if (_instance == null)
                            _instance= new ThreadSafeSingletone();
                    }
                }

                return _instance;
            }
        }
    }
}
