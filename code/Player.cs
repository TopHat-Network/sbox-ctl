using Sandbox;

namespace CTL
{
	partial class Player : Sandbox.Player
	{
		[Net]
		public BaseCharacter Character { get; set; }

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
			Camera = new ThirdPersonCamera();

			EnableAllCollisions = true;
			EnableDrawing = true;
			EnableHideInFirstPerson = true;
			EnableShadowInFirstPerson = true;

			base.Respawn();
		}

		public override void OnKilled()
		{
			base.OnKilled();
			EnableDrawing = false;
		}
	}

}
