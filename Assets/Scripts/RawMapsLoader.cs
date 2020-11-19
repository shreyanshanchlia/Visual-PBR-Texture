/*
* Author - @Shreyansh Anchlia 
* ©SquareDragon Games
*/

using UnityEngine;
using UnityEngine.UI;

public class RawMapsLoader : MonoBehaviour
{
	public RawImage albedoMap;
	public RawImage specularMap;
	public RawImage DisplacementMap;
	public RawImage NormalMap;
	public RawImage OcclusionMap;

	public MaterialScriptableObject[] materialObjects;

	public int emojiNumber = 0;

	private void Start()
	{
	}
	public void SetEmojiNumber(int emojiNumber)
	{
		loadTexturesIntoGrid(emojiNumber);
	}
	private void loadTexturesIntoGrid(int index)
	{
		albedoMap.texture = materialObjects[index].AlbedoMap;
		specularMap.texture = materialObjects[index].SpecularMap;
		DisplacementMap.texture = materialObjects[index].DisplacementMap;
		NormalMap.texture = materialObjects[index].NormalMap;
		OcclusionMap.texture = materialObjects[index].OcclusionMap;
	}
}
