using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenseDownTower : Tower
{
	private Projectile projectile;
	[HideInInspector]
	public float DefenceDamage;

	protected override void FireProjectile(Transform target)
	{
		if (target == null) return;

		projectile = Instantiate(projectilePrefab, firePoint.position, Quaternion.identity).GetComponent<Projectile>();
		Init(projectile);
		Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
		if (rb != null)
		{
			Vector2 direction = (target.position - firePoint.position).normalized;
			rb.velocity = direction * projectileSpeed;
		}
	}

	public void Init(Projectile projectile)
	{
		projectile.Damage = Damage;
		projectile.DefenceDamage = DefenceDamage;
	}
}
