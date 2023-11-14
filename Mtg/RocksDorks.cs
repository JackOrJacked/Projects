using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mtg
{
    public partial class RocksDorks : Form
    {
        public RocksDorks()
        {
            InitializeComponent();
        }

        private Form1 mainForm = null;
        public RocksDorks(Form callingForm)
        {
            mainForm = callingForm as Form1;
            InitializeComponent();
            this.BackColor = DarkMode.FormBackColor;
            this.ForeColor = DarkMode.ForeColor;

            foreach (Control control in this.Controls)
            {
                control.BackColor = DarkMode.BackColor;
                control.ForeColor = DarkMode.ForeColor;

                if (control is Button)
                {
                    control.BackColor = DarkMode.ButtonBackColor;
                    control.ForeColor = DarkMode.ButtonForeColor;
                }

            }
        }
        private void BtnInvia_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> RocksChecked = GetCheckedCheckBoxesRocks();
                List<string> Colorcheckeds = GetCheckedCheckBoxesColor();
                List<string> NomiRocks = GetRocksdName(RocksChecked, Colorcheckeds);
                //Form1.landissime = string.Join("$",NomiLande);
                mainForm.AggiungiADeck(string.Join("$", NomiRocks), true);
            }
            catch (Exception)
            {
            }
            Visible = false;
        }
        private List<string> GetCheckedCheckBoxesRocks()
        {
            List<string> checkedOptions = new List<string>();

            foreach (Control control in groupBox1.Controls)
            {
                if (control is CheckBox checkbox && checkbox.Checked)
                {
                    checkedOptions.Add(checkbox.Text);
                }
            }
            foreach (Control control in groupBox2.Controls)
            {
                if (control is CheckBox checkbox && checkbox.Checked)
                {
                    checkedOptions.Add(checkbox.Text);
                }
            }
            return checkedOptions;
        }
        private List<string> GetCheckedCheckBoxesColor()
        {
            List<string> checkedOptions = new List<string>();

            foreach (Control control in mainForm.Controls)
            {
                if (control.Name == "panel2")
                {
                    foreach (Control check in control.Controls)
                    {
                        if (check is CheckBox checkbox && checkbox.Checked)
                        {
                            checkedOptions.Add(checkbox.Text);
                        }
                    }

                }

            }
            return checkedOptions;
        }

        private List<string> GetRocksdName(List<string> Landcheckeds, List<string> Colorcheckeds)
        {
            List<string> colors = new List<string> { "W", "U", "B", "R", "G" };

            colors.RemoveAll(c => Colorcheckeds.Contains(c));
            // Carica il file JSON come stringa (sostituisci "path_to_file" con il percorso effettivo del tuo file JSON)
            string json = System.IO.File.ReadAllText("Rocks.json");

            // Deserializza la stringa JSON in un oggetto JObject
            JObject data = JObject.Parse(json);

            // Crea una lista per memorizzare i nomi degli elementi corrispondenti
            List<string> matchedNames = new List<string>();

            // Itera su ogni nome di array specificato nella lista "Landcheckeds"
            foreach (string landChecked in Landcheckeds)
            {
                // Ottieni l'array di land corrispondente dal JObject
                JArray landArray = (JArray)data[landChecked];

                // Se l'array di land è stato trovato, cerca gli elementi corrispondenti in base al colore
                if (landArray != null)
                {
                    foreach (JObject land in landArray)
                    {
                        string nome = (string)land["nome"];
                        string colore = (string)land["colore"];

                        // Verifica se il colore non è presente nella lista "Colorcheckeds"
                        if (!colors.Any(colore.Contains))
                        {
                            matchedNames.Add(nome);
                        }
                    }
                }
            }

            return matchedNames;
        }

        private void CBCommander_Click(object sender, EventArgs e)
        {
            if (!(sender as CheckBox).Checked)
            {
                (sender as CheckBox).ForeColor = Color.Red;
                (sender as CheckBox).BackColor = Color.Red;
            }
            else
            {
                (sender as CheckBox).ForeColor = Color.Green;
                (sender as CheckBox).BackColor = Color.Green;
            }

        }

        private void RBtutti_CheckedChanged(object sender, EventArgs e)
        {
            if (RBtutti.Checked)
            {
                foreach (Control control in groupBox1.Controls)
                {
                    if (control is CheckBox)
                    {
                        (control as CheckBox).Checked = true;
                        (control as CheckBox).BackColor = Color.Green;
                        (control as CheckBox).ForeColor = Color.Green;
                    }
                    
                }
                foreach (Control control in groupBox2.Controls)
                {
                    if (control is CheckBox)
                    {
                        (control as CheckBox).Checked = true;
                        (control as CheckBox).BackColor = Color.Green;
                        (control as CheckBox).ForeColor = Color.Green;
                    }

                }
            }
        }

        private void RBnessuno_CheckedChanged(object sender, EventArgs e)
        {
            if (RBnessuno.Checked)
            {
                foreach (Control control in groupBox1.Controls)
                {
                    if (control is CheckBox)
                    {
                        (control as CheckBox).Checked = false;
                        (control as CheckBox).BackColor = Color.Red;
                        (control as CheckBox).ForeColor = Color.Red;
                    }
                }
                foreach (Control control in groupBox2.Controls)
                {
                    if (control is CheckBox)
                    {
                        (control as CheckBox).Checked = false;
                        (control as CheckBox).BackColor = Color.Red;
                        (control as CheckBox).ForeColor = Color.Red;
                    }
                }
            }
        }

        private void RocksDorks_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
