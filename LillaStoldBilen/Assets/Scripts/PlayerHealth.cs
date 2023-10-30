using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerHealth : MonoBehaviour
{
	public float health = 100f;

	public void TakeDamage(float damage)
	{
		health -= damage;
		Debug.Log("Health = " + health.ToString());
	}
}
