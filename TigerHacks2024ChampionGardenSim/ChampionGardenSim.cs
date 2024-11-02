using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TigerHacks2024ChampionGardenSim
{
    public partial class ChampionGardenSim : Form
    {
        List<Crop> supportedCrops = new List<Crop>();
        public ChampionGardenSim()
        {
            //Name,  Plant Spacing,  Row Spacing, Seed Depth,  Seed Per,  HeavyFeed,  Shade
            supportedCrops.Add(new Crop("Onions", 4, 18, 0.25, 3, false, false));
            supportedCrops.Add(new Crop("Asparagus", 12, 36, 2, 3, false, false));
            supportedCrops.Add(new Crop("Green Beans", 3, 12, 1.5, 2, false, false));
            supportedCrops.Add(new Crop("Broccoli", 3, 24, 0.5, 3, false, true));
            supportedCrops.Add(new Crop("Cauliflower", 18, 24, 0.5, 3, false, true));
            supportedCrops.Add(new Crop("Cabbage", 18, 24, 0.5, 3, false, true));
            supportedCrops.Add(new Crop("Tomatoes", 18, 24, 0.5, 3, true, false));
            supportedCrops.Add(new Crop("Potatoes", 12, 24, 4, 1, true, true));
            supportedCrops.Add(new Crop("Bell Peppers", 18, 24, 0.5, 2, true, false));
            supportedCrops.Add(new Crop("Jalapenos", 18, 24, 0.5, 2, true, false));
            supportedCrops.Add(new Crop("Carrots", 3, 12, 0.25, 2, false, true));
            supportedCrops.Add(new Crop("Parsley", 8, 18, 0.25, 2, false, true));
            supportedCrops.Add(new Crop("Dill", 6, 18, 0.25, 3, false, true));
            supportedCrops.Add(new Crop("Zucchini", 24, 18, 1, 3, false, false));
            supportedCrops.Add(new Crop("Pumpkins", 24, 100, 1, 2, false, false));
            supportedCrops.Add(new Crop("Watermelon", 50, 100, 1, 4, false, false));
            supportedCrops.Add(new Crop("Cantaloupe", 50, 100, 1, 4, false, false));
            supportedCrops.Add(new Crop("Honeydew", 50, 100, 1, 4, false, false));
            supportedCrops.Add(new Crop("Cucumber", 12, 18, 0.5, 2, false, false));

            InitializeComponent();
            populateCropComboBox(rowCropComboBox);

        }

        private void populateCropComboBox(System.Windows.Forms.ComboBox cb)
        {
            cb.Items.Clear();

            foreach (Crop crop in supportedCrops)
            {
                cb.Items.Add(crop.getName());
            }
        }

        private void simulateButton_Click(object sender, EventArgs e)
        {
            addCropComboBox(6);
        }

        private void addCropComboBox(int row)
        {

            Label newRowLabel = new Label();

            newRowLabel.AutoSize = true;
            newRowLabel.Location = new System.Drawing.Point(7, 13);
            newRowLabel.Name = "rowLabel";
            newRowLabel.Size = new System.Drawing.Size(112, 23);
            newRowLabel.TabIndex = 4;
            newRowLabel.Text = "Row " + row + " Crop:";


            ComboBox newRowCropComboBox = new ComboBox();

            newRowCropComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            newRowCropComboBox.FormattingEnabled = true;
            newRowCropComboBox.Location = new System.Drawing.Point(125, 16);
            newRowCropComboBox.Name = "rowCropComboBox";
            newRowCropComboBox.Size = new System.Drawing.Size(121, 31);
            newRowCropComboBox.Sorted = true;
            newRowCropComboBox.TabIndex = 5;
            populateCropComboBox(newRowCropComboBox);


            Panel newRowPanel = new Panel();

            newRowPanel.AutoScroll = true;
            newRowPanel.Controls.Add(newRowLabel);
            newRowPanel.Controls.Add(newRowCropComboBox);
            newRowPanel.Location = new System.Drawing.Point(3, 3);
            newRowPanel.Name = "row1Panel";
            newRowPanel.Size = new System.Drawing.Size(255, 56);
            newRowPanel.TabIndex = 1;

            cropInfoFlowPanel.Controls.Add(newRowPanel);
        }
        
    }
}
