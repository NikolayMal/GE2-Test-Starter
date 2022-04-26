using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nematode : MonoBehaviour
{
    public int length;

    public Material material;

    void Awake()
    {
        // Put your code here!
        
        
        for (int i = 0; i < length; i++) {
            GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            sphere.transform.position = transform.position - transform.forward * i;
            sphere.transform.parent = transform;
            sphere.GetComponent<Renderer>().material.color = Color.HSVToRGB(i / (float)length, 1, 1);
            sphere.transform.localScale = Vector3.one * (i + 1) / length;
            
            // if (i <= length / 2) {
            //     sphere.transform.localScale = Vector3.one * (i + 1) / length;
            // }
            // if (i > length / 2) {
            //     sphere.transform.localScale = Vector3.one * (i - 1) / length;                
            // }           
            

        }
    }


    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
