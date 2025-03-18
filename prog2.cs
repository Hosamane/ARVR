using UnityEngine; 
using UnityEngine.UI; 
 
public class ChangeAppearance : MonoBehaviour 
{ 
    public GameObject cube, sphere, plane;  // Assign objects in the Inspector 
    public Material newCubeMaterial, newSphereMaterial, newPlaneMaterial;  // New materials 
    public Texture newCubeTexture, newSphereTexture, newPlaneTexture;  // New textures 
 
    // Function to change Cube appearance 
    public void ChangeCubeAppearance() 
    { 
        Renderer cubeRenderer = cube.GetComponent<Renderer>(); 
        cubeRenderer.material = newCubeMaterial;  // Change Material 
        cubeRenderer.material.mainTexture = newCubeTexture;  // Change Texture 
        cubeRenderer.material.color = Color.red;  // Change Color 
    } 
 
    // Function to change Sphere appearance 
    public void ChangeSphereAppearance() 
    { 
        Renderer sphereRenderer = sphere.GetComponent<Renderer>(); 
        sphereRenderer.material = newSphereMaterial; 
        sphereRenderer.material.mainTexture = newSphereTexture; 
        sphereRenderer.material.color = Color.green; 
    } 
 
    // Function to change Plane appearance 
    public void ChangePlaneAppearance() 
    { 
        Renderer planeRenderer = plane.GetComponent<Renderer>(); 
        planeRenderer.material = newPlaneMaterial; 
        planeRenderer.material.mainTexture = newPlaneTexture; 
        planeRenderer.material.color = Color.blue; 
    } 
} 
