using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class VoxelData {

    /* This is static so it can be accessed anywhere. We start with a minecraft voxel (Basically a big cube) that has 8 corners 
      and this helps us keep track of where those corners are located. We will start by making a lookup table that stores all of 
      this information about where these 8 vertices are.
      also making it readonly so data doesnt get changed later on accidentally. This doesn't do anything besides store data that we will need later on */

    //This is a lookup table
    public static readonly Vector3[] voxelVerts = new Vector3 [8] {

        new Vector3(0.0f, 0.0f, 0.0f),
        new Vector3(1.0f, 0.0f, 0.0f),
        new Vector3(1.0f, 1.0f, 0.0f),
        new Vector3(0.0f, 1.0f, 0.0f),
        new Vector3(0.0f, 0.0f, 1.0f),
        new Vector3(1.0f, 0.0f, 1.0f),
        new Vector3(1.0f, 1.0f, 1.0f),
        new Vector3(0.0f, 1.0f, 1.0f),

    };

    public static readonly int[,] voxelTris = new int[6,6] {

        {0, 3, 1, 1, 3, 2}, // Back Face
        {5, 6, 4, 4, 6, 7}, // Front Face
        {3, 7, 2, 2, 7, 6}, // Top Face
        {1, 5, 0, 0, 5, 4}, // Bottom Face
        {4, 7, 0, 0, 7, 3}, // Left Face
        {1, 2, 5, 5, 2, 6} // Right Face

   };

    public static readonly Vector2[] voxelUvs = new Vector2[6] {

        new Vector2(0.0f, 0.0f),
        new Vector2(0.0f, 1.0f),
        new Vector2(1.0f, 0.0f),
        new Vector2(1.0f, 0.0f),
        new Vector2(0.0f, 1.0f),
        new Vector2(1.0f, 1.0f),
    };


}
