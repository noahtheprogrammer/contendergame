using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    // Private objects used for individual player controls
    private GameObject player_one;
    private GameObject player_two;

    // Start is called before the first frame update
    void Start() 
    {
        player_one = GameObject.Find("PlayerOne");
        player_two = GameObject.Find("PlayerTwo");
    }

    // Update is called once per frame
    void Update()
    {
        // Checks whether player one's vehicle can still be operated
        if (player_one) 
        {
            // This if-else statement moves player one's vehicle
            if (Input.GetKey("a")) {
                player_one.transform.Translate(Vector3.left * Time.deltaTime * 2f);
            }
            else if (Input.GetKey("d")) {
                player_one.transform.Translate(Vector3.right * Time.deltaTime * 2f);
            }
        }

        // Checks whether player two's vehicle can still be operated
        if (player_two) 
        {
            // This if-else statement moves player two's vehicle
            if (Input.GetKey(KeyCode.LeftArrow)) {
                player_two.transform.Translate(Vector3.left * Time.deltaTime * 2f);
            }
            else if (Input.GetKey(KeyCode.RightArrow)) {
                player_two.transform.Translate(Vector3.right * Time.deltaTime * 2f);
            }
        }

        
    }
}