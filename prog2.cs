using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Change : MonoBehaviour
{
    public GameObject plane, cube, sphere;
    public Material newPlaneMaterial, newCubeMaterial, newSphereMaterial;
    public Texture newPlaneTexture, newCubeTexture, newSphereTexture;

    private Renderer cubeR;
    private Renderer sphereR;
    private Renderer planeR;

    void Start() {
        cubeR = cube.GetComponent<Renderer>();
        sphereR = sphere.GetComponent<Renderer>();
        planeR = plane.GetComponent<Renderer>();
    }

    public void ChangeColor() {
        cubeR.material = new Material(Shader.Find("Standard"));
        sphereR.material = new Material(Shader.Find("Standard"));
        planeR.material = new Material(Shader.Find("Standard"));
        cubeR.material.mainTexture = null;
        sphereR.material.mainTexture = null;
        planeR.material.mainTexture = null;
        cubeR.material.color = Color.red;
        sphereR.material.color = Color.green;
        planeR.material.color = Color.blue;
    }

    public void ChangeMaterial() {
        cubeR.material.mainTexture = null;
        sphereR.material.mainTexture = null;
        planeR.material.mainTexture = null;
        cubeR.material = newCubeMaterial;
        sphereR.material = newSphereMaterial;
        planeR.material = newPlaneMaterial;
    }

    public void ChangeTexture() {
        cubeR.material = new Material(Shader.Find("Standard"));
        sphereR.material = new Material(Shader.Find("Standard"));
        planeR.material = new Material(Shader.Find("Standard"));
        cubeR.material.mainTexture = newCubeTexture;
        sphereR.material.mainTexture = newSphereTexture;
        planeR.material.mainTexture = newPlaneTexture;
    }
}
