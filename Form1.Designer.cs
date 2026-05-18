namespace DictionaryManager
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            // ── Controls ────────────────────────────────────────────────────
            this.panelLeft = new System.Windows.Forms.Panel();
            this.lblWords = new System.Windows.Forms.Label();
            this.listBoxWords = new System.Windows.Forms.ListBox();

            this.panelRight = new System.Windows.Forms.Panel();

            this.grpCreate = new System.Windows.Forms.GroupBox();
            this.lblDictType = new System.Windows.Forms.Label();
            this.txtDictionaryType = new System.Windows.Forms.ComboBox();
            this.btnCreateDictionary = new System.Windows.Forms.Button();
            this.lblWord = new System.Windows.Forms.Label();
            this.txtWord = new System.Windows.Forms.TextBox();
            this.lblTranslation = new System.Windows.Forms.Label();
            this.txtTranslation = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnReplaceWord = new System.Windows.Forms.Button();
            this.btnReplaceTranslation = new System.Windows.Forms.Button();

            this.grpTranslations = new System.Windows.Forms.GroupBox();
            this.listBoxTranslations = new System.Windows.Forms.ListBox();
            this.btnDeleteWord = new System.Windows.Forms.Button();
            this.btnDeleteTranslation = new System.Windows.Forms.Button();

            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSaveConfirm = new System.Windows.Forms.Button();
            this.btnExportWord = new System.Windows.Forms.Button();

            // ── panelLeft ───────────────────────────────────────────────────
            this.panelLeft.BackColor = System.Drawing.Color.White;
            this.panelLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLeft.Location = new System.Drawing.Point(12, 12);
            this.panelLeft.Size = new System.Drawing.Size(220, 530);

            this.lblWords.Text = "Words";
            this.lblWords.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblWords.Location = new System.Drawing.Point(10, 10);
            this.lblWords.AutoSize = true;

            this.listBoxWords.Location = new System.Drawing.Point(5, 40);
            this.listBoxWords.Size = new System.Drawing.Size(206, 478);
            this.listBoxWords.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.listBoxWords.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxWords.SelectedIndexChanged += new System.EventHandler(this.listBoxWords_SelectedIndexChanged);

            this.panelLeft.Controls.Add(this.lblWords);
            this.panelLeft.Controls.Add(this.listBoxWords);

            // ── grpCreate ───────────────────────────────────────────────────
            this.grpCreate.Text = "Create Dictionary";
            this.grpCreate.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpCreate.Location = new System.Drawing.Point(246, 12);
            this.grpCreate.Size = new System.Drawing.Size(720, 240);
            this.grpCreate.BackColor = System.Drawing.Color.White;

            // Dictionary Type row
            this.lblDictType.Text = "Dictionary Type:";
            this.lblDictType.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblDictType.Location = new System.Drawing.Point(20, 35);
            this.lblDictType.AutoSize = true;

            this.txtDictionaryType.Items.AddRange(new object[] {
                "English-Russian", "English-French", "English-Spanish", "English-German",
                "English-Italian", "English-Portuguese", "English-Chinese", "English-Japanese",
                "English-Korean", "English-Arabic", "Russian-English",
                "French-English", "Spanish-English" });
            this.txtDictionaryType.Text = "English-Russian";
            this.txtDictionaryType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.txtDictionaryType.Location = new System.Drawing.Point(160, 32);
            this.txtDictionaryType.Size = new System.Drawing.Size(390, 26);
            this.txtDictionaryType.Font = new System.Drawing.Font("Segoe UI", 9.5F);

            this.btnCreateDictionary.Text = "Create Dictionary";
            this.btnCreateDictionary.Location = new System.Drawing.Point(562, 30);
            this.btnCreateDictionary.Size = new System.Drawing.Size(140, 30);
            this.btnCreateDictionary.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.btnCreateDictionary.ForeColor = System.Drawing.Color.White;
            this.btnCreateDictionary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateDictionary.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnCreateDictionary.FlatAppearance.BorderSize = 0;
            this.btnCreateDictionary.Click += new System.EventHandler(this.btnCreateDictionary_Click);

            // Word row
            this.lblWord.Text = "Word:";
            this.lblWord.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblWord.Location = new System.Drawing.Point(20, 80);
            this.lblWord.AutoSize = true;

            this.txtWord.Location = new System.Drawing.Point(160, 77);
            this.txtWord.Size = new System.Drawing.Size(540, 26);
            this.txtWord.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtWord.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtWord_KeyDown);

            // Translation row
            this.lblTranslation.Text = "Translation:";
            this.lblTranslation.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblTranslation.Location = new System.Drawing.Point(20, 125);
            this.lblTranslation.AutoSize = true;

            this.txtTranslation.Location = new System.Drawing.Point(160, 122);
            this.txtTranslation.Size = new System.Drawing.Size(540, 26);
            this.txtTranslation.Font = new System.Drawing.Font("Segoe UI", 9.5F);

            // Action buttons row
            this.btnAdd.Text = "Add";
            this.btnAdd.Location = new System.Drawing.Point(160, 168);
            this.btnAdd.Size = new System.Drawing.Size(120, 36);
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            this.btnReplaceWord.Text = "Replace Word";
            this.btnReplaceWord.Location = new System.Drawing.Point(292, 168);
            this.btnReplaceWord.Size = new System.Drawing.Size(130, 36);
            this.btnReplaceWord.BackColor = System.Drawing.Color.FromArgb(255, 140, 0);
            this.btnReplaceWord.ForeColor = System.Drawing.Color.White;
            this.btnReplaceWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReplaceWord.FlatAppearance.BorderSize = 0;
            this.btnReplaceWord.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnReplaceWord.Click += new System.EventHandler(this.btnReplaceWord_Click);

            this.btnReplaceTranslation.Text = "Replace Translation";
            this.btnReplaceTranslation.Location = new System.Drawing.Point(434, 168);
            this.btnReplaceTranslation.Size = new System.Drawing.Size(160, 36);
            this.btnReplaceTranslation.BackColor = System.Drawing.Color.FromArgb(255, 140, 0);
            this.btnReplaceTranslation.ForeColor = System.Drawing.Color.White;
            this.btnReplaceTranslation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReplaceTranslation.FlatAppearance.BorderSize = 0;
            this.btnReplaceTranslation.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnReplaceTranslation.Click += new System.EventHandler(this.btnReplaceTranslation_Click);

            this.grpCreate.Controls.Add(this.lblDictType);
            this.grpCreate.Controls.Add(this.txtDictionaryType);
            this.grpCreate.Controls.Add(this.btnCreateDictionary);
            this.grpCreate.Controls.Add(this.lblWord);
            this.grpCreate.Controls.Add(this.txtWord);
            this.grpCreate.Controls.Add(this.lblTranslation);
            this.grpCreate.Controls.Add(this.txtTranslation);
            this.grpCreate.Controls.Add(this.btnAdd);
            this.grpCreate.Controls.Add(this.btnReplaceWord);
            this.grpCreate.Controls.Add(this.btnReplaceTranslation);

            // ── grpTranslations ─────────────────────────────────────────────
            this.grpTranslations.Text = "Translations";
            this.grpTranslations.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpTranslations.Location = new System.Drawing.Point(246, 265);
            this.grpTranslations.Size = new System.Drawing.Size(720, 225);
            this.grpTranslations.BackColor = System.Drawing.Color.White;

            this.listBoxTranslations.Location = new System.Drawing.Point(20, 25);
            this.listBoxTranslations.Size = new System.Drawing.Size(340, 150);
            this.listBoxTranslations.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.listBoxTranslations.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxTranslations.SelectedIndexChanged += new System.EventHandler(this.listBoxTranslations_SelectedIndexChanged);

            this.btnDeleteWord.Text = "Delete Word";
            this.btnDeleteWord.Location = new System.Drawing.Point(20, 185);
            this.btnDeleteWord.Size = new System.Drawing.Size(130, 34);
            this.btnDeleteWord.BackColor = System.Drawing.Color.FromArgb(200, 40, 40);
            this.btnDeleteWord.ForeColor = System.Drawing.Color.White;
            this.btnDeleteWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteWord.FlatAppearance.BorderSize = 0;
            this.btnDeleteWord.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnDeleteWord.Click += new System.EventHandler(this.btnDeleteWord_Click);

            this.btnDeleteTranslation.Text = "Delete Translation";
            this.btnDeleteTranslation.Location = new System.Drawing.Point(162, 185);
            this.btnDeleteTranslation.Size = new System.Drawing.Size(155, 34);
            this.btnDeleteTranslation.BackColor = System.Drawing.Color.FromArgb(200, 40, 40);
            this.btnDeleteTranslation.ForeColor = System.Drawing.Color.White;
            this.btnDeleteTranslation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteTranslation.FlatAppearance.BorderSize = 0;
            this.btnDeleteTranslation.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnDeleteTranslation.Click += new System.EventHandler(this.btnDeleteTranslation_Click);

            this.grpTranslations.Controls.Add(this.listBoxTranslations);
            this.grpTranslations.Controls.Add(this.btnDeleteWord);
            this.grpTranslations.Controls.Add(this.btnDeleteTranslation);

            // ── Bottom bar buttons ──────────────────────────────────────────
            int bottomY = 508;

            this.btnSearch.Text = "Search";
            this.btnSearch.Location = new System.Drawing.Point(350, bottomY);
            this.btnSearch.Size = new System.Drawing.Size(90, 34);
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

            this.btnSave.Text = "Load";
            this.btnSave.Location = new System.Drawing.Point(452, bottomY);
            this.btnSave.Size = new System.Drawing.Size(90, 34);
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnSave.Click += new System.EventHandler(this.btnLoad_Click);

            this.btnSaveConfirm.Text = "✔ Save";
            this.btnSaveConfirm.Location = new System.Drawing.Point(554, bottomY);
            this.btnSaveConfirm.Size = new System.Drawing.Size(100, 34);
            this.btnSaveConfirm.BackColor = System.Drawing.Color.FromArgb(34, 180, 76);
            this.btnSaveConfirm.ForeColor = System.Drawing.Color.White;
            this.btnSaveConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveConfirm.FlatAppearance.BorderSize = 0;
            this.btnSaveConfirm.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSaveConfirm.Click += new System.EventHandler(this.btnSaveConfirm_Click);

            this.btnExportWord.Text = "Export Word";
            this.btnExportWord.Location = new System.Drawing.Point(666, bottomY);
            this.btnExportWord.Size = new System.Drawing.Size(110, 34);
            this.btnExportWord.BackColor = System.Drawing.Color.FromArgb(100, 50, 180);
            this.btnExportWord.ForeColor = System.Drawing.Color.White;
            this.btnExportWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportWord.FlatAppearance.BorderSize = 0;
            this.btnExportWord.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnExportWord.Click += new System.EventHandler(this.btnExportWord_Click);

            // ── Form ────────────────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 560);
            this.Text = "Multilanguage Dictionary Manager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.FromArgb(235, 240, 248);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // Header bar
            this.headerPanel = new System.Windows.Forms.Panel();
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(30, 100, 200);
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Size = new System.Drawing.Size(984, 40);
            this.headerLabel = new System.Windows.Forms.Label();
            this.headerLabel.Text = "Multilanguage Dictionary Manager";
            this.headerLabel.ForeColor = System.Drawing.Color.White;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.headerLabel.AutoSize = true;
            this.headerLabel.Location = new System.Drawing.Point(12, 10);
            this.headerPanel.Controls.Add(this.headerLabel);

            // Re-position everything below header
            this.panelLeft.Location = new System.Drawing.Point(12, 52);
            this.grpCreate.Location = new System.Drawing.Point(246, 52);
            this.grpTranslations.Location = new System.Drawing.Point(246, 305);
            this.ClientSize = new System.Drawing.Size(984, 600);

            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.grpCreate);
            this.Controls.Add(this.grpTranslations);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSaveConfirm);
            this.Controls.Add(this.btnExportWord);

            // Reposition bottom buttons
            bottomY = 550;
            this.btnSearch.Top = bottomY;
            this.btnSave.Top = bottomY;
            this.btnSaveConfirm.Top = bottomY;
            this.btnExportWord.Top = bottomY;
        }
        #endregion

        // ── Control declarations ─────────────────────────────────────────────
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label lblWords;
        private System.Windows.Forms.ListBox listBoxWords;
        private System.Windows.Forms.GroupBox grpCreate;
        private System.Windows.Forms.Label lblDictType;
        private System.Windows.Forms.ComboBox txtDictionaryType;
        private System.Windows.Forms.Button btnCreateDictionary;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.Label lblTranslation;
        private System.Windows.Forms.TextBox txtTranslation;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnReplaceWord;
        private System.Windows.Forms.Button btnReplaceTranslation;
        private System.Windows.Forms.GroupBox grpTranslations;
        private System.Windows.Forms.ListBox listBoxTranslations;
        private System.Windows.Forms.Button btnDeleteWord;
        private System.Windows.Forms.Button btnDeleteTranslation;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSaveConfirm;
        private System.Windows.Forms.Button btnExportWord;
        private System.Windows.Forms.Panel panelRight;
    }
}