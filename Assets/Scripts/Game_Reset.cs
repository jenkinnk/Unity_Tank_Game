﻿using UnityEngine;
using System.Collections;

public class Game_Reset : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.R))
        {
            Application.LoadLevel(0);
        }
	
	}
}
