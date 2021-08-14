using Sandbox;
using Ctl.UI;

namespace Ctl
{
  [Library("ctl", Title = "Combat Training Live")]
  partial class CTLGame : Game
  {
    public CTLGame()
    {
      Log.Info("Game Started");
      if (IsServer)
        new CTLHUD();
    }

    public override Player CreatePLayer() => new CTLPlayer();
  }
}