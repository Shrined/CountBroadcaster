using System.Windows.Forms;
using System.Xml;
using LiveSplit.Model;


namespace LiveSplit.UI.Components
{
    class CountBroadcasterComponent : LogicComponent
    {

        Control control = new Control();

        public CountBroadcasterComponent(LiveSplitState state)
        {
            new CountBroadcaster(state);
            System.Threading.Tasks.Task.Factory.StartNew(() =>
            {
                CountBroadcasterServer.Instance.startServer();
            });
        }

        public override string ComponentName => "Count Broadcaster";

        public override void Dispose()
        {
            CountBroadcasterServer.Instance.stopServer();
        }

        public override XmlNode GetSettings(XmlDocument document)
        {
            return document.CreateElement("Settings");
        }

        public override Control GetSettingsControl(LayoutMode mode)
        {
            return control;
        }

        public override void SetSettings(XmlNode settings)
        {
        }

        public override void Update(IInvalidator invalidator, LiveSplitState state, float width, float height, 
            LayoutMode mode) { }
    }
}
