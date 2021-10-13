using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickAudio : MonoBehaviour
{
	public static event Action clicked;

	public void Update()
		{
		if (Input.GetKey(KeyCode.Space)) 
			{
			clicked?.Invoke();
			}
		}
	}
