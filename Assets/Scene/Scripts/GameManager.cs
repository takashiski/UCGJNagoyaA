using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public static int life = 3;
	public static float postTime = 0;
	public static Vector3 pos = Vector3.zero;
	public static int deathTime = 0;

	public static void resetParam()
	{
		life = 3;
		postTime = 0;
		pos = Vector3.zero;
		deathTime = 0;
	}
}
