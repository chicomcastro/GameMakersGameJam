﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class F1Ender : MonoBehaviour {

	void OnTriggerEnter2D (Collider2D coll)
	{
		if (coll.tag == "Player")
			GameObject.FindGameObjectWithTag ("Manager").GetComponent<F1Manager> ().acabou = true;
	}
}
