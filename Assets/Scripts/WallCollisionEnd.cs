using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class WallCollisionEnd : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<VRTK_PlayerObject>())
        {
            GameController.instance.fadeScreen();
        }
    }

}
