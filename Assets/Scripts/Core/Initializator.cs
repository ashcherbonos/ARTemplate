using UnityEngine;
using UnityEngine.XR.ARFoundation;

namespace ARTemplate
{
  public class Initializator
  {
    public void InitScene()
    {
      InitSession();
      InitCameraRig();
      InitEnvironment();
      InitUI();
    }

    private void InitSession()
    {
      Loader.Instantiate<GameObject>(AddressableNames.ARSession);
    }

    private void InitCameraRig()
    {
      Main.Store.rig = Loader.Instantiate<ARSessionOrigin>(AddressableNames.CameraRig);
      Main.Store.mainCamera = Main.Store.rig.GetComponentInChildren<Camera>();
    }

    private void InitEnvironment()
    {
      //Loader.Instantiate<GameObject>(AddressableNames.Environment);
    }

    private void InitUI()
    {
      Loader.Instantiate<GameObject>(AddressableNames.UI);
    }
  }
}
