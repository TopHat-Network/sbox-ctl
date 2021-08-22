using Sandbox;

namespace CTL
{
    public partial class BaseCharacter : NetworkComponent
    {
		// Pawn Crap
        public virtual float Health => 100.0f;

		// Movement Information
		public virtual float Stamina => 100.0f;
		public virtual float SpeedFactor => 1.0f;
		public virtual float JumpFactor => 1.0f;

		// Appearance
		public virtual string Model => "models/citizen/citizen.vmdl";

		public virtual Color Color => new Color( 0, 0, 0 );

		// General Info
		public virtual string Name => "N/A";
		public virtual string Description => "If you're seeing this, someone fucked up. Maybe you, maybe me... probably me...";
		
		public BaseCharacter()
		{

		}
    }
}
