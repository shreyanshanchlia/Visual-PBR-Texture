/*
* Author - @Shreyansh Anchlia 
* ©SquareDragon Games
*/

using UnityEngine.UI;
using UnityEngine;

public class ChangeMaterial : MonoBehaviour
{
	public Material Mat;

	public Texture[] AlbedoMaps;
	public Texture[] NormalMaps;
	public Texture[] MetallicMaps;
	public Texture[] HeightMaps;
	public Texture[] OcclusionMaps;

	int index = 0;

	private void Start()
	{
		NullMaterial();
	}

	[ContextMenu("Null Material")]
	public void NullMaterial()
	{
		this.gameObject.GetComponent<MeshRenderer>().material.SetTexture("_MainTex", null);
		this.gameObject.GetComponent<MeshRenderer>().material.SetTexture("_BumpMap", null);
		this.gameObject.GetComponent<MeshRenderer>().material.SetTexture("_MetallicGlossMap", null);
		this.gameObject.GetComponent<MeshRenderer>().material.SetFloat("_Glossiness", 0f);
		this.gameObject.GetComponent<MeshRenderer>().material.SetTexture("_ParallaxMap", null);
		this.gameObject.GetComponent<MeshRenderer>().material.SetTexture("_OcclusionMap", null);
	}
	public void UpdateMesh()
	{

	}
	public void ChangeAlbedoImage()
	{
		this.gameObject.GetComponent<MeshRenderer>().material.SetTexture("_MainTex", AlbedoMaps[++index % AlbedoMaps.Length]);
	}
	public void ChangeNormalImage()
	{
		this.gameObject.GetComponent<MeshRenderer>().material.SetTexture("_BumpMap", NormalMaps[index % NormalMaps.Length]);
		this.gameObject.GetComponent<MeshRenderer>().material.EnableKeyword("_NORMALMAP");
	}
	public void ChangeMetallicImage()
	{
		this.gameObject.GetComponent<MeshRenderer>().material.SetTexture("_MetallicGlossMap", MetallicMaps[index % MetallicMaps.Length]);
		this.gameObject.GetComponent<MeshRenderer>().material.EnableKeyword("_METALLICGLOSSMAP");
	}
	public void ChangeSmoothnessSlider(float smoothness)
	{
		Mat.SetFloat("_Glossiness", smoothness);
		this.gameObject.GetComponent<MeshRenderer>().sharedMaterial.EnableKeyword("_SPECGLOSSMAP");
	}
	public void ChangeHeightMap()
	{
		this.gameObject.GetComponent<MeshRenderer>().material.SetTexture("_ParallaxMap", HeightMaps[index % HeightMaps.Length]);
		this.gameObject.GetComponent<MeshRenderer>().material.EnableKeyword("_PARALLAXMAP");
	}
	public void ChangeOcclusionMap()
	{
		this.gameObject.GetComponent<MeshRenderer>().material.SetTexture("_OcclusionMap", OcclusionMaps[index % OcclusionMaps.Length]);
		this.gameObject.GetComponent<MeshRenderer>().material.EnableKeyword("_OCCLUSIONMAP");
	}
}
