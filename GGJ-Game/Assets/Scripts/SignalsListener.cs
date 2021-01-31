using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SignalsListener : MonoBehaviour
{
    public Signals signals;
    public UnityEvent signalsEvent;

    public void OnSignalsRaised() {
      signalsEvent.Invoke();
    }

    private void onEnable()
    {
      signals.RegisterListener(this);
    }

    private void onDisable()
    {
      signals.DeRegisterListener(this);
    }
}
