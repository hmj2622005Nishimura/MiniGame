using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class ballController : MonoBehaviour
{

	
	//private void OnCollisionEnter(Collision collision)
	//{
	//	GetComponent<Rigidbody>().isKinematic = true;
	//}
	// Start is called once before the first execution of Update after the MonoBehaviour is created	
	//private void Update()
	//{
	//	if (Mouse.current.leftButton.wasPressedThisFrame)
	//	{
	//		this.MoveSpeed = -0.2f;

	//	}
	//	//transform.Translate(this.MoveSpeed, 0, 0);
	//	this.MoveSpeed *= 0.99f;
	//}
	public void Shoot(Vector2 dir)
	{
		GetComponent<Rigidbody2D>().AddForce(dir);
		Debug.Log("kkkkkkkk");
	}
	private void Start()
	{
		Application.targetFrameRate = 60;
		//if (Mouse.current.leftButton.wasPressedThisFrame)
		//{
		//	Shoot(new Vector2(MoveSpeed, 0));
		//}
	}
	//private void Update()
	//{
	//	if (Mouse.current.leftButton.wasPressedThisFrame)
	//	{
	//		Shoot(new Vector2(MoveSpeed, 0));
	//	}
	//}
}
