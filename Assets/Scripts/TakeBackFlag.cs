using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeBackFlag : MonoBehaviour
{
    // for player 2 stealing player 1's flag
    public GameObject blueFlag;
    public GameObject redFlag;
    public GameObject player1Parent;
    public GameObject player2Parent;
    private void OnCollisionEnter(Collision col)
    {
        if (col.collider.CompareTag("Player1"))
        {
            blueFlag = player1Parent.transform.Find("Playground Flag BLUE").gameObject;
            if (blueFlag != null)
            {
                blueFlag.transform.parent = player2Parent.transform;
                Debug.Log("blue flag has been taken back");
            }
        }

        else if (col.collider.CompareTag("Player2"))
        {
            redFlag = player2Parent.transform.Find("Playground Flag RED").gameObject;
            if (redFlag != null)
            {
                redFlag.transform.parent = player1Parent.transform;
                Debug.Log("red flag has been taken back");
            }
        }
    }
}
