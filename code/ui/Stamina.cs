using Sandbox;
using Sandbox.UI;
using Sandbox.UI.Construct;

namespace CTL
{
	public class Stamina : Panel
	{
		public Label Label;

		public Stamina()
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
