using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class scrRoleText : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
		GetComponent<Text> ().text = GC.playersRole.ToString ();
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
}
