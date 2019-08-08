using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorControl : MonoBehaviour {

    public bool pressed = false;
    private Light indicator;

	// Use this for initialization
	void Start () {

        indicator = GetComponentInChildren<Light>();
        indicator.color = Color.red;
		
	}
	
	// Update is called once per frame
	void Update () {

        if (pressed)
        {
            indicator.color = Color.green;
        }
        else
        {
            indicator.color = Color.red;
        }
		
	}
}
