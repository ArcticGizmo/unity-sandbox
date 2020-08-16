using UnityEngine;

public class Hexagon : MonoBehaviour
{

  public Rigidbody2D rb;

  public float shrinkSpeed = 3f;
  public float startScale = 10f;
  public float destroyAtScale = 0.05f;
  
  void Start()
  {
    rb.rotation = Random.Range(0f, 360f);
    transform.localScale = Vector3.one * startScale;
  }

  void Update()
  {
    transform.localScale -= Vector3.one * shrinkSpeed * Time.deltaTime;

    if (transform.localScale.x < destroyAtScale)
    {
      Destroy(gameObject);
    }
  }
}
