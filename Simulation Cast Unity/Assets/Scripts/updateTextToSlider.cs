using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class updateTextToSlider : MonoBehaviour
{
	public int id;
	public Slider slider;
	public Text text;

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// updates text and the value to be pushed
	void Update ()
	{
		int sliderInt = Mathf.FloorToInt (slider.value);
		text.text = sliderInt.ToString ();
		GC.vitalsModeratorNum [id] = sliderInt;
	}
}
