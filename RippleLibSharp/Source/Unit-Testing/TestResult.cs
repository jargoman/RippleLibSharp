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


            var tokenSource = new CancellationTokenSource();

            var token = tokenSource.Token;


            ConnectionSettings connectInfo = new ConnectionSettings
            {

                // list of server url's in prefered order. 
                ServerUrls = new string[] { "wss://s1.ripple.com:443", "wss://s2.ripple.com:443" },

               
                LocalUrl = "localhost",
                UserAgent = "optional spoof browser user agent",
                Reconnect = true
            };


            NetworkInterface network = new NetworkInterface(connectInfo);
            bool didConnect = network.Connect();

            if (!didConnect) {
                return;
            }

            /*
            string address = "";
            string destination = "";

            RippleCurrency recieve_amount = new RippleCurrency(1.0m);

            var task = PathFind.GetResult(
                        address,
                        destination,
                        recieve_amount,
                        network,
                        token

                    );

            task.Wait();

            var resp = task.Result;

            PathFindResult path_result = resp.result;

            Alternative[] alternatives = path_result.alternatives;


            int choice = 0;
            Alternative usersChoice = alternatives[choice];


            RipplePaymentTransaction tx = new RipplePaymentTransaction
            {
                Destination = path_result.destination_account,
                Account = path_result.source_account,
                Amount = path_result.destination_amount,
                Paths = usersChoice.paths_computed,
                SendMax = usersChoice.source_amount
            };
            */

            var task = Ping.getResult(network, token);
            task.Wait();

            var response = task.Result;

            PingObject ping = response.result;

            

        }

        public bool GetResult { get; }


    }
}
