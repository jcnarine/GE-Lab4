using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeText : MonoBehaviour
{
    public Text totalTime;

    // Start is called before the first frame update
    private void Start()
    {
        totalTime.text = "Time:" + PersistentManagerScript.Instance.CurrentTime.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        totalTime.text = "Time:" + PersistentManagerScript.Instance.CurrentTime.ToString();
    }
}
