using Sandbox;

namespace CTL
{
	public partial class SeatEntity : Prop, IUse
	{
		public override void Spawn()
		{
			base.Spawn();

			SetModel( "models/maya_testcube_100.vmdl" );
			SetupPhysicsFromModel( PhysicsMotionType.Static, false );
			Scale = 0.25f;
		}

		public bool IsUsable( Entity user )
		{
			return true;
		}

		public bool OnUse( Entity user )
		{
			if ( user is Player player )
			{
				Log.Info( "This, is a chair. Dear god. There is more. No!" );

				player.Parent = this;
				player.Animator = new SeatAnimator();
				// sit down bitch
			}

			return false;
		}

	}

}
