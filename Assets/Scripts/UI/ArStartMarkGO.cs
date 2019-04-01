using UnityEngine;

namespace ARTemplate.UI
{
  public class ArStartMarkGO : MonoBehaviour
  {
    void Start()
    {
      gameObject.SetActive(false);
      Main.Store.arOrigin.position.LazyBind(s =>
      {
        transform.position = s;
        gameObject.SetActive(true);
      });
      Main.Store.arOrigin.originIsSet.LazyBind(s => gameObject.SetActive(!s));
    }
  }
}
