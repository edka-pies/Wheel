using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Dodatki : MonoBehaviour
{
    [SerializeField] private Toggle[] dodatki;
    private Color[] dodatkiColor;
    [SerializeField] private String[] dodatkiText;
    public String[] dodatkiTextUzywane;
    [SerializeField] private Manager manager;
    private int koloryIndex;
    private int koloryInd;
    public void DodatkiBehav()
    {
        koloryIndex = 0;
        koloryInd = 0;
        foreach (Toggle toggle in dodatki)
        {
            if (toggle.isOn)
            {
                koloryInd++;
            }
        }
        dodatkiTextUzywane = new String[koloryInd];
        dodatkiColor = new Color[koloryInd];
        koloryInd = 0;
        foreach (Toggle toggle in dodatki)
        {
            if (toggle.isOn)
            {
                dodatkiColor[koloryInd] = UnityEngine.Random.ColorHSV();
                dodatkiTextUzywane[koloryInd] = dodatkiText[koloryIndex];
                koloryInd++;

            }
            koloryIndex++;
        }
        manager.namesUsed = dodatkiTextUzywane;
        manager.czesci = dodatkiTextUzywane.Length;
        manager.colorUsed = dodatkiColor;
    }
}
