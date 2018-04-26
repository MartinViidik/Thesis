using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class Flashlight : VRTK_InteractableObject{

    private Light _light;
    private bool LightStatus;
    private VRTK_ControllerReference controllerReference;

    private void Awake()
    {
        if(_light == null)
        {
            _light = GameObject.Find("FlashlightLight").GetComponent<Light>();
        }
    }

    public override void OnInteractableObjectUsed(InteractableObjectEventArgs e)
    {
        base.OnInteractableObjectUsed(e);
        if (LightStatus)
        {
            TurnOff();
        } else {
            TurnOn();
        }
    }

    public override void Grabbed(VRTK_InteractGrab grabbingObject)
    {
        base.Grabbed(grabbingObject);
        controllerReference = VRTK_ControllerReference.GetControllerReference(grabbingObject.controllerEvents.gameObject);
        if (VRTK_ControllerReference.IsValid(controllerReference) && IsGrabbed())
        {
            VRTK_ControllerHaptics.TriggerHapticPulse(controllerReference, 0.5f, 0.5f, 0.01f);
        }
    }

    void TurnOn()
    {
        LightStatus = true;
        _light.intensity = 1.0f;
    }

    void TurnOff()
    {
        LightStatus = false;
        _light.intensity = 0.0f;
    }

}
