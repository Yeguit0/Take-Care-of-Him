using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MusicManager : MonoBehaviour
{
    public AudioSource audioSource;

    [Header("Interfaz")]
    public TMP_Text textoArtista;
    public TMP_Text textoCancion;
    public Image imagenPortada;
    public Slider sliderMusica;

    [Header("Animacion")]
    public Animator animator;
    public bool isPlaying = false;

    private void Start()
    {
        sliderMusica.minValue = 0;
        sliderMusica.maxValue = 1;
        sliderMusica.value = 0;
    }

    private void Update()
    {
        if (audioSource.clip != null && audioSource.clip.length > 0)
        {
            sliderMusica.value =
                audioSource.time / audioSource.clip.length;
        }

        isPlaying = audioSource.isPlaying;
        animator.SetBool("isPlaying", isPlaying);

    }

    public void ReproducirCancion(MusicData cancion)
    {
        if (cancion == null || cancion.audio == null)
            return;

        audioSource.Stop();

        audioSource.clip = cancion.audio;
        audioSource.time = 0;
        audioSource.Play();

        textoArtista.text = cancion.artista;
        textoCancion.text = cancion.nombreCancion;
        imagenPortada.sprite = cancion.portada;

        sliderMusica.value = 0;
    }
}
