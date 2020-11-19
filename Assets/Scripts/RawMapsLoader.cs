/*
* Author - @Shreyansh Anchlia 
* ©SquareDragon Games
*/

using UnityEngine;
using UnityEngine.UI;

public class RawMapsLoader : EmojiManager
{
	public RawImage albedoMap;
	public RawImage specularMap;
	public RawImage DisplacementMap;
	public RawImage NormalMap;
	public RawImage OcclusionMap;
	public void SetEmojiNumber(int _emojiNumber)
	{
		emojiNumber = _emojiNumber;
		loadTexturesIntoGrid(emojiNumber);
		NullMaterial();
		ApplyAlbedoMap();
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
