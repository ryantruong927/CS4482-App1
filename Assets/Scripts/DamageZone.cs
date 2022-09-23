using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageZone : MonoBehaviour {
	public int damage = -1;

	private void OnTriggerStay2D(Collider2D other) {
		Controller controller = other.GetComponent<Controller>();

		if (controller != null)
			controller.ChangeHealth(damage);
		
	}
}
