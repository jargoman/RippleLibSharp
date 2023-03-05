using System;
using System.Collections.Generic;
using System.Linq;

// needed for CancellationToken
using System.Threading;


// needed for network interface
using RippleLibSharp.Network;

// needed to get result of tx submit

using RippleLibSharp.Transactions;
using RippleLibSharp.Commands.Stipulate;
using RippleLibSharp.Commands.Subscriptions;
using System.Threading.Tasks;
using RippleLibSharp.Result;
using RippleLibSharp.Transactions.TxTypes;
using RippleLibSharp.Commands.Server;

namespace RippleLibSharp.UnitTesting
{
    public class TestResult
    {
        public TestResult(bool result)
        {


            this.GetResult = result;

            

        }

        public bool GetResult { get; }


    }
}
