using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class CandleTextManager : MonoBehaviour
{
    public Inventory playerInventory;
    public TextMeshProUGUI candleDisplay;
    public void UpdateCandleCount() {
      candleDisplay.text = "" + playerInventory.candles;
    }
}
