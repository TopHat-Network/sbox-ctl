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

				var player = Local.Pawn;
				if ( player == null ) return;
				if ( (player as Player).state == "waiting_room" ) return;

				RootPanel.AddChild<Health>();
				RootPanel.AddChild<InventoryBar>();
				RootPanel.AddChild<KillFeed>();
			}
		}
	}
}
