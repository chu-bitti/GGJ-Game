using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DOGGEdialog : Interactable
{
    public Item take;
    public Quest quest;
    public QuestManager playerQuestmanager;
    public Inventory playerInventory;
    public GameObject dollInfo;
    public TextMeshProUGUI dollDisplay;
    public GameObject dialog;
    public Conversation conversation;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return) && playerInRange) {
            if(dialog.activeInHierarchy) {
              dialog.SetActive(false);
            } else {
              if (playerQuestmanager.candleRitual == 0) {
                
            }
              if (playerQuestmanager.candleRitual == 1) {
              if (playerInventory.dolls == 0) {

          } else {

              playerInventory.TakeItem(take);
              dollDisplay.text = "" + playerInventory.dolls;
              if (playerInventory.dolls == 0) {
                dollInfo.SetActive(false);
              }
            playerQuestmanager.AddInteraction(quest);
            }
          }
        }
      }
    }


    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !other.isTrigger)
        {
          context.Raise();
          playerInRange = false;
        }
    }
  }
