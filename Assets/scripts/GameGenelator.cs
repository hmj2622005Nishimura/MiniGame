using UnityEngine;
using TMPro;

public class GameGenelator : MonoBehaviour
{
	float time = 10.0f;
	int score = 0;
	[SerializeField] GameObject timeTEXT;
	[SerializeField] GameObject scoreTEXT;
	[SerializeField] GameObject BallCon;

	public void GetGoal()
	{
		score += 1000;
	}

	// Update is called once per frame
	void Update()
    {
		time -= Time.deltaTime;
		timeTEXT.GetComponent<TextMeshProUGUI>().text = time.ToString("F1");
		scoreTEXT.GetComponent<TextMeshProUGUI>().text = score.ToString() + "score";
		if(time < 0)
		{
			time = 0;
		}
	}
}
