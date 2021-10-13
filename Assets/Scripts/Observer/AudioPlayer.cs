using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    private AudioSource _audioSource;

	private void Awake()
		{
        _audioSource = GetComponent<AudioSource>();
		}

	private void OnEnable()
		{
		ClickAudio.clicked += PlayAudio;
		}

	private void OnDisable()
		{
		ClickAudio.clicked -= PlayAudio;
		}

	private void PlayAudio() {
		_audioSource.Play();
		}
	}
