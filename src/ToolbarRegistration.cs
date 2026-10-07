using ToolbarControl_NS;
using UnityEngine;

namespace Trajectories
{
    [KSPAddon(KSPAddon.Startup.Instantly, true)]
    public class RegisterToolbar : MonoBehaviour
    {

        static public KSP_Log.Log LGG_Log = null;
        static public void Start()
        {
            Debug.Log("[Trajectories] Registering Toolbar");
            ToolbarControl.RegisterMod(AppLauncherButton.MODID, AppLauncherButton.MODNAME);
        }

        static public void CheckLog()
        {
            if (LGG_Log == null)
            {
#if DEBUG
                LGG_Log = new KSP_Log.Log("Trajectories", KSP_Log.Log.LEVEL.INFO);
#else
            LGG_Log = new KSP_Log.Log("Trajectories", KSP_Log.Log.LEVEL.ERROR);
#endif
            }
        }
    }
}
