using Sandbox;
using Sandbox.UI;

namespace CTL
{
	public partial class HudEntity : Sandbox.HudEntity<RootPanel>
	{
		public HudEntity()
		{
			if ( IsClient )
			{
				RootPanel.SetTemplate( "/ui/Hud.html" );
				RootPanel.StyleSheet.Load( "/ui/Hud.scss" );
				RootPanel.AddChild<Health>();
				RootPanel.AddChild<InventoryBar>();
				RootPanel.AddChild<KillFeed>();
			}
		}
	}
}
