using Sandbox;

namespace CTL
{
	partial class Player : Sandbox.Player
	{
		[Net]
		public BaseCharacter Character { get; set; }

		public string state = "waiting_room";

		public override void Respawn()
		{
			Character = new HexerCharacter();

			SetModel( Character.Model );

			// Use WalkController for movement (you can make your own PlayerController for 100% control)
			var tempController = new PlayerController();

			tempController.JumpFactor = Character.JumpFactor;
			tempController.SpeedFactor = Character.SpeedFactor;

			Controller = tempController;

			// Use StandardPlayerAnimator  (you can make your own PlayerAnimator for 100% control)
			Animator = new StandardPlayerAnimator();

			// Use ThirdPersonCamera (you can make your own Camera for 100% control)
			Camera = new FirstPersonCamera();

			EnableAllCollisions = true;
			EnableDrawing = true;
			EnableHideInFirstPerson = true;
			EnableShadowInFirstPerson = true;

			base.Respawn();
		}

		public bool IsUseDisabled()
		{
			return false;
		}

		protected override Entity FindUsable()
		{
			if ( IsUseDisabled() )
				return null;

			// First try a direct 0 width line
			var tr = Trace.Ray( EyePos, EyePos + EyeRot.Forward * (85 * Scale) )
				.HitLayer( CollisionLayer.Debris )
				.Ignore( this )
				.Run();

			// Nothing found, try a wider search
			if ( !IsValidUseEntity( tr.Entity ) )
			{
				tr = Trace.Ray( EyePos, EyePos + EyeRot.Forward * (85 * Scale) )
				.Radius( 2 )
				.HitLayer( CollisionLayer.Debris )
				.Ignore( this )
				.Run();
			}

			// Still no good? Bail.
			if ( !IsValidUseEntity( tr.Entity ) ) return null;

			return tr.Entity;
		}

		public override void OnKilled()
		{
			base.OnKilled();
			EnableDrawing = false;
		}

	}

}
