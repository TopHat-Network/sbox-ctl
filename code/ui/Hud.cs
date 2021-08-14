using Sandbox;
using Sandbox.UI;

namespace Ctl.UI
{
  [Library]
  public partial class CTLHUD : Hud
  {
    public CTLHUD()
    {
      if (!IsClient) return;

      RootPanel.StyleSheet.Load("/ui/Hud.scss");
      RootPanel.AddChild<ChatBox>();
    }
  }
}