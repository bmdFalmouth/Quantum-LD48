﻿using UnityEngine;
using System.Collections;

public class ExitScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerStay(Collider c)
    {
        if (c.tag=="Player")
        {
            //Send Message to Level Manager
            Application.LoadLevel(0);
        }
    }
}