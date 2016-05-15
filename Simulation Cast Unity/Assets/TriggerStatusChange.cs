using UnityEngine;
using System.Collections;

public class TriggerStatusChange : MonoBehaviour
{

	public GameStatus stat;
	public SyncProperties sp;

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	public void OnClick ()
	{
		GC.gameStatus = stat;
		sp.ModeratorPushUpdates ();

	}
}
