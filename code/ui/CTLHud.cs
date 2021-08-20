using Sandbox;
using Sandbox.UI;

namespace CTL
{
	public partial class CTLHudEntity : Sandbox.HudEntity<RootPanel>
	{
		public CTLHudEntity()
		{
			if ( IsClient )
			{
				RootPanel.SetTemplate( "/ui/ctlhud.html" );
				RootPanel.StyleSheet.Load( "/ui/ctlhud.scss" );
				RootPanel.AddChild<CTLHealth>();
				RootPanel.AddChild<CTLInventoryBar>();
				RootPanel.AddChild<KillFeed>();
			}
		}
	}
}
