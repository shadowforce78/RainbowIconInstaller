using FlatUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RainbowIconInstaller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void flatClose1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            FBD.Description = "Select Geometry Dash Folder";

            // Afficher le dialog
            if (FBD.ShowDialog() == DialogResult.OK)
            {
                // Vérifier si le dossier sélectionné correspond au nom requis
                if (new DirectoryInfo(FBD.SelectedPath).Name.ToLower() == "geometry dash")
                {
                    // Si oui, mettre à jour le label avec le chemin sélectionné
                    label1.Text = "Geometry Dash Found";
                    label1.ForeColor = Color.LightGreen;
                    MessageBox.Show(FBD.SelectedPath, "Geometry Dash Folder", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Si non, afficher un message d'erreur
                    MessageBox.Show("Plesae select the Geometry Dash folder", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Mod path 
            string modPath = "\\geode\\unzipped\\saumondeluxe.rainbow_icon\\mod.json";
            string path = FBD.SelectedPath + modPath;
            if (File.Exists(path))
            {
                // Get the mod.json file
                string modJson = File.ReadAllText(path);
                // Find the version value
                string version = modJson.Split(new string[] { "\"version\":" }, StringSplitOptions.None)[1].Split(',')[0];
                label2.Text = "Actual version of the mod : " + version;
            }
            else
            {
                MessageBox.Show("Mod not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
