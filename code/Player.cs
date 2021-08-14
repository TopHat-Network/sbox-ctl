using Sandbox;
using System;

namespace Ctl
{
  partial class CTLPlayer : BasePlayer
  {
    public CTLPlayer()
    {
      Log.Info("CTL Player");
    }

    public override void Respawn()
    {
      SetModel("models/citizen/citizen.vmdl");
      Controller = new WalkController();
      Animator = new StandardPlayerAnimator();
      Camera = new FirstPersonCamera();
      EnableAllCollisions = true;
      EnableDrawing = true;
      EnableHideInFirstPerson = true;
      EnableShadowInFirstPerson = true;
      base.Respawn();
    }
  }
}