using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
  public HexSpawner spawner;

  public Text text;
  public int score = 0;

  private void Update()
  {
    score = spawner.nCreated;
    text.text = score.ToString();
  }

}
