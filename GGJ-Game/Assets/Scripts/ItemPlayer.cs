using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPlayer : MonoBehaviour
{
  private Transform player;
  public bool collision;

  void Start() {
    collision = false;
    player = GameObject.FindGameObjectWithTag("Player").transform;
  }

  public void OnTriggerEnter2D(Collider2D other)
  {
    if(other.tag == "Circle")
    {
    collision = true;
    }
  }

  public void OnTriggerExit2D(Collider2D other)
  {
    if(other.tag == "Circle")
    {
    collision = false;
    }
  }

}
