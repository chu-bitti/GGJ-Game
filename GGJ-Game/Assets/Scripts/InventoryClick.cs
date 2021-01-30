using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class InventoryClick : MonoBehaviour
{
    private bool isPaused;
    public GameObject inventoryPanel;
    public GameObject InventoryButton;

    void Start() {
      isPaused = false;
      inventoryPanel.SetActive(false);
    }

    public void Update() {
    }

    public void Pause() {
        isPaused = !isPaused;
        if(isPaused) {
          inventoryPanel.SetActive(true);
          Time.timeScale = 0f;
        } else {
          inventoryPanel.SetActive(false);
          Time.timeScale = 1f;
        }
      }

    public void Resume() {
      isPaused = !isPaused;
    }
}
