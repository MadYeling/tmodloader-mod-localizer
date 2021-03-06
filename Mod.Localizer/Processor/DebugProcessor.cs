﻿using System.Collections.Generic;
using System.IO;
using dnlib.DotNet;
using Mod.Localizer.ContentFramework;

namespace Mod.Localizer.Processor
{
    internal sealed class DebugProcessor : Processor<Content>
    {
        public override IReadOnlyList<Content> DumpContents()
        {
            DumpMainAssembly();

            return new List<Content>();
        }

        public override void PatchContents(IReadOnlyList<Content> contents)
        {
        }

        private void DumpMainAssembly()
        {
            var dll = ModFile.GetMainAssembly();
            var pdb = ModFile.GetMainPdb();

            var dllPath = ModFile.Name + "." + nameof(dll);
            var pdbPath = ModFile.Name + "." + nameof(pdb);

            File.WriteAllBytes(dllPath, dll);
            if (pdb != null)
            {
                File.WriteAllBytes(pdbPath, pdb);
            }

            Logger.Debug("Write assembly files: {0}, {1}", dllPath, pdbPath);
        }

        public DebugProcessor(Localizer localizer, ModuleDef modModule) : base(localizer, modModule)
        {
        }
    }
}
