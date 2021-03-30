using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleButton : MonoBehaviour
{
    //public variables
    public Material defaultMaterial;
    public Material secondMaterial;
    public Material buttonMaterial;

    [SerializeField] AudioClip buttonHigh;
    [SerializeField] AudioClip buttonLow;
    [SerializeField] private List<Transform> Surfaces;
    [SerializeField] private List<Transform> SecondSurfaces;
    [SerializeField] private List<Transform> ButtonHider;

    //private variables
    bool isDefaultMat;
    bool isSecondMat;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        //set initial material
        
        isDefaultMat = true;
        audioSource = GetComponent<AudioSource>();
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
                audioSource.clip = buttonHigh;
                audioSource.Play();
                isDefaultMat = false;
                foreach (Transform Tform in Surfaces)
                {
                    Tform.GetComponent<MeshRenderer>().material = secondMaterial;
                }
                foreach (Transform Tform in SecondSurfaces)
                {
                    Tform.GetComponent<MeshRenderer>().material = defaultMaterial;
                }
                foreach (Transform Tform in ButtonHider)
                {
                    Tform.GetComponent<MeshRenderer>().material = buttonMaterial;
                }

            }
            //but if the current mat is the second mat, switch to default
            else if (isDefaultMat == false)
            {
                audioSource.clip = buttonLow;
                audioSource.Play();
                isDefaultMat = true;
                foreach (Transform Tform in Surfaces)
                {
                    Tform.GetComponent<MeshRenderer>().material = defaultMaterial;
                }
                foreach (Transform Tform in SecondSurfaces)
                {
                    Tform.GetComponent<MeshRenderer>().material = secondMaterial;
                }
                foreach (Transform Tform in ButtonHider)
                {
                    Tform.GetComponent<MeshRenderer>().material = buttonMaterial;
                }

            }
        }
    }
}
