using Content.Shared.Atmos;
using Robust.Shared.GameStates;

namespace Content.Server._Funkystation.Anomaly.Components;

[RegisterComponent]
public sealed partial class ResonatorGasStorageComponent : Component
{
    [DataField]
    public GasMixture FuelMix { get; set; }

    [DataField]
    public GasMixture CatalystMix { get; set; }
}
