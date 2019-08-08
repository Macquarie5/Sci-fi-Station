using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {

    public bool doorOpened = false;
    private bool status;
    public DoorControl controlPanel;
    private Animator Anim;

	// Use this for initialization
	void Start () {

        status = controlPanel.GetComponent<DoorControl>().pressed;
        Anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {

        doorOpened = controlPanel.GetComponent<DoorControl>().pressed;
        if (doorOpened == true)
        {
            Anim.SetBool("Door Open", true);
        }
        else
        {
            Anim.SetBool("Door Open", false);
        }
		
	}
}
