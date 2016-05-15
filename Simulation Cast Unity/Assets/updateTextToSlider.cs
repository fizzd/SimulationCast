using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class updateTextToSlider : MonoBehaviour
{

	public Slider slider;
	public Text text;

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		text.text = slider.value.ToString ();
	}
}
