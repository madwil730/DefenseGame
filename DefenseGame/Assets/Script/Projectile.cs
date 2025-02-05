using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{

	public float Damage = 5;

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag("Wall") || other.CompareTag("Enemy") )
		{
			Destroy(this.gameObject);
		}
	}

}
