﻿using HtmlAgilityPack;
using NetStone.Definitions.Model.Character;

namespace NetStone.Model.Parseables.Character.Gear;

/// <summary>
/// Container class holding information about a character's equipped gear.
/// </summary>
public class CharacterGear : LodestoneParseable
{
    private readonly LodestoneClient client;
    private readonly CharacterGearDefinition definition;

    /// <summary>
    /// Constructs parser for character gear
    /// </summary>
    /// <param name="client"></param>
    /// <param name="rootNode"></param>
    /// <param name="definition"></param>
    public CharacterGear(LodestoneClient client, HtmlNode rootNode, CharacterGearDefinition definition) : base(rootNode)
    {
        this.client = client;
        this.definition = definition;
    }

    /// <summary>
    /// Information about the characters' weapon. Null if none equipped.
    /// </summary>
    public GearEntry? Mainhand => new GearEntry(this.client, this.RootNode, this.definition.Mainhand).GetOptional();

    /// <summary>
    /// Information about the characters' shield/offhand. Null if none equipped.
    /// </summary>
    public GearEntry? Offhand => new GearEntry(this.client, this.RootNode, this.definition.Offhand).GetOptional();

    /// <summary>
    /// Information about the characters' headgear. Null if none equipped.
    /// </summary>
    public GearEntry? Head => new GearEntry(this.client, this.RootNode, this.definition.Head).GetOptional();

    /// <summary>
    /// Information about the characters' body gear. Null if none equipped.
    /// </summary>
    public GearEntry? Body => new GearEntry(this.client, this.RootNode, this.definition.Body).GetOptional();

    /// <summary>
    /// Information about the characters' gloves. Null if none equipped.
    /// </summary>
    public GearEntry? Hands => new GearEntry(this.client, this.RootNode, this.definition.Hands).GetOptional();

    /// <summary>
    /// Information about the characters' waist gear. Null if none equipped.
    /// </summary>
    public GearEntry? Waist => new GearEntry(this.client, this.RootNode, this.definition.Waist).GetOptional();

    /// <summary>
    /// Information about the characters' pants. Null if none equipped.
    /// </summary>
    public GearEntry? Legs => new GearEntry(this.client, this.RootNode, this.definition.Legs).GetOptional();

    /// <summary>
    /// Information about the characters' shoes. Null if none equipped.
    /// </summary>
    public GearEntry? Feet => new GearEntry(this.client, this.RootNode, this.definition.Feet).GetOptional();

    /// <summary>
    /// Information about the characters' earrings. Null if none equipped.
    /// </summary>
    public GearEntry? Earrings => new GearEntry(this.client, this.RootNode, this.definition.Earrings).GetOptional();

    /// <summary>
    /// Information about the characters' necklace. Null if none equipped.
    /// </summary>
    public GearEntry? Necklace => new GearEntry(this.client, this.RootNode, this.definition.Necklace).GetOptional();

    /// <summary>
    /// Information about the characters' bracelets. Null if none equipped.
    /// </summary>
    public GearEntry? Bracelets => new GearEntry(this.client, this.RootNode, this.definition.Bracelets).GetOptional();

    /// <summary>
    /// Information about the characters' first ring. Null if none equipped.
    /// </summary>
    public GearEntry? Ring1 => new GearEntry(this.client, this.RootNode, this.definition.Ring1).GetOptional();

    /// <summary>
    /// Information about the characters' second ring. Null if none equipped.
    /// </summary>
    public GearEntry? Ring2 => new GearEntry(this.client, this.RootNode, this.definition.Ring2).GetOptional();

    /// <summary>
    /// Information about the characters' soul crystal. Null if none equipped.
    /// </summary>
    public SoulcrystalEntry? Soulcrystal =>
        new SoulcrystalEntry(this.RootNode, this.definition.Soulcrystal).GetOptional();
}