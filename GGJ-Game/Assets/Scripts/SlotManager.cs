using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlotManager : MonoBehaviour
{
    public Image[] slots;
    public Sprite box;
    public Sprite candle;
    public FloatValue allSlots;
    public FloatValue playerCurrentItem;

    // Start is called before the first frame update
    void Start()
    {
      InitSlots();
    }

    public void InitSlots() {
      for(int i = 0; i < allSlots.initialValue; i ++) {
        slots[i].gameObject.SetActive(true);
        slots[i].sprite = box;
      }
    }
}
