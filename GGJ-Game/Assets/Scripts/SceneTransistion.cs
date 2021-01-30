﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransistion : MonoBehaviour
{
    public string sceneToLoad;
    public void OnTriggerEnter2D(Collider2D other)
    {
      if(other.tag == "Player")
      {
        SceneManager.LoadScene(sceneToLoad);
      }
    }
  }
