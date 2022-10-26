using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
//informações das cartas encontradas
[RequireComponent(typeof(AudioSource))]
public class CardsInfo : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject infoMenuUI;

    GameObject gc;  //gc: GameController
    GameController gcs;

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
        gc = GameObject.Find("GameController");
        gcs = gc.GetComponent<GameController>();

        nameInfo = gcs.infoName;  //pega o nome da carta para saber qual informação exibir

        audioSource = GetComponent<AudioSource>();
        audioSource.PlayOneShot(succeed, 0.7F);

        if (nameInfo == "churrasqueiras")
        {
            Pause();
            typeCard.text = "Você encontrou a churrasqueira!";
            typeInfo.text = "Devemos tomar cuidado com as partes metálicas da churrasqueira, e não brincar em suas proximidades " +
                            "Para acender peça para o adulto responsável utilizar elétrico acendedor ou um pão sem miolo embebido em Álcool Gel. ";
            
            typeImage = Resources.Load<Sprite>("Sprites/Icons/churrasqueira");
            imageT.sprite = typeImage;
        }
        if (nameInfo == "fogao")
        {
            Pause();
            typeCard.text = "Você encontrou o fogão!";
            typeInfo.text = "Não se deve brincar com os botões do fogão nem tentar alcançar as panelas que estão sobre o tampo," +
                            " peça para o adulto responsável manter os cabos sempre voltados para parte de central do fogão e evite se aproximar do forno quando estiver ligado.";
            
            typeImage = Resources.Load<Sprite>("Sprites/Icons/fogao");
            imageT.sprite = typeImage;
        }
        if (nameInfo == "frituras")
        {
            Pause();
            typeCard.text = "Você encontrou as frituras!";
            typeInfo.text = "Frituras e óleos em geral são muito perigosos, jamais tente alcançar uma panela com óleo quente, " +
                            "caso o óleo pegue fogo o correto é pedir para um adulto desligar o fogo, não tocar na panela e cobri-la com um pano bem úmido.";
            
            typeImage = Resources.Load<Sprite>("Sprites/Icons/frituras");
            imageT.sprite = typeImage;
        }
        if (nameInfo == "microondas")
        {
            Pause();
            typeCard.text = "Você encontrou o microondas!";
            typeInfo.text = "Atenção! Materiais como aluminio, metal, isopor, papel e plastico podem causar acidentes e até incêndios." +
                            " Além disso devemos tomar cuidado com liquidos, quando muito aquecidos podem explodir causando queimaduras.";
            
            typeImage = Resources.Load<Sprite>("Sprites/Icons/microondas");
            imageT.sprite = typeImage;
        }
        if (nameInfo == "panela")
        {
            Pause();
            typeCard.text = "Você encontrou a panela!";
            typeInfo.text = "Muito cuidado com panelas sobre o fogão, estando ligado ou não, panelas podem conter liquidos quentes que causam queimaduras." +
                            " Sempre lembre o adulto responsável de deixar os cabo voltado para o centro do fogão";
            
            typeImage = Resources.Load<Sprite>("Sprites/Icons/panela");
            imageT.sprite = typeImage;
        }
    }
}
