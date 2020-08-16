
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
  public void RestartScene()
  {
    Debug.Log("[GM] Restarting scene");
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
  }

  public void ToMenu()
  {
    ToScene("Menu");
  }

  public void ToGame()
  {
    ToScene("Game");
  }

  public void ToScene(string name)
  {
    Debug.Log($"[GM] To scene '{name}'");
    SceneManager.LoadScene(name);
  }

  public void Quit()
  {
    Debug.Log("[GM] Quitting application");
    Application.Quit();
  }
}
