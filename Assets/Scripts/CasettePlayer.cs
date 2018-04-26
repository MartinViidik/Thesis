using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class CasettePlayer : VRTK_SnapDropZone {

    public GameObject Door;

    public override void OnObjectEnteredSnapDropZone(SnapDropZoneEventArgs e)
    {
        base.OnObjectEnteredSnapDropZone(e);
        Door.GetComponent<VRTK_InteractableObject>().isGrabbable = true;
        Door.GetComponent<Rigidbody>().isKinematic = false;
        GameController.instance.timerStarted = true;
    }


}
