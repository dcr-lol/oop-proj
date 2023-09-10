using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuUiManager : MonoBehaviour
{
    public TMP_InputField nameInput;
    public TMP_Text welcomeMessage;
    public Button continueButton;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetUserName() {
        Debug.Log(nameInput.text);
        GameManager.Instance.sharedState.userName = nameInput.text;
        welcomeMessage.text = $"Welcome to OOP {GameManager.Instance.sharedState.userName}";
        if (GameManager.Instance.sharedState.userName.Length > 2)
        {
            continueButton.image.color = Color.green;
        }
        else { 
            continueButton.image.color= Color.red;
        }

    }

    public void ContinueClick() {
        if (GameManager.Instance.sharedState.userName.Length > 2) {
            SceneManager.LoadScene(1);
        }
    }

}
