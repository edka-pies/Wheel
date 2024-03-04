using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] private float RotatePower;
    [SerializeField] private float StopPower;
    [SerializeField] private Manager manager;
    [SerializeField] private Transform Kó³ko;
    private Rigidbody2D rbody;
    private bool inRotate;
    private float t;
    private void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {

        if (rbody.angularVelocity > 0)
        {
            rbody.angularVelocity -= StopPower * Time.deltaTime;
            rbody.angularVelocity = Mathf.Clamp(rbody.angularVelocity, 0, 1440);
        }

        if (rbody.angularVelocity == 0 && inRotate)
        {
            t += Time.deltaTime;
            if (t >= 0.5f)
            {
                GetReward();
                inRotate = false;
                t = 0;
            }
        }
        if (Input.GetKeyDown("space"))
        {
            Rotete();
        }
    }
    public void Rotete()
    {
        transform.Rotate(0,0,Random.Range(0,360));
        if (!inRotate)
        {
            rbody.AddTorque(RotatePower);
            inRotate = true;
        }
    }
    public void GetReward()
    {
        
    }
    public void Win(string Score)
    {
        Debug.Log(Score);
    }
}
