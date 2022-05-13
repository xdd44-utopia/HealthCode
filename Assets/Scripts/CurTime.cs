using System;
using UnityEngine;
using UnityEngine.UI;

public class CurTime : MonoBehaviour
{
	public bool live;
	private Text timeText;
	// Start is called before the first frame update
	void Start()
	{
		timeText = GetComponent<Text>();
		updateTime();
	}

	// Update is called once per frame
	void Update()
	{
		if (live) {
			updateTime();
		}
	}

	void updateTime() {
		DateTime localTime = DateTime.Now;
		string[] timeStr = new string[6]{
			localTime.Year.ToString(),
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
		// timeText.text = timeStr[1] + "-" + timeStr[2] + " " + timeStr[3] + ":" + timeStr[4] + ":" + timeStr[5]; //常州场所码 
		timeText.text = timeStr[0] + "." + timeStr[0] + "." + timeStr[1] + " " + timeStr[2] + ":" + timeStr[3] + ":" + timeStr[4]; //行程码
	}
}
