﻿using UnityEngine;

public class Spin : MonoBehaviour 
{
	void Update () 
	{
		transform.Rotate(Vector3.up * Time.deltaTime * 40f);
	}
}