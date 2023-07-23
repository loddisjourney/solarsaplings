using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class ar_raycast_manager : MonoBehaviour
{
    public GameObject TREEobj;
    GameObject spawned_object;
    bool object_spawned;
    ARRaycastManager arrayman;
    List<ARRaycastHit> hits = new List<ARRaycastHit>();
    ar_raycast_manager scriptSelf;
    ARPlaneManager planeMan;
    public GameObject trackObj;

    public GameObject canvasObj;

    // Start is called before the first frame update
    void Start()
    {
        object_spawned = false;
        arrayman = GetComponent<ARRaycastManager>();
        scriptSelf = GetComponent<ar_raycast_manager>();
        planeMan = GetComponent<ARPlaneManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            if (arrayman.Raycast(Input.GetTouch(0).position, hits, TrackableType.PlaneWithinPolygon))
            {
                var hitpose = hits[0].pose;
                if (!object_spawned)
                {
                    //spawned_object = Instantiate(momoobj, hitpose.position, hitpose.rotation);
                    TREEobj.transform.position = hitpose.position;
                    //momoobj.transform.rotation = hitpose.rotation;
                    TREEobj.SetActive(true);
                    canvasObj.SetActive(true);
                    arrayman.enabled = false;
                    scriptSelf.enabled = false;
                    planeMan.enabled = false;
                    trackObj = GameObject.Find("Trackables");
                    trackObj.SetActive(false);

                }

            }
        }
    }
}
