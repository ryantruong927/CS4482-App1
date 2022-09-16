using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubyController : MonoBehaviour {

    public float Gravity = 0.1f;
    public float Speed = 10f;


    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
		Vector2 input = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
		Vector2 position = transform.position;
		position += input * Speed * Time.deltaTime;
		transform.position = position;
	}
}
