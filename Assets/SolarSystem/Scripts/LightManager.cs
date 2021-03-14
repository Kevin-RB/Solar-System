using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightManager : MonoBehaviour {

	public GameObject OverviewLight;
	public static LightManager instance = null;

	void Awake()
	{
		if(instance == null)
		{
			instance = this;
		}
		else if(instance != this)
		{
			Destroy(gameObject);
		}
	}

	public void ToggleOverviewLight(ConstantValues.CameraMode cameraMode)
	{
		if(cameraMode.Equals(ConstantValues.CameraMode.Detailed))
		{
			OverviewLight.GetComponent<Light>().intensity = 0;
		}
		else
		{
			OverviewLight.GetComponent<Light>().intensity = DefaultValues.overViewCameraLightIntensity;
		}
	}

}
