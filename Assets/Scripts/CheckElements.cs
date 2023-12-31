using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CheckElements : MonoBehaviour
{
    [SerializeField] private int numberOfElements; //3
    private int numberOfElementsInSocket = 0;

    [SerializeField] bool cursorActive = true;

    [Header("Unity Events")]
    public UnityEvent unlock;
    public UnityEvent hideTaskDescription;
    public UnityEvent showNextLevelUI;

    [Header("UI Components")]
    [SerializeField] Canvas nextLevelUI;
    [SerializeField] Canvas taskDescription;


    private void Start()
    {
        if (cursorActive)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }


    public void AddElementInSocket()
    {
        numberOfElementsInSocket++;
        CheckNumberOfElements(); 
    }

    private void CheckNumberOfElements()
    {
        if (numberOfElementsInSocket == numberOfElements)
        {
            hideTaskDescription.Invoke();
            showNextLevelUI.Invoke();
            unlock.Invoke();
        }
    }
}