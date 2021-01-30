using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SignalListener : MonoBehaviour
{
    public Signal signal;
    public UnityEvent signalEvent;

    public void OnSignalRaised() {
      signalEvent.Invoke();
    }

    private void onEnable()
    {
      signal.RegisterListener(this);
    }

    private void onDisable()
    {
      signal.DeRegisterListener(this);
    }
}
