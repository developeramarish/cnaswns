﻿namespace Cnas.wns.CnasBarcodeLib
{

    [global::System.Serializable()]
    [global::System.ComponentModel.DesignerCategoryAttribute("code")]
    [global::System.ComponentModel.ToolboxItem(true)]
    [global::System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedDataSetSchema")]
    [global::System.Xml.Serialization.XmlRootAttribute("BarcodeXML")]
    [global::System.ComponentModel.Design.HelpKeywordAttribute("vs.data.DataSet")]
    public partial class BarcodeXML : global::System.Data.DataSet
    {

        private BarcodeDataTable tableBarcode;

        private global::System.Data.SchemaSerializationMode _schemaSerializationMode = global::System.Data.SchemaSerializationMode.IncludeSchema;

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public BarcodeXML()
        {
            this.BeginInit();
            this.InitClass();
            global::System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new global::System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            base.Tables.CollectionChanged += schemaChangedHandler;
            base.Relations.CollectionChanged += schemaChangedHandler;
            this.EndInit();
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected BarcodeXML(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) :
            base(info, context, false)
        {
            if ((this.IsBinarySerialized(info, context) == true))
            {
                this.InitVars(false);
                global::System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler1 = new global::System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
                this.Tables.CollectionChanged += schemaChangedHandler1;
                this.Relations.CollectionChanged += schemaChangedHandler1;
                return;
            }
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((this.DetermineSchemaSerializationMode(info, context) == global::System.Data.SchemaSerializationMode.IncludeSchema))
            {
                global::System.Data.DataSet ds = new global::System.Data.DataSet();
                ds.ReadXmlSchema(new global::System.Xml.XmlTextReader(new global::System.IO.StringReader(strSchema)));
                if ((ds.Tables["Barcode"] != null))
                {
                    base.Tables.Add(new BarcodeDataTable(ds.Tables["Barcode"]));
                }
                this.DataSetName = ds.DataSetName;
                this.Prefix = ds.Prefix;
                this.Namespace = ds.Namespace;
                this.Locale = ds.Locale;
                this.CaseSensitive = ds.CaseSensitive;
                this.EnforceConstraints = ds.EnforceConstraints;
                this.Merge(ds, false, global::System.Data.MissingSchemaAction.Add);
                this.InitVars();
            }
            else
            {
                this.ReadXmlSchema(new global::System.Xml.XmlTextReader(new global::System.IO.StringReader(strSchema)));
            }
            this.GetSerializationData(info, context);
            global::System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new global::System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            base.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.Browsable(false)]
        [global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
        public BarcodeDataTable Barcode
        {
            get
            {
                return this.tableBarcode;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.BrowsableAttribute(true)]
        [global::System.ComponentModel.DesignerSerializationVisibilityAttribute(global::System.ComponentModel.DesignerSerializationVisibility.Visible)]
        public override global::System.Data.SchemaSerializationMode SchemaSerializationMode
        {
            get
            {
                return this._schemaSerializationMode;
            }
            set
            {
                this._schemaSerializationMode = value;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.DesignerSerializationVisibilityAttribute(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public new global::System.Data.DataTableCollection Tables
        {
            get
            {
                return base.Tables;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        [global::System.ComponentModel.DesignerSerializationVisibilityAttribute(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public new global::System.Data.DataRelationCollection Relations
        {
            get
            {
                return base.Relations;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override void InitializeDerivedDataSet()
        {
            this.BeginInit();
            this.InitClass();
            this.EndInit();
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public override global::System.Data.DataSet Clone()
        {
            BarcodeXML cln = ((BarcodeXML)(base.Clone()));
            cln.InitVars();
            cln.SchemaSerializationMode = this.SchemaSerializationMode;
            return cln;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override bool ShouldSerializeTables()
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override bool ShouldSerializeRelations()
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override void ReadXmlSerializable(global::System.Xml.XmlReader reader)
        {
            if ((this.DetermineSchemaSerializationMode(reader) == global::System.Data.SchemaSerializationMode.IncludeSchema))
            {
                this.Reset();
                global::System.Data.DataSet ds = new global::System.Data.DataSet();
                ds.ReadXml(reader);
                if ((ds.Tables["Barcode"] != null))
                {
                    base.Tables.Add(new BarcodeDataTable(ds.Tables["Barcode"]));
                }
                this.DataSetName = ds.DataSetName;
                this.Prefix = ds.Prefix;
                this.Namespace = ds.Namespace;
                this.Locale = ds.Locale;
                this.CaseSensitive = ds.CaseSensitive;
                this.EnforceConstraints = ds.EnforceConstraints;
                this.Merge(ds, false, global::System.Data.MissingSchemaAction.Add);
                this.InitVars();
            }
            else
            {
                this.ReadXml(reader);
                this.InitVars();
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override global::System.Xml.Schema.XmlSchema GetSchemaSerializable()
        {
            global::System.IO.MemoryStream stream = new global::System.IO.MemoryStream();
            this.WriteXmlSchema(new global::System.Xml.XmlTextWriter(stream, null));
            stream.Position = 0;
            return global::System.Xml.Schema.XmlSchema.Read(new global::System.Xml.XmlTextReader(stream), null);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        internal void InitVars()
        {
            this.InitVars(true);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        internal void InitVars(bool initTable)
        {
            this.tableBarcode = ((BarcodeDataTable)(base.Tables["Barcode"]));
            if ((initTable == true))
            {
                if ((this.tableBarcode != null))
                {
                    this.tableBarcode.InitVars();
                }
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private void InitClass()
        {
            this.DataSetName = "BarcodeXML";
            this.Prefix = "";
            this.Namespace = "http://tempuri.org/BarcodeXML.xsd";
            this.EnforceConstraints = true;
            this.SchemaSerializationMode = global::System.Data.SchemaSerializationMode.IncludeSchema;
            this.tableBarcode = new BarcodeDataTable();
            base.Tables.Add(this.tableBarcode);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private bool ShouldSerializeBarcode()
        {
            return false;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private void SchemaChanged(object sender, global::System.ComponentModel.CollectionChangeEventArgs e)
        {
            if ((e.Action == global::System.ComponentModel.CollectionChangeAction.Remove))
            {
                this.InitVars();
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public static global::System.Xml.Schema.XmlSchemaComplexType GetTypedDataSetSchema(global::System.Xml.Schema.XmlSchemaSet xs)
        {
            BarcodeXML ds = new BarcodeXML();
            global::System.Xml.Schema.XmlSchemaComplexType type = new global::System.Xml.Schema.XmlSchemaComplexType();
            global::System.Xml.Schema.XmlSchemaSequence sequence = new global::System.Xml.Schema.XmlSchemaSequence();
            global::System.Xml.Schema.XmlSchemaAny any = new global::System.Xml.Schema.XmlSchemaAny();
            any.Namespace = ds.Namespace;
            sequence.Items.Add(any);
            type.Particle = sequence;
            global::System.Xml.Schema.XmlSchema dsSchema = ds.GetSchemaSerializable();
            if (xs.Contains(dsSchema.TargetNamespace))
            {
                global::System.IO.MemoryStream s1 = new global::System.IO.MemoryStream();
                global::System.IO.MemoryStream s2 = new global::System.IO.MemoryStream();
                try
                {
                    global::System.Xml.Schema.XmlSchema schema = null;
                    dsSchema.Write(s1);
                    for (global::System.Collections.IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator(); schemas.MoveNext(); )
                    {
                        schema = ((global::System.Xml.Schema.XmlSchema)(schemas.Current));
                        s2.SetLength(0);
                        schema.Write(s2);
                        if ((s1.Length == s2.Length))
                        {
                            s1.Position = 0;
                            s2.Position = 0;
                            for (; ((s1.Position != s1.Length)
                                        && (s1.ReadByte() == s2.ReadByte())); )
                            {
                                ;
                            }
                            if ((s1.Position == s1.Length))
                            {
                                return type;
                            }
                        }
                    }
                }
                finally
                {
                    if ((s1 != null))
                    {
                        s1.Close();
                    }
                    if ((s2 != null))
                    {
                        s2.Close();
                    }
                }
            }
            xs.Add(dsSchema);
            return type;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void BarcodeRowChangeEventHandler(object sender, BarcodeRowChangeEvent e);

        /// <summary>
        ///Represents the strongly named DataTable class.
        ///</summary>
        [global::System.Serializable()]
        [global::System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")]
        public partial class BarcodeDataTable : global::System.Data.DataTable, global::System.Collections.IEnumerable
        {

            private global::System.Data.DataColumn columnType;

            private global::System.Data.DataColumn columnRawData;

            private global::System.Data.DataColumn columnEncodedValue;

            private global::System.Data.DataColumn columnEncodingTime;

            private global::System.Data.DataColumn columnIncludeLabel;

            private global::System.Data.DataColumn columnForecolor;

            private global::System.Data.DataColumn columnBackcolor;

            private global::System.Data.DataColumn columnCountryAssigningManufacturingCode;

            private global::System.Data.DataColumn columnImageWidth;

            private global::System.Data.DataColumn columnImageHeight;

            private global::System.Data.DataColumn columnImage;

            private global::System.Data.DataColumn columnRotateFlipType;

            private global::System.Data.DataColumn columnLabelPosition;

            private global::System.Data.DataColumn columnAlignment;

            private global::System.Data.DataColumn columnLabelFont;

            private global::System.Data.DataColumn columnImageFormat;

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public BarcodeDataTable()
            {
                this.TableName = "Barcode";
                this.BeginInit();
                this.InitClass();
                this.EndInit();
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal BarcodeDataTable(global::System.Data.DataTable table)
            {
                this.TableName = table.TableName;
                if ((table.CaseSensitive != table.DataSet.CaseSensitive))
                {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString()))
                {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace))
                {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected BarcodeDataTable(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) :
                base(info, context)
            {
                this.InitVars();
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn TypeColumn
            {
                get
                {
                    return this.columnType;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn RawDataColumn
            {
                get
                {
                    return this.columnRawData;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn EncodedValueColumn
            {
                get
                {
                    return this.columnEncodedValue;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn EncodingTimeColumn
            {
                get
                {
                    return this.columnEncodingTime;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn IncludeLabelColumn
            {
                get
                {
                    return this.columnIncludeLabel;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn ForecolorColumn
            {
                get
                {
                    return this.columnForecolor;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn BackcolorColumn
            {
                get
                {
                    return this.columnBackcolor;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn CountryAssigningManufacturingCodeColumn
            {
                get
                {
                    return this.columnCountryAssigningManufacturingCode;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn ImageWidthColumn
            {
                get
                {
                    return this.columnImageWidth;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn ImageHeightColumn
            {
                get
                {
                    return this.columnImageHeight;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn ImageColumn
            {
                get
                {
                    return this.columnImage;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn RotateFlipTypeColumn
            {
                get
                {
                    return this.columnRotateFlipType;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn LabelPositionColumn
            {
                get
                {
                    return this.columnLabelPosition;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn AlignmentColumn
            {
                get
                {
                    return this.columnAlignment;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn LabelFontColumn
            {
                get
                {
                    return this.columnLabelFont;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataColumn ImageFormatColumn
            {
                get
                {
                    return this.columnImageFormat;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [global::System.ComponentModel.Browsable(false)]
            public int Count
            {
                get
                {
                    return this.Rows.Count;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public BarcodeRow this[int index]
            {
                get
                {
                    return ((BarcodeRow)(this.Rows[index]));
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event BarcodeRowChangeEventHandler BarcodeRowChanging;

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event BarcodeRowChangeEventHandler BarcodeRowChanged;

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event BarcodeRowChangeEventHandler BarcodeRowDeleting;

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public event BarcodeRowChangeEventHandler BarcodeRowDeleted;

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void AddBarcodeRow(BarcodeRow row)
            {
                this.Rows.Add(row);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public BarcodeRow AddBarcodeRow(
                        string Type,
                        string RawData,
                        string EncodedValue,
                        double EncodingTime,
                        bool IncludeLabel,
                        string Forecolor,
                        string Backcolor,
                        string CountryAssigningManufacturingCode,
                        int ImageWidth,
                        int ImageHeight,
                        string Image,
                        System.Drawing.RotateFlipType RotateFlipType,
                        Cnas.wns.CnasBarcodeLib.LabelPositions LabelPosition,
                        Cnas.wns.CnasBarcodeLib.AlignmentPositions Alignment,
                        string LabelFont,
                        string ImageFormat)
            {
                BarcodeRow rowBarcodeRow = ((BarcodeRow)(this.NewRow()));
                object[] columnValuesArray = new object[] {
                        Type,
                        RawData,
                        EncodedValue,
                        EncodingTime,
                        IncludeLabel,
                        Forecolor,
                        Backcolor,
                        CountryAssigningManufacturingCode,
                        ImageWidth,
                        ImageHeight,
                        Image,
                        RotateFlipType,
                        LabelPosition,
                        Alignment,
                        LabelFont,
                        ImageFormat};
                rowBarcodeRow.ItemArray = columnValuesArray;
                this.Rows.Add(rowBarcodeRow);
                return rowBarcodeRow;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public virtual global::System.Collections.IEnumerator GetEnumerator()
            {
                return this.Rows.GetEnumerator();
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public override global::System.Data.DataTable Clone()
            {
                BarcodeDataTable cln = ((BarcodeDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override global::System.Data.DataTable CreateInstance()
            {
                return new BarcodeDataTable();
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal void InitVars()
            {
                this.columnType = base.Columns["Type"];
                this.columnRawData = base.Columns["RawData"];
                this.columnEncodedValue = base.Columns["EncodedValue"];
                this.columnEncodingTime = base.Columns["EncodingTime"];
                this.columnIncludeLabel = base.Columns["IncludeLabel"];
                this.columnForecolor = base.Columns["Forecolor"];
                this.columnBackcolor = base.Columns["Backcolor"];
                this.columnCountryAssigningManufacturingCode = base.Columns["CountryAssigningManufacturingCode"];
                this.columnImageWidth = base.Columns["ImageWidth"];
                this.columnImageHeight = base.Columns["ImageHeight"];
                this.columnImage = base.Columns["Image"];
                this.columnRotateFlipType = base.Columns["RotateFlipType"];
                this.columnLabelPosition = base.Columns["LabelPosition"];
                this.columnAlignment = base.Columns["Alignment"];
                this.columnLabelFont = base.Columns["LabelFont"];
                this.columnImageFormat = base.Columns["ImageFormat"];
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void InitClass()
            {
                this.columnType = new global::System.Data.DataColumn("Type", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnType);
                this.columnRawData = new global::System.Data.DataColumn("RawData", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnRawData);
                this.columnEncodedValue = new global::System.Data.DataColumn("EncodedValue", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnEncodedValue);
                this.columnEncodingTime = new global::System.Data.DataColumn("EncodingTime", typeof(double), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnEncodingTime);
                this.columnIncludeLabel = new global::System.Data.DataColumn("IncludeLabel", typeof(bool), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnIncludeLabel);
                this.columnForecolor = new global::System.Data.DataColumn("Forecolor", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnForecolor);
                this.columnBackcolor = new global::System.Data.DataColumn("Backcolor", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnBackcolor);
                this.columnCountryAssigningManufacturingCode = new global::System.Data.DataColumn("CountryAssigningManufacturingCode", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnCountryAssigningManufacturingCode);
                this.columnImageWidth = new global::System.Data.DataColumn("ImageWidth", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnImageWidth);
                this.columnImageHeight = new global::System.Data.DataColumn("ImageHeight", typeof(int), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnImageHeight);
                this.columnImage = new global::System.Data.DataColumn("Image", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnImage);
                this.columnRotateFlipType = new global::System.Data.DataColumn("RotateFlipType", typeof(global::System.Drawing.RotateFlipType), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnRotateFlipType);
                this.columnLabelPosition = new global::System.Data.DataColumn("LabelPosition", typeof(global::Cnas.wns.CnasBarcodeLib.LabelPositions), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnLabelPosition);
                this.columnAlignment = new global::System.Data.DataColumn("Alignment", typeof(global::Cnas.wns.CnasBarcodeLib.AlignmentPositions), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnAlignment);
                this.columnLabelFont = new global::System.Data.DataColumn("LabelFont", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnLabelFont);
                this.columnImageFormat = new global::System.Data.DataColumn("ImageFormat", typeof(string), null, global::System.Data.MappingType.Element);
                base.Columns.Add(this.columnImageFormat);
                this.columnImage.MaxLength = 10000000;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public BarcodeRow NewBarcodeRow()
            {
                return ((BarcodeRow)(this.NewRow()));
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override global::System.Data.DataRow NewRowFromBuilder(global::System.Data.DataRowBuilder builder)
            {
                return new BarcodeRow(builder);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override global::System.Type GetRowType()
            {
                return typeof(BarcodeRow);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanged(global::System.Data.DataRowChangeEventArgs e)
            {
                base.OnRowChanged(e);
                if ((this.BarcodeRowChanged != null))
                {
                    this.BarcodeRowChanged(this, new BarcodeRowChangeEvent(((BarcodeRow)(e.Row)), e.Action));
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanging(global::System.Data.DataRowChangeEventArgs e)
            {
                base.OnRowChanging(e);
                if ((this.BarcodeRowChanging != null))
                {
                    this.BarcodeRowChanging(this, new BarcodeRowChangeEvent(((BarcodeRow)(e.Row)), e.Action));
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleted(global::System.Data.DataRowChangeEventArgs e)
            {
                base.OnRowDeleted(e);
                if ((this.BarcodeRowDeleted != null))
                {
                    this.BarcodeRowDeleted(this, new BarcodeRowChangeEvent(((BarcodeRow)(e.Row)), e.Action));
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleting(global::System.Data.DataRowChangeEventArgs e)
            {
                base.OnRowDeleting(e);
                if ((this.BarcodeRowDeleting != null))
                {
                    this.BarcodeRowDeleting(this, new BarcodeRowChangeEvent(((BarcodeRow)(e.Row)), e.Action));
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void RemoveBarcodeRow(BarcodeRow row)
            {
                this.Rows.Remove(row);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public static global::System.Xml.Schema.XmlSchemaComplexType GetTypedTableSchema(global::System.Xml.Schema.XmlSchemaSet xs)
            {
                global::System.Xml.Schema.XmlSchemaComplexType type = new global::System.Xml.Schema.XmlSchemaComplexType();
                global::System.Xml.Schema.XmlSchemaSequence sequence = new global::System.Xml.Schema.XmlSchemaSequence();
                BarcodeXML ds = new BarcodeXML();
                global::System.Xml.Schema.XmlSchemaAny any1 = new global::System.Xml.Schema.XmlSchemaAny();
                any1.Namespace = "http://www.w3.org/2001/XMLSchema";
                any1.MinOccurs = new decimal(0);
                any1.MaxOccurs = decimal.MaxValue;
                any1.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any1);
                global::System.Xml.Schema.XmlSchemaAny any2 = new global::System.Xml.Schema.XmlSchemaAny();
                any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
                any2.MinOccurs = new decimal(1);
                any2.ProcessContents = global::System.Xml.Schema.XmlSchemaContentProcessing.Lax;
                sequence.Items.Add(any2);
                global::System.Xml.Schema.XmlSchemaAttribute attribute1 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute1.Name = "namespace";
                attribute1.FixedValue = ds.Namespace;
                type.Attributes.Add(attribute1);
                global::System.Xml.Schema.XmlSchemaAttribute attribute2 = new global::System.Xml.Schema.XmlSchemaAttribute();
                attribute2.Name = "tableTypeName";
                attribute2.FixedValue = "BarcodeDataTable";
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                global::System.Xml.Schema.XmlSchema dsSchema = ds.GetSchemaSerializable();
                if (xs.Contains(dsSchema.TargetNamespace))
                {
                    global::System.IO.MemoryStream s1 = new global::System.IO.MemoryStream();
                    global::System.IO.MemoryStream s2 = new global::System.IO.MemoryStream();
                    try
                    {
                        global::System.Xml.Schema.XmlSchema schema = null;
                        dsSchema.Write(s1);
                        for (global::System.Collections.IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator(); schemas.MoveNext(); )
                        {
                            schema = ((global::System.Xml.Schema.XmlSchema)(schemas.Current));
                            s2.SetLength(0);
                            schema.Write(s2);
                            if ((s1.Length == s2.Length))
                            {
                                s1.Position = 0;
                                s2.Position = 0;
                                for (; ((s1.Position != s1.Length)
                                            && (s1.ReadByte() == s2.ReadByte())); )
                                {
                                    ;
                                }
                                if ((s1.Position == s1.Length))
                                {
                                    return type;
                                }
                            }
                        }
                    }
                    finally
                    {
                        if ((s1 != null))
                        {
                            s1.Close();
                        }
                        if ((s2 != null))
                        {
                            s2.Close();
                        }
                    }
                }
                xs.Add(dsSchema);
                return type;
            }
        }

        /// <summary>
        ///Represents strongly named DataRow class.
        ///</summary>
        public partial class BarcodeRow : global::System.Data.DataRow
        {

            private BarcodeDataTable tableBarcode;

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal BarcodeRow(global::System.Data.DataRowBuilder rb) :
                base(rb)
            {
                this.tableBarcode = ((BarcodeDataTable)(this.Table));
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string Type
            {
                get
                {
                    try
                    {
                        return ((string)(this[this.tableBarcode.TypeColumn]));
                    }
                    catch (global::System.InvalidCastException e)
                    {
                        throw new global::System.Data.StrongTypingException("The value for column \'Type\' in table \'Barcode\' is DBNull.", e);
                    }
                }
                set
                {
                    this[this.tableBarcode.TypeColumn] = value;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string RawData
            {
                get
                {
                    try
                    {
                        return ((string)(this[this.tableBarcode.RawDataColumn]));
                    }
                    catch (global::System.InvalidCastException e)
                    {
                        throw new global::System.Data.StrongTypingException("The value for column \'RawData\' in table \'Barcode\' is DBNull.", e);
                    }
                }
                set
                {
                    this[this.tableBarcode.RawDataColumn] = value;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string EncodedValue
            {
                get
                {
                    try
                    {
                        return ((string)(this[this.tableBarcode.EncodedValueColumn]));
                    }
                    catch (global::System.InvalidCastException e)
                    {
                        throw new global::System.Data.StrongTypingException("The value for column \'EncodedValue\' in table \'Barcode\' is DBNull.", e);
                    }
                }
                set
                {
                    this[this.tableBarcode.EncodedValueColumn] = value;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public double EncodingTime
            {
                get
                {
                    try
                    {
                        return ((double)(this[this.tableBarcode.EncodingTimeColumn]));
                    }
                    catch (global::System.InvalidCastException e)
                    {
                        throw new global::System.Data.StrongTypingException("The value for column \'EncodingTime\' in table \'Barcode\' is DBNull.", e);
                    }
                }
                set
                {
                    this[this.tableBarcode.EncodingTimeColumn] = value;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IncludeLabel
            {
                get
                {
                    try
                    {
                        return ((bool)(this[this.tableBarcode.IncludeLabelColumn]));
                    }
                    catch (global::System.InvalidCastException e)
                    {
                        throw new global::System.Data.StrongTypingException("The value for column \'IncludeLabel\' in table \'Barcode\' is DBNull.", e);
                    }
                }
                set
                {
                    this[this.tableBarcode.IncludeLabelColumn] = value;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string Forecolor
            {
                get
                {
                    try
                    {
                        return ((string)(this[this.tableBarcode.ForecolorColumn]));
                    }
                    catch (global::System.InvalidCastException e)
                    {
                        throw new global::System.Data.StrongTypingException("The value for column \'Forecolor\' in table \'Barcode\' is DBNull.", e);
                    }
                }
                set
                {
                    this[this.tableBarcode.ForecolorColumn] = value;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string Backcolor
            {
                get
                {
                    try
                    {
                        return ((string)(this[this.tableBarcode.BackcolorColumn]));
                    }
                    catch (global::System.InvalidCastException e)
                    {
                        throw new global::System.Data.StrongTypingException("The value for column \'Backcolor\' in table \'Barcode\' is DBNull.", e);
                    }
                }
                set
                {
                    this[this.tableBarcode.BackcolorColumn] = value;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string CountryAssigningManufacturingCode
            {
                get
                {
                    try
                    {
                        return ((string)(this[this.tableBarcode.CountryAssigningManufacturingCodeColumn]));
                    }
                    catch (global::System.InvalidCastException e)
                    {
                        throw new global::System.Data.StrongTypingException("The value for column \'CountryAssigningManufacturingCode\' in table \'Barcode\' is DB" +
                                "Null.", e);
                    }
                }
                set
                {
                    this[this.tableBarcode.CountryAssigningManufacturingCodeColumn] = value;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int ImageWidth
            {
                get
                {
                    try
                    {
                        return ((int)(this[this.tableBarcode.ImageWidthColumn]));
                    }
                    catch (global::System.InvalidCastException e)
                    {
                        throw new global::System.Data.StrongTypingException("The value for column \'ImageWidth\' in table \'Barcode\' is DBNull.", e);
                    }
                }
                set
                {
                    this[this.tableBarcode.ImageWidthColumn] = value;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int ImageHeight
            {
                get
                {
                    try
                    {
                        return ((int)(this[this.tableBarcode.ImageHeightColumn]));
                    }
                    catch (global::System.InvalidCastException e)
                    {
                        throw new global::System.Data.StrongTypingException("The value for column \'ImageHeight\' in table \'Barcode\' is DBNull.", e);
                    }
                }
                set
                {
                    this[this.tableBarcode.ImageHeightColumn] = value;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string Image
            {
                get
                {
                    try
                    {
                        return ((string)(this[this.tableBarcode.ImageColumn]));
                    }
                    catch (global::System.InvalidCastException e)
                    {
                        throw new global::System.Data.StrongTypingException("The value for column \'Image\' in table \'Barcode\' is DBNull.", e);
                    }
                }
                set
                {
                    this[this.tableBarcode.ImageColumn] = value;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public System.Drawing.RotateFlipType RotateFlipType
            {
                get
                {
                    try
                    {
                        return ((global::System.Drawing.RotateFlipType)(this[this.tableBarcode.RotateFlipTypeColumn]));
                    }
                    catch (global::System.InvalidCastException e)
                    {
                        throw new global::System.Data.StrongTypingException("The value for column \'RotateFlipType\' in table \'Barcode\' is DBNull.", e);
                    }
                }
                set
                {
                    this[this.tableBarcode.RotateFlipTypeColumn] = value;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public Cnas.wns.CnasBarcodeLib.LabelPositions LabelPosition
            {
                get
                {
                    try
                    {
                        return ((global::Cnas.wns.CnasBarcodeLib.LabelPositions)(this[this.tableBarcode.LabelPositionColumn]));
                    }
                    catch (global::System.InvalidCastException e)
                    {
                        throw new global::System.Data.StrongTypingException("The value for column \'LabelPosition\' in table \'Barcode\' is DBNull.", e);
                    }
                }
                set
                {
                    this[this.tableBarcode.LabelPositionColumn] = value;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public Cnas.wns.CnasBarcodeLib.AlignmentPositions Alignment
            {
                get
                {
                    try
                    {
                        return ((global::Cnas.wns.CnasBarcodeLib.AlignmentPositions)(this[this.tableBarcode.AlignmentColumn]));
                    }
                    catch (global::System.InvalidCastException e)
                    {
                        throw new global::System.Data.StrongTypingException("The value for column \'Alignment\' in table \'Barcode\' is DBNull.", e);
                    }
                }
                set
                {
                    this[this.tableBarcode.AlignmentColumn] = value;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string LabelFont
            {
                get
                {
                    try
                    {
                        return ((string)(this[this.tableBarcode.LabelFontColumn]));
                    }
                    catch (global::System.InvalidCastException e)
                    {
                        throw new global::System.Data.StrongTypingException("The value for column \'LabelFont\' in table \'Barcode\' is DBNull.", e);
                    }
                }
                set
                {
                    this[this.tableBarcode.LabelFontColumn] = value;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string ImageFormat
            {
                get
                {
                    try
                    {
                        return ((string)(this[this.tableBarcode.ImageFormatColumn]));
                    }
                    catch (global::System.InvalidCastException e)
                    {
                        throw new global::System.Data.StrongTypingException("The value for column \'ImageFormat\' in table \'Barcode\' is DBNull.", e);
                    }
                }
                set
                {
                    this[this.tableBarcode.ImageFormatColumn] = value;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsTypeNull()
            {
                return this.IsNull(this.tableBarcode.TypeColumn);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetTypeNull()
            {
                this[this.tableBarcode.TypeColumn] = global::System.Convert.DBNull;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsRawDataNull()
            {
                return this.IsNull(this.tableBarcode.RawDataColumn);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetRawDataNull()
            {
                this[this.tableBarcode.RawDataColumn] = global::System.Convert.DBNull;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsEncodedValueNull()
            {
                return this.IsNull(this.tableBarcode.EncodedValueColumn);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetEncodedValueNull()
            {
                this[this.tableBarcode.EncodedValueColumn] = global::System.Convert.DBNull;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsEncodingTimeNull()
            {
                return this.IsNull(this.tableBarcode.EncodingTimeColumn);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetEncodingTimeNull()
            {
                this[this.tableBarcode.EncodingTimeColumn] = global::System.Convert.DBNull;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsIncludeLabelNull()
            {
                return this.IsNull(this.tableBarcode.IncludeLabelColumn);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetIncludeLabelNull()
            {
                this[this.tableBarcode.IncludeLabelColumn] = global::System.Convert.DBNull;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsForecolorNull()
            {
                return this.IsNull(this.tableBarcode.ForecolorColumn);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetForecolorNull()
            {
                this[this.tableBarcode.ForecolorColumn] = global::System.Convert.DBNull;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsBackcolorNull()
            {
                return this.IsNull(this.tableBarcode.BackcolorColumn);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetBackcolorNull()
            {
                this[this.tableBarcode.BackcolorColumn] = global::System.Convert.DBNull;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsCountryAssigningManufacturingCodeNull()
            {
                return this.IsNull(this.tableBarcode.CountryAssigningManufacturingCodeColumn);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetCountryAssigningManufacturingCodeNull()
            {
                this[this.tableBarcode.CountryAssigningManufacturingCodeColumn] = global::System.Convert.DBNull;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsImageWidthNull()
            {
                return this.IsNull(this.tableBarcode.ImageWidthColumn);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetImageWidthNull()
            {
                this[this.tableBarcode.ImageWidthColumn] = global::System.Convert.DBNull;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsImageHeightNull()
            {
                return this.IsNull(this.tableBarcode.ImageHeightColumn);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetImageHeightNull()
            {
                this[this.tableBarcode.ImageHeightColumn] = global::System.Convert.DBNull;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsImageNull()
            {
                return this.IsNull(this.tableBarcode.ImageColumn);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetImageNull()
            {
                this[this.tableBarcode.ImageColumn] = global::System.Convert.DBNull;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsRotateFlipTypeNull()
            {
                return this.IsNull(this.tableBarcode.RotateFlipTypeColumn);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetRotateFlipTypeNull()
            {
                this[this.tableBarcode.RotateFlipTypeColumn] = global::System.Convert.DBNull;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsLabelPositionNull()
            {
                return this.IsNull(this.tableBarcode.LabelPositionColumn);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetLabelPositionNull()
            {
                this[this.tableBarcode.LabelPositionColumn] = global::System.Convert.DBNull;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsAlignmentNull()
            {
                return this.IsNull(this.tableBarcode.AlignmentColumn);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetAlignmentNull()
            {
                this[this.tableBarcode.AlignmentColumn] = global::System.Convert.DBNull;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsLabelFontNull()
            {
                return this.IsNull(this.tableBarcode.LabelFontColumn);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetLabelFontNull()
            {
                this[this.tableBarcode.LabelFontColumn] = global::System.Convert.DBNull;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsImageFormatNull()
            {
                return this.IsNull(this.tableBarcode.ImageFormatColumn);
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetImageFormatNull()
            {
                this[this.tableBarcode.ImageFormatColumn] = global::System.Convert.DBNull;
            }
        }

        /// <summary>
        ///Row event argument class
        ///</summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class BarcodeRowChangeEvent : global::System.EventArgs
        {

            private BarcodeRow eventRow;

            private global::System.Data.DataRowAction eventAction;

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public BarcodeRowChangeEvent(BarcodeRow row, global::System.Data.DataRowAction action)
            {
                this.eventRow = row;
                this.eventAction = action;
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public BarcodeRow Row
            {
                get
                {
                    return this.eventRow;
                }
            }

            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public global::System.Data.DataRowAction Action
            {
                get
                {
                    return this.eventAction;
                }
            }
        }
    }
}
