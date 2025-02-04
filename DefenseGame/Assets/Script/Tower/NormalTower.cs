using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalTower : Tower
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

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
