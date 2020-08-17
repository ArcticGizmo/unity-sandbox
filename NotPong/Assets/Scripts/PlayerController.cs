using UnityEngine;

public class PlayerController : MonoBehaviour
{
  public Rigidbody rb;
  public float acceleration = 20f;
  public float maxSpeed = 200f;
  private float movement = 0f;

  void Update()
  {
    // getting this will be much more complicated because it will depend on the 
    // direction that you are facing (only for multi directional input, keyboard will just stay confusing I guess)
    movement = Input.GetAxisRaw("Horizontal");
  }

  private void FixedUpdate()
  {
    rb.AddForce(Vector3.right * acceleration * Time.deltaTime * movement, ForceMode.VelocityChange);
    rb.velocity = Vector3.ClampMagnitude(rb.velocity, maxSpeed);
    Debug.Log(rb.velocity.magnitude);
  }
}
