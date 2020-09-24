using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : Collectable
{
    // Start is called before the first frame update
    private void Start()
    {
        collectableName = "coin";
        description = "increases score by 10";
        //DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    public override void Use()
    {
        player.GetComponent<playerManager>().ChangeScore(10);
    }
}
