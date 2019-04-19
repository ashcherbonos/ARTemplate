using UnityEngine;

namespace ARTemplate.Services
{
  public class ArStartMarkPosition : MonoBehaviour
  {
    void Start()
    {
      gameObject.SetActive(false);
      Main.Store.ar.position.LazyBind(s =>
      {
        transform.position = s;
        gameObject.SetActive(true);
      });
      Main.Store.ar.originIsSet.LazyBind(s => gameObject.SetActive(!s));
    }
  }
}
