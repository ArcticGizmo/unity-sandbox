using UnityEngine;
using UnityEngine.UI;

public class DistanceScore : MonoBehaviour
{
  public Text text;
  public Transform target;
  public int score = 0;
  public int scoreScale = 1;

  private Vector3 initialPosition;

  void Start()
  {
    initialPosition = target.position;
  }

  // Update is called once per frame
  void Update()
  {
    float distance = Vector3.Distance(initialPosition, target.position);
    score = (int)(distance * scoreScale);
    text.text = score.ToString();
  }
}
