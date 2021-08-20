using Sandbox;

namespace CTL
{
	partial class CTLPlayerController : WalkController
	{
		public Rotation LocRot;
		public bool Locked;
		public override void Simulate()
		{
			if ( Input.Down( InputButton.Attack2 ) && !Locked )
			{
				Locked = true;
				LocRot = Rotation;
			} else if (!Input.Down( InputButton.Attack2 ) && Locked) {
				Locked = false;
			}

			if (Locked)
				Rotation = LocRot;

			base.Simulate();
    }
	}
}
