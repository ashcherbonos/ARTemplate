using UnityEngine;

namespace ARTemplate
{
  public class World : MonoBehaviour
  {
    void Start()
    {
      Main.Store.arOrigin.originIsSet.Bind(s => gameObject.SetActive(s));
      Main.Store.arOrigin.position.Bind(s => gameObject.transform.position = s);
    }
  }
}