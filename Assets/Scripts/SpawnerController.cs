using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour
{
    [SerializeField] private GameObject prefab;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnItems());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnItems() {
        while (true) {
            Instantiate(prefab);
            yield return new WaitForSeconds(2f);
        }
    }
}