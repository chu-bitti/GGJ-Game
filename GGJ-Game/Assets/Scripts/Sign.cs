using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Sign : MonoBehaviour
{

    public GameObject dialogeBox;
    public GameObject InventoryFrame;
    public Text dialogText;
    public string dialog;
    public bool playerInRange;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && playerInRange) {
            if(dialogeBox.activeInHierarchy) {
              InventoryFrame.SetActive(true);
              dialogeBox.SetActive(false);
            } else {
              InventoryFrame.SetActive(false);
              dialogeBox.SetActive(true);
              dialogText.text = dialog;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
      if(other.CompareTag("Player")) {
        playerInRange = true;
      }
    }

    private void OnTriggerExit2D(Collider2D other) {
      if(other.CompareTag("Player")) {
        playerInRange = false;
        InventoryFrame.SetActive(true);
        dialogeBox.SetActive(false);
      }
    }
}
