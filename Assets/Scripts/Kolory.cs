using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Kolory : MonoBehaviour
{
    [SerializeField] private Toggle[] kolory;
    [SerializeField] private Color[] koloryColor;
    [SerializeField] private Color[] koloryUzywane;
    [SerializeField] private String[] koloryText;
    public String[] koloryTextUzywane;
    [SerializeField] private Manager manager;
    private int koloryIndex;
    private int koloryInd;
    public void KoloryBehav()
    {
        koloryIndex = 0;
        koloryInd = 0;
        foreach (Toggle toggle in kolory) 
        { 
            if (toggle.isOn) 
            {
                koloryInd++;
            }
        }
        koloryUzywane = new Color[koloryInd];
        koloryTextUzywane = new String[koloryInd];
        koloryInd = 0;
        foreach (Toggle toggle in kolory)
        {
            if (toggle.isOn)
            {
                koloryUzywane[koloryInd] = koloryColor[koloryIndex];
                koloryTextUzywane[koloryInd] = koloryText[koloryIndex];
                koloryInd++;
                
            }
            koloryIndex++;
        }
        manager.namesUsed = koloryTextUzywane;
        manager.czesci = koloryUzywane.Length;
        manager.colorUsed = koloryUzywane;
    }
}
