﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class END : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D coll)
	{
		if (coll.tag == "Player") {
			GameObject.FindGameObjectWithTag ("Manager").GetComponent<LevelManager> ().acabou = true;
		}
	}

}