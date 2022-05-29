using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : Interactable
{

    public Light m_Light; // im using m_Light name since 'light' is already a variable used by unity
    public bool isOn;

    private void Start()
    {
        UpdateLight();
    }

    void UpdateLight()
    {
        m_Light.enabled = isOn;
    }

    public override string GetDescription()
    {
        if (isOn) return "Lights (On)";
        return "Lights (Off)";
    }

    public override void Interact()
    {
        isOn = !isOn;
        UpdateLight();
    }
}
