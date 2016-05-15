using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class scrVital : MonoBehaviour
{

	public int id;
	public Text vitalText;
	public Text vitalValue;

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		{
			vitalText.text = GC.vitalsName [id];
			vitalValue.text = GC.vitalsNum [id].ToString ();
		}
	}
}
