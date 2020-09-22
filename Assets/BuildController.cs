using HoloToolkit.Unity.InputModule.Utilities.Interactions;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildController : MonoBehaviour
{
    public GameObject cube;
    public GameObject sphere;
    public GameObject cyclinder;
    public GameObject emptyGroup;

    private GameObject group;
    private GameObject activeGroup;

    private Vector3 GetCameraPosition()
    {
        return (new Vector3 (Camera.main.transform.position.x, Camera.main.transform.position.y) + (Camera.main.transform.forward * 4.0f));
    }

    public void CombineObjects()
    {
        GameObject[] list = GameObject.FindGameObjectsWithTag("User Created");

        if (list != null || list.Length != 0)
        {
            activeGroup = Instantiate(emptyGroup, list[0].transform.position, Quaternion.identity);

            foreach (GameObject x in list)
            {
                x.transform.parent = activeGroup.transform;
                x.GetComponent<TwoHandManipulatable>().enabled = false;
            }
        }
    }

    public void SeperateObjects()
    {
        GameObject[] list = GameObject.FindGameObjectsWithTag("User Created");

        if (list != null || list.Length != 0)
        {
            foreach (GameObject x in list)
            {
                x.transform.parent = null;
                x.GetComponent<TwoHandManipulatable>().enabled = true;
            }
        }

        Destroy(activeGroup);
    }

    public void NewSphere()
    {
        GameObject x = Instantiate(sphere, GetCameraPosition(), Quaternion.identity);
    }

    public void NewCube()
    {
        GameObject x = Instantiate(cube, GetCameraPosition(), Quaternion.identity);
    }

    public void NewCyclinder()
    {
        GameObject x = Instantiate(cyclinder, GetCameraPosition(), Quaternion.identity);
    }
}
