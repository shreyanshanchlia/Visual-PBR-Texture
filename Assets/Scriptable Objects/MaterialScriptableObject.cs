/*
* Author - @Shreyansh Anchlia 
* ©SquareDragon Games
*/

using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "MaterialMaps", menuName = "MaterialMaps")]
public class MaterialScriptableObject : ScriptableObject
{
	public Texture AlbedoMap;
	public Texture DisplacementMap;
	public Texture OcclusionMap;
	public Texture SpecularMap;
	public Texture NormalMap;
	public Material material;
}
