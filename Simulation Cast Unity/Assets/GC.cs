using UnityEngine;
using System.Collections;

public enum Role
{
	Moderator,
	Nurse,
	Anaesthesist,
	Doctor}

;

public class GC : MonoBehaviour
{


	public static Role playersRole;

	public static int startingTime;
	public static string situationText;


}
