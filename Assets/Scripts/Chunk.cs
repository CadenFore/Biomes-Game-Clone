using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chunk : MonoBehaviour {

    //Need a referance to a mesh renderer and mesh filter
    public MeshRenderer meshRenderer;
    public MeshFilter meshFilter;


    void Start () {


        int vertexIndex = 0;
        List<Vector3> vertices = new List<Vector3>();
        List<int> triangles = new List<int> ();
        List<Vector2> uvs = new List<Vector2>();

        for (int p = 0; p < 6; p++) {
            for (int i = 0; i < 6; i++)
            {

                /*The first line here is basically pulling an index from our voxelTris array, 
                 The 2nd line is adding the corresponding index vertices from our voxelVerts lookup table.
                */
                int triangleIndex = VoxelData.voxelTris[0, i];
                vertices.Add(VoxelData.voxelVerts[triangleIndex]);
                triangles.Add(vertexIndex);

                uvs.Add(VoxelData.voxelUvs[i]);

                vertexIndex++;

            }
        }

        Mesh mesh = new Mesh();
            mesh.vertices = vertices.ToArray ();
            mesh.triangles = triangles.ToArray ();
            mesh.uv = uvs.ToArray ();

        mesh.RecalculateNormals ();

        meshFilter.mesh = mesh;
    }


}
