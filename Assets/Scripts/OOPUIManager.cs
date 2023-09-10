using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class OOPUIManager : MonoBehaviour
{
    public TMP_Text playerText;
    // Start is called before the first frame update
    void Start()
    {
        playerText.text = $"Player Name: {GameManager.Instance.sharedState.userName}";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
