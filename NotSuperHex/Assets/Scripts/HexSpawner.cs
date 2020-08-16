using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexSpawner : MonoBehaviour
{
  public GameObject prefab;
  public float spawnRate = 1f;

  private float nextTimeToSpawn = 0f;

  void Update()
  {
    if (Time.time >= nextTimeToSpawn)
    {
      Instantiate(prefab, Vector3.zero, Quaternion.identity);
      nextTimeToSpawn = Time.time + 1 / spawnRate;
    }
  }
}
