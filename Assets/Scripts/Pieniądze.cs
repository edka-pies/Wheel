using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pieniądze : MonoBehaviour
{
    [SerializeField] private Slider minSlider;
    [SerializeField] private Slider maxSlider;
    [SerializeField] private Toggle[] ilosc;
    [SerializeField] private Toggle[] mnoznikLista;
    [SerializeField] private Manager manager;
    private Color[] koloryPieniazki;
    private float[] liczby;
    private string[] liczbyNazwy;
    private int[] iloscWartosc;
    private int[] mnoznikWartosci;
    private int iloscUzywana;
    private float wartosc;
    private int mnoznik;
    public void PieniBehav()
    {
        iloscWartosc = new int[3];
        mnoznikWartosci = new int[2];
        iloscWartosc[0] = 8;
        iloscWartosc[1] = 10;
        iloscWartosc[2] = 12;
        mnoznikWartosci[0] = 100;
        mnoznikWartosci[1] = 1000;
        int Count = 0;
        foreach (Toggle toggle in ilosc) 
        {
            if (toggle.isOn)
            {
                iloscUzywana = iloscWartosc[Count];
            }
            Count++;
        }
        int Countmnoznik = 0;
        foreach (Toggle toggle in mnoznikLista)
        { 
            if (toggle.isOn) 
            {
                mnoznik = mnoznikWartosci[Countmnoznik];
                minSlider.maxValue = 300000 / mnoznik;
                maxSlider.maxValue = 300000 / mnoznik;
            }
            Countmnoznik++;
        }
        koloryPieniazki = new Color[iloscUzywana];
        liczbyNazwy = new string[iloscUzywana];
        liczby = new float[iloscUzywana];
        for (int i = 0; i < iloscUzywana; i++) 
        {
            koloryPieniazki[i] = new Color(Random.Range(0, 0.5f), 0.5f, Random.Range(0, 0.5f));
        }
        GenerateValues(iloscUzywana);
        manager.namesUsed = liczbyNazwy;
        manager.czesci = liczbyNazwy.Length;
        manager.colorUsed = koloryPieniazki;
    }
    private void GenerateValues(int range)
    {
        for (int i = 0; i < range; i++) 
        {
            wartosc = Mathf.Round(Random.Range(minSlider.value, maxSlider.value));
            wartosc *= mnoznik;
            liczby[i] = wartosc;
            liczbyNazwy[i] = wartosc.ToString();
        }
    }
}
