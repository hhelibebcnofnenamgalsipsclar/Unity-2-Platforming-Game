using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerinfo : MonoBehaviour
{
    // Start is called before the first frame update
    public int score = 0;
    public int health=0;
    public List<Collectable> inventory;
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    
}
