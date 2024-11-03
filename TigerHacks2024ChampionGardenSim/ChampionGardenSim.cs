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
        //Holds data on all of the supported crop types
        List<Crop> supportedCrops = new List<Crop>();

        //Holds all of the active combo boxes which indicate what is planted in each row
        List<System.Windows.Forms.ComboBox> cropRowSelections = 
            new List<System.Windows.Forms.ComboBox>();

        List<Panel> cropPanels = new List<Panel>();

        PictureBox recentSim = new PictureBox();

        //number of rows calculated to be in the garden
        int rowcount = 0;

        //user selected walkway/path width using the radio buttons
        int pathwidth = 0;
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

            //Populate combo boxes with members
            populateCropComboBox(rowCropComboBox);
            populateDimensionComboBox(spaceLengthComboBox);
            populateDimensionComboBox(spaceWidthComboBox);
            populateCropComboBox(instructionCropComboBox);

            //Add default crop row to the list
            cropRowSelections.Add(rowCropComboBox);

            //Disable simulate button until dimensions have been specified.
            simulateButton.Enabled = false;

        }

        private void populateCropComboBox(System.Windows.Forms.ComboBox cb)
        {
            cb.Items.Clear();

            foreach (Crop crop in supportedCrops)
            {
                cb.Items.Add(crop.getName());
            }
        }

        private void populateDimensionComboBox(System.Windows.Forms.ComboBox cb)
        {
            cb.Items.Clear();

            for(int i = 5; i <= 25; i++)
            {
                cb.Items.Add(i.ToString());
            }
        }

        private void simulateButton_Click(object sender, EventArgs e)
        {
            simulateGarden();
        }

        private void addCropComboBox(int row)
        {
            //Create the label which indicates what row the crop is for
            Label newRowLabel = new Label();
            newRowLabel.AutoSize = true;
            newRowLabel.Location = new System.Drawing.Point(7, 13);
            newRowLabel.Name = "rowLabel";
            newRowLabel.Size = new System.Drawing.Size(112, 23);
            newRowLabel.TabIndex = 4;
            newRowLabel.Text = "Row " + row + " Crop:";

            //Create the combo box which indicates what crop for each row
            ComboBox newRowCropComboBox = new ComboBox();
            newRowCropComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            newRowCropComboBox.FormattingEnabled = true;
            newRowCropComboBox.Location = new System.Drawing.Point(109, 10);
            newRowCropComboBox.Name = "rowCropComboBox";
            newRowCropComboBox.Size = new System.Drawing.Size(121, 31);
            newRowCropComboBox.Sorted = true;
            newRowCropComboBox.TabIndex = 5;
            populateCropComboBox(newRowCropComboBox);

            //Create a panel to house these components and keep them together
            Panel newRowPanel = new Panel();
            newRowPanel.AutoScroll = true;
            newRowPanel.Controls.Add(newRowLabel);
            newRowPanel.Controls.Add(newRowCropComboBox);
            newRowPanel.Location = new System.Drawing.Point(3, 3);
            newRowPanel.Name = "row1Panel";
            newRowPanel.Size = new System.Drawing.Size(255, 56);
            newRowPanel.TabIndex = 1;

            //Add the panel to a flow panel so the user can automatically scroll through
            cropInfoFlowPanel.Controls.Add(newRowPanel);

            //Add the combo box to the list of combo boxes
            cropRowSelections.Add(newRowCropComboBox);

            cropPanels.Add(newRowPanel);
        }

        private bool attemptRowCountCalculation()
        {
            /*
             * Check step 1:
             */
            if(spaceLengthComboBox.SelectedIndex < 0 || spaceWidthComboBox.SelectedIndex < 0)
            {
                return false; //can't calculate without selecting space dimensions
            }

            /*
             * Check step 2:
             */
            if(!radio2ft.Checked && !radio3ft.Checked && !radio4ft.Checked && !radio5ft.Checked)
            {
                return false; //can't calculate without selecting walkway width
            }

            if (rowcount + 1 > 5)
                return false;

            int gardenwidth = int.Parse(spaceWidthComboBox.SelectedItem.ToString());

            if (radio2ft.Checked)
                pathwidth = 2;
            else if (radio3ft.Checked)
                pathwidth = 3;
            else if (radio4ft.Checked)
                pathwidth = 4;
            else if (radio5ft.Checked)
                pathwidth = 5;

            //totalwidth = 3(R) + P(R-1)
            //Calculation to determine the number of rows in the garden
            rowcount = (gardenwidth + pathwidth) / (3 + pathwidth);
            plantableRowsTextBox.Text = rowcount.ToString() + " Rows";

            //Sync area statistics shown at the top of the form
            syncStats();

            //Ensure there are only as many crop combo boxes as there are rows
            syncQuantityOfCropComboBoxes();

            simulateButton.Enabled = true;
            return true;
        }

        private void syncQuantityOfCropComboBoxes()
        {
            //If there are more rows than there are crop controls, add some
            while(rowcount > cropRowSelections.Count)
            {
                addCropComboBox(cropRowSelections.Count + 2);
            }

            //If there are less rows than there are crop controls, remove some
            while(rowcount < cropRowSelections.Count)
            {
                int index = cropRowSelections.Count - 1;
                cropInfoFlowPanel.Controls.Remove(cropPanels[index]);
                cropPanels.RemoveAt(index);
                cropRowSelections.RemoveAt(index);
            }

            Console.WriteLine("Combo Count = " + cropRowSelections.Count);
        }


        private void syncStats()
        {
            int gardenwidth = int.Parse(spaceWidthComboBox.SelectedItem.ToString());
            int gardenlength = int.Parse(spaceLengthComboBox.SelectedItem.ToString());
            qtotalAreaLabel.Text = "" + (gardenwidth * gardenlength);
            qGrowableAreaLabel.Text = "" + (3 * gardenlength) * rowcount;
            qWalkwayAreaLabel.Text = "" + (pathwidth * gardenlength) * (rowcount - 1);
        }

        private bool simulateGarden()
        {
            basePictureBox.Visible = false;
            recentSim.Visible = false;
            this.Controls.Remove(recentSim);
            //Create the encompassing picture box for the simulation image
            
            PictureBox gardenSim = new PictureBox();
            gardenSim.BackColor = System.Drawing.Color.LightGray;
            gardenSim.Location = new System.Drawing.Point(450, 135);
            gardenSim.Name = "basePictureBox";
            gardenSim.Size = new System.Drawing.Size(500, 500);
            gardenSim.TabIndex = 8;
            gardenSim.TabStop = false;
            gardenSim.Paint += new System.Windows.Forms.PaintEventHandler(this.gardenSim_Paint);

            recentSim = gardenSim;
            this.Controls.Add(recentSim);

            return true;
        }

        private void gardenSim_Paint(object sender, PaintEventArgs e)
        {
            //Max garden dimensions are 25ft x 25ft AKA 300" x 300"
            //gardenSim picture box is sized 600 x 600, so 2 = 1"
            int gardenlength = 12 * int.Parse(spaceLengthComboBox.SelectedItem.ToString());
            int gardenwidth = 12 * int.Parse(spaceWidthComboBox.SelectedItem.ToString());

            Brush brush = new SolidBrush(Color.Gainsboro);
            e.Graphics.FillRectangle(brush, new Rectangle(0, 0, gardenlength * 2, gardenwidth * 2));
            
            brush = new SolidBrush(Color.FromArgb(75, 75, 75));

            /*
             * Draw all of the rows 
             */
            int ylocation = 0;
            for(int r = 0; r < rowcount; r++)
            {
                e.Graphics.FillRectangle(brush, new Rectangle(0, ylocation, gardenlength * 2, 72));
                ylocation += 72 + (pathwidth * 24);
            }

           /*
            * Draw all of the seed planting locations
            */
            brush = new SolidBrush(Color.IndianRed);
            ylocation = 0;
            for (int r = 0; r < rowcount; r++)
            {
                //Simulate seed planting if they indicate that they want to plant something in the row
                if (cropRowSelections[r].SelectedIndex != -1)
                {
                    
                    //Match input to parent Crop object
                    foreach(Crop c in supportedCrops)
                    {
                        //If it's a match, draw all the seed locations and break out of the match search
                        if (c.getName().Equals(cropRowSelections[r].SelectedItem.ToString()))
                        {
                            List<Point> seedLocations = getSeedLocationsForBed(c);

                            foreach(Point p in seedLocations)
                            {
                                Console.WriteLine("MATCH WITH " + c.getName());
                                e.Graphics.FillRectangle(brush, new Rectangle(p.X, p.Y + ylocation,
                                    4, 4));
                            }
                            break;
                        }
                    }
                    //e.Graphics.FillEllipse(brush, new Rectangle(0, ylocation, 5, 5));
                }
                ylocation += 72 + (pathwidth * 24);
            }
        }

        /*
         * Generates a list of planted points
         */
        private List<Point> getSeedLocationsForBed(Crop crop)
        {
            List<Point> seedLocations = new List<Point>();

            int numPlants = 0;

            int numinnerrows = crop.getRowSpacing() <= 18 ? 2 : 1;
            int colspacing = crop.getPlantSpacing() * 2;

            int length = 24 * int.Parse(spaceLengthComboBox.SelectedItem.ToString());
            int width = 72;

            int centerX = 12 + (length % ((length - 12) / colspacing)) / 2;

            if(numinnerrows == 2)
            {
                for (int r = 1; r <= numinnerrows; r++)
                {
                    Console.WriteLine("r = " + r);
                    for (int c = centerX; c <= length - centerX; c += colspacing)
                    {
                        //Console.WriteLine("point ( " + c + " , " + r + " )");
                        seedLocations.Add(new Point(c, r * 24));
                    }
                }
            }
            else
            {
                for (int c = centerX; c <= length - centerX; c += colspacing)
                {
                    //Console.WriteLine("point ( " + c + " , " + r + " )");
                    seedLocations.Add(new Point(c, 36));
                }
            }
            

            return seedLocations;
        }


        /*
         * Anytime any of these events occur, try to recalculate the garden setup
         * 
         */
        private void spaceLengthComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            attemptRowCountCalculation();
        }

        private void spaceWidthComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            attemptRowCountCalculation();
        }

        private void radio2ft_Click(object sender, EventArgs e)
        {
            attemptRowCountCalculation();
        }

        private void radio3ft_Click(object sender, EventArgs e)
        {
            attemptRowCountCalculation();
        }

        private void radio4ft_Click(object sender, EventArgs e)
        {
            attemptRowCountCalculation();
        }

        private void radio5ft_Click(object sender, EventArgs e)
        {
            attemptRowCountCalculation();
        }

        /*
         * If they select a crop to query instructions on, show the information
         */
        private void instructionCropComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(Crop c in supportedCrops)
            {
                if (c.getName().Equals(instructionCropComboBox.SelectedItem.ToString()))
                {
                    plantSpacingLabel.Text = "Plant Spacing: " + c.getPlantSpacing() + "\"";
                    rowSpacingLabel.Text = "Row Spacing: " + c.getRowSpacing() + "\"";
                    seedDepthLabel.Text = "Seed Depth: " + c.getSeedDepth() + "\"";
                    seedsPerLabel.Text = "Seeds Planted Per Hole: " + c.getSeedsPlantedPer();
                    heavyFeederLabel.Text = "Heavy Feeder? " + (c.getIsHeavyFeeder() ? "Y": "N");
                    shadeLabel.Text = "Shade Tolerant? " + (c.getCanShade() ? "Y": "N");
                    break;
                }
            }
        }

    }
}
