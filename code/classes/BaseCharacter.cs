using Sandbox;

namespace CTL
{
    public partial class BaseCharacter : NetworkComponent
    {
		// Health shit
        public virtual float Health => 100.0f;

		// Movement shit
		public virtual float Stamina => 100.0f;
		public virtual float Speed => 100.0f;
		public virtual float JumpFactor => 1.2f;

		// Model shit
		public virtual string Model => "models/citizen/citizen.vmdl";

		// General Info crap
		public virtual string Name => "N/A";
		public virtual string Description => "If you're seeing this, someone fucked up. Maybe you, maybe me... probably me...";

		public BaseCharacter()
		{

		}
    }
}
