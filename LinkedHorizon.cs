using System;
using System.Collections;

namespace LinkedHorizon
{
    public class Horizon
    {
        public Horizon()
        {
        }
    }

    public class LinkedHorizon : IEnumerable
    {
        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator) GetEnumerator();
        }

        public PeopleEnum GetEnumerator()
        {
            return new HorizonEnum();
        }
    }

    public class HorizonEnum : IEnumerator
    {
        public bool MoveNext()
        {
            return false;
        }

        public void Reset()
        {
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        Horizon Current
        {
            get
            {
                return null;
            }
        }
    }
}
