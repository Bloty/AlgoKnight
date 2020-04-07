using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ScriptGrid : MonoBehaviour
{
	public int columnLength, rowLength;
	public float x_space, y_space, x_start, y_start;
	public GameObject prefab;

	void Start()
	{
		for (int i = 0; i < columnLength * rowLength; i++)
		{
			Instantiate(prefab, new Vector3(x_start + (x_space * (i % columnLength)), y_start + (y_space * (i / columnLength)), 0), Quaternion.identity);
		}
	}
}
