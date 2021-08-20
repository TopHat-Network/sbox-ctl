using Sandbox;
using Sandbox.UI;
using Sandbox.UI.Construct;

namespace CTL
{
	public class CTLHealth : Panel
	{
		public Label Label;

		public CTLHealth()
		{
			Label = Add.Label( "100", "value" );
		}

		public override void Tick()
		{
			var player = Local.Pawn;
			if ( player == null ) return;

			Label.Text = $"{player.Health.CeilToInt()}";
		}
	}
}
