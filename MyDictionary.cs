using System;
using System.Collections.Generic;
using System.Text;

namespace KeyValueStore
{
    public class MyDictionary
    {
        private KeyValue[] myValues = new KeyValue[10];
        private int numVal = 0;

        public object this[string key]
        {
            get
            {
                for(int i = 0; i < numVal; i++)
                {
                    if(myValues[i].key == key)
                    {
                        return myValues[i].value;
                    } 
                }
                throw new KeyNotFoundException();
            }

            set
            {
                for(int i = 0; i < numVal; i++)
                {
                    if(myValues[i].key == key)
                    {
                        myValues[i] = new KeyValue(key, value);
                        return;
                    }
                }
                myValues[numVal++] = new KeyValue(key, value);
            }
        }
    }
}
