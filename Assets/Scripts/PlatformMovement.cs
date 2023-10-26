using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.ProBuilder.Shapes;
using UnityEngine.WSA;

public class PlatformMovement : MonoBehaviour
{
    [Header("Game Object Components")]
    [SerializeField] GameObject[] wayPoints;
    int indexWayPoint = 0;
    public float platformSpeed = 2f;

    [Header("UI Components")]
    [SerializeField] Canvas congratulationsUI;
    [SerializeField] Canvas gemsChildUI;
    int total = 0;
    [SerializeField] TMP_Text gemsValueUI;

    private void Start()
    {
        congratulationsUI.enabled = false;
        gemsChildUI.enabled = false;
    }

    void Update() { MovePlatform(); }

    void MovePlatform()
    {
        if (Vector3.Distance(transform.position, wayPoints[indexWayPoint].transform.position) < 0.1f)
        {
            indexWayPoint++;

            if (indexWayPoint >= wayPoints.Length)
            {
                indexWayPoint = 0;
            }
        }
        transform.position = Vector3.MoveTowards(transform.position, wayPoints[indexWayPoint].transform.position, platformSpeed * Time.deltaTime);
    }

    // nos da la colision con la cual colisiono el objeto
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Gems"))
        {
            collision.gameObject.transform.SetParent(transform, true);
            collision.transform.SetParent(transform, true);
            //collision.rigidbody.Sleep();

            getFiftyPoints();
        }
    }

    public void getFiftyPoints()
    {
        total += 10;
        gemsChildUI.enabled = true;
        gemsValueUI.text = $" Score:{total}";
        if (total == 50)
        {
            congratulationsUI.enabled = true;
        }
    }
}