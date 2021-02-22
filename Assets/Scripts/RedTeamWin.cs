using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedTeamWin : MonoBehaviour
{
    public GameObject blueFlag;
    public GameObject player1Parent;
    //aka player 1
    private void OnCollisionEnter(Collision col)
    {
        if (col.collider.CompareTag("Player2"))
        {
            //Debug.Log("player1");
            //blueFlag.transform.parent = player1Parent.transform;
            blueFlag = player1Parent.transform.Find("Playground Flag BLUE").gameObject;
            if (blueFlag != null)
            {
                blueFlag.transform.parent = this.transform;
                Debug.Log("transferred flag");
            }
        }
    }
}
