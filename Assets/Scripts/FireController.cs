using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
public class FireController : MonoBehaviour
{
    [SerializeField] private int fireStrength;
    [SerializeField] private List<GameObject> onFireArray;
    [SerializeField] private GameObject itemFireParticles;
    [SerializeField] private ParticleSystem mainFireParticles;
    [SerializeField] private Light campfireLight;
    [SerializeField] private int lightIntValue;
    [SerializeField] private LightFlickerEffect lightFlicker;

    private void Start()
    {
        onFireArray = new List<GameObject>();
        lightFlicker = GetComponent<LightFlickerEffect>();

        lightIntValue = 500000;
        campfireLight.intensity = lightIntValue;
    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Item")
        {
            GameObject temp = other.gameObject;
            Debug.Log("Item on fire");
            onFireArray.Add(temp);
            GameObject newFire = Instantiate(itemFireParticles, temp.transform);
            newFire.transform.parent = temp.transform;
            temp.tag = "Untagged";
            temp.GetComponent<MeshRenderer>().shadowCastingMode = ShadowCastingMode.Off;

        }

        
        campfireLight.intensity += lightIntValue;
        lightFlicker.maxIntensity += lightIntValue;

    }





}
