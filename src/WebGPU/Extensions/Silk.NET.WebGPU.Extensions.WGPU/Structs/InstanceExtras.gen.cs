// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.WebGPU.Extensions.WGPU
{
    [NativeName("Name", "WGPUInstanceExtras")]
    public unsafe partial struct InstanceExtras
    {
        public InstanceExtras
        (
            ChainedStruct? chain = null,
            Silk.NET.WebGPU.Extensions.WGPU.InstanceBackend? backends = null,
            Dx12Compiler? dx12ShaderCompiler = null,
            byte* dxilPath = null,
            byte* dxcPath = null
        ) : this()
        {
            if (chain is not null)
            {
                Chain = chain.Value;
            }

            if (backends is not null)
            {
                Backends = backends.Value;
            }

            if (dx12ShaderCompiler is not null)
            {
                Dx12ShaderCompiler = dx12ShaderCompiler.Value;
            }

            if (dxilPath is not null)
            {
                DxilPath = dxilPath;
            }

            if (dxcPath is not null)
            {
                DxcPath = dxcPath;
            }
        }


        [NativeName("Type", "WGPUChainedStruct")]
        [NativeName("Type.Name", "WGPUChainedStruct")]
        [NativeName("Name", "chain")]
        public ChainedStruct Chain;

        [NativeName("Type", "WGPUInstanceBackendFlags")]
        [NativeName("Type.Name", "WGPUInstanceBackendFlags")]
        [NativeName("Name", "backends")]
        public Silk.NET.WebGPU.Extensions.WGPU.InstanceBackend Backends;

        [NativeName("Type", "WGPUDx12Compiler")]
        [NativeName("Type.Name", "WGPUDx12Compiler")]
        [NativeName("Name", "dx12ShaderCompiler")]
        public Dx12Compiler Dx12ShaderCompiler;

        [NativeName("Type", "const char *")]
        [NativeName("Type.Name", "const char *")]
        [NativeName("Name", "dxilPath")]
        public byte* DxilPath;

        [NativeName("Type", "const char *")]
        [NativeName("Type.Name", "const char *")]
        [NativeName("Name", "dxcPath")]
        public byte* DxcPath;
    }
}
