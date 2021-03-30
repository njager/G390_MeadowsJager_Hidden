using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RESTART : MonoBehaviour
{
    public GameObject Player;
    

    public void OnTriggerEnter(Collider col)
    {
        Player.transform.position = CheckPoint.GetActiveCheckPointPosition();
    }
}
