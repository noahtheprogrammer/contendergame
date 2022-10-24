using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    // Serializable objects used for individual player controls
    [SerializeField] private GameObject player_one;
    [SerializeField] private GameObject player_two;
    public int remaining_players = 2;

    // Update is called once per frame
    void Update()
    {
        // This if-else statement moves player one's vehicle
        if (Input.GetKey("a")) {
            player_one.transform.Translate(Vector3.left * Time.deltaTime * 2f);
        }
        else if (Input.GetKey("d")) {
            player_one.transform.Translate(Vector3.right * Time.deltaTime * 2f);
        }

        // This if-else statement moves player two's vehicle
        if (Input.GetKey(KeyCode.LeftArrow)) {
            player_two.transform.Translate(Vector3.left * Time.deltaTime * 2f);
        }
        else if (Input.GetKey(KeyCode.RightArrow)) {
            player_two.transform.Translate(Vector3.right * Time.deltaTime * 2f);
        }

        // This checks if any players are left and can change the scene 
        if (remaining_players == 0) {
            // SceneManager.LoadScene("Over");
        }
    }
}