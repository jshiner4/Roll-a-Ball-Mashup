using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaptureFlagRed : MonoBehaviour
{
    public GameObject redFlag;
    public GameObject player2Parent;
    public GameObject redFlagStand;
    public GameObject player1Parent;

    private void OnCollisionEnter(Collision col)
    {
        if (col.collider.CompareTag("Player2"))
        {
            Debug.Log("player2");
            redFlag.transform.parent = player2Parent.transform;
        }

        else if (col.collider.CompareTag("Player1"))
        {
            redFlag = player1Parent.transform.Find("Playground Flag RED").gameObject;
            if (redFlag != null)
            {
                redFlag.transform.parent = redFlagStand.transform;
                Debug.Log("blue flag has been returned");
            }
        }
    }
}
