using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BUNBUNdialog : Interactable
{
    public GameObject dialogeBox;
    public Text dialoge;
    public string dialog;
    public Image profile;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return) && playerInRange) {
            if(dialogeBox.activeInHierarchy) {
              dialogeBox.SetActive(false);
            } else {
              dialogeBox.SetActive(true);
              dialoge.text = dialog;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !other.isTrigger)
        {
          context.Raise();
          playerInRange = false;
          dialogeBox.SetActive(false);
        }
    }
  }
