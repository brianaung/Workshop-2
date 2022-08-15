using System.Linq;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
public class GeneratePyramid : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var meshFilter = GetComponent<MeshFilter>();
        meshFilter.mesh = CreateMesh();
        
    }

    private Mesh CreateMesh()
    {
        var mesh = new Mesh
        {
            name = "Pyramid"
        };

        mesh.SetVertices(new[]
        {
            // face 1
            new Vector3(0, 1.0f, 0),
            new Vector3(-1.0f, 0, 1.0f),
            new Vector3(1.0f, 0, 1.0f),
            

            // face 2
            new Vector3(0, 1.0f, 0),
            new Vector3(-1.0f, 0, -1.0f),
            new Vector3(-1.0f, 0, 1.0f),

            // face 3
            new Vector3(0, 1.0f, 0),
            new Vector3(1.0f, 0, -1.0f),
            new Vector3(-1.0f, 0, -1.0f),


            // face 4
            new Vector3(0, 1.0f, 0),
            new Vector3(1.0f, 0, 1.0f),
            new Vector3(1.0f, 0, -1.0f),

            // Bottom face
            new Vector3(1.0f, 0, 1.0f),
            new Vector3(-1.0f, 0, 1.0f),
            new Vector3(-1.0f, 0, -1.0f),

            new Vector3(1.0f, 0, 1.0f),
            new Vector3(-1.0f, 0, -1.0f),
            new Vector3(1.0f, 0, -1.0f),

        });

        mesh.SetColors(new[]
        {
            Color.red,
            Color.red,
            Color.red,

            Color.green,
            Color.green,
            Color.green,

            Color.blue,
            Color.blue,
            Color.blue,

            Color.yellow,
            Color.yellow,
            Color.yellow,

            Color.cyan,
            Color.cyan,
            Color.cyan,
            Color.cyan,
            Color.cyan,
            Color.cyan,

        });

        var indices = Enumerable.Range(0, mesh.vertices.Length).ToArray();
        mesh.SetIndices(indices, MeshTopology.Triangles, 0);

        return mesh;
    }
}
