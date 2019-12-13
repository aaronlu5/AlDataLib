using System;
using System.Collections.Generic;

namespace AlDataLib.DataGenerator
{
    public class RandomGen
    {
        private RandomGenOptions _options;
        public RandomGenOptions Options
        {
            get
            {
                if (_options == null)
                {
                    _options = new RandomGenOptions();
                }

                return _options;
            }
            set
            {
                _options = value;
            }
        }

        public RandomGen()
        {
        }

        public RandomGen(RandomGenOptions options)
        {
            _options = options;
        }

        public IEnumerable<T> Get<T>(int count)
        {

        }
    }
}
