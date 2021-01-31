using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Candle : PowerUp
{

    public Inventory playerInventory;
    // Start is called before the first frame update
    void Start()
    {
      powerupSignals.Raise();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter2D(Collider2D other) {
      if(other.CompareTag("Player") && !other.isTrigger)
      {
        playerInventory.candles += 1;
        powerupSignals.Raise();
        Destroy(this.gameObject);
      }
    }
}
