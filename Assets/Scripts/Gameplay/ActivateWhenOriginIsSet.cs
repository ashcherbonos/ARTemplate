using UnityEngine;

namespace ARTemplate
{
  public class ActivateWhenOriginIsSet : MonoBehaviour
  {
    void Start()
    {
      Main.Store.ar.originIsSet.Bind(s => gameObject.SetActive(s));
    }
  }
}