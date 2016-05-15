using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class scrDisableIfDropdownNotModerator : MonoBehaviour
{
	public Dropdown dd;
	public GameObject go;

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (dd.value != 0)
			go.SetActive (false);
		else
			go.SetActive (true);
	}
}
