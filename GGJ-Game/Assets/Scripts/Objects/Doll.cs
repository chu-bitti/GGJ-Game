using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doll : PowerUp
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
}
