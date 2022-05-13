using UnityEngine;
using UnityEngine.UI;

public class LocationUpdate : MonoBehaviour
{
	public InputField inputField;
	private Text location;
	// Start is called before the first frame update
	void Start()
	{
		location = GetComponent<Text>();
	}

	public void updateLocation() {
		location.text = inputField.text;
		inputField.gameObject.SetActive(false);
	}
}
