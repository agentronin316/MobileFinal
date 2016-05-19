using UnityEngine;
using System.Collections.Generic;
using System.IO;
using System;

/// <summary>
/// @author Marshall R. Mason
/// This script handles the inputs and player controls for Lights and Spells gameplay modes.
/// </summary>
public class InputController : MonoBehaviour {

    public GameObject lightHolder;
    public GameObject spellSprite;
    public int numSpells = 13;
    public int[] numTrainingSets = new int[] {3, 3, 4, 4, 3, 3, 3, 3, 3, 3, 3, 3, 3 };
    
    public bool isPlayingLights = false;

    List<Vector2>[][] trainingSets;



    List<Vector2> inputSwipe = new List<Vector2>();
    bool swipeStarted = false;

    void Start()
    {
        isPlayingLights = !PrefStatsScript.isSpells;
        if (!isPlayingLights)
        {
            lightHolder.SetActive(false);
            spellSprite.SetActive(true);
            //Load in training sets
            trainingSets = new List<Vector2>[numSpells][];
            for (int i = 0; i < numTrainingSets.Length; i++)
            {
                trainingSets[i] = new List<Vector2>[numTrainingSets[i]];
                for (int j = 0; j < numTrainingSets[i]; j++)
                {
                    TextAsset file = (TextAsset)Resources.Load("Symbol" + i + "TrainingSets/Set" + j);
                    StringReader reader = new StringReader(file.text);
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        string[] temp = line.Split(',');
                        trainingSets[i][j].Add(new Vector2(Convert.ToSingle(temp[0]), Convert.ToSingle(temp[1])));
                    }
                }
            }
        }
        else
        {
            lightHolder.SetActive(true);
            spellSprite.SetActive(false);
        }
    }

    void Update ()
    {
	    if (!isPlayingLights)
        {
            if (Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);
                switch(touch.phase)
                {
                    case TouchPhase.Began:
                        swipeStarted = true;
                        goto case TouchPhase.Moved;
                    case TouchPhase.Moved:
                        inputSwipe.Add(touch.position);
                        break;
                    case TouchPhase.Ended:
                        int index;
                        float score = SpellsRecognizer.Compare(inputSwipe, trainingSets, 64, out index);
                        //Pass the index and score off to whatever to check if it matches/passes
                        swipeStarted = false;
                        break;
                }
            }
            else if(swipeStarted)
            {
                int index;
                float score = SpellsRecognizer.Compare(inputSwipe, trainingSets, 64, out index);
                //Pass the index and score off to whatever to check if it matches/passes
                swipeStarted = false;
            }
        }
	}
}
