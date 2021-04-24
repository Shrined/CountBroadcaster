using System;
using System.Windows.Forms;
using System.Xml;
using LiveSplit.Model;
using LiveSplit.UI;
using LiveSplit.UI.Components;

namespace LiveSplit.Components
{
    class CountBroadcasterComponent : LogicComponent
    {

        public CountBroadcasterComponent(LiveSplitState state)
        {
            new CountBroadcaster(state);
        }

        public override string ComponentName => throw new NotImplementedException();

        public override void Dispose()
        {
            CountBroadcasterServer.StopWebServer();
        }

        public override XmlNode GetSettings(XmlDocument document)
        {
            throw new NotImplementedException();
        }

        public override Control GetSettingsControl(LayoutMode mode)
        {
            throw new NotImplementedException();
        }

        public override void SetSettings(XmlNode settings)
        {
            throw new NotImplementedException();
        }

        public override void Update(IInvalidator invalidator, LiveSplitState state, float width, float height, LayoutMode mode)
        {
            throw new NotImplementedException();
        }
    }
}
