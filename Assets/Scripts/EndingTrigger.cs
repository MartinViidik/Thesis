using UnityEngine;
using VRTK;

public class EndingTrigger : MonoBehaviour {

    public GameObject blockedWall;
    public GameObject wall;

    private bool endingEnabled = false;

    private void Update()
    {
        if (endingEnabled)
        {
            MoveWall();
        }
    }

    void MoveWall()
    {
        wall.transform.Translate(Vector3.forward * 2.5f * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<VRTK_PlayerObject>() && !endingEnabled)
        {
            Debug.Log("End scene beginning");
            blockedWall.SetActive(true);
            endingEnabled = true;
            GameController.instance.GameOver(0.1f);
        }
    }

}
