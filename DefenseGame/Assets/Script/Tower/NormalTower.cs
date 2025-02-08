using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalTower : Tower
{

	protected override void FireProjectile(Transform target)
    {
		if (target == null) return;

		GameObject projectile = Instantiate(projectilePrefab, firePoint.position, Quaternion.identity);
		Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
		if (rb != null)
		{
			Vector2 direction = (target.position - firePoint.position).normalized;
			rb.velocity = direction * projectileSpeed;
		}
	}


}
