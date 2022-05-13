using UnityEngine;
using UnityEngine.UI;

public class TextMovement : MonoBehaviour
{
	private int mostPosition = 1650;
	private float speed = -2f;
	private float cur = 0;
	void Update()
	{
		GetComponent<RectTransform>().anchoredPosition = new Vector2(cur, 1089.8f);
		cur += speed;
		if (cur <= -mostPosition) {
			cur = mostPosition;
		}
	}
}
