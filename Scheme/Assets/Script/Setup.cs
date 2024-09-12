using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Setup : MonoBehaviour
{
    public List<Sprite> sprites;
    private List<Sprite> originalList;
    public List<Sprite> reorderedSprites;
    // Start is called before the first frame update
    void Start()
    {
        //save orignal list
        originalList = sprites;

        //setup for shuffled deck
        int listLength = sprites.Count;
        int num = listLength;
        int rand = Random.Range(0, listLength);

        while (num-1 >= 0)
        {
            //random int
            rand = Random.Range(0, listLength);

            //removes from old list and adds to reordered one
            reorderedSprites.Add(sprites[rand]);
            sprites.Remove(sprites[rand]);
            listLength = sprites.Count;
            num -= 1;
        }

    }

}
