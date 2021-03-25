using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARSubsystems;
using UnityEngine.XR.ARFoundation;
 
[System.Serializable]
public class MarkerPrefabs
{
    public string marker;
    public GameObject targetPrefab;
}
 
public class SwitchPrefab : MonoBehaviour
{
    /* Insepctor array */
    public MarkerPrefabs[] markerPrefabCombos;
    ARTrackedImageManager m_TrackedImageManager;
    public GameManager gameManager;

     private void Start() {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
 
    void Awake()
    {
        m_TrackedImageManager = GetComponent<ARTrackedImageManager>();
    }
 
    void OnEnable()
    {
        m_TrackedImageManager.trackedImagesChanged += OnTrackedImagesChanged;
    }
 
    void OnDisable()
    {
        m_TrackedImageManager.trackedImagesChanged -= OnTrackedImagesChanged;
    }
 
    private void OnTrackedImagesChanged(ARTrackedImagesChangedEventArgs eventArgs)
    {
        Debug.Log("test Change");

            foreach (var newImage in eventArgs.added)
    {
        Debug.Log("test Add");
        for(int i =0;i<markerPrefabCombos.Length;i++){
        if (markerPrefabCombos[i].marker==newImage.referenceImage.name) {
 
                        /* Set the corresponding prefab to active at the center of the tracked image */                    
                        markerPrefabCombos[i].targetPrefab.SetActive(true);
                        gameManager.nowObject = markerPrefabCombos[i].targetPrefab;
                        markerPrefabCombos[i].targetPrefab.transform.position = newImage.transform.position;
                    }
        }
     
    }

    foreach (var updatedImage in eventArgs.updated)
    {
        Debug.Log("test updated");
        Debug.Log("test " + updatedImage.trackingState);
        if(updatedImage.trackingState == TrackingState.Limited){
              for(int i =0;i<markerPrefabCombos.Length;i++){
                            if (markerPrefabCombos[i].marker==updatedImage.referenceImage.name) {
 
                        /* Set the corresponding prefab to active at the center of the tracked image */                    
                        markerPrefabCombos[i].targetPrefab.SetActive(false);
                    }
              }
      

        }else         if(updatedImage.trackingState == TrackingState.Tracking){
              for(int i =0;i<markerPrefabCombos.Length;i++){
                            if (markerPrefabCombos[i].marker==updatedImage.referenceImage.name) {
 
                        /* Set the corresponding prefab to active at the center of the tracked image */
                        gameManager.nowObject = markerPrefabCombos[i].targetPrefab;                    
                        markerPrefabCombos[i].targetPrefab.SetActive(true);
                        markerPrefabCombos[i].targetPrefab.GetComponent<ARObject>().InitAR();
        
                        markerPrefabCombos[i].targetPrefab.transform.position = updatedImage.transform.position;

                    }
              }
      

        }

    }

    foreach (var removedImage in eventArgs.removed)
    {
        Debug.Log("test removed");
                for(int i =0;i<markerPrefabCombos.Length;i++){
    if (markerPrefabCombos[i].marker==removedImage.referenceImage.name) {
 
                        /* Set the corresponding prefab to active at the center of the tracked image */                    
                        markerPrefabCombos[i].targetPrefab.SetActive(false);
                        markerPrefabCombos[i].targetPrefab.transform.position = removedImage.transform.position;
                    }
                }
          
    }

    }
 
}
 
