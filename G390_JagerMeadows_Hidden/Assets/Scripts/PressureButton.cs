using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressureButton : MonoBehaviour
{
    //public variables
    public Material defaultMaterial;
    public Material secondMaterial;
    public MeshRenderer subject;

    //private variables
    bool isDefaultMat;
    bool isSecondMat;

    // Start is called before the first frame update
    void Start()
    {
        //set initial material
        subject.material = defaultMaterial;
        isDefaultMat = true;
    }

    //when something enters the trgger
    private void OnTriggerEnter(Collider other)
    {
        //if it's the player
        if (other.CompareTag("Player"))
        {
            //and if the current mat is default, switch to the second mat
            if (isDefaultMat == true)
            {
                subject.material = secondMaterial;
                isDefaultMat = false;
            }
            //but if the current mat is the second mat, switch to default
            else if (isDefaultMat == false)
            {
                subject.material = defaultMaterial;
                isDefaultMat = true;
            }
        }
    }
    //same as above but when the player exits
    private void OnTriggerExit(Collider other)
    {
        //if it's the player
        if (other.CompareTag("Player"))
        {
            //and if the current mat is default, switch to the second mat
            if (isDefaultMat == true)
            {
                subject.material = secondMaterial;
                isDefaultMat = false;
            }
            //but if the current mat is the second mat, switch to default
            else if (isDefaultMat == false)
            {
                subject.material = defaultMaterial;
                isDefaultMat = true;
            }
        }
    }
}
