using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Variables used to store vehicle speed and boost
    public float speed = 3f;
    public float boost;

    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("a")) {
            transform.Translate(Vector3.left * Time.deltaTime);
        }
        else if (Input.GetKey("d")) {
            transform.Translate(Vector3.left * Time.deltaTime);
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