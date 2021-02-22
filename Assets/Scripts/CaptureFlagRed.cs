using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaptureFlagRed : MonoBehaviour
{
    public GameObject redFlag;
    public GameObject player2Parent;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.collider.CompareTag("Player2"))
        {
            Debug.Log("player2");
            redFlag.transform.parent = player2Parent.transform;
        }
    }
}
