using Braintree;
using System;
using System.Collections.Generic;
using System.Text;

namespace Utility.BrainTree
{
    public interface IBrainTreeGate
    {
        IBraintreeGateway CreateGateway();

        IBraintreeGateway GetGateway();
    }
}
