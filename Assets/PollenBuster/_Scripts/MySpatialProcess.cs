using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.SpatialMapping;

public class MySpatialProcess : MonoBehaviour
{

	[SerializeField] private Material mat;
	// Use this for initialization
	void Start () {
		SurfaceMeshesToPlanes.Instance.MakePlanesComplete += SurfaceMeshesToPlanes_MakePlanesComplete;
		SurfaceMeshesToPlanes.Instance.MakePlanes ();
	}
	private void SurfaceMeshesToPlanes_MakePlanesComplete(object source, System.EventArgs args)
	{
		var planes = new List<GameObject> ();
		planes = SurfaceMeshesToPlanes.Instance.ActivePlanes;
		foreach (GameObject plane in planes) {
			var surfacePlane = plane.GetComponent<SurfacePlane> ();
			if (surfacePlane != null) {
				print (surfacePlane.PlaneType);
				print (surfacePlane.transform.position);
				if (surfacePlane.PlaneType == PlaneTypes.Floor)
				{
					surfacePlane.gameObject.GetComponent<Renderer>().material = mat;
					print("nat");
				}
			}
		}
	}
}
