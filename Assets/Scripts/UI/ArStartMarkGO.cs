﻿using System.Collections;
using System.Collections.Generic;
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
      Main.Store.arOrigin.originIsSet.LazyBind(s =>
      {
        if (s) gameObject.SetActive(false);
      });
    }
  }
}