using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainController : MonoBehaviour
{
    // Private object used to access the player controller
    private PlayerController player_controller;

    // Update is called once per frame
    void Update()
    {
        // Constantly moves the object forward and any child objects with it
        transform.Translate(Vector3.forward * Time.deltaTime * 9f);
    }

    // Called whenever the terrain collides with the destroyer object to clear old terrain
    void OnTriggerEnter(Collider other)
    {
        // Compares tag of the object the current object collided with
        if (other.CompareTag("Destroyer"))
        {
            // Calls destroy method on current object
            Destroy(this.gameObject);
        }

        // Checks if the players interact with an obstacle
        if (other.CompareTag("Player")) {
            Destroy(other.gameObject);
            GetComponent<Animator>().Play("explode");
        }
    }
}
