using Robust.Shared.Configuration;

namespace Content.Shared._Funkystation.CCVar;

[CVarDefs]
public sealed class CueCardCVars
{
    public static readonly CVarDef<bool> CueCardsEnabled =
        CVarDef.Create("cue_cards.enabled", true, CVar.SERVER);
}
