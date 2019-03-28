using UnityEngine;
using UnityEngine.XR.ARFoundation;

namespace ARTemplate
{
  public class Initializator
  {
    public void InitScene()
    {
      InitCameraRig();
      InitEnvironment();
      InitUI();
    }

    private void InitCameraRig()
    {
      Main.Store.rig = Loader.Instantiate<ARSessionOrigin>(AddressableNames.CameraRig);
      Main.Store.mainCamera = Main.Store.rig.GetComponentInChildren<Camera>();
    }

    private void InitEnvironment()
    {
      Loader.Instantiate<GameObject>(AddressableNames.Environment);
    }

    private void InitUI()
    {
      Loader.Instantiate<GameObject>(AddressableNames.UI);
    }
  }
}
