using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class GoToGame : MonoBehaviour
{
	public Dropdown dd;



	// Use this for initialization
	void Start ()
	{
	
	}

	public void Gogogo ()
	{
		int ddvalue = dd.value;

		if (dd.value == 0)
		{
			GC.playersRole = Role.Moderator;

		}
		if (dd.value == 1)
			GC.playersRole = Role.Doctor;
		if (dd.value == 2)
			GC.playersRole = Role.Anaesthesist;
		if (dd.value == 3)
			GC.playersRole = Role.Nurse;
		
		SceneManager.LoadScene ("GameScene");


	}
	// Update is called once per frame
	void Update ()
	{
	
	}
}
