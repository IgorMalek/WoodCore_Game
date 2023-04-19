using UnityEngine;

public class HumanMovement : MonoBehaviour
{
    public Rigidbody rb;
    private float speed = 4.0f;
    private float verticalInput;
    private float turnSpeed = 90.0f;
    private float horizontalInput;
    private float forwardInput;
    void FixedUpdate()
    {
      horizontalInput = Input.GetAxis("Horizontal");
      forwardInput = Input.GetAxis("Vertical");
      transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
      transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);  
        

    }
}
