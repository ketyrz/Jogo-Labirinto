using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Labirinto : MonoBehaviour
{
    public GameObject modeloParede;
    public Texture2D imagemLabirinto;

    // Start is called before the first frame update
    void Start()
    {
        for (int col = 0; col < imagemLabirinto.width;  col++)
        {
            for (int row = 0; row < imagemLabirinto.height; row++)
            {
                var pixel = imagemLabirinto.GetPixel(col, row);

                if (pixel == Color.white)
                {
                    var posicao = new Vector3(col, 0, row);

                    Instantiate(modeloParede, posicao, Quaternion.identity, transform);
                }
            }
        }
    }
}
