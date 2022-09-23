using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Variables used to store vehicle speed and boost
    public float speed;
    public float boost;

    // Start is called before the first frame update
    void Start() {

        // Starts coroutines used within the vehicle
        StartCoroutine(BoostChange());
    }

    // Update is called once per frame
    void Update()
    {

        // Conditional statements used to determine what vehicle function to initiate
        if(!Input.GetKey("w")) {
            transform.Translate(Vector3.back * Time.deltaTime * speed);
            VelocityChange(false, 0.25f);
        }

        if(Input.GetKey("b") && (boost >= 1f)) {
            speed = speed + 3f;
            boost = 0f;
        }

        if (Input.GetKey("w"))
        {
            transform.Translate(Vector3.back * Time.deltaTime * speed);
            VelocityChange(true, 0f);
        }

        else if (Input.GetKey("s")) {
            VelocityChange(false, 0.8f);
        }

        if (Input.GetKey("a")) {
            transform.Rotate(0f, -1.5f, 0f);
        }
        else if (Input.GetKey("d")) {
            transform.Rotate(0f, 1.5f, 0f);
        }
    }

    // Public method called whenever the controls are pressed or whenever a collision occurs
    public void VelocityChange(bool increasespeed, float brakingforce)
    {
        if (increasespeed) {
            if (speed < 12f)
            {
                speed = speed + (speed/2);
            }
        }
        else {
            if (speed > 1f) {
                speed = speed - brakingforce;
            }
        }
    }

    // Private IEnumerator called to increment boost amount
    private IEnumerator BoostChange() 
    {
        while (true) {
            boost = boost + 0.1f;
            yield return new WaitForSeconds(1f);
        }
    }
}