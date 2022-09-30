using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainController : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * 9f);
    }

    // Called whenever the terrain collides with the destroyer object to clear old terrain
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Destroyer"))
        {
            Destroy(this.gameObject);
        }
    }
}
