namespace RESTwinoef001
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label aRT_CODELabel;
            System.Windows.Forms.Label beginBloeiMaandLabel;
            System.Windows.Forms.Label bLOEIBEGINLabel;
            System.Windows.Forms.Label bLOEIEINDELabel;
            System.Windows.Forms.Label eindBloeiMaandLabel;
            System.Windows.Forms.Label hOOGTELabel;
            System.Windows.Forms.Label kLEURLabel;
            System.Windows.Forms.Label pLANTENNAAMLabel;
            System.Windows.Forms.Label pRIJSLabel;
            System.Windows.Forms.Label sOORTLabel;
            this.plantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.plantComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.mijnPlantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aRT_CODETextBox = new System.Windows.Forms.TextBox();
            this.beginBloeiMaandTextBox = new System.Windows.Forms.TextBox();
            this.bLOEIBEGINTextBox = new System.Windows.Forms.TextBox();
            this.bLOEIEINDETextBox = new System.Windows.Forms.TextBox();
            this.eindBloeiMaandTextBox = new System.Windows.Forms.TextBox();
            this.hOOGTETextBox = new System.Windows.Forms.TextBox();
            this.kLEURTextBox = new System.Windows.Forms.TextBox();
            this.pLANTENNAAMTextBox = new System.Windows.Forms.TextBox();
            this.pRIJSTextBox = new System.Windows.Forms.TextBox();
            this.sOORTTextBox = new System.Windows.Forms.TextBox();
            aRT_CODELabel = new System.Windows.Forms.Label();
            beginBloeiMaandLabel = new System.Windows.Forms.Label();
            bLOEIBEGINLabel = new System.Windows.Forms.Label();
            bLOEIEINDELabel = new System.Windows.Forms.Label();
            eindBloeiMaandLabel = new System.Windows.Forms.Label();
            hOOGTELabel = new System.Windows.Forms.Label();
            kLEURLabel = new System.Windows.Forms.Label();
            pLANTENNAAMLabel = new System.Windows.Forms.Label();
            pRIJSLabel = new System.Windows.Forms.Label();
            sOORTLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.plantBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mijnPlantBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // plantBindingSource
            // 
            this.plantBindingSource.DataSource = typeof(RESTapioef001.Models.Plant);
            // 
            // plantComboBox
            // 
            this.plantComboBox.DataSource = this.plantBindingSource;
            this.plantComboBox.DisplayMember = "Plantennaam";
            this.plantComboBox.FormattingEnabled = true;
            this.plantComboBox.Location = new System.Drawing.Point(1, 33);
            this.plantComboBox.Name = "plantComboBox";
            this.plantComboBox.Size = new System.Drawing.Size(211, 21);
            this.plantComboBox.TabIndex = 1;
            this.plantComboBox.ValueMember = "Art_Code";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(233, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mijnPlantBindingSource
            // 
            this.mijnPlantBindingSource.DataSource = typeof(RESTwinoef001.MijnPlant);
            // 
            // aRT_CODELabel
            // 
            aRT_CODELabel.AutoSize = true;
            aRT_CODELabel.Location = new System.Drawing.Point(42, 94);
            aRT_CODELabel.Name = "aRT_CODELabel";
            aRT_CODELabel.Size = new System.Drawing.Size(65, 13);
            aRT_CODELabel.TabIndex = 17;
            aRT_CODELabel.Text = "ART CODE:";
            // 
            // aRT_CODETextBox
            // 
            this.aRT_CODETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mijnPlantBindingSource, "ART_CODE", true));
            this.aRT_CODETextBox.Location = new System.Drawing.Point(147, 91);
            this.aRT_CODETextBox.Name = "aRT_CODETextBox";
            this.aRT_CODETextBox.Size = new System.Drawing.Size(100, 20);
            this.aRT_CODETextBox.TabIndex = 18;
            // 
            // beginBloeiMaandLabel
            // 
            beginBloeiMaandLabel.AutoSize = true;
            beginBloeiMaandLabel.Location = new System.Drawing.Point(42, 120);
            beginBloeiMaandLabel.Name = "beginBloeiMaandLabel";
            beginBloeiMaandLabel.Size = new System.Drawing.Size(99, 13);
            beginBloeiMaandLabel.TabIndex = 19;
            beginBloeiMaandLabel.Text = "Begin Bloei Maand:";
            // 
            // beginBloeiMaandTextBox
            // 
            this.beginBloeiMaandTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mijnPlantBindingSource, "BeginBloeiMaand", true));
            this.beginBloeiMaandTextBox.Location = new System.Drawing.Point(147, 117);
            this.beginBloeiMaandTextBox.Name = "beginBloeiMaandTextBox";
            this.beginBloeiMaandTextBox.Size = new System.Drawing.Size(100, 20);
            this.beginBloeiMaandTextBox.TabIndex = 20;
            // 
            // bLOEIBEGINLabel
            // 
            bLOEIBEGINLabel.AutoSize = true;
            bLOEIBEGINLabel.Location = new System.Drawing.Point(42, 146);
            bLOEIBEGINLabel.Name = "bLOEIBEGINLabel";
            bLOEIBEGINLabel.Size = new System.Drawing.Size(74, 13);
            bLOEIBEGINLabel.TabIndex = 21;
            bLOEIBEGINLabel.Text = "BLOEIBEGIN:";
            // 
            // bLOEIBEGINTextBox
            // 
            this.bLOEIBEGINTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mijnPlantBindingSource, "BLOEIBEGIN", true));
            this.bLOEIBEGINTextBox.Location = new System.Drawing.Point(147, 143);
            this.bLOEIBEGINTextBox.Name = "bLOEIBEGINTextBox";
            this.bLOEIBEGINTextBox.Size = new System.Drawing.Size(100, 20);
            this.bLOEIBEGINTextBox.TabIndex = 22;
            // 
            // bLOEIEINDELabel
            // 
            bLOEIEINDELabel.AutoSize = true;
            bLOEIEINDELabel.Location = new System.Drawing.Point(42, 172);
            bLOEIEINDELabel.Name = "bLOEIEINDELabel";
            bLOEIEINDELabel.Size = new System.Drawing.Size(74, 13);
            bLOEIEINDELabel.TabIndex = 23;
            bLOEIEINDELabel.Text = "BLOEIEINDE:";
            // 
            // bLOEIEINDETextBox
            // 
            this.bLOEIEINDETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mijnPlantBindingSource, "BLOEIEINDE", true));
            this.bLOEIEINDETextBox.Location = new System.Drawing.Point(147, 169);
            this.bLOEIEINDETextBox.Name = "bLOEIEINDETextBox";
            this.bLOEIEINDETextBox.Size = new System.Drawing.Size(100, 20);
            this.bLOEIEINDETextBox.TabIndex = 24;
            // 
            // eindBloeiMaandLabel
            // 
            eindBloeiMaandLabel.AutoSize = true;
            eindBloeiMaandLabel.Location = new System.Drawing.Point(42, 198);
            eindBloeiMaandLabel.Name = "eindBloeiMaandLabel";
            eindBloeiMaandLabel.Size = new System.Drawing.Size(93, 13);
            eindBloeiMaandLabel.TabIndex = 25;
            eindBloeiMaandLabel.Text = "Eind Bloei Maand:";
            // 
            // eindBloeiMaandTextBox
            // 
            this.eindBloeiMaandTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mijnPlantBindingSource, "EindBloeiMaand", true));
            this.eindBloeiMaandTextBox.Location = new System.Drawing.Point(147, 195);
            this.eindBloeiMaandTextBox.Name = "eindBloeiMaandTextBox";
            this.eindBloeiMaandTextBox.Size = new System.Drawing.Size(100, 20);
            this.eindBloeiMaandTextBox.TabIndex = 26;
            // 
            // hOOGTELabel
            // 
            hOOGTELabel.AutoSize = true;
            hOOGTELabel.Location = new System.Drawing.Point(42, 224);
            hOOGTELabel.Name = "hOOGTELabel";
            hOOGTELabel.Size = new System.Drawing.Size(56, 13);
            hOOGTELabel.TabIndex = 27;
            hOOGTELabel.Text = "HOOGTE:";
            // 
            // hOOGTETextBox
            // 
            this.hOOGTETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mijnPlantBindingSource, "HOOGTE", true));
            this.hOOGTETextBox.Location = new System.Drawing.Point(147, 221);
            this.hOOGTETextBox.Name = "hOOGTETextBox";
            this.hOOGTETextBox.Size = new System.Drawing.Size(100, 20);
            this.hOOGTETextBox.TabIndex = 28;
            // 
            // kLEURLabel
            // 
            kLEURLabel.AutoSize = true;
            kLEURLabel.Location = new System.Drawing.Point(42, 250);
            kLEURLabel.Name = "kLEURLabel";
            kLEURLabel.Size = new System.Drawing.Size(46, 13);
            kLEURLabel.TabIndex = 29;
            kLEURLabel.Text = "KLEUR:";
            // 
            // kLEURTextBox
            // 
            this.kLEURTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mijnPlantBindingSource, "KLEUR", true));
            this.kLEURTextBox.Location = new System.Drawing.Point(147, 247);
            this.kLEURTextBox.Name = "kLEURTextBox";
            this.kLEURTextBox.Size = new System.Drawing.Size(100, 20);
            this.kLEURTextBox.TabIndex = 30;
            // 
            // pLANTENNAAMLabel
            // 
            pLANTENNAAMLabel.AutoSize = true;
            pLANTENNAAMLabel.Location = new System.Drawing.Point(42, 276);
            pLANTENNAAMLabel.Name = "pLANTENNAAMLabel";
            pLANTENNAAMLabel.Size = new System.Drawing.Size(91, 13);
            pLANTENNAAMLabel.TabIndex = 31;
            pLANTENNAAMLabel.Text = "PLANTENNAAM:";
            // 
            // pLANTENNAAMTextBox
            // 
            this.pLANTENNAAMTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mijnPlantBindingSource, "PLANTENNAAM", true));
            this.pLANTENNAAMTextBox.Location = new System.Drawing.Point(147, 273);
            this.pLANTENNAAMTextBox.Name = "pLANTENNAAMTextBox";
            this.pLANTENNAAMTextBox.Size = new System.Drawing.Size(100, 20);
            this.pLANTENNAAMTextBox.TabIndex = 32;
            // 
            // pRIJSLabel
            // 
            pRIJSLabel.AutoSize = true;
            pRIJSLabel.Location = new System.Drawing.Point(42, 302);
            pRIJSLabel.Name = "pRIJSLabel";
            pRIJSLabel.Size = new System.Drawing.Size(40, 13);
            pRIJSLabel.TabIndex = 33;
            pRIJSLabel.Text = "PRIJS:";
            // 
            // pRIJSTextBox
            // 
            this.pRIJSTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mijnPlantBindingSource, "PRIJS", true));
            this.pRIJSTextBox.Location = new System.Drawing.Point(147, 299);
            this.pRIJSTextBox.Name = "pRIJSTextBox";
            this.pRIJSTextBox.Size = new System.Drawing.Size(100, 20);
            this.pRIJSTextBox.TabIndex = 34;
            // 
            // sOORTLabel
            // 
            sOORTLabel.AutoSize = true;
            sOORTLabel.Location = new System.Drawing.Point(42, 328);
            sOORTLabel.Name = "sOORTLabel";
            sOORTLabel.Size = new System.Drawing.Size(48, 13);
            sOORTLabel.TabIndex = 35;
            sOORTLabel.Text = "SOORT:";
            // 
            // sOORTTextBox
            // 
            this.sOORTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mijnPlantBindingSource, "SOORT", true));
            this.sOORTTextBox.Location = new System.Drawing.Point(147, 325);
            this.sOORTTextBox.Name = "sOORTTextBox";
            this.sOORTTextBox.Size = new System.Drawing.Size(100, 20);
            this.sOORTTextBox.TabIndex = 36;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 365);
            this.Controls.Add(aRT_CODELabel);
            this.Controls.Add(this.aRT_CODETextBox);
            this.Controls.Add(beginBloeiMaandLabel);
            this.Controls.Add(this.beginBloeiMaandTextBox);
            this.Controls.Add(bLOEIBEGINLabel);
            this.Controls.Add(this.bLOEIBEGINTextBox);
            this.Controls.Add(bLOEIEINDELabel);
            this.Controls.Add(this.bLOEIEINDETextBox);
            this.Controls.Add(eindBloeiMaandLabel);
            this.Controls.Add(this.eindBloeiMaandTextBox);
            this.Controls.Add(hOOGTELabel);
            this.Controls.Add(this.hOOGTETextBox);
            this.Controls.Add(kLEURLabel);
            this.Controls.Add(this.kLEURTextBox);
            this.Controls.Add(pLANTENNAAMLabel);
            this.Controls.Add(this.pLANTENNAAMTextBox);
            this.Controls.Add(pRIJSLabel);
            this.Controls.Add(this.pRIJSTextBox);
            this.Controls.Add(sOORTLabel);
            this.Controls.Add(this.sOORTTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.plantComboBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.plantBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mijnPlantBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource plantBindingSource;
        private System.Windows.Forms.ComboBox plantComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource mijnPlantBindingSource;
        private System.Windows.Forms.TextBox aRT_CODETextBox;
        private System.Windows.Forms.TextBox beginBloeiMaandTextBox;
        private System.Windows.Forms.TextBox bLOEIBEGINTextBox;
        private System.Windows.Forms.TextBox bLOEIEINDETextBox;
        private System.Windows.Forms.TextBox eindBloeiMaandTextBox;
        private System.Windows.Forms.TextBox hOOGTETextBox;
        private System.Windows.Forms.TextBox kLEURTextBox;
        private System.Windows.Forms.TextBox pLANTENNAAMTextBox;
        private System.Windows.Forms.TextBox pRIJSTextBox;
        private System.Windows.Forms.TextBox sOORTTextBox;
    }
}

