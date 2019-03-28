﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ARTemplate.Services.ArOriginPoint
{
  public class ArStartMark : MonoBehaviour
  {
    void OnBecameVisible() => Main.Store.arOrigin.markIsVisible.Value = true;
    void OnBecameInvisible() => Main.Store.arOrigin.markIsVisible.Value = false;

    void Start()
    {
      Main.Store.arOrigin.position.LazyBind(s => transform.position = s * Main.Store.arOrigin.zoom.Value);
    }
  }
}