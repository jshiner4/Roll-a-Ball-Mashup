using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueTeamWin : MonoBehaviour
{
    public GameObject redFlag;
    public GameObject player2Parent;
    public GameObject redFlagStand;
    public GameObject blueWinText;
    //player 2 is blue. wants red flag
    private void Start()
    {
        blueWinText.SetActive(false);
    }
    private void OnCollisionEnter(Collision col)
    {
        if (col.collider.CompareTag("Player2"))
        {
            redFlag = player2Parent.transform.Find("Playground Flag RED").gameObject;
            if (redFlag != null)
            {
                redFlag.transform.parent = redFlagStand.transform;
                Debug.Log("transferred red flag. blue team wins");
                blueWinText.SetActive(true);
            }
        }
    }
}
