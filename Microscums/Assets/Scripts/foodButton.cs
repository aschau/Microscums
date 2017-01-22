﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foodButton : MonoBehaviour
{
    //public string itemName = "";
    GameObject item, space1, space2, space3, control;
    public GameObject create, parent;
    public void Awake()
    {
       // itemName = this.name + "Button";
        space1 = GameObject.Find("First Space");
        space2 = GameObject.Find("Second Space");
        space3 = GameObject.Find("Third Space");
        parent = GameObject.Find("Items");
        control = GameObject.Find("microwaveControl");
    }
    public void Start()
    {

    }
	// Update is called once per frame
	void Update () {
		
	}

    public void onClick()
    {
        if (this.name == "cupNoodlesButton")
        {
            if (control.GetComponent<microControl>().space1 == false)
            {
                create = GameObject.Instantiate(create, space1.transform.position, Quaternion.identity, parent.transform);
                create.GetComponent<foodItem>().occupied = 1;
                control.GetComponent<microControl>().space1 = true;
            }
            else if (control.GetComponent<microControl>().space2 == false)
            {
                create = GameObject.Instantiate(create, space2.transform.position, Quaternion.identity, parent.transform);
                create.GetComponent<foodItem>().occupied = 2;
                control.GetComponent<microControl>().space2 = true;
            }
            else if (control.GetComponent<microControl>().space3 == false)
            {
                create = GameObject.Instantiate(create, space3.transform.position, Quaternion.identity, parent.transform);
                create.GetComponent<foodItem>().occupied = 3;
                control.GetComponent<microControl>().space3 = true;
            }
        }
        else if (this.name == "popcornButton" || this.name == "hotPocketButton")
        {
            if (control.GetComponent<microControl>().space1 == false && control.GetComponent<microControl>().space2 == false) {
                create = GameObject.Instantiate(create, space1.transform.position, Quaternion.identity, parent.transform);
                create.GetComponent<foodItem>().occupied = 12;
                control.GetComponent<microControl>().space2 = true;
                control.GetComponent<microControl>().space1 = true;
            }
            else if (control.GetComponent<microControl>().space2 == false && control.GetComponent<microControl>().space3 == false)
            {
                create = GameObject.Instantiate(create, space2.transform.position, Quaternion.identity, parent.transform);
                create.GetComponent<foodItem>().occupied = 23;
                control.GetComponent<microControl>().space2 = true;
                control.GetComponent<microControl>().space3 = true;
            }
        }
        else if (this.name == "tvDinnerButton")
        {
            if (control.GetComponent<microControl>().spaces == 3)
            {
                create = GameObject.Instantiate(create, space1.transform.position, Quaternion.identity, parent.transform);
                create.GetComponent<foodItem>().occupied = 123;
                control.GetComponent<microControl>().spaces = 0;
                control.GetComponent<microControl>().space1 = true;
                control.GetComponent<microControl>().space2 = true;
                control.GetComponent<microControl>().space3 = true;
            }
        }

        //whatever happens when the button gets clicked
    }

}
