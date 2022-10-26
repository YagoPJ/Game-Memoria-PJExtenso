using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
//informações das cartas encontradas
[RequireComponent(typeof(AudioSource))]
public class CardsInfo2 : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject infoMenuUI;

    GameObject gc;  //gc: GameController
    GameController2 gcs;

    //som
    public AudioClip succeed;
    AudioSource audioSource;

    public Text typeCard;
    public Text typeInfo;
    Sprite typeImage;
    public Image imageT;

    public static string nameInfo;

    public void Resume() //No botão da tela, para fechar a tela de informação e continuar o jogo
    {
        infoMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void Pause()  //Pausa para mostrar as infomações das cartas
    {
        infoMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;

    }

    public void OpenInfo()
    {
        //exibe a informação da respectiva carta encontrada
        gc = GameObject.Find("GameController2");
        gcs = gc.GetComponent<GameController2>();

        nameInfo = gcs.infoName;  //pega o nome da carta para saber qual informação exibir

        audioSource = GetComponent<AudioSource>();
        audioSource.PlayOneShot(succeed, 0.5F);
        
        if (nameInfo == "ferro")
        {
            Debug.Log("ferro");
            Pause();
            typeCard.text = "Você encontrou Ferro de passar!";
            typeInfo.text = "Ferros de passar são extremamente perigosos, podendo causar queimaduras de 3º grau,"+
                            " devem ser mantidos em lugares altos e longe do alcance das crianças, sempre lembre o adulto de retirar o ferro da tomada.";
            typeImage = Resources.Load<Sprite>("Sprites/Icons/ferro");
            imageT.sprite = typeImage;
        }
        if (nameInfo == "fosfor")
        {
            Pause();
            typeCard.text = "Você encontrou os fósforos e o isqueiro!";
            typeInfo.text = "Tanto fósforos quanto os isqueiros são materiais de alta combustão,"+
                           " podendo rápidamente causar queimaduras ou incendiar outros produtos inflamáveis."+
                           " Devemos tomar um cuidado redrobrado com o isqueiro, pois o seu fluido pode vazar causando acidentes.";
            typeImage = Resources.Load<Sprite>("Sprites/Icons/fosfor");
            imageT.sprite = typeImage;
        }
        if (nameInfo == "produtos")
        {
            Pause();
            typeCard.text = "Você encontrou os produtos químicos!";
            typeInfo.text = "Os produtos podem ser inflamáveis, podendo rápidamente começar um incendio ou causar queimaduras de 3º grau, "+
                            " mas alem dos riscos de queimaduras, produtos quimícos são muito tóxicos podendo causar intoxicação ou até envenenamento.";
            typeImage = Resources.Load<Sprite>("Sprites/Icons/produtos");
            imageT.sprite = typeImage;
        }
        if (nameInfo == "vela")
        {
            Pause();
            typeCard.text = "Você encontrou as velas!";
            typeInfo.text = "Velas em lugares inapropriados ou deixadas sem supervisão podem ser o foco inicial de incendios," +
                            " evite acende-las próximo à cortinas, plasticos, toalhas de mesa, etc. E sempre apague-as antes de sair ou dormir";
            typeImage = Resources.Load<Sprite>("Sprites/Icons/vela");
            imageT.sprite = typeImage;
        }
        if (nameInfo == "tomadas")
        {
            Pause();
            typeCard.text = "Você encontrou as tomadas!";
            typeInfo.text = "Peça para o adulto tampar as entradas das tomadas com capas protetoras apropriadas," +
            " jamais tente inserir algum objeto (principalmente metais) em uma tomada, pois há risco de causar curto circuito, incendios e choques elétricos .";
            typeImage = Resources.Load<Sprite>("Sprites/Icons/tomada");
            imageT.sprite = typeImage;
        }
    }
}
