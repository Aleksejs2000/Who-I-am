using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveTriggerEnter : MonoBehaviour
{
    [SerializeField] private Canvas _interactiveCanvas;

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _interactiveCanvas.gameObject.SetActive(true);
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _interactiveCanvas.gameObject.SetActive(false);
        }
    }


}
