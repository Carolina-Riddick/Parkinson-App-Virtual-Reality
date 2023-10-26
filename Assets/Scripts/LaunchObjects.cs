using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class LaunchObjects : MonoBehaviour
{
    public float launchForce = 5.0f;

    [Header("Audio")]
    public AudioClip audioClip;
    public AudioSource audioSource;

    public void OnSelectExit(XRBaseInteractor interactor)
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        if (rb != null)
        {
            Vector3 launchDirection = interactor.transform.forward;
            rb.AddForce(launchDirection * launchForce, ForceMode.Impulse);
        }
    }

    public void PlayClip()
    {
        audioSource.PlayOneShot(audioClip);
    }
}