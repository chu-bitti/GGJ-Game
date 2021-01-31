using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class QuestManager : ScriptableObject {

    public Quest currentQuest;
    public List<Quest> quests = new List<Quest>();
    public int candleRitual;

    public void AddInteraction(Quest interactionToAdd)
    {
        // Is the item a candle?
        if(interactionToAdd.isCandleRitual)
        {
            candleRitual++;
        }
    }

}
