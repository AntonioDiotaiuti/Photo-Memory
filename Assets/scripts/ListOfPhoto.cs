using UnityEngine;

public class ListOfPhoto : MonoBehaviour
{


    public GameObject[] cubePrefab; // Assign a cube prefab in the Inspector
    public Vector3 spawnOffset = new Vector3(0, 1, 0); // Offset for spawning the cube
    int randomIndex;
    void OnMouseDown()
    {
        do
        {
            randomIndex = Random.Range(0, cubePrefab.Length);
            Instantiate(cubePrefab[randomIndex], transform.position + spawnOffset, Quaternion.identity);
            cubePrefab[randomIndex] = null;
        } while (cubePrefab[randomIndex] != null);
    }
}


