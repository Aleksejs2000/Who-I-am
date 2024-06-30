using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.UI;

public class DialogButtonTextSkip : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _dialogText;
    [SerializeField] private List<string> _firstDialog = new List<string>();
    [SerializeField] private InputSustem _characterMovementScript;
    [SerializeField] private GameObject _dailogBar;
    private int _currentDialogIndex = 0;

    private void Start()
    {
        
        DisplayCurrentDialog();
    }

    

    public void OnNextButtonClick()
    {
        NextDialog();
    }

    private void NextDialog()
    {
        if (_currentDialogIndex < _firstDialog.Count - 1)
        {
            // Увеличиваем индекс для следующего диалога и отображаем его.
            _currentDialogIndex++;
            DisplayCurrentDialog();
            
        }
        else
        {
            // Достигнут конец диалогов.
            _dailogBar.SetActive(false);
            Debug.Log("Диалог завершен.");
            EnableCharacterMovement();
        }
    }

    private void DisplayCurrentDialog()
    {
        DisableCharacterMovement();
        _dialogText.text = _firstDialog[_currentDialogIndex];
    }

    private void DisableCharacterMovement()
    {
        _characterMovementScript.enabled = false;
    }

    private void EnableCharacterMovement()
    {
        _characterMovementScript.enabled = true;
    }
}

