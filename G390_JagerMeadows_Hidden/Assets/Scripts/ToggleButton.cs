using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleButton : MonoBehaviour
{
    //public variables
    public Material defaultMaterial;
    public Material secondMaterial;
    
    [SerializeField] private List<Transform> Surfaces;

    //private variables
    bool isDefaultMat;
    bool isSecondMat;

    // Start is called before the first frame update
    void Start()
    {
        //set initial material
        
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
                foreach (Transform Tform in Surfaces)
                {
                    Tform.GetComponent<MeshRenderer>().material = secondMaterial;
                    isDefaultMat = false;
                }
                
            }
            //but if the current mat is the second mat, switch to default
            else if (isDefaultMat == false)
            {
                foreach (Transform Tform in Surfaces)
                {
                    Tform.GetComponent<MeshRenderer>().material = defaultMaterial;
                    isDefaultMat = true;
                }
                
            }
        }
    }
}
