using System;
using System.Collections.Generic;
using System.Linq;

namespace HW19
{
    enum InteractionType { Call = 2, SMS = 1 }
    class Interaction
    {
        public string fromMobileNumber;
        public string toMobileNumber;
        public InteractionType interactionType;
        
        public Interaction(string fromMobileNumber, string toMobileNumber, InteractionType interactionType)
        {
            this.fromMobileNumber = fromMobileNumber;
            this.toMobileNumber =toMobileNumber;
            this.interactionType = interactionType;
        }
    }
}
