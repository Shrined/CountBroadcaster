using System;
using LiveSplit.Model;
using LiveSplit.UI.Components;

namespace LiveSplit.Components
{
    class CountBroadcasterFactory : IComponentFactory
    {
        public string ComponentName => "Count Broadcaster";

        public string Description => "Exposes an endpoint to allow external access to counter data";

        public ComponentCategory Category => ComponentCategory.Information;

        public IComponent Create(LiveSplitState state) => new CountBroadcasterComponent(state);

        public string UpdateName => ComponentName;

        public string XMLURL => throw new NotImplementedException();

        public string UpdateURL => throw new NotImplementedException();

        public Version Version => Version.Parse("1.0.0");

    }
}
