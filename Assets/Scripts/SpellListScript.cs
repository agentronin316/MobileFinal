using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SpellListScript : MonoBehaviour {

    public enum SpellList { AIR, EARTH, FIRE, WATER, SWORD, PENTACLE, WAND, CUP, MARK, HOLD, CHARM, GROWTH, SPIRIT};

    public List<SpellList> gestureSpells = new List<SpellList>();
    public List<int[,]> spellList = new List<int[,]>();
    public Sprite[] gestureSprites = new Sprite[13];
    // Use this for initialization
    void Start()
    {
        // All the gesture spells added in order
        gestureSpells.Add(SpellList.CUP);
        gestureSpells.Add(SpellList.AIR);
        gestureSpells.Add(SpellList.CHARM);
        gestureSpells.Add(SpellList.EARTH);
        gestureSpells.Add(SpellList.FIRE);
        gestureSpells.Add(SpellList.GROWTH);
        gestureSpells.Add(SpellList.HOLD);
        gestureSpells.Add(SpellList.MARK);
        gestureSpells.Add(SpellList.PENTACLE);
        gestureSpells.Add(SpellList.SPIRIT);
        gestureSpells.Add(SpellList.SWORD);
        gestureSpells.Add(SpellList.WAND);
        gestureSpells.Add(SpellList.WATER);



        int[,] air;
        air  = new  int[,] { {1,1,1,1,1,1},
                              {0,0,0,0,0,1},
                              {0,1,1,1,0,1},
                              {0,1,0,1,0,1},
                              {0,1,0,1,0,1},
                              {0,1,0,0,0,1},
                              {0,1,1,1,1,1} };
        spellList.Add(air);
        int[,] earth;
        earth = new  int[,] { {1,1,1,1,1,1},
                              {1,0,0,0,0,1},
                              {1,0,0,0,0,1},
                              {1,0,0,0,0,1},
                              {1,0,0,0,0,1},
                              {1,0,0,0,0,1},
                              {1,1,0,0,1,1} };
        spellList.Add(earth);
        int[,] fire;
        fire  =  new int[,] { {0,0,0,1,0,0},
                              {0,0,1,0,0,0},
                              {0,0,0,1,0,0},
                              {0,0,0,0,1,0},
                              {0,1,1,1,1,0},
                              {1,0,0,0,0,0},
                              {0,1,1,1,1,1} };
        spellList.Add(fire);
        int[,] water;
        water =  new int[,] { {0,0,0,0,1,0},
                              {0,0,0,1,0,0},
                              {0,0,1,0,0,1},
                              {0,1,0,0,1,0},
                              {1,0,0,0,0,1},
                              {1,0,0,0,0,1},
                              {0,1,1,1,1,0} };
        spellList.Add(water);
        int[,] sword;
        sword =  new int[,] { {0,0,1,0,0,0},
                              {0,0,1,1,0,0},
                              {0,0,1,1,0,0},
                              {0,0,1,1,0,0},
                              {0,0,1,1,0,0},
                              {0,0,1,0,0,0},
                              {0,0,1,0,0,0} };
        spellList.Add(sword);
        int[,] penta;
        penta  = new int[,] { {0,0,1,0,0,0},
                              {0,0,1,1,0,0},
                              {1,1,0,0,1,1},
                              {0,1,0,0,1,0},
                              {0,0,1,1,0,0},
                              {0,1,1,1,1,0},
                              {1,1,0,0,1,1} };
        spellList.Add(penta);
        int[,] wand;
        wand  =  new int[,] { {0,1,0,0,0,0},
                              {0,0,1,0,0,0},
                              {0,0,0,1,0,0},
                              {0,0,0,0,1,0},
                              {0,0,0,1,0,0},
                              {0,0,0,0,1,0},
                              {0,0,0,0,0,1} };
        spellList.Add(wand);
        int[,] cups;
        cups  =  new int[,] { {0,0,0,0,0,0},
                              {0,1,0,0,1,0},
                              {1,0,0,0,0,1},
                              {1,0,0,0,0,1},
                              {1,0,0,0,0,1},
                              {0,1,0,0,1,0},
                              {0,0,1,1,0,0} };
        spellList.Add(cups);
        int[,] mark;
        mark  =  new int[,] { {1,0,0,0,0,0},
                              {1,1,0,0,0,1},
                              {1,0,1,0,1,0},
                              {1,0,0,1,0,0},
                              {1,0,1,0,1,0},
                              {1,1,0,0,0,1},
                              {1,0,0,0,0,0} };
        spellList.Add(mark);
        int[,] hold;
        hold  =  new int[,] { {0,0,0,1,0,0},
                              {0,0,0,1,0,0},
                              {0,0,0,1,0,0},
                              {0,0,0,1,0,0},
                              {0,0,0,1,0,0},
                              {0,0,1,0,1,0},
                              {0,0,0,1,0,0} };
        spellList.Add(hold);
        int[,] charm;
        charm =  new int[,] { {0,0,0,0,0,0},
                              {0,1,0,0,1,0},
                              {1,0,1,1,0,1},
                              {1,0,0,0,0,1},
                              {0,1,0,0,1,0},
                              {0,0,1,1,0,0},
                              {0,0,0,0,0,0} };
        spellList.Add(charm);
        int[,] growth;
        growth = new int[,] { {0,0,1,1,0,0},
                              {0,1,0,0,1,0},
                              {1,0,0,0,0,1},
                              {0,1,0,0,1,0},
                              {0,0,1,1,0,0},
                              {0,0,1,1,0,0},
                              {1,1,1,1,1,1} };
        spellList.Add(growth);
        int[,] spirit;
        spirit = new int[,] { {0,0,1,1,0,0},
                              {0,1,0,0,1,0},
                              {1,0,0,0,0,1},
                              {1,0,0,0,0,1},
                              {0,1,0,0,1,0},
                              {0,0,1,1,0,0},
                              {0,0,0,1,1,0} };
        spellList.Add(spirit);


    }

    // Update is called once per frame
    void Update () {
	
	}
}
