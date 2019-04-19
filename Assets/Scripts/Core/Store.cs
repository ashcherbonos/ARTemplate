using UnityEngine;
using UnityEngine.XR.ARFoundation;

namespace ARTemplate
{
  /// <summary>
  /// Value class with globall acces for storing app-level data.
  /// (Only data. For logic, use Services)
  /// Use Boxing to bind listeners to stored data:
  /// Main.Store.someFloat.Value = 42f;
  /// Main.Store.someFloat.Bind(s=>Debug.Log(s));
  /// </summary>
  public class Store
  {
    public Camera mainCamera;
    public ArOriginData ar = new ArOriginData();
  }

  public class ArOriginData
  {
    public ARSessionOrigin session = null;
    public Box<bool> originIsSet = new Box<bool>(false);
    public Box<Vector3> position = new Box<Vector3>(Vector3.zero);
    public Box<bool> markIsVisible = new Box<bool>(false);
    public Box<float> zoom = new Box<float>(Constants.DefaultArZoom);
  }
}
