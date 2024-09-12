using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scheme : MonoBehaviour
{
    public string cardTitle;
    public bool isOngoing;
    private SpriteRenderer sp;

    // Start is called before the first frame update
    void Start()
    {

        sp = GetComponent<SpriteRenderer>();
        
    }
}
