﻿using System.Collections.Generic;
using System.Linq;
using dnlib.DotNet;
using dnlib.DotNet.Emit;
using Mod.Localizer.ContentFramework;
using Mod.Localizer.Extensions;
using Terraria.ModLoader;

namespace Mod.Localizer.ContentProcessor
{
    public sealed class ItemProcessor : Processor<ItemContent>
    {
        public ItemProcessor(TmodFileWrapper.ITmodFile modFile, ModuleDef modModule) : base(modFile, modModule)
        {
        }

        protected override bool Selector(TypeDef type)
        {
            return type.HasBaseType("Terraria.ModLoader.ModItem");
        }

        [ProcessTarget(nameof(ModItem.SetStaticDefaults), nameof(ItemContent.Name), nameof(ItemContent.ToolTip))]
        public Instruction[] BasicInformation(MethodDef method)
        {
            var insts = new Instruction[2];

            foreach (var instruction in method.Body.Instructions.Where(
                i => i.Operand is IMethodDefOrRef m && m.IsMethod("ModTranslation", "SetDefault")))
            {
                var source = method.Body.FindObjectInstance(instruction);
                var value = method.Body.FindStringLiteralBefore(instruction);
                if (source == null || value == null)
                {
                    continue;
                }

                switch (((IMethodDefOrRef)source.Operand).Name)
                {
                    case "get_Tooltip":
                        insts[1] = value;
                        break;
                    case "get_DisplayName":
                        insts[0] = value;
                        break;
                }
            }

            return insts;
        }

        [ProcessTarget(nameof(ModItem.UpdateArmorSet), nameof(ItemContent.SetBonus))]
        public Instruction[] BonusText(MethodDef method)
        {
            foreach (var instruction in method.Body.Instructions.Where(i => i.OpCode == OpCodes.Stfld))
            {
                var ldstr = method.Body.FindStringLiteralBefore(instruction);

                switch (((IMemberRef)instruction.Operand).Name)
                {
                    case "setBonus":
                        return new[] { ldstr };
                }
            }

            return new Instruction[0];
        }

        [ProcessTarget(nameof(ModItem.ModifyTooltips), nameof(ItemContent.ModifyTooltips))]
        public Instruction[] ModifyTooltips(MethodDef method)
        {
            var result = new List<Instruction>();

            var inst = method.Body.Instructions;

            for (var index = 0; index < inst.Count; index++)
            {
                var ins = inst[index];

                if (ins.OpCode != OpCodes.Newobj || !(ins.Operand is MemberRef m) || !m.DeclaringType.Name.Equals("TooltipLine"))
                    continue;

                ins = inst[index - 1];

                if (ins.OpCode.Equals(OpCodes.Ldstr))
                {
                    result.Add(ins);
                }
                else if (ins.OpCode.Equals(OpCodes.Call) && ins.Operand is MemberRef n && n.Name.Equals("Concat"))
                {
                    var list = method.Body.FindStringLiteralsOf(ins);

                    // the list given above is in reverse order
                    result.AddRange(list.Reverse());
                }
            }

            return result.ToArray();
        }
    }
}
