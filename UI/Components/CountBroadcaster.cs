using LiveSplit.Model;

namespace LiveSplit.UI.Components
{
    public class CountBroadcaster
    {
        private static LiveSplitState state;

        public CountBroadcaster(LiveSplitState liveSplitState)
        {
            state = liveSplitState;
        }

        public static int getNumOfAttemps()
        {
            return state.Run.AttemptCount;
        }

    }
}
