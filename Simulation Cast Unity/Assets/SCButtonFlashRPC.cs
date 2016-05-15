using System.Collections;
using UnityEngine;
using UnityEngine.UI;


public class SCButtonFlashRPC : Photon.PunBehaviour
{
	private Material originalMaterial;
	private Color originalColor;
	public Image boxImage;
	private bool isFlashing;

	// called by InputToEvent.
	// we use this GameObject's PhotonView to call an RPC on all clients in this room.
	public void OnClick ()
	{
		photonView.RPC ("Flash", PhotonTargets.All);
	}


	// A PUN RPC.
	// RPCs are only executed on the same GameObject that was used to call it.
	// RPCs can be implemented as Coroutine, which is here used to flash the emissive color.
	[PunRPC]
	private IEnumerator Flash ()
	{

		//this.originalColor = this.originalMaterial.GetColor ("_Emission");
		//this.originalMaterial.SetColor ("_Emission", Color.white);
		boxImage.color = Color.white;

		for (float f = 0.0f; f <= 1.0f; f += 0.08f)
		{
			Color lerped = Color.Lerp (Color.white, this.originalColor, f);
			//this.originalMaterial.SetColor ("_Emission", lerped);
			boxImage.color = lerped;
			yield return null;
		}
	}
}