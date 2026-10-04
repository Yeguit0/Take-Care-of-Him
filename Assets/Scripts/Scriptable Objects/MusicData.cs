using UnityEngine;

[CreateAssetMenu(fileName = "MusicData", menuName = "Scriptable Objects/MusicData")]
public class MusicData : ScriptableObject
{
    public string nombreCancion;
    public string artista;
    public string musicLenght;
    public AudioClip audio;
    public Sprite portada;
}
