using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DictionaryManager
{
    public partial class Form1 : Form
    {
        // ── Data model ───────────────────────────────────────────────────────
        private Dictionary<string, List<string>> _dictionary =
            new Dictionary<string, List<string>>(StringComparer.OrdinalIgnoreCase);
        private string _dictionaryType = "English-Russian";
        private string _selectedWord = null;
        private string _selectedTranslation = null;

        // Silent save path: same folder as .exe, named after the dictionary type
        private string AutoSavePath =>
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
                         _dictionaryType.Replace("-", "_") + "_dictionary.txt");

        public Form1()
        {
            InitializeComponent();
            LoadSampleData();
            RefreshWordList();
        }

        // ── Sample data ──────────────────────────────────────────────────────
        private void LoadSampleData()
        {
            _dictionary["hello"] = new List<string> { "привет", "здравствуйте" };
            _dictionary["world"] = new List<string> { "мир" };
            _dictionary["book"] = new List<string> { "книга" };
            _dictionary["friend"] = new List<string> { "друг", "приятель" };
        }

        // ── Refresh helpers ──────────────────────────────────────────────────
        private void RefreshWordList(string filter = null)
        {
            listBoxWords.Items.Clear();
            var keys = _dictionary.Keys
                .Where(k => filter == null || k.IndexOf(filter, StringComparison.OrdinalIgnoreCase) >= 0)
                .OrderBy(k => k);

            foreach (var k in keys)
                listBoxWords.Items.Add(k);

            if (_selectedWord != null && listBoxWords.Items.Contains(_selectedWord))
                listBoxWords.SelectedItem = _selectedWord;
            else
                ClearTranslations();
        }

        private void RefreshTranslations()
        {
            listBoxTranslations.Items.Clear();
            _selectedTranslation = null;
            if (_selectedWord != null && _dictionary.TryGetValue(_selectedWord, out var list))
                foreach (var t in list)
                    listBoxTranslations.Items.Add(t);
        }

        private void ClearTranslations()
        {
            listBoxTranslations.Items.Clear();
            _selectedTranslation = null;
        }

        // ── Create Dictionary ────────────────────────────────────────────────
        private void btnCreateDictionary_Click(object sender, EventArgs e)
        {
            string newType = txtDictionaryType.Text.Trim();
            if (string.IsNullOrWhiteSpace(newType))
            {
                MessageBox.Show("Please enter a dictionary type.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show($"Create a new '{newType}' dictionary? This will clear all current entries.",
                    "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _dictionaryType = newType;
                _dictionary.Clear();
                _selectedWord = null;
                RefreshWordList();
                this.Text = "Multilanguage Dictionary Manager";
                MessageBox.Show($"Dictionary '{_dictionaryType}' created.", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // ── Add ──────────────────────────────────────────────────────────────
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string word = txtWord.Text.Trim();
            string trans = txtTranslation.Text.Trim();

            if (string.IsNullOrWhiteSpace(word))
            {
                MessageBox.Show("Please enter a word.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            if (string.IsNullOrWhiteSpace(trans))
            {
                MessageBox.Show("Please enter a translation.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }

            if (!_dictionary.ContainsKey(word))
                _dictionary[word] = new List<string>();

            if (!_dictionary[word].Contains(trans, StringComparer.OrdinalIgnoreCase))
            {
                _dictionary[word].Add(trans);
                _selectedWord = word;
                RefreshWordList();
                RefreshTranslations();
                txtWord.Clear();
                txtTranslation.Clear();
            }
            else
                MessageBox.Show("This translation already exists.", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ── Replace Word ─────────────────────────────────────────────────────
        private void btnReplaceWord_Click(object sender, EventArgs e)
        {
            if (_selectedWord == null)
            {
                MessageBox.Show("Please select a word first.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            string newWord = txtWord.Text.Trim();
            if (string.IsNullOrWhiteSpace(newWord))
            {
                MessageBox.Show("Enter the new word in the Word field.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            if (_dictionary.ContainsKey(newWord) &&
                !newWord.Equals(_selectedWord, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show($"Word '{newWord}' already exists.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }

            var translations = _dictionary[_selectedWord];
            _dictionary.Remove(_selectedWord);
            _dictionary[newWord] = translations;
            _selectedWord = newWord;
            RefreshWordList();
            RefreshTranslations();
            txtWord.Clear();
        }

        // ── Replace Translation ──────────────────────────────────────────────
        private void btnReplaceTranslation_Click(object sender, EventArgs e)
        {
            if (_selectedWord == null)
            {
                MessageBox.Show("Please select a word first.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            if (_selectedTranslation == null)
            {
                MessageBox.Show("Please select a translation first.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            string newTrans = txtTranslation.Text.Trim();
            if (string.IsNullOrWhiteSpace(newTrans))
            {
                MessageBox.Show("Enter the new translation in the Translation field.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }

            var list = _dictionary[_selectedWord];
            int idx = list.FindIndex(t => t.Equals(_selectedTranslation, StringComparison.OrdinalIgnoreCase));
            if (idx >= 0)
            {
                list[idx] = newTrans;
                _selectedTranslation = newTrans;
                RefreshTranslations();
                listBoxTranslations.SelectedItem = newTrans;
                txtTranslation.Clear();
            }
        }

        // ── Delete Word ──────────────────────────────────────────────────────
        private void btnDeleteWord_Click(object sender, EventArgs e)
        {
            if (_selectedWord == null)
            {
                MessageBox.Show("Please select a word to delete.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            if (MessageBox.Show($"Delete word '{_selectedWord}' and all its translations?",
                    "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _dictionary.Remove(_selectedWord);
                _selectedWord = null;
                RefreshWordList();
                ClearTranslations();
            }
        }

        // ── Delete Translation ───────────────────────────────────────────────
        private void btnDeleteTranslation_Click(object sender, EventArgs e)
        {
            if (_selectedWord == null || _selectedTranslation == null)
            {
                MessageBox.Show("Please select a word and a translation first.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            _dictionary[_selectedWord].Remove(_selectedTranslation);
            _selectedTranslation = null;
            RefreshTranslations();
        }

        // ── Search ───────────────────────────────────────────────────────────
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string query = txtWord.Text.Trim();
            RefreshWordList(string.IsNullOrWhiteSpace(query) ? null : query);
        }

        // ── LOAD button — opens OpenFileDialog, no silent save ───────────────
        private void btnLoad_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Load Dictionary";
                dlg.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                if (dlg.ShowDialog() != DialogResult.OK) return;

                try
                {
                    var lines = File.ReadAllLines(dlg.FileName, Encoding.UTF8);
                    var loaded = new Dictionary<string, List<string>>(StringComparer.OrdinalIgnoreCase);
                    string ldType = _dictionaryType;

                    foreach (var line in lines)
                    {
                        if (string.IsNullOrWhiteSpace(line)) continue;
                        if (line.StartsWith("# Dictionary Type:"))
                        {
                            ldType = line.Replace("# Dictionary Type:", "").Trim();
                            continue;
                        }
                        int eq = line.IndexOf('=');
                        if (eq < 0) continue;
                        string word = line.Substring(0, eq).Trim();
                        string trans = line.Substring(eq + 1).Trim();
                        loaded[word] = new List<string>(trans.Split('|'));
                    }

                    _dictionary = loaded;
                    _dictionaryType = ldType;
                    _selectedWord = null;
                    txtDictionaryType.Text = _dictionaryType;
                    RefreshWordList();
                    ClearTranslations();
                    MessageBox.Show("Dictionary loaded successfully.", "Loaded",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to load file:\n{ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // ── ✔ SAVE button — silently saves to app folder, NO dialog at all ───
        private void btnSaveConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                var sb = new StringBuilder();
                sb.AppendLine($"# Dictionary Type: {_dictionaryType}");
                foreach (var pair in _dictionary.OrderBy(p => p.Key))
                    sb.AppendLine($"{pair.Key}={string.Join("|", pair.Value)}");

                File.WriteAllText(AutoSavePath, sb.ToString(), Encoding.UTF8);

                // No popup — update title bar only
                this.Text = "Multilanguage Dictionary Manager  [✔ Saved]";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to save:\n{ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ── Export Word ──────────────────────────────────────────────────────
        private void btnExportWord_Click(object sender, EventArgs e)
        {
            if (_selectedWord == null)
            {
                MessageBox.Show("Please select a word to export.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }

            using (SaveFileDialog dlg = new SaveFileDialog())
            {
                dlg.Title = "Export Word";
                dlg.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                dlg.FileName = _selectedWord + "_export.txt";
                if (dlg.ShowDialog() != DialogResult.OK) return;

                var sb = new StringBuilder();
                sb.AppendLine($"Word: {_selectedWord}");
                sb.AppendLine($"Dictionary: {_dictionaryType}");
                sb.AppendLine("Translations:");
                foreach (var t in _dictionary[_selectedWord])
                    sb.AppendLine($"  - {t}");

                File.WriteAllText(dlg.FileName, sb.ToString(), Encoding.UTF8);
                MessageBox.Show($"Word '{_selectedWord}' exported.", "Exported",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // ── ListBox events ───────────────────────────────────────────────────
        private void listBoxWords_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxWords.SelectedItem is string word)
            {
                _selectedWord = word;
                txtWord.Text = word;
                RefreshTranslations();
            }
        }

        private void listBoxTranslations_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxTranslations.SelectedItem is string trans)
            {
                _selectedTranslation = trans;
                txtTranslation.Text = trans;
            }
        }

        // ── Search on Enter key ──────────────────────────────────────────────
        private void txtWord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                btnSearch_Click(sender, e);
        }
    }
}