using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

//Para usar o código, deve-se escolher um game object vazio, chamado ponto de soltura,
//que será onde o objeto vai ficar enquanto você estiver segurando e onde ele será depositado ao soltar o mouse.
//Enquanto você estiver com mouse precionado, o objeto estará sendo segurado; quando você soltar o mouse, ele para de ser segurado

public class Carregar : MonoBehaviour
{
    [SerializeField]
    Transform pontoSoltar;

    StarterAssetsMaps joaozinho;
    InputAction fireTwo;

    private void Awake()
    {
        joaozinho = new StarterAssetsMaps();
        fireTwo=joaozinho.Player.FireTwo;
        fireTwo.Enable();

    }
    bool soltou = false;
    bool carregando = false;
    public void OnPointerDown()
    {
        carregando = true;
    }

    public void OnPointerUp()
    {
        carregando=false;
    }

    private void Update()
    {
        if (carregando)
        {
            transform.position = pontoSoltar.position;
        }
    }
}
