using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleHealth : MonoBehaviour {
	public int health = 1;

	void OnTriggerEnter2D(Collider2D other) {
		Controller controller = other.GetComponent<Controller>();

		if (controller != null) {
			if (controller.Health < controller.maxHealth) {
				controller.ChangeHealth(health);
				Destroy(gameObject);
			}
		}
	}
}
