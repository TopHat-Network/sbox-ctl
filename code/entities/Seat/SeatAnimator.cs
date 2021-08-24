using Sandbox;

namespace CTL
{
    public class SeatAnimator : PawnAnimator
    {
        public override void Simulate()
        {
            ResetParams();

			SetParam( "b_grounded", true );
			SetParam( "bit_sit", true );
        }
    }
}
