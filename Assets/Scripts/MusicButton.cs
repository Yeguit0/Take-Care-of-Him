using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MusicButton : MonoBehaviour
{
    public MusicData cancion;

    [Header("Interfaz")]
    public TMP_Text textoArtista;
    public TMP_Text textoCancion;
    public Image imagenPortada;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        textoArtista.text = cancion.artista;
        textoCancion.text = cancion.nombreCancion;
        imagenPortada.sprite = cancion.portada;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
