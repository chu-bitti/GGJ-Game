using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ritual : MonoBehaviour
{
  public GameObject candle;

  public void OnTriggerEnter2D(Collider2D other)
  {
    if(other.tag == "Circle")
    {
      Destroy(candle);
    }
  }
}
