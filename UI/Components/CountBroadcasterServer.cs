using System;
using Serverito;

namespace LiveSplit.UI.Components
{
    public class CountBroadcasterServer
    {

        private static CountBroadcasterServer instance = null;
        private static readonly object padlock = new object();

        CountBroadcasterServer()
        {
        }

        public static CountBroadcasterServer Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new CountBroadcasterServer();
                        instance.createView();
                    }
                    return instance;
                }
            }
        }

        ServeritoListener server = new ServeritoListener("http://localhost:8000/");


        public void createView()
        {
            server.AddView(new URL("/getCounter"), (ServeritoContext context) =>
            {
                Utils.WriteToResponse(context.Context, CountBroadcaster.getNumOfAttemps().ToString());
            });
        }

        public void startServer()
        {
            server.Start();
        }

        public void stopServer() {
            server.Stop();
        }
    }
}
