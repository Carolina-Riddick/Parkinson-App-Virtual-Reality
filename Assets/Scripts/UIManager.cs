using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] Button _buttonOne;
    [SerializeField] Button _buttonTwo;
    [SerializeField] Button _buttonThree;
    public SceneManager SceneManager;

    private void Start()
    {
        //Hook events
       _buttonOne.onClick.AddListener(OnButtonOneClicked);
       _buttonTwo.onClick.AddListener(OnButtonTowClicked);
       _buttonThree.onClick.AddListener(OnButtonThreeClicked);
    }

    public void OnButtonOneClicked()
    {
        Scene scene = SceneManager.GetActiveScene();
        
        if (scene.name == "Gems" )
        {
            Debug.Log("You are here :)");
        } else
        {
            SceneManager.LoadScene(1); // Gems
        }
    }

    public void OnButtonTowClicked()
    {
        SceneManager.LoadScene(2); // Games
    }

    public void OnButtonThreeClicked()
    {
        SceneManager.LoadScene(0); // Back to the beginning 
    }
}