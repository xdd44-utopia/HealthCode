using System;
using UnityEngine;
using UnityEngine.UI;

public class CurTime : MonoBehaviour
{
	private Text timeText;
	// Start is called before the first frame update
	void Start()
	{
		timeText = GetComponent<Text>();
	}

	// Update is called once per frame
	void Update()
	{
		DateTime localTime = DateTime.Now;
		string[] timeStr = new string[5]{
			localTime.Month.ToString(),
			localTime.Day.ToString(),
			localTime.Hour.ToString(),
			localTime.Minute.ToString(),
			localTime.Second.ToString()
		};
		for (int i=0;i<5;i++) {
			if (timeStr[i].Length == 1) {
				timeStr[i] = "0" + timeStr[i];
			}
		}
		timeText.text = timeStr[0] + "-" + timeStr[1] + " " + timeStr[2] + ":" + timeStr[3] + ":" + timeStr[4];
	}
}
