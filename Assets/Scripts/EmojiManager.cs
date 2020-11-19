/*
* Author - @Shreyansh Anchlia 
* ©SquareDragon Games
*/

using UnityEngine;

public class EmojiManager : MonoBehaviour
{
	public GameObject TargetGameObject;
	public MaterialScriptableObject[] materialObjects;

	public int emojiNumber = 0;

	public void NullMaterial()
	{
		TargetGameObject.GetComponent<Renderer>().material.SetTexture("_MainTex", null);
		TargetGameObject.GetComponent<Renderer>().material.SetTexture("_BumpMap", null);
		TargetGameObject.GetComponent<Renderer>().material.SetTexture("_MetallicGlossMap", null);
		TargetGameObject.GetComponent<Renderer>().material.SetTexture("_ParallaxMap", null);
		TargetGameObject.GetComponent<Renderer>().material.SetTexture("_OcclusionMap", null);
	}
	public void ApplyAlbedoMap()
	{
		TargetGameObject.GetComponent<Renderer>().material = materialObjects[emojiNumber].material;
		TargetGameObject.GetComponent<Renderer>().material.SetTexture
			("_MainTex", materialObjects[emojiNumber].AlbedoMap);
	}
	public void ApplySpecularMap()
	{
		TargetGameObject.GetComponent<Renderer>().material.SetTexture
			("_MetallicGlossMap", materialObjects[emojiNumber].SpecularMap);
		TargetGameObject.GetComponent<Renderer>().material.EnableKeyword("_METALLICGLOSSMAP");
	}
	public void ApplyDisplacementMap()
	{
		TargetGameObject.GetComponent<Renderer>().material.SetTexture
			("_ParallaxMap", materialObjects[emojiNumber].DisplacementMap);
		TargetGameObject.GetComponent<Renderer>().material.EnableKeyword("_ParallaxMap");
	}
	public void ApplyNormalMap()
	{
		TargetGameObject.GetComponent<Renderer>().material.SetTexture
			("_BumpMap", materialObjects[emojiNumber].NormalMap);
		TargetGameObject.GetComponent<Renderer>().material.EnableKeyword("_NORMALMAP");
	}
	public void ApplyOcclusionMap()
	{
		TargetGameObject.GetComponent<Renderer>().material.SetTexture
			("_OcclusionMap", materialObjects[emojiNumber].OcclusionMap);
		TargetGameObject.GetComponent<Renderer>().material.EnableKeyword("_OCCLUSIONMAP");
	}
}
