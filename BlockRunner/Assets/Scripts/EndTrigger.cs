using UnityEngine;

public class EndTrigger : MonoBehaviour
{
  public GameManager gameManager;
  void OnTriggerEnter(Collider other)
  {
    Debug.Log("[EndTrigger] Collision");
    if (other.tag == "Player" && other.gameObject.activeSelf)
    {
      gameManager.CompleteLevel();
    }
  }
}
