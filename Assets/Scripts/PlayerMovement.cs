using UnityEngine;
using UnityEngine.Events;

public class PlayerMovement : MonoBehaviour
{
	public PlayerController controller;
	[SerializeField] private float runSpeed = 40f;
	
	private float horizontalMove = 0f;
	private bool jump = false;
	private bool dash = false;
	private Animator animator;

	void Start() {
		animator = gameObject.GetComponent<Animator>();
	}

	void Update()
	{
		horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
		if (Input.GetButtonDown("Jump")) {
			jump = true;
			animator.SetBool("Jump", true);
		}
		if (Input.GetKeyDown(KeyCode.LeftShift)) {
			dash = true;
		}
	}

	void FixedUpdate()
	{
		controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump, dash);
		animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
		jump = false;
		dash = false;
	}

	public void OnLanding() {
		animator.SetBool("Jump", false);
	}
}
