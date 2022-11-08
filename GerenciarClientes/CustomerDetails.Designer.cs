
namespace GerenciarClientes
{
    partial class CustomerDetails
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
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.helperLbl = new MetroFramework.Controls.MetroLabel();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.CVisityHistoryListView = new MetroFramework.Controls.MetroListView();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.CCPFTxt = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.CPhoneTxt = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.CNumVisitsTxt = new MaterialSkin.Controls.MaterialTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.CDescTxt = new MaterialSkin.Controls.MaterialTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.CNameTxt = new MaterialSkin.Controls.MaterialTextBox();
            this.materialButton3 = new MaterialSkin.Controls.MaterialButton();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.CPublishDateLbl = new MetroFramework.Controls.MetroLabel();
            this.CPublishDateTxt = new MaterialSkin.Controls.MaterialTextBox();
            this.SuspendLayout();
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(701, 517);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(76, 36);
            this.materialButton2.TabIndex = 44;
            this.materialButton2.Text = "Salvar";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // helperLbl
            // 
            this.helperLbl.AutoSize = true;
            this.helperLbl.ForeColor = System.Drawing.Color.DarkRed;
            this.helperLbl.Location = new System.Drawing.Point(508, 228);
            this.helperLbl.Name = "helperLbl";
            this.helperLbl.Size = new System.Drawing.Size(0, 0);
            this.helperLbl.TabIndex = 43;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(678, 234);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(98, 36);
            this.materialButton1.TabIndex = 42;
            this.materialButton1.Text = "Adicionar";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(508, 283);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(116, 19);
            this.metroLabel8.TabIndex = 41;
            this.metroLabel8.Text = "Histórico de visitas";
            // 
            // CVisityHistoryListView
            // 
            this.CVisityHistoryListView.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.CVisityHistoryListView.FullRowSelect = true;
            this.CVisityHistoryListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.CVisityHistoryListView.Location = new System.Drawing.Point(508, 305);
            this.CVisityHistoryListView.Name = "CVisityHistoryListView";
            this.CVisityHistoryListView.OwnerDraw = true;
            this.CVisityHistoryListView.Size = new System.Drawing.Size(269, 203);
            this.CVisityHistoryListView.TabIndex = 40;
            this.CVisityHistoryListView.UseCompatibleStateImageBehavior = false;
            this.CVisityHistoryListView.UseSelectable = true;
            this.CVisityHistoryListView.View = System.Windows.Forms.View.List;
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.CustomFormat = "dd/MM/yyyy";
            this.metroDateTime1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.metroDateTime1.Location = new System.Drawing.Point(508, 196);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(269, 29);
            this.metroDateTime1.TabIndex = 39;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(508, 174);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(87, 19);
            this.metroLabel7.TabIndex = 38;
            this.metroLabel7.Text = "Data da visita";
            // 
            // CCPFTxt
            // 
            this.CCPFTxt.AllowPromptAsInput = true;
            this.CCPFTxt.AnimateReadOnly = false;
            this.CCPFTxt.AsciiOnly = false;
            this.CCPFTxt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CCPFTxt.BeepOnError = false;
            this.CCPFTxt.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.CCPFTxt.Depth = 0;
            this.CCPFTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.CCPFTxt.HidePromptOnLeave = false;
            this.CCPFTxt.HideSelection = true;
            this.CCPFTxt.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.CCPFTxt.LeadingIcon = null;
            this.CCPFTxt.Location = new System.Drawing.Point(23, 196);
            this.CCPFTxt.Mask = "###.###.###-##";
            this.CCPFTxt.MaxLength = 32767;
            this.CCPFTxt.MouseState = MaterialSkin.MouseState.OUT;
            this.CCPFTxt.Name = "CCPFTxt";
            this.CCPFTxt.PasswordChar = '\0';
            this.CCPFTxt.PrefixSuffixText = null;
            this.CCPFTxt.PromptChar = '_';
            this.CCPFTxt.ReadOnly = false;
            this.CCPFTxt.RejectInputOnFirstFailure = false;
            this.CCPFTxt.ResetOnPrompt = true;
            this.CCPFTxt.ResetOnSpace = true;
            this.CCPFTxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CCPFTxt.SelectedText = "";
            this.CCPFTxt.SelectionLength = 0;
            this.CCPFTxt.SelectionStart = 0;
            this.CCPFTxt.ShortcutsEnabled = true;
            this.CCPFTxt.Size = new System.Drawing.Size(280, 48);
            this.CCPFTxt.SkipLiterals = true;
            this.CCPFTxt.TabIndex = 37;
            this.CCPFTxt.TabStop = false;
            this.CCPFTxt.Text = "   ,   ,   -";
            this.CCPFTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CCPFTxt.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.CCPFTxt.TrailingIcon = null;
            this.CCPFTxt.UseSystemPasswordChar = false;
            this.CCPFTxt.ValidatingType = null;
            // 
            // CPhoneTxt
            // 
            this.CPhoneTxt.AllowPromptAsInput = true;
            this.CPhoneTxt.AnimateReadOnly = false;
            this.CPhoneTxt.AsciiOnly = false;
            this.CPhoneTxt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CPhoneTxt.BeepOnError = false;
            this.CPhoneTxt.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.CPhoneTxt.Depth = 0;
            this.CPhoneTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.CPhoneTxt.HidePromptOnLeave = false;
            this.CPhoneTxt.HideSelection = true;
            this.CPhoneTxt.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.CPhoneTxt.LeadingIcon = null;
            this.CPhoneTxt.Location = new System.Drawing.Point(23, 290);
            this.CPhoneTxt.Mask = "(##)#####-####";
            this.CPhoneTxt.MaxLength = 32767;
            this.CPhoneTxt.MouseState = MaterialSkin.MouseState.OUT;
            this.CPhoneTxt.Name = "CPhoneTxt";
            this.CPhoneTxt.PasswordChar = '\0';
            this.CPhoneTxt.PrefixSuffixText = null;
            this.CPhoneTxt.PromptChar = '_';
            this.CPhoneTxt.ReadOnly = false;
            this.CPhoneTxt.RejectInputOnFirstFailure = false;
            this.CPhoneTxt.ResetOnPrompt = true;
            this.CPhoneTxt.ResetOnSpace = true;
            this.CPhoneTxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CPhoneTxt.SelectedText = "";
            this.CPhoneTxt.SelectionLength = 0;
            this.CPhoneTxt.SelectionStart = 0;
            this.CPhoneTxt.ShortcutsEnabled = true;
            this.CPhoneTxt.Size = new System.Drawing.Size(280, 48);
            this.CPhoneTxt.SkipLiterals = true;
            this.CPhoneTxt.TabIndex = 36;
            this.CPhoneTxt.TabStop = false;
            this.CPhoneTxt.Text = "(  )     -";
            this.CPhoneTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CPhoneTxt.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.CPhoneTxt.TrailingIcon = null;
            this.CPhoneTxt.UseSystemPasswordChar = false;
            this.CPhoneTxt.ValidatingType = null;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(23, 174);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(33, 19);
            this.metroLabel6.TabIndex = 35;
            this.metroLabel6.Text = "CPF";
            // 
            // materialDivider1
            // 
            this.materialDivider1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(402, 3);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(0, 782);
            this.materialDivider1.TabIndex = 32;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(508, 79);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(114, 19);
            this.metroLabel4.TabIndex = 31;
            this.metroLabel4.Text = "Número de visitas";
            // 
            // CNumVisitsTxt
            // 
            this.CNumVisitsTxt.AnimateReadOnly = false;
            this.CNumVisitsTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CNumVisitsTxt.Depth = 0;
            this.CNumVisitsTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CNumVisitsTxt.LeadingIcon = null;
            this.CNumVisitsTxt.Location = new System.Drawing.Point(508, 101);
            this.CNumVisitsTxt.MaxLength = 50;
            this.CNumVisitsTxt.MouseState = MaterialSkin.MouseState.OUT;
            this.CNumVisitsTxt.Multiline = false;
            this.CNumVisitsTxt.Name = "CNumVisitsTxt";
            this.CNumVisitsTxt.Size = new System.Drawing.Size(269, 50);
            this.CNumVisitsTxt.TabIndex = 30;
            this.CNumVisitsTxt.Text = "0";
            this.CNumVisitsTxt.TrailingIcon = null;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 362);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(65, 19);
            this.metroLabel3.TabIndex = 29;
            this.metroLabel3.Text = "Descrição";
            // 
            // CDescTxt
            // 
            this.CDescTxt.AnimateReadOnly = false;
            this.CDescTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CDescTxt.Depth = 0;
            this.CDescTxt.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.CDescTxt.LeadingIcon = null;
            this.CDescTxt.Location = new System.Drawing.Point(23, 384);
            this.CDescTxt.MaxLength = 50;
            this.CDescTxt.MouseState = MaterialSkin.MouseState.OUT;
            this.CDescTxt.Multiline = false;
            this.CDescTxt.Name = "CDescTxt";
            this.CDescTxt.Size = new System.Drawing.Size(280, 50);
            this.CDescTxt.TabIndex = 28;
            this.CDescTxt.Text = "";
            this.CDescTxt.TrailingIcon = null;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 268);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(57, 19);
            this.metroLabel2.TabIndex = 27;
            this.metroLabel2.Text = "Telefone";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 79);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(46, 19);
            this.metroLabel1.TabIndex = 26;
            this.metroLabel1.Text = "Nome";
            // 
            // CNameTxt
            // 
            this.CNameTxt.AnimateReadOnly = false;
            this.CNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CNameTxt.Depth = 0;
            this.CNameTxt.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.CNameTxt.LeadingIcon = null;
            this.CNameTxt.Location = new System.Drawing.Point(23, 101);
            this.CNameTxt.MaxLength = 50;
            this.CNameTxt.MouseState = MaterialSkin.MouseState.OUT;
            this.CNameTxt.Multiline = false;
            this.CNameTxt.Name = "CNameTxt";
            this.CNameTxt.Size = new System.Drawing.Size(280, 50);
            this.CNameTxt.TabIndex = 25;
            this.CNameTxt.Text = "";
            this.CNameTxt.TrailingIcon = null;
            // 
            // materialButton3
            // 
            this.materialButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton3.Depth = 0;
            this.materialButton3.HighEmphasis = true;
            this.materialButton3.Icon = null;
            this.materialButton3.Location = new System.Drawing.Point(597, 517);
            this.materialButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton3.Name = "materialButton3";
            this.materialButton3.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton3.Size = new System.Drawing.Size(96, 36);
            this.materialButton3.TabIndex = 45;
            this.materialButton3.Text = "Cancelar";
            this.materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton3.UseAccentColor = false;
            this.materialButton3.UseVisualStyleBackColor = true;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.ForeColor = System.Drawing.Color.DarkRed;
            this.metroLabel10.Location = new System.Drawing.Point(23, 502);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(0, 0);
            this.metroLabel10.TabIndex = 50;
            // 
            // CPublishDateLbl
            // 
            this.CPublishDateLbl.AutoSize = true;
            this.CPublishDateLbl.Location = new System.Drawing.Point(23, 448);
            this.CPublishDateLbl.Name = "CPublishDateLbl";
            this.CPublishDateLbl.Size = new System.Drawing.Size(109, 19);
            this.CPublishDateLbl.TabIndex = 48;
            this.CPublishDateLbl.Text = "Data de cadastro";
            // 
            // CPublishDateTxt
            // 
            this.CPublishDateTxt.AnimateReadOnly = false;
            this.CPublishDateTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CPublishDateTxt.Depth = 0;
            this.CPublishDateTxt.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.CPublishDateTxt.LeadingIcon = null;
            this.CPublishDateTxt.Location = new System.Drawing.Point(23, 467);
            this.CPublishDateTxt.MaxLength = 50;
            this.CPublishDateTxt.MouseState = MaterialSkin.MouseState.OUT;
            this.CPublishDateTxt.Multiline = false;
            this.CPublishDateTxt.Name = "CPublishDateTxt";
            this.CPublishDateTxt.ReadOnly = true;
            this.CPublishDateTxt.Size = new System.Drawing.Size(280, 50);
            this.CPublishDateTxt.TabIndex = 51;
            this.CPublishDateTxt.Text = "";
            this.CPublishDateTxt.TrailingIcon = null;
            // 
            // CustomerDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 572);
            this.Controls.Add(this.CPublishDateTxt);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.CPublishDateLbl);
            this.Controls.Add(this.materialButton3);
            this.Controls.Add(this.materialButton2);
            this.Controls.Add(this.helperLbl);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.CVisityHistoryListView);
            this.Controls.Add(this.metroDateTime1);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.CCPFTxt);
            this.Controls.Add(this.CPhoneTxt);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.CNumVisitsTxt);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.CDescTxt);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.CNameTxt);
            this.Name = "CustomerDetails";
            this.Text = "Detalhes do Cliente";
            this.Load += new System.EventHandler(this.CustomerDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MetroFramework.Controls.MetroLabel helperLbl;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroListView CVisityHistoryListView;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MaterialSkin.Controls.MaterialMaskedTextBox CCPFTxt;
        private MaterialSkin.Controls.MaterialMaskedTextBox CPhoneTxt;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MaterialSkin.Controls.MaterialTextBox CNumVisitsTxt;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MaterialSkin.Controls.MaterialTextBox CDescTxt;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MaterialSkin.Controls.MaterialTextBox CNameTxt;
        private MaterialSkin.Controls.MaterialButton materialButton3;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel CPublishDateLbl;
        private MaterialSkin.Controls.MaterialTextBox CPublishDateTxt;
    }
}