﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2MP.RuleXpressToXMI.Definition.Old
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class Term
    {

        private UsedByTerm[] usedByTermField;

        private UsesTerm[] usesTermField;

        private UsedByFact[] usedByFactField;

        private UsesFact[] usesFactField;

        private UsedByRule[] usedByRuleField;

        private UsedByDecisionTable[] usedByDecisionTableField;

        private ViolatedQualityItem[] violatedQualityItemField;

        private ItemProperties[] itemPropertiesField;

        private TermDefinition[] definitionField;

        private string showField;

        private string displayModeField;

        private string idField;

        private string signifierField;

        private string qualitygradeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("UsedByTerm")]
        public UsedByTerm[] UsedByTerm
        {
            get
            {
                return this.usedByTermField;
            }
            set
            {
                this.usedByTermField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("UsesTerm")]
        public UsesTerm[] UsesTerm
        {
            get
            {
                return this.usesTermField;
            }
            set
            {
                this.usesTermField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("UsedByFact")]
        public UsedByFact[] UsedByFact
        {
            get
            {
                return this.usedByFactField;
            }
            set
            {
                this.usedByFactField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("UsesFact")]
        public UsesFact[] UsesFact
        {
            get
            {
                return this.usesFactField;
            }
            set
            {
                this.usesFactField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("UsedByRule")]
        public UsedByRule[] UsedByRule
        {
            get
            {
                return this.usedByRuleField;
            }
            set
            {
                this.usedByRuleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("UsedByDecisionTable")]
        public UsedByDecisionTable[] UsedByDecisionTable
        {
            get
            {
                return this.usedByDecisionTableField;
            }
            set
            {
                this.usedByDecisionTableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ViolatedQualityItem")]
        public ViolatedQualityItem[] ViolatedQualityItem
        {
            get
            {
                return this.violatedQualityItemField;
            }
            set
            {
                this.violatedQualityItemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemProperties")]
        public ItemProperties[] ItemProperties
        {
            get
            {
                return this.itemPropertiesField;
            }
            set
            {
                this.itemPropertiesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Definition", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public TermDefinition[] Definition
        {
            get
            {
                return this.definitionField;
            }
            set
            {
                this.definitionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string show
        {
            get
            {
                return this.showField;
            }
            set
            {
                this.showField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string displayMode
        {
            get
            {
                return this.displayModeField;
            }
            set
            {
                this.displayModeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ID
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
        public string signifier
        {
            get
            {
                return this.signifierField;
            }
            set
            {
                this.signifierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string qualitygrade
        {
            get
            {
                return this.qualitygradeField;
            }
            set
            {
                this.qualitygradeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class UsedByTerm
    {

        private string refField;

        private string textField;

        private string showField;

        private string displayModeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Ref
        {
            get
            {
                return this.refField;
            }
            set
            {
                this.refField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string show
        {
            get
            {
                return this.showField;
            }
            set
            {
                this.showField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string displayMode
        {
            get
            {
                return this.displayModeField;
            }
            set
            {
                this.displayModeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class UsesTerm
    {

        private string showField;

        private string displayModeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string show
        {
            get
            {
                return this.showField;
            }
            set
            {
                this.showField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string displayMode
        {
            get
            {
                return this.displayModeField;
            }
            set
            {
                this.displayModeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class UsedByFact
    {

        private string showField;

        private string displayModeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string show
        {
            get
            {
                return this.showField;
            }
            set
            {
                this.showField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string displayMode
        {
            get
            {
                return this.displayModeField;
            }
            set
            {
                this.displayModeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class UsesFact
    {

        private string showField;

        private string displayModeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string show
        {
            get
            {
                return this.showField;
            }
            set
            {
                this.showField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string displayMode
        {
            get
            {
                return this.displayModeField;
            }
            set
            {
                this.displayModeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class UsedByRule
    {

        private string refField;

        private string textField;

        private string showField;

        private string displayModeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Ref
        {
            get
            {
                return this.refField;
            }
            set
            {
                this.refField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string show
        {
            get
            {
                return this.showField;
            }
            set
            {
                this.showField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string displayMode
        {
            get
            {
                return this.displayModeField;
            }
            set
            {
                this.displayModeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class UsedByDecisionTable
    {

        private string showField;

        private string displayModeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string show
        {
            get
            {
                return this.showField;
            }
            set
            {
                this.showField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string displayMode
        {
            get
            {
                return this.displayModeField;
            }
            set
            {
                this.displayModeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class ViolatedQualityItem
    {

        private string refField;

        private string textField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Ref
        {
            get
            {
                return this.refField;
            }
            set
            {
                this.refField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class ItemProperties
    {

        private string groupNameField;

        private ItemPropertiesItemProperty[] itemPropertyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string GroupName
        {
            get
            {
                return this.groupNameField;
            }
            set
            {
                this.groupNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemProperty", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ItemPropertiesItemProperty[] ItemProperty
        {
            get
            {
                return this.itemPropertyField;
            }
            set
            {
                this.itemPropertyField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ItemPropertiesItemProperty
    {

        private string nameField;

        private ItemPropertiesItemPropertyValue[] valueField;

        private ItemPropertiesItemPropertySubProperty[] subPropertyField;

        private string conceptIDField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Name
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
        [System.Xml.Serialization.XmlElementAttribute("Value", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ItemPropertiesItemPropertyValue[] Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SubProperty", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ItemPropertiesItemPropertySubProperty[] SubProperty
        {
            get
            {
                return this.subPropertyField;
            }
            set
            {
                this.subPropertyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ConceptID
        {
            get
            {
                return this.conceptIDField;
            }
            set
            {
                this.conceptIDField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ItemPropertiesItemPropertyValue
    {

        private string textField;

        private string strValField;

        private string propertyValueIDField;

        private string realValField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string StrVal
        {
            get
            {
                return this.strValField;
            }
            set
            {
                this.strValField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PropertyValueID
        {
            get
            {
                return this.propertyValueIDField;
            }
            set
            {
                this.propertyValueIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RealVal
        {
            get
            {
                return this.realValField;
            }
            set
            {
                this.realValField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ItemPropertiesItemPropertySubProperty
    {

        private string nameField;

        private string valueField;

        private string conceptIDField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Name
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
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ConceptID
        {
            get
            {
                return this.conceptIDField;
            }
            set
            {
                this.conceptIDField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class TermDefinition
    {

        private Text[] textField;

        private TermRef[] termRefField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Text", IsNullable = true)]
        public Text[] Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TermRef", IsNullable = true)]
        public TermRef[] TermRef
        {
            get
            {
                return this.termRefField;
            }
            set
            {
                this.termRefField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
    public partial class Text
    {

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
    public partial class TermRef
    {

        private string idrefField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string idref
        {
            get
            {
                return this.idrefField;
            }
            set
            {
                this.idrefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class FactSymbol
    {

        private UsedByFact[] usedByFactField;

        private ItemProperties[] itemPropertiesField;

        private FactSymbolFactSymbolExpression[] factSymbolExpressionField;

        private string showField;

        private string displayModeField;

        private string idField;

        private string signifierField;

        private string qualitygradeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("UsedByFact")]
        public UsedByFact[] UsedByFact
        {
            get
            {
                return this.usedByFactField;
            }
            set
            {
                this.usedByFactField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemProperties")]
        public ItemProperties[] ItemProperties
        {
            get
            {
                return this.itemPropertiesField;
            }
            set
            {
                this.itemPropertiesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FactSymbolExpression", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public FactSymbolFactSymbolExpression[] FactSymbolExpression
        {
            get
            {
                return this.factSymbolExpressionField;
            }
            set
            {
                this.factSymbolExpressionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string show
        {
            get
            {
                return this.showField;
            }
            set
            {
                this.showField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string displayMode
        {
            get
            {
                return this.displayModeField;
            }
            set
            {
                this.displayModeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ID
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
        public string signifier
        {
            get
            {
                return this.signifierField;
            }
            set
            {
                this.signifierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string qualitygrade
        {
            get
            {
                return this.qualitygradeField;
            }
            set
            {
                this.qualitygradeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FactSymbolFactSymbolExpression
    {

        private string textField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class Rule
    {

        private UsesTerm[] usesTermField;

        private UsesFact[] usesFactField;

        private RuleRelation[] ruleRelationField;

        private UsedByRuleGroup[] usedByRuleGroupField;

        private ViolatedQualityItem[] violatedQualityItemField;

        private ItemProperties[] itemPropertiesField;

        private RuleStatement[] statementField;

        private string showField;

        private string displayModeField;

        private string idField;

        private string signifierField;

        private string qualitygradeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("UsesTerm")]
        public UsesTerm[] UsesTerm
        {
            get
            {
                return this.usesTermField;
            }
            set
            {
                this.usesTermField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("UsesFact")]
        public UsesFact[] UsesFact
        {
            get
            {
                return this.usesFactField;
            }
            set
            {
                this.usesFactField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RuleRelation")]
        public RuleRelation[] RuleRelation
        {
            get
            {
                return this.ruleRelationField;
            }
            set
            {
                this.ruleRelationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("UsedByRuleGroup")]
        public UsedByRuleGroup[] UsedByRuleGroup
        {
            get
            {
                return this.usedByRuleGroupField;
            }
            set
            {
                this.usedByRuleGroupField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ViolatedQualityItem")]
        public ViolatedQualityItem[] ViolatedQualityItem
        {
            get
            {
                return this.violatedQualityItemField;
            }
            set
            {
                this.violatedQualityItemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemProperties")]
        public ItemProperties[] ItemProperties
        {
            get
            {
                return this.itemPropertiesField;
            }
            set
            {
                this.itemPropertiesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Statement", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public RuleStatement[] Statement
        {
            get
            {
                return this.statementField;
            }
            set
            {
                this.statementField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string show
        {
            get
            {
                return this.showField;
            }
            set
            {
                this.showField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string displayMode
        {
            get
            {
                return this.displayModeField;
            }
            set
            {
                this.displayModeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ID
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
        public string signifier
        {
            get
            {
                return this.signifierField;
            }
            set
            {
                this.signifierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string qualitygrade
        {
            get
            {
                return this.qualitygradeField;
            }
            set
            {
                this.qualitygradeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class RuleRelation
    {

        private string showField;

        private string displayModeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string show
        {
            get
            {
                return this.showField;
            }
            set
            {
                this.showField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string displayMode
        {
            get
            {
                return this.displayModeField;
            }
            set
            {
                this.displayModeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class UsedByRuleGroup
    {

        private string showField;

        private string displayModeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string show
        {
            get
            {
                return this.showField;
            }
            set
            {
                this.showField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string displayMode
        {
            get
            {
                return this.displayModeField;
            }
            set
            {
                this.displayModeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RuleStatement
    {

        private Text[] textField;

        private TermRef[] termRefField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Text", IsNullable = true)]
        public Text[] Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TermRef", IsNullable = true)]
        public TermRef[] TermRef
        {
            get
            {
                return this.termRefField;
            }
            set
            {
                this.termRefField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class UsesDecisionTable
    {

        private string showField;

        private string displayModeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string show
        {
            get
            {
                return this.showField;
            }
            set
            {
                this.showField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string displayMode
        {
            get
            {
                return this.displayModeField;
            }
            set
            {
                this.displayModeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class UsesRule
    {

        private string showField;

        private string displayModeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string show
        {
            get
            {
                return this.showField;
            }
            set
            {
                this.showField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string displayMode
        {
            get
            {
                return this.displayModeField;
            }
            set
            {
                this.displayModeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class UsesRuleGroup
    {

        private string showField;

        private string displayModeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string show
        {
            get
            {
                return this.showField;
            }
            set
            {
                this.showField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string displayMode
        {
            get
            {
                return this.displayModeField;
            }
            set
            {
                this.displayModeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class QualityItem
    {

        private string descriptionField;

        private string motivationField;

        private string examplesField;

        private UsedByTerm[] usedByTermField;

        private UsesTerm[] usesTermField;

        private UsedByFact[] usedByFactField;

        private UsesFact[] usesFactField;

        private QualityItemUsedByFactSymbol[] usedByFactSymbolField;

        private UsedByRule[] usedByRuleField;

        private UsedByDecisionTable[] usedByDecisionTableField;

        private UsesRule[] usesRuleField;

        private UsesDecisionTable[] usesDecisionTableField;

        private RuleRelation[] ruleRelationField;

        private UsedByRuleGroup[] usedByRuleGroupField;

        private UsesRuleGroup[] usesRuleGroupField;

        private string showField;

        private string displayModeField;

        private string idField;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Motivation
        {
            get
            {
                return this.motivationField;
            }
            set
            {
                this.motivationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Examples
        {
            get
            {
                return this.examplesField;
            }
            set
            {
                this.examplesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("UsedByTerm")]
        public UsedByTerm[] UsedByTerm
        {
            get
            {
                return this.usedByTermField;
            }
            set
            {
                this.usedByTermField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("UsesTerm")]
        public UsesTerm[] UsesTerm
        {
            get
            {
                return this.usesTermField;
            }
            set
            {
                this.usesTermField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("UsedByFact")]
        public UsedByFact[] UsedByFact
        {
            get
            {
                return this.usedByFactField;
            }
            set
            {
                this.usedByFactField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("UsesFact")]
        public UsesFact[] UsesFact
        {
            get
            {
                return this.usesFactField;
            }
            set
            {
                this.usesFactField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("UsedByFactSymbol", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public QualityItemUsedByFactSymbol[] UsedByFactSymbol
        {
            get
            {
                return this.usedByFactSymbolField;
            }
            set
            {
                this.usedByFactSymbolField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("UsedByRule")]
        public UsedByRule[] UsedByRule
        {
            get
            {
                return this.usedByRuleField;
            }
            set
            {
                this.usedByRuleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("UsedByDecisionTable")]
        public UsedByDecisionTable[] UsedByDecisionTable
        {
            get
            {
                return this.usedByDecisionTableField;
            }
            set
            {
                this.usedByDecisionTableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("UsesRule")]
        public UsesRule[] UsesRule
        {
            get
            {
                return this.usesRuleField;
            }
            set
            {
                this.usesRuleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("UsesDecisionTable")]
        public UsesDecisionTable[] UsesDecisionTable
        {
            get
            {
                return this.usesDecisionTableField;
            }
            set
            {
                this.usesDecisionTableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RuleRelation")]
        public RuleRelation[] RuleRelation
        {
            get
            {
                return this.ruleRelationField;
            }
            set
            {
                this.ruleRelationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("UsedByRuleGroup")]
        public UsedByRuleGroup[] UsedByRuleGroup
        {
            get
            {
                return this.usedByRuleGroupField;
            }
            set
            {
                this.usedByRuleGroupField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("UsesRuleGroup")]
        public UsesRuleGroup[] UsesRuleGroup
        {
            get
            {
                return this.usesRuleGroupField;
            }
            set
            {
                this.usesRuleGroupField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string show
        {
            get
            {
                return this.showField;
            }
            set
            {
                this.showField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string displayMode
        {
            get
            {
                return this.displayModeField;
            }
            set
            {
                this.displayModeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ID
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class QualityItemUsedByFactSymbol
    {

        private string showField;

        private string displayModeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string show
        {
            get
            {
                return this.showField;
            }
            set
            {
                this.showField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string displayMode
        {
            get
            {
                return this.displayModeField;
            }
            set
            {
                this.displayModeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class RuleXpressPublication
    {

        private string appliedFilterField;

        private RuleXpressPublicationLayout[] layoutField;

        private RuleXpressPublicationContent[] contentField;

        private string languageField;

        private string reportdateField;

        private string reportmemberField;

        private string titleField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string AppliedFilter
        {
            get
            {
                return this.appliedFilterField;
            }
            set
            {
                this.appliedFilterField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Layout", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public RuleXpressPublicationLayout[] Layout
        {
            get
            {
                return this.layoutField;
            }
            set
            {
                this.layoutField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Content", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public RuleXpressPublicationContent[] Content
        {
            get
            {
                return this.contentField;
            }
            set
            {
                this.contentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string language
        {
            get
            {
                return this.languageField;
            }
            set
            {
                this.languageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string reportdate
        {
            get
            {
                return this.reportdateField;
            }
            set
            {
                this.reportdateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string reportmember
        {
            get
            {
                return this.reportmemberField;
            }
            set
            {
                this.reportmemberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RuleXpressPublicationLayout
    {

        private RuleXpressPublicationLayoutDocument[] documentField;

        private RuleXpressPublicationLayoutHeader[] headerField;

        private RuleXpressPublicationLayoutItem[] itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Document", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public RuleXpressPublicationLayoutDocument[] Document
        {
            get
            {
                return this.documentField;
            }
            set
            {
                this.documentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Header", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public RuleXpressPublicationLayoutHeader[] Header
        {
            get
            {
                return this.headerField;
            }
            set
            {
                this.headerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Item", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public RuleXpressPublicationLayoutItem[] Item
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RuleXpressPublicationLayoutDocument
    {

        private RuleXpressPublicationLayoutDocumentEmptyProperties[] emptyPropertiesField;

        private string orientationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EmptyProperties", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public RuleXpressPublicationLayoutDocumentEmptyProperties[] EmptyProperties
        {
            get
            {
                return this.emptyPropertiesField;
            }
            set
            {
                this.emptyPropertiesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string orientation
        {
            get
            {
                return this.orientationField;
            }
            set
            {
                this.orientationField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RuleXpressPublicationLayoutDocumentEmptyProperties
    {

        private string showField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string show
        {
            get
            {
                return this.showField;
            }
            set
            {
                this.showField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RuleXpressPublicationLayoutHeader
    {

        private RuleXpressPublicationLayoutHeaderShortcutList[] shortcutListField;

        private RuleXpressPublicationLayoutHeaderAppliedFilters[] appliedFiltersField;

        private RuleXpressPublicationLayoutHeaderGeneralInformation[] generalInformationField;

        private string showField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ShortcutList", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public RuleXpressPublicationLayoutHeaderShortcutList[] ShortcutList
        {
            get
            {
                return this.shortcutListField;
            }
            set
            {
                this.shortcutListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AppliedFilters", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public RuleXpressPublicationLayoutHeaderAppliedFilters[] AppliedFilters
        {
            get
            {
                return this.appliedFiltersField;
            }
            set
            {
                this.appliedFiltersField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("GeneralInformation", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public RuleXpressPublicationLayoutHeaderGeneralInformation[] GeneralInformation
        {
            get
            {
                return this.generalInformationField;
            }
            set
            {
                this.generalInformationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string show
        {
            get
            {
                return this.showField;
            }
            set
            {
                this.showField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RuleXpressPublicationLayoutHeaderShortcutList
    {

        private string showField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string show
        {
            get
            {
                return this.showField;
            }
            set
            {
                this.showField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RuleXpressPublicationLayoutHeaderAppliedFilters
    {

        private string showField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string show
        {
            get
            {
                return this.showField;
            }
            set
            {
                this.showField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RuleXpressPublicationLayoutHeaderGeneralInformation
    {

        private string showField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string show
        {
            get
            {
                return this.showField;
            }
            set
            {
                this.showField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RuleXpressPublicationLayoutItem
    {

        private Term[] termField;

        private RuleXpressPublicationLayoutItemFact[] factField;

        private FactSymbol[] factSymbolField;

        private Rule[] ruleField;

        private RuleXpressPublicationLayoutItemDecisionTable[] decisionTableField;

        private RuleXpressPublicationLayoutItemRuleGroup[] ruleGroupField;

        private QualityItem[] qualityItemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Term")]
        public Term[] Term
        {
            get
            {
                return this.termField;
            }
            set
            {
                this.termField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Fact", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public RuleXpressPublicationLayoutItemFact[] Fact
        {
            get
            {
                return this.factField;
            }
            set
            {
                this.factField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FactSymbol")]
        public FactSymbol[] FactSymbol
        {
            get
            {
                return this.factSymbolField;
            }
            set
            {
                this.factSymbolField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Rule")]
        public Rule[] Rule
        {
            get
            {
                return this.ruleField;
            }
            set
            {
                this.ruleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DecisionTable", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public RuleXpressPublicationLayoutItemDecisionTable[] DecisionTable
        {
            get
            {
                return this.decisionTableField;
            }
            set
            {
                this.decisionTableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RuleGroup", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public RuleXpressPublicationLayoutItemRuleGroup[] RuleGroup
        {
            get
            {
                return this.ruleGroupField;
            }
            set
            {
                this.ruleGroupField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("QualityItem")]
        public QualityItem[] QualityItem
        {
            get
            {
                return this.qualityItemField;
            }
            set
            {
                this.qualityItemField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RuleXpressPublicationLayoutItemFact
    {

        private UsedByTerm[] usedByTermField;

        private UsesTerm[] usesTermField;

        private RuleXpressPublicationLayoutItemFactUsesFactSymbol[] usesFactSymbolField;

        private UsedByRule[] usedByRuleField;

        private string showField;

        private string displayModeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("UsedByTerm")]
        public UsedByTerm[] UsedByTerm
        {
            get
            {
                return this.usedByTermField;
            }
            set
            {
                this.usedByTermField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("UsesTerm")]
        public UsesTerm[] UsesTerm
        {
            get
            {
                return this.usesTermField;
            }
            set
            {
                this.usesTermField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("UsesFactSymbol", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public RuleXpressPublicationLayoutItemFactUsesFactSymbol[] UsesFactSymbol
        {
            get
            {
                return this.usesFactSymbolField;
            }
            set
            {
                this.usesFactSymbolField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("UsedByRule")]
        public UsedByRule[] UsedByRule
        {
            get
            {
                return this.usedByRuleField;
            }
            set
            {
                this.usedByRuleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string show
        {
            get
            {
                return this.showField;
            }
            set
            {
                this.showField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string displayMode
        {
            get
            {
                return this.displayModeField;
            }
            set
            {
                this.displayModeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RuleXpressPublicationLayoutItemFactUsesFactSymbol
    {

        private string showField;

        private string displayModeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string show
        {
            get
            {
                return this.showField;
            }
            set
            {
                this.showField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string displayMode
        {
            get
            {
                return this.displayModeField;
            }
            set
            {
                this.displayModeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RuleXpressPublicationLayoutItemDecisionTable
    {

        private UsesTerm[] usesTermField;

        private UsedByDecisionTable[] usedByDecisionTableField;

        private UsesDecisionTable[] usesDecisionTableField;

        private UsedByRuleGroup[] usedByRuleGroupField;

        private string showField;

        private string displayModeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("UsesTerm")]
        public UsesTerm[] UsesTerm
        {
            get
            {
                return this.usesTermField;
            }
            set
            {
                this.usesTermField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("UsedByDecisionTable")]
        public UsedByDecisionTable[] UsedByDecisionTable
        {
            get
            {
                return this.usedByDecisionTableField;
            }
            set
            {
                this.usedByDecisionTableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("UsesDecisionTable")]
        public UsesDecisionTable[] UsesDecisionTable
        {
            get
            {
                return this.usesDecisionTableField;
            }
            set
            {
                this.usesDecisionTableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("UsedByRuleGroup")]
        public UsedByRuleGroup[] UsedByRuleGroup
        {
            get
            {
                return this.usedByRuleGroupField;
            }
            set
            {
                this.usedByRuleGroupField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string show
        {
            get
            {
                return this.showField;
            }
            set
            {
                this.showField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string displayMode
        {
            get
            {
                return this.displayModeField;
            }
            set
            {
                this.displayModeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RuleXpressPublicationLayoutItemRuleGroup
    {

        private UsesRule[] usesRuleField;

        private UsesDecisionTable[] usesDecisionTableField;

        private UsedByRuleGroup[] usedByRuleGroupField;

        private UsesRuleGroup[] usesRuleGroupField;

        private string showField;

        private string displayModeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("UsesRule")]
        public UsesRule[] UsesRule
        {
            get
            {
                return this.usesRuleField;
            }
            set
            {
                this.usesRuleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("UsesDecisionTable")]
        public UsesDecisionTable[] UsesDecisionTable
        {
            get
            {
                return this.usesDecisionTableField;
            }
            set
            {
                this.usesDecisionTableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("UsedByRuleGroup")]
        public UsedByRuleGroup[] UsedByRuleGroup
        {
            get
            {
                return this.usedByRuleGroupField;
            }
            set
            {
                this.usedByRuleGroupField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("UsesRuleGroup")]
        public UsesRuleGroup[] UsesRuleGroup
        {
            get
            {
                return this.usesRuleGroupField;
            }
            set
            {
                this.usesRuleGroupField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string show
        {
            get
            {
                return this.showField;
            }
            set
            {
                this.showField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string displayMode
        {
            get
            {
                return this.displayModeField;
            }
            set
            {
                this.displayModeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RuleXpressPublicationContent
    {

        private RuleXpressPublicationContentCommunity[] communityField;

        private Term[] termField;

        private FactSymbol[] factSymbolField;

        private Rule[] ruleField;

        private QualityItem[] qualityItemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Community", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public RuleXpressPublicationContentCommunity[] Community
        {
            get
            {
                return this.communityField;
            }
            set
            {
                this.communityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Term")]
        public Term[] Term
        {
            get
            {
                return this.termField;
            }
            set
            {
                this.termField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FactSymbol")]
        public FactSymbol[] FactSymbol
        {
            get
            {
                return this.factSymbolField;
            }
            set
            {
                this.factSymbolField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Rule")]
        public Rule[] Rule
        {
            get
            {
                return this.ruleField;
            }
            set
            {
                this.ruleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("QualityItem")]
        public QualityItem[] QualityItem
        {
            get
            {
                return this.qualityItemField;
            }
            set
            {
                this.qualityItemField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class RuleXpressPublicationContentCommunity
    {

        private string idField;

        private string signifierField;

        private string descriptionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ID
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
        public string signifier
        {
            get
            {
                return this.signifierField;
            }
            set
            {
                this.signifierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class NewDataSet
    {

        private object[] itemsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FactSymbol", typeof(FactSymbol))]
        [System.Xml.Serialization.XmlElementAttribute("ItemProperties", typeof(ItemProperties))]
        [System.Xml.Serialization.XmlElementAttribute("QualityItem", typeof(QualityItem))]
        [System.Xml.Serialization.XmlElementAttribute("Rule", typeof(Rule))]
        [System.Xml.Serialization.XmlElementAttribute("RuleRelation", typeof(RuleRelation))]
        [System.Xml.Serialization.XmlElementAttribute("RuleXpressPublication", typeof(RuleXpressPublication))]
        [System.Xml.Serialization.XmlElementAttribute("Term", typeof(Term))]
        [System.Xml.Serialization.XmlElementAttribute("TermRef", typeof(TermRef), IsNullable = true)]
        [System.Xml.Serialization.XmlElementAttribute("Text", typeof(Text), IsNullable = true)]
        [System.Xml.Serialization.XmlElementAttribute("UsedByDecisionTable", typeof(UsedByDecisionTable))]
        [System.Xml.Serialization.XmlElementAttribute("UsedByFact", typeof(UsedByFact))]
        [System.Xml.Serialization.XmlElementAttribute("UsedByRule", typeof(UsedByRule))]
        [System.Xml.Serialization.XmlElementAttribute("UsedByRuleGroup", typeof(UsedByRuleGroup))]
        [System.Xml.Serialization.XmlElementAttribute("UsedByTerm", typeof(UsedByTerm))]
        [System.Xml.Serialization.XmlElementAttribute("UsesDecisionTable", typeof(UsesDecisionTable))]
        [System.Xml.Serialization.XmlElementAttribute("UsesFact", typeof(UsesFact))]
        [System.Xml.Serialization.XmlElementAttribute("UsesRule", typeof(UsesRule))]
        [System.Xml.Serialization.XmlElementAttribute("UsesRuleGroup", typeof(UsesRuleGroup))]
        [System.Xml.Serialization.XmlElementAttribute("UsesTerm", typeof(UsesTerm))]
        [System.Xml.Serialization.XmlElementAttribute("ViolatedQualityItem", typeof(ViolatedQualityItem))]
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
    }
}