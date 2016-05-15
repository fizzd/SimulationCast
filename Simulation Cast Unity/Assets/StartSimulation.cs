using UnityEngine;
using System.Collections;

public class StartSimulation : MonoBehaviour
{
	public SyncProperties sp;

	// Use this for initialization
	void Start ()
	{
	
	}

	public void OnClick ()
	{
		GC.gameStatus = GameStatus.Normal;
		gameObject.SetActive (false);
		sp.ModeratorPushUpdates ();
	}
}
