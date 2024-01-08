using GearLib.Parts;
using SmashHammer.GearBlocks.Construction;
using UnityEngine;
using static SmashHammer.GearBlocks.Construction.PartPointGrid;

namespace AngledParts.Parts;

class Bracket_45 : Part
{
    public Bracket_45() : base("AngledParts/assets/angled_parts", "45_bracket", 748933236416855, "45 Degree Bracket", "Blocks", 0.5f, true, true)
    {
        // Bottom Attachments
        AddAttachmentPoint(
            "Inside_Multiple",
            AttachmentTypeFlags.RotaryBearing | AttachmentTypeFlags.LinearBearing | AttachmentTypeFlags.LinearRotaryBearing,
            AlignmentFlags.IsInterior | AlignmentFlags.IsBidirectional | AlignmentFlags.IsFemale,
            new Vector3(0f, 0f, 0f),
            new Vector3(45, 270, 90),
            Vector3Int.one,
            true
        );
        
        AddAttachmentPoint(
            "Outer_Fixed",
            AttachmentTypeFlags.Fixed,
            AlignmentFlags.UNUSED,
            new Vector3(0f, 0f, 0.05f),
            new Vector3(90, 0, 0),
            Vector3Int.one,
            true
        );

        AddAttachmentPoint(
            "Outer_Fixed",
            AttachmentTypeFlags.Fixed,
            AlignmentFlags.UNUSED,
            new Vector3(0f, 0f, -0.05f),
            new Vector3(270, 0, 0),
            Vector3Int.one,
            true
        );
        
        AddAttachmentPoint(
            "Outer_Fixed",
            AttachmentTypeFlags.Fixed,
            AlignmentFlags.UNUSED,
            new Vector3(0f, -0.05f, 0f),
            new Vector3(0, 180, 180),
            Vector3Int.one,
            true
        );

        // Top Attachments 1
        // AddAttachmentPoint(
        //     "Inside_Multiple",
        //     AttachmentTypeFlags.RotaryBearing | AttachmentTypeFlags.LinearBearing | AttachmentTypeFlags.LinearRotaryBearing,
        //     AlignmentFlags.IsInterior | AlignmentFlags.IsBidirectional | AlignmentFlags.IsFemale,
        //     new Vector3(-0.1f, 0.1f, 0f),
        //     new Vector3(45, 270, 90)
        // );

        // AddAttachmentPoint(
        //     "Outer_Fixed",
        //     AttachmentTypeFlags.Fixed,
        //     AlignmentFlags.UNUSED,
        //     new Vector3(-0.1f, 0.1f, -0.05f),
        //     new Vector3(45, 270, 90)
        // );
        
        // AddAttachmentPoint(
        //     "Outer_Fixed",
        //     AttachmentTypeFlags.Fixed,
        //     AlignmentFlags.UNUSED,
        //     new Vector3(-0.1f, 0.1f, 0.05f),
        //     new Vector3(45, 90, 90)
        // );
        
        // Top Attachments 2
        AddAttachmentPoint(
            "Inside_Multiple",
            AttachmentTypeFlags.RotaryBearing | AttachmentTypeFlags.LinearBearing | AttachmentTypeFlags.LinearRotaryBearing,
            AlignmentFlags.IsInterior | AlignmentFlags.IsBidirectional | AlignmentFlags.IsFemale,
            new Vector3(0.1f, 0.1f, 0f),
            new Vector3(45, 270, 90),
            Vector3Int.one,
            true
        );

        AddAttachmentPoint(
            "Outer_Fixed",
            AttachmentTypeFlags.Fixed,
            AlignmentFlags.UNUSED,
            new Vector3(0.1f, 0.1f, -0.05f),
            new Vector3(45, 270, 90),
            Vector3Int.one,
            true
        );
        
        AddAttachmentPoint(
            "Outer_Fixed",
            AttachmentTypeFlags.Fixed,
            AlignmentFlags.UNUSED,
            new Vector3(0.1f, 0.1f, 0.05f),
            new Vector3(45, 90, 90),
            Vector3Int.one,
            true
        );
    }
}