
namespace GerenciarClientes
{
    partial class NewCustomer
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
            this.CNameTxt = new MaterialSkin.Controls.MaterialTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.CDescTxt = new MaterialSkin.Controls.MaterialTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.CNumVisitsTxt = new MaterialSkin.Controls.MaterialTextBox();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.CPhoneTxt = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.CCPFTxt = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.CVisityHistoryListView = new MetroFramework.Controls.MetroListView();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.addVisitDateBtn = new MaterialSkin.Controls.MaterialButton();
            this.helperLbl = new MetroFramework.Controls.MetroLabel();
            this.RegisterCustomerBtn = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // CNameTxt
            // 
            this.CNameTxt.AnimateReadOnly = false;
            this.CNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CNameTxt.Depth = 0;
            this.CNameTxt.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.CNameTxt.LeadingIcon = null;
            this.CNameTxt.Location = new System.Drawing.Point(23, 93);
            this.CNameTxt.MaxLength = 50;
            this.CNameTxt.MouseState = MaterialSkin.MouseState.OUT;
            this.CNameTxt.Multiline = false;
            this.CNameTxt.Name = "CNameTxt";
            this.CNameTxt.Size = new System.Drawing.Size(280, 50);
            this.CNameTxt.TabIndex = 1;
            this.CNameTxt.Text = "";
            this.CNameTxt.TrailingIcon = null;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 71);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(46, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Nome";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 260);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(57, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Telefone";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 354);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(65, 19);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Descrição";
            // 
            // CDescTxt
            // 
            this.CDescTxt.AnimateReadOnly = false;
            this.CDescTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CDescTxt.Depth = 0;
            this.CDescTxt.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.CDescTxt.LeadingIcon = null;
            this.CDescTxt.Location = new System.Drawing.Point(23, 376);
            this.CDescTxt.MaxLength = 50;
            this.CDescTxt.MouseState = MaterialSkin.MouseState.OUT;
            this.CDescTxt.Multiline = false;
            this.CDescTxt.Name = "CDescTxt";
            this.CDescTxt.Size = new System.Drawing.Size(280, 50);
            this.CDescTxt.TabIndex = 4;
            this.CDescTxt.Text = "";
            this.CDescTxt.TrailingIcon = null;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(508, 71);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(114, 19);
            this.metroLabel4.TabIndex = 8;
            this.metroLabel4.Text = "Número de visitas";
            // 
            // CNumVisitsTxt
            // 
            this.CNumVisitsTxt.AnimateReadOnly = false;
            this.CNumVisitsTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CNumVisitsTxt.Depth = 0;
            this.CNumVisitsTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CNumVisitsTxt.LeadingIcon = null;
            this.CNumVisitsTxt.Location = new System.Drawing.Point(508, 93);
            this.CNumVisitsTxt.MaxLength = 50;
            this.CNumVisitsTxt.MouseState = MaterialSkin.MouseState.OUT;
            this.CNumVisitsTxt.Multiline = false;
            this.CNumVisitsTxt.Name = "CNumVisitsTxt";
            this.CNumVisitsTxt.Size = new System.Drawing.Size(269, 50);
            this.CNumVisitsTxt.TabIndex = 6;
            this.CNumVisitsTxt.Text = "0";
            this.CNumVisitsTxt.TrailingIcon = null;
            this.CNumVisitsTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.materialTextBox4_KeyPress);
            // 
            // materialDivider1
            // 
            this.materialDivider1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(402, -5);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(10, 559);
            this.materialDivider1.TabIndex = 9;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(23, 166);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(33, 19);
            this.metroLabel6.TabIndex = 13;
            this.metroLabel6.Text = "CPF";
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
            this.CPhoneTxt.Location = new System.Drawing.Point(23, 282);
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
            this.CPhoneTxt.TabIndex = 3;
            this.CPhoneTxt.TabStop = false;
            this.CPhoneTxt.Text = "(  )     -";
            this.CPhoneTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CPhoneTxt.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.CPhoneTxt.TrailingIcon = null;
            this.CPhoneTxt.UseSystemPasswordChar = false;
            this.CPhoneTxt.ValidatingType = null;
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
            this.CCPFTxt.Location = new System.Drawing.Point(23, 188);
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
            this.CCPFTxt.TabIndex = 2;
            this.CCPFTxt.TabStop = false;
            this.CCPFTxt.Tag = "2";
            this.CCPFTxt.Text = "   ,   ,   -";
            this.CCPFTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CCPFTxt.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.CCPFTxt.TrailingIcon = null;
            this.CCPFTxt.UseSystemPasswordChar = false;
            this.CCPFTxt.ValidatingType = null;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(508, 166);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(87, 19);
            this.metroLabel7.TabIndex = 17;
            this.metroLabel7.Text = "Data da visita";
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.CustomFormat = "dd/MM/yyyy";
            this.metroDateTime1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.metroDateTime1.Location = new System.Drawing.Point(508, 188);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(269, 29);
            this.metroDateTime1.TabIndex = 7;
            // 
            // CVisityHistoryListView
            // 
            this.CVisityHistoryListView.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.CVisityHistoryListView.FullRowSelect = true;
            this.CVisityHistoryListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.CVisityHistoryListView.Location = new System.Drawing.Point(508, 297);
            this.CVisityHistoryListView.Name = "CVisityHistoryListView";
            this.CVisityHistoryListView.OwnerDraw = true;
            this.CVisityHistoryListView.Size = new System.Drawing.Size(269, 203);
            this.CVisityHistoryListView.TabIndex = 8;
            this.CVisityHistoryListView.UseCompatibleStateImageBehavior = false;
            this.CVisityHistoryListView.UseSelectable = true;
            this.CVisityHistoryListView.View = System.Windows.Forms.View.List;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(508, 275);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(116, 19);
            this.metroLabel8.TabIndex = 21;
            this.metroLabel8.Text = "Histórico de visitas";
            // 
            // addVisitDateBtn
            // 
            this.addVisitDateBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addVisitDateBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.addVisitDateBtn.Depth = 0;
            this.addVisitDateBtn.HighEmphasis = true;
            this.addVisitDateBtn.Icon = null;
            this.addVisitDateBtn.Location = new System.Drawing.Point(678, 226);
            this.addVisitDateBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.addVisitDateBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.addVisitDateBtn.Name = "addVisitDateBtn";
            this.addVisitDateBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.addVisitDateBtn.Size = new System.Drawing.Size(98, 36);
            this.addVisitDateBtn.TabIndex = 22;
            this.addVisitDateBtn.Text = "Adicionar";
            this.addVisitDateBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.addVisitDateBtn.UseAccentColor = false;
            this.addVisitDateBtn.UseVisualStyleBackColor = true;
            this.addVisitDateBtn.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // helperLbl
            // 
            this.helperLbl.AutoSize = true;
            this.helperLbl.ForeColor = System.Drawing.Color.DarkRed;
            this.helperLbl.Location = new System.Drawing.Point(508, 220);
            this.helperLbl.Name = "helperLbl";
            this.helperLbl.Size = new System.Drawing.Size(0, 0);
            this.helperLbl.TabIndex = 23;
            // 
            // RegisterCustomerBtn
            // 
            this.RegisterCustomerBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RegisterCustomerBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.RegisterCustomerBtn.Depth = 0;
            this.RegisterCustomerBtn.HighEmphasis = true;
            this.RegisterCustomerBtn.Icon = null;
            this.RegisterCustomerBtn.Location = new System.Drawing.Point(609, 509);
            this.RegisterCustomerBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.RegisterCustomerBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.RegisterCustomerBtn.Name = "RegisterCustomerBtn";
            this.RegisterCustomerBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.RegisterCustomerBtn.Size = new System.Drawing.Size(168, 36);
            this.RegisterCustomerBtn.TabIndex = 24;
            this.RegisterCustomerBtn.Text = "Cadastrar Cliente";
            this.RegisterCustomerBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.RegisterCustomerBtn.UseAccentColor = false;
            this.RegisterCustomerBtn.UseVisualStyleBackColor = true;
            this.RegisterCustomerBtn.Click += new System.EventHandler(this.registerCustomer_Click);
            // 
            // NewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 553);
            this.Controls.Add(this.RegisterCustomerBtn);
            this.Controls.Add(this.helperLbl);
            this.Controls.Add(this.addVisitDateBtn);
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
            this.Name = "NewCustomer";
            this.Text = "Novo Cliente";
            this.Load += new System.EventHandler(this.NewCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox CNameTxt;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MaterialSkin.Controls.MaterialTextBox CDescTxt;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MaterialSkin.Controls.MaterialTextBox CNumVisitsTxt;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MaterialSkin.Controls.MaterialMaskedTextBox CPhoneTxt;
        private MaterialSkin.Controls.MaterialMaskedTextBox CCPFTxt;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private MetroFramework.Controls.MetroListView CVisityHistoryListView;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MaterialSkin.Controls.MaterialButton addVisitDateBtn;
        private MetroFramework.Controls.MetroLabel helperLbl;
        private MaterialSkin.Controls.MaterialButton RegisterCustomerBtn;
    }
}