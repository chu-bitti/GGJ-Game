using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class CandleTextManager : Interactable
{
    public Inventory playerInventory;
    public TextMeshProUGUI candleDisplay;


    public void OnTriggerEnter2D(Collider2D other) {
      if(other.CompareTag("Player") && !other.isTrigger)
      {
        playerInventory.candles += 1;
        UpdateCandleCount();
        Destroy(this.gameObject);
      }
    }

    public void UpdateCandleCount() {
      candleDisplay.text = "" + playerInventory.candles;
    }
}
