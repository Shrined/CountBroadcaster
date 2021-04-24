using LiveSplit.Model;
using LiveSplit.UI.Components;
using System.Net;

namespace LiveSplit.Components
{
    class CountBroadcaster
    {

        private LiveSplitState state;

        public CountBroadcaster(LiveSplitState state)
        {
            this.state = state;
            CountBroadcasterServer.StartWebServer(this);
        }

        public int getNumOfAttemps()
        {
            return state.Run.AttemptCount;
        }

    }
}
