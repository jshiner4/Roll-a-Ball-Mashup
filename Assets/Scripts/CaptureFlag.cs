using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaptureFlag : MonoBehaviour
{
    public GameObject blueFlag;
    public GameObject player1Parent;    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision col)
    {
        if(col.collider.CompareTag("Player1"))
        {
            Debug.Log("player1");
            blueFlag.transform.parent = player1Parent.transform;
        }
    }
}
