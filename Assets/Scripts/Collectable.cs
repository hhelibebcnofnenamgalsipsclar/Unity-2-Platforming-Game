using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class Collectable : MonoBehaviour
{
    public string collectableName;
    public string description;
    public GameObject Player;
    public abstract void Use();
}
