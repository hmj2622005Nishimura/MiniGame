using UnityEngine;
using UnityEngine.InputSystem;

public class BallGenerator : MonoBehaviour
{
	[SerializeField] GameObject ballPrefab;
	float MoveSpeed = 0;

	private void Update()
	{
		if(Mouse.current.rightButton.wasPressedThisFrame)
		{
			GameObject ball = Instantiate(ballPrefab);
			MoveSpeed = -1000;
			ball.GetComponent<ballController>().Shoot(new Vector2(MoveSpeed, 30));
		}	
	}
}
