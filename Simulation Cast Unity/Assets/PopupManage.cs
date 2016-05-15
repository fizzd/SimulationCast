using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PopupManage : MonoBehaviour
{
	
	public GameObject panelGO;
	public Text statusText;

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		string _statusText = "";
		if (GC.gameStatus == GameStatus.Prestart && GC.playersRole != Role.Moderator)
			_statusText = "Moderator is setting up.. Get Ready!";
		if (GC.gameStatus == GameStatus.Died)
			_statusText = "Patient has died.";
		if (GC.gameStatus == GameStatus.Stable)
			_statusText = "Patient has stabilised!";



		if (GC.gameStatus == GameStatus.Normal || (GC.gameStatus == GameStatus.Prestart && GC.playersRole == Role.Moderator))
		{
			panelGO.SetActive (false);
		}
		else
			panelGO.SetActive (true);


		statusText.text = _statusText;
	}
}
