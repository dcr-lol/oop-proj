using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager Instance;
    public SharedState sharedState = new SharedState();

    public void Awake()
    {
        if (Instance != null) { 
            
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }    
}

public class SharedState {
    private string _userName;
    // encapsulation
    public string userName { get {
            return this._userName;
        } set {
            _userName = value.Length >= 3 ? value : "";
        }
    }
}
