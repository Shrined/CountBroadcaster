using System.Windows.Forms;
using System.Xml;
using LiveSplit.Model;


namespace LiveSplit.UI.Components
{
    class CountBroadcasterComponent : LogicComponent
    {

        public CountBroadcasterComponent(LiveSplitState state)
        {
            new CountBroadcaster(state);
        }

        public override string ComponentName => "Count Broadcaster";

        public override void Dispose()
        {
            CountBroadcasterServer.StopWebServer();
        }

        public override XmlNode GetSettings(XmlDocument document)
        {
            return null;
        }

        public override Control GetSettingsControl(LayoutMode mode)
        {
            return null;
        }

        public override void SetSettings(XmlNode settings)
        {
        }

        public override void Update(IInvalidator invalidator, LiveSplitState state, float width, float height, 
            LayoutMode mode) { }
    }
}
