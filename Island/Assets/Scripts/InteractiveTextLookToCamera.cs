using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveTextLookToCamera : MonoBehaviour
{
    [SerializeField] private Camera _mainCamera;
    
    private void LateUpdate()
    {
        LookAtCamera();
    }
    private void LookAtCamera()
    {
        transform.LookAt(new Vector3(transform.position.x, _mainCamera.transform.position.y, _mainCamera.transform.position.z));
    }
}
