using UnityEngine;

public class GoalController : MonoBehaviour
{
	[SerializeField] GameObject ball;
	[SerializeField] GameObject Goal;
	float speed = 0.1f;
	int time = 0;

	// Update is called once per frame
	private void OnTriggerEnter2D(Collider2D collision)
	{
		// ‘ŠŽè‚Ìƒ^ƒO‚ªBall‚È‚ç
		if (collision.gameObject.CompareTag("Ball"))
		{
			Destroy(collision.gameObject);
			Debug.Log("‚²[‚é");
		}
	}

	private void Start()
	{
		Application.targetFrameRate = 60;
	}
	private void Update()
	{
		time++;
		
		//if (time > 300)
		//{
		//	time = 0;
		//}
		//else
		//{
		//	speed = Random.Range(1,5);
		//}
		transform.Translate(0, this.speed/**Time.deltaTime*60*/, 0);
		if(transform.position.y < -5.0f || transform.position.y > 5.0f)
		{
			speed = this.speed * -1;
		}
	}
}
