using GearLib.Parts;
using SmashHammer.GearBlocks.Construction;
using UnityEngine;
using static SmashHammer.GearBlocks.Construction.PartPointGrid;

namespace AngledParts.Parts;

class Connector_22 : Part
{
    public Connector_22() : base("AngledParts/assets/angled_parts", "22_connector", 334914918761865, "Angle 22", "Connectors", 0.5f, true, true)
    {
        AddAttachmentPoint(
            "Inside_Multiple",
            AttachmentTypeFlags.RotaryBearing | AttachmentTypeFlags.LinearBearing | AttachmentTypeFlags.LinearRotaryBearing | AttachmentTypeFlags.Fixed,
            AlignmentFlags.IsInterior | AlignmentFlags.IsBidirectional | AlignmentFlags.IsFemale,
            new Vector3(0f, 0f, 0f),
            new Vector3(0, 0, 0),
            Vector3Int.one,
            true
        );

        AddAttachmentPoint(
            "Inside_Multiple",
            AttachmentTypeFlags.RotaryBearing | AttachmentTypeFlags.Fixed,
            AlignmentFlags.IsInterior | AlignmentFlags.IsFemale,
            new Vector3(0.04f, 0f, 0.1f),
            new Vector3(90, 22, 0),
            Vector3Int.one,
            true
        );
    }
}