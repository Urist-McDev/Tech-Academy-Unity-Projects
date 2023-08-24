using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class win_detection : MonoBehaviour
{
    public Text winText;
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            winText.gameObject.SetActive(true);
        }
    }
}
