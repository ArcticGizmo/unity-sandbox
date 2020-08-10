using UnityEngine;

public class PlayerController : MonoBehaviour
{
  public Rigidbody rb;
  public float forwardForce = 2000f;
  public float horizontalForce = 1000f;

  float yDeathPlane = -1f;

  // Update is called once per frame
  void FixedUpdate()
  {
    rb.AddForce(0, 0, forwardForce * Time.deltaTime);

    ApplyHorizontalForce();

  }

  void ApplyHorizontalForce()
  {

    if (Input.GetKey("d"))
    {
      rb.AddForce(horizontalForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }

    if (Input.GetKey("a"))
    {
      rb.AddForce(-horizontalForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }

    if (rb.position.y < yDeathPlane)
    {
      Debug.Log("[Player Cont] y death plane triggered");
      FindObjectOfType<GameManager>().EndGame();
    }
  }
}
