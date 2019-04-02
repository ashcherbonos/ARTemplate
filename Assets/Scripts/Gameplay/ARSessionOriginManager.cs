using UnityEngine;

namespace ARTemplate
{
  public class ARSessionOriginManager : MonoBehaviour
  {
    void Start()
    {
      Main.Store.arOrigin.zoom.Bind(s => transform.localScale = s * Vector3.one);
    }
  }
}