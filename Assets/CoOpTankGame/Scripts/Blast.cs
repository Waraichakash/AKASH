﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blast : MonoBehaviour {

    float timer;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;

        if (timer>=0.6f)
        {
            Destroy(gameObject);
        }

    }
}
