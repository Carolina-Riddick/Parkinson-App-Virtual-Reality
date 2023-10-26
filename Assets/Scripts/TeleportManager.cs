using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class TeleportManager : MonoBehaviour
{
    public InputActionReference teleportActionReference;

    public UnityEvent teleportOn;
    public UnityEvent teleportOff;

    private void Start()
    {
        teleportActionReference.action.performed += TeleportActivate;

        teleportActionReference.action.canceled -= TeleportCanceled;
    }

    private void TeleportActivate(InputAction.CallbackContext context)
    {
        teleportOn.Invoke();
    }


    void DelayedTeleportCancel()
    {
        teleportOff.Invoke();
    }


    private void TeleportCanceled(InputAction.CallbackContext context)
    {
        Invoke("DelayedTeleportCancel", 0.1f);
    }
}
