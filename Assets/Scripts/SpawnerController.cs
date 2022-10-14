using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour
{
    // Private serializable object used for terrain generation
    [SerializeField] private GameObject terrain;

    // Private serializable object array used for obstacle generation
    [SerializeField] private GameObject[] obstacles;

    // Start is called before the first frame update
    void Start()
    {
        // Starts the repeating coroutine to generate terrain and obstacles
        StartCoroutine(GenerateLand());
    }

    // IEnumerator called once and repeated every 0.78 seconds
    IEnumerator GenerateLand() {
        int i = 0;
        while (true) {
            Instantiate(terrain);
            Instantiate(obstacles[i], new Vector3(Random.Range(-2,2), 0.44f, -92), Quaternion.identity);
            yield return new WaitForSeconds(0.78f);
            // i = Random.Range();
        }
    }
}