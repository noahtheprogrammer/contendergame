using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InterfaceController : MonoBehaviour
{
    private PlayerController playercontroller;
    private Image boostbar;

    // Start is called before the first frame update
    void Start()
    {
        boostbar = GameObject.Find("ActiveBar").GetComponent<Image>();
        playercontroller = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        boostbar.fillAmount = playercontroller.boost;
    }
}
