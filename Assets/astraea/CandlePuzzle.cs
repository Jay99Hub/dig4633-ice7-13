using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandlePuzzle : MonoBehaviour
{
    public int inPlace;
    public ParticleSystem[] lights;
    public ParticleSystem fire;
    public GameObject fireLight;
    public GameObject winText;

    
    // Start is called before the first frame update
    void Start()
    {
        inPlace = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CandleIn(int spot)
    {
        inPlace++;
        lights[spot].Play();
        Debug.Log(inPlace);

        if (inPlace >= 3)
        {
            Debug.Log("Win");
            fire.Play();
            fireLight.SetActive(true);
            winText.SetActive(true);
        }
    }

    public void CandleOut(int spot) 
    { 
        inPlace--;
        lights[spot].Stop();
    }
}
