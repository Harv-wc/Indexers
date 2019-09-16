using System;
using System.Collections.Generic;
using System.Text;

namespace KeyValueStore
{
    struct KeyValue
    {
        public readonly string key;
        public readonly object value;

        public KeyValue (string keyVal, object valueVal)
        {
            key = keyVal;
            value = valueVal;
        }
    }
}
