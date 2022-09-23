using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MrClockworkController : Controller {
    public bool isBroken = true;

    public float changeTime = 2f;
    private float changeTimer;

    public bool isGoingUpAndDown = false;

    public int damage = -1;

    protected override void Start() {
        base.Start();

        changeTimer = changeTime;

        if (isGoingUpAndDown)
            animator.SetFloat("Move X", 0);
        else
			animator.SetFloat("Move Y", 0);
	}

	protected override void Update() {
        if (!isBroken)
            return;

        base.Update();

        if (changeTimer > 0)
            changeTimer -= Time.deltaTime;
        else {
            changeTimer = changeTime;
            speed *= -1;
        }
	}

	private void FixedUpdate() {
		if (!isBroken)
			return;

		Vector2 position = rigidbody2D.position;

        if (isGoingUpAndDown) {
            animator.SetFloat("Move Y", speed);
            position.y += speed * Time.deltaTime;
		}
        else {
            animator.SetFloat("Move X", speed);
            position.x += speed * Time.deltaTime;
		}

		rigidbody2D.MovePosition(position);
	}

	public void Fix() {
		isBroken = false;
		rigidbody2D.simulated = false;
        animator.SetTrigger("Fixed");
	}

	private void OnCollisionStay2D(Collision2D other) {
		RubyController player = other.gameObject.GetComponent<RubyController>();

		if (player != null)
			player.ChangeHealth(damage);
	}
}
