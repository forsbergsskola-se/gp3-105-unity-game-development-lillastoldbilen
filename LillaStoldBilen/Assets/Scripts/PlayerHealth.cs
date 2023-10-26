﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerHealth : MonoBehaviour 
{
	public float health = 100f;

	public void TakeDamage(float damage)
	{
		health -= damage;
		Debug.Log("Health = " + health.ToString());
	}
}
