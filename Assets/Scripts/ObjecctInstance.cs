using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjecctInstance : MonoBehaviour
{
    [SerializeField] GameObject[] flies;
    [SerializeField] float spawnTime = 0.7f;
    [SerializeField] float minTransform;
    [SerializeField] float maxTransform;

    private void Start()
    {
        StartCoroutine(SpawnFlies());
    }
    IEnumerator SpawnFlies()
    {
        while (true)
        {
            var spawnPosition = Random.RandomRange(minTransform, maxTransform);
            var positionSpawn = new Vector3(spawnPosition, transform.position.y);
            GameObject go = Instantiate(flies[Random.Range(0, flies.Length)], positionSpawn, Quaternion.identity);
            yield return new WaitForSeconds(spawnTime);
            Destroy(go, 5f);
        }
    }
}
