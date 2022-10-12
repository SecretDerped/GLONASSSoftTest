using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.Services
{
    public class DurationSetup
    {
        public int MaxDuration { get; }

        public DurationSetup(int maxDuration)
        {
            MaxDuration = maxDuration;
        }
    }
}
