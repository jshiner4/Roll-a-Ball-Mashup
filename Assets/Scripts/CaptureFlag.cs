using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaptureFlag : MonoBehaviour
{
    public GameObject blueFlag;
    public GameObject player1Parent;
    public GameObject player2Parent;
    public GameObject blueFlagStand;
    //red team captures blue flag, or blue team puts their flag back
    private void OnCollisionEnter(Collision col)
    {
        if(col.collider.CompareTag("Player1"))
        {
            Debug.Log("player1");
            blueFlag.transform.parent = player1Parent.transform;
        }

        else if (col.collider.CompareTag("Player2"))
        {
            blueFlag = player2Parent.transform.Find("Playground Flag BLUE").gameObject;
            if (blueFlag != null)
            {
                blueFlag.transform.parent = blueFlagStand.transform;
                Debug.Log("blue flag has been returned");
            }
        }
    }
}
