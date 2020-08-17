using UnityEngine;

public class PlayerController : MonoBehaviour
{
  public float direction = 0f;

  private int segments = 8;
  private float segmentWidth = 0f;
  private float offset = 22.5f + 90f;

  private void Start()
  {
    segmentWidth = 360f / (float)segments;
  }

  private void Update()
  {
    int segment = GetSegment(transform.eulerAngles.z);
    direction = GetDirection(segment);
  }

  private int GetSegment(float rotation)
  {
    float effectiveRotation = rotation - offset;
    if (effectiveRotation < 0)
    {
      effectiveRotation += 360f;
    }
    return Mathf.Abs(Mathf.CeilToInt(effectiveRotation / segmentWidth) % segments);
  }

  private float GetDirection(int segment)
  {
    float hDirection = 0f;
    float vDirection = 0f;

    vDirection = Input.GetAxisRaw("Vertical");
    hDirection = Input.GetAxisRaw("Horizontal");

    // horizontal direction
    if (segment == 0 || segment == 4)
    {
      hDirection = 0f;
    }
    else if (segment >= 1 && segment <= 3)
    {
      hDirection *= -1f;
    }

    // vertical direction
    if (segment == 2 || segment == 6)
    {
      vDirection = 0f;
    }
    else if (segment >= 3 && segment <= 5)
    {
      vDirection *= -1f;
    }

    return LargetByMagnitude(vDirection, hDirection);
  }

  private float LargetByMagnitude(float a, float b)
  {
    if (Mathf.Abs(a) > Mathf.Abs(b))
    {
      return a;
    }
    else
    {
      return b;
    }
  }
}
