using Sandbox;

namespace CTL
{
    public partial class SofaEntity : Prop, IUse
    {
        public override void Spawn()
        {
            base.Spawn();

            SetModel("models/citizen_props/chair04blackleather.vmdl");
            SetupPhysicsFromModel(PhysicsMotionType.Dynamic, false);
        }

        public bool IsUsable(Entity user)
        {
            return true;
        }

        public bool OnUse(Entity user)
        {
            if ( user is Player player )
            {
                // sit down bitch
            }

            return false;
        }
    }
}
