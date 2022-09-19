using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MrClockworkController : Controller {
    public float changeTime = 2f;
    private float changeTimer;

    public bool isGoingUpAndDown = false;

    public int damage = -1;

    protected override void Start() {
        base.Start();

        changeTimer = changeTime;
    }

    protected override void Update() {
        base.Update();

        if (changeTimer > 0)
            changeTimer -= Time.deltaTime;
        else {
            changeTimer = changeTime;
            speed *= -1;
        }
	}

	void FixedUpdate() {
		Vector2 position = rigidbody2D.position;

        if (isGoingUpAndDown)
            position.y += speed * Time.deltaTime;
		else
			position.x += speed * Time.deltaTime;

		rigidbody2D.MovePosition(position);
	}

	void OnCollisionEnter2D(Collision2D other) {
		RubyController player = other.gameObject.GetComponent<RubyController>();

		if (player != null)
			player.ChangeHealth(damage);
	}
}
