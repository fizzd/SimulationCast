using UnityEngine;
using System.Collections;

public class SyncProperties : Photon.PunBehaviour
{



	// Use this for initialization
	void Start ()
	{
	
	}


	public void ModeratorPushUpdates ()
	{
		//push updates
		photonView.RPC ("SyncFromModerator", PhotonTargets.All, new object[] {
			GC.vitalsModeratorNum,
			GC.situationText,
			GC.gameStatus
		});

	}



	// A PUN RPC.
	// RPCs are only executed on the same GameObject that was used to call it.
	// RPCs can be implemented as Coroutine, which is here used to flash the emissive color.
	[PunRPC]
	private void SyncFromModerator (int[] vitals, string situation, GameStatus gameStatus)
	{
		GC.vitalsNum = vitals;
		GC.situationText = situation;
		GC.gameStatus = gameStatus;

	}



}
