using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public float czesci;
    public Image[] images;
    public TextMeshProUGUI[] teksty;
    public Color[] colorUsed;
    public string[] namesUsed;
    [SerializeField] Image image;
    public float OffsetY;
    public float OffsetX;
    private void Start()
    {
        OffsetY = image.transform.position.y;
        OffsetX = image.transform.position.x;
    }
    public void GenerateSlices()
    {
        for (int i = 0; i < 15; i++) 
        {
            images[i].transform.rotation = Quaternion.identity;
            teksty[i].transform.rotation = Quaternion.identity;
            images[i].gameObject.SetActive(false);
            teksty[i].gameObject.SetActive(false);
        }
        float rotation = 360 / czesci;
        for (int i = 0; i < czesci; i++)
        {
            images[i].fillAmount = 1 / czesci;
            images[i].color = (colorUsed[i]);
            images[i].transform.Rotate(new Vector3(0, 0, i * rotation));
            images[i].gameObject.SetActive(true);
            teksty[i].gameObject.SetActive(true);
            teksty[i].transform.Rotate(new Vector3(0, 0, (i * rotation) - 95 - rotation/2));
            teksty[i].transform.position = new Vector3(OffsetX,OffsetY,0);
            teksty[i].transform.Translate(170, 0, 0);
            teksty[i].SetText(namesUsed[i]);
            if (namesUsed[i] == "Czarny")
            {
                teksty[i].color = Color.white;
            }
        }
    }
}
