using Sandbox;

namespace CTL
{
    partial class PlayerController : WalkController
    {
		private float jumpFactor = 1.2f;
		public float JumpFactor { get { return jumpFactor; } set { jumpFactor = value; } }
		public float SpeedFactor
		{
			get { return DefaultSpeed / 190.0f; }
			set
			{
				DefaultSpeed = 190.0f * value;
				WalkSpeed = 150.0f * value;
				SprintSpeed = 320.0f * value;
			}
		}

		public override void CheckJumpButton()
		{
			//if ( !player->CanJump() )
			//    return false;


			/*
            if ( player->m_flWaterJumpTime )
            {
                player->m_flWaterJumpTime -= gpGlobals->frametime();
                if ( player->m_flWaterJumpTime < 0 )
                    player->m_flWaterJumpTime = 0;

                return false;
            }*/



			// If we are in the water most of the way...
			if ( Swimming )
			{
				// swimming, not jumping
				ClearGroundEntity();

				Velocity = Velocity.WithZ( 100 );

				// play swimming sound
				//  if ( player->m_flSwimSoundTime <= 0 )
				{
					// Don't play sound again for 1 second
					//   player->m_flSwimSoundTime = 1000;
					//   PlaySwimSound();
				}

				return;
			}

			if ( GroundEntity == null )
				return;

			/*
            if ( player->m_Local.m_bDucking && (player->GetFlags() & FL_DUCKING) )
                return false;
            */

			/*
            // Still updating the eye position.
            if ( player->m_Local.m_nDuckJumpTimeMsecs > 0u )
                return false;
            */

			ClearGroundEntity();

			// player->PlayStepSound( (Vector &)mv->GetAbsOrigin(), player->m_pSurfaceData, 1.0, true );

			// MoveHelper()->PlayerSetAnimation( PLAYER_JUMP );

			float flGroundFactor = 1.0f;
			//if ( player->m_pSurfaceData )
			{
				//   flGroundFactor = g_pPhysicsQuery->GetGameSurfaceproperties( player->m_pSurfaceData )->m_flJumpFactor;
			}

			Log.Info($"Jump: {jumpFactor}");

			float flMul = 268.3281572999747f * jumpFactor;

			float startz = Velocity.z;

			if ( Duck.IsActive )
				flMul *= 0.8f;

			Velocity = Velocity.WithZ( startz + flMul * flGroundFactor );

			Velocity -= new Vector3( 0, 0, Gravity * 0.5f ) * Time.Delta;

			// mv->m_outJumpVel.z += mv->m_vecVelocity[2] - startz;
			// mv->m_outStepHeight += 0.15f;

			// don't jump again until released
			//mv->m_nOldButtons |= IN_JUMP;

			AddEvent( "jump" );

		}
	}
}
