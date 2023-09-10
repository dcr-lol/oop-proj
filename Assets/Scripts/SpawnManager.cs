using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject spawn;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GenerateGamer());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    class GamerBase {
        public float speed = 1f;
        public Color color = Color.cyan;
        public virtual float getFavourtiteNumber() { 
            return Random.Range(0f, 100f);
        }
    }
    // INHERITANCE
    class Gamer1 : GamerBase {
        public string favouriteBand = "Yoko Ono";
        // POLYMORPHISM
        public override float getFavourtiteNumber() {
            return Random.Range(200f, 300f);
        }
    }

    class Gamer2 : GamerBase {
        public string favouriteFlower = "Daisy";
        // POLYMORPHISM
        public override float getFavourtiteNumber()
        {
            return Random.Range(500f, 600f);
        }
    }


    // ABSTRACTION
    GamerBase getNewGamer() {
        int randomNumber = Random.Range(0, 3);
        Debug.Log("RN");
        Debug.Log(randomNumber);
        switch (randomNumber)
        {
            case 0:
                return new GamerBase();
            case 1:
                return new Gamer1();
            case 2:
                return new Gamer2();
            default: 
                return new GamerBase();
        }
    }

    IEnumerator GenerateGamer()
    {
        while (true) { 
            GamerBase gamer = getNewGamer();
            Debug.Log($"speed: {gamer.speed}");
            Debug.Log($"color: {gamer.color}");
            Debug.Log($"favourtie Number: {gamer.getFavourtiteNumber()}");
            yield return new WaitForSeconds(3f);
        }
        
    }

}
