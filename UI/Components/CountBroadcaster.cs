using LiveSplit.Model;

namespace LiveSplit.UI.Components
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
