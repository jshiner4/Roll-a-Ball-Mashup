using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent (typeof(CharacterController))]
[AddComponentMenu("Control Script/FPS Input")]
public class RealPlayerController : MonoBehaviour
{
    public float speed = 6.0f;
    public float gravity = -9.8f;
    //public Vector3 jump;
    public float jumpForce = 10.0f;
    public bool isGrounded;

    private Rigidbody rb;
    private CharacterController _charController;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //jump = new Vector3(0.0f, 2.0f, 0.0f);
        jumpForce = 100.0f;
        _charController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float deltaX = Input.GetAxis("Horizontal") * speed;
        float deltaZ = Input.GetAxis("Vertical") * speed;
        Vector3 movement = new Vector3(deltaX, 0, deltaZ);
        movement = Vector3.ClampMagnitude(movement, speed);

        movement.y = gravity;

        movement *= Time.deltaTime;
        movement = transform.TransformDirection(movement);
        _charController.Move(movement);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
            Debug.Log("jump");
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        isGrounded = true;
        //Debug.Log("grounded");
    }
}
