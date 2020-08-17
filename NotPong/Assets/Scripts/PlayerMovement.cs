using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
  public PlayerController pc;
  public Rigidbody rb;
  public float acceleration = 20f;
  public float maxSpeed = 10f;

  private void FixedUpdate()
  {
    float movement = pc.direction;
    rb.AddForce(transform.right * acceleration * Time.deltaTime * movement, ForceMode.VelocityChange);
    rb.velocity = Vector3.ClampMagnitude(rb.velocity, maxSpeed);
  }

}
