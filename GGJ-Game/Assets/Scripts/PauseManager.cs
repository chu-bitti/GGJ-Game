using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseManager : MonoBehaviour
{
    private bool isPaused;
    public GameObject pausePanel;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Cancel")) {
            Resume();
        }
    }

    public void Resume() {
      isPaused = !isPaused;
      if(isPaused) {
        pausePanel.SetActive(true);
        Time.timeScale = 0f;
      } else {
        pausePanel.SetActive(false);
        Time.timeScale = 1f;
      }
    }

    public void QuitToDesktop() {
      Application.Quit();
    }
}
