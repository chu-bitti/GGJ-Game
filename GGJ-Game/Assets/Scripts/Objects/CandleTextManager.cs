using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class CandleTextManager : Interactable
{
    public Inventory playerInventory;
    public TextMeshProUGUI candleDisplay;
    public GameObject candleInfo;


    public void OnTriggerEnter2D(Collider2D other) {
      if(other.CompareTag("Player") && !other.isTrigger)
      {
        candleInfo.SetActive(true);
        playerInventory.candles += 1;
        candleDisplay.text = "" + playerInventory.candles;
        Destroy(this.gameObject);
      }
    }

    public void UpdateCandleCounter() {
    candleDisplay.text = "" + playerInventory.candles;
  }

}
