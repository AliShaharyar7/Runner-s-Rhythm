
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float speed = 10;
    public Rigidbody rb;

	float horizontalInput;
	public float horizontalMultiplier = 1.5f;
	private void FixedUpdate()
	{
		Vector3 forwardMove = transform.forward * speed * Time.fixedDeltaTime;
		Vector3 horizontalMove = transform.right * horizontalInput * horizontalMultiplier * speed * Time.fixedDeltaTime;
		rb.MovePosition(rb.position + forwardMove + horizontalMove);
	}
	// Update is called once per frame
	void Update()
    {
		horizontalInput = Input.GetAxis("Horizontal");
    }
}
