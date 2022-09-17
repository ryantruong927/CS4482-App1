using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubyController : MonoBehaviour {

    public float Speed = 3f;

    private Rigidbody2D rigidbody2d;
	private Vector2 input;


	// Start is called before the first frame update
	void Start() {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update() {
		input = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
	}

	void FixedUpdate() {
		Vector2 position = rigidbody2d.position; position += Speed * Time.deltaTime * input;

		position += Speed * Time.deltaTime * input;

		rigidbody2d.MovePosition(position);
	}
}
