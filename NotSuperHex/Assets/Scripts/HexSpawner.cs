using UnityEngine;

public class HexSpawner : MonoBehaviour
{
  public GameObject prefab;
  public float spawnRate = 1f;
  public int nCreated = 0;

  public float shrinkSpeed = 3f;

  public float startScale = 10f;
  public float endScale = 0.05f;

  public float initialWidth = 0.2f;
  public float finalWidth = 0.05f;


  private float nextTimeToSpawn = 0f;

  void Update()
  {
    if (Time.time >= nextTimeToSpawn)
    {
      CreateHexagon();
      nextTimeToSpawn = Time.time + 1 / spawnRate;
    }
  }

  void CreateHexagon()
  {
    nCreated += 1;
    Quaternion rotation = Quaternion.Euler(0f, 0f, Random.Range(0f, 360f));
    Hexagon hex = Instantiate(prefab, Vector3.zero, rotation).GetComponent<Hexagon>();

    hex.shrinkSpeed = shrinkSpeed;
    hex.startScale = startScale;
    hex.endScale = endScale;
    hex.initialWidth = initialWidth;
    hex.finalWidth = finalWidth;
  }
}
