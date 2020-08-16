using UnityEngine;

public class Hexagon : MonoBehaviour
{

  public Rigidbody2D rb;
  public LineRenderer lr;
  private Transform hexColliderTransform;

  public float shrinkSpeed = 3f;

  public float startScale = 10f;
  public float endScale = 0.05f;

  public float initialWidth = 0.2f;
  public float finalWidth = 0.05f;


  void Start()
  {
    hexColliderTransform = gameObject.transform.GetChild(0);
    rb.rotation = Random.Range(0f, 360f);
    transform.localScale = Vector3.one * startScale;
    SetLineWidth(initialWidth);
    ScaleCollider(initialWidth, startScale);
  }

  void Update()
  {
    transform.localScale -= Vector3.one * shrinkSpeed * Time.deltaTime;
    float xScale = transform.localScale.x;

    // calculate line width from scale
    float lineWidth = mapRange(xScale, startScale, endScale, initialWidth, finalWidth);
    SetLineWidth(lineWidth);
    ScaleCollider(lineWidth, xScale);

    if (xScale < endScale)
    {
      Destroy(gameObject);
    }
  }

  void SetLineWidth(float width)
  {
    lr.startWidth = width;
    lr.endWidth = width;
  }

  void ScaleCollider(float lineWidth, float xScale)
  {
    float scale = -(0.6f / xScale) * lineWidth + 1;
    hexColliderTransform.localScale = Vector3.one * scale;
  }

  private float mapRange(float value, float a1, float a2, float b1, float b2)
  {
    return b1 + (value - a1) * (b2 - b1) / (a2 - a1);
  }
}
