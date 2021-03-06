﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RedTeamWin : MonoBehaviour
{
    public GameObject blueFlag;
    public GameObject player1Parent;
    public GameObject blueFlagStand;
    public GameObject redWinText;
    //aka player 1 is red team. wants blue flag to win.
    private void Start()
    {
        redWinText.SetActive(false);
    }
    private void OnCollisionEnter(Collision col)
    {
        if (col.collider.CompareTag("Player1"))
        {
            blueFlag = player1Parent.transform.Find("Playground Flag BLUE").gameObject;
            if (blueFlag != null)
            {
                blueFlag.transform.parent = blueFlagStand.transform;
                Debug.Log("transferred blue flag. red team wins");
                redWinText.SetActive(true);
            }
        }
    }
}
