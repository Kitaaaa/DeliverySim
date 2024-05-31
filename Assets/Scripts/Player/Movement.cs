using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody rb;

    private bool isJumpPressed = false;

    [SerializeField] public float movementSpeed;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked;
    }


    void Update()
    {
        isJumpPressed = Input.GetKey(KeyCode.Space);

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput) * movementSpeed * Time.deltaTime;
        transform.Translate(movement);

    }

    void FixedUpdate()
    {
        if (isJumpPressed)
        {

            // the cube is going to move upwards in 2 units per second
            rb.velocity = new Vector3(0, 2, 0);
            Debug.Log("jump");
        }

    }
}