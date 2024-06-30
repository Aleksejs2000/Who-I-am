using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;

public class MainMenuAnimations : MonoBehaviour
{
    [SerializeField] private float _transitionTime;
    [SerializeField] private float _curentTime = 0f;
    [SerializeField] private Animator _mainMenuAnimator;

    private void Update()
    {
        _curentTime += Time.deltaTime;
        if (_curentTime >= _transitionTime)

        {
            _mainMenuAnimator.SetTrigger("Animation2");
            _curentTime = 0f;
        }
        
                
    }
}
