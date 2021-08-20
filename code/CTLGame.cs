using Sandbox;

namespace CTL
{
	public partial class CTLGame : Sandbox.Game
	{

		public CTLGame()
		{
			if ( IsServer )
			{
				new CTLHudEntity();
			}
		}

		public override void ClientJoined( Client client )
		{
			base.ClientJoined( client );

			// Create a pawn and assign it to the client.
			var player = new CTLPlayer();
			client.Pawn = player;

			player.Respawn();
		}
	}

}
