using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueTeamWin : MonoBehaviour
{
    public GameObject redFlag;
    public GameObject player2Parent;

    private void OnCollisionEnter(Collision col)
    {
        if (col.collider.CompareTag("Player2"))
        {
            //Debug.Log("player1");
            //blueFlag.transform.parent = player1Parent.transform;
            redFlag = player2Parent.transform.Find("Playground Flag RED").gameObject;
            if (redFlag != null)
            {
                redFlag.transform.parent = this.transform;
                Debug.Log("transferred flag");
            }
        }
    }
}
