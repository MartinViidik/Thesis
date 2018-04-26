using UnityEngine;

public class Fan : MonoBehaviour {

    public float speed;

	void Update () {
        transform.Rotate(Vector3.up * speed * Time.deltaTime, Space.World);
    }

}
