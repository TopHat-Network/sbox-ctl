using Sandbox;

namespace CTL
{
	public partial class Game : Sandbox.Game
	{

		public Game()
		{
			if ( IsServer )
			{
				new HudEntity();
			}
		}

		public override void ClientJoined( Client client )
		{
			base.ClientJoined( client );

			// Create a pawn and assign it to the client.
			var player = new Player();
			client.Pawn = player;

			player.Respawn();
		}
	}

}
