using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Przyciski : MonoBehaviour
{
    [SerializeField] private GameObject KoloryWybor;
    [SerializeField] private GameObject DodatkiWybor;
    [SerializeField] private GameObject PieniazkiWybor;
    [SerializeField] private GameObject KoloryPrzy;
    [SerializeField] private GameObject DodatkiPrzy;
    [SerializeField] private GameObject PieniazkiPrzy;
    [SerializeField] private GameObject KoloryUstaw;
    [SerializeField] private GameObject DodatkiUstaw;
    [SerializeField] private GameObject PieniazkiUstaw;
    public void KoloryPrzycisk() 
    {
        KoloryPrzy.SetActive(true);
        KoloryUstaw.SetActive(true);
        KoloryWybor.SetActive(false);
        DodatkiWybor.SetActive(false);
        PieniazkiWybor.SetActive(false);
    }
    public void DodatkiPrzycisk()
    {
        DodatkiPrzy.SetActive(true);
        DodatkiUstaw.SetActive(true);
        KoloryWybor.SetActive(false);
        DodatkiWybor.SetActive(false);
        PieniazkiWybor.SetActive(false);
    }
    public void PieniazkiPrzycisk()
    {
        PieniazkiPrzy.SetActive(true);
        PieniazkiUstaw.SetActive(true);
        KoloryWybor.SetActive(false);
        DodatkiWybor.SetActive(false);
        PieniazkiWybor.SetActive(false);
    }
}
