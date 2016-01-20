using UnityEngine;
using System.Collections;

public class VAF : MonoBehaviour 
{
	public int Pizza = 4000000;

	// Use this for initialization
	void Update () 
	{
		Pizza = DivideByTwo(Pizza);
		Debug.Log (Pizza);
	}

	int DivideByTwo (int number)
	{
		int ret;
		ret = number / 8;
		return ret;
	}
}