using UnityEngine;
using System.Collections;

public class OnlyShowIfRole : MonoBehaviour
{
	public Role role;

	// Use this for initialization
	void Start ()
	{
		if (GC.playersRole != role)
			this.gameObject.SetActive (false);
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
}
