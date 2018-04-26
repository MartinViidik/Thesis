using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretScript : MonoBehaviour {

    private Rigidbody rb;
    public GameObject player;
    public GameObject turret;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        LookAtPlayer();
    }

    void LookAtPlayer()
    {
        Vector3 dir = transform.position - player.transform.position;
        Quaternion lookRotation = Quaternion.LookRotation(dir);
        Vector3 rotation = lookRotation.eulerAngles;
        turret.transform.rotation = Quaternion.Euler(-90, rotation.y + 5, rotation.z);

    }

}
