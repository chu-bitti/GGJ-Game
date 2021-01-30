﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransistion : MonoBehaviour
{
    public string sceneToLoad;
    public Vector2 playerPosition;
    public VectorValue playerStorage;

    public void OnTriggerEnter2D(Collider2D other)
    {
      if(other.tag == "Player")
      {
        playerStorage.initalValue = playerPosition;
        SceneManager.LoadScene(sceneToLoad);
      }
    }
  }
