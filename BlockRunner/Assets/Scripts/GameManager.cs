
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
  public float restartDelay = 2f;
  public GameObject completeLevelUI;
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

  public void CompleteLevel()
  {
    Debug.Log("[GM] Level complete");
    completeLevelUI.SetActive(true);
  }

  public void Restart()
  {
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
  }
}
