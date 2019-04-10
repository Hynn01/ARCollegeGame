using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridImage : MonoBehaviour {

    public Transform[] grids;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public Transform GetEmptyGrid()
    {

        for (int i = 0; i < grids.Length; i++)
        {

            if (grids[i].childCount == 0)
            {

                return grids[i];

            }

        }

        return null;

    }

}
