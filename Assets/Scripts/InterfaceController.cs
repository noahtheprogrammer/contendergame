using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InterfaceController : MonoBehaviour
{
    private PlayerController playercontroller;
    private Image boostbar;
    private Text speedtext;

    // Start is called before the first frame update
    void Start()
    {
        boostbar = GameObject.Find("ActiveBar").GetComponent<Image>();
        speedtext = GameObject.Find("Rate").GetComponent<Text>();
        playercontroller = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        boostbar.fillAmount = playercontroller.boost;
        speedtext.text = (int)(playercontroller.speed * 8f) + " MPH";
    }
}
