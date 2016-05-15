using UnityEngine;
using System.Collections;

public enum Role
{
	Moderator,
	Nurse,
	Anaesthesist,
	Doctor
}


public enum GameStatus
{
	Prestart,
	Normal,
	Died,
	Stable}

;

public class GC : MonoBehaviour
{
	public static Role playersRole;
	public static GameStatus gameStatus;

	public static int startingTime;
	public static string situationText;

	public static int[] vitalsNum;
	public static int[] vitalsModeratorNum;
	public static string[] vitalsName;



}
