using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
  public float moveSpeed = 600f;

  private float movement = 1f;

  void Update()
  {
    movement = Input.GetAxisRaw("Horizontal");
  }

  private void FixedUpdate()
  {
    transform.RotateAround(Vector3.zero, Vector3.forward, movement * Time.fixedDeltaTime * -moveSpeed);
  }

  private void OnTriggerEnter2D(Collider2D other)
  {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
  }
}
