using UnityEngine;

public class CenterCamera : MonoBehaviour
{
  public GameObject target;

  public void Face()
  {
    transform.LookAt(target.transform, Vector3.up);
  }
}
