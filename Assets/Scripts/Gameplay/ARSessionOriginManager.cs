using UnityEngine;
using UnityEngine.XR.ARFoundation;

namespace ARTemplate
{
  public class ARSessionOriginManager : MonoBehaviour
  {
    [SerializeField] ARPlaneManager arPlaneManager;

    void Start()
    {
      Main.Store.arOrigin.zoom.Bind(s => transform.localScale = (1f / s) * Vector3.one);
      Main.Store.arOrigin.originIsSet.Bind(s => arPlaneManager.enabled = !s);
    }
  }
}