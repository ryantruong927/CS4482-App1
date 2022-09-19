using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubyController : Controller {
	private Vector2 input;

    protected override void Update() {
		base.Update();

		input = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
	}

	void FixedUpdate() {
		Vector2 position = rigidbody2D.position;
		position += speed * Time.deltaTime * input;

		position += speed * Time.deltaTime * input;

		rigidbody2D.MovePosition(position);
	}
}
