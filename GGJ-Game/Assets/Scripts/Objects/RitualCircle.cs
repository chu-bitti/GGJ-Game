using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RitualCircle : Interactable
{
    public Item take;
    public int numberCandles;
    public bool isComplete;
    public bool AllCandlesLit;
    public GameObject dialogeBox;
    public Text dialogText;
    public TextMeshProUGUI candleDisplay;
    public GameObject candleInfo;
    public Inventory playerInventory;
    public GameObject LitCandles0;
    public GameObject LitCandles1;
    public GameObject LitCandles2;
    public GameObject LitCandles3;

    void Start() {
      LitCandles0.SetActive(false);
      LitCandles1.SetActive(false);
      LitCandles2.SetActive(false);
      LitCandles3.SetActive(false);
      numberCandles = 0;
      AllCandlesLit = false;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return) && playerInRange) {
            if(!isComplete) {
              if(playerInventory.candles > 0) {
              if(AllCandlesLit == false) {
              playerInventory.TakeItem(take);
              candleDisplay.text = "" + playerInventory.candles;
              if (playerInventory.candles == 0) {
                candleInfo.SetActive(false);
              }
              ActivateCandle();
              numberCandles++;
              CompleteRitual(); }
            }
            } else {
              RitualComplete();
            }
        }
      }

    public void ActivateCandle() {
      if (numberCandles == 0) {
          LitCandles0.SetActive(true);
        }
        if (numberCandles == 1) {
            LitCandles1.SetActive(true);
          }
          if (numberCandles == 2) {
              LitCandles2.SetActive(true);
            }
            if (numberCandles == 3) {
                LitCandles3.SetActive(true);
              }
    }

    public void CompleteRitual() {
      if (numberCandles == 4) {
          AllCandlesLit = true;
          dialogeBox.SetActive(true);
          dialogText.text = "The ritual is complete.";
          isComplete = true;
        }
    }

    public void RitualComplete() {
          dialogeBox.SetActive(false);
          playerInventory.currentItem = null;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !other.isTrigger &&!isComplete)
        {
            context.Raise();
            playerInRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !other.isTrigger &&!isComplete)
        {
            context.Raise();
            playerInRange = false;
        }
    }

  }
