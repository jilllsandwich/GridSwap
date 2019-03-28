using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class NewGridManager : MonoBehaviour
{
    // 0 = green
    // 1 = blue
    // 2 = red
    
    public const int COLS = 6;
    public const int ROWS = 3;
    
    int[,] _gems = new int[COLS,ROWS];

    [FormerlySerializedAs("gemPrefab")] public GameObject GemPrefab;
    // Start is called before the first frame update
    void Start()
    {
        /*
        _gems[0,0] = Random.Range(0,9);
        _gems[0,1] = Random.Range(0,9);
        _gems[0,2] = Random.Range(0,9);
        _gems[1,0] = Random.Range(0,9);
        _gems[2,1] = Random.Range(0,9);
        */

        for (int x = 0; x < COLS; x++)
        {
            for (int y = 0; y < ROWS; y++)
            {
                int color = Random.Range(0, 9);
                _gems[x, y] = color;
            }
        }
        
        InstantiateGems();

        /*
        for (int i = 0; i < 5; i++)
        {
            Debug.Log("Gem" + i + ": " + _gems[i]);
        }
        */
    }

    // Update is called once per frame
    void InstantiateGems()
    {
        for (int x = 0; x < COLS; x++)
        {
            for (int y = 0; y < ROWS; y++)
            {
                Debug.Log("Gem" + x + "," + y + ": " + _gems[x,y]);
                GameObject gem = GameObject.Instantiate(GemPrefab);
                gem.transform.position = new Vector3(x, y, 0);
            }
        }
    }
}
