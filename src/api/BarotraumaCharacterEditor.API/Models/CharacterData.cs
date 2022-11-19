namespace BarotraumaCharacterEditor.API.Models
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class CharacterData
    {

        private CharacterDataCharacterCampaignData[] characterCampaignDataField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CharacterCampaignData")]
        public CharacterDataCharacterCampaignData[] CharacterCampaignData
        {
            get
            {
                return this.characterCampaignDataField;
            }
            set
            {
                this.characterCampaignDataField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CharacterDataCharacterCampaignData
    {

        private CharacterDataCharacterCampaignDataCharacter characterField;

        private CharacterDataCharacterCampaignDataItem[] inventoryField;

        private CharacterDataCharacterCampaignDataHealth healthField;

        private CharacterDataCharacterCampaignDataOrder[] ordersField;

        private CharacterDataCharacterCampaignDataWallet walletField;

        private string nameField;

        private string addressField;

        private string accountidField;

        /// <remarks/>
        public CharacterDataCharacterCampaignDataCharacter Character
        {
            get
            {
                return this.characterField;
            }
            set
            {
                this.characterField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Item", IsNullable = false)]
        public CharacterDataCharacterCampaignDataItem[] inventory
        {
            get
            {
                return this.inventoryField;
            }
            set
            {
                this.inventoryField = value;
            }
        }

        /// <remarks/>
        public CharacterDataCharacterCampaignDataHealth health
        {
            get
            {
                return this.healthField;
            }
            set
            {
                this.healthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("order", IsNullable = false)]
        public CharacterDataCharacterCampaignDataOrder[] orders
        {
            get
            {
                return this.ordersField;
            }
            set
            {
                this.ordersField = value;
            }
        }

        /// <remarks/>
        public CharacterDataCharacterCampaignDataWallet Wallet
        {
            get
            {
                return this.walletField;
            }
            set
            {
                this.walletField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string address
        {
            get
            {
                return this.addressField;
            }
            set
            {
                this.addressField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string accountid
        {
            get
            {
                return this.accountidField;
            }
            set
            {
                this.accountidField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CharacterDataCharacterCampaignDataCharacter
    {

        private CharacterDataCharacterCampaignDataCharacterJob jobField;

        private CharacterDataCharacterCampaignDataCharacterSavedstatvalues savedstatvaluesField;

        private string nameField;

        private string originalnameField;

        private string speciesnameField;

        private string tagsField;

        private ushort salaryField;

        private ushort experiencepointsField;

        private string unlockedtalentsField;

        private byte additionaltalentpointsField;

        private byte hairindexField;

        private byte beardindexField;

        private byte moustacheindexField;

        private byte faceattachmentindexField;

        private string skincolorField;

        private string haircolorField;

        private string facialhaircolorField;

        private bool startitemsgivenField;

        private string ragdollField;

        private string personalityField;

        private byte missionscompletedsincedeathField;

        private ushort hullField;

        private bool hullFieldSpecified;

        /// <remarks/>
        public CharacterDataCharacterCampaignDataCharacterJob job
        {
            get
            {
                return this.jobField;
            }
            set
            {
                this.jobField = value;
            }
        }

        /// <remarks/>
        public CharacterDataCharacterCampaignDataCharacterSavedstatvalues savedstatvalues
        {
            get
            {
                return this.savedstatvaluesField;
            }
            set
            {
                this.savedstatvaluesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string originalname
        {
            get
            {
                return this.originalnameField;
            }
            set
            {
                this.originalnameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string speciesname
        {
            get
            {
                return this.speciesnameField;
            }
            set
            {
                this.speciesnameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string tags
        {
            get
            {
                return this.tagsField;
            }
            set
            {
                this.tagsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort salary
        {
            get
            {
                return this.salaryField;
            }
            set
            {
                this.salaryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort experiencepoints
        {
            get
            {
                return this.experiencepointsField;
            }
            set
            {
                this.experiencepointsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string unlockedtalents
        {
            get
            {
                return this.unlockedtalentsField;
            }
            set
            {
                this.unlockedtalentsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte additionaltalentpoints
        {
            get
            {
                return this.additionaltalentpointsField;
            }
            set
            {
                this.additionaltalentpointsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte hairindex
        {
            get
            {
                return this.hairindexField;
            }
            set
            {
                this.hairindexField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte beardindex
        {
            get
            {
                return this.beardindexField;
            }
            set
            {
                this.beardindexField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte moustacheindex
        {
            get
            {
                return this.moustacheindexField;
            }
            set
            {
                this.moustacheindexField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte faceattachmentindex
        {
            get
            {
                return this.faceattachmentindexField;
            }
            set
            {
                this.faceattachmentindexField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string skincolor
        {
            get
            {
                return this.skincolorField;
            }
            set
            {
                this.skincolorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string haircolor
        {
            get
            {
                return this.haircolorField;
            }
            set
            {
                this.haircolorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string facialhaircolor
        {
            get
            {
                return this.facialhaircolorField;
            }
            set
            {
                this.facialhaircolorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool startitemsgiven
        {
            get
            {
                return this.startitemsgivenField;
            }
            set
            {
                this.startitemsgivenField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ragdoll
        {
            get
            {
                return this.ragdollField;
            }
            set
            {
                this.ragdollField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string personality
        {
            get
            {
                return this.personalityField;
            }
            set
            {
                this.personalityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte missionscompletedsincedeath
        {
            get
            {
                return this.missionscompletedsincedeathField;
            }
            set
            {
                this.missionscompletedsincedeathField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort hull
        {
            get
            {
                return this.hullField;
            }
            set
            {
                this.hullField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool hullSpecified
        {
            get
            {
                return this.hullFieldSpecified;
            }
            set
            {
                this.hullFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CharacterDataCharacterCampaignDataCharacterJob
    {

        private CharacterDataCharacterCampaignDataCharacterJobSkill[] skillField;

        private string nameField;

        private string identifierField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("skill")]
        public CharacterDataCharacterCampaignDataCharacterJobSkill[] skill
        {
            get
            {
                return this.skillField;
            }
            set
            {
                this.skillField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string identifier
        {
            get
            {
                return this.identifierField;
            }
            set
            {
                this.identifierField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CharacterDataCharacterCampaignDataCharacterJobSkill
    {

        private string identifierField;

        private decimal levelField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string identifier
        {
            get
            {
                return this.identifierField;
            }
            set
            {
                this.identifierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal level
        {
            get
            {
                return this.levelField;
            }
            set
            {
                this.levelField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CharacterDataCharacterCampaignDataCharacterSavedstatvalues
    {

        private CharacterDataCharacterCampaignDataCharacterSavedstatvaluesSavedstatvalue savedstatvalueField;

        /// <remarks/>
        public CharacterDataCharacterCampaignDataCharacterSavedstatvaluesSavedstatvalue savedstatvalue
        {
            get
            {
                return this.savedstatvalueField;
            }
            set
            {
                this.savedstatvalueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CharacterDataCharacterCampaignDataCharacterSavedstatvaluesSavedstatvalue
    {

        private string stattypeField;

        private string statidentifierField;

        private byte statvalueField;

        private bool removeondeathField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string stattype
        {
            get
            {
                return this.stattypeField;
            }
            set
            {
                this.stattypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string statidentifier
        {
            get
            {
                return this.statidentifierField;
            }
            set
            {
                this.statidentifierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte statvalue
        {
            get
            {
                return this.statvalueField;
            }
            set
            {
                this.statvalueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool removeondeath
        {
            get
            {
                return this.removeondeathField;
            }
            set
            {
                this.removeondeathField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CharacterDataCharacterCampaignDataItem
    {

        private object[] itemsField;

        private string nameField;

        private string identifierField;

        private ushort idField;

        private string rectField;

        private string nonInteractableField;

        private string nonPlayerTeamInteractableField;

        private string allowSwappingField;

        private sbyte rotationField;

        private decimal scaleField;

        private string spriteColorField;

        private string inventoryIconColorField;

        private string containerColorField;

        private decimal conditionField;

        private string invulnerableToDamageField;

        private string tagsField;

        private string displaySideBySideWhenLinkedField;

        private string disallowedUpgradesField;

        private decimal spriteDepthField;

        private string hiddenInGameField;

        private byte iField;

        private string allowStealingField;

        private string originalOutpostField;

        private bool flippedxField;

        private bool flippedxFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Holdable", typeof(CharacterDataCharacterCampaignDataItemHoldable))]
        [System.Xml.Serialization.XmlElementAttribute("IdCard", typeof(CharacterDataCharacterCampaignDataItemIdCard))]
        [System.Xml.Serialization.XmlElementAttribute("ItemContainer", typeof(CharacterDataCharacterCampaignDataItemItemContainer))]
        [System.Xml.Serialization.XmlElementAttribute("LightComponent", typeof(CharacterDataCharacterCampaignDataItemLightComponent))]
        [System.Xml.Serialization.XmlElementAttribute("MeleeWeapon", typeof(CharacterDataCharacterCampaignDataItemMeleeWeapon))]
        [System.Xml.Serialization.XmlElementAttribute("MiniMap", typeof(CharacterDataCharacterCampaignDataItemMiniMap))]
        [System.Xml.Serialization.XmlElementAttribute("Pickable", typeof(CharacterDataCharacterCampaignDataItemPickable))]
        [System.Xml.Serialization.XmlElementAttribute("Projectile", typeof(CharacterDataCharacterCampaignDataItemProjectile))]
        [System.Xml.Serialization.XmlElementAttribute("Quality", typeof(CharacterDataCharacterCampaignDataItemQuality))]
        [System.Xml.Serialization.XmlElementAttribute("RangedWeapon", typeof(CharacterDataCharacterCampaignDataItemRangedWeapon))]
        [System.Xml.Serialization.XmlElementAttribute("RepairTool", typeof(CharacterDataCharacterCampaignDataItemRepairTool))]
        [System.Xml.Serialization.XmlElementAttribute("Rope", typeof(CharacterDataCharacterCampaignDataItemRope))]
        [System.Xml.Serialization.XmlElementAttribute("StatusHUD", typeof(CharacterDataCharacterCampaignDataItemStatusHUD))]
        [System.Xml.Serialization.XmlElementAttribute("Wearable", typeof(CharacterDataCharacterCampaignDataItemWearable))]
        [System.Xml.Serialization.XmlElementAttribute("WifiComponent", typeof(CharacterDataCharacterCampaignDataItemWifiComponent))]
        [System.Xml.Serialization.XmlElementAttribute("Wire", typeof(CharacterDataCharacterCampaignDataItemWire))]
        [System.Xml.Serialization.XmlElementAttribute("inventory", typeof(CharacterDataCharacterCampaignDataItemInventory))]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string identifier
        {
            get
            {
                return this.identifierField;
            }
            set
            {
                this.identifierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string rect
        {
            get
            {
                return this.rectField;
            }
            set
            {
                this.rectField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NonInteractable
        {
            get
            {
                return this.nonInteractableField;
            }
            set
            {
                this.nonInteractableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NonPlayerTeamInteractable
        {
            get
            {
                return this.nonPlayerTeamInteractableField;
            }
            set
            {
                this.nonPlayerTeamInteractableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AllowSwapping
        {
            get
            {
                return this.allowSwappingField;
            }
            set
            {
                this.allowSwappingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public sbyte Rotation
        {
            get
            {
                return this.rotationField;
            }
            set
            {
                this.rotationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Scale
        {
            get
            {
                return this.scaleField;
            }
            set
            {
                this.scaleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SpriteColor
        {
            get
            {
                return this.spriteColorField;
            }
            set
            {
                this.spriteColorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string InventoryIconColor
        {
            get
            {
                return this.inventoryIconColorField;
            }
            set
            {
                this.inventoryIconColorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ContainerColor
        {
            get
            {
                return this.containerColorField;
            }
            set
            {
                this.containerColorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Condition
        {
            get
            {
                return this.conditionField;
            }
            set
            {
                this.conditionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string InvulnerableToDamage
        {
            get
            {
                return this.invulnerableToDamageField;
            }
            set
            {
                this.invulnerableToDamageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Tags
        {
            get
            {
                return this.tagsField;
            }
            set
            {
                this.tagsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DisplaySideBySideWhenLinked
        {
            get
            {
                return this.displaySideBySideWhenLinkedField;
            }
            set
            {
                this.displaySideBySideWhenLinkedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DisallowedUpgrades
        {
            get
            {
                return this.disallowedUpgradesField;
            }
            set
            {
                this.disallowedUpgradesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal SpriteDepth
        {
            get
            {
                return this.spriteDepthField;
            }
            set
            {
                this.spriteDepthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string HiddenInGame
        {
            get
            {
                return this.hiddenInGameField;
            }
            set
            {
                this.hiddenInGameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte i
        {
            get
            {
                return this.iField;
            }
            set
            {
                this.iField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AllowStealing
        {
            get
            {
                return this.allowStealingField;
            }
            set
            {
                this.allowStealingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string OriginalOutpost
        {
            get
            {
                return this.originalOutpostField;
            }
            set
            {
                this.originalOutpostField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool flippedx
        {
            get
            {
                return this.flippedxField;
            }
            set
            {
                this.flippedxField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool flippedxSpecified
        {
            get
            {
                return this.flippedxFieldSpecified;
            }
            set
            {
                this.flippedxFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CharacterDataCharacterCampaignDataItemHoldable
    {

        private string holdPosField;

        private sbyte holdAngleField;

        private string swingAmountField;

        private byte swingSpeedField;

        private string swingWhenHoldingField;

        private string swingWhenAimingField;

        private string swingWhenUsingField;

        private string disableHeadRotationField;

        private decimal spriteDepthWhenDroppedField;

        private byte pickingTimeField;

        private string canBePickedField;

        private string allowInGameEditingField;

        private string msgField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string HoldPos
        {
            get
            {
                return this.holdPosField;
            }
            set
            {
                this.holdPosField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public sbyte HoldAngle
        {
            get
            {
                return this.holdAngleField;
            }
            set
            {
                this.holdAngleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SwingAmount
        {
            get
            {
                return this.swingAmountField;
            }
            set
            {
                this.swingAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte SwingSpeed
        {
            get
            {
                return this.swingSpeedField;
            }
            set
            {
                this.swingSpeedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SwingWhenHolding
        {
            get
            {
                return this.swingWhenHoldingField;
            }
            set
            {
                this.swingWhenHoldingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SwingWhenAiming
        {
            get
            {
                return this.swingWhenAimingField;
            }
            set
            {
                this.swingWhenAimingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SwingWhenUsing
        {
            get
            {
                return this.swingWhenUsingField;
            }
            set
            {
                this.swingWhenUsingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DisableHeadRotation
        {
            get
            {
                return this.disableHeadRotationField;
            }
            set
            {
                this.disableHeadRotationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal SpriteDepthWhenDropped
        {
            get
            {
                return this.spriteDepthWhenDroppedField;
            }
            set
            {
                this.spriteDepthWhenDroppedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte PickingTime
        {
            get
            {
                return this.pickingTimeField;
            }
            set
            {
                this.pickingTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CanBePicked
        {
            get
            {
                return this.canBePickedField;
            }
            set
            {
                this.canBePickedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AllowInGameEditing
        {
            get
            {
                return this.allowInGameEditingField;
            }
            set
            {
                this.allowInGameEditingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Msg
        {
            get
            {
                return this.msgField;
            }
            set
            {
                this.msgField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CharacterDataCharacterCampaignDataItemIdCard
    {

        private string teamIDField;

        private string ownerTagsField;

        private string ownerNameField;

        private string ownerJobIdField;

        private byte ownerHairIndexField;

        private byte ownerBeardIndexField;

        private byte ownerMoustacheIndexField;

        private byte ownerFaceAttachmentIndexField;

        private string ownerHairColorField;

        private string ownerFacialHairColorField;

        private string ownerSkinColorField;

        private string ownerSheetIndexField;

        private byte pickingTimeField;

        private string canBePickedField;

        private string allowInGameEditingField;

        private string msgField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TeamID
        {
            get
            {
                return this.teamIDField;
            }
            set
            {
                this.teamIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string OwnerTags
        {
            get
            {
                return this.ownerTagsField;
            }
            set
            {
                this.ownerTagsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string OwnerName
        {
            get
            {
                return this.ownerNameField;
            }
            set
            {
                this.ownerNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string OwnerJobId
        {
            get
            {
                return this.ownerJobIdField;
            }
            set
            {
                this.ownerJobIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte OwnerHairIndex
        {
            get
            {
                return this.ownerHairIndexField;
            }
            set
            {
                this.ownerHairIndexField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte OwnerBeardIndex
        {
            get
            {
                return this.ownerBeardIndexField;
            }
            set
            {
                this.ownerBeardIndexField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte OwnerMoustacheIndex
        {
            get
            {
                return this.ownerMoustacheIndexField;
            }
            set
            {
                this.ownerMoustacheIndexField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte OwnerFaceAttachmentIndex
        {
            get
            {
                return this.ownerFaceAttachmentIndexField;
            }
            set
            {
                this.ownerFaceAttachmentIndexField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string OwnerHairColor
        {
            get
            {
                return this.ownerHairColorField;
            }
            set
            {
                this.ownerHairColorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string OwnerFacialHairColor
        {
            get
            {
                return this.ownerFacialHairColorField;
            }
            set
            {
                this.ownerFacialHairColorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string OwnerSkinColor
        {
            get
            {
                return this.ownerSkinColorField;
            }
            set
            {
                this.ownerSkinColorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string OwnerSheetIndex
        {
            get
            {
                return this.ownerSheetIndexField;
            }
            set
            {
                this.ownerSheetIndexField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte PickingTime
        {
            get
            {
                return this.pickingTimeField;
            }
            set
            {
                this.pickingTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CanBePicked
        {
            get
            {
                return this.canBePickedField;
            }
            set
            {
                this.canBePickedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AllowInGameEditing
        {
            get
            {
                return this.allowInGameEditingField;
            }
            set
            {
                this.allowInGameEditingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Msg
        {
            get
            {
                return this.msgField;
            }
            set
            {
                this.msgField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CharacterDataCharacterCampaignDataItemItemContainer
    {

        private string containableRestrictionsField;

        private string autoFillField;

        private byte pickingTimeField;

        private string canBePickedField;

        private string allowInGameEditingField;

        private string msgField;

        private string containedField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ContainableRestrictions
        {
            get
            {
                return this.containableRestrictionsField;
            }
            set
            {
                this.containableRestrictionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AutoFill
        {
            get
            {
                return this.autoFillField;
            }
            set
            {
                this.autoFillField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte PickingTime
        {
            get
            {
                return this.pickingTimeField;
            }
            set
            {
                this.pickingTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CanBePicked
        {
            get
            {
                return this.canBePickedField;
            }
            set
            {
                this.canBePickedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AllowInGameEditing
        {
            get
            {
                return this.allowInGameEditingField;
            }
            set
            {
                this.allowInGameEditingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Msg
        {
            get
            {
                return this.msgField;
            }
            set
            {
                this.msgField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string contained
        {
            get
            {
                return this.containedField;
            }
            set
            {
                this.containedField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CharacterDataCharacterCampaignDataItemLightComponent
    {

        private ushort rangeField;

        private string castShadowsField;

        private string drawBehindSubsField;

        private string isOnField;

        private decimal flickerField;

        private byte flickerSpeedField;

        private decimal pulseFrequencyField;

        private decimal pulseAmountField;

        private byte blinkFrequencyField;

        private string lightColorField;

        private string isActiveField;

        private decimal minVoltageField;

        private byte powerConsumptionField;

        private byte voltageField;

        private string vulnerableToEMPField;

        private byte pickingTimeField;

        private string canBePickedField;

        private string allowInGameEditingField;

        private string msgField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort Range
        {
            get
            {
                return this.rangeField;
            }
            set
            {
                this.rangeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CastShadows
        {
            get
            {
                return this.castShadowsField;
            }
            set
            {
                this.castShadowsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DrawBehindSubs
        {
            get
            {
                return this.drawBehindSubsField;
            }
            set
            {
                this.drawBehindSubsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string IsOn
        {
            get
            {
                return this.isOnField;
            }
            set
            {
                this.isOnField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Flicker
        {
            get
            {
                return this.flickerField;
            }
            set
            {
                this.flickerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte FlickerSpeed
        {
            get
            {
                return this.flickerSpeedField;
            }
            set
            {
                this.flickerSpeedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal PulseFrequency
        {
            get
            {
                return this.pulseFrequencyField;
            }
            set
            {
                this.pulseFrequencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal PulseAmount
        {
            get
            {
                return this.pulseAmountField;
            }
            set
            {
                this.pulseAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte BlinkFrequency
        {
            get
            {
                return this.blinkFrequencyField;
            }
            set
            {
                this.blinkFrequencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LightColor
        {
            get
            {
                return this.lightColorField;
            }
            set
            {
                this.lightColorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string IsActive
        {
            get
            {
                return this.isActiveField;
            }
            set
            {
                this.isActiveField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal MinVoltage
        {
            get
            {
                return this.minVoltageField;
            }
            set
            {
                this.minVoltageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte PowerConsumption
        {
            get
            {
                return this.powerConsumptionField;
            }
            set
            {
                this.powerConsumptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte Voltage
        {
            get
            {
                return this.voltageField;
            }
            set
            {
                this.voltageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VulnerableToEMP
        {
            get
            {
                return this.vulnerableToEMPField;
            }
            set
            {
                this.vulnerableToEMPField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte PickingTime
        {
            get
            {
                return this.pickingTimeField;
            }
            set
            {
                this.pickingTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CanBePicked
        {
            get
            {
                return this.canBePickedField;
            }
            set
            {
                this.canBePickedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AllowInGameEditing
        {
            get
            {
                return this.allowInGameEditingField;
            }
            set
            {
                this.allowInGameEditingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Msg
        {
            get
            {
                return this.msgField;
            }
            set
            {
                this.msgField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CharacterDataCharacterCampaignDataItemMeleeWeapon
    {

        private string swingField;

        private string swingPosField;

        private string swingForceField;

        private string holdPosField;

        private ushort holdAngleField;

        private string swingAmountField;

        private decimal swingSpeedField;

        private string swingWhenHoldingField;

        private string swingWhenAimingField;

        private string swingWhenUsingField;

        private string disableHeadRotationField;

        private decimal spriteDepthWhenDroppedField;

        private byte pickingTimeField;

        private string canBePickedField;

        private string allowInGameEditingField;

        private string msgField;

        private string aimableField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Swing
        {
            get
            {
                return this.swingField;
            }
            set
            {
                this.swingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SwingPos
        {
            get
            {
                return this.swingPosField;
            }
            set
            {
                this.swingPosField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SwingForce
        {
            get
            {
                return this.swingForceField;
            }
            set
            {
                this.swingForceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string HoldPos
        {
            get
            {
                return this.holdPosField;
            }
            set
            {
                this.holdPosField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort HoldAngle
        {
            get
            {
                return this.holdAngleField;
            }
            set
            {
                this.holdAngleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SwingAmount
        {
            get
            {
                return this.swingAmountField;
            }
            set
            {
                this.swingAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal SwingSpeed
        {
            get
            {
                return this.swingSpeedField;
            }
            set
            {
                this.swingSpeedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SwingWhenHolding
        {
            get
            {
                return this.swingWhenHoldingField;
            }
            set
            {
                this.swingWhenHoldingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SwingWhenAiming
        {
            get
            {
                return this.swingWhenAimingField;
            }
            set
            {
                this.swingWhenAimingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SwingWhenUsing
        {
            get
            {
                return this.swingWhenUsingField;
            }
            set
            {
                this.swingWhenUsingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DisableHeadRotation
        {
            get
            {
                return this.disableHeadRotationField;
            }
            set
            {
                this.disableHeadRotationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal SpriteDepthWhenDropped
        {
            get
            {
                return this.spriteDepthWhenDroppedField;
            }
            set
            {
                this.spriteDepthWhenDroppedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte PickingTime
        {
            get
            {
                return this.pickingTimeField;
            }
            set
            {
                this.pickingTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CanBePicked
        {
            get
            {
                return this.canBePickedField;
            }
            set
            {
                this.canBePickedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AllowInGameEditing
        {
            get
            {
                return this.allowInGameEditingField;
            }
            set
            {
                this.allowInGameEditingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Msg
        {
            get
            {
                return this.msgField;
            }
            set
            {
                this.msgField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Aimable
        {
            get
            {
                return this.aimableField;
            }
            set
            {
                this.aimableField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CharacterDataCharacterCampaignDataItemMiniMap
    {

        private string requireWaterDetectorsField;

        private string requireOxygenDetectorsField;

        private string showHullIntegrityField;

        private string enableHullStatusField;

        private string enableElectricalViewField;

        private string enableItemFinderField;

        private byte minVoltageField;

        private byte powerConsumptionField;

        private string isActiveField;

        private byte voltageField;

        private string vulnerableToEMPField;

        private byte pickingTimeField;

        private string canBePickedField;

        private string allowInGameEditingField;

        private string msgField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RequireWaterDetectors
        {
            get
            {
                return this.requireWaterDetectorsField;
            }
            set
            {
                this.requireWaterDetectorsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RequireOxygenDetectors
        {
            get
            {
                return this.requireOxygenDetectorsField;
            }
            set
            {
                this.requireOxygenDetectorsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ShowHullIntegrity
        {
            get
            {
                return this.showHullIntegrityField;
            }
            set
            {
                this.showHullIntegrityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string EnableHullStatus
        {
            get
            {
                return this.enableHullStatusField;
            }
            set
            {
                this.enableHullStatusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string EnableElectricalView
        {
            get
            {
                return this.enableElectricalViewField;
            }
            set
            {
                this.enableElectricalViewField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string EnableItemFinder
        {
            get
            {
                return this.enableItemFinderField;
            }
            set
            {
                this.enableItemFinderField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte MinVoltage
        {
            get
            {
                return this.minVoltageField;
            }
            set
            {
                this.minVoltageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte PowerConsumption
        {
            get
            {
                return this.powerConsumptionField;
            }
            set
            {
                this.powerConsumptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string IsActive
        {
            get
            {
                return this.isActiveField;
            }
            set
            {
                this.isActiveField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte Voltage
        {
            get
            {
                return this.voltageField;
            }
            set
            {
                this.voltageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VulnerableToEMP
        {
            get
            {
                return this.vulnerableToEMPField;
            }
            set
            {
                this.vulnerableToEMPField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte PickingTime
        {
            get
            {
                return this.pickingTimeField;
            }
            set
            {
                this.pickingTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CanBePicked
        {
            get
            {
                return this.canBePickedField;
            }
            set
            {
                this.canBePickedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AllowInGameEditing
        {
            get
            {
                return this.allowInGameEditingField;
            }
            set
            {
                this.allowInGameEditingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Msg
        {
            get
            {
                return this.msgField;
            }
            set
            {
                this.msgField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CharacterDataCharacterCampaignDataItemPickable
    {

        private byte pickingTimeField;

        private string canBePickedField;

        private string allowInGameEditingField;

        private string msgField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte PickingTime
        {
            get
            {
                return this.pickingTimeField;
            }
            set
            {
                this.pickingTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CanBePicked
        {
            get
            {
                return this.canBePickedField;
            }
            set
            {
                this.canBePickedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AllowInGameEditing
        {
            get
            {
                return this.allowInGameEditingField;
            }
            set
            {
                this.allowInGameEditingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Msg
        {
            get
            {
                return this.msgField;
            }
            set
            {
                this.msgField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CharacterDataCharacterCampaignDataItemProjectile
    {

        private byte pickingTimeField;

        private string canBePickedField;

        private string allowInGameEditingField;

        private string msgField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte PickingTime
        {
            get
            {
                return this.pickingTimeField;
            }
            set
            {
                this.pickingTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CanBePicked
        {
            get
            {
                return this.canBePickedField;
            }
            set
            {
                this.canBePickedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AllowInGameEditing
        {
            get
            {
                return this.allowInGameEditingField;
            }
            set
            {
                this.allowInGameEditingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Msg
        {
            get
            {
                return this.msgField;
            }
            set
            {
                this.msgField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CharacterDataCharacterCampaignDataItemQuality
    {

        private byte qualityLevelField;

        private byte pickingTimeField;

        private string canBePickedField;

        private string allowInGameEditingField;

        private string msgField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte QualityLevel
        {
            get
            {
                return this.qualityLevelField;
            }
            set
            {
                this.qualityLevelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte PickingTime
        {
            get
            {
                return this.pickingTimeField;
            }
            set
            {
                this.pickingTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CanBePicked
        {
            get
            {
                return this.canBePickedField;
            }
            set
            {
                this.canBePickedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AllowInGameEditing
        {
            get
            {
                return this.allowInGameEditingField;
            }
            set
            {
                this.allowInGameEditingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Msg
        {
            get
            {
                return this.msgField;
            }
            set
            {
                this.msgField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CharacterDataCharacterCampaignDataItemRangedWeapon
    {

        private CharacterDataCharacterCampaignDataItemRangedWeaponRequireditem requireditemField;

        private byte pickingTimeField;

        private string canBePickedField;

        private string allowInGameEditingField;

        private string msgField;

        /// <remarks/>
        public CharacterDataCharacterCampaignDataItemRangedWeaponRequireditem requireditem
        {
            get
            {
                return this.requireditemField;
            }
            set
            {
                this.requireditemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte PickingTime
        {
            get
            {
                return this.pickingTimeField;
            }
            set
            {
                this.pickingTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CanBePicked
        {
            get
            {
                return this.canBePickedField;
            }
            set
            {
                this.canBePickedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AllowInGameEditing
        {
            get
            {
                return this.allowInGameEditingField;
            }
            set
            {
                this.allowInGameEditingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Msg
        {
            get
            {
                return this.msgField;
            }
            set
            {
                this.msgField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CharacterDataCharacterCampaignDataItemRangedWeaponRequireditem
    {

        private string itemsField;

        private string typeField;

        private bool optionalField;

        private bool ignoreineditorField;

        private bool excludebrokenField;

        private bool excludefullconditionField;

        private sbyte targetslotField;

        private bool allowvariantsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool optional
        {
            get
            {
                return this.optionalField;
            }
            set
            {
                this.optionalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ignoreineditor
        {
            get
            {
                return this.ignoreineditorField;
            }
            set
            {
                this.ignoreineditorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool excludebroken
        {
            get
            {
                return this.excludebrokenField;
            }
            set
            {
                this.excludebrokenField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool excludefullcondition
        {
            get
            {
                return this.excludefullconditionField;
            }
            set
            {
                this.excludefullconditionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public sbyte targetslot
        {
            get
            {
                return this.targetslotField;
            }
            set
            {
                this.targetslotField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool allowvariants
        {
            get
            {
                return this.allowvariantsField;
            }
            set
            {
                this.allowvariantsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CharacterDataCharacterCampaignDataItemRepairTool
    {

        private CharacterDataCharacterCampaignDataItemRepairToolRequireditem requireditemField;

        private byte barrelRotationField;

        private byte pickingTimeField;

        private string canBePickedField;

        private string allowInGameEditingField;

        private string msgField;

        /// <remarks/>
        public CharacterDataCharacterCampaignDataItemRepairToolRequireditem requireditem
        {
            get
            {
                return this.requireditemField;
            }
            set
            {
                this.requireditemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte BarrelRotation
        {
            get
            {
                return this.barrelRotationField;
            }
            set
            {
                this.barrelRotationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte PickingTime
        {
            get
            {
                return this.pickingTimeField;
            }
            set
            {
                this.pickingTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CanBePicked
        {
            get
            {
                return this.canBePickedField;
            }
            set
            {
                this.canBePickedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AllowInGameEditing
        {
            get
            {
                return this.allowInGameEditingField;
            }
            set
            {
                this.allowInGameEditingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Msg
        {
            get
            {
                return this.msgField;
            }
            set
            {
                this.msgField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CharacterDataCharacterCampaignDataItemRepairToolRequireditem
    {

        private string itemsField;

        private string typeField;

        private bool optionalField;

        private bool ignoreineditorField;

        private bool excludebrokenField;

        private bool excludefullconditionField;

        private sbyte targetslotField;

        private bool allowvariantsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool optional
        {
            get
            {
                return this.optionalField;
            }
            set
            {
                this.optionalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ignoreineditor
        {
            get
            {
                return this.ignoreineditorField;
            }
            set
            {
                this.ignoreineditorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool excludebroken
        {
            get
            {
                return this.excludebrokenField;
            }
            set
            {
                this.excludebrokenField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool excludefullcondition
        {
            get
            {
                return this.excludefullconditionField;
            }
            set
            {
                this.excludefullconditionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public sbyte targetslot
        {
            get
            {
                return this.targetslotField;
            }
            set
            {
                this.targetslotField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool allowvariants
        {
            get
            {
                return this.allowvariantsField;
            }
            set
            {
                this.allowvariantsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CharacterDataCharacterCampaignDataItemRope
    {

        private byte pickingTimeField;

        private string canBePickedField;

        private string allowInGameEditingField;

        private string msgField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte PickingTime
        {
            get
            {
                return this.pickingTimeField;
            }
            set
            {
                this.pickingTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CanBePicked
        {
            get
            {
                return this.canBePickedField;
            }
            set
            {
                this.canBePickedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AllowInGameEditing
        {
            get
            {
                return this.allowInGameEditingField;
            }
            set
            {
                this.allowInGameEditingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Msg
        {
            get
            {
                return this.msgField;
            }
            set
            {
                this.msgField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CharacterDataCharacterCampaignDataItemStatusHUD
    {

        private byte pickingTimeField;

        private string canBePickedField;

        private string allowInGameEditingField;

        private string msgField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte PickingTime
        {
            get
            {
                return this.pickingTimeField;
            }
            set
            {
                this.pickingTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CanBePicked
        {
            get
            {
                return this.canBePickedField;
            }
            set
            {
                this.canBePickedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AllowInGameEditing
        {
            get
            {
                return this.allowInGameEditingField;
            }
            set
            {
                this.allowInGameEditingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Msg
        {
            get
            {
                return this.msgField;
            }
            set
            {
                this.msgField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CharacterDataCharacterCampaignDataItemWearable
    {

        private byte pickingTimeField;

        private string canBePickedField;

        private string allowInGameEditingField;

        private string msgField;

        private byte variantField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte PickingTime
        {
            get
            {
                return this.pickingTimeField;
            }
            set
            {
                this.pickingTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CanBePicked
        {
            get
            {
                return this.canBePickedField;
            }
            set
            {
                this.canBePickedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AllowInGameEditing
        {
            get
            {
                return this.allowInGameEditingField;
            }
            set
            {
                this.allowInGameEditingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Msg
        {
            get
            {
                return this.msgField;
            }
            set
            {
                this.msgField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte variant
        {
            get
            {
                return this.variantField;
            }
            set
            {
                this.variantField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CharacterDataCharacterCampaignDataItemWifiComponent
    {

        private string teamIDField;

        private ushort rangeField;

        private byte channelField;

        private string allowCrossTeamCommunicationField;

        private string linkToChatField;

        private byte minChatMessageIntervalField;

        private string discardDuplicateChatMessagesField;

        private byte pickingTimeField;

        private string canBePickedField;

        private string allowInGameEditingField;

        private string msgField;

        private string channelmemoryField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TeamID
        {
            get
            {
                return this.teamIDField;
            }
            set
            {
                this.teamIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort Range
        {
            get
            {
                return this.rangeField;
            }
            set
            {
                this.rangeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte Channel
        {
            get
            {
                return this.channelField;
            }
            set
            {
                this.channelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AllowCrossTeamCommunication
        {
            get
            {
                return this.allowCrossTeamCommunicationField;
            }
            set
            {
                this.allowCrossTeamCommunicationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LinkToChat
        {
            get
            {
                return this.linkToChatField;
            }
            set
            {
                this.linkToChatField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte MinChatMessageInterval
        {
            get
            {
                return this.minChatMessageIntervalField;
            }
            set
            {
                this.minChatMessageIntervalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DiscardDuplicateChatMessages
        {
            get
            {
                return this.discardDuplicateChatMessagesField;
            }
            set
            {
                this.discardDuplicateChatMessagesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte PickingTime
        {
            get
            {
                return this.pickingTimeField;
            }
            set
            {
                this.pickingTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CanBePicked
        {
            get
            {
                return this.canBePickedField;
            }
            set
            {
                this.canBePickedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AllowInGameEditing
        {
            get
            {
                return this.allowInGameEditingField;
            }
            set
            {
                this.allowInGameEditingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Msg
        {
            get
            {
                return this.msgField;
            }
            set
            {
                this.msgField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string channelmemory
        {
            get
            {
                return this.channelmemoryField;
            }
            set
            {
                this.channelmemoryField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CharacterDataCharacterCampaignDataItemWire
    {

        private string noAutoLockField;

        private string useSpriteDepthField;

        private byte pickingTimeField;

        private string canBePickedField;

        private string allowInGameEditingField;

        private string msgField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NoAutoLock
        {
            get
            {
                return this.noAutoLockField;
            }
            set
            {
                this.noAutoLockField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string UseSpriteDepth
        {
            get
            {
                return this.useSpriteDepthField;
            }
            set
            {
                this.useSpriteDepthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte PickingTime
        {
            get
            {
                return this.pickingTimeField;
            }
            set
            {
                this.pickingTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CanBePicked
        {
            get
            {
                return this.canBePickedField;
            }
            set
            {
                this.canBePickedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AllowInGameEditing
        {
            get
            {
                return this.allowInGameEditingField;
            }
            set
            {
                this.allowInGameEditingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Msg
        {
            get
            {
                return this.msgField;
            }
            set
            {
                this.msgField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CharacterDataCharacterCampaignDataItemInventory
    {

        private CharacterDataCharacterCampaignDataItemInventoryItem[] itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Item")]
        public CharacterDataCharacterCampaignDataItemInventoryItem[] Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CharacterDataCharacterCampaignDataItemInventoryItem
    {

        private object[] itemsField;

        private string nameField;

        private string identifierField;

        private ushort idField;

        private string rectField;

        private string nonInteractableField;

        private string nonPlayerTeamInteractableField;

        private string allowSwappingField;

        private byte rotationField;

        private decimal scaleField;

        private string spriteColorField;

        private string inventoryIconColorField;

        private string containerColorField;

        private decimal conditionField;

        private string invulnerableToDamageField;

        private string allowStealingField;

        private string originalOutpostField;

        private string tagsField;

        private string displaySideBySideWhenLinkedField;

        private string disallowedUpgradesField;

        private decimal spriteDepthField;

        private string hiddenInGameField;

        private byte iField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Holdable", typeof(CharacterDataCharacterCampaignDataItemInventoryItemHoldable))]
        [System.Xml.Serialization.XmlElementAttribute("IdCard", typeof(CharacterDataCharacterCampaignDataItemInventoryItemIdCard))]
        [System.Xml.Serialization.XmlElementAttribute("ItemContainer", typeof(CharacterDataCharacterCampaignDataItemInventoryItemItemContainer))]
        [System.Xml.Serialization.XmlElementAttribute("LightComponent", typeof(CharacterDataCharacterCampaignDataItemInventoryItemLightComponent))]
        [System.Xml.Serialization.XmlElementAttribute("MeleeWeapon", typeof(CharacterDataCharacterCampaignDataItemInventoryItemMeleeWeapon))]
        [System.Xml.Serialization.XmlElementAttribute("Pickable", typeof(CharacterDataCharacterCampaignDataItemInventoryItemPickable))]
        [System.Xml.Serialization.XmlElementAttribute("Projectile", typeof(CharacterDataCharacterCampaignDataItemInventoryItemProjectile))]
        [System.Xml.Serialization.XmlElementAttribute("Quality", typeof(CharacterDataCharacterCampaignDataItemInventoryItemQuality))]
        [System.Xml.Serialization.XmlElementAttribute("Rope", typeof(CharacterDataCharacterCampaignDataItemInventoryItemRope))]
        [System.Xml.Serialization.XmlElementAttribute("StatusHUD", typeof(CharacterDataCharacterCampaignDataItemInventoryItemStatusHUD))]
        [System.Xml.Serialization.XmlElementAttribute("Wearable", typeof(CharacterDataCharacterCampaignDataItemInventoryItemWearable))]
        [System.Xml.Serialization.XmlElementAttribute("inventory", typeof(CharacterDataCharacterCampaignDataItemInventoryItemInventory))]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string identifier
        {
            get
            {
                return this.identifierField;
            }
            set
            {
                this.identifierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string rect
        {
            get
            {
                return this.rectField;
            }
            set
            {
                this.rectField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NonInteractable
        {
            get
            {
                return this.nonInteractableField;
            }
            set
            {
                this.nonInteractableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NonPlayerTeamInteractable
        {
            get
            {
                return this.nonPlayerTeamInteractableField;
            }
            set
            {
                this.nonPlayerTeamInteractableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AllowSwapping
        {
            get
            {
                return this.allowSwappingField;
            }
            set
            {
                this.allowSwappingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte Rotation
        {
            get
            {
                return this.rotationField;
            }
            set
            {
                this.rotationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Scale
        {
            get
            {
                return this.scaleField;
            }
            set
            {
                this.scaleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SpriteColor
        {
            get
            {
                return this.spriteColorField;
            }
            set
            {
                this.spriteColorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string InventoryIconColor
        {
            get
            {
                return this.inventoryIconColorField;
            }
            set
            {
                this.inventoryIconColorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ContainerColor
        {
            get
            {
                return this.containerColorField;
            }
            set
            {
                this.containerColorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Condition
        {
            get
            {
                return this.conditionField;
            }
            set
            {
                this.conditionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string InvulnerableToDamage
        {
            get
            {
                return this.invulnerableToDamageField;
            }
            set
            {
                this.invulnerableToDamageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AllowStealing
        {
            get
            {
                return this.allowStealingField;
            }
            set
            {
                this.allowStealingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string OriginalOutpost
        {
            get
            {
                return this.originalOutpostField;
            }
            set
            {
                this.originalOutpostField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Tags
        {
            get
            {
                return this.tagsField;
            }
            set
            {
                this.tagsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DisplaySideBySideWhenLinked
        {
            get
            {
                return this.displaySideBySideWhenLinkedField;
            }
            set
            {
                this.displaySideBySideWhenLinkedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DisallowedUpgrades
        {
            get
            {
                return this.disallowedUpgradesField;
            }
            set
            {
                this.disallowedUpgradesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal SpriteDepth
        {
            get
            {
                return this.spriteDepthField;
            }
            set
            {
                this.spriteDepthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string HiddenInGame
        {
            get
            {
                return this.hiddenInGameField;
            }
            set
            {
                this.hiddenInGameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte i
        {
            get
            {
                return this.iField;
            }
            set
            {
                this.iField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CharacterDataCharacterCampaignDataItemInventoryItemHoldable
    {

        private string holdPosField;

        private byte holdAngleField;

        private string swingAmountField;

        private byte swingSpeedField;

        private string swingWhenHoldingField;

        private string swingWhenAimingField;

        private string swingWhenUsingField;

        private string disableHeadRotationField;

        private decimal spriteDepthWhenDroppedField;

        private byte pickingTimeField;

        private string canBePickedField;

        private string allowInGameEditingField;

        private string msgField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string HoldPos
        {
            get
            {
                return this.holdPosField;
            }
            set
            {
                this.holdPosField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte HoldAngle
        {
            get
            {
                return this.holdAngleField;
            }
            set
            {
                this.holdAngleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SwingAmount
        {
            get
            {
                return this.swingAmountField;
            }
            set
            {
                this.swingAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte SwingSpeed
        {
            get
            {
                return this.swingSpeedField;
            }
            set
            {
                this.swingSpeedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SwingWhenHolding
        {
            get
            {
                return this.swingWhenHoldingField;
            }
            set
            {
                this.swingWhenHoldingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SwingWhenAiming
        {
            get
            {
                return this.swingWhenAimingField;
            }
            set
            {
                this.swingWhenAimingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SwingWhenUsing
        {
            get
            {
                return this.swingWhenUsingField;
            }
            set
            {
                this.swingWhenUsingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DisableHeadRotation
        {
            get
            {
                return this.disableHeadRotationField;
            }
            set
            {
                this.disableHeadRotationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal SpriteDepthWhenDropped
        {
            get
            {
                return this.spriteDepthWhenDroppedField;
            }
            set
            {
                this.spriteDepthWhenDroppedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte PickingTime
        {
            get
            {
                return this.pickingTimeField;
            }
            set
            {
                this.pickingTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CanBePicked
        {
            get
            {
                return this.canBePickedField;
            }
            set
            {
                this.canBePickedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AllowInGameEditing
        {
            get
            {
                return this.allowInGameEditingField;
            }
            set
            {
                this.allowInGameEditingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Msg
        {
            get
            {
                return this.msgField;
            }
            set
            {
                this.msgField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CharacterDataCharacterCampaignDataItemInventoryItemIdCard
    {

        private string teamIDField;

        private uint submarineSpecificIDField;

        private string ownerTagsField;

        private string ownerNameField;

        private string ownerJobIdField;

        private byte ownerHairIndexField;

        private byte ownerBeardIndexField;

        private byte ownerMoustacheIndexField;

        private byte ownerFaceAttachmentIndexField;

        private string ownerHairColorField;

        private string ownerFacialHairColorField;

        private string ownerSkinColorField;

        private string ownerSheetIndexField;

        private byte pickingTimeField;

        private string canBePickedField;

        private string allowInGameEditingField;

        private string msgField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TeamID
        {
            get
            {
                return this.teamIDField;
            }
            set
            {
                this.teamIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint SubmarineSpecificID
        {
            get
            {
                return this.submarineSpecificIDField;
            }
            set
            {
                this.submarineSpecificIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string OwnerTags
        {
            get
            {
                return this.ownerTagsField;
            }
            set
            {
                this.ownerTagsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string OwnerName
        {
            get
            {
                return this.ownerNameField;
            }
            set
            {
                this.ownerNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string OwnerJobId
        {
            get
            {
                return this.ownerJobIdField;
            }
            set
            {
                this.ownerJobIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte OwnerHairIndex
        {
            get
            {
                return this.ownerHairIndexField;
            }
            set
            {
                this.ownerHairIndexField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte OwnerBeardIndex
        {
            get
            {
                return this.ownerBeardIndexField;
            }
            set
            {
                this.ownerBeardIndexField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte OwnerMoustacheIndex
        {
            get
            {
                return this.ownerMoustacheIndexField;
            }
            set
            {
                this.ownerMoustacheIndexField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte OwnerFaceAttachmentIndex
        {
            get
            {
                return this.ownerFaceAttachmentIndexField;
            }
            set
            {
                this.ownerFaceAttachmentIndexField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string OwnerHairColor
        {
            get
            {
                return this.ownerHairColorField;
            }
            set
            {
                this.ownerHairColorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string OwnerFacialHairColor
        {
            get
            {
                return this.ownerFacialHairColorField;
            }
            set
            {
                this.ownerFacialHairColorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string OwnerSkinColor
        {
            get
            {
                return this.ownerSkinColorField;
            }
            set
            {
                this.ownerSkinColorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string OwnerSheetIndex
        {
            get
            {
                return this.ownerSheetIndexField;
            }
            set
            {
                this.ownerSheetIndexField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte PickingTime
        {
            get
            {
                return this.pickingTimeField;
            }
            set
            {
                this.pickingTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CanBePicked
        {
            get
            {
                return this.canBePickedField;
            }
            set
            {
                this.canBePickedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AllowInGameEditing
        {
            get
            {
                return this.allowInGameEditingField;
            }
            set
            {
                this.allowInGameEditingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Msg
        {
            get
            {
                return this.msgField;
            }
            set
            {
                this.msgField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CharacterDataCharacterCampaignDataItemInventoryItemItemContainer
    {

        private string containableRestrictionsField;

        private string autoFillField;

        private byte pickingTimeField;

        private string canBePickedField;

        private string allowInGameEditingField;

        private string msgField;

        private ushort containedField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ContainableRestrictions
        {
            get
            {
                return this.containableRestrictionsField;
            }
            set
            {
                this.containableRestrictionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AutoFill
        {
            get
            {
                return this.autoFillField;
            }
            set
            {
                this.autoFillField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte PickingTime
        {
            get
            {
                return this.pickingTimeField;
            }
            set
            {
                this.pickingTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CanBePicked
        {
            get
            {
                return this.canBePickedField;
            }
            set
            {
                this.canBePickedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AllowInGameEditing
        {
            get
            {
                return this.allowInGameEditingField;
            }
            set
            {
                this.allowInGameEditingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Msg
        {
            get
            {
                return this.msgField;
            }
            set
            {
                this.msgField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort contained
        {
            get
            {
                return this.containedField;
            }
            set
            {
                this.containedField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CharacterDataCharacterCampaignDataItemInventoryItemLightComponent
    {

        private ushort rangeField;

        private string castShadowsField;

        private string drawBehindSubsField;

        private string isOnField;

        private decimal flickerField;

        private byte flickerSpeedField;

        private decimal pulseFrequencyField;

        private decimal pulseAmountField;

        private byte blinkFrequencyField;

        private string lightColorField;

        private string isActiveField;

        private decimal minVoltageField;

        private byte powerConsumptionField;

        private byte voltageField;

        private string vulnerableToEMPField;

        private byte pickingTimeField;

        private string canBePickedField;

        private string allowInGameEditingField;

        private string msgField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort Range
        {
            get
            {
                return this.rangeField;
            }
            set
            {
                this.rangeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CastShadows
        {
            get
            {
                return this.castShadowsField;
            }
            set
            {
                this.castShadowsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DrawBehindSubs
        {
            get
            {
                return this.drawBehindSubsField;
            }
            set
            {
                this.drawBehindSubsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string IsOn
        {
            get
            {
                return this.isOnField;
            }
            set
            {
                this.isOnField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Flicker
        {
            get
            {
                return this.flickerField;
            }
            set
            {
                this.flickerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte FlickerSpeed
        {
            get
            {
                return this.flickerSpeedField;
            }
            set
            {
                this.flickerSpeedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal PulseFrequency
        {
            get
            {
                return this.pulseFrequencyField;
            }
            set
            {
                this.pulseFrequencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal PulseAmount
        {
            get
            {
                return this.pulseAmountField;
            }
            set
            {
                this.pulseAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte BlinkFrequency
        {
            get
            {
                return this.blinkFrequencyField;
            }
            set
            {
                this.blinkFrequencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LightColor
        {
            get
            {
                return this.lightColorField;
            }
            set
            {
                this.lightColorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string IsActive
        {
            get
            {
                return this.isActiveField;
            }
            set
            {
                this.isActiveField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal MinVoltage
        {
            get
            {
                return this.minVoltageField;
            }
            set
            {
                this.minVoltageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte PowerConsumption
        {
            get
            {
                return this.powerConsumptionField;
            }
            set
            {
                this.powerConsumptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte Voltage
        {
            get
            {
                return this.voltageField;
            }
            set
            {
                this.voltageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VulnerableToEMP
        {
            get
            {
                return this.vulnerableToEMPField;
            }
            set
            {
                this.vulnerableToEMPField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte PickingTime
        {
            get
            {
                return this.pickingTimeField;
            }
            set
            {
                this.pickingTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CanBePicked
        {
            get
            {
                return this.canBePickedField;
            }
            set
            {
                this.canBePickedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AllowInGameEditing
        {
            get
            {
                return this.allowInGameEditingField;
            }
            set
            {
                this.allowInGameEditingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Msg
        {
            get
            {
                return this.msgField;
            }
            set
            {
                this.msgField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CharacterDataCharacterCampaignDataItemInventoryItemMeleeWeapon
    {

        private string swingField;

        private string swingPosField;

        private string swingForceField;

        private string holdPosField;

        private byte holdAngleField;

        private string swingAmountField;

        private byte swingSpeedField;

        private string swingWhenHoldingField;

        private string swingWhenAimingField;

        private string swingWhenUsingField;

        private string disableHeadRotationField;

        private decimal spriteDepthWhenDroppedField;

        private byte pickingTimeField;

        private string canBePickedField;

        private string allowInGameEditingField;

        private string msgField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Swing
        {
            get
            {
                return this.swingField;
            }
            set
            {
                this.swingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SwingPos
        {
            get
            {
                return this.swingPosField;
            }
            set
            {
                this.swingPosField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SwingForce
        {
            get
            {
                return this.swingForceField;
            }
            set
            {
                this.swingForceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string HoldPos
        {
            get
            {
                return this.holdPosField;
            }
            set
            {
                this.holdPosField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte HoldAngle
        {
            get
            {
                return this.holdAngleField;
            }
            set
            {
                this.holdAngleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SwingAmount
        {
            get
            {
                return this.swingAmountField;
            }
            set
            {
                this.swingAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte SwingSpeed
        {
            get
            {
                return this.swingSpeedField;
            }
            set
            {
                this.swingSpeedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SwingWhenHolding
        {
            get
            {
                return this.swingWhenHoldingField;
            }
            set
            {
                this.swingWhenHoldingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SwingWhenAiming
        {
            get
            {
                return this.swingWhenAimingField;
            }
            set
            {
                this.swingWhenAimingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SwingWhenUsing
        {
            get
            {
                return this.swingWhenUsingField;
            }
            set
            {
                this.swingWhenUsingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DisableHeadRotation
        {
            get
            {
                return this.disableHeadRotationField;
            }
            set
            {
                this.disableHeadRotationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal SpriteDepthWhenDropped
        {
            get
            {
                return this.spriteDepthWhenDroppedField;
            }
            set
            {
                this.spriteDepthWhenDroppedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte PickingTime
        {
            get
            {
                return this.pickingTimeField;
            }
            set
            {
                this.pickingTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CanBePicked
        {
            get
            {
                return this.canBePickedField;
            }
            set
            {
                this.canBePickedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AllowInGameEditing
        {
            get
            {
                return this.allowInGameEditingField;
            }
            set
            {
                this.allowInGameEditingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Msg
        {
            get
            {
                return this.msgField;
            }
            set
            {
                this.msgField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CharacterDataCharacterCampaignDataItemInventoryItemPickable
    {

        private byte pickingTimeField;

        private string canBePickedField;

        private string allowInGameEditingField;

        private string msgField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte PickingTime
        {
            get
            {
                return this.pickingTimeField;
            }
            set
            {
                this.pickingTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CanBePicked
        {
            get
            {
                return this.canBePickedField;
            }
            set
            {
                this.canBePickedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AllowInGameEditing
        {
            get
            {
                return this.allowInGameEditingField;
            }
            set
            {
                this.allowInGameEditingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Msg
        {
            get
            {
                return this.msgField;
            }
            set
            {
                this.msgField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CharacterDataCharacterCampaignDataItemInventoryItemProjectile
    {

        private byte pickingTimeField;

        private string canBePickedField;

        private string allowInGameEditingField;

        private string msgField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte PickingTime
        {
            get
            {
                return this.pickingTimeField;
            }
            set
            {
                this.pickingTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CanBePicked
        {
            get
            {
                return this.canBePickedField;
            }
            set
            {
                this.canBePickedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AllowInGameEditing
        {
            get
            {
                return this.allowInGameEditingField;
            }
            set
            {
                this.allowInGameEditingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Msg
        {
            get
            {
                return this.msgField;
            }
            set
            {
                this.msgField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CharacterDataCharacterCampaignDataItemInventoryItemQuality
    {

        private byte qualityLevelField;

        private byte pickingTimeField;

        private string canBePickedField;

        private string allowInGameEditingField;

        private string msgField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte QualityLevel
        {
            get
            {
                return this.qualityLevelField;
            }
            set
            {
                this.qualityLevelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte PickingTime
        {
            get
            {
                return this.pickingTimeField;
            }
            set
            {
                this.pickingTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CanBePicked
        {
            get
            {
                return this.canBePickedField;
            }
            set
            {
                this.canBePickedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AllowInGameEditing
        {
            get
            {
                return this.allowInGameEditingField;
            }
            set
            {
                this.allowInGameEditingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Msg
        {
            get
            {
                return this.msgField;
            }
            set
            {
                this.msgField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CharacterDataCharacterCampaignDataItemInventoryItemRope
    {

        private byte pickingTimeField;

        private string canBePickedField;

        private string allowInGameEditingField;

        private string msgField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte PickingTime
        {
            get
            {
                return this.pickingTimeField;
            }
            set
            {
                this.pickingTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CanBePicked
        {
            get
            {
                return this.canBePickedField;
            }
            set
            {
                this.canBePickedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AllowInGameEditing
        {
            get
            {
                return this.allowInGameEditingField;
            }
            set
            {
                this.allowInGameEditingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Msg
        {
            get
            {
                return this.msgField;
            }
            set
            {
                this.msgField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CharacterDataCharacterCampaignDataItemInventoryItemStatusHUD
    {

        private byte pickingTimeField;

        private string canBePickedField;

        private string allowInGameEditingField;

        private string msgField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte PickingTime
        {
            get
            {
                return this.pickingTimeField;
            }
            set
            {
                this.pickingTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CanBePicked
        {
            get
            {
                return this.canBePickedField;
            }
            set
            {
                this.canBePickedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AllowInGameEditing
        {
            get
            {
                return this.allowInGameEditingField;
            }
            set
            {
                this.allowInGameEditingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Msg
        {
            get
            {
                return this.msgField;
            }
            set
            {
                this.msgField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CharacterDataCharacterCampaignDataItemInventoryItemWearable
    {

        private byte pickingTimeField;

        private string canBePickedField;

        private string allowInGameEditingField;

        private string msgField;

        private byte variantField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte PickingTime
        {
            get
            {
                return this.pickingTimeField;
            }
            set
            {
                this.pickingTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CanBePicked
        {
            get
            {
                return this.canBePickedField;
            }
            set
            {
                this.canBePickedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AllowInGameEditing
        {
            get
            {
                return this.allowInGameEditingField;
            }
            set
            {
                this.allowInGameEditingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Msg
        {
            get
            {
                return this.msgField;
            }
            set
            {
                this.msgField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte variant
        {
            get
            {
                return this.variantField;
            }
            set
            {
                this.variantField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CharacterDataCharacterCampaignDataItemInventoryItemInventory
    {

        private CharacterDataCharacterCampaignDataItemInventoryItemInventoryItem itemField;

        /// <remarks/>
        public CharacterDataCharacterCampaignDataItemInventoryItemInventoryItem Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CharacterDataCharacterCampaignDataItemInventoryItemInventoryItem
    {

        private CharacterDataCharacterCampaignDataItemInventoryItemInventoryItemHoldable holdableField;

        private CharacterDataCharacterCampaignDataItemInventoryItemInventoryItemQuality qualityField;

        private CharacterDataCharacterCampaignDataItemInventoryItemInventoryItemPickable pickableField;

        private CharacterDataCharacterCampaignDataItemInventoryItemInventoryItemProjectile projectileField;

        private string nameField;

        private string identifierField;

        private ushort idField;

        private string rectField;

        private string nonInteractableField;

        private string nonPlayerTeamInteractableField;

        private string allowSwappingField;

        private byte rotationField;

        private decimal scaleField;

        private string spriteColorField;

        private string inventoryIconColorField;

        private string containerColorField;

        private decimal conditionField;

        private string invulnerableToDamageField;

        private string tagsField;

        private string displaySideBySideWhenLinkedField;

        private string disallowedUpgradesField;

        private decimal spriteDepthField;

        private string hiddenInGameField;

        private byte iField;

        /// <remarks/>
        public CharacterDataCharacterCampaignDataItemInventoryItemInventoryItemHoldable Holdable
        {
            get
            {
                return this.holdableField;
            }
            set
            {
                this.holdableField = value;
            }
        }

        /// <remarks/>
        public CharacterDataCharacterCampaignDataItemInventoryItemInventoryItemQuality Quality
        {
            get
            {
                return this.qualityField;
            }
            set
            {
                this.qualityField = value;
            }
        }

        /// <remarks/>
        public CharacterDataCharacterCampaignDataItemInventoryItemInventoryItemPickable Pickable
        {
            get
            {
                return this.pickableField;
            }
            set
            {
                this.pickableField = value;
            }
        }

        /// <remarks/>
        public CharacterDataCharacterCampaignDataItemInventoryItemInventoryItemProjectile Projectile
        {
            get
            {
                return this.projectileField;
            }
            set
            {
                this.projectileField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string identifier
        {
            get
            {
                return this.identifierField;
            }
            set
            {
                this.identifierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string rect
        {
            get
            {
                return this.rectField;
            }
            set
            {
                this.rectField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NonInteractable
        {
            get
            {
                return this.nonInteractableField;
            }
            set
            {
                this.nonInteractableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NonPlayerTeamInteractable
        {
            get
            {
                return this.nonPlayerTeamInteractableField;
            }
            set
            {
                this.nonPlayerTeamInteractableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AllowSwapping
        {
            get
            {
                return this.allowSwappingField;
            }
            set
            {
                this.allowSwappingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte Rotation
        {
            get
            {
                return this.rotationField;
            }
            set
            {
                this.rotationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Scale
        {
            get
            {
                return this.scaleField;
            }
            set
            {
                this.scaleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SpriteColor
        {
            get
            {
                return this.spriteColorField;
            }
            set
            {
                this.spriteColorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string InventoryIconColor
        {
            get
            {
                return this.inventoryIconColorField;
            }
            set
            {
                this.inventoryIconColorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ContainerColor
        {
            get
            {
                return this.containerColorField;
            }
            set
            {
                this.containerColorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Condition
        {
            get
            {
                return this.conditionField;
            }
            set
            {
                this.conditionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string InvulnerableToDamage
        {
            get
            {
                return this.invulnerableToDamageField;
            }
            set
            {
                this.invulnerableToDamageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Tags
        {
            get
            {
                return this.tagsField;
            }
            set
            {
                this.tagsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DisplaySideBySideWhenLinked
        {
            get
            {
                return this.displaySideBySideWhenLinkedField;
            }
            set
            {
                this.displaySideBySideWhenLinkedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DisallowedUpgrades
        {
            get
            {
                return this.disallowedUpgradesField;
            }
            set
            {
                this.disallowedUpgradesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal SpriteDepth
        {
            get
            {
                return this.spriteDepthField;
            }
            set
            {
                this.spriteDepthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string HiddenInGame
        {
            get
            {
                return this.hiddenInGameField;
            }
            set
            {
                this.hiddenInGameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte i
        {
            get
            {
                return this.iField;
            }
            set
            {
                this.iField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CharacterDataCharacterCampaignDataItemInventoryItemInventoryItemHoldable
    {

        private string holdPosField;

        private byte holdAngleField;

        private string swingAmountField;

        private byte swingSpeedField;

        private string swingWhenHoldingField;

        private string swingWhenAimingField;

        private string swingWhenUsingField;

        private string disableHeadRotationField;

        private decimal spriteDepthWhenDroppedField;

        private byte pickingTimeField;

        private string canBePickedField;

        private string allowInGameEditingField;

        private string msgField;

        private string aimableField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string HoldPos
        {
            get
            {
                return this.holdPosField;
            }
            set
            {
                this.holdPosField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte HoldAngle
        {
            get
            {
                return this.holdAngleField;
            }
            set
            {
                this.holdAngleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SwingAmount
        {
            get
            {
                return this.swingAmountField;
            }
            set
            {
                this.swingAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte SwingSpeed
        {
            get
            {
                return this.swingSpeedField;
            }
            set
            {
                this.swingSpeedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SwingWhenHolding
        {
            get
            {
                return this.swingWhenHoldingField;
            }
            set
            {
                this.swingWhenHoldingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SwingWhenAiming
        {
            get
            {
                return this.swingWhenAimingField;
            }
            set
            {
                this.swingWhenAimingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SwingWhenUsing
        {
            get
            {
                return this.swingWhenUsingField;
            }
            set
            {
                this.swingWhenUsingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DisableHeadRotation
        {
            get
            {
                return this.disableHeadRotationField;
            }
            set
            {
                this.disableHeadRotationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal SpriteDepthWhenDropped
        {
            get
            {
                return this.spriteDepthWhenDroppedField;
            }
            set
            {
                this.spriteDepthWhenDroppedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte PickingTime
        {
            get
            {
                return this.pickingTimeField;
            }
            set
            {
                this.pickingTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CanBePicked
        {
            get
            {
                return this.canBePickedField;
            }
            set
            {
                this.canBePickedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AllowInGameEditing
        {
            get
            {
                return this.allowInGameEditingField;
            }
            set
            {
                this.allowInGameEditingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Msg
        {
            get
            {
                return this.msgField;
            }
            set
            {
                this.msgField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Aimable
        {
            get
            {
                return this.aimableField;
            }
            set
            {
                this.aimableField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CharacterDataCharacterCampaignDataItemInventoryItemInventoryItemQuality
    {

        private byte qualityLevelField;

        private byte pickingTimeField;

        private string canBePickedField;

        private string allowInGameEditingField;

        private string msgField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte QualityLevel
        {
            get
            {
                return this.qualityLevelField;
            }
            set
            {
                this.qualityLevelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte PickingTime
        {
            get
            {
                return this.pickingTimeField;
            }
            set
            {
                this.pickingTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CanBePicked
        {
            get
            {
                return this.canBePickedField;
            }
            set
            {
                this.canBePickedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AllowInGameEditing
        {
            get
            {
                return this.allowInGameEditingField;
            }
            set
            {
                this.allowInGameEditingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Msg
        {
            get
            {
                return this.msgField;
            }
            set
            {
                this.msgField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CharacterDataCharacterCampaignDataItemInventoryItemInventoryItemPickable
    {

        private byte pickingTimeField;

        private string canBePickedField;

        private string allowInGameEditingField;

        private string msgField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte PickingTime
        {
            get
            {
                return this.pickingTimeField;
            }
            set
            {
                this.pickingTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CanBePicked
        {
            get
            {
                return this.canBePickedField;
            }
            set
            {
                this.canBePickedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AllowInGameEditing
        {
            get
            {
                return this.allowInGameEditingField;
            }
            set
            {
                this.allowInGameEditingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Msg
        {
            get
            {
                return this.msgField;
            }
            set
            {
                this.msgField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CharacterDataCharacterCampaignDataItemInventoryItemInventoryItemProjectile
    {

        private byte pickingTimeField;

        private string canBePickedField;

        private string allowInGameEditingField;

        private string msgField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte PickingTime
        {
            get
            {
                return this.pickingTimeField;
            }
            set
            {
                this.pickingTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CanBePicked
        {
            get
            {
                return this.canBePickedField;
            }
            set
            {
                this.canBePickedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AllowInGameEditing
        {
            get
            {
                return this.allowInGameEditingField;
            }
            set
            {
                this.allowInGameEditingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Msg
        {
            get
            {
                return this.msgField;
            }
            set
            {
                this.msgField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CharacterDataCharacterCampaignDataHealth
    {

        private CharacterDataCharacterCampaignDataHealthAffliction afflictionField;

        private CharacterDataCharacterCampaignDataHealthLimbHealth[] limbHealthField;

        /// <remarks/>
        public CharacterDataCharacterCampaignDataHealthAffliction Affliction
        {
            get
            {
                return this.afflictionField;
            }
            set
            {
                this.afflictionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LimbHealth")]
        public CharacterDataCharacterCampaignDataHealthLimbHealth[] LimbHealth
        {
            get
            {
                return this.limbHealthField;
            }
            set
            {
                this.limbHealthField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CharacterDataCharacterCampaignDataHealthAffliction
    {

        private string identifierField;

        private byte strengthField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string identifier
        {
            get
            {
                return this.identifierField;
            }
            set
            {
                this.identifierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte strength
        {
            get
            {
                return this.strengthField;
            }
            set
            {
                this.strengthField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CharacterDataCharacterCampaignDataHealthLimbHealth
    {

        private CharacterDataCharacterCampaignDataHealthLimbHealthAffliction afflictionField;

        private byte iField;

        /// <remarks/>
        public CharacterDataCharacterCampaignDataHealthLimbHealthAffliction Affliction
        {
            get
            {
                return this.afflictionField;
            }
            set
            {
                this.afflictionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte i
        {
            get
            {
                return this.iField;
            }
            set
            {
                this.iField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CharacterDataCharacterCampaignDataHealthLimbHealthAffliction
    {

        private string identifierField;

        private decimal strengthField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string identifier
        {
            get
            {
                return this.identifierField;
            }
            set
            {
                this.identifierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal strength
        {
            get
            {
                return this.strengthField;
            }
            set
            {
                this.strengthField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CharacterDataCharacterCampaignDataOrder
    {

        private string idField;

        private byte priorityField;

        private byte targettypeField;

        private string optionField;

        private byte ordergiverinfoidField;

        private bool ordergiverinfoidFieldSpecified;

        private bool onmainsubField;

        private bool onmainsubFieldSpecified;

        private ushort targetidField;

        private bool targetidFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte priority
        {
            get
            {
                return this.priorityField;
            }
            set
            {
                this.priorityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte targettype
        {
            get
            {
                return this.targettypeField;
            }
            set
            {
                this.targettypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string option
        {
            get
            {
                return this.optionField;
            }
            set
            {
                this.optionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte ordergiverinfoid
        {
            get
            {
                return this.ordergiverinfoidField;
            }
            set
            {
                this.ordergiverinfoidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ordergiverinfoidSpecified
        {
            get
            {
                return this.ordergiverinfoidFieldSpecified;
            }
            set
            {
                this.ordergiverinfoidFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool onmainsub
        {
            get
            {
                return this.onmainsubField;
            }
            set
            {
                this.onmainsubField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool onmainsubSpecified
        {
            get
            {
                return this.onmainsubFieldSpecified;
            }
            set
            {
                this.onmainsubFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort targetid
        {
            get
            {
                return this.targetidField;
            }
            set
            {
                this.targetidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool targetidSpecified
        {
            get
            {
                return this.targetidFieldSpecified;
            }
            set
            {
                this.targetidFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CharacterDataCharacterCampaignDataWallet
    {

        private ushort balanceField;

        private byte rewarddistributionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort balance
        {
            get
            {
                return this.balanceField;
            }
            set
            {
                this.balanceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte rewarddistribution
        {
            get
            {
                return this.rewarddistributionField;
            }
            set
            {
                this.rewarddistributionField = value;
            }
        }
    }


}
