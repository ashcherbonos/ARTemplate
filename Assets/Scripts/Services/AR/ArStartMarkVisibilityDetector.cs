using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ARTemplate.Services
{
  [RequireComponent(typeof(Renderer))]
  public class ArStartMarkVisibilityDetector : MonoBehaviour
  {
    void OnBecameVisible() => Main.Store.ar.markIsVisible.Value = true;
    void OnBecameInvisible() => Main.Store.ar.markIsVisible.Value = false;
  }
}