using UnityEngine;

namespace ARTemplate
{
  public class DiszctivateWhenOriginIsSet : MonoBehaviour
  {
    void Start()
    {
      Main.Store.ar.originIsSet.Bind(s => gameObject.SetActive(!s));
    }
  }
}