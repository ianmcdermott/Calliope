using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialSetter : MonoBehaviour
{
    Renderer m_Renderer;
    //private Object[] textures;
    private Object[] materials;
    private string objName; // Must match the name of the folder

    void Start()
    {
        objName = transform.parent.name;
        //Fetch the Renderer from the GameObject
        m_Renderer = GetComponent<MeshRenderer>();

        // Snag all materials from the materials resources folder
        materials = Resources.LoadAll("Holograms/"+objName+"/Materials", typeof(Material));

        // Create temporary arraylist to cast materials from Object to Material
        Material[] castmat = new Material[materials.Length];
        int counter = 0;
        foreach(Material m in materials){
            castmat[counter] = m;
            counter++;
        }
        m_Renderer.materials = castmat;
    }
}