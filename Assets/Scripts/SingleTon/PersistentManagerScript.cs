using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PersistentManagerScript : MonoBehaviour
	{
	public static PersistentManagerScript Instance { get; private set; }

	public int CurrentTime=0;

	private void Awake()
		{

		if (Instance == null)
			{
			Instance = this;
			DontDestroyOnLoad(gameObject);
			}
		else { Destroy(gameObject); }

		}

	public void Update()
		{
		CurrentTime = (int)Time.time; 
		}


	}
