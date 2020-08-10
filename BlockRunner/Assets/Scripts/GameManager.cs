
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
  public float restartDelay = 2f;
  bool gameActive = true;
  public void EndGame()
  {
    if (gameActive)
    {
      Debug.Log("[GM] GAME OVER");
      gameActive = false;
      Invoke("Restart", restartDelay);
    }
  }

  public void Restart()
  {
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
  }
}
