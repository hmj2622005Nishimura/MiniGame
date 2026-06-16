using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class BallDelete : MonoBehaviour
{
	[SerializeField] GameObject ball;
	private void OnTriggerEnter2D(Collider2D collision)
	{
		// ‘Šè‚Ìƒ^ƒO‚ªBall‚È‚ç
		if (collision.gameObject.CompareTag("Ball"))
		{
			Destroy(collision.gameObject);
			Debug.Log("‚Ú[‚é‚¯‚·");
		}
	}
}
