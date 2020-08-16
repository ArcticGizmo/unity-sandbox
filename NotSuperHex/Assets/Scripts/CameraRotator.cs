using UnityEngine;

public class CameraRotator : MonoBehaviour
{
  public float rotationRate = 30f;

  private void Start()
  {
    transform.LookAt(Vector3.zero, Vector3.up);
  }

  void Update()
  {
    transform.Rotate(Vector3.forward, Time.deltaTime * rotationRate);
  }
}
