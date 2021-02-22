using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoPlayerController : MonoBehaviour
{
    //Player Objects
    [SerializeField]
    private GameObject Player1;
    [SerializeField]
    private GameObject Player2;
    public float speed = 6.0f;
    public float gravity = -9.8f;
    private CharacterController _charController;

    private void Start()
    {
        _charController = GetComponent<CharacterController>();
    }

    void Update()
    {
        //Check if players are assigned
        if (Player1 && Player2)
        {
            float deltaX = Input.GetAxis("HorizontalPlayer2") * speed;
            float deltaZ = Input.GetAxis("VerticalPlayer2") * speed;
            Vector3 movement = new Vector3(deltaX, 0, deltaZ);
            movement = Vector3.ClampMagnitude(movement, speed);

            movement.y = gravity;

            movement *= Time.deltaTime;
            movement = transform.TransformDirection(movement);
            _charController.Move(movement);
        }
    }
}
