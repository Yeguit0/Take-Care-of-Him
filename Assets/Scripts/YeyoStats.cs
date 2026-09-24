using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class YeyoStats : MonoBehaviour
{
    
    public int nivel = 1;
    public float vida = 100f;
    public float hambre = 100f;
    public float sueño = 100f;
    public float felicidad = 100f;

    public GameObject Yeyo;
    public Animator animator;

    public Slider vidaSlider;
    public Slider hambreSlider;
    public Slider sueñoSlider;
    public Slider felicidadSlider;

    void Start()
    {
        StartCoroutine(Idle());
    }

    void Update()
    {
        vida = Mathf.Clamp(vida, 0, 100);
        hambre = Mathf.Clamp(hambre, 0, 100);
        sueño = Mathf.Clamp(sueño, 0, 100);
        felicidad = Mathf.Clamp(felicidad, 0, 100);

        vidaSlider.value = vida;
        hambreSlider.value = hambre;
        sueñoSlider.value = sueño;
        felicidadSlider.value = felicidad;
    }

    IEnumerator Idle()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);

            hambre -= 0.2f;
            sueño -= 0.1f;
            felicidad -= 0.1f;

            if (hambre <= 20 || sueño <= 20 || vida <= 20)
            {
                felicidad -= 0.5f;
            }
            
            if (hambre <= 20 || sueño <= 20)
            {
                vida -= 0.5f;
            }

            if (vida <= 0)
            {
                // Handle character death
                Debug.Log("Yeyo murió ggs");
                StopCoroutine(Idle());
            }
        }
    }
}
