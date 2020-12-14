using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonePattern
{
   public class LazySingletone
    {
        private static Lazy<LazySingletone> _lazyInstance = new Lazy<LazySingletone>(() => new LazySingletone());

        private LazySingletone()
        {

        }

        public static LazySingletone Instance
        {
            get => _lazyInstance.Value;
        }
    }
}
