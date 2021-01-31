using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class DollTextManager : Interactable
{
    public Inventory playerInventory;
    public TextMeshProUGUI dollDisplay;
    public GameObject dollInfo;


    public void OnTriggerEnter2D(Collider2D other) {
      if(other.CompareTag("Player") && !other.isTrigger)
      {
        dollInfo.SetActive(true);
        playerInventory.dolls += 1;
        dollDisplay.text = "" + playerInventory.dolls;
        Destroy(this.gameObject);
      }
    }

    public void UpdateDollCounter() {
    dollDisplay.text = "" + playerInventory.dolls;
  }

}
