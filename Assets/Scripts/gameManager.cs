using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{

    public static gameManager instance;// instance of game manager class

    
    public GameObject player;// player object accesible thorugh other classes
    public GameObject playerScript;// access to the player object's script

    // Start is called before the first frame update
    void Awake()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
