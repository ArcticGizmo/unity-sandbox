using UnityEngine;

public class PlayerRotator : MonoBehaviour
{
  public float rotationalVelcoity = 10f;
  private float movement = 0f;

  private void Update()
  {
    if (Input.GetKey("l"))
    {
      movement = -1f;
    }
    else if (Input.GetKey("k"))
    {
      movement = 1f;
    }
    else
    {
      movement = 0f;
    }
  }

  private void FixedUpdate()
  {
    transform.Rotate(0, 0, movement);
  }
}
