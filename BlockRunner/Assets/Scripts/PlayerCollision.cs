using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
  public PlayerController playerController;
  void OnCollisionEnter(Collision other)
  {
    if (other.collider.tag == "Obstacle")
    {
      playerController.enabled = false;
      FindObjectOfType<GameManager>().EndGame();
    }
  }
}
