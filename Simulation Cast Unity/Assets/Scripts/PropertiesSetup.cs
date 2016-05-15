using UnityEngine;
using System.Collections;

public class PropertiesSetup : MonoBehaviour
{

	// Use this for initialization
	void Awake ()
	{
		GC.vitalsName = new string[]{ "Heart Rate", "Oxygen Saturation", "Blood Pressure S", "Blood Pressure D" };
		GC.vitalsModeratorNum = new int[]{ 0, 0, 0, 0 };
		GC.vitalsNum = new int[]{ 0, 0, 0, 0 };
		GC.gameStatus = GameStatus.Prestart;
	}
	
	// Update is called once per frame
	void Update ()
	{



	
	}
}
