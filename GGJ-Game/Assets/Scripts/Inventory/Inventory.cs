using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Inventory : ScriptableObject {

    public Item currentItem;
    public List<Item> items = new List<Item>();
    public int candles;
    public int dolls;

    public void AddItem(Item itemToAdd)
    {
        // Is the item a candle?
        if(itemToAdd.isCandle)
        {
            candles++;
        }
        if(itemToAdd.isDoll)
        {
            dolls++;
        }
        else
        {
            if(!items.Contains(itemToAdd))
            {
                items.Add(itemToAdd);
            }
        }
    }

    public void TakeItem(Item itemToTake)
    {
        // Is the item a candle?
        if(itemToTake.isCandle)
        {
          if(candles >= 1) {
            candles--;
          }
        } // Is the item a doll?
        if(itemToTake.isDoll)
        {
          if(candles >= 1) {
            dolls--;
          }
        }
        else
        {
            if(!items.Contains(itemToTake))
            {
                Debug.Log("No item");
            }
        }
    }

}
