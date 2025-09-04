using System;
using System.Collections.Generic;
using Vintagestory.API.Client;
using Vintagestory.API.Common;
using Vintagestory.API.Common.Entities;
using Vintagestory.API.Config;
using Vintagestory.API.Datastructures;
using Vintagestory.API.MathTools;
using Vintagestory.API.Server;
using Vintagestory.API.Util;

namespace CetusBorealis;
public class Core : ModSystem
{
    public override void Start(ICoreAPI api)
    {
        api.RegisterBlockClass("CetusBorealis.BlockSDFirepit", typeof(BlockSDFirepit));
        api.RegisterBlockEntityClass("CetusBorealis.SDFirepit", typeof(SDFirepit));

    }
    public class BlockSDFirepit : BlockEntityFirepit //Taking base Firepit Class
    {
        public override MeshData getOrCreateMesh(string burnstate, string contentstate)
        {
            return // no mesh override for you
        }
    }
}