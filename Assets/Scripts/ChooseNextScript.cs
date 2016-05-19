using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ChooseNextScript : MonoBehaviour {

    public GameObject[] lightsButtonsRow1;
    public GameObject[] lightsButtonsRow2;
    public GameObject[] lightsButtonsRow3;
    public GameObject[] lightsButtonsRow4;
    public GameObject[] lightsButtonsRow5;
    public GameObject[] lightsButtonsRow6;
    public GameObject[] lightsButtonsRow7;

    public static int symbol;
    public static List<int> previousSymbols;
    public static int maxCount = 3;

    public void ChooseNext()
    {
        previousSymbols.Add(symbol);
        while (previousSymbols.Count > maxCount)
        {
            previousSymbols.RemoveAt(0);
        }
        bool newSym;
        do
        {
            newSym = false;
            symbol = Random.Range(0, System.Enum.GetValues(typeof(SpellListScript.SpellList)).Length);
            foreach (int check in previousSymbols)
            {
                if (symbol == check)
                    newSym = true;
            }
        } while (newSym);
        //chosen a new spell by integer
    }

    public void _CheckLights()
    {

    }
}
