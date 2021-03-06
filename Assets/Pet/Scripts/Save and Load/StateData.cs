﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class StateData
{
    public bool portal;
    public bool sfx;
    public bool music;
    public int qualityLevel;
    public float volume;
    public int highScore;
    public string prefabName;

    public int slotA_val, slotB_val, slotC_val;
    public StateData(GlobalSettingsControl settings)
    {
        //qualityLevel = settings.qualityLevelIndex;
        //portal = settings.portalBool;
        music = settings.musicBool;
        sfx = settings.sfxBool;
        //volume = settings.volumeVal;
        //highScore = settings.highScoreCount;
        prefabName = settings.prefabTitle;
    }
    
    /*
    public StateData(MyInventoryControl inventoryStats)
    {
        slotA_val = inventoryStats.slotA_index;
        slotB_val = inventoryStats.slotB_index;
        slotC_val = inventoryStats.slotC_index;
    }
    */
}
